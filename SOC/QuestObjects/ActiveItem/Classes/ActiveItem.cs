using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System.Xml.Serialization;
using System;

namespace SOC.QuestObjects.ActiveItem
{
    /*
    public class ActiveItem : QuestObject
    {

        public ActiveItem() : base(new Position(new Coordinates(), new Rotation()), 0) { }

        public ActiveItem(ActiveItemBox aiBox, int index) : base(new Position(new Coordinates(aiBox.ai_textBox_xcoord.Text, aiBox.ai_textBox_ycoord.Text, aiBox.ai_textBox_xcoord.Text), new Rotation(new Quaternion(aiBox.ai_textBox_xrot.Text, aiBox.ai_textBox_yrot.Text, aiBox.ai_textBox_zrot.Text, aiBox.ai_textBox_wrot.Text))), index)
        {
            isTarget = aiBox.ai_checkBox_target.Checked;
            name = aiBox.ai_groupBox_main.Text;
            activeItem = aiBox.ai_comboBox_activeitem.Text;
            position = base.position;
            ID = base.ID;
        }

        public ActiveItem(Position pos, int index) : base(pos, index)
        {
            position = pos; ID = index;
        }

        public void setRotation(Rotation rot)
        {
            base.position.rotation = rot;
            position = base.position;
        }

        public override string GetObjectName()
        {
            return "Active_Item_" + ID;
        }

        [XmlElement]
        public int ID { get; set; } = 0;

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlAttribute]
        public string name { get; set; } = "Active_Item_0";

        [XmlElement]
        public string activeItem { get; set; } = "EQP_SWP_DMine";

        [XmlElement]
        public Position position { get; set; } = new Position(new Coordinates(), new Rotation());

    }
    */
}
