using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace SOC.QuestObjects.Model
{
    static class ModelAssets
    {
        public static string modelAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//ModelAssets");

        public static void BuildModelAssets(string FPKPath, List<Model> modelList)
        {
            string FPKPathAssets = FPKPath + "//Assets";
            if (!Directory.Exists(FPKPathAssets))
                Directory.CreateDirectory(FPKPathAssets);
            foreach (Model model in modelList)
            {

                string SourcemodelFileName = Path.Combine(modelAssetsPath, model.model);
                string DestModelFileName = Path.Combine(FPKPathAssets, model.model);

                File.Copy(SourcemodelFileName + ".fmdl", DestModelFileName + ".fmdl", true);
                if (!model.missingGeom)
                {
                    File.Copy(SourcemodelFileName + ".geom", DestModelFileName + ".geom", true);
                }
            }
        }
    }
}
