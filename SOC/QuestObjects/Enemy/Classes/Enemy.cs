using System.Xml.Serialization;

namespace SOC.QuestObjects.Enemy
{
    /*
    public class Enemy
    {

        public Enemy() { }

        public Enemy(EnemyBox d, int num)
        {
            isSpawn = d.e_checkBox_spawn.Checked;
            isTarget = d.e_checkBox_target.Checked;
            isBalaclava = d.e_checkBox_balaclava.Checked;
            isZombie = d.e_checkBox_zombie.Checked;
            isArmored = d.e_checkBox_armor.Checked;
            number = num;
            name = d.e_groupBox_main.Text;
            body = d.e_comboBox_body.Text;
            cRoute = d.e_comboBox_cautionroute.Text;
            dRoute = d.e_comboBox_sneakroute.Text;
            skill = d.e_comboBox_skill.Text;
            staffType = d.e_comboBox_staff.Text;
            string[] powerArray = new string[d.e_listBox_power.Items.Count];
            d.e_listBox_power.Items.CopyTo(powerArray, 0);
            powers = powerArray;
        }

        public Enemy(int num, string nme)
        {
            number = num; name = nme;
        }

        [XmlElement]
        public bool isSpawn { get; set; } = false;

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public bool isBalaclava { get; set; } = false;

        [XmlElement]
        public bool isZombie { get; set; } = false;

        [XmlElement]
        public bool isArmored { get; set; } = false;

        [XmlElement]
        public int number { get; set; } = 0;

        [XmlAttribute]
        public string name { get; set; } = "sol_quest_0000";

        [XmlElement]
        public string body { get; set; } = "DEFAULT";

        [XmlElement]
        public string cRoute { get; set; } = "NONE";

        [XmlElement]
        public string dRoute { get; set; } = "NONE";

        [XmlElement]
        public string skill { get; set; } = "NONE";

        [XmlElement]
        public string staffType { get; set; } = "NONE";

        [XmlArray]
        public string[] powers { get; set; } = new string[0];

    }
    */
}
