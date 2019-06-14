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

        public HelicopterBox(Helicopter h, List<string> routes)
        {
            InitializeComponent();
            ID = h.ID;

            textBox_xcoord.Text = h.position.coords.xCoord;
            textBox_ycoord.Text = h.position.coords.yCoord;
            textBox_zcoord.Text = h.position.coords.zCoord;
            textBox_rot.Text = h.position.rotation.GetDegreeRotY();

            checkBox_target.Checked = h.isTarget;
            
            comboBox_class.Text = h.heliClass;

            comboBox_route.Items.Add("NONE");
            comboBox_route.Items.AddRange(routes.ToArray());
            if (comboBox_route.Items.Contains(h.heliRoute))
            {
                comboBox_route.Text = h.heliRoute;
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
