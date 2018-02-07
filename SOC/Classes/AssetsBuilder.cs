using SOC.UI;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.Classes
{

    static class AssetsBuilder
    {
        public static string VehAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "assets//VehicleAssets");
        public static string AniAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "assets//AnimalAssets");
        public static string modelAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "assets//ModelAssets");
        public static string enemyAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "assets//EnemyAssets");
        public static string routeAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "assets//RouteAssets");

        public static void CopyDirectory(string sourceDir, string destinyDir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(sourceDir);
            if (!Directory.Exists(destinyDir))
                Directory.CreateDirectory(destinyDir);
            foreach (FileInfo fileInfo in dirInfo.GetFiles())
                fileInfo.CopyTo(Path.Combine(destinyDir, fileInfo.Name), true);
            foreach (DirectoryInfo subDirInfo in dirInfo.GetDirectories())
                CopyDirectory(subDirInfo.FullName, Path.Combine(destinyDir, subDirInfo.Name));

        }

        public static void DeleteDirectory(string dir)
        {
            foreach (string directory in Directory.GetDirectories(dir))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(dir, true);
            }
            catch (IOException)
            {
                Directory.Delete(dir, true);
            }
            catch (System.UnauthorizedAccessException)
            {
                Directory.Delete(dir, true);
            }
        }

        public static void ClearQuestFolders(DefinitionDetails definitionDetails)
        {
            string fpkdir = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpk", definitionDetails.FpkName);
            string fpkddir = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd", definitionDetails.FpkName);

            if (Directory.Exists(fpkdir))
                DeleteDirectory(fpkdir);

            if (Directory.Exists(fpkddir))
                DeleteDirectory(fpkddir);
        }

        public static void BuildAssets(DefinitionDetails definitionDetails, QuestEntities questDetails)
        {
            string destFPKPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpk", definitionDetails.FpkName);
            string destFPKDPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd", definitionDetails.FpkName);

            Directory.CreateDirectory(destFPKPath);
            Directory.CreateDirectory(destFPKDPath);

            BuildVehicleAssets(destFPKPath, destFPKDPath, questDetails.vehicles);
            BuildAnimalAssets(destFPKPath, destFPKDPath, questDetails.animals);
            BuildModelAssets(destFPKPath, questDetails.models);
            BuildZombieAssets(destFPKDPath);
            BuildRouteAssets(destFPKPath, definitionDetails.routeName);
            
        }

        public static void BuildVehicleAssets(string FPKPath, string FPKDPath, List<Vehicle> vehicleList)
        {
            string VehFPKAssetsPath = Path.Combine(VehAssetsPath, "FPK_Files");
            foreach (Vehicle vehicle in vehicleList)
            {
                string vehicleName = vehicleNames[vehicle.vehicleIndex];
                string sourceDirPath = Path.Combine(VehFPKAssetsPath, string.Format("{0}_fpk", vehicleName));

                CopyDirectory(sourceDirPath, FPKPath);
            }

            string VehFPKDAssetsPath = Path.Combine(VehAssetsPath, "FPKD_Files");
            foreach (Vehicle vehicle in vehicleList)
            {
                string vehicleName = vehicleNames[vehicle.vehicleIndex];
                string sourceDirPath = Path.Combine(VehFPKDAssetsPath, string.Format("{0}_fpkd", vehicleName));

                CopyDirectory(sourceDirPath, FPKDPath);
            }
        }

        public static void BuildAnimalAssets(string FPKPath, string FPKDPath, List<Animal> animalList)
        {
            string AniFPKAssetsPath = Path.Combine(AniAssetsPath, "FPK_Files");
            foreach (Animal animal in animalList)
            {
                string animalName = animal.animal;
                string sourceDirPath = Path.Combine(AniFPKAssetsPath, string.Format("{0}_fpk", animalName));

                CopyDirectory(sourceDirPath, FPKPath);
            }

            string AniFPKDAssetsPath = Path.Combine(AniAssetsPath, "FPKD_Files");
            foreach (Animal animal in animalList)
            {
                string animalName = animal.animal;
                string sourceDirPath = Path.Combine(AniFPKDAssetsPath, string.Format("{0}_fpkd", animalName));

                CopyDirectory(sourceDirPath, FPKDPath);
            }
        }

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

        public static void BuildZombieAssets(string FPKDPath)
        {
            string enemyFPKDAssetsPath = Path.Combine(enemyAssetsPath, "FPKD_Files");
            if (QuestComponents.EnemyInfo.zombieCount > 0)
            {
                string sourceDirPath = Path.Combine(enemyFPKDAssetsPath, "zombie_fpkd");
                CopyDirectory(sourceDirPath, FPKDPath);
            }
        }

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
