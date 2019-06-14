using System.Windows.Forms;

namespace SOC.QuestObjects.Item
{
    public partial class ItemControl : UserControl
    {
        public ItemControl()
        {
            InitializeComponent();
            comboBox_itemObjType.SelectedIndex = 0;
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        }

        internal void SetMetadata(ItemMetada meta)
        {
            comboBox_itemObjType.Text = meta.itemObjectiveType;
        }
    }
}
