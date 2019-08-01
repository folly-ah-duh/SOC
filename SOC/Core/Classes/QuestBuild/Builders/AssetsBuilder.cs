using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.IO;
using SOC.Classes.Assets;
using SOC.Core.Classes.Route;

namespace SOC.Classes.QuestBuild.Assets
{
    class AssetsBuilder
    {
        internal static void BuildAssets(string dir, CoreDetails coreDetails, DetailManager[] managers)
        {
            FileAssets fileAssets = new FileAssets(dir, coreDetails.FpkName);

            RouteAssets.BuildRouteAssets(coreDetails.routeName, fileAssets);

            foreach(DetailManager manager in managers)
            {
                manager.AddToAssets(fileAssets);
            }

            fileAssets.SendAssets();
        }
    }
}
