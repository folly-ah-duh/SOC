using System;
using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.IO;
using SOC.Classes.Assets;

namespace SOC.Classes.QuestBuild
{
    class BuildManager
    {
        private CoreDetails coreDetails;
        private MasterManager masterManager;

        public BuildManager(CoreDetails core, MasterManager master)
        {
            coreDetails = core; masterManager = master;
        }

        internal bool Build()
        {
            ClearQuestFolders();
            Lang.LangBuilder.WriteQuestLangs(coreDetails);

            Lua.LuaBuilder.WriteDefinitionLua(coreDetails, masterManager);
            Lua.LuaBuilder.WriteMainQuestLua(coreDetails, masterManager);

            Fox2.Fox2Builder.WriteQuestFox2(coreDetails.FpkName, masterManager);
            //Fox2Builder.WriteItemFox2(definitionDetails, questDetails);?

            Assets.AssetsBuilder.BuildAssets(coreDetails, masterManager);

            /*
            steps to building a quest:
            1. Clear possible existing fpk directories
            2. Write lang files
            3. write definition lua
            4. write main quest lua
            5. write fox2 file (how should I deal with the seperate item fox2?) 
            6. Add necessary asset files
            */
            return true;
        }

        public void ClearQuestFolders()
        {
            string fpkName = coreDetails.FpkName;
            string fpkdir = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpk", fpkName);
            string fpkddir = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd", fpkName);

            if (Directory.Exists(fpkdir))
                FileAssets.DeleteDirectory(fpkdir);

            if (Directory.Exists(fpkddir))
                FileAssets.DeleteDirectory(fpkddir);
        }
    }
}
