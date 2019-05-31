using System.Collections.Generic;

namespace SOC.QuestObjects.Vehicle
{
    static class VehicleNames
    {
        public static readonly Dictionary<string, string> vehicleName = new Dictionary<string, string>
        {
            { "TT77 NOSOROG", "EASTERN_TRACKED_TANK"},
            { "M84A MAGLOADER", "WESTERN_TRACKED_TANK"},
            { "ZHUK BR-3", "EASTERN_WHEELED_ARMORED_VEHICLE"},
            { "ZHUK RS-ZO", "EASTERN_WHEELED_ARMORED_VEHICLE_ROCKET_ARTILLERY"},
            { "STOUT IFV-SC", "WESTERN_WHEELED_ARMORED_VEHICLE_TURRET_MACHINE_GUN"},
            { "STOUT IFV-FS", "WESTERN_WHEELED_ARMORED_VEHICLE_TURRET_CANNON"}
        };
    }
}
