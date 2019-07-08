using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOC.Classes.Lua;

namespace SOC.QuestObjects.Helicopter
{
    static class HelicopterLua
    {
        internal static void GetDefinition(HelicopterDetail questDetail, DefinitionLua definitionLua)
        {
            if (questDetail.helicopters.Count > 0)
            {
                definitionLua.AddDefinition("hasEnemyHeli = true");
            }
            else
            {
                definitionLua.AddDefinition("hasEnemyHeli = false");
            }
        }

        internal static void GetMain(HelicopterDetail questDetail, MainLua mainLua)
        {
            if (questDetail.helicopters.Count > 0)
            {
                mainLua.AddToQuestTable(BuildHeliList(questDetail));

                if (questDetail.helicopters.Any(helicopter => helicopter.isTarget))
                {
                    CheckQuestGenericEnemy helicopterCheck = new CheckQuestGenericEnemy(mainLua);
                    foreach (Helicopter heli in questDetail.helicopters)
                    {
                        if (heli.isTarget)
                            mainLua.AddToTargetList(heli.GetObjectName());
                    }
                }
            }
        }

        private static string BuildHeliList(HelicopterDetail questDetail)
        {
            List<Helicopter> heliList = questDetail.helicopters;
            StringBuilder helicopterListBuilder = new StringBuilder(@"heliList = {");

            if (heliList.Count == 0)
                helicopterListBuilder.Append(@"
        nil ");
            else
                foreach (Helicopter heli in heliList)
                {
                    helicopterListBuilder.Append($@"
        {{
            heliName = ""{heli.GetObjectName()}"",{((heli.heliRoute == "NONE") ? "" : $@"
            routeName = ""{heli.heliRoute}"",")} {((heli.heliClass == "DEFAULT") ? "" : $@"
            coloringType = TppDefine.ENEMY_HELI_COLORING_TYPE.{heli.heliClass},")}   ");
                    helicopterListBuilder.Append(@"
        },");
                }
            helicopterListBuilder.Append(@"
    }");
            return helicopterListBuilder.ToString();
        } 
    }
}
