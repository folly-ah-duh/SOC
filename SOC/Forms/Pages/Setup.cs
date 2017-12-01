using SOC.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static SOC.QuestComponents.GameObjectInfo;
using static SOC.QuestComponents.EnemyInfo;

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
        string[] mtbsCP = new string[] { "NONE" };

        public Setup()
        {
            InitializeComponent();
            CoordsScrolling = new Forms.PanelScroll(this.panel1, false);
            SendMessage(textBoxQuestNum.Handle, 0x1501, 1, "30103");
            SendMessage(textBoxFPKName.Handle, 0x1501, 1, "Example_Quest_Name");
            SendMessage(textBoxQuestTitle.Handle, 0x1501, 1, "Example Quest Title Text");

            for (int i = 0; i < AfghCPs.Length; i++)
                afghCP[i] = AfghCPs[i].CPname;
            for (int i = 0; i < MafrCPs.Length; i++)
                mafrCP[i] = MafrCPs[i].CPname;

            refreshNotifsList();
        }

        public void refreshNotifsList()
        {
            string[] notifications = UpdateNotifsManager.getDispNotifs();
            bool refresh = false;

            if (notifications.Length == comboBoxProgressNotifs.Items.Count)
            {
                for (int i = 0; i < notifications.Length; i++)
                {
                    if (!notifications[i].Equals(comboBoxProgressNotifs.Items[i]))
                    {
                        refresh = true;
                    }
                }
            } else
            {
                refresh = true;
            }

            if (refresh)
            {
                comboBoxProgressNotifs.Items.Clear();
                comboBoxProgressNotifs.Items.AddRange(UpdateNotifsManager.getDispNotifs());
            }
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
                    break;
                case 1:
                    locationID = 20;
                    comboBoxLoadArea.Items.AddRange(mafrLoadAreas);
                    comboBoxCP.Items.AddRange(mafrCP);
                    break;
                case 2:
                    comboBoxLoadArea.Items.AddRange(mtbsLoadAreas);
                    comboBoxCP.Items.AddRange(mtbsCP);
                    locationID = 50;
                    disableRegionInput();
                    comboBoxRadius.Text = "1";
                    break;
                default:
                    locationID = -1;
                    disableRegionInput();
                    break;
            }
            comboBoxCP.Text = "NONE";

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
                textBox_ActiveItem.Enabled = true;
                textBox_ActiveItem.BackColor = System.Drawing.Color.Silver;
                label21.Text = "Active Item Locations: (X, Y, Z, Y-Axis Rotation)";
                label21.ForeColor = System.Drawing.Color.Black;
            } else
            {
                textBox_ActiveItem.Enabled = false;
                textBox_ActiveItem.BackColor = System.Drawing.Color.DarkGray;
                label21.Text = "Active Item Locations: (X, Y, Z, Y-Axis Rotation) [Disabled When Items Exist]";
                label21.ForeColor = System.Drawing.Color.Goldenrod;
                textBox_ActiveItem.Clear();
            }

            if (string.IsNullOrEmpty(textBox_ActiveItem.Text))
            {
                textBoxItemCoords.Enabled = true;
                textBoxItemCoords.BackColor = System.Drawing.Color.Silver;
                label17.Text = "Item Locations: (X, Y, Z, Y-Axis Rotation)";
                label17.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                textBoxItemCoords.Enabled = false;
                textBoxItemCoords.BackColor = System.Drawing.Color.DarkGray;
                label17.Text = "Item Locations: (X, Y, Z, Y-Axis Rotation) [Disabled When Active Items Exist]";
                label17.ForeColor = System.Drawing.Color.Goldenrod;
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

        private void textBoxFPKName_Leave(object sender, EventArgs e)
        {
            string invalidchars = "[\\/\\?\\\\\\|\\*\\:\\\"\\<\\> ]";
            string replacement = "_";
            Regex fileNameFixer = new Regex(invalidchars);
            textBoxFPKName.Text = fileNameFixer.Replace(textBoxFPKName.Text, replacement);
        }
    }
}
