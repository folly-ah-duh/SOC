using SOC.Classes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SOC.QuestObjects.Hostage
{

    public class Hostage
    {

        public Hostage() { }

        public Hostage(HostageBox d, int num)
        {
            isTarget = d.h_checkBox_target.Checked;
            isUntied = d.h_checkBox_untied.Checked;
            isInjured = d.h_checkBox_injured.Checked;
            number = num;
            name = d.h_groupBox_main.Text;
            skill = d.h_comboBox_skill.Text;
            staffType = d.h_comboBox_staff.Text;
            scared = d.h_comboBox_scared.Text;
            language = d.h_comboBox_lang.Text;
            coordinates = new Coordinates(d.h_textBox_xcoord.Text, d.h_textBox_ycoord.Text, d.h_textBox_zcoord.Text, d.h_textBox_rot.Text);
        }

        public Hostage(Coordinates coords, int num, string nme)
        {
            coordinates = coords; number = num; name = nme;
        }

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public bool isUntied { get; set; } = false;

        [XmlElement]
        public bool isInjured { get; set; } = false;

        [XmlElement]
        public int number { get; set; } = 0;

        [XmlAttribute]
        public string name { get; set; } = "Hostage_0";

        [XmlElement]
        public string skill { get; set; } = "NONE";

        [XmlElement]
        public string staffType { get; set; } = "NONE";

        [XmlElement]
        public string scared { get; set; } = "NORMAL";

        [XmlElement]
        public string language { get; set; } = "english";

        [XmlElement]
        public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0", "0");

    }

}
