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
        public static void WriteQuestLang(QuestDefinitionLua definitionInfo)
        {
            string[] NotificationList = File.ReadAllLines("UpdateNotifsList.txt");
            int progressNotifIndex = definitionInfo.progNotif;

            using (System.IO.StreamWriter questLang =
            new System.IO.StreamWriter(string.Format(@"ih_quest_q{0}.eng.lng2.xml", definitionInfo.QuestNum)))
            {
                string entryLines = "";

                entryLines += string.Format("\n\t\t<Entry LangId=\"name_q{0}\" Color=\"5\" Value=\"{1}\" />", definitionInfo.QuestNum, definitionInfo.QuestTitle);
                entryLines += string.Format("\n\t\t<Entry LangId=\"info_q{0}\" Color=\"5\" Value=\"{1}\" />", definitionInfo.QuestNum, definitionInfo.QuestDesc);

                if (progressNotifIndex > 17)
                {
                    string progressId = NotificationList[progressNotifIndex + 1];
                    string progressdesc = NotificationList[progressNotifIndex];

                    entryLines += string.Format("\n\t\t<Entry LangId=\"{0}\" Color=\"5\" Value=\"{1}\" />\n", progressId, progressdesc);
                }

                string entries = string.Format("\n\t<Entries>{0}\t</Entries>\n", entryLines);

                questLang.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                questLang.WriteLine(string.Format("<LangFile xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" Endianess=\"BigEndian\">{0}</LangFile>", entries));

            }
        }
    }
}
