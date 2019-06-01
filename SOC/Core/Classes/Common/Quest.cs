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

        public Quest(CoreDetails core, List<Detail> details)
        {
            coreDetails = core;
            questObjectDetails = details;
        }

        public void Save(string fileName)
        {

            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Quest),  ManagerArray.GetAllDetailTypes());
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
                XmlSerializer deserializer = new XmlSerializer(typeof(Quest), ManagerArray.GetAllDetailTypes());
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

        [XmlElement]
        public CoreDetails coreDetails { get; set; }

        [XmlArray]
        public List<Detail> questObjectDetails { get; set; }

    }
}
