using SOC.Classes.Common;
using System.Xml.Serialization;

namespace SOC.QuestObjects.Item
{
    public class Item
    {

        public Item() { }

        public Item(ItemBox d, int num)
        {
            number = num; isTarget = d.i_checkBox_target.Checked;
            isBoxed = d.i_checkBox_boxed.Checked;
            name = d.i_groupBox_main.Text;
            count = d.i_comboBox_count.Text;
            item = d.i_comboBox_item.Text;
            coordinates = new Coordinates(d.i_textBox_xcoord.Text, d.i_textBox_ycoord.Text, d.i_textBox_zcoord.Text);
            rotation = new Rotation(new Quaternion(d.i_textBox_xrot.Text, d.i_textBox_yrot.Text, d.i_textBox_zrot.Text, d.i_textBox_wrot.Text));
        }

        public Item(Coordinates coords, Rotation rot, int num, string nme)
        {
            coordinates = coords; number = num; name = nme;
            rotation = rot;
        }

        public void setRotation(Rotation rot)
        {
            rotation = rot;
        }

        [XmlElement]
        public bool isBoxed { get; set; } = false;

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public int number { get; set; } = 0;

        [XmlAttribute]
        public string name { get; set; } = "Item_0";

        [XmlElement]
        public string count { get; set; } = "1";

        [XmlElement]
        public string item { get; set; } = "EQP_SWP_Magazine";

        [XmlElement]
        public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0");

        [XmlElement]
        public Rotation rotation { get; set; } = new Rotation(new Quaternion("0", "0", "0", "0"));

    }
}
