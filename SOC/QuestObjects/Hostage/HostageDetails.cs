using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SOC.QuestObjects.Hostage
{
    [XmlType("HostageDetails")]
    class HostageDetails : QuestObjectDetails
    {
        public HostageDetails() { }

        public HostageDetails(List<Hostage> hostageList, HostageMetadata hostageMeta)
        {
            Hostages = hostageList; hostageMetadata = hostageMeta;
        }

        [XmlArray]
        public List<Hostage> Hostages { get; set; } = new List<Hostage>();

        [XmlAttribute]
        public HostageMetadata hostageMetadata { get; set; } = new HostageMetadata();
    }


    public class Hostage
    {
        public Hostage() { }

        public Hostage(Coordinates coords, int numId)
        {
            coordinates = coords; hostageId = numId;
        }

        public Hostage(HostageBox hBox, int index)
        {
            hostageId = index;

            isTarget = hBox.h_checkBox_target.Checked;
            isUntied = hBox.h_checkBox_untied.Checked;
            isInjured = hBox.h_checkBox_injured.Checked;
            skill = hBox.h_comboBox_skill.Text;
            staffType = hBox.h_comboBox_staff.Text;
            scared = hBox.h_comboBox_scared.Text;
            language = hBox.h_comboBox_lang.Text;
            coordinates = new Coordinates(hBox.h_textBox_xcoord.Text, hBox.h_textBox_ycoord.Text, hBox.h_textBox_zcoord.Text);
            rotation = new Rotation(hBox.h_textBox_rot.Text);
        }

        public string GetHostageName()
        {
            return "Hostage_" + hostageId;
        }

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public bool isUntied { get; set; } = false;

        [XmlElement]
        public bool isInjured { get; set; } = false;

        [XmlElement]
        public int hostageId { get; set; } = 0;

        [XmlElement]
        public string skill { get; set; } = "NONE";

        [XmlElement]
        public string staffType { get; set; } = "NONE";

        [XmlElement]
        public string scared { get; set; } = "NORMAL";

        [XmlElement]
        public string language { get; set; } = "english";

        [XmlElement]
        public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0");

        [XmlElement]
        public Rotation rotation { get; set; } = new Rotation("0");
    }


    class HostageMetadata
    {

        public HostageMetadata() { }

        public HostageMetadata(HostagePanel hostagePanel)
        {
            hostageBodyName = hostagePanel.comboBox_Body.SelectedText;
            canInterrogate = hostagePanel.h_checkBox_intrgt.Checked;
            hostageObjectiveType = hostagePanel.comboBox_hosObjType.SelectedText;
        }

        [XmlAttribute]
        public string hostageBodyName { get; set; } = "AFGH_HOSTAGE";

        [XmlAttribute]
        public bool canInterrogate { get; set; } = false;

        [XmlAttribute]
        public string hostageObjectiveType { get; set; } = "ELIMINATE";
    }
}
