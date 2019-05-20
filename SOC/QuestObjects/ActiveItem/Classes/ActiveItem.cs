using SOC.Classes.Common;
using System.Xml.Serialization;

namespace SOC.QuestObjects.ActiveItem
{
    public class ActiveItem
    {

        public ActiveItem() { }

        public ActiveItem(ActiveItemBox d, int num)
        {
            number = num; isTarget = d.ai_checkBox_target.Checked;
            name = d.ai_groupBox_main.Text;
            activeItem = d.ai_comboBox_activeitem.Text;
            coordinates = new Coordinates(d.ai_textBox_xcoord.Text, d.ai_textBox_ycoord.Text, d.ai_textBox_zcoord.Text);
            rotation = new Rotation(new Quaternion(d.ai_textBox_xrot.Text, d.ai_textBox_yrot.Text, d.ai_textBox_zrot.Text, d.ai_textBox_wrot.Text));
        }

        public ActiveItem(Coordinates coords, Rotation rot, int num, string nme)
        {
            coordinates = coords; number = num; name = nme;
            rotation = rot;
        }

        public void setRotation(Rotation rot)
        {
            rotation = rot;
        }

        [XmlElement]
        public int number { get; set; } = 0;

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlAttribute]
        public string name { get; set; } = "Active_Item_0";

        [XmlElement]
        public string activeItem { get; set; } = "EQP_SWP_DMine";

        [XmlElement]
        public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0");

        [XmlElement]
        public Rotation rotation { get; set; } = new Rotation(new Quaternion("0", "0", "0", "0"));

    }
}
