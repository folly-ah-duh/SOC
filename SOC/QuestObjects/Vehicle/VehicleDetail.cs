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
    public class VehicleDetail : Detail
    {
        public VehicleDetail() { }

        public VehicleDetail(List<Vehicle> vehicleList, VehicleMetadata vehicleMeta)
        {
            vehicles = vehicleList; vehicleMetadata = vehicleMeta;
        }

        [XmlArray]
        public List<Vehicle> vehicles { get; set; } = new List<Vehicle>();

        [XmlElement]
        public VehicleMetadata vehicleMetadata { get; set; } = new VehicleMetadata();

        public override DetailManager GetNewManager()
        {
            return new VehicleManager(this);
        }

        public override List<QuestObject> GetQuestObjects()
        {
            return vehicles.Cast<QuestObject>().ToList();
        }

        public override void SetQuestObjects(List<QuestObject> qObjects)
        {
            vehicles = qObjects.Cast<Vehicle>().ToList();
        }

        public override Metadata GetMetadata()
        {
            return vehicleMetadata;
        }
    }

    public class Vehicle : QuestObject
    {

        public Vehicle() { }

        public Vehicle(VehicleBox vBox, int index)
        {
            isTarget = vBox.v_checkBox_target.Checked;
            ID = index;
            vehicleIndex = vBox.v_comboBox_vehicle.SelectedIndex;
            vehicleClass = vBox.v_comboBox_class.Text;
            position = new Position(new Coordinates(vBox.v_textBox_xcoord.Text, vBox.v_textBox_ycoord.Text, vBox.v_textBox_zcoord.Text), new Rotation(vBox.v_textBox_rot.Text));
        }

        public Vehicle(Position pos, int index)
        {
            position = pos; ID = index;
        }

        public override string GetObjectName()
        {
            return "Vehicle_" + ID;
        }

        public override Position GetPosition()
        {
            return position;
        }

        public override void SetPosition(Position pos)
        {
            position = pos;
        }

        public override int GetID()
        {
            return ID;
        }

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlAttribute]
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
