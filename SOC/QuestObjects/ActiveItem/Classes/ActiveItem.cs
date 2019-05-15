using SOC.Classes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            quatCoordinates = new Rotation(d.ai_textBox_xrot.Text, d.ai_textBox_yrot.Text, d.ai_textBox_zrot.Text, d.ai_textBox_wrot.Text);
            coordinates.roty = Fox2Info.getDegreeRot(quatCoordinates.yval);
        }

        public ActiveItem(Coordinates coords, int num, string nme)
        {
            coordinates = coords; number = num; name = nme;
            quatCoordinates.yval = Fox2Info.getQuaternionY(coords.roty);
            quatCoordinates.wval = Fox2Info.getQuaternionW(coords.roty);
        }

        public void setRotation(Coordinates coords)
        {
            quatCoordinates.yval = Fox2Info.getQuaternionY(coords.roty);
            quatCoordinates.wval = Fox2Info.getQuaternionW(coords.roty);
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
        public Rotation quatCoordinates { get; set; } = new Rotation("0", "0", "0", "0");

    }
}
