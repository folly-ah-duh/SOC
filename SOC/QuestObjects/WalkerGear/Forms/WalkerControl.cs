using System.Windows.Forms;

namespace SOC.QuestObjects.WalkerGear
{
    public partial class WalkerControl : UserControl
    {
        public WalkerControl()
        {
            InitializeComponent();
            comboBox_WalkerObjType.SelectedIndex = 0;
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        }

        public void SetMetadata(WalkerMetadata meta)
        {
            comboBox_WalkerObjType.Text = meta.walkerObjectiveType;
        }
    }
}
