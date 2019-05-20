using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public string xCoord;

        [XmlElement]
        public string yCoord;

        [XmlElement]
        public string zCoord;

    }

}
