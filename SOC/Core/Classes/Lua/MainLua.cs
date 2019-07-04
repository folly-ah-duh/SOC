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
        List<string> functionList = new List<string>();
        List<string> startList_OnEnter = new List<string>();
        List<string> onUpdate = new List<string>();
        Dictionary<string, string> localVariables = new Dictionary<string, string>();

        public void AddToQuestTable(string table)
        {
            questTable.Add(table);
        }

        public void AddCodeToScript(string code)
        {
            functionList.Add(code);
        }

        public void AddToQStep_Start_OnEnter(string functionCall)
        {
            startList_OnEnter.Add(functionCall);
        }

        public void AddToOnUpdate(string code)
        {
            onUpdate.Add(code);
        }

        public bool QuestTableContains(string tableName)
        {
            foreach (string table in questTable)
                if (table.StartsWith(tableName))
                    return true;
            return false;
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
            AddQuestTableToLua(luaList);
            AddLocalVariablesToLua(luaList);
            AddFunctionsToLua(luaList);

            return luaList;
        }

        private void AddQuestTableToLua(List<string> luaList)
        {
            StringBuilder questTableBuilder = new StringBuilder("this.QUEST_TABLE = {");
            foreach (string tableItem in questTable)
            {
                questTableBuilder.Append($@"
    {tableItem},");
            }
            questTableBuilder.Append(GetTargetListFormatted(luaList));
            questTableBuilder.Append(@"
}");

            ReplaceLuaLine(luaList, "this.QUEST_TABLE = {}", questTableBuilder.ToString());
        }

        private string GetTargetListFormatted(List<string> luaList)
        {
            StringBuilder targetListBuilder = new StringBuilder(@"
    targetList = {");
            if (targetList.Any())
                foreach (string targetName in targetList)
                {
                    targetListBuilder.Append($@"
        ""{targetName}"", ");
                }
            else
                targetListBuilder.Append(@"
        nil ");
            targetListBuilder.Append(@"
    },");
            return targetListBuilder.ToString();
        }

        private void AddLocalVariablesToLua(List<string> luaList)
        {
            foreach (KeyValuePair<string, string> localVariable in localVariables)
            {
                ReplaceLuaLine(luaList, localVariable.Key, localVariable.Value);
            }
        }

        private void AddFunctionsToLua(List<string> luaList)
        {
            functionList.Add(BuildQStep_StartFunction());
            functionList.Add(BuildOnUpdateFunction());

            StringBuilder functionBuilder = new StringBuilder();
            foreach (string function in functionList)
            {
                functionBuilder.Append($@"
{function}");
            }
            ReplaceLuaLine(luaList, "--ADDITIONAL FUNCTIONS--", functionBuilder.ToString());
        }

        private string BuildQStep_StartFunction()
        {
            StringBuilder qStep_StartBuilder = new StringBuilder(@"
quest_step.QStep_Start = {
  OnEnter = function()");

            foreach (string code in startList_OnEnter)
            {
                qStep_StartBuilder.Append($@"
    {code}");
            }
            qStep_StartBuilder.Append(@"
    this.SwitchEnableQuestHighIntTable(true, CPNAME, this.questCpInterrogation)
    TppQuest.SetNextQuestStep(""QStep_Main"")
  end,
}"); //SwitchEnableQuestHighIntTable is temporary. Ideally, hostageLua should be able to set the function to OnTerminate and inside the QStep_Main messages as well.

            return qStep_StartBuilder.ToString();
        }

        private string BuildOnUpdateFunction()
        {
            StringBuilder onUpdateBuilder = new StringBuilder(@"
function this.OnUpdate()
  TppQuest.QuestBlockOnUpdate(this)");

            foreach (string code in onUpdate)
            {
                onUpdateBuilder.Append($@"
  {code}");
            }
            onUpdateBuilder.Append(@"
end");

            return onUpdateBuilder.ToString();
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
