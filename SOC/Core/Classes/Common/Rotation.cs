using System;
using System.Globalization;
using System.Xml.Serialization;

namespace SOC.Classes.Common
{
    [XmlType("Rotation")]
    public class Rotation
    {
        public Rotation() { }

        public Rotation(string roty)
        {
            SetRotation(roty);
        }

        public Rotation(string x, string y, string z, string w)
        {
            xRot = x; yRot = y; zRot = z; wRot = w;
        }

        public void SetRotation(string roty)
        {
            xRot = "0"; yRot = GetQuaternionY(roty); zRot = "0"; wRot = GetQuaternionW(roty);
        }

        public void SetRotation(string x, string y, string z, string w)
        {
            xRot = x; yRot = y; zRot = z; wRot = w;
        }

        private string GetQuaternionY(string roty)
        {
            double quatNum = 0;
            double.TryParse(roty, out quatNum);
            quatNum = quatNum * Math.PI / 360;
            return Math.Sin(quatNum).ToString("F5", CultureInfo.InvariantCulture);
        }

        private string GetQuaternionW(string roty)
        {
            double quatNum = 0;
            double.TryParse(roty, out quatNum);
            quatNum = quatNum * Math.PI / 360;
            return Math.Cos(quatNum).ToString("F5", CultureInfo.InvariantCulture);
        }

        public string GetDegreeRotY()
        {
            double degree = 0;
            double.TryParse(yRot, out degree);
            degree = Math.Asin(degree);
            return (degree / Math.PI * 360).ToString("F2", CultureInfo.InvariantCulture);
        }

        public string GetRadianRotY()
        {
            double radian = 0;
            double.TryParse(yRot, out radian);
            radian = Math.Asin(radian);
            return (radian * 2).ToString("F3", CultureInfo.InvariantCulture);
        }

        public string ToFox2String()
        {
            return string.Format($@"
            <property name=""transform_rotation_quat"" type=""Quat"" container=""StaticArray"" arraySize=""1"">
              <value x = ""{xRot}"" y = ""{yRot}"" z = ""{zRot}"" w = ""{wRot}"" />
            </property>
                                 ");
        }


        [XmlAttribute]
        public string xRot = "0";

        [XmlAttribute]
        public string yRot = "0";

        [XmlAttribute]
        public string zRot = "0";

        [XmlAttribute]
        public string wRot = "0";
    }
}
