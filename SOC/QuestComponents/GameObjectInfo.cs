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

    }
}