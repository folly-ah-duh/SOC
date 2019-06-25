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

        public void SetMetadata(HostageMetadata meta, string[] bodyNames)
        {
            comboBox_Body.Items.Clear();
            comboBox_Body.Items.AddRange(bodyNames);

            if (comboBox_Body.Items.Contains(meta.hostageBodyName))
                comboBox_Body.Text = meta.hostageBodyName;
            else if (comboBox_Body.Items.Count > 0)
                comboBox_Body.SelectedIndex = 0;

            comboBox_ObjType.Text = meta.objectiveType;
            checkBox_intrgt.Checked = meta.canInterrogate;
        }
    }
}
