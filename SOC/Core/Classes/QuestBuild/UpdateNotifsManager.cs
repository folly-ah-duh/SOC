using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;

namespace SOC.Classes.QuestBuild
{
    static class UpdateNotifsManager
    {
        public static string NotifsListPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//UpdateNotifsList.xml");
        public static LangTool.LangFile notificationLangEntries = new LangTool.LangFile(NotifsListPath);

        public static string[] vanillaLangIds = {
            "quest_extract_elite",
            "quest_defeat_armor",
            "quest_defeat_zombie",
            "quest_extract_hostage",
            "quest_defeat_armor_vehicle",
            "quest_defeat_tunk",
            "quest_target_eliminate",
            "mine_quest_log",
            "announce_quest_extract_animal"
        };
        
        private static void refreshList()
        {
            notificationLangEntries.Load(NotifsListPath);
        }

        private static void saveList()
        {
            notificationLangEntries.Save(NotifsListPath);
        }

        public static string GetLangId(string value)
        {
            if (value != null)
            {
                LangTool.LangEntry langEntry = notificationLangEntries.Entries.FirstOrDefault(entry => entry.Value == value);
                if (langEntry != null)
                    return langEntry.LangId;
            }

            return null;
        }

        public static LangTool.LangEntry GetDefaultLangEntry()
        {
            if (notificationLangEntries.Entries.Count > 0)
                return notificationLangEntries.Entries[0];
            else
                return new LangTool.LangEntry("","",5);
        }

        public static string GetDisplayNotification(string langId)
        {
            if (langId != null)
            {
                LangTool.LangEntry langEntry = notificationLangEntries.Entries.FirstOrDefault(entry => entry.LangId == langId);
                if (langEntry != null)
                    return langEntry.Value;
            }

            return null;
        }

        public static string[] GetAllDisplayNotifications()
        {
            return notificationLangEntries.Entries.Select(entry => entry.Value).ToArray();
        }

        public static string[] GetAllLangIds()
        {
            return notificationLangEntries.Entries.Select(entry => entry.LangId).ToArray();
        }

        public static void addNotification(string langId, string value)
        {
            notificationLangEntries.Entries.Add(new LangTool.LangEntry(langId, value, 5));
            saveList();
        }

        public static bool isCustomNotification(string langId)
        {
            return !vanillaLangIds.Any(defaultEntry => defaultEntry == langId);
        }
    }
}
