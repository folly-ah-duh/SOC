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

                mainLua.AddToQStep_Main(QStep_MainCommonMessages.mechaNoCaptureTargetMessages);

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

        private static Table BuildHeliList(HelicopterDetail questDetail)
        {
            Table heliList = new Table("heliList");

            foreach (Helicopter heli in questDetail.helicopters)
            {
                heliList.Add($@"
        {{
            heliName = ""{heli.GetObjectName()}"",{((heli.heliRoute == "NONE") ? "" : $@"
            routeName = ""{heli.heliRoute}"",")} {((heli.heliClass == "DEFAULT") ? "" : $@"
            coloringType = TppDefine.ENEMY_HELI_COLORING_TYPE.{heli.heliClass},")}
        }}");
            }
            return heliList;
        }
    }
}
