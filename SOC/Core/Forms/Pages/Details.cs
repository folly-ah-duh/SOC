using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.Windows.Forms;

namespace SOC.UI
{
    public partial class Details : UserControl
    {
        MasterManager managerMaster;

        public Details(MasterManager manMaster)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            managerMaster = manMaster;
            flowPanelDetails.Controls.AddRange(managerMaster.GetModulePanels());
        }

        public void RefreshObjectPanels(CoreDetails core) // enemy will need routes and region info
        {
            managerMaster.RefreshAllPanels();
        }

        private void flowPanelDetails_Layout(object sender, LayoutEventArgs e)
        {
            labelFlowHeight.Height = flowPanelDetails.Height;
        }
    }
}
