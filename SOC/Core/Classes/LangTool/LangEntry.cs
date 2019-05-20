using System;
using System.Xml.Serialization;

namespace SOC.Classes.LangTool
{
    [XmlType("Entry")]
    public class LangEntry
    {
        public LangEntry(string lngId, string val, short col)
        {
            LangId = lngId; Value = val; Color = col;
        }

        [XmlAttribute]
        public uint Key { get; set; }

        [XmlAttribute]
        public string LangId { get; set; }

        [XmlIgnore]
        public int Offset { get; set; }

        [XmlAttribute]
        public short Color { get; set; }

        [XmlAttribute]
        public string Value { get; set; }

        public bool ShouldSerializeKey()
        {
            return string.IsNullOrEmpty(LangId);
        }

        public void UpdateKey()
        {
            if (!string.IsNullOrEmpty(LangId))
            {
                Key = RouteManager.HashString(LangId);
            }
        }
    }
}