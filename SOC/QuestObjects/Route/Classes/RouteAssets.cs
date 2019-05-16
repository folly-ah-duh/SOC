using System.IO;
using System.Reflection;

namespace SOC.QuestObjects.Route
{
    static class RouteAssets
    {
        public static string routeAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//RouteAssets");
        
        public static void BuildRouteAssets(string FPKPath, string routeName)
        {
            string FPKPathAssets = FPKPath + "//Assets";
            if (!Directory.Exists(FPKPathAssets))
                Directory.CreateDirectory(FPKPathAssets);
            if (!routeName.Equals("NONE"))
            {
                string sourceRouteFileName = Path.Combine(routeAssetsPath, routeName) + ".frt";
                string destRouteFileName = Path.Combine(FPKPathAssets, routeName) + ".frt";

                File.Copy(sourceRouteFileName, destRouteFileName, true);
            }
        }
    }
}
