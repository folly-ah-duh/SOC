using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace SOC.Classes
{
    static class UpdateNotifsManager
    {
        public static string NotifsListPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//UpdateNotifsList.txt");

        public static string[] defaultLangIds = {
            "quest_extract_elite",
            "quest_defeat_armor",
            "quest_defeat_zombie",
            "quest_extract_hostage",
            "quest_defeat_armor_vehicle",
            "quest_defeat_tunk",
            "quest_target_eliminate",
            "mine_quest_log",
            "quest_extract_animal"
        };

        public static List<string> UpdateNotifsList = new List<string>();

        public static void readList()
        {
            UpdateNotifsList.Clear();
            UpdateNotifsList.AddRange(File.ReadAllLines(NotifsListPath));
            for (int i = UpdateNotifsList.Count - 1; i >= 0; i--)
            {
                if (string.IsNullOrEmpty(UpdateNotifsList[i]))
                {
                    UpdateNotifsList.RemoveAt(i);
                }
            }
        }

        public static List<string> getDispNotifs()
        {
            List<string> DisplayList = new List<string>();
            readList();
            for (int i = 0; i < UpdateNotifsList.Count; i += 2)
            {
                DisplayList.Add(UpdateNotifsList[i]);
            }

            return DisplayList;
        }

        public static List<string> getLangIds()
        {
            List<string> LangIdList = new List<string>();
            readList();
            for (int i = 1; i < UpdateNotifsList.Count; i += 2)
            {
                LangIdList.Add(UpdateNotifsList[i]);
            }

            return LangIdList;
        }

        public static void addNotification(string langId, string value)
        {
            string[] langEntry = { "", value, langId };
            File.AppendAllLines(NotifsListPath, langEntry);
        }

        public static bool isCustomNotification(string LangId)
        {
            foreach (string defaultLangId in defaultLangIds)
            {
                if (defaultLangId.Equals(LangId))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
