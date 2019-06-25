using SOC.Classes.Lua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.QuestObjects.ActiveItem
{
    class ActiveItemLua
    {
        internal static void GetMain(ActiveItemDetail questDetail, MainLua mainLua)
        {
            if (!mainLua.QuestTableContains("targetItemList"))
            {
                mainLua.AddToLocalVariables("local itemQuestType =", "local itemQuestType = " + questDetail.activeItemMetadata.objectiveType);
                mainLua.AddToQuestTable(BuildItemTargetList(questDetail));
            }
        }

        private static string BuildItemTargetList(ActiveItemDetail detail)
        {
            List<ActiveItem> activeItems = detail.activeItems;
            StringBuilder targetItemListBuilder = new StringBuilder("targetItemList  = {");
            int targetItemCount = 0;

            foreach (ActiveItem activeItem in activeItems)
            {
                if (!activeItem.isTarget)
                    continue;

                targetItemCount++;
                targetItemListBuilder.Append($@"
        {{
            equipId = TppEquip.{activeItem.activeItem},
            messageId = ""None"",");
                targetItemListBuilder.Append(@"
        },");
            }
            if (targetItemCount == 0)
            {
                targetItemListBuilder.Append(@"
        nil ");
            }

            targetItemListBuilder.Append(@"
    }");
            return targetItemListBuilder.ToString();
        }
    }
}
