using System;
using System.Windows.Forms;
using SOC.Classes.Common;

namespace SOC.QuestObjects.Hostage
{
    public partial class HostagePanel : UserControl
    {
        public HostagePanel()
        {
            InitializeComponent();
            comboBox_Body.Items.AddRange(NPCBodyInfo.GetBodyNames());
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        }

        private void comboBox_Body_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelHosDet_Layout(object sender, LayoutEventArgs e)
        {
            labelPanelWidth.Width = panelHosDet.Width;
        }
    }
}
