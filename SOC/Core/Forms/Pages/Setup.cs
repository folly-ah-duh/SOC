using SOC.Classes;
using SOC.QuestObjects.Common;
using SOC.Core.Classes.Route;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static SOC.QuestComponents.EnemyInfo;
using System.Collections.Generic;
using SOC.Classes.Common;
using System.Globalization;

namespace SOC.UI
{
    public partial class Setup : UserControl
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
        public int locationID = -1;
        ManagerMaster managerMaster;
        RouteManager routeManager = new RouteManager();

        public Setup(ManagerMaster manMaster)
        {
            InitializeComponent();
            SetManagerMaster(manMaster);
            Dock = DockStyle.Fill;
            SendMessage(textBoxQuestNum.Handle, 0x1501, 1, "30103");
            SendMessage(textBoxFPKName.Handle, 0x1501, 1, "Example_Quest_Name");
            SendMessage(textBoxQuestTitle.Handle, 0x1501, 1, "Example Quest Title Text");

            flowPanelLocationalStubs.Controls.AddRange(managerMaster.GetLocationalStubs().ToArray());

            refreshNotifsList();
            refreshRoutesList();
        }

        public void SetManagerMaster(ManagerMaster manMaster)
        {
            managerMaster = manMaster;
        }

        public void SetCoreDetails(CoreDetails core)
        {
            textBoxQuestTitle.Text = core.QuestTitle; textBoxQuestDesc.Text = core.QuestDesc;

            textBoxFPKName.Text = core.FpkName; textBoxQuestNum.Text = core.QuestNum;

            locationID = core.locationID;

            switch(locationID)
            {
                case 10:
                    comboBoxRegion.Text = "Afghanistan";
                    break;
                case 20:
                    comboBoxRegion.Text = "Central Africa";
                    break;
                case 50:
                    comboBoxRegion.Text = "Mother Base";
                    break;
            }

            comboBoxLoadArea.Text = core.loadArea;

            textBoxXCoord.Text = core.coords.xCoord; textBoxYCoord.Text = core.coords.yCoord; textBoxZCoord.Text = core.coords.zCoord;

            comboBoxRadius.Text = core.radius; comboBoxCategory.Text = core.category; comboBoxReward.Text = core.reward;

            core.CPName = comboBoxCP.Text;

            refreshNotifsList();
            if (comboBoxProgressNotifs.Items.Count > core.progNotif)
                comboBoxProgressNotifs.SelectedIndex = core.progNotif;
            else
                comboBoxProgressNotifs.SelectedIndex = 0;

            refreshRoutesList();
            if (!string.IsNullOrEmpty(core.routeName) && comboBoxRoute.Items.Contains(core.routeName))
                comboBoxRoute.SelectedItem = core.routeName;
            else
                comboBoxRoute.SelectedItem = "NONE";

        }

        public CoreDetails GetCoreDetails()
        {
            CoreDetails core = new CoreDetails();

            core.QuestTitle = textBoxQuestTitle.Text; core.QuestDesc = textBoxQuestDesc.Text;

            core.FpkName = textBoxFPKName.Text; core.QuestNum = textBoxQuestNum.Text;

            core.locationID = locationID; core.loadArea = comboBoxLoadArea.Text;

            core.coords = new Coordinates(textBoxXCoord.Text, textBoxYCoord.Text, textBoxZCoord.Text); core.radius = comboBoxRadius.Text;

            core.category = comboBoxCategory.Text; core.progNotif = comboBoxProgressNotifs.SelectedIndex;

            core.reward = comboBoxReward.Text;

            core.CPName = comboBoxCP.Text; core.routeName = comboBoxRoute.Text;

            return core;
        }

        public void refreshNotifsList()
        {
            UpdateComboBox(comboBoxProgressNotifs, UpdateNotifsManager.getDispNotifs());
        }

        public void refreshRoutesList()
        {
            List<string> routesList = routeManager.GetRouteFileNameList();
            routesList.Insert(0, "NONE");

            UpdateComboBox(comboBoxRoute, routesList);
        }

