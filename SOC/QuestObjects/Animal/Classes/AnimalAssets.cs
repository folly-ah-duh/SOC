using SOC.Classes.Common;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace SOC.QuestObjects.Animal.Classes
{
    static class AnimalAssets
    {
        static string animalAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//AnimalAssets");
        
        public static void BuildAssets(List<Animal> animalList, string FPKPath, string FPKDPath)
        {

            string AniFPKAssetsPath = Path.Combine(animalAssetsPath, "FPK_Files");
            foreach (Animal animal in animalList)
            {
                string animalName = animal.animal;
                string sourceDirPath = Path.Combine(AniFPKAssetsPath, string.Format("{0}_fpk", animalName));
                Tools.CopyDirectory(sourceDirPath, FPKPath);
            }

            string AniFPKDAssetsPath = Path.Combine(animalAssetsPath, "FPKD_Files");
            foreach (Animal animal in animalList)
            {
                string animalName = animal.animal;
                string sourceDirPath = Path.Combine(AniFPKDAssetsPath, string.Format("{0}_fpkd", animalName));
                Tools.CopyDirectory(sourceDirPath, FPKDPath);
            }
        }
    }
}
