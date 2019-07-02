using SOC.Classes.Lua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.QuestObjects.Enemy
{
    static class EnemyLua
    {
        public static void GetDefinition(EnemyDetail detail, DefinitionLua definitionLua)
        {
            if (detail.enemies.Count > 0)
            {
                string region = GetRegion(detail.enemyMetadata.subtype);

                StringBuilder faceIdList = new StringBuilder("faceIdList = {");
                if(HasBalaclavas(detail.enemies))
                {
                    faceIdList.Append($"TppDefine.QUEST_FACE_ID_LIST.{region}_BALACLAVA, ");
                }
                faceIdList.Append("}");
                definitionLua.AddPackInfo(faceIdList.ToString()); // if necessary faceIdList and bodyIdList should be components of definitionLua
                
                StringBuilder bodyIdList = new StringBuilder("bodyIdList = {");
                if (HasArmors(detail.enemies))
                {
                    bodyIdList.Append($"TppDefine.QUEST_BODY_ID_LIST.{region}_ARMOR, ");
                }
                foreach(string body in GetBodies(detail.enemies))
                {
                    bodyIdList.Append($"TppEnemyBodyId.{body}, ");
                }
                bodyIdList.Append("}");
                definitionLua.AddPackInfo(bodyIdList.ToString());
            }
        }

        private static bool HasArmors(List<Enemy> enemies)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.armored)
                    return true;
            }
            return false;
        }

        private static bool HasBalaclavas(List<Enemy> enemies)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.balaclava)
                    return true;
            }
            return false;
        }

        private static bool HasZombie(List<Enemy> enemies)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.zombie)
                    return true;
            }
            return false;
        }

        private static List<string> GetBodies(List<Enemy> enemies)
        {
            List<string> uniqueBodies = new List<string>();
            foreach(Enemy enemy in enemies)
            {
                if (enemy.body != "DEFAULT" && !enemy.armored && !uniqueBodies.Contains(enemy.body))
                {
                    uniqueBodies.Add(enemy.body);
                }
            }
            return uniqueBodies;
        }

        private static string GetRegion(string subtype)
        {
            switch(subtype)
            {
                case "SOVIET_A":
                case "SOVIET_B":
                    return "AFGH";
                case "PF_A":
                case "PF_B":
                case "PF_C":
                    return "MAFR";
                default:
                    return "";
            }
        }

        public static void GetMain(EnemyDetail detail, MainLua mainLua)
        {
            List<Enemy> enemies = detail.enemies;
            EnemyMetadata meta = detail.enemyMetadata;

            mainLua.AddToLocalVariables("local SUBTYPE =", $@"local SUBTYPE = ""{meta.subtype}""");
            mainLua.AddToLocalVariables("local enemyQuestType =", "local enemyQuestType = " + meta.objectiveType);

            mainLua.AddToQuestTable($"isQuestArmor = {(HasArmors(enemies) ? "true" : "false")}");
            mainLua.AddToQuestTable($"isQuestZombie = {(HasZombie(enemies) ? "true" : "false")}");
            mainLua.AddToQuestTable($"isQuestBalaclava = {(HasBalaclavas(enemies) ? "true" : "false")}");

            mainLua.AddToQuestTable(BuildEnemyList(enemies));

            foreach (Enemy enemy in enemies)
            {
                if (enemy.isTarget && enemy.spawn)
                    mainLua.AddToTargetList(enemy.GetObjectName());
            }
        }

        private static string BuildEnemyList(List<Enemy> enemies)
        {
            StringBuilder enemyListBuilder = new StringBuilder("enemyList = {");
            int enemyCount = 0;

            foreach (Enemy enemy in enemies)
            {
                if (!enemy.spawn)
                    continue;
                enemyCount++;

                string DRouteString;
                uint route;
                if (uint.TryParse(enemy.dRoute, out route)) // no quotations necessary if the route is hashed
                    DRouteString = enemy.dRoute;
                else
                    DRouteString = $@"""{enemy.dRoute}""";
                
                string CRouteString;
                if (uint.TryParse(enemy.cRoute, out route))
                    CRouteString = enemy.cRoute;
                else
                    CRouteString = $@"""{enemy.cRoute}""";

                string powerSetting = "";
                if (enemy.powers.Length > 0)
                {
                    powerSetting = "powerSetting = {";
                    foreach (string power in enemy.powers)
                    {
                        powerSetting += $@"""{power}"", ";
                    }
                    powerSetting += "},";
                }

                enemyListBuilder.Append($@"
        {{
            enemyName = ""{enemy.name}"",
            {(enemy.dRoute == @"""DEFAULT""" ? "" : $"route_d = {DRouteString}, ")}
            {(enemy.cRoute == @"""DEFAULT""" ? "" : $"route_c = {CRouteString}, ")}
            cpName = CPNAME,
            soldierSubType = SUBTYPE,
            {(enemy.skill.Equals("NONE") ? "" : $@"skill = ""{enemy.skill}"", ")}
            {powerSetting}
            {(enemy.staffType.Equals("NONE") ? "" : $@"staffTypeId = TppDefine.STAFF_TYPE_ID.{enemy.staffType}, ")}
            {(enemy.body.Equals("DEFAULT") || enemy.armored ? "" : $@"bodyId = TppEnemyBodyId.{enemy.body}, ")}
            isBalaclava = {(enemy.balaclava ? "true" : "false")},
            isZombie = {(enemy.zombie ? "true" : "false")},
            {(enemy.zombie ? "isZombieUseRoute = true," : "")}");
                enemyListBuilder.Append(@"
        },");
            }

            if (enemyCount == 0)
            {
                enemyListBuilder.Append(@"
        nil ");
            }
            enemyListBuilder.Append(@"
    }");
            return enemyListBuilder.ToString();
        }
    }
}
