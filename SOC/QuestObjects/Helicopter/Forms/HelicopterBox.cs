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
        public int helicopterID;

        public HelicopterBox(Helicopter h, List<string> routes)
        {
            InitializeComponent();
            helicopterID = h.ID;

            h_textBox_xcoord.Text = h.position.coords.xCoord;
            h_textBox_ycoord.Text = h.position.coords.yCoord;
            h_textBox_zcoord.Text = h.position.coords.zCoord;
            h_textBox_rot.Text = h.position.rotation.GetDegreeRotY();

            h_checkBox_target.Checked = h.isTarget;
            
            h_comboBox_class.Text = h.heliClass;

            h_comboBox_route.Items.Add("NONE");
            h_comboBox_route.Items.AddRange(routes.ToArray());
            if (h_comboBox_route.Items.Contains(h.heliRoute))
            {
                h_comboBox_route.Text = h.heliRoute;
            }
            else
            {
                h_comboBox_route.Text = "NONE";
            }
        }

        public override QuestObject getQuestObject()
        {
            return new Helicopter(this);
        }
    }
}
