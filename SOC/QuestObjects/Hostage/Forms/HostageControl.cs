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
            panelHosDet.VerticalScroll.Visible = true;
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        }

        private void panelHosDet_Layout(object sender, LayoutEventArgs e)
        {
            //labelPanelWidth.Width = panelHosDet.Width; // muddies the gui especially when the vertical scroll appears
        }
    }
}
