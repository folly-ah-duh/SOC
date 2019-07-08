using SOC.Classes.Lua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.QuestObjects.Item
{
    class ItemLua
    {
        internal static void GetDefinition(ItemDetail questDetail, DefinitionLua definitionLua)
        {
            List<string> requestList = new List<string>();
            StringBuilder requestEquipBuilder = new StringBuilder("requestEquipIds = {");
            foreach(Item item in questDetail.items)
            {
                if (requestList.Contains(item.item))
                    continue;
                else if(item.item.Contains("EQP_WP_"))
                {
                    requestEquipBuilder.Append($@"""{item.item}"", ");
                    requestList.Add(item.item);
                }
            }
            requestEquipBuilder.Append("}");

            definitionLua.AddDefinition(requestEquipBuilder.ToString());
        }

        internal static void GetMain(ItemDetail questDetail, MainLua mainLua)
        {
            if (!mainLua.QuestTableContains("targetItemList"))
            {
                if (questDetail.items.Any(item => item.isTarget))
                {
                    CheckQuestItem checkQuestItem = new CheckQuestItem(mainLua, questDetail.itemMetadata.objectiveType);
                    mainLua.AddToQuestTable(BuildItemTargetList(questDetail.items));
                }
            }

        }

        private static string BuildItemTargetList(List<Item> items)
        {
            StringBuilder targetItemListBuilder = new StringBuilder("targetItemList  = {");
            int targetItemCount = 0;

            foreach (Item item in items)
            {
                if (!item.isTarget)
                    continue;

                targetItemCount++;
                targetItemListBuilder.Append($@"
        {{
            equipId = TppEquip.{item.item},
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
