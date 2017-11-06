using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using SOC.Classes;

namespace SOC.UI
{
    public partial class FormMain : Form
    {
        private Setup setupPage = new Setup();
        private Details detailPage;
        private int panelNum = 0;

        public FormMain()
        {
            InitializeComponent();
            panelMain.Controls.Add(setupPage);
            buttonBack.Visible = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            panelNum++;
            this.GoToPanel();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelNum--;
            this.GoToPanel();
        }

        private void GoToPanel()
        {
            switch (panelNum)
            {
                case 0:
                    buttonBack.Visible = false;
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(setupPage);
                    buttonNext.Text = "Next >>";
                    break;

                case 1:
                    List<Coordinates> HostageCoords = BuildCoordinatesList(setupPage.textBoxHosCoords.Text);
                    List<Coordinates> VehicleCoords = BuildCoordinatesList(setupPage.textBoxVehCoords.Text);
                    List<Coordinates> ItemCoords = BuildCoordinatesList(setupPage.textBoxItemCoords.Text);
                    List<Coordinates> ModelCoords = BuildCoordinatesList(setupPage.textBoxStMdCoords.Text);
                    detailPage = new Details(HostageCoords, VehicleCoords, ItemCoords, ModelCoords);

                    buttonBack.Visible = true;
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(detailPage);
                    buttonNext.Text = "Build";
                    break;

                case 2:
                    QuestDefinitionLua definitionInfo = new QuestDefinitionLua(setupPage.textBoxFPKName.Text, setupPage.textBoxQuestNum.Text, setupPage.locationID, setupPage.comboBoxLoadArea.Text, new Coordinates(setupPage.textBoxXCoord.Text, setupPage.textBoxYCoord.Text, setupPage.textBoxZCoord.Text), setupPage.comboBoxRadius.Text, setupPage.comboBoxCategory.Text, setupPage.comboBoxReward.Text, setupPage.comboBoxProgressNotifs.SelectedIndex, setupPage.comboBoxObjective.Text, setupPage.comboBoxCP.Text, setupPage.textBoxQuestTitle.Text, setupPage.textBoxQuestDesc.Text); //string fpk, string quest, int locID, object loada, Coordinates c, string rad, string cat, string rew, int prog)
                    LangBuilder.WriteQuestLangs(definitionInfo);

                    LuaBuilder.WriteDefinitionLua(definitionInfo, detailPage.questDetails, detailPage.comboBox_Gender.Text);
                    LuaBuilder.WriteMainQuestLua(definitionInfo, detailPage.questDetails, detailPage.h_checkBox_intrgt.Checked, detailPage.comboBox_Gender.Text);

                    Fox2Builder.WriteItemFox2(definitionInfo, detailPage.questDetails);
                    Fox2Builder.WriteQuestFox2(definitionInfo, detailPage.questDetails, detailPage.comboBox_Gender.Text);

                    AssetsBuilder.BuildFPKAssets(definitionInfo, detailPage.questDetails);
                    AssetsBuilder.BuildFPKDAssets(definitionInfo, detailPage.questDetails);
                    panelNum--;
                    break;
                    
            }
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            detailPage.Height = this.Height - 100;
            detailPage.Width = this.Width - 42;
            detailPage.groupHosDet.Width = detailPage.Width / 4 - 3;
            detailPage.groupVehDet.Left = detailPage.groupHosDet.Location.X + detailPage.groupHosDet.Size.Width + 3;
            detailPage.groupVehDet.Width = detailPage.Width / 4 - 3;
            detailPage.groupItemDet.Left = detailPage.groupVehDet.Location.X + detailPage.groupVehDet.Size.Width + 3;
            detailPage.groupItemDet.Width = detailPage.Width / 4 - 3;
            detailPage.groupStMdDet.Left = detailPage.groupItemDet.Location.X + detailPage.groupItemDet.Size.Width + 3;
            detailPage.groupStMdDet.Width = detailPage.Width / 4 - 3;
        }

        public static List<Coordinates> BuildCoordinatesList(string rawString)
        {
            List<Coordinates> coordList = new List<Coordinates>();
            Coordinates coords;
            string coordPattern = @"-?\d+([.]\d+)?";

            MatchCollection matches = Regex.Matches(rawString, coordPattern);
            var list = matches.Cast<Match>().Select(match => match.Value).ToList();
            while (list.Count % 3 != 0)
            {
                list.Add("0.00");
            }
            for (int i = 0; i < list.Count; i += 3)
            {
                coords = new Coordinates(list[i], list[i + 1], list[i + 2]);
                coordList.Add(coords);
            }

            return coordList;
        }
    }
}
