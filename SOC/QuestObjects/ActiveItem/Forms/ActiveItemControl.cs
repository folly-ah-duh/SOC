using System.Windows.Forms;

namespace SOC.QuestObjects.ActiveItem.Forms
{
    public partial class ActiveItemControl : UserControl
    {
        public ActiveItemControl()
        {
            InitializeComponent();
            comboBox_ObjType.SelectedIndex = 0;
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        }

        internal void SetMetadata(ActiveItemMetadata meta)
        {
            comboBox_ObjType.Text = meta.itemObjectiveType;
        }
    }
}
