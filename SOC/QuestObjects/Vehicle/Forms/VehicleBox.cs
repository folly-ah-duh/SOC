using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOC.UI;
using SOC.QuestObjects.Common;

namespace SOC.QuestObjects.Vehicle
{
    public partial class VehicleBox : QuestBox
    {
        public int ID;

        public VehicleBox(Vehicle v, VehicleMetadata meta)
        {
            InitializeComponent();
            ID = v.ID;

            textBox_xcoord.Text = v.position.coords.xCoord;
            textBox_ycoord.Text = v.position.coords.yCoord;
            textBox_zcoord.Text = v.position.coords.zCoord;
            textBox_rot.Text = v.position.rotation.GetDegreeRotY();

            checkBox_target.Checked = v.isTarget;

            comboBox_vehicle.Items.AddRange(new string[] 
            {
                "TT77 NOSOROG","M84A MAGLOADER", "ZHUK BR-3", "ZHUK RS-ZO","STOUT IFV-SC","STOUT IFV-FS"
            });
            comboBox_vehicle.Text = v.vehicle;

            comboBox_class.Items.AddRange(new string[] 
            {
                "DEFAULT", "DARK_GRAY", "OXIDE_RED"
            });
            comboBox_class.Text = v.vehicleClass;
        }

        public override QuestObject getQuestObject()
        {
            return new Vehicle(this);
        }
    }
}
