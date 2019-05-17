using SOC.Classes.Common;
using System.Xml.Serialization;

namespace SOC.QuestObjects.Hostage
{

    public class Hostage
    {
        public Hostage() { }
        
        public Hostage(Coordinates coords, int numId)
        {
            coordinates = coords; hostageId = numId;
        }

        public Hostage(HostageBox d, int num)
        {
            isTarget = d.h_checkBox_target.Checked;
            isUntied = d.h_checkBox_untied.Checked;
            isInjured = d.h_checkBox_injured.Checked;
            hostageId = num;
            skill = d.h_comboBox_skill.Text;
            staffType = d.h_comboBox_staff.Text;
            scared = d.h_comboBox_scared.Text;
            language = d.h_comboBox_lang.Text;
            coordinates = new Coordinates(d.h_textBox_xcoord.Text, d.h_textBox_ycoord.Text, d.h_textBox_zcoord.Text);
            rotation = new Rotation(d.h_textBox_rot.Text);
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

}
