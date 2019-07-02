using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.Linq;

namespace SOC.QuestObjects.UAV
{
    public class UAVDetail : Detail
    {
        public UAVDetail() { }

        public UAVDetail(List<UAV> UAVList, UAVMetadata meta)
        {
            UAVs = UAVList; UAVmetadata = meta;
        }

        [XmlElement]
        public UAVMetadata UAVmetadata { get; set; } = new UAVMetadata();

        [XmlArray]
        public List<UAV> UAVs { get; set; } = new List<UAV>();

        public override Metadata GetMetadata()
        {
            return UAVmetadata;
        }

        public override DetailManager GetNewManager()
        {
            return new UAVManager(this);
        }

        public override List<QuestObject> GetQuestObjects()
        {
            return UAVs.Cast<QuestObject>().ToList();
        }

        public override void SetQuestObjects(List<QuestObject> qObjects)
        {
            UAVs = qObjects.Cast<UAV>().ToList();
        }
    }

    public class UAV : QuestObject
    {
        public UAV() { }

        public UAV(Position pos, int numId)
        {
            position = pos; ID = numId;
        }

        public UAV(UAVBox box)
        {
            ID = box.ID;

            aRoute = box.comboBox_aRoute.Text;
            dRoute = box.comboBox_dRoute.Text;
            position = new Position(new Coordinates(box.textBox_xcoord.Text, box.textBox_ycoord.Text, box.textBox_zcoord.Text), new Rotation(box.textBox_rot.Text));
        }

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
            return "UAV_" + ID;
        }

        [XmlElement]
        public int ID { get; set; } = 0;

        [XmlElement]
        public string aRoute { get; set; } = "NONE";

        [XmlElement]
        public string dRoute { get; set; } = "NONE";

        [XmlElement]
        public Position position = new Position(new Coordinates(), new Rotation());
    }

    public class UAVMetadata : Metadata
    {
        public UAVMetadata() { }
    }
}
