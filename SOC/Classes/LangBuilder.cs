using SOC.UI;
using System.IO;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.Classes
{
    static class LangBuilder
    {
        static string[] lngLanguages = { "eng", "fre", "ger", "ita", "jpn", "por", "rus", "spa" };

        public static void WriteQuestLangs(DefinitionDetails definitionDetails)
        {
            string[] NotificationList = File.ReadAllLines(Setup.NotifsListPath);
            int progressNotifIndex = definitionDetails.progNotif;

            string entryLines = "";

            entryLines += string.Format("\n\t\t<Entry LangId=\"name_q{0}\" Color=\"5\" Value=\"{1}\" />", definitionDetails.QuestNum, definitionDetails.QuestTitle);
            entryLines += string.Format("\n\t\t<Entry LangId=\"info_q{0}\" Color=\"5\" Value=\"{1}\" />\n", definitionDetails.QuestNum, definitionDetails.QuestDesc);

            if (progressNotifIndex > 17)
            {
                string progressId = NotificationList[progressNotifIndex + 1];
                string progressdesc = NotificationList[progressNotifIndex];

                entryLines += string.Format("\t\t<Entry LangId=\"{0}\" Color=\"5\" Value=\"{1}\" />\n", progressId, progressdesc);
            }

            string entries = string.Format("\n\t<Entries>{0}\t</Entries>\n", entryLines);

            string lngText = (string.Format("<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<LangFile xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" Endianess=\"BigEndian\">{0}</LangFile>", entries));

            foreach (string language in lngLanguages)
            {
                string lngPath = string.Format("Sideop_Build//Assets//tpp/pack//ui//lang//lang_default_data_{0}_fpk//Assets//tpp//lang//ui", language);
                string lngFile = Path.Combine(lngPath, string.Format(@"ih_quest_q{0}.{1}.lng2.xml", definitionDetails.QuestNum, language));

                Directory.CreateDirectory(lngPath);
                File.WriteAllText(lngFile, lngText);
            }
        }
    }
}
