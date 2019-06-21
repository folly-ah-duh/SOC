using SOC.Classes.Assets;
using System.IO;
using System.Reflection;

namespace SOC.Core.Classes.Route
{
    static class RouteAssets
    {
        public static string routeAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//RouteAssets");

        public static void BuildRouteAssets(string routeName, FileAssets fileAssets)
        {
            if (!routeName.Equals("NONE"))
            {
                string frtFilePath = Path.Combine(routeAssetsPath, routeName) + ".frt";
                string destinationFpkPath = Path.Combine(fileAssets.questFPKPath, "Assets", routeName + ".frt");

                fileAssets.AddIndividualFile(frtFilePath, destinationFpkPath);
            }
        }
    }
}
