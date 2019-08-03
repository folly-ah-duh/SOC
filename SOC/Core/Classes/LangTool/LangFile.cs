using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SOC.Classes.LangTool
{
    [XmlRoot("LangFile")]
    public class LangFile
    {
        public LangFile() { }

        public LangFile(List<LangEntry> entryList)
        {
            Entries = entryList;
        }

        public LangFile(string fileName)
        {
            Load(fileName);
        }

        [XmlArray("Entries")]
        public List<LangEntry> Entries { get; set; } = new List<LangEntry>();

        [XmlAttribute("Endianess")]
        public string Endianess = "BigEndian";

        public void Save(string fileName = "test.xml")
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(LangFile));
                serializer.Serialize(stream, this);
            }
        }

        public bool Load(string fileName = "test.xml")
        {

            if (!File.Exists(fileName))
            {
                return false;
            }

            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(LangFile));
                try
                {
                    LangFile loadedQuest = (LangFile)deserializer.Deserialize(stream);
                    Entries = loadedQuest.Entries;
                    Endianess = loadedQuest.Endianess;
                    return true;
                }
                catch (InvalidOperationException e)
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("An Exception has occurred and the selected xml file could not be loaded. \n\nInnerException message: \n{0}", e.InnerException), "SOC", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public void Write(Stream outputStream)
        {
            BinaryWriter headerWriter = new BinaryWriter(outputStream, Encoding.UTF8, true);
            BinaryWriter writer = new BigEndianBinaryWriter(outputStream, Encoding.UTF8, true);

            long headerPosition = outputStream.Position;
            outputStream.Position += 24;

            int valuesPosition = (int)outputStream.Position;
            foreach (var entry in Entries)
            {
                entry.UpdateKey();
                entry.Offset = (int)outputStream.Position - valuesPosition;
                headerWriter.Write(entry.Color);
                writer.WriteNullTerminatedString(entry.Value);
            }

            writer.AlignWrite(4, 0x00);

            int keysPosition = (int)outputStream.Position;
            foreach (var entry in Entries.OrderBy(e => e.Key).ThenByDescending(e => e.Offset))
            {
                writer.Write(entry.Key);
                writer.Write(entry.Offset);
            }

            long endPosition = outputStream.Position;

            outputStream.Position = headerPosition;

            headerWriter.Write(0x474e414c); // LANG
            writer.Write(0x0000003);
            headerWriter.Write(0x00004542);

            writer.Write(Entries.Count);
            writer.Write(valuesPosition);
            writer.Write(keysPosition);

            outputStream.Position = endPosition;
        }
    }
}
