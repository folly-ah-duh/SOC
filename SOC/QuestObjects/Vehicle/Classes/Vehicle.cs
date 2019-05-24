using SOC.Classes.Common;
using System.Xml.Serialization;

namespace SOC.QuestObjects.Vehicle
{
    public class Vehicle
    {

        public Vehicle() { }

        public Vehicle(VehicleBox d, int num)
        {
            isTarget = d.v_checkBox_target.Checked;
            number = num;
            name = d.v_groupBox_main.Text;
            vehicleIndex = d.v_comboBox_vehicle.SelectedIndex;
            vehicleClass = d.v_comboBox_class.Text;
            coordinates = new Coordinates(d.v_textBox_xcoord.Text, d.v_textBox_ycoord.Text, d.v_textBox_zcoord.Text);
            rotation = new Rotation(d.v_textBox_rot.Text);
        }

        public Vehicle(Coordinates coords, int num, string nme)
        {
            coordinates = coords; number = num; name = nme;
        }

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public int number { get; set; } = 0;

        [XmlAttribute]
        public string name { get; set; } = "Vehicle_0";

        [XmlElement]
        public int vehicleIndex { get; set; } = 0;

        [XmlElement]
        public string vehicleClass { get; set; } = "DEFAULT";

        [XmlElement]
        public Coordinates coordinates { get; set; } = new Coordinates("0", "0", "0");

        [XmlElement]
        public Rotation rotation { get; set; } = new Rotation("0");
    }
}
