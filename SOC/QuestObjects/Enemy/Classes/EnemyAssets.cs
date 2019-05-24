using SOC.Classes.Common;
using System.IO;
using System.Reflection;

namespace SOC.QuestObjects.Enemy.Classes
{
    static class EnemyAssets
    {
        public static string enemyAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//EnemyAssets");

        public static void BuildZombieAssets(string FPKDPath)
        {
            string enemyFPKDAssetsPath = Path.Combine(enemyAssetsPath, "FPKD_Files");
            if (QuestComponents.EnemyInfo.zombieCount > 0)
            {
                string sourceDirPath = Path.Combine(enemyFPKDAssetsPath, "zombie_fpkd");
                Tools.CopyDirectory(sourceDirPath, FPKDPath);
            }
        }
    }
}
