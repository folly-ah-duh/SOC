using SOC.UI;
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
       
        
        public static void BuildFPKAssets(DefinitionDetails definitionDetails, QuestDetails questDetails) {

            string destPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpk", definitionDetails.FpkName);
            Directory.CreateDirectory(destPath);

            string VehFPKAssetsPath = Path.Combine(VehAssetsPath, "FPK_Files");
            foreach (VehicleDetail vehicleDetail in questDetails.vehicleDetails)
            {
                string vehicleName = vehicleNames[vehicleDetail.v_comboBox_vehicle.SelectedIndex];
                string sourceDirPath = Path.Combine(VehFPKAssetsPath, string.Format("{0}_fpk", vehicleName));

                CopyDirectory(sourceDirPath, destPath);
            }

            string AniFPKAssetsPath = Path.Combine(AniAssetsPath, "FPK_Files");
            foreach (AnimalDetail animalDetail in questDetails.animalDetails)
            {
                string animalName = animalDetail.a_comboBox_animal.Text;
                string sourceDirPath = Path.Combine(AniFPKAssetsPath, string.Format("{0}_fpk", animalName));

                CopyDirectory(sourceDirPath, destPath);
            }

            destPath += "//Assets";
            if (!Directory.Exists(destPath))
                Directory.CreateDirectory(destPath);
            foreach (ModelDetail modelDetail in questDetails.modelDetails)
            {

                string SourcemodelFileName = Path.Combine(modelAssetsPath, modelDetail.m_comboBox_preset.Text);
                string DestModelFileName = Path.Combine(destPath, modelDetail.m_comboBox_preset.Text);

                File.Copy(SourcemodelFileName + ".fmdl", DestModelFileName + ".fmdl", true);
                if (!modelDetail.m_label_GeomNotFound.Visible)
                {
                    File.Copy(SourcemodelFileName + ".geom", DestModelFileName + ".geom", true);
                }
            }
        }
        public static void BuildFPKDAssets(DefinitionDetails definitionDetails, QuestDetails questDetails)
        {
            string destPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd", definitionDetails.FpkName);
            Directory.CreateDirectory(destPath);

            string VehFPKDAssetsPath = Path.Combine(VehAssetsPath, "FPKD_Files");
            foreach (VehicleDetail vehicleDetail in questDetails.vehicleDetails)
            {
                string vehicleName = vehicleNames[vehicleDetail.v_comboBox_vehicle.SelectedIndex];
                string sourceDirPath = Path.Combine(VehFPKDAssetsPath, string.Format("{0}_fpkd", vehicleName));

                CopyDirectory(sourceDirPath, destPath);
            }

            string AniFPKDAssetsPath = Path.Combine(AniAssetsPath, "FPKD_Files");
            foreach (AnimalDetail animalDetail in questDetails.animalDetails)
            {
                string animalName = animalDetail.a_comboBox_animal.Text;
                string sourceDirPath = Path.Combine(AniFPKDAssetsPath, string.Format("{0}_fpkd", animalName));

                CopyDirectory(sourceDirPath, destPath);
            }

            string enemyFPKDAssetsPath = Path.Combine(enemyAssetsPath, "FPKD_Files");
            if (QuestComponents.EnemyInfo.zombieCount > 0)
            {
                string sourceDirPath = Path.Combine(enemyFPKDAssetsPath, "zombie_fpkd");
                CopyDirectory(sourceDirPath, destPath);
            }
        }
    }
}
