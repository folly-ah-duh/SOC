using SOC.Classes;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static SOC.QuestComponents.GameObjectInfo;
using static SOC.QuestComponents.EnemyInfo;
using System.IO;

namespace SOC.UI
{
    public partial class Setup : UserControl
    {
        

        Forms.PanelScroll CoordsScrolling;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
        public static DefinitionDetails DefinitionInfo;
        public int locationID = -1;
        string[] afghCP = new string[AfghCPs.Length];
        string[] mafrCP = new string[MafrCPs.Length];
        string[] mtbsCP = new string[1];
        Tuple<Label, TextBox>[] LocationBoxes;

        public Setup()
        {
            InitializeComponent();
            CoordsScrolling = new Forms.PanelScroll(this.panel1, false);
            SendMessage(textBoxQuestNum.Handle, 0x1501, 1, "30103");
            SendMessage(textBoxFPKName.Handle, 0x1501, 1, "Example_Quest_Name");
            SendMessage(textBoxQuestTitle.Handle, 0x1501, 1, "Example Quest Title Text");


            LocationBoxes = new Tuple<Label, TextBox>[6] {
                new Tuple<Label, TextBox>(labelHos, textBoxHosCoords),
                new Tuple<Label, TextBox>(labelVeh, textBoxVehCoords),
                new Tuple<Label, TextBox>(labelAni, textBoxAnimalCoords),
                new Tuple<Label, TextBox>(labelItem, textBoxItemCoords),
                new Tuple<Label, TextBox>(labelActiveItem, textBoxActiveItemCoords),
                new Tuple<Label, TextBox>(labelModel, textBoxStMdCoords)
            };


            for (int i = 0; i < AfghCPs.Length; i++)
                afghCP[i] = AfghCPs[i].CPname;
            for (int i = 0; i < MafrCPs.Length; i++)
                mafrCP[i] = MafrCPs[i].CPname;
            mtbsCP[0] = MtbsCP.CPname;

            refreshNotifsList();
            refreshRoutesList();
        }

        public DefinitionDetails getDefinitionDetails()
        {
            return new DefinitionDetails(textBoxFPKName.Text, textBoxQuestNum.Text, locationID, comboBoxLoadArea.Text, 
                new Coordinates(textBoxXCoord.Text, textBoxYCoord.Text, textBoxZCoord.Text), comboBoxRadius.Text, comboBoxCategory.Text, comboBoxReward.Text, comboBoxProgressNotifs.SelectedIndex, 
                comboBoxObjective.Text, comboBoxCP.Text, textBoxQuestTitle.Text, textBoxQuestDesc.Text,
                textBoxHosCoords.Text, textBoxVehCoords.Text, textBoxAnimalCoords.Text, textBoxItemCoords.Text, textBoxActiveItemCoords.Text, textBoxStMdCoords.Text,
                comboBoxRoute.Text);
        }

        public void setDefinitionDetails(DefinitionDetails dd)
        {
            textBoxFPKName.Text = dd.FpkName; textBoxQuestNum.Text = dd.QuestNum;
            locationID = dd.locationID;

            if (locationID == 10)
                comboBoxRegion.Text = "Afghanistan";
            else if (locationID == 20)
                comboBoxRegion.Text = "Central Africa";
            else
                comboBoxRegion.Text = "Mother Base";

            comboBoxLoadArea.Text = dd.loadArea;
            textBoxXCoord.Text = dd.coords.xCoord; textBoxYCoord.Text = dd.coords.yCoord; textBoxZCoord.Text = dd.coords.zCoord; comboBoxRadius.Text = dd.radius;
            comboBoxCategory.Text = dd.category; comboBoxReward.Text = dd.reward; comboBoxObjective.Text = dd.objectiveType;
            comboBoxCP.Text = dd.CPName; textBoxQuestTitle.Text = dd.QuestTitle; textBoxQuestDesc.Text = dd.QuestDesc;

            refreshRoutesList();
            if (!string.IsNullOrEmpty(dd.routeName) && comboBoxRoute.Items.Contains(dd.routeName))
                comboBoxRoute.SelectedItem = dd.routeName;
            else
                comboBoxRoute.SelectedItem = "NONE";

            refreshNotifsList();
            if (comboBoxProgressNotifs.Items.Count <= dd.progNotif)
                comboBoxProgressNotifs.SelectedIndex = 0;
            else
                comboBoxProgressNotifs.SelectedIndex = dd.progNotif;

            textBoxHosCoords.Text = dd.hostageCoordinates.Replace("\n", "\r\n");
            textBoxVehCoords.Text = dd.vehicleCoordinates.Replace("\n", "\r\n");
            textBoxAnimalCoords.Text = dd.animalCoordinates.Replace("\n", "\r\n");
            textBoxItemCoords.Text = dd.itemCoordinates.Replace("\n", "\r\n");
            textBoxActiveItemCoords.Text = dd.activeItemCoordinates.Replace("\n", "\r\n");
            textBoxStMdCoords.Text = dd.modelCoordinates.Replace("\n", "\r\n");
        }

