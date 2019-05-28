using System.Xml.Serialization;

namespace SOC.Classes.Common
{

    [XmlType("Quaternion")]
    public class Quaternion
    {

        public Quaternion() { }

        public Quaternion(string x, string y, string z, string w)
        {
            xval = x;
            yval = y;
            zval = z;
            wval = w;
        }

        [XmlElement]
        public string xval = "0";

        [XmlElement]
        public string yval = "0";

        [XmlElement]
        public string zval = "0";

        [XmlElement]
        public string wval = "0";

    }
}
