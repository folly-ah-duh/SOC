using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.Linq;

namespace SOC.QuestObjects.ActiveItem
{
    public class ActiveItemDetail : Detail
    {
        public ActiveItemDetail() { }

        public ActiveItemDetail(List<ActiveItem> activeList, ActiveItemMetadata meta)
        {
            activeItems = activeList; activeItemMetadata = meta;
        }

        [XmlElement]
        public ActiveItemMetadata activeItemMetadata { get; set; } = new ActiveItemMetadata();

        [XmlArray]
        public List<ActiveItem> activeItems { get; set; } = new List<ActiveItem>();

        public override Metadata GetMetadata()
        {
            return activeItemMetadata;
        }

        public override DetailManager GetNewManager()
        {
            return new ActiveItemManager(this);
        }

        public override List<QuestObject> GetQuestObjects()
        {
            return activeItems.Cast<QuestObject>().ToList();
        }

        public override void SetQuestObjects(List<QuestObject> qObjects)
        {
            activeItems = qObjects.Cast<ActiveItem>().ToList();
        }
    }

    public class ActiveItem : QuestObject
    {
        public ActiveItem() { }

        public ActiveItem(Position pos, int index)
        {
            position = pos; ID = index;
        }

        public ActiveItem(ActiveItemBox box)
        {
            ID = box.ID;

            isTarget = box.checkBox_target.Checked;
            activeItem = box.comboBox_activeItem.Text;
            position = new Position(new Coordinates(box.textBox_xcoord.Text, box.textBox_ycoord.Text, box.textBox_zcoord.Text), new Rotation(new Quaternion(box.textBox_xrot.Text, box.textBox_yrot.Text, box.textBox_zrot.Text, box.textBox_wrot.Text)));
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

        public override int GetID()
        {
            return ID;
        }

        public override string GetObjectName()
        {
                return "ActiveItem_" + ID;
        }

        public override Position GetPosition()
        {
            return position;
        }

        public override void SetPosition(Position pos)
        {
            position = pos;
        }
    }

    public class ActiveItemMetadata : Metadata
    {
        public ActiveItemMetadata() { }

        public ActiveItemMetadata(ActiveItemControl control)
        {
            objectiveType = control.comboBox_ObjType.Text;
        }

        [XmlAttribute]
        public string objectiveType { get; set; } = "ELIMINATE";
    }
}