        public void refreshNotifsList()
        {
            string[] notifications = UpdateNotifsManager.getDispNotifs();
            
            if (FilesUpdated(notifications, comboBoxProgressNotifs))
            {
                comboBoxProgressNotifs.Items.Clear();
                comboBoxProgressNotifs.Items.AddRange(UpdateNotifsManager.getDispNotifs());
            }
        }
        public void refreshRoutesList()
        {
            string routeDir = AssetsBuilder.routeAssetsPath;


            string[] RouteFiles = Directory.GetFiles(routeDir, "*.frt");
            for (int i = 0; i < RouteFiles.Length; i++)
            {
                int filenameLength = RouteFiles[i].Substring(RouteFiles[i].LastIndexOf('\\') + 1).Length - 1;
                RouteFiles[i] = RouteFiles[i].Substring(RouteFiles[i].LastIndexOf('\\') + 1, filenameLength - 3);
            }

            string[] RouteFilesAndNone = new string[RouteFiles.Length + 1];
            RouteFilesAndNone[0] = "NONE"; RouteFiles.CopyTo(RouteFilesAndNone, 1);
            if (FilesUpdated(RouteFilesAndNone, comboBoxRoute))
            {
                comboBoxRoute.Items.Clear();
                comboBoxRoute.Items.AddRange(RouteFilesAndNone);
                comboBoxRoute.SelectedIndex = 0;
            }
        }

        public bool FilesUpdated(string[] newList, ComboBox comboBox)
        {

            if (newList.Length == comboBox.Items.Count)
                for (int i = 0; i < newList.Length; i++)
                {
                    if (!newList[i].Equals(comboBox.Items[i]))
                    {
                        return true;
                    }
                }
            else
                return true;

            return false;
        }

        internal void refreshCoordinateBoxes(QuestEntities qe)
        {
            string updatedTest = "";
            foreach (Hostage entity in qe.hostages)
            {
                Coordinates detailCoords = entity.coordinates;
                updatedTest += string.Format("{{pos={{{0},{1},{2}}},rotY={3},}}, \r\n", detailCoords.xCoord, detailCoords.yCoord, detailCoords.zCoord, detailCoords.roty);
            }
            textBoxHosCoords.Text = updatedTest;

            updatedTest = "";
            foreach (Vehicle entity in qe.vehicles)
            {
                Coordinates detailCoords = entity.coordinates;
                updatedTest += string.Format("{{pos={{{0},{1},{2}}},rotY={3},}}, \r\n", detailCoords.xCoord, detailCoords.yCoord, detailCoords.zCoord, detailCoords.roty);
            }
            textBoxVehCoords.Text = updatedTest;

            updatedTest = "";
            foreach (Animal entity in qe.animals)
            {
                Coordinates detailCoords = entity.coordinates;
                updatedTest += string.Format("{{pos={{{0},{1},{2}}},rotY={3},}}, \r\n", detailCoords.xCoord, detailCoords.yCoord, detailCoords.zCoord, detailCoords.roty);
            }
            textBoxAnimalCoords.Text = updatedTest;

            updatedTest = "";
            foreach (Item entity in qe.items)
            {
                Coordinates detailCoords = entity.coordinates;
                updatedTest += string.Format("{{pos={{{0},{1},{2}}},rotY={3},}}, \r\n", detailCoords.xCoord, detailCoords.yCoord, detailCoords.zCoord, detailCoords.roty);
            }
            textBoxItemCoords.Text = updatedTest;

            updatedTest = "";
            foreach (ActiveItem entity in qe.activeItems)
            {
                Coordinates detailCoords = entity.coordinates;
                updatedTest += string.Format("{{pos={{{0},{1},{2}}},rotY={3},}}, \r\n", detailCoords.xCoord, detailCoords.yCoord, detailCoords.zCoord, detailCoords.roty);
            }
            textBoxActiveItemCoords.Text = updatedTest;

            updatedTest = "";
            foreach (Model entity in qe.models)
            {
                Coordinates detailCoords = entity.coordinates;
                updatedTest += string.Format("{{pos={{{0},{1},{2}}},rotY={3},}}, \r\n", detailCoords.xCoord, detailCoords.yCoord, detailCoords.zCoord, detailCoords.roty);
            }
            textBoxStMdCoords.Text = updatedTest;
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLoadArea.Items.Clear();
            comboBoxCP.Items.Clear();
            enableRegionInput();
            switch (comboBoxRegion.SelectedIndex)
            {
                case 0:
                    comboBoxLoadArea.Items.AddRange(afghLoadAreas);
                    comboBoxCP.Items.AddRange(afghCP);
                    locationID = 10;
                    textBoxVehCoords.Enabled = true;
                    textBoxVehCoords.BackColor = System.Drawing.Color.Silver;
                    labelVeh.ForeColor = System.Drawing.Color.Black;
                    labelVeh.Text = "Vehicle Locations: (X, Y, Z, Y-Axis Rotation)";
                    break;
                case 1:
                    locationID = 20;
                    comboBoxLoadArea.Items.AddRange(mafrLoadAreas);
                    comboBoxCP.Items.AddRange(mafrCP);
                    textBoxVehCoords.Enabled = true;
                    textBoxVehCoords.BackColor = System.Drawing.Color.Silver;
                    labelVeh.ForeColor = System.Drawing.Color.Black;
                    labelVeh.Text = "Vehicle Locations: (X, Y, Z, Y-Axis Rotation)";
                    break;
                case 2:
                    comboBoxLoadArea.Items.AddRange(mtbsLoadAreas);
                    comboBoxCP.Items.AddRange(mtbsCP);
                    locationID = 50;
                    disableRegionInput();
                    textBoxVehCoords.Enabled = false;
                    textBoxVehCoords.Text = "";
                    textBoxVehCoords.BackColor = System.Drawing.Color.DarkGray;
                    labelVeh.ForeColor = System.Drawing.Color.Goldenrod;
                    labelVeh.Text = "Vehicle Locations: (X, Y, Z, Y-Axis Rotation) [Disabled On Mother Base]";
                    comboBoxRadius.Text = "1";
                    break;
                default:
                    locationID = -1;
                    disableRegionInput();
                    break;
            }
            comboBoxCP.SelectedIndex = 0;
            comboBoxLoadArea.SelectedIndex = 0;

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

        private void buttonAddNotif_Click(object sender, EventArgs e)
        {
            formCustomProgressLang customLang = new formCustomProgressLang();
            customLang.ShowDialog();
            refreshNotifsList();
        }

        public void EnableScrolling()
        {
            Application.AddMessageFilter(CoordsScrolling);
        }
        public void DisableScrolling()
        {
            Application.RemoveMessageFilter(CoordsScrolling);
        }

        private void textBoxItemCoords_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxItemCoords.Text))
            {
                textBoxActiveItemCoords.Enabled = true;
                textBoxActiveItemCoords.BackColor = System.Drawing.Color.Silver;
                labelActiveItem.Text = "Active Item Locations: (X, Y, Z, Y-Axis Rotation)";
                labelActiveItem.ForeColor = System.Drawing.Color.Black;
            } else
            {
                textBoxActiveItemCoords.Enabled = false;
                textBoxActiveItemCoords.BackColor = System.Drawing.Color.DarkGray;
                labelActiveItem.Text = "Active Item Locations: (X, Y, Z, Y-Axis Rotation) [Disabled When Dormant Items Exist]";
                labelActiveItem.ForeColor = System.Drawing.Color.Goldenrod;
                textBoxActiveItemCoords.Clear();
            }

