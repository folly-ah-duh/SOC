using System.IO;
using SOC.Classes.LangTool;
using static SOC.QuestComponents.GameObjectInfo;
using System.Collections.Generic;

namespace SOC.Classes
{
    static class LangBuilder
    {
        static string[] lngLanguages = { "eng", "fre", "ger", "ita", "jpn", "por", "rus", "spa" };

        public static void WriteQuestLangs(DefinitionDetails definitionDetails)
        {
            string[] LangIdList = UpdateNotifsManager.getLangIds();
            string[] DisplayList = UpdateNotifsManager.getDispNotifs();
            int notificationIndex = definitionDetails.progNotif;

            List<LangEntry> langList = new List<LangEntry>();

            langList.Add(new LangEntry(MakeLangId("name_q", definitionDetails.QuestNum), definitionDetails.QuestTitle, 5));
            langList.Add(new LangEntry(MakeLangId("info_q", definitionDetails.QuestNum), definitionDetails.QuestDesc, 5));

            if (UpdateNotifsManager.isCustomNotification(LangIdList[notificationIndex]))
                langList.Add(new LangEntry(LangIdList[notificationIndex], (DisplayList[notificationIndex] + " [%d/%d]"), 5));

            LangFile questLng = new LangFile(langList);

            foreach (string language in lngLanguages)
            {
                string lngPath = string.Format("Sideop_Build//Assets//tpp/pack//ui//lang//lang_default_data_{0}_fpk//Assets//tpp//lang//ui", language);
                string lngFile = Path.Combine(lngPath, string.Format(@"ih_quest_q{0}.{1}.lng2", definitionDetails.QuestNum, language));
                Directory.CreateDirectory(lngPath);
                
                using (FileStream outputStream = new FileStream(lngFile, FileMode.Create))
                {
                    questLng.Write(outputStream);
                }
            }
        }

        public static string MakeLangId(string prefix, string qNum)
        {
            return (prefix + qNum);
        }
    }
}
