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

namespace SOC.QuestObjects.ActiveItem
{
    public partial class ActiveItemBox : QuestBox
    {
        public int ID;

        public ActiveItemBox(ActiveItem qObject)
        {
            InitializeComponent();
            ID = qObject.ID;

            textBox_xcoord.Text = qObject.position.coords.xCoord;
            textBox_ycoord.Text = qObject.position.coords.yCoord;
            textBox_zcoord.Text = qObject.position.coords.zCoord;

            textBox_xrot.Text = qObject.position.rotation.quatRotation.xval;
            textBox_yrot.Text = qObject.position.rotation.quatRotation.yval;
            textBox_zrot.Text = qObject.position.rotation.quatRotation.zval;
            textBox_wrot.Text = qObject.position.rotation.quatRotation.wval;

            comboBox_activeItem.Items.AddRange(ActiveItemNames.activeItems);
            comboBox_activeItem.Text = qObject.activeItem;

            checkBox_target.Checked = qObject.isTarget;
        }

        public override QuestObject getQuestObject()
        {
            return new ActiveItem(this);
        }
    }
}
