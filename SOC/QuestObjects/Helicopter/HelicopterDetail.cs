using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using SOC.Core.Classes.InfiniteHeaven;
using System.Windows.Forms;
using System.Linq;

namespace SOC.QuestObjects.Helicopter
{
    public class HelicopterDetail : Detail
    {
        public HelicopterDetail() { }

        public HelicopterDetail(List<Helicopter> heliList, HelicopterMetadata meta)
        {
            helicopters = heliList; helicopterMetadata = meta;
        }
        
        [XmlElement]
        public HelicopterMetadata helicopterMetadata { get; set; } = new HelicopterMetadata();

        [XmlArray]
        public List<Helicopter> helicopters { get; set; } = new List<Helicopter>(); 

        public override Metadata GetMetadata()
        {
            return helicopterMetadata;
        }

        public override DetailManager GetNewManager()
        {
            return new HelicopterManager(this);
        }

        public override List<QuestObject> GetQuestObjects()
        {
            return helicopters.Cast<QuestObject>().ToList();
        }

        public override void SetQuestObjects(List<QuestObject> qObjects)
        {
            helicopters = qObjects.Cast<Helicopter>().ToList();
        }
    }

    public class Helicopter : QuestObject
    {
        public Helicopter() { }

        public Helicopter(Position pos, int index)
        {
            position = pos; ID = index;
        }

        public Helicopter(HelicopterBox h)
        {
            ID = h.helicopterID;
            
            isTarget = h.h_checkBox_target.Checked;
            heliRoute = h.h_comboBox_route.Text;
            heliClass = h.h_comboBox_class.Text;
            position = new Position(new Coordinates(h.h_textBox_xcoord.Text, h.h_textBox_ycoord.Text, h.h_textBox_zcoord.Text), new Rotation(h.h_textBox_rot.Text));
        }

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public bool isSpawn { get; set; } = false;

        [XmlAttribute]
        public int ID { get; set; } = 0;

        [XmlElement]
        public string heliRoute { get; set; } = "NONE";

        [XmlElement]
        public string heliClass { get; set; } = "DEFAULT";

        [XmlElement]
        public Position position { get; set; } = new Position(new Coordinates(), new Rotation());
        
        public override int GetID()
        {
            return ID;
        }

        public override string GetObjectName()
        {
            if (ID == 0)
                return "EnemyHeli"; // TppReinforceBlock.REINFORCE_HELI_NAME
            else
                return "Helicopter_" + ID;
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

    public class HelicopterMetadata : Metadata
    {
        public HelicopterMetadata() { }

        public HelicopterMetadata(HelicopterControl heliControl)
        {
            helicopterObjectiveType = heliControl.comboBox_heliObjType.Text;
        }

        [XmlAttribute]
        public string helicopterObjectiveType { get; set; } = "KILLREQUIRED";
    }
}
