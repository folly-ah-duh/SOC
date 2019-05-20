using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOC.QuestObjects.Common;

namespace SOC.Forms.Pages
{
    public partial class LocationalDataStub : UserControl
    {
        public LocationalDataStub(QuestObjectManager questObjectManager)
        {
            InitializeComponent();
            // add object nametag to the label
            // add any existing object locations to the textbox
        }

        public string GetBoxText() // give textbox text for a method to parse into coordinate/rotation pairs
        {
            return "";
        }
    }
}
