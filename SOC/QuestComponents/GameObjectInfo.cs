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
        public static string[] Str32Array =
        {
            "EQP_AB_Item = 3701051719",
            "EQP_AB_Mecha = 1087922814",
            "EQP_AB_PrimaryCommon = 3636743652",
            "EQP_AB_PrimaryMissile = 165673314",
            "EQP_AB_PrimaryMissileTranq = 2632867348",
            "EQP_AB_PrimaryTranq = 3838800485",
            "EQP_AB_SecondaryCommon = 2648389228",
            "EQP_AB_SecondaryTranq = 550443242",
            "EQP_AB_Support = 1584841319",
            "EQP_AB_Suppressor = 2248319796",
            "EQP_AM_10001 = 942386689",
            "EQP_AM_10003 = 744457620",
            "EQP_AM_10015 = 1358446639",
            "EQP_AM_1003a = 3865925797",
            "EQP_AM_10101 = 3763602871",
            "EQP_AM_10103 = 1117855202",
            "EQP_AM_10125 = 365499484",
            "EQP_AM_10134 = 240002840",
            "EQP_AM_10201 = 145874407",
            "EQP_AM_10203 = 3011332882",
            "EQP_AM_10214 = 2861513002",
            "EQP_AM_10302 = 2120008197",
            "EQP_AM_10303 = 1915144394",
            "EQP_AM_10305 = 2173158461",
            "EQP_AM_10403 = 2640427390",
            "EQP_AM_10404 = 4101749406",
            "EQP_AM_10405 = 2277386885",
            "EQP_AM_10407 = 726461515",
            "EQP_AM_10503 = 3253056461",
            "EQP_AM_10515 = 2254235644",
            "EQP_AM_10526 = 405330773",
            "EQP_AM_20002 = 1318930306",
            "EQP_AM_20003 = 1430896920",
            "EQP_AM_20005 = 2168524468",
            "EQP_AM_20103 = 3695338189",
            "EQP_AM_20104 = 397061487",
            "EQP_AM_20105 = 3774968955",
            "EQP_AM_20106 = 4262765224",
            "EQP_AM_20116 = 3578910857",
            "EQP_AM_20203 = 3795859629",
            "EQP_AM_20206 = 3141003267",
            "EQP_AM_20302 = 3200494389",
            "EQP_AM_20303 = 2730924595",
            "EQP_AM_20304 = 208460826",
            "EQP_AM_20305 = 41987348",
            "EQP_AM_30001 = 1604283350",
            "EQP_AM_30003 = 2801949682",
            "EQP_AM_30014 = 2805408094",
            "EQP_AM_30034 = 1865417414",
            "EQP_AM_30043 = 3168448727",
            "EQP_AM_30047 = 1956400477",
            "EQP_AM_30054 = 570000243",
            "EQP_AM_30055 = 3699467218",
            "EQP_AM_30102 = 233110227",
            "EQP_AM_30103 = 2413361028",
            "EQP_AM_30123 = 2500994915",
            "EQP_AM_30125 = 3001943870",
            "EQP_AM_30201 = 659671488",
            "EQP_AM_30203 = 3325870963",
            "EQP_AM_30223 = 36512606",
            "EQP_AM_30225 = 2273310016",
            "EQP_AM_30232 = 2308649588",
            "EQP_AM_30303 = 2656667019",
            "EQP_AM_30305 = 4210003792",
            "EQP_AM_30306 = 2445577938",
            "EQP_AM_30325 = 3963562310",
            "EQP_AM_40001 = 4160422845",
            "EQP_AM_40004 = 2800769517",
            "EQP_AM_40012 = 3347515566",
            "EQP_AM_40015 = 3271835704",
            "EQP_AM_40023 = 4149411751",
            "EQP_AM_40102 = 4209479459",
            "EQP_AM_40105 = 514409796",
            "EQP_AM_40115 = 2921367150",
            "EQP_AM_40123 = 3188294448",
            "EQP_AM_40126 = 1872840152",
            "EQP_AM_40133 = 2966274613",
            "EQP_AM_40135 = 845376444",
            "EQP_AM_40136 = 90153563",
            "EQP_AM_40143 = 3381456965",
            "EQP_AM_40203 = 4268762764",
            "EQP_AM_40204 = 3278162543",
            "EQP_AM_40206 = 3327866036",
            "EQP_AM_40304 = 963486475",
            "EQP_AM_50102 = 3662130966",
            "EQP_AM_50115 = 1899736379",
            "EQP_AM_50126 = 2332536486",
            "EQP_AM_50136 = 3314734774",
            "EQP_AM_50147 = 3855601427",
            "EQP_AM_50202 = 3535171861",
            "EQP_AM_50215 = 1508343740",
            "EQP_AM_50226 = 2963941635",
            "EQP_AM_50237 = 2940728864",
            "EQP_AM_50303 = 3659669131",
            "EQP_AM_50304 = 694095484",
            "EQP_AM_50306 = 943084575",
            "EQP_AM_60001 = 883006582",
            "EQP_AM_60007 = 2994367062",
            "EQP_AM_60013 = 215543032",
            "EQP_AM_60102 = 1351531735",
            "EQP_AM_60107 = 2371946254",
            "EQP_AM_60114 = 2086864608",
            "EQP_AM_60203 = 1414760875",
            "EQP_AM_60303 = 3975999681",
            "EQP_AM_60315 = 2041958517",
            "EQP_AM_60325 = 2207493696",
            "EQP_AM_60404 = 4226965578",
            "EQP_AM_60406 = 3227953282",
            "EQP_AM_60415 = 3993363145",
            "EQP_AM_60417 = 459222973",
            "EQP_AM_70002 = 2358887088",
            "EQP_AM_70003 = 766255576",
            "EQP_AM_70005 = 2632349685",
            "EQP_AM_70103 = 3510080321",
            "EQP_AM_70104 = 4134048866",
            "EQP_AM_70105 = 1596949892",
            "EQP_AM_70114 = 1774493529",
            "EQP_AM_70115 = 2347306227",
            "EQP_AM_70116 = 1264841501",
            "EQP_AM_70125 = 742780294",
            "EQP_AM_70126 = 3385458845",
            "EQP_AM_70127 = 2776039916",
            "EQP_AM_70203 = 2803884036",
            "EQP_AM_70204 = 3070302356",
            "EQP_AM_70205 = 2093360574",
            "EQP_AM_EX_gl_000 = 447926378",
            "EQP_AM_EX_hg_000 = 473727751",
            "EQP_AM_EX_hg_010 = 1937218480",
            "EQP_AM_EX_sr_000 = 3470110506",
            "EQP_AM_Pr_ar_010 = 1631123210",
            "EQP_AM_Pr_sg_010 = 3706531358",
            "EQP_AM_Pr_sm_010 = 2193416726",
            "EQP_AM_Pr_sr_010 = 2450674805",
            "EQP_AM_Quiet_sr_010 = 2683522218",
            "EQP_AM_Quiet_sr_020 = 2872633414",
            "EQP_AM_Quiet_sr_030 = 1662206366",
            "EQP_AM_SP_hg_010 = 2289842122",
            "EQP_AM_SP_hg_020 = 797833356",
            "EQP_AM_SP_sg_010 = 1414996770",
            "EQP_AM_SP_sm_010 = 782405644",
            "EQP_AM_SkullFace_hg_010 = 1389072866",
            "EQP_BL_20mmGrenade = 471160147",
            "EQP_BL_20mmRocket = 4210772381",
            "EQP_BL_20mmSleep = 3495970553",
            "EQP_BL_20mmSmoke = 2543528557",
            "EQP_BL_20mmStun = 823050362",
            "EQP_BL_40mmGrenade = 3401287737",
            "EQP_BL_40mmSleep = 4258340665",
            "EQP_BL_40mmSmoke = 2091250291",
            "EQP_BL_40mmStun = 586553044",
            "EQP_BL_Cannon = 3652026893",
            "EQP_BL_EX_gl_000 = 424293115",
            "EQP_BL_Flare = 199958230",
            "EQP_BL_HgGrenade = 289902459",
            "EQP_BL_HgSleep = 408995493",
            "EQP_BL_HgSmoke = 1869526419",
            "EQP_BL_HgStun = 2632082634",
            "EQP_BL_Mortar = 3241565003",
            "EQP_BL_RocketPunchBlast = 1370836470",
            "EQP_BL_RocketPunchStun = 1273187832",
            "EQP_BL_SupplyBomb = 674937096",
            "EQP_BL_SupplyChaff = 3855377204",
            "EQP_BL_SupplySleep = 959291929",
            "EQP_BL_SupplySmoke = 794798824",
            "EQP_BL_TankCannon = 1032822480",
            "EQP_BL_TankCannonHoming = 3839775256",
            "EQP_BL_Tankgun_105mmRifledBoreGun = 3352078975",
            "EQP_BL_Tankgun_105mmRifledBoreGun_Homing = 2774022405",
            "EQP_BL_Tankgun_120mmSmoothBoreGun = 2402436344",
            "EQP_BL_Tankgun_120mmSmoothBoreGun_Homing = 3347454244",
            "EQP_BL_Tankgun_125mmSmoothBoreGun = 685053113",
            "EQP_BL_Tankgun_125mmSmoothBoreGun_Homing = 3524114420",
            "EQP_BL_Tankgun_82mmRocketPoweredProjectile = 1681994303",
            "EQP_BL_Tankgun_MultipleRocketLauncher = 937617026",
            "EQP_BL_UavGrenade = 545284451",
            "EQP_BL_UavSleepGasGrenade = 2053278280",
            "EQP_BL_UavSmokeGrenade = 156816365",
            "EQP_BL_WavCannon = 2896605544",
            "EQP_BL_WavCannonHoming = 1022193325",
            "EQP_BL_WavRocket = 489075643",
            "EQP_BL_mgm0_ammo0 = 1481356880",
            "EQP_BL_mgm0_cmn_ammo0 = 1066023737",
            "EQP_BL_mgm0_cmn_ammo1 = 510708170",
            "EQP_BL_mgm0_famo0 = 338342908",
            "EQP_BL_mgs0_grnd0 = 1398858507",
            "EQP_BL_mgs0_miss0 = 1751023113",
            "EQP_BL_mgs0_miss1 = 2402016362",
            "EQP_BL_mgs0_srcm0 = 1027474130",
            "EQP_BL_ms00 = 4008999740",
            "EQP_BL_ms00_G2 = 3504807822",
            "EQP_BL_ms00_G3 = 3706299389",
            "EQP_BL_ms01 = 3989756358",
            "EQP_BL_ms01_Child = 1806636541",
            "EQP_BL_ms01_G2 = 1657148044",
            "EQP_BL_ms01_G2_Child = 599094933",
            "EQP_BL_ms01_G3 = 833395813",
            "EQP_BL_ms01_G3_Child = 1761270286",
            "EQP_BL_ms01_G4 = 421231201",
            "EQP_BL_ms01_G4_Child = 2604275811",
            "EQP_BL_ms02 = 3640933022",
            "EQP_BL_ms02F = 3538607968",
            "EQP_BL_ms02F_G2 = 951821876",
            "EQP_BL_ms02F_G3 = 3788033983",
            "EQP_BL_ms02Fulton = 3182611276",
            "EQP_BL_ms02Sleep = 1655113344",
            "EQP_BL_ms02_G2 = 3817384181",
            "EQP_BL_ms02_G3 = 668070489",
            "EQP_BL_ms03 = 414523170",
            "EQP_BL_ms03_G2 = 1674028063",
            "EQP_BL_ms03_G3 = 1309977657",
            "EQP_BL_ms03_G4 = 3810026717",
            "EQP_BL_uth0_ammo0 = 1342437695",
            "EQP_BL_uth0_ammo1 = 3325619747",
            "EQP_BX_Primary = 2965041888",
            "EQP_BX_Secondary = 275830932",
            "EQP_BX_Support = 1539203178",
            "EQP_HAND_GOLD = 2555823993",
            "EQP_HAND_JEHUTY = 2490913558",
            "EQP_HAND_KILL_ROCKET = 4056597849",
            "EQP_HAND_NORMAL = 3199053329",
            "EQP_HAND_SILVER = 2585824023",
            "EQP_HAND_STUNARM = 2851473425",
            "EQP_HAND_STUN_ROCKET = 1088650704",
            "EQP_IT_BayonetWest = 2958564855",
            "EQP_IT_Binocle = 309978643",
            "EQP_IT_BottleLiquid = 4271227325",
            "EQP_IT_CBox_BOLE = 376120247",
            "EQP_IT_CBox_BOLE_G01 = 3228989621",
            "EQP_IT_CBox_CITY = 1420468688",
            "EQP_IT_CBox_CITY_G01 = 1112955485",
            "EQP_IT_CBox_CLB_A = 2472083186",
            "EQP_IT_CBox_CLB_A_G01 = 3408044433",
            "EQP_IT_CBox_CLB_B = 4208414082",
            "EQP_IT_CBox_CLB_B_G01 = 1343734093",
            "EQP_IT_CBox_CLB_C = 3852094676",
            "EQP_IT_CBox_CLB_C_G01 = 36321842",
            "EQP_IT_CBox_DSR = 215757141",
            "EQP_IT_CBox_DSR_G01 = 824474964",
            "EQP_IT_CBox_DSR_G02 = 2538764310",
            "EQP_IT_CBox_FRST = 1184162712",
            "EQP_IT_CBox_FRST_G01 = 1284424128",
            "EQP_IT_CBox_LIMITED = 562208995",
            "EQP_IT_CBox_LIMITED_G01 = 3131160279",
            "EQP_IT_CBox_SMK = 199206201",
            "EQP_IT_CBox_WR = 3040902098",
            "EQP_IT_Cassette = 3115897383",
            "EQP_IT_Cigarette = 218870227",
            "EQP_IT_CigaretteCase = 114400128",
            "EQP_IT_Clairvoyance = 1743804179",
            "EQP_IT_CureSpray = 3073940205",
            "EQP_IT_DDogStunLod = 2132483414",
            "EQP_IT_DevelopmentFile = 4154155589",
            "EQP_IT_FilmCase = 3467346754",
            "EQP_IT_Fulton = 2020961543",
            "EQP_IT_Fulton_Cargo = 789783388",
            "EQP_IT_Fulton_Child = 1732648546",
            "EQP_IT_Fulton_WormHole = 194136571",
            "EQP_IT_GasMask = 1958929861",
            "EQP_IT_HandyLight = 3260951228",
            "EQP_IT_IDroid = 515927244",
            "EQP_IT_Infected = 1829282362",

            "EQP_IT_InstantStealth = 633414155",

            "EQP_IT_Knife = 1625758311",
            "EQP_IT_KnifeLiquid = 1634943786",
            "EQP_IT_KnifePF = 3962271739",
            "EQP_IT_Machete = 3888944926",
            "EQP_IT_MacheteLiquid = 775241128",
            "EQP_IT_Nvg = 2704689080",
            "EQP_IT_ParasiteCamouf = 3675306451",
            "EQP_IT_ParasiteHard = 2481641904",
            "EQP_IT_ParasiteMist = 2696887792",

            "EQP_IT_Pentazemin = 3282036821",

            "EQP_IT_PickingToolL = 1818878992",
            "EQP_IT_PickingToolR = 2371811700",
            "EQP_IT_PipeLiquid = 4147360598",
            "EQP_IT_Radio = 66149589",

            "EQP_IT_ReflexMedicine = 796139346",

            "EQP_IT_SKnife = 2187881504",
            "EQP_IT_SRadio = 459927039",
            "EQP_IT_ShellLiquid = 229617213",
            "EQP_IT_ShotShell = 1800345829",

            "EQP_IT_Stealth = 195059527",

            "EQP_IT_Telescope = 3274141297",

            "EQP_IT_TimeCigarette = 3475942585",
            "EQP_IT_mgs0_msbl0 = 558066791",
            "EQP_SLD_DD = 22715550",
            "EQP_SLD_DD_01 = 2412339677",
            "EQP_SLD_DD_G02 = 2338929536",
            "EQP_SLD_DD_G03 = 1817573585",
            "EQP_SLD_PF_00 = 111660325",
            "EQP_SLD_PF_01 = 717613654",
            "EQP_SLD_PF_02 = 1034025940",
            "EQP_SLD_SV = 3569226671",

            "EQP_SWP_ActiveDecoy = 631777925",
            "EQP_SWP_ActiveDecoy_G01 = 125435196",
            "EQP_SWP_ActiveDecoy_G02 = 1572261594",
            "EQP_SWP_AntitankMine = 2380434448",
            "EQP_SWP_AntitankMine_G01 = 3398829166",
            "EQP_SWP_AntitankMine_G02 = 553841645",
            "EQP_SWP_C4 = 2248417544",
            "EQP_SWP_C4_G01 = 3680273883",
            "EQP_SWP_C4_G02 = 1638061628",
            "EQP_SWP_C4_G03 = 1245836066",
            "EQP_SWP_C4_G04 = 1330467844",
            "EQP_SWP_CaptureCage = 1711629690",
            "EQP_SWP_CaptureCage_G01 = 552167052",
            "EQP_SWP_CaptureCage_G02 = 452941044",
            "EQP_SWP_DMine = 269631637",
            "EQP_SWP_DMineLocator = 3866854189",
            "EQP_SWP_DMine_G01 = 593832643",
            "EQP_SWP_DMine_G02 = 1837867390",
            "EQP_SWP_DMine_G03 = 470410001",
            "EQP_SWP_Decoy = 3951752765",
            "EQP_SWP_Decoy_G01 = 3518196155",
            "EQP_SWP_Decoy_G02 = 672800204",
            "EQP_SWP_Dung = 775449917",
            "EQP_SWP_ElectromagneticNetMine = 1397745267",
            "EQP_SWP_ElectromagneticNetMine_G01 = 853152114",
            "EQP_SWP_ElectromagneticNetMine_G02 = 4231263272",
            "EQP_SWP_ShockDecoy = 3164016199",
            "EQP_SWP_ShockDecoy_G01 = 3147793694",
            "EQP_SWP_ShockDecoy_G02 = 2575886044",
            "EQP_SWP_ShockDecoy_G03 = 104841607",
            "EQP_SWP_ShockDecoy_G04 = 2999447259",
            "EQP_SWP_SleepingGusMine = 2364332929",
            "EQP_SWP_SleepingGusMineLocator = 2265173",
            "EQP_SWP_SleepingGusMine_G01 = 3385519743",
            "EQP_SWP_SleepingGusMine_G02 = 1871659905",

            "EQP_SWP_FakeSign = 2285172609",
            "EQP_SWP_FakeSign_G01 = 4140878589",
            "EQP_SWP_FakeSign_G02 = 1600143726",
            "EQP_SWP_Grenade = 3234702229",
            "EQP_SWP_Grenade_G01 = 832826455",
            "EQP_SWP_Grenade_G02 = 3796343448",
            "EQP_SWP_Grenade_G03 = 1873153737",
            "EQP_SWP_Grenade_G04 = 4098463476",
            "EQP_SWP_Grenade_G05 = 4078051275",
            "EQP_SWP_Grenade_G06 = 3561818312",
            "EQP_SWP_Grenade_G07 = 4129918514",
            "EQP_SWP_Grenade_G08 = 896708107",
            "EQP_SWP_Kibidango = 1729095651",
            "EQP_SWP_Kibidango_G01 = 1517131214",
            "EQP_SWP_Kibidango_G02 = 3582842553",
            "EQP_SWP_Magazine = 1729400768",
            "EQP_SWP_MolotovCocktail = 3601061635",
            "EQP_SWP_MolotovCocktailPlaced = 1777800427",
            "EQP_SWP_MolotovCocktail_G01 = 369997865",
            "EQP_SWP_MolotovCocktail_G02 = 1861473252",
            
            "EQP_SWP_SleepingGusGrenade = 1767259635",
            "EQP_SWP_SleepingGusGrenade_G01 = 3842441047",
            "EQP_SWP_SleepingGusGrenade_G02 = 1322908006",
            "EQP_SWP_SmokeGrenade = 1340992856",
            "EQP_SWP_SmokeGrenade_G01 = 537949682",
            "EQP_SWP_SmokeGrenade_G02 = 26456530",
            "EQP_SWP_SmokeGrenade_G03 = 589912424",
            "EQP_SWP_SmokeGrenade_G04 = 488255820",
            "EQP_SWP_StunGrenade = 3139845",
            "EQP_SWP_StunGrenade_G01 = 1822086030",
            "EQP_SWP_StunGrenade_G02 = 220294450",
            "EQP_SWP_StunGrenade_G03 = 575899652",
            "EQP_SWP_StunGrenade_G04 = 4190956630",
            "EQP_SWP_StunGrenade_G05 = 1623851637",
            "EQP_SWP_StunGrenade_G06 = 1610924274",
            "EQP_SWP_SupplyFlareGrenade = 160773547",
            "EQP_SWP_SupplyFlareGrenade_G01 = 3893550372",
            "EQP_SWP_SupplyFlareGrenade_G02 = 2540455665",
            "EQP_SWP_SupportHeliFlareGrenade = 2929309074",
            "EQP_SWP_SupportHeliFlareGrenade_G01 = 3086998058",
            "EQP_SWP_SupportHeliFlareGrenade_G02 = 243879909",
            "EQP_SWP_WormholePortal = 1372924546",
            "EQP_WP_BossQuiet_sr_010 = 2618042870",
            "EQP_WP_Com_ms_010 = 2652843571",
            "EQP_WP_Com_ms_020 = 3563412907",
            "EQP_WP_Com_ms_023 = 2664947204",
            "EQP_WP_Com_ms_024 = 396880388",
            "EQP_WP_Com_ms_026 = 1379167173",
            "EQP_WP_Com_ms_029 = 2357381301",
            "EQP_WP_Com_ms_02a = 1836768007",
            "EQP_WP_Com_ms_02b = 1375549568",
            "EQP_WP_Com_sg_010 = 2381010158",
            "EQP_WP_Com_sg_011 = 3747062774",
            "EQP_WP_Com_sg_011_FL = 2128560303",
            "EQP_WP_Com_sg_013 = 2087323406",
            "EQP_WP_Com_sg_015 = 2166157937",
            "EQP_WP_Com_sg_016 = 3900424921",
            "EQP_WP_Com_sg_018 = 11678877",
            "EQP_WP_Com_sg_020 = 2359733399",
            "EQP_WP_Com_sg_020_FL = 2697773255",
            "EQP_WP_Com_sg_023 = 685340280",
            "EQP_WP_Com_sg_024 = 2582567510",
            "EQP_WP_Com_sg_025 = 2098920834",
            "EQP_WP_Com_sg_030 = 190258288",
            "EQP_WP_Com_sg_038 = 394470869",
            "EQP_WP_DEBUG_sr_010 = 1436774388",
            "EQP_WP_DEMO_ar_010 = 160662483",
            "EQP_WP_DEMO_ar_020 = 3771918338",
            "EQP_WP_DEMO_ar_030 = 433307492",
            "EQP_WP_DEMO_hg_010 = 1898602042",
            "EQP_WP_DEMO_hg_020 = 3524947650",
            "EQP_WP_DEMO_hg_030 = 3964973642",
            "EQP_WP_DEMO_mg_010 = 1275995190",
            "EQP_WP_DEMO_ms_010 = 58887870",
            "EQP_WP_DEMO_ms_020 = 3712341932",
            "EQP_WP_DEMO_sm_010 = 1278304055",
            "EQP_WP_DEMO_sm_020 = 1310216725",
            "EQP_WP_DEMO_sr_010 = 2392059727",
            "EQP_WP_EX_gl_000 = 4169556718",
            "EQP_WP_EX_hg_000 = 4001165168",
            "EQP_WP_EX_hg_000_G01 = 3070538266",
            "EQP_WP_EX_hg_000_G02 = 4042976828",
            "EQP_WP_EX_hg_000_G03 = 1803076094",
            "EQP_WP_EX_hg_000_G04 = 1974491201",
            "EQP_WP_EX_hg_010 = 4179299715",
            "EQP_WP_EX_hg_011 = 661561680",
            "EQP_WP_EX_hg_012 = 259280670",
            "EQP_WP_EX_hg_013 = 4140816574",
            "EQP_WP_EX_sr_000 = 2090616205",
            "EQP_WP_East_ar_010 = 3704165053",
            "EQP_WP_East_ar_010_FL = 1885486820",
            "EQP_WP_East_ar_020 = 71986377",
            "EQP_WP_East_ar_030 = 3749235060",
            "EQP_WP_East_ar_030_FL = 1354170242",
            "EQP_WP_East_hg_010 = 2217654729",
            "EQP_WP_East_mg_010 = 661011400",
            "EQP_WP_East_ms_010 = 2105861306",
            "EQP_WP_East_ms_020 = 4283898693",
            "EQP_WP_East_sm_010 = 3946739440",
            "EQP_WP_East_sm_020 = 3184048147",
            "EQP_WP_East_sm_030 = 3527995433",
            "EQP_WP_East_sm_042 = 922867167",
            "EQP_WP_East_sm_043 = 791075340",
            "EQP_WP_East_sm_044 = 2494251918",
            "EQP_WP_East_sm_045 = 2705262656",
            "EQP_WP_East_sm_047 = 1311125152",
            "EQP_WP_East_sm_049 = 3274521203",
            "EQP_WP_East_sm_04a = 3740898701",
            "EQP_WP_East_sm_04b = 3895755609",
            "EQP_WP_East_sr_011 = 1906730152",
            "EQP_WP_East_sr_020 = 1086503214",
            "EQP_WP_East_sr_032 = 2038260248",
            "EQP_WP_East_sr_033 = 3257743636",
            "EQP_WP_East_sr_034 = 879491589",
            "EQP_WP_HoneyBee = 4231865953",
            "EQP_WP_Pr_ar_010 = 2752575230",
            "EQP_WP_Pr_sg_010 = 1831103880",
            "EQP_WP_Pr_sm_010 = 2875847062",
            "EQP_WP_Pr_sr_010 = 2874762533",
            "EQP_WP_Quiet_sr_010 = 2766172832",
            "EQP_WP_Quiet_sr_020 = 1590199376",
            "EQP_WP_Quiet_sr_030 = 3624849955",
            "EQP_WP_SCamLocator = 4074839377",
            "EQP_WP_SP_SLD_010 = 379754007",
            "EQP_WP_SP_SLD_010_G01 = 1183548925",
            "EQP_WP_SP_SLD_010_G02 = 1994584569",
            "EQP_WP_SP_SLD_020 = 699691113",
            "EQP_WP_SP_SLD_020_G01 = 3082906773",
            "EQP_WP_SP_SLD_020_G02 = 1081206013",
            "EQP_WP_SP_SLD_030 = 2139666375",
            "EQP_WP_SP_SLD_030_G01 = 3841461941",
            "EQP_WP_SP_SLD_030_G02 = 349586244",
            "EQP_WP_SP_SLD_040 = 1899789585",
            "EQP_WP_SP_SLD_040_G01 = 2108543",
            "EQP_WP_SP_SLD_040_G02 = 1884865098",
            "EQP_WP_SP_hg_010 = 2950334174",
            "EQP_WP_SP_hg_020 = 2454332517",
            "EQP_WP_SP_sg_010 = 677450990",
            "EQP_WP_SP_sm_010 = 2054119593",
            "EQP_WP_SkullFace_hg_010 = 3041864382",
            "EQP_WP_Volgin_sg_010 = 239105661",
            "EQP_WP_West_ar_010 = 4047504990",
            "EQP_WP_West_ar_010_FL = 1428812365",
            "EQP_WP_West_ar_020 = 1717548004",
            "EQP_WP_West_ar_020_FL = 524826996",
            "EQP_WP_West_ar_030 = 936868182",
            "EQP_WP_West_ar_040 = 1858930399",
            "EQP_WP_West_ar_042 = 4117383222",
            "EQP_WP_West_ar_050 = 3459808140",
            "EQP_WP_West_ar_055 = 3558182609",
            "EQP_WP_West_ar_057 = 1614747202",
            "EQP_WP_West_ar_059 = 2562693040",
            "EQP_WP_West_ar_05a = 1100428604",
            "EQP_WP_West_ar_05b = 3052535988",
            "EQP_WP_West_ar_060 = 1638878583",
            "EQP_WP_West_ar_063 = 581070372",
            "EQP_WP_West_ar_070 = 3731644209",
            "EQP_WP_West_ar_075 = 1306820854",
            "EQP_WP_West_ar_077 = 222016352",
            "EQP_WP_West_ar_079 = 867571564",
            "EQP_WP_West_ar_07a = 841386652",
            "EQP_WP_West_ar_07b = 3593323316",
            "EQP_WP_West_hg_010 = 1638409701",
            "EQP_WP_West_hg_010_WG = 288388838",
            "EQP_WP_West_hg_020 = 2514863450",
            "EQP_WP_West_hg_030 = 1524001822",
            "EQP_WP_West_hg_030_cmn = 3072840360",
            "EQP_WP_West_mg_010 = 1372660584",
            "EQP_WP_West_mg_020 = 2601800033",
            "EQP_WP_West_mg_021 = 3908037870",
            "EQP_WP_West_mg_023 = 3014886100",
            "EQP_WP_West_mg_024 = 1779580382",
            "EQP_WP_West_mg_030 = 3716387981",
            "EQP_WP_West_mg_037 = 2727677479",
            "EQP_WP_West_mg_039 = 3676621319",
            "EQP_WP_West_mg_03a = 1856874736",
            "EQP_WP_West_mg_03b = 1186744014",
            "EQP_WP_West_ms_010 = 1753488422",
            "EQP_WP_West_ms_020 = 1022605058",
            "EQP_WP_West_ms_029 = 818028818",
            "EQP_WP_West_ms_02a = 1721169765",
            "EQP_WP_West_ms_02b = 2338667780",
            "EQP_WP_West_sm_010 = 3426343295",
            "EQP_WP_West_sm_010_WG = 139488615",
            "EQP_WP_West_sm_014 = 3278367546",
            "EQP_WP_West_sm_015 = 883704911",
            "EQP_WP_West_sm_016 = 4262421142",
            "EQP_WP_West_sm_017 = 2218447420",
            "EQP_WP_West_sm_019 = 2778816778",
            "EQP_WP_West_sm_01a = 4235743289",
            "EQP_WP_West_sm_01b = 695481464",
            "EQP_WP_West_sm_020 = 2582967869",
            "EQP_WP_West_sr_010 = 2739379538",
            "EQP_WP_West_sr_011 = 1107864457",
            "EQP_WP_West_sr_013 = 3912688988",
            "EQP_WP_West_sr_014 = 1732918664",
            "EQP_WP_West_sr_020 = 4085075673",
            "EQP_WP_West_sr_027 = 134305031",
            "EQP_WP_West_sr_029 = 512393922",
            "EQP_WP_West_sr_02a = 1805253821",
            "EQP_WP_West_sr_02b = 2933941681",
            "EQP_WP_West_sr_037 = 2728579426",
            "EQP_WP_West_sr_047 = 1720774172",
            "EQP_WP_West_sr_048 = 3773341461",
            "EQP_WP_West_sr_049 = 516141085",
            "EQP_WP_West_sr_04a = 2084326138",
            "EQP_WP_West_sr_04b = 3173901658",
            "EQP_WP_West_thg_010 = 3810173747",
            "EQP_WP_West_thg_020 = 4005258284",
            "EQP_WP_West_thg_030 = 1492927031",
            "EQP_WP_West_thg_040 = 275062985",
            "EQP_WP_West_thg_050 = 2481935090",
            "EQP_WP_Wood_ar_010 = 3997713692",
            "EQP_WP_mgm0_mgun0 = 433801869"
        };

        public static string EquipIDLookup(string wpName)
        {
            string ID = "NONE";

            foreach (string WpIDPair in Str32Array)
            {
                if (WpIDPair.Contains(wpName))
                {
                    ID = WpIDPair.Substring(wpName.Length + 3);
                    break;
                }
            }

            return ID;
        }

        public static bool isAfgh(int locId)
        {
            return locId == 10;
        }

        public static bool isMafr(int locId)
        {
            return locId == 20;
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

            public DefinitionDetails(string fpk, string quest, int locID, string loada, Coordinates c, string rad, string cat, string rew, int prog, string type, string cpnme, string qtitle, string qdesc, string hcoord, string vehcoord, string anicoord, string itcoord, string acitcoord, string mdlcoord)
            {
                FpkName = fpk; QuestNum = quest; QuestTitle = qtitle; QuestDesc = qdesc;

                locationID = locID; loadArea = loada; coords = c; radius = rad; CPName = cpnme;

                category = cat; progNotif = prog; objectiveType = type; reward = rew;
                
                hostageCoordinates = hcoord; vehicleCoordinates = vehcoord; animalCoordinates = anicoord; itemCoordinates = itcoord; activeItemCoordinates = acitcoord; modelCoordinates = mdlcoord;
            }

            [XmlElement]
            public string QuestTitle { get; set; }

            [XmlElement]
            public string QuestDesc { get; set; }

            [XmlAttribute]
            public string FpkName { get; set; }

            [XmlAttribute]
            public string QuestNum { get; set; }

            [XmlElement]
            public int locationID { get; set; }

            [XmlElement]
            public string loadArea { get; set; }

            [XmlElement]
            public Coordinates coords { get; set; }

            [XmlElement]
            public string radius { get; set; }

            [XmlElement]
            public string category { get; set; }

            [XmlElement]
            public string objectiveType { get; set; }

            [XmlElement]
            public string CPName { get; set; }

            [XmlElement]
            public string reward { get; set; }

            [XmlElement]
            public int progNotif { get; set; }

            [XmlElement]
            public string hostageCoordinates { get; set; }

            [XmlElement]
            public string vehicleCoordinates { get; set; }

            [XmlElement]
            public string animalCoordinates { get; set; }

            [XmlElement]
            public string itemCoordinates { get; set; }

            [XmlElement]
            public string activeItemCoordinates { get; set; }

            [XmlElement]
            public string modelCoordinates { get; set; }

        }

        [XmlType("QuestObjects")]
        public class QuestEntities
        {

            public QuestEntities() { }

            public QuestEntities(List<Enemy> questenedets, List<Enemy> cpenedets, List<Hostage> hosDets, List<Vehicle> vehDets, List<Animal> anidets, List<Item> itDets, List<ActiveItem> acitdets, List<Model> MdDets, int bodyIndex, bool inter, string sst)
            {
                questEnemies = questenedets;
                cpEnemies = cpenedets;
                hostages = hosDets;
                vehicles = vehDets;
                items = itDets;
                models = MdDets;
                activeItems = acitdets;
                animals = anidets;
                hostageBodyIndex = bodyIndex;
                canInter = inter;
                soldierSubType = sst;
            }

            [XmlArray]
            public List<Enemy> questEnemies { get; set; } = new List<Enemy>();

            [XmlArray]
            public List<Enemy> cpEnemies { get; set; } = new List<Enemy>();

            [XmlArray]
            public List<Hostage> hostages { get; set; } = new List<Hostage>();

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

        }

        public class Enemy
        {

            public Enemy() { }

            public Enemy(int num, string nme)
            {
                number = num; name = nme;
            }

            public Enemy(bool spawn, bool target, bool clava, bool zombie, bool armored, int num, string nme, string bod, string caution, string sneak, string skll, string staff, string[] pow)
            {
                isSpawn = spawn; isTarget = target; isBalaclava = clava; isZombie = zombie; isArmored = armored;
                number = num; name = nme;
                body = bod; cRoute = caution; dRoute = sneak; skill = skll; staffType = staff; powers = pow;
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
            
        public class Hostage
        {

            public Hostage() { }

            public Hostage(bool target, bool untied, bool injured, int num, string nme, string skll, string staff, string scare, string lang, Coordinates coords)
            {
                isTarget = target; isUntied = untied; isInjured = injured;
                number = num; name = nme;
                skill = skll; staffType = staff; scared = scare; language = lang;
                coordinates = coords;
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

            public Vehicle(bool target, int num, string nme, int veh, string clas, Coordinates coords)
            {
                isTarget = target;
                number = num; name = nme;
                vehicleIndex = veh; vehicleClass = clas;
                coordinates = coords;
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

        public class Animal
        {

            public Animal() { }

            public Animal(bool target, int num, string nme, string cnt, string ani, string type, Coordinates coords)
            {
                isTarget = target;
                number = num; name = nme;
                count = cnt; animal = ani; typeID = type;
                coordinates = coords;
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

            public Item(bool box, int num, string nme, string cnt, string it, Coordinates coords, RotationQuat qcoords)
            {
                isBoxed = box;
                number = num; name = nme;
                count = cnt; item = it;
                coordinates = coords; quatCoordinates = qcoords;
                coordinates.roty = Fox2Info.getDegreeRot(qcoords.yval);
            }

            public Item(Coordinates coords, int num, string nme)
            {
                coordinates = coords; number = num; name = nme;
                quatCoordinates.yval = Fox2Info.getQuaternionY(coords.roty);
                quatCoordinates.wval = Fox2Info.getQuaternionW(coords.roty);
            }

            [XmlElement]
            public bool isBoxed { get; set; } = false;

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

            public ActiveItem(int num, string nme, string acit, Coordinates coords, RotationQuat qcoords)
            {
                number = num; name = nme;
                activeItem = acit;
                coordinates = coords; quatCoordinates = qcoords;
                coordinates.roty = Fox2Info.getDegreeRot(qcoords.yval);
            }

            public ActiveItem(Coordinates coords, int num, string nme)
            {
                coordinates = coords; number = num; name = nme;
                quatCoordinates.yval = Fox2Info.getQuaternionY(coords.roty);
                quatCoordinates.wval = Fox2Info.getQuaternionW(coords.roty);
            }

            [XmlElement]
            public int number { get; set; } = 0;

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

            public Model(bool mGeom, int num, string nme, string stmd, Coordinates coords, RotationQuat qcoords)
            {
                missingGeom = mGeom;
                number = num; name = nme;
                model = stmd;
                coordinates = coords; quatCoordinates = qcoords;
                coordinates.roty = Fox2Info.getDegreeRot(qcoords.yval);
            }

            public Model(Coordinates coords, int num, string nme)
            {
                coordinates = coords; number = num; name = nme;
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