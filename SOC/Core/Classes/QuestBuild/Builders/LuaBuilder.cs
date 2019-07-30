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
            DefinitionLua definitionLua = new DefinitionLua();
            string questCompleteLangId = UpdateNotifsManager.getLangIds()[coreDetails.progNotif];
            
            definitionLua.AddDefinition($"locationId = {coreDetails.locationID}");
            definitionLua.AddDefinition($@"areaName = ""{coreDetails.loadArea}""");
            definitionLua.AddDefinition($"iconPos = Vector3({coreDetails.coords.xCoord},{coreDetails.coords.yCoord},{coreDetails.coords.zCoord})");
            definitionLua.AddDefinition($"radius = {coreDetails.radius}");
            definitionLua.AddDefinition($"category = TppQuest.QUEST_CATEGORIES_ENUM.{coreDetails.category}");
            definitionLua.AddDefinition($@"questCompleteLangId = ""{questCompleteLangId}""");
            definitionLua.AddDefinition("canOpenQuest=InfQuest.AllwaysOpenQuest");
            definitionLua.AddDefinition($"questRank = TppDefine.QUEST_RANK.{coreDetails.reward}");
            definitionLua.AddDefinition("disableLzs = {}");

            foreach (DetailManager manager in managers)
            {
                manager.AddToDefinitionLua(definitionLua);
            }
            definitionLua.AddPackPath($"/Assets/tpp/pack/mission2/quest/ih/{coreDetails.FpkName}.fpk");

            return definitionLua.GetDefinitionLuaFormatted();
        }

        public static void WriteMainQuestLua(CoreDetails coreDetails, MasterManager masterManager)
        {
            DetailManager[] managers = masterManager.GetManagers();

            string LuaScriptPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd//Assets//tpp//level//mission2//quest//ih", coreDetails.FpkName);
            string LuaScriptFile = Path.Combine(LuaScriptPath, coreDetails.FpkName + ".lua");

            Directory.CreateDirectory(LuaScriptPath);

            File.WriteAllText(LuaScriptFile, BuildMain(coreDetails, managers));
        }

        private static string BuildMain(CoreDetails coreDetails, DetailManager[] managers)
        {
            MainLua mainLua = new MainLua();
            mainLua.AddToOpeningVariables("this", "{}");
            mainLua.AddToOpeningVariables("quest_step", "{}");
            mainLua.AddToOpeningVariables("StrCode32", "Fox.StrCode32");
            mainLua.AddToOpeningVariables("StrCode32Table", "Tpp.StrCode32Table");
            mainLua.AddToOpeningVariables("GetGameObjectId", "GameObject.GetGameObjectId");
            mainLua.AddToOpeningVariables("ELIMINATE", "TppDefine.QUEST_TYPE.ELIMINATE");
            mainLua.AddToOpeningVariables("RECOVERED", "TppDefine.QUEST_TYPE.RECOVERED");
            mainLua.AddToOpeningVariables("KILLREQUIRED", "9");
            mainLua.AddToOpeningVariables("CPNAME", $@"""{(coreDetails.CPName == "NONE" ? "quest_cp" : $"{coreDetails.CPName}")}""");
            mainLua.AddToOpeningVariables("DISTANTCP", $@"""{QuestObjects.Enemy.EnemyInfo.ChooseDistantCP(coreDetails.CPName, coreDetails.locationID)}""");
            mainLua.AddToOpeningVariables("questTrapName", $@"""trap_preDeactiveQuestArea_{coreDetails.loadArea}""");

            mainLua.AddToQuestTable("questType = ELIMINATE");
            mainLua.AddToQuestTable("soldierSubType = SUBTYPE");
            mainLua.AddToQuestTable(BuildCpList(coreDetails));

            foreach (DetailManager manager in managers)
            {
                manager.AddToMainLua(mainLua);
            }

            return mainLua.GetMainLuaFormatted();
        }

        private static string BuildCpList(CoreDetails coreDetails)
        {
            StringBuilder cpListBuilder = new StringBuilder("cpList = {");
            if (coreDetails.CPName != "NONE")
                cpListBuilder.Append(@"
      nil");
            else
            {
                cpListBuilder.Append($@"
      cpName = ""quest_cp"",
      cpPosition_x = {coreDetails.coords.xCoord}, cpPosition_y = {coreDetails.coords.yCoord}, cpPosition_z = {coreDetails.coords.zCoord}, cpPosition_r = {70},
      isOuterBaseCp = true,
      gtName = ""gt_quest_0000"",
      gtPosition_x = {coreDetails.coords.xCoord}, gtPosition_y = {coreDetails.coords.yCoord}, gtPosition_z = {coreDetails.coords.zCoord}, gtPosition_r = {70},");
            }
            cpListBuilder.Append(@"
    }");
            return cpListBuilder.ToString();
        }
    }
}
