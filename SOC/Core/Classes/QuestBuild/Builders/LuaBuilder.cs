using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System;
using System.Text;
using SOC.Classes.Lua;

namespace SOC.Classes.QuestBuild.Lua
{
    static class LuaBuilder
    {

        static string[] questLuaTemplate = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//questScript.lua"));

        static DefinitionLua definitionLua = new DefinitionLua();

        static MainLua mainLua = new MainLua();

        public static void WriteDefinitionLua(CoreDetails coreDetails, MasterManager masterManager)
        {
            DetailManager[] managers = masterManager.GetManagers();

            string DefinitionLuaPath = "Sideop_Build//GameDir//mod//quests//";
            string DefinitionLuaFile = Path.Combine(DefinitionLuaPath, string.Format("ih_quest_q{0}.lua", coreDetails.QuestNum));

            Directory.CreateDirectory(DefinitionLuaPath);

            using (StreamWriter defFile = new StreamWriter(DefinitionLuaFile))
            {
                defFile.Write(BuildDefinition(coreDetails, managers));
            }
        }

        private static string BuildDefinition(CoreDetails coreDetails, DetailManager[] managers) //rewrite
        {
            string questCompleteLangId = UpdateNotifsManager.getLangIds()[coreDetails.progNotif];

            definitionLua.AddDefinition($@"
    locationId = {coreDetails.locationID},
    areaName = ""{coreDetails.loadArea}"",
    iconPos = Vector3({coreDetails.coords.xCoord},{coreDetails.coords.yCoord},{coreDetails.coords.zCoord}),
    radius = {coreDetails.radius},
    category = TppQuest.QUEST_CATEGORIES_ENUM.{coreDetails.category},
    questCompleteLangId = ""{questCompleteLangId}"",
    canOpenQuest=InfQuest.AllwaysOpenQuest,
    questRank = TppDefine.QUEST_RANK.{coreDetails.reward},
    disableLzs = {{}}");

            foreach (DetailManager manager in managers)
            {
                manager.AddToDefinitionLua(definitionLua);
            }
            definitionLua.AddPackPath($"/Assets/tpp/pack/mission2/quest/ih/{coreDetails.FpkName}.fpk");

            return definitionLua.GetDefinitionLuaFormatted();
        }

        public static void WriteMainQuestLua(CoreDetails coreDetails, MasterManager masterManager)
        {
            List<string> questLua = new List<string>(questLuaTemplate);
            DetailManager[] managers = masterManager.GetManagers();

            string LuaScriptPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd//Assets//tpp//level//mission2//quest//ih", coreDetails.FpkName);
            string LuaScriptFile = Path.Combine(LuaScriptPath, coreDetails.FpkName + ".lua");

            Directory.CreateDirectory(LuaScriptPath);

            File.WriteAllLines(LuaScriptFile, BuildMain(questLua, coreDetails, managers));
        }

        private static List<string> BuildMain(List<string> questLua, CoreDetails coreDetails, DetailManager[] managers) // rewrite
        {
            mainLua.AddToLocalVariables("local CPNAME =", $@"local CPNAME = ""{coreDetails.CPName}""");
            mainLua.AddToLocalVariables("local questTrapName =", $@"local questTrapName = ""trap_preDeactiveQuestArea_{coreDetails.loadArea}""");

            mainLua.AddToQuestTable("questType = ELIMINATE");
            mainLua.AddToQuestTable("soldierSubType = SUBTYPE");
            foreach (DetailManager manager in managers)
            {
                manager.AddToMainLua(mainLua);
            }

            return mainLua.GetMainLuaFormatted(questLua);
        }
    }
}
