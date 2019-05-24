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

        public LangFile(List<LangEntry> entryList)
        {
            Entries = entryList;
        }

        [XmlArray("Entries")]
        public List<LangEntry> Entries { get; set; }

        [XmlAttribute("Endianess")]
        public string Endianess = "BigEndian";

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
