using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using SOC.Core.Classes.InfiniteHeaven;
using System.Windows.Forms;
using System.Linq;

namespace SOC.QuestObjects.Hostage
{
    public class HostageDetail : Detail
    {
        public HostageDetail() { }

        public HostageDetail(List<Hostage> hostageList, HostageMetadata hostageMeta)
        {
            hostages = hostageList; hostageMetadata = hostageMeta;
        }

        [XmlElement]
        public HostageMetadata hostageMetadata { get; set; } = new HostageMetadata();

        [XmlArray]
        public List<Hostage> hostages { get; set; } = new List<Hostage>();

        public override Metadata GetMetadata()
        {
            return hostageMetadata;
        }

        public override DetailManager GetNewManager()
        {
            return new HostageManager(this);
        }

        public override List<QuestObject> GetQuestObjects()
        {
            return hostages.Cast<QuestObject>().ToList();
        }

        public override void SetQuestObjects(List<QuestObject> qObjects)
        {
            hostages = qObjects.Cast<Hostage>().ToList();
        }
    }


    public class Hostage : QuestObject
    {
        public Hostage() { }

        public Hostage(Position pos, int numId)
        {
            position = pos; ID = numId;
        }

        public Hostage(HostageBox box)
        {
            ID = box.ID;

            isTarget = box.checkBox_target.Checked;
            isUntied = box.checkBox_untied.Checked;
            isInjured = box.checkBox_injured.Checked;
            skill = box.comboBox_skill.Text;
            staffType = box.comboBox_staff.Text;
            scared = box.comboBox_scared.Text;
            language = box.comboBox_lang.Text;
            position = new Position(new Coordinates(box.textBox_xcoord.Text, box.textBox_ycoord.Text, box.textBox_zcoord.Text), new Rotation(box.textBox_rot.Text));
        }

        public override string GetObjectName()
        {
            return "Hostage_" + ID;
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

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public bool isUntied { get; set; } = false;

        [XmlElement]
        public bool isInjured { get; set; } = false;

        [XmlAttribute]
        public int ID { get; set; } = 0;

        [XmlElement]
        public string skill { get; set; } = "NONE";

        [XmlElement]
        public string staffType { get; set; } = "NONE";

        [XmlElement]
        public string scared { get; set; } = "NORMAL";

        [XmlElement]
        public string language { get; set; } = "english";

        [XmlElement]
        public Position position { get; set; } = new Position(new Coordinates(), new Rotation());
    }
    
    public class HostageMetadata : Metadata
    {
        public HostageMetadata() { }

        public HostageMetadata(HostageControl control)
        {
            hostageBodyName = control.comboBox_Body.Text;
            canInterrogate = control.checkBox_intrgt.Checked;
            objectiveType = control.comboBox_ObjType.Text;
        }

        [XmlAttribute]
        public string hostageBodyName { get; set; } = "AFGH_HOSTAGE";

        [XmlAttribute]
        public bool canInterrogate { get; set; } = false;

        [XmlAttribute]
        public string objectiveType { get; set; } = "ELIMINATE";
    }
}
