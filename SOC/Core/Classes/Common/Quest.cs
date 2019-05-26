using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SOC.Classes.Common
{
    [XmlType("Quest")]
    public class Quest
    {

        public Quest() { }

        public Quest(CoreDetails core, List<QuestObjectDetails> questObject)
        {
            coreDetails = core;
            questObjectDetails = questObject;
        }

        public void Save(string fileName)
        {

            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Quest),  ManagerArray.GetDetailsTypes());
                serializer.Serialize(stream, this);
            }

        }

        public bool Load(string fileName)
        {

            if (!File.Exists(fileName))
            {
                return false;
            }

            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Quest), ManagerArray.GetDetailsTypes());
                try
                {
                    Quest loadedQuest = (Quest)deserializer.Deserialize(stream);
                    coreDetails = loadedQuest.coreDetails;
                    questObjectDetails = loadedQuest.questObjectDetails;
                    return true;
                }
                catch (InvalidOperationException e)
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("An Exception has occurred and the selected xml file could not be loaded. \n\nInnerException message: \n{0}", e.InnerException), "SOC", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public void ClearQuestFolders()
        {
            string fpkdir = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpk", coreDetails.FpkName);
            string fpkddir = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd", coreDetails.FpkName);

            if (Directory.Exists(fpkdir))
                Tools.DeleteDirectory(fpkdir);

            if (Directory.Exists(fpkddir))
                Tools.DeleteDirectory(fpkddir);
        }

        [XmlElement]
        public CoreDetails coreDetails { get; set; }

        [XmlArray]
        public List<QuestObjectDetails> questObjectDetails { get; set; }

    }
}
