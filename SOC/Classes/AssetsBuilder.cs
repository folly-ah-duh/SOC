using SOC.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes
{

    static class AssetsBuilder
    {
        public static string VehAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "assets//VehicleAssets");
        public static string modelAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "assets//ModelAssets");

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
       
        
        public static void BuildFPKAssets(QuestDefinitionLua definitionInfo, QuestDetails detailInfo) { //v0.1.0 add required vehicle files. future: add route files? add preselected model files?

            string destPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpk", definitionInfo.FpkName);
            Directory.CreateDirectory(destPath);

            string VehFPKAssetsPath = Path.Combine(VehAssetsPath, "FPK_Files");
            foreach (VehicleDetail vehicleDetail in detailInfo.vehicleDetails)
            {
                string vehicleName = QuestComponents.vehicleNames[vehicleDetail.v_comboBox_vehicle.SelectedIndex];
                string sourceDirPath = Path.Combine(VehFPKAssetsPath, string.Format("{0}_fpk", vehicleName));

                CopyDirectory(sourceDirPath, destPath);
            }
            destPath += "//Assets";
            if (!Directory.Exists(destPath))
                Directory.CreateDirectory(destPath);
            foreach (ModelDetail modelDetail in detailInfo.modelDetails)
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
        public static void BuildFPKDAssets(QuestDefinitionLua definitionInfo, QuestDetails detailInfo)
        {
            string destPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd", definitionInfo.FpkName);
            Directory.CreateDirectory(destPath);

            string VehFPKDAssetsPath = Path.Combine(VehAssetsPath, "FPKD_Files");
            foreach (VehicleDetail vehicleDetail in detailInfo.vehicleDetails)
            {
                string vehicleName = QuestComponents.vehicleNames[vehicleDetail.v_comboBox_vehicle.SelectedIndex];
                string sourceDirPath = Path.Combine(VehFPKDAssetsPath, string.Format("{0}_fpkd", vehicleName));

                CopyDirectory(sourceDirPath, destPath);
            }
        }
    }
}
