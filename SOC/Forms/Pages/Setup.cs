using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOC.UI
{
    public partial class Setup : UserControl
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
        internal static string[] afghLoadAreas = new string[] { "tent", "field", "ruins", "waterway", "cliffTown", "commFacility", "sovietBase", "fort", "citadel" };
        internal static string[] mafrLoadAreas = new string[] { "outland", "pfCamp", "savannah", "hill", "banana", "diamond", "lab" };
        internal static string[] mtbsLoadAreas = new string[] { "MtbsCommand", "MtbsCombat", "MtbsDevelop", "MtbsMedical", "MtbsSupport", "MtbsSpy", "MtbsBaseDev", "MtbsPaz" };
        internal static string[] afghCP = new string[] {"NONE", "afgh_field_cp", "afgh_remnants_cp", "afgh_tent_cp", "afgh_village_cp", "afgh_slopedTown_cp", "afgh_commFacility_cp", "afgh_enemyBase_cp", "afgh_bridge_cp", "afgh_cliffTown_cp", "afgh_fort_cp", "afgh_powerPlant_cp", "afgh_sovietBase_cp", "afgh_citadel_cp", "afgh_fieldEast_ob", "afgh_remnantsNorth_ob", "afgh_fieldWest_ob", "afgh_tentEast_ob", "afgh_tentNorth_ob", "afgh_commWest_ob", "afgh_ruinsNorth_ob", "afgh_slopedWest_ob", "afgh_villageEast_ob", "afgh_villageNorth_ob", "afgh_villageWest_ob", "afgh_enemyEast_ob", "afgh_bridgeNorth_ob", "afgh_bridgeWest_ob", "afgh_cliffEast_ob", "afgh_cliffSouth_ob", "afgh_cliffWest_ob", "afgh_enemyNorth_ob", "afgh_fortSouth_ob", "afgh_fortWest_ob", "afgh_slopedEast_ob", "afgh_plantSouth_ob", "afgh_plantWest_ob", "afgh_sovietSouth_ob", "afgh_waterwayEast_ob", "afgh_citadelSouth_ob" };
        internal static string[] mafrCP = new string[] {"NONE", "mafr_outland_cp", "mafr_flowStation_cp", "mafr_swamp_cp", "mafr_savannah_cp", "mafr_pfCamp_cp", "mafr_banana_cp", "mafr_diamond_cp", "mafr_hill_cp", "mafr_factory_cp", "mafr_lab_cp", "mafr_outlandEast_ob", "mafr_outlandNorth_ob", "mafr_swampEast_ob", "mafr_swampSouth_ob", "mafr_swampWest_ob", "mafr_pfCampNorth_ob", "mafr_pfCampEast_ob", "mafr_savannahEast_ob", "mafr_savannahWest_ob", "mafr_chicoVilWest_ob", "mafr_hillSouth_ob", "mafr_factorySouth_ob", "mafr_hillNorth_ob", "mafr_hillWest_ob", "mafr_hillWestNear_ob", "mafr_diamondSouth_ob", "mafr_diamondNorth_ob", "mafr_diamondWest_ob", "mafr_bananaEast_ob", "mafr_savannahNorth_ob", "mafr_bananaSouth_ob", "mafr_factoryWest_ob", "mafr_labWest_ob"};
        internal static string[] mtbsCP = new string[] { "NONE" };
        internal static string[] UpdateNotifsList = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "UpdateNotifsList.txt"));
        public static QuestDefinitionLua DefinitionInfo;
        public int locationID = -1;
        const int EM_SETCUEBANNER = 0x1501;

        public Setup()
        {
            InitializeComponent();
            SendMessage(textBoxQuestNum.Handle, EM_SETCUEBANNER, 1, "30100");
            SendMessage(textBoxFPKName.Handle, EM_SETCUEBANNER, 1, "Example_Quest_Name");
            SendMessage(textBoxQuestTitle.Handle, EM_SETCUEBANNER, 1, "Example Quest Title Text");
            refreshNotifsList();
        }

        public void refreshNotifsList()
        {
            UpdateNotifsList = File.ReadAllLines("UpdateNotifsList.txt");
            comboBoxProgressNotifs.Items.Clear();
            for (int i = 0; i < UpdateNotifsList.Length; i += 2)
            {
                comboBoxProgressNotifs.Items.Add(UpdateNotifsList[i]);
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
            comboBoxLoadArea.Enabled = false; comboBoxRadius.Enabled = false; comboBoxCP.Enabled = false;
            textBoxXCoord.Enabled = false; textBoxYCoord.Enabled = false; textBoxZCoord.Enabled = false;
        }
        private void enableRegionInput()
        {
            comboBoxLoadArea.Enabled = true; comboBoxRadius.Enabled = true; comboBoxCP.Enabled = true;
            textBoxXCoord.Enabled = true; textBoxYCoord.Enabled = true; textBoxZCoord.Enabled = true;
        }

        private void buttonAddNotif_Click(object sender, EventArgs e)
        {
            //open a new form, takes lang entry and id, updates UpdateNotifsList.txt and refreshes notifslist combobox
            formCustomProgressLang customLang = new formCustomProgressLang();
            customLang.ShowDialog();
            refreshNotifsList();
        }
        
    }
}
