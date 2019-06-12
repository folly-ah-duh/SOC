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

namespace SOC.QuestObjects.WalkerGear
{
    public partial class WalkerBox : QuestBox
    {
        public int walkerID;

        public WalkerBox(WalkerGear w)
        {
            InitializeComponent();
            walkerID = w.ID;

            w_textBox_xcoord.Text = w.position.coords.xCoord;
            w_textBox_ycoord.Text = w.position.coords.yCoord;
            w_textBox_zcoord.Text = w.position.coords.zCoord;
            w_textBox_rot.Text = w.position.rotation.GetDegreeRotY();

            w_checkBox_target.Checked = w.isTarget;

            w_comboBox_pilot.Items.AddRange(new object[] {
                "NONE",
                "sol_quest_0000",
                "sol_quest_0001",
                "sol_quest_0002",
                "sol_quest_0003",
                "sol_quest_0004",
                "sol_quest_0005",
                "sol_quest_0006",
                "sol_quest_0007"
            });
            w_comboBox_pilot.Text = w.pilot;

            w_comboBox_paint.Items.AddRange(new object[] {
                "SOVIET",
                "ROGUE_COYOTE",
                "CFA",
                "ZRS",
                "DDOGS"
            });
            w_comboBox_paint.Text = w.paint;

            w_comboBox_weapon.Items.AddRange(new object[] {
                "WG_MACHINEGUN",
                "WG_MISSILE"
            });
            w_comboBox_weapon.Text = w.weapon;
        }

        public override QuestObject getQuestObject()
        {
            return new WalkerGear(this);
        }
    }
}
