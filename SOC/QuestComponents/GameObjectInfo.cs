using SOC.Forms.Pages.QuestBoxes;
using SOC.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SOC.QuestComponents
{
    public static class GameObjectInfo
    {
        public static string[] afghLoadAreas = {
            "tent",
            "field",
            "ruins",
            "waterway",
            "cliffTown",
            "commFacility",
            "sovietBase",
            "fort",
            "citadel"
        };
        public static string[] mafrLoadAreas = {
            "outland",
            "pfCamp",
            "savannah",
            "hill",
            "banana",
            "diamond",
            "lab"
        };
        public static string[] mtbsLoadAreas =  {
            "MtbsCommand",
            "MtbsCombat",
            "MtbsDevelop",
            "MtbsMedical",
            "MtbsSupport",
            "MtbsSpy",
            "MtbsBaseDev"
        };

        public static string[] skills =
        {
            "NONE",
            "Reflex",
            "Ninja",
            "Athlete",
            "FultonExpert",
            "QuickReload",
            "Study",
            "Lucky",
            "Grappler",
            "BigMouth",
            "Botanist",
            "QuickDraw",
            "Surgeon",
            "Physician",
            "Counselor",
            "Moodmaker",
            "Zoologist",
            "TroublemakerViolence",
            "TroublemakerIntemperately",
            "TroublemakerHarassment",
            "GunsmithHandGun",
            "GunsmithSubmachineGun",
            "GunsmithAssultRifle",
            "GunsmithShotGun",
            "GunsmithGrenadeLauncher",
            "GunsmithSniperRifle",
            "GunsmithMachineGun",
            "GunsmithMissile",
            "MasterGunsmith",
            "TranqEngineer",
            "SuppressorEngineer",
            "MissileHomingEngineer",
            "SleepingGasEngineer",
            "ElectricEngineer",
            "ElectromagneticNetEngineer",
            "RadarEngineer",
            "MetamaterialEngineer",
            "DrugEngineer",
            "MechatronicsEngineer",
            "CyberneticsEngineer",
            "RocketControlEngineer",
            "ElectricSpinningEngineer",
            "MaterialEngineer",
            "HaulageEngineer",
            "MonitorEngineer",
            "MechanicalEngineer",
            "TranslateRussian",
            "TranslateAfrikaans",
            "TranslateKikongo",
            "TranslatePashto",
            "なし",
            "TacticsInstructor",
            "MBViceCommander",
            "ScoutSniper",
            "BipedalismWeaponDevelopment",
            "ParasiteReseacher",
        };
        public static string[] Staff_Type_ID =
        {
            "NONE",
            "NORMAL",
            "COMBAT",
            "DEVELOP",
            "BASE_DEV",
            "SUPPORT",
            "SPY",
            "MEDICAL"
        };

        public static string[] vehicleNames = {
            "EASTERN_TRACKED_TANK",
            "WESTERN_TRACKED_TANK",
            "EASTERN_WHEELED_ARMORED_VEHICLE",
            "EASTERN_WHEELED_ARMORED_VEHICLE_ROCKET_ARTILLERY",
            "WESTERN_WHEELED_ARMORED_VEHICLE_TURRET_MACHINE_GUN",
            "WESTERN_WHEELED_ARMORED_VEHICLE_TURRET_CANNON"
        };

        public static string[] items =
        {
            "EQP_SWP_Magazine",
            "EQP_SWP_Kibidango",
            "EQP_SWP_Kibidango_G01",
            "EQP_SWP_Kibidango_G02",

            "EQP_SWP_Grenade",
            "EQP_SWP_Grenade_G01",
            "EQP_SWP_Grenade_G02",
            "EQP_SWP_Grenade_G03",
            "EQP_SWP_Grenade_G04",
            "EQP_SWP_Grenade_G05",
            "EQP_SWP_Grenade_G06",
            "EQP_SWP_Grenade_G07",
            "EQP_SWP_Grenade_G08",

            "EQP_SWP_SmokeGrenade",
            "EQP_SWP_SmokeGrenade_G01",
            "EQP_SWP_SmokeGrenade_G02",
            "EQP_SWP_SmokeGrenade_G03",
            "EQP_SWP_SmokeGrenade_G04",

            "EQP_SWP_SupportHeliFlareGrenade",
            "EQP_SWP_SupportHeliFlareGrenade_G01",
            "EQP_SWP_SupportHeliFlareGrenade_G02",

            "EQP_SWP_SupplyFlareGrenade",
            "EQP_SWP_SupplyFlareGrenade_G01",
            "EQP_SWP_SupplyFlareGrenade_G02",

            "EQP_SWP_StunGrenade",
            "EQP_SWP_StunGrenade_G01",
            "EQP_SWP_StunGrenade_G02",
            "EQP_SWP_StunGrenade_G03",
            "EQP_SWP_StunGrenade_G04",
            "EQP_SWP_StunGrenade_G05",
            "EQP_SWP_StunGrenade_G06",

            "EQP_SWP_SleepingGusGrenade",
            "EQP_SWP_SleepingGusGrenade_G01",
            "EQP_SWP_SleepingGusGrenade_G02",

            "EQP_SWP_MolotovCocktail",
            "EQP_SWP_MolotovCocktail_G01",
            "EQP_SWP_MolotovCocktail_G02",

            "EQP_SWP_MolotovCocktailPlaced",

            "EQP_SWP_C4",
            "EQP_SWP_C4_G01",
            "EQP_SWP_C4_G02",
            "EQP_SWP_C4_G03",
            "EQP_SWP_C4_G04",

            "EQP_SWP_Decoy",
            "EQP_SWP_Decoy_G01",
            "EQP_SWP_Decoy_G02",

            "EQP_SWP_ActiveDecoy",
            "EQP_SWP_ActiveDecoy_G01",
            "EQP_SWP_ActiveDecoy_G02",

            "EQP_SWP_ShockDecoy",
            "EQP_SWP_ShockDecoy_G01",
            "EQP_SWP_ShockDecoy_G02",
            "EQP_SWP_ShockDecoy_G03",
            "EQP_SWP_ShockDecoy_G04",

            "EQP_SWP_CaptureCage",
            "EQP_SWP_CaptureCage_G01",
            "EQP_SWP_CaptureCage_G02",

            "EQP_SWP_DMine",
            "EQP_SWP_DMine_G01",
            "EQP_SWP_DMine_G02",
            "EQP_SWP_DMine_G03",

            "EQP_SWP_SleepingGusMine",
            "EQP_SWP_SleepingGusMine_G01",
            "EQP_SWP_SleepingGusMine_G02",

            "EQP_SWP_AntitankMine",
            "EQP_SWP_AntitankMine_G01",
            "EQP_SWP_AntitankMine_G02",

            "EQP_SWP_ElectromagneticNetMine",
            "EQP_SWP_ElectromagneticNetMine_G01",
            "EQP_SWP_ElectromagneticNetMine_G02",

            "EQP_WP_West_thg_010",
            "EQP_WP_West_thg_020",
            "EQP_WP_West_thg_030",
            "EQP_WP_West_thg_040",
            "EQP_WP_West_thg_050",
            "EQP_WP_West_hg_010",
            "EQP_WP_West_hg_020",
            "EQP_WP_East_hg_010",

            "EQP_WP_EX_hg_000",
            "EQP_WP_EX_hg_000_G01",
            "EQP_WP_EX_hg_000_G02",
            "EQP_WP_EX_hg_000_G03",
            "EQP_WP_EX_hg_000_G04",
            "EQP_WP_EX_hg_010",
            "EQP_WP_EX_hg_011",
            "EQP_WP_EX_hg_012",
            "EQP_WP_EX_hg_013",
            "EQP_WP_EX_gl_000",
            "EQP_WP_EX_sr_000",

            "EQP_WP_West_sm_010",
            "EQP_WP_West_sm_020",
            "EQP_WP_East_sm_010",
            "EQP_WP_East_sm_020",
            "EQP_WP_East_sm_030",
            "EQP_WP_East_sm_042",
            "EQP_WP_East_sm_043",
            "EQP_WP_East_sm_044",
            "EQP_WP_East_sm_045",
            "EQP_WP_Com_sg_010",
            "EQP_WP_Com_sg_011",
            "EQP_WP_West_ar_010",
            "EQP_WP_West_ar_010_FL",
            "EQP_WP_West_ar_020",
            "EQP_WP_West_ar_020_FL",
            "EQP_WP_West_ar_030",
            "EQP_WP_East_ar_010",
            "EQP_WP_East_ar_010_FL",
            "EQP_WP_East_ar_020",
            "EQP_WP_East_ar_030",
            "EQP_WP_East_ar_030_FL",
            "EQP_WP_West_ar_040",
            "EQP_WP_West_ar_042",
            "EQP_WP_West_ar_050",
            "EQP_WP_West_ms_010",
            "EQP_WP_East_ms_010",
            "EQP_WP_East_ms_020",
            "EQP_WP_Com_ms_020",
            "EQP_WP_West_ms_020",

            "EQP_AB_PrimaryTranq",
            "EQP_AB_PrimaryMissile",
            "EQP_AB_PrimaryMissileTranq",
            "EQP_AB_SecondaryCommon",
            "EQP_AB_SecondaryTranq",
            "EQP_AB_Support",
            "EQP_AB_Suppressor",
            "EQP_AB_Item",
            "EQP_AB_Mecha",

            "EQP_BX_Primary",
            "EQP_BX_Secondary",
            "EQP_BX_Support",

            "EQP_IT_InstantStealth",
            "EQP_IT_Pentazemin",
            "EQP_IT_Clairvoyance",
            "EQP_IT_ReflexMedicine",
            "EQP_IT_CBox_WR",
            "EQP_IT_CBox_SMK",
            "EQP_IT_CBox_DSR",
            "EQP_IT_CBox_DSR_G01",
            "EQP_IT_CBox_DSR_G02",
            "EQP_IT_CBox_FRST",
            "EQP_IT_CBox_FRST_G01",
            "EQP_IT_CBox_BOLE",
            "EQP_IT_CBox_BOLE_G01",
            "EQP_IT_CBox_CITY",
            "EQP_IT_CBox_CITY_G01",
        };
        public static string[] activeItems =
        {
            "EQP_SWP_DMine",
            "EQP_SWP_DMine_G01",
            "EQP_SWP_DMine_G02",
            "EQP_SWP_DMine_G03",

            "EQP_SWP_SleepingGusMine",
            "EQP_SWP_SleepingGusMine_G01",
            "EQP_SWP_SleepingGusMine_G02",

            "EQP_SWP_AntitankMine",
            "EQP_SWP_AntitankMine_G01",
            "EQP_SWP_AntitankMine_G02",

            "EQP_SWP_ElectromagneticNetMine",
            "EQP_SWP_ElectromagneticNetMine_G01",
            "EQP_SWP_ElectromagneticNetMine_G02",

            "EQP_SWP_C4",
            "EQP_SWP_C4_G01",
            "EQP_SWP_C4_G02",
            "EQP_SWP_C4_G03",
            "EQP_SWP_C4_G04",

            "EQP_SWP_Decoy",
            "EQP_SWP_Decoy_G01",
            "EQP_SWP_Decoy_G02",

            "EQP_SWP_ActiveDecoy",
            "EQP_SWP_ActiveDecoy_G01",
            "EQP_SWP_ActiveDecoy_G02",

            "EQP_SWP_ShockDecoy",
            "EQP_SWP_ShockDecoy_G01",
            "EQP_SWP_ShockDecoy_G02",
            "EQP_SWP_ShockDecoy_G03",
            "EQP_SWP_ShockDecoy_G04",
        };
        
        public static string EquipIdStr32(string wpName)
        {
            return Classes.GzsTool.Hashing.ToStr32(wpName);
        }

        public static bool isAfgh(int locId)
        {
            return locId == 10;
        }

        public static bool isMafr(int locId)
        {
            return locId == 20;
        }

        public static bool isMtbs(int locId)
        {
            return locId == 50;
        }

        [XmlType("Quest")]
        public class Quest
        {

            public Quest() { }

            public Quest(DefinitionDetails d, QuestEntities q)
            {
                definitionDetails = d;
                questEntities = q;
            }

            public void Save(string fileName)
            {

                using (FileStream stream = new FileStream(fileName, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Quest));
                    serializer.Serialize(stream, this);
                }

            }

            public bool Load(string fileName)
            {
                
                if (!File.Exists(fileName))
                {
                    return false;
                } 

                using (FileStream stream = new FileStream(fileName, FileMode.Open))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Quest));
                    try
                    {
                        Quest loadedQuest = (Quest)deserializer.Deserialize(stream);
                        questEntities = loadedQuest.questEntities;
                        definitionDetails = loadedQuest.definitionDetails;
                        return true;
                    }
                    catch (InvalidOperationException e)
                    {
                        System.Windows.Forms.MessageBox.Show(string.Format("An Exception has occurred and the selected xml file could not be loaded. \n\nInnerException message: \n{0}", e.InnerException), "SOC", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }

                return false;
            }

            [XmlElement]
            public DefinitionDetails definitionDetails { get; set; }

            [XmlElement]
            public QuestEntities questEntities { get; set; }

        }

        [XmlType("DefinitionDetails")]
        public class DefinitionDetails
        {

            public DefinitionDetails() { }

            public DefinitionDetails(string fpk, string quest, int locID, string loada, Coordinates c, string rad, string cat, string rew, int prog, string cpnme, string qtitle, string qdesc, string hcoord, string walkercoord, string vehcoord, string anicoord, string itcoord, string acitcoord, string mdlcoord, string route)
            {
                FpkName = fpk; QuestNum = quest; QuestTitle = qtitle; QuestDesc = qdesc;

                locationID = locID; loadArea = loada; coords = c; radius = rad; CPName = cpnme;

                category = cat; progNotif = prog; reward = rew;
                
                hostageCoordinates = hcoord; vehicleCoordinates = vehcoord; animalCoordinates = anicoord; itemCoordinates = itcoord; activeItemCoordinates = acitcoord; modelCoordinates = mdlcoord; walkerGearCoordinates = walkercoord;

                routeName = route;
            }

            [XmlElement]
            public string QuestTitle { get; set; } = "";

            [XmlElement]
            public string QuestDesc { get; set; } = "";

            [XmlAttribute]
            public string FpkName { get; set; } = "";

            [XmlAttribute]
            public string QuestNum { get; set; } = "";

            [XmlElement]
            public int locationID { get; set; } = -1;

            [XmlElement]
            public string loadArea { get; set; } = "";

            [XmlElement]
            public Coordinates coords { get; set; } = new Coordinates();

            [XmlElement]
            public string radius { get; set; } = "";

            [XmlElement]
            public string category { get; set; } = "";

            [XmlElement]
            public string CPName { get; set; } = "";

            [XmlElement]
            public string reward { get; set; } = "";

            [XmlElement]
            public int progNotif { get; set; } = -1;

            [XmlElement]
            public string walkerGearCoordinates { get; set; } = "";

            [XmlElement]
            public string hostageCoordinates { get; set; } = "";

            [XmlElement]
            public string vehicleCoordinates { get; set; } = "";

            [XmlElement]
            public string animalCoordinates { get; set; } = "";

            [XmlElement]
            public string itemCoordinates { get; set; } = "";

            [XmlElement]
            public string activeItemCoordinates { get; set; } = "";

            [XmlElement]
            public string modelCoordinates { get; set; } = "";

            [XmlElement]
            public string routeName { get; set; } = "";

        }

        [XmlType("QuestObjects")]
        public class QuestEntities
        {

            public QuestEntities() { }

            public QuestEntities(List<Enemy> questenedets, List<Enemy> cpenedets, List<Helicopter> helis, List<Hostage> hosDets, List<WalkerGear> walkers, List<Vehicle> vehDets, List<Animal> anidets, List<Item> itDets, List<ActiveItem> acitdets, List<Model> MdDets, int bodyIndex, bool inter, string sst, string eneObjType, string hosObjType, string vehObjType, string aniObjType, string walkerObjType, string acItObjType)
            {
                questEnemies = questenedets;
                cpEnemies = cpenedets;
                enemyHelicopters = helis;
                hostages = hosDets;
                walkerGears = walkers;
                vehicles = vehDets;
                items = itDets;
                models = MdDets;
                activeItems = acitdets;
                animals = anidets;
                hostageBodyIndex = bodyIndex;
                canInter = inter;
                soldierSubType = sst;
                enemyObjectiveType = eneObjType;
                hostageObjectiveType = hosObjType;
                vehicleObjectiveType = vehObjType;
                animalObjectiveType = aniObjType;
                walkerGearObjectiveType = walkerObjType;
                activeItemObjectiveType = acItObjType;
            }

            [XmlArray]
            public List<Enemy> questEnemies { get; set; } = new List<Enemy>();

            [XmlArray]
            public List<Enemy> cpEnemies { get; set; } = new List<Enemy>();

            [XmlArray]
            public List<Hostage> hostages { get; set; } = new List<Hostage>();

            [XmlArray]
            public List<Helicopter> enemyHelicopters { get; set; } = new List<Helicopter>();

            [XmlArray]
            public List<WalkerGear> walkerGears { get; set; } = new List<WalkerGear>();

            [XmlArray]
            public List<Vehicle> vehicles { get; set; } = new List<Vehicle>();

            [XmlArray]
            public List<Item> items { get; set; } = new List<Item>();

            [XmlArray]
            public List<Model> models { get; set; } = new List<Model>();

            [XmlArray]
            public List<ActiveItem> activeItems { get; set; } = new List<ActiveItem>();

            [XmlArray]
            public List<Animal> animals { get; set; } = new List<Animal>();

            [XmlAttribute]
            public int hostageBodyIndex { get; set; } = 0;

            [XmlAttribute]
            public bool canInter { get; set; } = false;

            [XmlAttribute]
            public string soldierSubType { get; set; } = "SOVIET_A";

            [XmlAttribute]
            public string enemyObjectiveType { get; set; } = "ELIMINATE";

            [XmlAttribute]
            public string hostageObjectiveType { get; set; } = "ELIMINATE";

            [XmlAttribute]
            public string vehicleObjectiveType { get; set; } = "ELIMINATE";

            [XmlAttribute]
            public string animalObjectiveType { get; set; } = "ELIMINATE";

            [XmlAttribute]
            public string walkerGearObjectiveType { get; set; } = "ELIMINATE";

            [XmlAttribute]
            public string activeItemObjectiveType { get; set; } = "ELIMINATE";

        }

        public class Enemy
        {

            public Enemy() { }

            public Enemy(EnemyBox d, int num)
            {
                isSpawn = d.e_checkBox_spawn.Checked;
                isTarget = d.e_checkBox_target.Checked;
                isBalaclava = d.e_checkBox_balaclava.Checked;
                isZombie = d.e_checkBox_zombie.Checked;
                isArmored = d.e_checkBox_armor.Checked;
                number = num;
                name = d.e_groupBox_main.Text;
                body = d.e_comboBox_body.Text;
                cRoute = d.e_comboBox_cautionroute.Text;
                dRoute = d.e_comboBox_sneakroute.Text;
                skill = d.e_comboBox_skill.Text;
                staffType = d.e_comboBox_staff.Text;
                string[] powerArray = new string[d.e_listBox_power.Items.Count];
                d.e_listBox_power.Items.CopyTo(powerArray, 0);
                powers = powerArray;
            }

            public Enemy(int num, string nme)
            {
                number = num; name = nme;
            }

            [XmlElement]
            public bool isSpawn { get; set; } = false;

            [XmlElement]
            public bool isTarget { get; set; } = false;

            [XmlElement]
            public bool isBalaclava { get; set; } = false;

            [XmlElement]
            public bool isZombie { get; set; } = false;

            [XmlElement]
            public bool isArmored { get; set; } = false;

            [XmlElement]
            public int number { get; set; } = 0;

            [XmlAttribute]
            public string name { get; set; } = "sol_quest_0000";

            [XmlElement]
            public string body { get; set; } = "DEFAULT";

            [XmlElement]
            public string cRoute { get; set; } = "NONE";

            [XmlElement]
            public string dRoute { get; set; } = "NONE";

            [XmlElement]
            public string skill { get; set; } = "NONE";

            [XmlElement]
            public string staffType { get; set; } = "NONE";

            [XmlArray]
            public string[] powers { get; set; } = new string[0];
            
        }

        public class Helicopter
        {
            public Helicopter() { }

            public Helicopter(HelicopterBox he)
            {
                isSpawn = he.He_checkBox_spawn.Checked;
                isTarget = he.He_checkBox_target.Checked;
                heliRoute = he.He_comboBox_route.Text;
                heliClass = he.He_comboBox_class.Text;
            }

            [XmlElement]
            public bool isTarget { get; set; } = false;

            [XmlElement]
            public bool isSpawn { get; set; } = false;

            [XmlElement]
            public string heliRoute { get; set; } = "NONE";

            [XmlElement]
            public string heliClass { get; set; } = "DEFAULT";

        }
            
        public class Hostage
        {

            public Hostage() { }

            public Hostage(HostageBox d, int num) {
                isTarget = d.h_checkBox_target.Checked;
                isUntied = d.h_checkBox_untied.Checked;
                isInjured = d.h_checkBox_injured.Checked;
                number = num;
                name = d.h_groupBox_main.Text;
                skill = d.h_comboBox_skill.Text;
                staffType = d.h_comboBox_staff.Text;
                scared = d.h_comboBox_scared.Text;
                language = d.h_comboBox_lang.Text;
                coordinates = new Coordinates(d.h_textBox_xcoord.Text, d.h_textBox_ycoord.Text, d.h_textBox_zcoord.Text, d.h_textBox_rot.Text);
            }

            public Hostage(Coordinates coords, int num, string nme)
            {
                coordinates = coords; number = num; name = nme;
            }

            [XmlElement]
            public bool isTarget { get; set; } = false;

            [XmlElement]
            public bool isUntied { get; set; } = false;

            [XmlElement]
            public bool isInjured { get; set; } = false;

            [XmlElement]
            public int number { get; set; } = 0;

            [XmlAttribute]
            public string name { get; set; } = "Hostage_0";

            [XmlElement]
            public string skill { get; set; } = "NONE";

            [XmlElement]
            public string staffType { get; set; } = "NONE";

            [XmlElement]
            public string scared { get; set; } = "NORMAL";

            [XmlElement]
            public string language { get; set; } = "english";

            [XmlElement]
            public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0", "0");

        }

        public class Vehicle
        {

            public Vehicle() { }

            public Vehicle(VehicleBox d, int num)
            {
                isTarget = d.v_checkBox_target.Checked;
                number = num;
                name = d.v_groupBox_main.Text;
                vehicleIndex = d.v_comboBox_vehicle.SelectedIndex;
                vehicleClass = d.v_comboBox_class.Text;
                coordinates = new Coordinates(d.v_textBox_xcoord.Text, d.v_textBox_ycoord.Text, d.v_textBox_zcoord.Text, d.v_textBox_rot.Text);
            }

            public Vehicle(Coordinates coords, int num, string nme)
            {
                coordinates = coords; number = num; name = nme;
            }

            [XmlElement]
            public bool isTarget { get; set; } = false;

            [XmlElement]
            public int number { get; set; } = 0;

            [XmlAttribute]
            public string name { get; set; } = "Vehicle_0";

            [XmlElement]
            public int vehicleIndex { get; set; } = 0;

            [XmlElement]
            public string vehicleClass { get; set; } = "DEFAULT";

            [XmlElement]
            public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0", "0");

        }

        public class WalkerGear
        {

            public WalkerGear() { }

            public WalkerGear(WalkerGearBox walkerBox, int num)
            {
                isTarget = walkerBox.wg_checkBox_target.Checked;
                number = num;
                name = walkerBox.wg_groupBox_main.Text;
                rider = walkerBox.wg_comboBox_rider.Text;
                color = walkerBox.wg_comboBox_paint.Text;
                weapon = walkerBox.wg_comboBox_weapon.Text;
                coordinates = new Coordinates(walkerBox.wg_textBox_xcoord.Text, walkerBox.wg_textBox_ycoord.Text, walkerBox.wg_textBox_zcoord.Text, walkerBox.wg_textBox_rot.Text);
            }
            
            public WalkerGear(Coordinates coords, int num, string nme)
            {
                coordinates = coords; number = num; name = nme;
            }

            [XmlElement]
            public bool isTarget { get; set; } = false;

            [XmlElement]
            public int number { get; set; } = 0;

            [XmlAttribute]
            public string name { get; set; } = "WalkerGear_0";

            [XmlElement]
            public string rider { get; set; } = "NONE";

            [XmlElement]
            public string color { get; set; } = "SOVIET";

            [XmlElement]
            public string weapon { get; set; } = "WG_MACHINEGUN";

            [XmlElement]
            public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0", "0");

        }

        public class Animal
        {

            public Animal() { }

            public Animal(AnimalBox d, int num)
            {
                isTarget = d.a_checkBox_isTarget.Checked;
                number = num;
                name = d.a_groupBox_main.Text;
                count = d.a_comboBox_count.Text;
                animal = d.a_comboBox_animal.Text;
                typeID = d.a_comboBox_TypeID.Text;
                coordinates = new Coordinates(d.a_textBox_xcoord.Text, d.a_textBox_ycoord.Text, d.a_textBox_zcoord.Text, d.a_textBox_rot.Text);
            }

            public Animal(Coordinates coords, int num, string nme)
            {
                coordinates = coords; number = num; name = nme;
            }

            [XmlElement]
            public bool isTarget { get; set; } = false;

            [XmlElement]
            public int number { get; set; } = 0;

            [XmlAttribute]
            public string name { get; set; } = "Animal_Cluster_0";

            [XmlElement]
            public string count { get; set; } = "1";

            [XmlElement]
            public string animal { get; set; } = "Sheep";

            [XmlElement]
            public string typeID { get; set; } = "TppGoat";

            [XmlElement]
            public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0", "0");

        }

        public class Item
        {
            
            public Item() { }

            public Item(ItemBox d, int num)
            {
                number = num; isTarget = d.i_checkBox_target.Checked;
                isBoxed = d.i_checkBox_boxed.Checked;
                name = d.i_groupBox_main.Text;
                count = d.i_comboBox_count.Text;
                item = d.i_comboBox_item.Text;
                coordinates = new Coordinates(d.i_textBox_xcoord.Text, d.i_textBox_ycoord.Text, d.i_textBox_zcoord.Text);
                quatCoordinates = new RotationQuat(d.i_textBox_xrot.Text, d.i_textBox_yrot.Text, d.i_textBox_zrot.Text, d.i_textBox_wrot.Text);
                coordinates.roty = Fox2Info.getDegreeRot(quatCoordinates.yval);
            }

            public Item(Coordinates coords, int num, string nme)
            {
                coordinates = coords; number = num; name = nme;
                quatCoordinates.yval = Fox2Info.getQuaternionY(coords.roty);
                quatCoordinates.wval = Fox2Info.getQuaternionW(coords.roty);
            }

            public void setRotation(Coordinates coords)
            {
                quatCoordinates.yval = Fox2Info.getQuaternionY(coords.roty);
                quatCoordinates.wval = Fox2Info.getQuaternionW(coords.roty);
            }

            [XmlElement]
            public bool isBoxed { get; set; } = false;

            [XmlElement]
            public bool isTarget { get; set; } = false;

            [XmlElement]
            public int number { get; set; } = 0;

            [XmlAttribute]
            public string name { get; set; } = "Item_0";

            [XmlElement]
            public string count { get; set; } = "1";

            [XmlElement]
            public string item { get; set; } = "EQP_SWP_Magazine";

            [XmlElement]
            public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0");

            [XmlElement]
            public RotationQuat quatCoordinates { get; set; } = new RotationQuat("0", "0", "0", "0");

        }
        
        public class ActiveItem
        {

            public ActiveItem() { }

            public ActiveItem(ActiveItemBox d, int num)
            {
                number = num; isTarget = d.ai_checkBox_target.Checked;
                name = d.ai_groupBox_main.Text;
                activeItem = d.ai_comboBox_activeitem.Text;
                coordinates = new Coordinates(d.ai_textBox_xcoord.Text, d.ai_textBox_ycoord.Text, d.ai_textBox_zcoord.Text);
                quatCoordinates = new RotationQuat(d.ai_textBox_xrot.Text, d.ai_textBox_yrot.Text, d.ai_textBox_zrot.Text, d.ai_textBox_wrot.Text);
                coordinates.roty = Fox2Info.getDegreeRot(quatCoordinates.yval);
            }

            public ActiveItem(Coordinates coords, int num, string nme)
            {
                coordinates = coords; number = num; name = nme;
                quatCoordinates.yval = Fox2Info.getQuaternionY(coords.roty);
                quatCoordinates.wval = Fox2Info.getQuaternionW(coords.roty);
            }

            public void setRotation(Coordinates coords)
            {
                quatCoordinates.yval = Fox2Info.getQuaternionY(coords.roty);
                quatCoordinates.wval = Fox2Info.getQuaternionW(coords.roty);
            }

            [XmlElement]
            public int number { get; set; } = 0;

            [XmlElement]
            public bool isTarget { get; set; } = false;

            [XmlAttribute]
            public string name { get; set; } = "Active_Item_0";

            [XmlElement]
            public string activeItem { get; set; } = "EQP_SWP_DMine";

            [XmlElement]
            public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0");

            [XmlElement]
            public RotationQuat quatCoordinates { get; set; } = new RotationQuat("0", "0", "0", "0");

        }

        public class Model
        {

            public Model() { }

            public Model(ModelBox d, int num)
            {
                missingGeom = d.m_label_GeomNotFound.Visible;
                number = num;
                name = d.m_groupBox_main.Text;
                model = d.m_comboBox_preset.Text;
                coordinates = new Coordinates(d.m_textBox_xcoord.Text, d.m_textBox_ycoord.Text, d.m_textBox_zcoord.Text);
                quatCoordinates = new RotationQuat(d.m_textBox_xrot.Text, d.m_textBox_yrot.Text, d.m_textBox_zrot.Text, d.m_textBox_wrot.Text);
                coordinates.roty = Fox2Info.getDegreeRot(quatCoordinates.yval);
            }

            public Model(Coordinates coords, int num, string nme)
            {
                coordinates = coords; number = num; name = nme;
                quatCoordinates.yval = Fox2Info.getQuaternionY(coords.roty);
                quatCoordinates.wval = Fox2Info.getQuaternionW(coords.roty);
            }

            public void setRotation(Coordinates coords)
            {
                quatCoordinates.yval = Fox2Info.getQuaternionY(coords.roty);
                quatCoordinates.wval = Fox2Info.getQuaternionW(coords.roty);
            }

            [XmlElement]
            public bool missingGeom { get; set; } = true;

            [XmlElement]
            public int number { get; set; } = 0;

            [XmlAttribute]
            public string name { get; set; } = "Model_0";

            [XmlElement]
            public string model { get; set; } = "";

            [XmlElement]
            public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0");

            [XmlElement]
            public RotationQuat quatCoordinates { get; set; } = new RotationQuat("0", "0", "0", "0");

        }


        [XmlType("Coordinates")]
        public class Coordinates
        {

            public Coordinates() { }

            public Coordinates(string x, string y, string z, string rot = "0")
            {
                xCoord = x;
                yCoord = y;
                zCoord = z;
                roty = rot;
            }

            [XmlElement]
            public string xCoord;

            [XmlElement]
            public string yCoord;

            [XmlElement]
            public string zCoord;

            [XmlElement]
            public string roty;
            
        }

        [XmlType("RotationQuat")]
        public class RotationQuat
        {

            public RotationQuat() { }

            public RotationQuat(string x, string y, string z, string w)
            {
                xval = x;
                yval = y;
                zval = z;
                wval = w;
            }

            [XmlElement]
            public string xval;

            [XmlElement]
            public string yval;

            [XmlElement]
            public string zval;

            [XmlElement]
            public string wval;
            
        }

    }
}