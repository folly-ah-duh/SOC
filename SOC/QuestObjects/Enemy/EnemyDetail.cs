using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.Linq;

namespace SOC.QuestObjects.Enemy
{
    public class EnemyDetail : Detail
    {
        public EnemyDetail() { }

        public EnemyDetail(List<Enemy> enemyList, EnemyMetadata meta)
        {
            enemies = enemyList; enemyMetadata = meta;
        }

        [XmlElement]
        public EnemyMetadata enemyMetadata { get; set; } = new EnemyMetadata();

        [XmlArray]
        public List<Enemy> enemies { get; set; } = new List<Enemy>();

        public override Metadata GetMetadata()
        {
            return enemyMetadata;
        }

        public override DetailManager GetNewManager()
        {
            return new EnemyManager(this);
        }

        public override List<QuestObject> GetQuestObjects()
        {
            return enemies.Cast<QuestObject>().ToList();
        }

        public override void SetQuestObjects(List<QuestObject> qObjects)
        {
            enemies = qObjects.Cast<Enemy>().ToList();
        }
    }

    public class Enemy : QuestObject
    {

        public Enemy() { }

        public Enemy(EnemyBox box)
        {
            name = box.enemyName;

            spawn = box.checkBox_spawn.Checked;
            isTarget = box.checkBox_target.Checked;
            balaclava = box.checkBox_balaclava.Checked;
            zombie = box.checkBox_zombie.Checked;

            cRoute = box.comboBox_cautionroute.Text;
            dRoute = box.comboBox_sneakroute.Text;
            skill = box.comboBox_skill.Text;
            staffType = box.comboBox_staff.Text;

            armored = box.checkBox_armor.Checked;
            body = box.comboBox_body.Text;
            powers = box.listBox_power.Items.OfType<string>().ToArray();
        }

        public Enemy(string enemyName)
        {
            name = enemyName;
        }

        [XmlAttribute]
        public string name { get; set; } = "sol_quest_0000";

        [XmlElement]
        public bool spawn { get; set; } = false;

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public bool balaclava { get; set; } = false;

        [XmlElement]
        public bool zombie { get; set; } = false;

        [XmlElement]
        public bool armored { get; set; } = false;

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

        public override Position GetPosition()
        {
            return new Position();
        }

        public override void SetPosition(Position pos)
        {
            return;
        }

        public override int GetID()
        {
            return 0;
        }

        public override string GetObjectName()
        {
            return name;
        }
    }

    public class EnemyMetadata : Metadata
    {
        public EnemyMetadata() { }

        public EnemyMetadata(EnemyControl control)
        {
            objectiveType = control.comboBox_ObjType.Text;
            subtype = control.comboBox_Subtype.Text;
        }

        [XmlAttribute]
        public string objectiveType { get; set; } = "ELIMINATE";

        [XmlAttribute]
        public string subtype { get; set; } = "SOVIET_A";

    }
}
