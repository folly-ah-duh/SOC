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
        internal static void BuildAssets(CoreDetails coreDetails, MasterManager masterManager)
        {
            FileAssets fileAssets = new FileAssets(coreDetails.FpkName);

            RouteAssets.BuildRouteAssets(coreDetails.routeName, fileAssets);

            foreach(DetailManager manager in masterManager.GetManagers())
            {
                manager.AddToAssets(fileAssets);
            }

            fileAssets.SendAssets();
        }
    }
}
