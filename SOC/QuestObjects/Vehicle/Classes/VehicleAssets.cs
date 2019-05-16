using System.Collections.Generic;
using System.IO;
using System.Reflection;
using SOC.Classes.Common;

namespace SOC.QuestObjects.Vehicle.Classes
{
    static class VehicleAssets
    {
        public static string VehAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//VehicleAssets");
        
        public static void BuildVehicleAssets(List<Vehicle> vehicleList, string FPKPath, string FPKDPath)
        {
            string VehFPKAssetsPath = Path.Combine(VehAssetsPath, "FPK_Files");
            foreach (Vehicle vehicle in vehicleList)
            {
                string vehicleName = VehicleNames.vehicleNames[vehicle.vehicleIndex];
                string sourceDirPath = Path.Combine(VehFPKAssetsPath, string.Format("{0}_fpk", vehicleName));

                Tools.CopyDirectory(sourceDirPath, FPKPath);
            }

            string VehFPKDAssetsPath = Path.Combine(VehAssetsPath, "FPKD_Files");
            foreach (Vehicle vehicle in vehicleList)
            {
                string vehicleName = VehicleNames.vehicleNames[vehicle.vehicleIndex];
                string sourceDirPath = Path.Combine(VehFPKDAssetsPath, string.Format("{0}_fpkd", vehicleName));

                Tools.CopyDirectory(sourceDirPath, FPKDPath);
            }
        }
    }
}
