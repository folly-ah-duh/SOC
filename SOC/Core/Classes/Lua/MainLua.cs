using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    public class MainLua
    {
        List<string> questTable = new List<string>();
        List<string> targetList = new List<string>();
        Dictionary<string, string> localVariables = new Dictionary<string, string>();

        public void AddToQuestTable(string table)
        {
            questTable.Add(table);
        }

        public void AddToLocalVariables(string search, string replacement)
        {
            localVariables.Add(search, replacement);
        }

        public void AddToTargetList(string targetName)
        {
            targetList.Add(targetName);
        }

        public List<string> GetMainLuaFormatted(List<string> luaTemplate)
        {
            List<string> luaList = luaTemplate;

            StringBuilder questTableBuilder = new StringBuilder("this.QUEST_TABLE = {");
            foreach (string tableItem in questTable)
            {
                questTableBuilder.Append($@"
    {tableItem},");
            }

            questTableBuilder.Append(@"
    targetList = {");
            foreach(string targetName in targetList)
            {
                questTableBuilder.Append($@"
        ""{targetName}"", ");
            }
            questTableBuilder.Append(@"
    },");

            questTableBuilder.Append(@"
}");

            ReplaceLuaLine(luaList, "this.QUEST_TABLE = {}", questTableBuilder.ToString());
            foreach(KeyValuePair<string, string> localVariable in localVariables)
            {
                ReplaceLuaLine(luaList, localVariable.Key, localVariable.Value);
            }

            return luaList;
        }

        private static void ReplaceLuaLine(List<string> luaList, string searchFor, string replaceWith)
        {
            luaList[GetLineContaining(searchFor, luaList)] = replaceWith;
        }

        private static int GetLineContaining(string text, List<string> questLua)
        {
            for (int i = 0; i < questLua.Count; i++)
                if (questLua[i].Contains(text))
                    return i;

            return -1;
        }
    }
}
