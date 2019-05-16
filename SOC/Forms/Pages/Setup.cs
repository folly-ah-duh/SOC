using SOC.Classes;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static SOC.QuestComponents.EnemyInfo;
using System.IO;

namespace SOC.UI
{
    public partial class Setup : UserControl
    {
        

        Forms.PanelScroll CoordsScrolling;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
        public int locationID = -1;
        string[] afghCP = new string[AfghCPs.Length];
        string[] mafrCP = new string[MafrCPs.Length];
        string[] mtbsCP = new string[1];
        Tuple<Label, TextBox>[] LocationBoxes;

        public Setup()
        {
            InitializeComponent();
            SendMessage(textBoxQuestNum.Handle, 0x1501, 1, "30103");
            SendMessage(textBoxFPKName.Handle, 0x1501, 1, "Example_Quest_Name");
            SendMessage(textBoxQuestTitle.Handle, 0x1501, 1, "Example Quest Title Text");

            for (int i = 0; i < AfghCPs.Length; i++)
                afghCP[i] = AfghCPs[i].CPname;
            for (int i = 0; i < MafrCPs.Length; i++)
                mafrCP[i] = MafrCPs[i].CPname;
            mtbsCP[0] = MtbsCP.CPname;

            refreshNotifsList();
            refreshRoutesList();
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
