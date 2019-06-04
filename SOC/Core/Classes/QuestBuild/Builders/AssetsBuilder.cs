using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.IO;

namespace SOC.Classes.QuestBuild.Assets
{
    class AssetsBuilder
    {
        internal static void BuildAssets(CoreDetails coreDetails, MasterManager masterManager)
        {
            string destFPKPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpk//Assets", coreDetails.FpkName);
            if (!Directory.Exists(destFPKPath))
                Directory.CreateDirectory(destFPKPath);

            string destFPKDPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd//Assets", coreDetails.FpkName);
            if (!Directory.Exists(destFPKDPath))
                Directory.CreateDirectory(destFPKDPath);


        }
    }
}
