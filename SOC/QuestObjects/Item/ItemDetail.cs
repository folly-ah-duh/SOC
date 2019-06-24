using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace SOC.QuestObjects.Item
{
    public class ItemDetail : Detail
    {
        public ItemDetail() { }

        public ItemDetail(List<Item> itemList, ItemMetadata meta)
        {
            items = itemList; itemMetadata = meta;
        }

        [XmlElement]
        public ItemMetadata itemMetadata { get; set; } = new ItemMetadata();

        [XmlArray]
        public List<Item> items { get; set; } = new List<Item>();
        
        public override Metadata GetMetadata()
        {
            return itemMetadata;
        }

        public override DetailManager GetNewManager()
        {
            return new ItemManager(this);
        }

        public override List<QuestObject> GetQuestObjects()
        {
            return items.Cast<QuestObject>().ToList();
        }

        public override void SetQuestObjects(List<QuestObject> qObjects)
        {
            items = qObjects.Cast<Item>().ToList();
        }
    }

    public class Item : QuestObject
    {

        public Item() { }

        public Item(Position pos, int index)
        {
            position = pos; ID = index;
        }

        public Item(ItemBox box)
        {
            ID = box.ID;

            isTarget = box.checkBox_target.Checked;
            isBoxed = box.checkBox_boxed.Checked;
            count = box.comboBox_count.Text;
            item = box.comboBox_item.Text;
            position = new Position(new Coordinates(box.textBox_xcoord.Text, box.textBox_ycoord.Text, box.textBox_zcoord.Text), new Rotation(box.textBox_xrot.Text, box.textBox_yrot.Text, box.textBox_zrot.Text, box.textBox_wrot.Text));
        }

        public override void SetPosition(Position pos)
        {
            position = pos;
        }

        public override Position GetPosition()
        {
            return position;
        }

        public override int GetID()
        {
            return ID;
        }

        public override string GetObjectName()
        {
            return "Item_" + ID;
        }

        [XmlElement]
        public bool isBoxed { get; set; } = false;

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public int ID { get; set; } = 0;

        [XmlElement]
        public string count { get; set; } = "1";

        [XmlElement]
        public string item { get; set; } = "EQP_SWP_Magazine";

        [XmlElement]
        public Position position = new Position(new Coordinates(), new Rotation());
    }

    public class ItemMetadata : Metadata
    {
        public ItemMetadata() { }

        public ItemMetadata(ItemControl itemControl)
        {
            objectiveType = itemControl.comboBox_ObjType.Text;
        }

        [XmlAttribute]
        public string objectiveType { get; set; } = "ELIMINATE";
    }
}
