using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.Windows.Forms;

namespace SOC.UI
{
    public partial class DetailDisplay : UserControl
    {
        MasterManager managerMaster;

        public DetailDisplay(MasterManager manMaster)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            managerMaster = manMaster;
            flowPanelDetails.Controls.AddRange(managerMaster.GetModulePanels());
        }

        public void RefreshObjectPanels(CoreDetails core)
        {
            managerMaster.RefreshAllPanels(core);
        }

        private void flowPanelDetails_Layout(object sender, LayoutEventArgs e)
        {
            labelFlowHeight.Height = flowPanelDetails.Height - 18;
        }
    }
}
