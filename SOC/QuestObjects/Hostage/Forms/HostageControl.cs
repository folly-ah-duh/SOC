using System;
using System.Windows.Forms;
using SOC.Classes.Common;

namespace SOC.QuestObjects.Hostage
{
    public partial class HostageControl : UserControl
    {
        public HostageControl()
        {
            InitializeComponent();
            comboBox_Body.Items.AddRange(NPCBodyInfo.GetBodyNames());
            comboBox_Body.SelectedIndex = 0;
            comboBox_hosObjType.SelectedIndex = 0;
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        }

        public void SetMetadata(HostageMetadata meta)
        {
            comboBox_Body.Text = meta.hostageBodyName;
            comboBox_hosObjType.Text = meta.hostageObjectiveType;
            h_checkBox_intrgt.Checked = meta.canInterrogate;
        }
    }
}
