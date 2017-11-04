using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes
{
    static class AssetsBuilder
    {
        public static void BuildPack(QuestDefinitionLua definitionInfo, QuestDetails detailInfo) { //v0.1.0 add required vehicle files. future: add route files? add preselected model files?

            string packPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpk", definitionInfo.FpkName);
            Directory.CreateDirectory(packPath);
            
        }
    }
}
