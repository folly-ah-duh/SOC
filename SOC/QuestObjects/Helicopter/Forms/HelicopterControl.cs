using System.Windows.Forms;

namespace SOC.QuestObjects.Helicopter
{
    public partial class HelicopterControl : UserControl
    {
        public HelicopterControl()
        {
            InitializeComponent();
            comboBox_ObjType.SelectedIndex = 0;
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        }

        public void SetMetadata(HelicopterMetadata meta)
        {
            comboBox_ObjType.Text = meta.objectiveType;
        }
    }
}
