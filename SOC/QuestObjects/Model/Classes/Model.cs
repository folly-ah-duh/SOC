using SOC.Classes.Common;
using System.Xml.Serialization;

namespace SOC.QuestObjects.Model
{
    public class Model
    {

        public Model() { }

        public Model(ModelBox d, int num)
        {
            missingGeom = d.m_label_GeomNotFound.Visible;
            number = num;
            name = d.m_groupBox_main.Text;
            model = d.m_comboBox_preset.Text;
            coordinates = new Coordinates(d.m_textBox_xcoord.Text, d.m_textBox_ycoord.Text, d.m_textBox_zcoord.Text);
            rotation = new Rotation(new Quaternion(d.m_textBox_xrot.Text, d.m_textBox_yrot.Text, d.m_textBox_zrot.Text, d.m_textBox_wrot.Text));
        }

        public Model(Coordinates coords, Rotation rot, int num, string nme)
        {
            coordinates = coords; number = num; name = nme;
            rotation = rot;
        }

        public void setRotation(Rotation rot)
        {
            rotation = rot;
        }

        [XmlElement]
        public bool missingGeom { get; set; } = true;

        [XmlElement]
        public int number { get; set; } = 0;

        [XmlAttribute]
        public string name { get; set; } = "Model_0";

        [XmlElement]
        public string model { get; set; } = "";

        [XmlElement]
        public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0");

        [XmlElement]
        public Rotation rotation { get; set; } = new Rotation(new Quaternion("0", "0", "0", "0"));

    }
}
