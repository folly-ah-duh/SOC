using System.Windows.Forms;

namespace SOC.QuestObjects.Enemy
{
    public partial class EnemyControl : UserControl
    {
        public EnemyControl()
        {
            InitializeComponent();
            comboBox_ObjType.SelectedIndex = 0;
            //comboBox_Subtype.SelectedIndex = 0;
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        }

        internal void SetMetadata(EnemyMetadata meta)
        {
            comboBox_ObjType.Text = meta.objectiveType;
            //comboBox_Subtype.Text = meta.subtype;
        }
    }
}
