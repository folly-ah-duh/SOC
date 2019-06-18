using System.Windows.Forms;

namespace SOC.QuestObjects.Enemy
{
    public partial class EnemyControl : UserControl
    {
        public EnemyControl()
        {
            InitializeComponent();
        }

        internal void SetMetadata(EnemyMetadata meta)
        {
            comboBox_ObjType.Text = meta.objectiveType;
        }
    }
}
