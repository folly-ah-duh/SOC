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

namespace SOC.QuestObjects.UAV
{
    public partial class UAVBox : QuestBox
    {
        public int ID;

        public UAVBox(UAV qObject, List<string> routes)
        {
            InitializeComponent();
            ID = qObject.ID;
            groupBox_main.Text = qObject.GetObjectName();
            
            textBox_xcoord.Text = qObject.position.coords.xCoord;
            textBox_ycoord.Text = qObject.position.coords.yCoord;
            textBox_zcoord.Text = qObject.position.coords.zCoord;
            textBox_rot.Text = qObject.position.rotation.GetDegreeRotY();


            comboBox_dRoute.Items.Add("NONE");
            comboBox_dRoute.Items.AddRange(routes.ToArray());
            if (comboBox_dRoute.Items.Contains(qObject.dRoute))
            {
                comboBox_dRoute.Text = qObject.dRoute;
            }
            else
            {
                comboBox_dRoute.Text = "NONE";
            }
            
            comboBox_aRoute.Items.Add("NONE");
            comboBox_aRoute.Items.AddRange(routes.ToArray());
            if (comboBox_aRoute.Items.Contains(qObject.aRoute))
            {
                comboBox_aRoute.Text = qObject.aRoute;
            }
            else
            {
                comboBox_aRoute.Text = "NONE";
            }
        }

        public override QuestObject getQuestObject()
        {
            return new UAV(this);
        }


    }
}
