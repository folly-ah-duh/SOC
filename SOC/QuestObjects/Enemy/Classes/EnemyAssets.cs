using SOC.Classes.Assets;
using SOC.Classes.Common;
using System.IO;
using System.Reflection;

namespace SOC.QuestObjects.Enemy.Classes
{
    static class EnemyAssets
    {
        public static string enemyAssetsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//EnemyAssets");
        /*
        internal static void GetEnemyAssets(EnemyDetail questDetail, FileAssets fileAssets)
        {
            string enemyFPKDAssetsPath = Path.Combine(enemyAssetsPath, "FPKD_Files");
            if (QuestComponents.EnemyInfo.zombieCount > 0)
            {
                fileAssets.AddFPKDFolder(Path.Combine(enemyFPKDAssetsPath, "zombie_fpkd"));
            }
        }
        */
        
    }
}
