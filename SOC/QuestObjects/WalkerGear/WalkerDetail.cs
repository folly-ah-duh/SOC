using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using SOC.Core.Classes.InfiniteHeaven;
using System.Linq;

namespace SOC.QuestObjects.WalkerGear
{
    public class WalkerDetail : Detail
    {
        public WalkerDetail() { }

        public WalkerDetail(List<WalkerGear> walkerList, WalkerMetadata meta)
        {
            walkers = walkerList; walkerMetadata = meta;
        }

        [XmlElement]
        public WalkerMetadata walkerMetadata { get; set; } = new WalkerMetadata();
        
        [XmlArray]
        public List<WalkerGear> walkers { get; set; } = new List<WalkerGear>();

        public override Metadata GetMetadata()
        {
            return walkerMetadata;
        }

        public override DetailManager GetNewManager()
        {
            return new WalkerManager(this);
        }

        public override List<QuestObject> GetQuestObjects()
        {
            return walkers.Cast<QuestObject>().ToList();
        }

        public override void SetQuestObjects(List<QuestObject> qObjects)
        {
            walkers = qObjects.Cast<WalkerGear>().ToList();
        }
    }

    public class WalkerGear : QuestObject
    {
        public WalkerGear() { }

        public WalkerGear(Position pos, int id)
        {
            position = pos; ID = id;
        }

        public WalkerGear(WalkerBox box)
        {
            ID = box.ID;

            isTarget = box.checkBox_target.Checked;
            pilot = box.comboBox_pilot.Text;
            paint = box.comboBox_paint.Text;
            weapon = box.comboBox_weapon.Text;
            position = new Position(new Coordinates(box.textBox_xcoord.Text, box.textBox_ycoord.Text, box.textBox_zcoord.Text), new Rotation(box.textBox_rot.Text));
        }

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlAttribute]
        public int ID { get; set; } = 0;

        [XmlElement]
        public string pilot { get; set; } = "NONE";

        [XmlElement]
        public string paint { get; set; } = "SOVIET";

        [XmlElement]
        public string weapon { get; set; } = "WG_MACHINEGUN";

        [XmlElement]
        public Position position = new Position(new Coordinates(), new Rotation());

        public override Position GetPosition()
        {
            return position;
        }

        public override void SetPosition(Position pos)
        {
            position = pos;
        }

        public override int GetID()
        {
            return ID;
        }

        public override string GetObjectName()
        {
            return "WalkerGear_" + ID;
        }
    }

    public class WalkerMetadata : Metadata
    {
        public WalkerMetadata() { }

        public WalkerMetadata(WalkerControl control)
        {
            objectiveType = control.comboBox_ObjType.Text;
        }

        [XmlAttribute]
        public string objectiveType { get; set; } = "ELIMINATE";
    }
}
