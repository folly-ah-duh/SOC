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

        public Helicopter(int index) // (Position pos, int index)
        {
            //position = pos;
            ID = index;
        }

        public Helicopter(HelicopterBox box)
        {
            ID = box.ID;
            
            isTarget = box.checkBox_target.Checked;
            heliRoute = box.comboBox_route.Text;
            heliClass = box.comboBox_class.Text;
            //position = new Position(new Coordinates(box.textBox_xcoord.Text, box.textBox_ycoord.Text, box.textBox_zcoord.Text), new Rotation(box.textBox_rot.Text));
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
        /*
        [XmlElement]
        public Position position { get; set; } = new Position(new Coordinates(), new Rotation());
        */
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
            return new Position();
        }

        public override void SetPosition(Position pos)
        {
            return;
        }
    }

    public class HelicopterMetadata : Metadata
    {
        public HelicopterMetadata() { }

        public HelicopterMetadata(HelicopterControl control)
        {
            objectiveType = control.comboBox_ObjType.Text;
        }

        [XmlAttribute]
        public string objectiveType { get; set; } = "KILLREQUIRED";
    }
}
