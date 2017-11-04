using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes
{
    static class LangBuilder
    {
        static string[] lngLanguages = { "eng", "fre", "ger", "ita", "jpn", "por", "rus", "spa" };

        public static void WriteQuestLangs(QuestDefinitionLua definitionInfo)
        {
            string[] NotificationList = File.ReadAllLines("UpdateNotifsList.txt");
            int progressNotifIndex = definitionInfo.progNotif;

            string entryLines = "";

            entryLines += string.Format("\n\t\t<Entry LangId=\"name_q{0}\" Color=\"5\" Value=\"{1}\" />", definitionInfo.QuestNum, definitionInfo.QuestTitle);
            entryLines += string.Format("\n\t\t<Entry LangId=\"info_q{0}\" Color=\"5\" Value=\"{1}\" />\n", definitionInfo.QuestNum, definitionInfo.QuestDesc);

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
                string lngFile = Path.Combine(lngPath, string.Format(@"ih_quest_q{0}.{1}.lng2.xml", definitionInfo.QuestNum, language));

                Directory.CreateDirectory(lngPath);
                File.WriteAllText(lngFile, lngText);
            }
        }
    }
}
