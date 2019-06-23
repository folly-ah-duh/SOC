using System.Collections.Generic;

namespace SOC.QuestObjects.Vehicle
{
    static class VehicleInfo
    {
        public static readonly Dictionary<string, string> vehicleLuaName = new Dictionary<string, string>
        {
            { "TT77 NOSOROG", "EASTERN_TRACKED_TANK"},
            { "M84A MAGLOADER", "WESTERN_TRACKED_TANK"},
            { "ZHUK BR-3", "EASTERN_WHEELED_ARMORED_VEHICLE"},
            { "ZHUK RS-ZO", "EASTERN_WHEELED_ARMORED_VEHICLE_ROCKET_ARTILLERY"},
            { "STOUT IFV-SC", "WESTERN_WHEELED_ARMORED_VEHICLE_TURRET_MACHINE_GUN"},
            { "STOUT IFV-FS", "WESTERN_WHEELED_ARMORED_VEHICLE_TURRET_CANNON"}
        };
        public static readonly Dictionary<string, string> vehicleBody = new Dictionary<string, string>
        {
            { "TT77 NOSOROG", "veh_bd_east_tnk"},
            { "M84A MAGLOADER", "veh_bd_west_tnk"},
            { "ZHUK BR-3", "veh_bd_east_wav"},
            { "ZHUK RS-ZO", "veh_bd_east_wav"},
            { "STOUT IFV-SC", "veh_bd_west_wav"},
            { "STOUT IFV-FS", "veh_bd_west_wav"}
        };
        public static readonly Dictionary<string, string> vehicleAttachment = new Dictionary<string, string>
        {
            { "ZHUK RS-ZO", "veh_at_east_wav_rocket"},
            { "STOUT IFV-SC", "veh_at_west_wav_trt_machinegun"},
            { "STOUT IFV-FS", "veh_at_west_wav_trt_cannon"}
        };

        public static void GetVehicle2Body(string colloquialName, out string bodyName, out string TypeIndex, out string ImplTypeIndex, out string partsFileName)
        {
            bodyName = ""; TypeIndex = ""; ImplTypeIndex = ""; partsFileName = "";

            switch (colloquialName)
            {
                case "TT77 NOSOROG":
                    TypeIndex = "8";
                    ImplTypeIndex = "5";
                    partsFileName = "/Assets/tpp/parts/mecha/mbt/mbt0_main0_def.parts";
                    break;
                case "M84A MAGLOADER":
                    TypeIndex = "7";
                    ImplTypeIndex = "5";
                    partsFileName = "/Assets/tpp/parts/mecha/nbt/nbt0_main0_def.parts";
                    break;
                case "ZHUK BR-3":
                case "ZHUK RS-ZO":
                    TypeIndex = "6";
                    ImplTypeIndex = "3";
                    partsFileName = "/Assets/tpp/parts/mecha/sav/sav0_main0_def.parts";
                    break;
                case "STOUT IFV-SC":
                case "STOUT IFV-FS":
                    TypeIndex = "5";
                    ImplTypeIndex = "4";
                    partsFileName = "/Assets/tpp/parts/mecha/wav/wav0_main0_def.parts";
                    break;
            }

            bodyName = vehicleBody[colloquialName];
        }

        public static void GetVehicle2Attachment(string colloquialName, out string attachementName, out string typeCode, out string ImplTypeIndex, out string partsFileName, out string instanceCount, out string CnpName)
        {
            attachementName = ""; typeCode = ""; ImplTypeIndex = ""; partsFileName = ""; instanceCount = ""; CnpName = "";

            switch (colloquialName)
            {
                case "ZHUK RS-ZO":
                    typeCode = "97";
                    ImplTypeIndex = "4";
                    partsFileName = "/Assets/tpp/parts/mecha/sav/sav0_wepn0_def.parts";
                    instanceCount = "2";
                    CnpName = "CNP_weapon";
                    break;
                case "STOUT IFV-SC":
                    typeCode = "81";
                    ImplTypeIndex = "2";
                    partsFileName = "/Assets/tpp/parts/mecha/wav/wav0_turt1_def.parts";
                    instanceCount = "1";
                    CnpName = "CNP_TURRET";
                    break;
                case "STOUT IFV-FS":
                    typeCode = "82";
                    ImplTypeIndex = "3";
                    partsFileName = "/Assets/tpp/parts/mecha/wav/wav0_turt0_def.parts";
                    instanceCount = "2";
                    CnpName = "CNP_TURRET";
                    break;
            }

            attachementName = vehicleAttachment[colloquialName];
        }
    }
}
