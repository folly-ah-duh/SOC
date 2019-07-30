using System;
using System.Windows.Forms;
using SOC.Classes.Common;
using System.Collections.Generic;

namespace SOC.QuestObjects.Hostage
{
    public partial class HostageControl : UserControl
    {
        public HostageControl()
        {
            InitializeComponent();
            comboBox_ObjType.SelectedIndex = 0;
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        }

        public void SetMetadata(HostageMetadata meta, string[] bodyNames, string cpName)
        {
            comboBox_Body.Items.Clear();
            comboBox_Body.Items.AddRange(bodyNames);

            if (comboBox_Body.Items.Contains(meta.hostageBodyName))
                comboBox_Body.Text = meta.hostageBodyName;
            else if (comboBox_Body.Items.Count > 0)
                comboBox_Body.SelectedIndex = 0;

            comboBox_ObjType.Text = meta.objectiveType;

            if (cpName != "NONE")
            {
                checkBox_intrgt.Enabled = true;
                checkBox_intrgt.Checked = meta.canInterrogate;
                checkBox_intrgt.Text = "Interrogate For Whereabouts";
            }
            else
            {
                checkBox_intrgt.Enabled = false;
                checkBox_intrgt.Checked = false;
                checkBox_intrgt.Text = "Interrogate For Whereabouts [Requires Quest CP]";
            }
        }
    }
}
