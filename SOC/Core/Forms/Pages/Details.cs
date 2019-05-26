using SOC.QuestObjects.Common;
using System.Windows.Forms;

namespace SOC.UI
{
    public partial class Details : UserControl
    {
        ManagerMaster managerMaster;

        public Details(ManagerMaster manMaster)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            managerMaster = manMaster;
        }

        private void flowPanelDetails_Layout(object sender, LayoutEventArgs e)
        {
            labelFlowHeight.Height = flowPanelDetails.Height;
        }
    }
}
