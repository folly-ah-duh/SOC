using System;
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

        public Rotation(Quaternion quat)
        {
            quatRotation = quat;
        }

        public void SetRotation(string roty)
        {
            quatRotation = new Quaternion("0", GetQuaternionY(roty), "0", GetQuaternionW(roty));
        }

        public void SetRotation(Quaternion quat)
        {
            quatRotation = quat;
        }

        private string GetQuaternionY(string roty)
        {
            double quatNum = 0;
            double.TryParse(roty, out quatNum);
            quatNum = quatNum * Math.PI / 360;
            return Math.Sin(quatNum).ToString();
        }

        private string GetQuaternionW(string roty)
        {
            double quatNum = 0;
            double.TryParse(roty, out quatNum);
            quatNum = quatNum * Math.PI / 360;
            return Math.Cos(quatNum).ToString();
        }

        public string GetDegreeRotY()
        {
            double degree = 0;
            double.TryParse(quatRotation.yval, out degree);
            degree = Math.Asin(degree);
            return (degree / Math.PI * 360).ToString();
        }

        public string GetRadianRotY()
        {
            double radian = 0;
            double.TryParse(quatRotation.yval, out radian);
            radian = Math.Asin(radian);
            return (radian * 2).ToString();
        }

        public string ToFox2String()
        {
            return string.Format($@"
                                  <property name=""transform_rotation_quat"" type=""Quat"" container=""StaticArray"" arraySize=""1"">
                                    <value x = ""{quatRotation.xval}"" y = ""{quatRotation.yval}"" z = ""{quatRotation.zval}"" w = ""{quatRotation.wval}"" />
                                  </property>
                                 ");
        }

        [XmlElement]
        public Quaternion quatRotation;
    }
}
