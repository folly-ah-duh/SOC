using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SOC.Classes;
using static SOC.QuestComponents.GameObjectInfo;

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
            GoToPanel();
            Forms.PanelScroll CoordsScrolling = new Forms.PanelScroll(setupPage.panel1, false);
            Application.AddMessageFilter(CoordsScrolling);
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
        private bool isFilled()
        {
            //return true; // FOR DEBUG
            if (string.IsNullOrEmpty(setupPage.textBoxFPKName.Text) || string.IsNullOrEmpty(setupPage.textBoxQuestNum.Text) || string.IsNullOrEmpty(setupPage.textBoxQuestTitle.Text) || string.IsNullOrEmpty(setupPage.textBoxQuestDesc.Text))
                return false;
            if (setupPage.comboBoxCategory.SelectedIndex == -1 || setupPage.comboBoxReward.SelectedIndex == -1 || setupPage.comboBoxObjective.SelectedIndex == -1 || setupPage.comboBoxProgressNotifs.SelectedIndex == -1 || setupPage.comboBoxRegion.SelectedIndex == -1)
                return false;
            if (setupPage.comboBoxCP.Enabled)
                if (setupPage.comboBoxCP.SelectedIndex == -1 || setupPage.comboBoxLoadArea.SelectedIndex == -1 || setupPage.comboBoxRadius.SelectedIndex == -1 || string.IsNullOrEmpty(setupPage.textBoxXCoord.Text) || string.IsNullOrEmpty(setupPage.textBoxYCoord.Text) || string.IsNullOrEmpty(setupPage.textBoxZCoord.Text))
                    return false;

            return true;
        }
        private void GoToPanel()
        {
            

            switch (panelNum)
            {
                case 0:
                    buttonBack.Visible = false;
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(setupPage);
                    setupPage.EnableScrolling();
                    buttonNext.Text = "Next >>";
                    this.Width = 1120;
                    break;

                case 1:
                    if (isFilled())
                    {
                        setupPage.DisableScrolling();
                        List<Coordinates> HostageCoords = BuildCoordinatesList(setupPage.textBoxHosCoords.Text);
                        List<Coordinates> VehicleCoords = BuildCoordinatesList(setupPage.textBoxVehCoords.Text);
                        List<Coordinates> ItemCoords = BuildCoordinatesList(setupPage.textBoxItemCoords.Text);
                        List<Coordinates> ModelCoords = BuildCoordinatesList(setupPage.textBoxStMdCoords.Text);
                        List<Coordinates> activeItemCoords = BuildCoordinatesList(setupPage.textBox_ActiveItem.Text);
                        List<Coordinates> AnimalCoords = BuildCoordinatesList(setupPage.textBox_Animal.Text);
                        detailPage = new Details(HostageCoords, VehicleCoords, ItemCoords, ModelCoords, activeItemCoords, AnimalCoords);
                        buttonBack.Visible = true;
                        panelMain.Controls.Clear();
                        panelMain.Controls.Add(detailPage);
                        buttonNext.Text = "Build";
                        this.Width = 1180;
                    }
                    else
                    {
                        MessageBox.Show("Please fill in the remaining Setup and Flavor Text fields.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panelNum--;
                        return;
                    }
                    
                    break;

                case 2:
                    DefinitionDetails definitionDetails = new DefinitionDetails(setupPage.textBoxFPKName.Text, setupPage.textBoxQuestNum.Text, setupPage.locationID, setupPage.comboBoxLoadArea.Text, new Coordinates(setupPage.textBoxXCoord.Text, setupPage.textBoxYCoord.Text, setupPage.textBoxZCoord.Text), setupPage.comboBoxRadius.Text, setupPage.comboBoxCategory.Text, setupPage.comboBoxReward.Text, setupPage.comboBoxProgressNotifs.SelectedIndex, setupPage.comboBoxObjective.Text, setupPage.comboBoxCP.Text, setupPage.textBoxQuestTitle.Text, setupPage.textBoxQuestDesc.Text); //string fpk, string quest, int locID, object loada, Coordinates c, string rad, string cat, string rew, int prog)
                    QuestDetails questDetails = detailPage.getQuestDetails();

                    LangBuilder.WriteQuestLangs(definitionDetails);

                    LuaBuilder.WriteDefinitionLua(definitionDetails, questDetails);
                    LuaBuilder.WriteMainQuestLua(definitionDetails, questDetails);

                    Fox2Builder.WriteItemFox2(definitionDetails, questDetails);
                    Fox2Builder.WriteQuestFox2(definitionDetails, questDetails);

                    AssetsBuilder.BuildFPKAssets(definitionDetails, questDetails);
                    AssetsBuilder.BuildFPKDAssets(definitionDetails, questDetails);

                    MessageBox.Show("Build Complete", "Sideop Companion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelNum--;
                    break;
                    
            }
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            int maxPanelWidth = 314;
            detailPage.Height = this.Height - 100;
            detailPage.Width = this.Width - 42;
            int dynamicPanelWidth = detailPage.Width / 4;

            if (dynamicPanelWidth >= maxPanelWidth)
                dynamicPanelWidth = maxPanelWidth;

            detailPage.groupHosDet.Width = dynamicPanelWidth;
            detailPage.groupVehDet.Width = dynamicPanelWidth;
            detailPage.groupItemDet.Width = dynamicPanelWidth;
            detailPage.groupStMdDet.Width = dynamicPanelWidth;
            detailPage.groupAcItDet.Width = dynamicPanelWidth;
            detailPage.groupAnimalDet.Width = dynamicPanelWidth;

            detailPage.groupVehDet.Left = detailPage.groupHosDet.Location.X + dynamicPanelWidth;
            detailPage.groupItemDet.Left = detailPage.groupHosDet.Location.X + dynamicPanelWidth * 2;
            detailPage.groupStMdDet.Left = detailPage.groupHosDet.Location.X + dynamicPanelWidth * 3;
            detailPage.groupAcItDet.Left = detailPage.groupHosDet.Location.X + dynamicPanelWidth * 4;
            detailPage.groupAnimalDet.Left = detailPage.groupHosDet.Location.X + dynamicPanelWidth * 5;
        }

        public static List<Coordinates> BuildCoordinatesList(string rawString)
        {
            List<Coordinates> coordList = new List<Coordinates>();
            Coordinates coords;
            string coordPattern = @"-?\d+([.]\d+)?";

            MatchCollection matches = Regex.Matches(rawString, coordPattern);
            var list = matches.Cast<Match>().Select(match => match.Value).ToList();
            while (list.Count % 4 != 0)
            {
                list.Add("0.00");
            }
            for (int i = 0; i < list.Count; i += 4)
            {
                coords = new Coordinates(list[i], list[i + 1], list[i + 2], list[i + 3]);
                coordList.Add(coords);
            }

            return coordList;
        }
    }
}
