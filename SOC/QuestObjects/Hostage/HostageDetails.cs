using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using SOC.Core.Classes.InfiniteHeaven;
using System.Windows.Forms;

namespace SOC.QuestObjects.Hostage
{
    [XmlType("HostageDetails")]
    public class HostageDetails : Detail
    {
        public HostageDetails() : base (new List<Hostage>(), new HostageMetadata()) { }

        public HostageDetails(List<Hostage> hostageList, HostageMetadata hostageMeta) : base (hostageList, hostageMeta)
        {
            Hostages = hostageList; hostageMetadata = hostageMeta;
        }

        [XmlArray]
        public List<Hostage> Hostages { get; set; } = new List<Hostage>();

        [XmlElement]
        public HostageMetadata hostageMetadata { get; set; } = new HostageMetadata();

        public override DetailManager GetNewManager()
        {
            return new HostageManager(this);
        }
    }


    public class Hostage : QuestObject
    {
        public Hostage() : base(new Position(new Coordinates(), new Rotation()), 0) { }

        public Hostage(Position pos, int numId) : base (pos, numId)
        {
            position = pos; ID = numId;
        }

        public Hostage(HostageBox hBox) : base (new Position(new Coordinates(hBox.h_textBox_xcoord.Text, hBox.h_textBox_ycoord.Text, hBox.h_textBox_zcoord.Text), new Rotation(hBox.h_textBox_rot.Text)), hBox.hostageID)
        {
            ID = base.ID;

            isTarget = hBox.h_checkBox_target.Checked;
            isUntied = hBox.h_checkBox_untied.Checked;
            isInjured = hBox.h_checkBox_injured.Checked;
            skill = hBox.h_comboBox_skill.Text;
            staffType = hBox.h_comboBox_staff.Text;
            scared = hBox.h_comboBox_scared.Text;
            language = hBox.h_comboBox_lang.Text;
            position = base.position;
        }

        public override string GetObjectName()
        {
            return "Hostage_" + ID;
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