            if (string.IsNullOrEmpty(textBoxActiveItemCoords.Text))
            {
                textBoxItemCoords.Enabled = true;
                textBoxItemCoords.BackColor = System.Drawing.Color.Silver;
                labelItem.Text = "Dormant Item Locations: (X, Y, Z, Y-Axis Rotation)";
                labelItem.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                textBoxItemCoords.Enabled = false;
                textBoxItemCoords.BackColor = System.Drawing.Color.DarkGray;
                labelItem.Text = "Dormant Item Locations: (X, Y, Z, Y-Axis Rotation) [Disabled When Active Items Exist]";
                labelItem.ForeColor = System.Drawing.Color.Goldenrod;
                textBoxItemCoords.Clear();
            }
        }

        private void textBoxQuestNum_Leave(object sender, EventArgs e)
        {
            int qNumInt = 0;
            bool isvalid = false;

            if (Int32.TryParse(textBoxQuestNum.Text, out qNumInt))
            {
                if (qNumInt >= 30103 && qNumInt <= 39009)
                {
                    textBoxQuestNum.Text = qNumInt.ToString();
                    isvalid = true;
                }
            }
            if (!isvalid && !string.IsNullOrEmpty(textBoxQuestNum.Text))
            {
                MessageBox.Show(string.Format("Invalid Quest Number: {0} \nThe Quest Number must be an integer between 30103 and 39009", qNumInt.ToString()), "Invalid Quest Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void ShiftGroups(int height, int width)
        {
            Height = height; Width = width;
            int dynamicHeight = groupBoxLocations.Height / 4 - 20;
            int maxHeight = 124;

            if (dynamicHeight >= maxHeight)
                dynamicHeight = maxHeight;


            foreach(Tuple<Label, TextBox> box in LocationBoxes)
            {
                box.Item2.Height = dynamicHeight;
            }

            int yOffset = 6 + originAnchor.Location.Y; int bufferSpace = 25 + dynamicHeight;
            for (int i = 0; i < LocationBoxes.Length; i++)
            {
                LocationBoxes[i].Item1.Top = yOffset + bufferSpace * i;
                LocationBoxes[i].Item2.Top = yOffset + 15 + bufferSpace * i;

            }
        }

        private void textBoxFPKName_Leave(object sender, EventArgs e)
        {
            string invalidchars = "[\\/\\?\\\\\\|\\*\\:\\\"\\<\\> ]";
            string replacement = "_";
            Regex fileNameFixer = new Regex(invalidchars);
            textBoxFPKName.Text = fileNameFixer.Replace(textBoxFPKName.Text, replacement);
        }

        private void comboBoxRoute_DropDown(object sender, EventArgs e)
        {
            refreshRoutesList();
        }
    }
}
