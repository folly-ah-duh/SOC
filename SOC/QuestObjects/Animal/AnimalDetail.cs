﻿using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.Linq;

namespace SOC.QuestObjects.Animal
{
    /*
    public class Animal
    {

        public Animal() { }

        public Animal(AnimalBox d, int num)
        {
            isTarget = d.a_checkBox_isTarget.Checked;
            number = num;
            name = d.a_groupBox_main.Text;
            count = d.a_comboBox_count.Text;
            animal = d.a_comboBox_animal.Text;
            typeID = d.a_comboBox_TypeID.Text;
            coordinates = new Coordinates(d.a_textBox_xcoord.Text, d.a_textBox_ycoord.Text, d.a_textBox_zcoord.Text);
            rotation = new Rotation(d.a_textBox_rot.Text);
        }

        public Animal(Coordinates coords, int num, string nme)
        {
            coordinates = coords; number = num; name = nme;
        }

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public int number { get; set; } = 0;

        [XmlAttribute]
        public string name { get; set; } = "Animal_Cluster_0";

        [XmlElement]
        public string count { get; set; } = "1";

        [XmlElement]
        public string animal { get; set; } = "Sheep";

        [XmlElement]
        public string typeID { get; set; } = "TppGoat";

        [XmlElement]
        public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0");

        [XmlElement]
        public Rotation rotation { get; set; } = new Rotation("0");

    }
    */
}