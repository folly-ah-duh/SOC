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
            if (questDetail.activeItems.Any(activeItem => activeItem.isTarget))
            {
                CheckQuestItem checkQuestItem = new CheckQuestItem(mainLua, questDetail.activeItemMetadata.objectiveType);
                mainLua.AddToQuestTable(BuildTargetItemList(questDetail));
            }
        }

        private static Table BuildTargetItemList(ActiveItemDetail detail)
        {
            Table targetItemList = new Table("targetItemList");
            foreach (ActiveItem activeItem in detail.activeItems)
            {
                if (!activeItem.isTarget)
                    continue;
                
                targetItemList.Add($@"
        {{
            equipId = TppEquip.{activeItem.activeItem},
            messageId = ""None"",
        }}");
            }
            return targetItemList;
        }
    }
}
