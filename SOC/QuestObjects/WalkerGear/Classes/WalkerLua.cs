using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOC.Classes.Lua;

namespace SOC.QuestObjects.WalkerGear
{
    static class WalkerLua
    {
        internal static void GetDefinition(WalkerDetail walkerDetail, DefinitionLua definitionLua)
        {
            int walkerCount = walkerDetail.walkers.Count;

            if (walkerCount > 0)
            {
                definitionLua.AddPackPath("/Assets/tpp/pack/mission2/common/mis_com_walkergear.fpk");
            }
        }

        internal static void GetMain(WalkerDetail walkerDetail, MainLua mainLua)
        {
            List<WalkerGear> walkers = walkerDetail.walkers;
            WalkerMetadata meta = walkerDetail.walkerMetadata;

            mainLua.AddToLocalVariables("local walkerQuestType =", "local walkerQuestType = " + meta.objectiveType);

            mainLua.AddToQuestTable(BuildWalkerList(walkerDetail));

            foreach (WalkerGear walker in walkers)
            {
                if (walker.isTarget)
                    mainLua.AddToTargetList(walker.GetObjectName());
            }
        }

        private static string BuildWalkerList(WalkerDetail walkerDetail)
        {
            StringBuilder walkerListBuilder = new StringBuilder(@"walkerList = {");
            List<WalkerGear> walkers = walkerDetail.walkers;
            WalkerMetadata meta = walkerDetail.walkerMetadata;

            if (walkers.Count == 0)
                walkerListBuilder.Append(@"
        nil ");
            else
                foreach (WalkerGear walker in walkers)
                {
                    walkerListBuilder.Append($@"
        {{
            walkerName = ""{walker.GetObjectName()}"",
            {(walker.pilot.Equals("NONE") ? "" : $@"riderName = ""{walker.pilot}"",")}
            colorType = {walker.paint},
            primaryWeapon = {walker.weapon},
            position = {{pos = {{{walker.position.coords.xCoord},{walker.position.coords.yCoord},{walker.position.coords.zCoord}}}, rotY = {walker.position.rotation.GetDegreeRotY()},}},");
                    walkerListBuilder.Append(@"
        },");
                }
            walkerListBuilder.Append(@"
    }");
            return walkerListBuilder.ToString();
        }
    }
}
