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
        public int vehicleID;

        public VehicleBox(Vehicle v, VehicleMetadata meta)
        {
            InitializeComponent();
            vehicleID = v.ID;

            v_textBox_xcoord.Text = v.position.coords.xCoord;
            v_textBox_ycoord.Text = v.position.coords.yCoord;
            v_textBox_zcoord.Text = v.position.coords.zCoord;
            v_textBox_rot.Text = v.position.rotation.GetDegreeRotY();

            v_checkBox_target.Checked = v.isTarget;

            v_comboBox_vehicle.Items.AddRange(new string[] 
            {
                "TT77 NOSOROG","M84A MAGLOADER", "ZHUK BR-3", "ZHUK RS-ZO","STOUT IFV-SC","STOUT IFV-FS"
            });
            v_comboBox_vehicle.Text = v.vehicle;

            v_comboBox_class.Items.AddRange(new string[] 
            {
                "DEFAULT", "DARK_GRAY", "OXIDE_RED"
            });
            v_comboBox_class.Text = v.vehicleClass;
        }

        public override QuestObject getQuestObject()
        {
            return new Vehicle(this);
        }
    }
}
