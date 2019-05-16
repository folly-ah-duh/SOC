using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SOC.Classes.Common;

namespace SOC.Classes.Quest
{
    [XmlType("Quest")]
    public class Quest
    {

        public Quest() { }

        public Quest(DefinitionDetails d, QuestEntities q)
        {
            definitionDetails = d;
            questEntities = q;
        }

        public void Save(string fileName)
        {

            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Quest));
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
                XmlSerializer deserializer = new XmlSerializer(typeof(Quest));
                try
                {
                    Quest loadedQuest = (Quest)deserializer.Deserialize(stream);
                    questEntities = loadedQuest.questEntities;
                    definitionDetails = loadedQuest.definitionDetails;
                    return true;
                }
                catch (InvalidOperationException e)
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("An Exception has occurred and the selected xml file could not be loaded. \n\nInnerException message: \n{0}", e.InnerException), "SOC", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static void ClearQuestFolders(DefinitionDetails definitionDetails)
        {
            string fpkdir = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpk", definitionDetails.FpkName);
            string fpkddir = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd", definitionDetails.FpkName);

            if (Directory.Exists(fpkdir))
                Tools.DeleteDirectory(fpkdir);

            if (Directory.Exists(fpkddir))
                Tools.DeleteDirectory(fpkddir);
        }

        [XmlElement]
        public DefinitionDetails definitionDetails { get; set; }

        [XmlElement]
        public QuestEntities questEntities { get; set; }

    }
}
