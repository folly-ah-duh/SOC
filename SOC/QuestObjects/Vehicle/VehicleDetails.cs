using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace SOC.QuestObjects.Vehicle
{
    [XmlType("VehicleDetails")]
    public class VehicleDetails : Detail
    {
        public VehicleDetails() : base (new List<Vehicle>(), new VehicleMetadata()) { }

        public VehicleDetails(List<Vehicle> vehicleList, VehicleMetadata vehicleMeta) : base (vehicleList, vehicleMeta)
        {
            Vehicles = vehicleList; vehicleMetadata = vehicleMeta;
        }

        [XmlArray]
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        [XmlElement]
        public VehicleMetadata vehicleMetadata { get; set; } = new VehicleMetadata();

        public override DetailManager GetNewManager()
        {
            return new VehicleManager(this);
        }
    }

    public class Vehicle : QuestObject
    {

        public Vehicle() : base(new Position(new Coordinates(), new Rotation()), 0) { }

        public Vehicle(VehicleBox vBox, int index) : base(new Position(new Coordinates(vBox.v_textBox_xcoord.Text, vBox.v_textBox_ycoord.Text, vBox.v_textBox_zcoord.Text), new Rotation(vBox.v_textBox_rot.Text)), index)
        {
            isTarget = vBox.v_checkBox_target.Checked;
            ID = base.ID;
            vehicleIndex = vBox.v_comboBox_vehicle.SelectedIndex;
            vehicleClass = vBox.v_comboBox_class.Text;
            position = base.position;
        }

        public Vehicle(Position pos, int index) : base (pos, index)
        {
            position = pos; ID = index;
        }

        public override string GetObjectName()
        {
            return "Vehicle_" + ID;
        }

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public int ID { get; set; } = 0;

        [XmlElement]
        public int vehicleIndex { get; set; } = 0;

        [XmlElement]
        public string vehicleClass { get; set; } = "DEFAULT";

        [XmlElement]
        public Position position = new Position(new Coordinates(), new Rotation());
    }

    public class VehicleMetadata : Metadata
    {

        public VehicleMetadata() { }

        public VehicleMetadata(VehicleControl vehiclePanel)
        {
            vehicleObjectiveType = vehiclePanel.comboBox_vehObjType.Text;
        }

        [XmlAttribute]
        public string vehicleObjectiveType { get; set; } = "ELIMINATE";

        public override void DrawMetadata(UserControl control)
        {
            throw new NotImplementedException();
        }
    }
}
