using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using SOC.QuestObjects.Vehicle.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SOC.QuestObjects.Vehicle
{
    [XmlType("VehicleDetails")]
    public class VehicleDetails : QuestObjectDetails
    {
        public VehicleDetails() { }

        public VehicleDetails(List<Vehicle> vehicleList, VehicleMetadata vehicleMeta)
        {
            Vehicles = vehicleList; vehicleMetadata = vehicleMeta;
        }

        [XmlArray]
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        [XmlElement]
        public VehicleMetadata vehicleMetadata { get; set; } = new VehicleMetadata();

        public override QuestObjectManager GetNewManager()
        {
            return new VehicleManager(this);
        }
    }

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

    public class VehicleMetadata
    {

        public VehicleMetadata() { }

        public VehicleMetadata(VehiclePanel vehiclePanel)
        {
            vehicleObjectiveType = vehiclePanel.comboBox_vehObjType.Text;
        }

        [XmlAttribute]
        public string vehicleObjectiveType { get; set; } = "ELIMINATE";
    }
}
