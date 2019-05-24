using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System;
using System.Windows.Forms;

namespace SOC.Forms.Pages
{
    public partial class LocationalDataStub : UserControl
    {
        private static string locationWrittenConvention = "{pos={X, Y, Z},rotY=Y-Axis Rotation,},";
        private string questObjectTitle;

        public LocationalDataStub(string objectTitle)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            questObjectTitle = objectTitle;
            labelStub.Text = $"{questObjectTitle}: {locationWrittenConvention}";
        }

        internal void DisableStub(string reason)
        {
            textBoxCoords.Enabled = false;
            textBoxCoords.Text = "";
            textBoxCoords.BackColor = System.Drawing.Color.DarkGray;
            labelStub.ForeColor = System.Drawing.Color.Goldenrod;
            labelStub.Text = $"{questObjectTitle}: {locationWrittenConvention} [{reason}]";
        }

        internal void EnableStub()
        {
            textBoxCoords.Enabled = true;
            textBoxCoords.BackColor = System.Drawing.Color.Silver;
            labelStub.ForeColor = System.Drawing.Color.Black;
            labelStub.Text = $"{questObjectTitle}: {locationWrittenConvention}";
        }

        public IHLogPositions GetStubLocations()
        {
            return new IHLogPositions(textBoxCoords.Text);
        }

        public void SetStubText(IHLogPositions positions)
        {
            textBoxCoords.Text = positions.GetPositionsFormatted();
        }
    }
}
