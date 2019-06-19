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

namespace SOC.QuestObjects.Helicopter
{
    public partial class HelicopterBox : QuestBox
    {
        public int ID;

        public HelicopterBox(Helicopter qObject, List<string> routes)
        {
            InitializeComponent();
            ID = qObject.ID;
            groupBox_main.Text = qObject.GetObjectName();

            textBox_xcoord.Text = qObject.position.coords.xCoord;
            textBox_ycoord.Text = qObject.position.coords.yCoord;
            textBox_zcoord.Text = qObject.position.coords.zCoord;
            textBox_rot.Text = qObject.position.rotation.GetDegreeRotY();

            checkBox_target.Checked = qObject.isTarget;
            
            comboBox_class.Text = qObject.heliClass;

            comboBox_route.Items.Add("NONE");
            comboBox_route.Items.AddRange(routes.ToArray());
            if (comboBox_route.Items.Contains(qObject.heliRoute))
            {
                comboBox_route.Text = qObject.heliRoute;
            }
            else
            {
                comboBox_route.Text = "NONE";
            }
        }

        public override QuestObject getQuestObject()
        {
            return new Helicopter(this);
        }
    }
}
