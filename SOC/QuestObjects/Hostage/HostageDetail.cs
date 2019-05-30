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
    [XmlType(TypeName = "HostageDetail")]
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

        public Hostage(HostageBox hBox)
        {
            ID = hBox.hostageID;

            isTarget = hBox.h_checkBox_target.Checked;
            isUntied = hBox.h_checkBox_untied.Checked;
            isInjured = hBox.h_checkBox_injured.Checked;
            skill = hBox.h_comboBox_skill.Text;
            staffType = hBox.h_comboBox_staff.Text;
            scared = hBox.h_comboBox_scared.Text;
            language = hBox.h_comboBox_lang.Text;
            position = new Position(new Coordinates(hBox.h_textBox_xcoord.Text, hBox.h_textBox_ycoord.Text, hBox.h_textBox_zcoord.Text), new Rotation(hBox.h_textBox_rot.Text));
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

        [XmlElement]
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
    
    [XmlType(TypeName = "HostageMetadata")]
    public class HostageMetadata : Metadata
    {
        public HostageMetadata() { }

        public HostageMetadata(HostageControl hostageControl)
        {
            hostageBodyName = hostageControl.comboBox_Body.Text;
            canInterrogate = hostageControl.h_checkBox_intrgt.Checked;
            hostageObjectiveType = hostageControl.comboBox_hosObjType.Text;
        }

        public override void DrawMetadata(UserControl control)
        {
            HostageControl hostageControl = (HostageControl)control;
            hostageControl.comboBox_Body.Text = hostageBodyName;
            hostageControl.comboBox_hosObjType.Text = hostageObjectiveType;
            hostageControl.h_checkBox_intrgt.Checked = canInterrogate;
        }

        [XmlAttribute]
        public string hostageBodyName { get; set; } = "AFGH_HOSTAGE";

        [XmlAttribute]
        public bool canInterrogate { get; set; } = false;

        [XmlAttribute]
        public string hostageObjectiveType { get; set; } = "ELIMINATE";
    }
}
