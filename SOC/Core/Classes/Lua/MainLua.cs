using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    public class MainLua
    {
        List<string> functionList = new List<string>();

        OpeningVariables openingVariables = new OpeningVariables();
        AuxiliaryCode auxiliaryCode = new AuxiliaryCode();
        QuestTable questTable = new QuestTable();
        QStep_Start qStep_start = new QStep_Start();
        QStep_Main qStep_main = new QStep_Main();
        CheckQuestMethodsList checkQuestMethodList = new CheckQuestMethodsList();
        ObjectiveTypesList objectiveTypesList = new ObjectiveTypesList();
        OnUpdate onUpdate = new OnUpdate();
        Dictionary<string, string> localVariables = new Dictionary<string, string>();
        
        public void AddToOpeningVariables(string variableName, string value)
        {
            openingVariables.Add(variableName, value);
        }

        public void AddToAuxiliary(LuaFunction function)
        {
            auxiliaryCode.Add(function.FunctionFull);
        }

        public void AddToAuxiliary(string localVar)
        {
            auxiliaryCode.Add(localVar);
        }

        public void AddToQStep_Start_OnEnter(params string[] functionCalls)
        {
            foreach (string functionCall in functionCalls)
                qStep_start.AddToOnEnter(functionCall);
        }

        public void AddToQStep_Start_OnEnter(params LuaFunction[] auxiliaryFunctions)
        {
            foreach (LuaFunction function in auxiliaryFunctions)
                qStep_start.AddToOnEnter($"InfCore.PCall(this.{function.FunctionName})");
        }

        public void AddToCheckQuestMethod(CheckQuestMethodsPair methodsPair)
        {
            if (!checkQuestMethodList.Contains(methodsPair))
                checkQuestMethodList.Add(methodsPair);
        }

        public void AddToObjectiveTypes(GenericTargetPair objectivePair)
        {
            if (!objectiveTypesList.genericTargets.Exists(pair => pair.checkMethod.Equals(objectivePair.checkMethod)))
                objectiveTypesList.genericTargets.Add(objectivePair);
        }

        public void AddToObjectiveTypes(string oneLineObjective)
        {
            if (!objectiveTypesList.oneLineObjectiveTypes.Contains(oneLineObjective))
                objectiveTypesList.oneLineObjectiveTypes.Add(oneLineObjective);
        }

        public void AddToOnUpdate(string code)
        {
            onUpdate.Add(code);
        }

        public void AddToLocalVariables(string search, string replacement)
        {
            localVariables.Add(search, replacement);
        }

        public void AddToQuestTable(params object[] tableItems)
        {
            foreach(object tableItem in tableItems)
            {
                if (tableItem is Table)
                    questTable.Add(tableItem as Table);
                else if (tableItem is string)
                    questTable.Add(tableItem as string);
            }
        }

        public void AddToTargetList(string targetName)
        {
            questTable.AddTarget(targetName);
        }

        public void AddToQStep_Main(params QStep_Message[] messages)
        {
            foreach (QStep_Message message in messages)
                qStep_main.Add(message);
        }

        public List<string> GetMainLuaFormatted(List<string> luaTemplate)
        {
            AddLocalVariablesToLua(luaTemplate);
            AddFunctionsToLua(luaTemplate);

            return luaTemplate;
        }

        private void AddLocalVariablesToLua(List<string> luaList)
        {
            foreach (KeyValuePair<string, string> localVariable in localVariables)
                ReplaceLuaLine(luaList, localVariable.Key, localVariable.Value);
        }

        private void AddFunctionsToLua(List<string> luaList)
        {
            openingVariables.BuildComponent(this); // decide whether to add "timeless" variables via constructor or during LuaBuilder's BuildMain
            questTable.BuildComponent(this);
            auxiliaryCode.BuildComponent(this);
            new OnAllocate().BuildComponent(this);
            new Messages().BuildComponent(this);
            new OnInitialize().BuildComponent(this);
            onUpdate.BuildComponent(this);
            new OnTerminate().BuildComponent(this);
            qStep_start.BuildComponent(this);
            qStep_main.BuildComponent(this);
            objectiveTypesList.BuildComponent(this);
            checkQuestMethodList.BuildComponent(this);

            StringBuilder functionBuilder = new StringBuilder();
            foreach (string function in functionList)
                functionBuilder.Append($@"
{function}");

            ReplaceLuaLine(luaList, "--ADDITIONAL FUNCTIONS--", functionBuilder.ToString());
        }

        public void AddCodeToScript(string code)
        {
            functionList.Add(code);
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
