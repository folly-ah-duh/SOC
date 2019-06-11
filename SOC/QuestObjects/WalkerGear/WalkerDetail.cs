using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using SOC.Core.Classes.InfiniteHeaven;
using System.Linq;

namespace SOC.QuestObjects.WalkerGear
{
    [XmlType("WalkerDetails")]
    public class WalkerDetail : Detail
    {
        public WalkerDetail() { }

        public WalkerDetail(List<WalkerGear> walkerList, WalkerMetadata meta)
        {
            walkers = walkerList; walkerMetadata = meta;
        }
        
        [XmlArray]
        public List<WalkerGear> walkers { get; set; } = new List<WalkerGear>();

        [XmlElement]
        public WalkerMetadata walkerMetadata { get; set; } = new WalkerMetadata();

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

        public WalkerGear(WalkerBox walkerBox)
        {
            ID = walkerBox.walkerID;

            isTarget = walkerBox.w_checkBox_target.Checked;
            pilot = walkerBox.w_comboBox_pilot.Text;
            paint = walkerBox.w_comboBox_paint.Text;
            weapon = walkerBox.w_comboBox_weapon.Text;
            position = new Position(new Coordinates(walkerBox.w_textBox_xcoord.Text, walkerBox.w_textBox_ycoord.Text, walkerBox.w_textBox_zcoord.Text), new Rotation(walkerBox.w_textBox_rot.Text));
        }

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
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

        public WalkerMetadata(WalkerControl walkerControl)
        {
            walkerObjectiveType = walkerControl.comboBox_WalkerObjType.Text;
        }

        [XmlAttribute]
        public string walkerObjectiveType { get; set; } = "ELIMINATE";
    }
}
