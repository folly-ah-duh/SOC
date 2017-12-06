using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOC.UI
{
    public partial class Waiting : UserControl
    {
        public Waiting(Size panelSize)
        {
            InitializeComponent();
            this.Size = panelSize;
            labelWaiting.Location = new Point((panelSize.Width / 2) - (labelWaiting.Width / 2), (panelWaiting.Height / 4));
        }
    }
}
