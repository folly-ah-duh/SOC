using System.Xml.Serialization;

namespace SOC.Classes.Common
{

    [XmlType("Coordinates")]
    public class Coordinates
    {

        public Coordinates() { }

        public Coordinates(string x, string y, string z)
        {
            xCoord = x;
            yCoord = y;
            zCoord = z;
        }

        public string ToFox2String()
        {
            return string.Format($@"
                                  <property name=""transform_translation"" type=""Vector3"" container=""StaticArray"" arraySize=""1"">
                                    <value x = ""{xCoord}"" y = ""{yCoord}"" z = ""{zCoord}"" w = ""0"" />
                                  </property>");
        }

        [XmlElement]
        public string xCoord = "0";

        [XmlElement]
        public string yCoord = "0";

        [XmlElement]
        public string zCoord = "0";

    }

}