        private void disableRegionInput()
        {
            comboBoxRadius.Enabled = false; comboBoxCP.Enabled = false;
            textBoxXCoord.Enabled = false; textBoxYCoord.Enabled = false; textBoxZCoord.Enabled = false;
        }

        private void enableRegionInput()
        {
            comboBoxLoadArea.Enabled = true; comboBoxRadius.Enabled = true; comboBoxCP.Enabled = true;
            textBoxXCoord.Enabled = true; textBoxYCoord.Enabled = true; textBoxZCoord.Enabled = true;
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] loadArea = new string[0];
            string[] cpNames = new string[0];
            enableRegionInput();
            managerMaster.EnableVehicleBox();

            switch (comboBoxRegion.Text)
            {
                case "Afghanistan":
                    locationID = 10;
                    loadArea = LoadAreas.afgh;
                    cpNames = GetCPNames(AfghCPs);
                    break;

                case "Central Africa":
                    locationID = 20;
                    loadArea = LoadAreas.mafr;
                    cpNames = GetCPNames(MafrCPs);
                    break;

                case "Mother Base":
                    locationID = 50;
                    loadArea = LoadAreas.mtbs;
                    cpNames = GetCPNames(MtbsCP);
                    disableRegionInput();
                    managerMaster.DisableVehicleBox();
                    comboBoxRadius.Text = "1";
                    break;
            }

            UpdateComboBox(comboBoxLoadArea, loadArea);
            UpdateComboBox(comboBoxCP, cpNames);
        }

        private void buttonAddNotif_Click(object sender, EventArgs e)
        {
            formCustomProgressLang customLang = new formCustomProgressLang();
            customLang.ShowDialog();
            refreshNotifsList();
        }

        private void textBoxQuestNum_Leave(object sender, EventArgs e)
        {
            int qNumInt = 0;
            bool isvalid = false;

            if (Int32.TryParse(textBoxQuestNum.Text, out qNumInt))
            {
                if (qNumInt >= 30103 && qNumInt <= 39009)
                {
                    textBoxQuestNum.Text = qNumInt.ToString("F0", CultureInfo.InvariantCulture);
                    isvalid = true;
                }
            }
            if (!isvalid && !string.IsNullOrEmpty(textBoxQuestNum.Text))
            {
                MessageBox.Show(string.Format("Invalid Quest Number: {0} \nThe Quest Number must be an integer between 30103 and 39009", qNumInt.ToString()), "Invalid Quest Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxFPKName_Leave(object sender, EventArgs e)
        {
            string invalidchars = @"[\/\?\\\|\*\:\""\<\> ]";
            string replacement = "_";
            Regex fileNameFixer = new Regex(invalidchars);
            textBoxFPKName.Text = fileNameFixer.Replace(textBoxFPKName.Text, replacement);
        }

        private void comboBoxRoute_DropDown(object sender, EventArgs e)
        {
            refreshRoutesList();
        }

        private void flowPanelLocationalStubs_Layout(object sender, LayoutEventArgs e) // necessary jank for flowLayoutPanels: https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-anchor-and-dock-child-controls-in-a-flowlayoutpanel-control
        {
            labelFlowWidth.Width = flowPanelLocationalStubs.Width;
        }
        
        public void UpdateComboBox(ComboBox box, List<string> itemList)
        {
            int currentIndex = box.SelectedIndex;

            if (currentIndex >= itemList.Count)
                currentIndex = 0;

            box.Items.Clear();
            box.Items.AddRange(itemList.ToArray());
            box.SelectedIndex = currentIndex;
        }

        public void UpdateComboBox(ComboBox box, string[] itemList)
        {
            int currentIndex = box.SelectedIndex;

            if (currentIndex >= itemList.Length)
                currentIndex = 0;

            box.Items.Clear();
            box.Items.AddRange(itemList);
            box.SelectedIndex = currentIndex;
        }
    }
}
