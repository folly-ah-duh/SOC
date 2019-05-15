using SOC.Classes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SOC.QuestObjects.WalkerGear
{
    public class WalkerGear
    {
        public WalkerGear() { }

        public WalkerGear(WalkerGearBox walkerBox, int num)
        {
            isTarget = walkerBox.wg_checkBox_target.Checked;
            number = num;
            name = walkerBox.wg_groupBox_main.Text;
            rider = walkerBox.wg_comboBox_rider.Text;
            color = walkerBox.wg_comboBox_paint.Text;
            weapon = walkerBox.wg_comboBox_weapon.Text;
            coordinates = new Coordinates(walkerBox.wg_textBox_xcoord.Text, walkerBox.wg_textBox_ycoord.Text, walkerBox.wg_textBox_zcoord.Text, walkerBox.wg_textBox_rot.Text);
        }

        public WalkerGear(Coordinates coords, int num, string nme)
        {
            coordinates = coords; number = num; name = nme;
        }

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public int number { get; set; } = 0;

        [XmlAttribute]
        public string name { get; set; } = "WalkerGear_0";

        [XmlElement]
        public string rider { get; set; } = "NONE";

        [XmlElement]
        public string color { get; set; } = "SOVIET";

        [XmlElement]
        public string weapon { get; set; } = "WG_MACHINEGUN";

        [XmlElement]
        public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0", "0");

    }
}
