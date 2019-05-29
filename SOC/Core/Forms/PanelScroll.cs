using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SOC.UI
{
    class PanelScroll : IMessageFilter
    {
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private Panel scrollPanel;
        bool canScrollAnywhere;

        public PanelScroll(Panel panel, bool unconstrained)
        {
            scrollPanel = panel;
            canScrollAnywhere = unconstrained;
        }

        bool IMessageFilter.PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x020A)
            {

                if (scrollPanel.RectangleToScreen(scrollPanel.ClientRectangle).Contains(Cursor.Position) || canScrollAnywhere)
                {
                    SendMessage(scrollPanel.Handle, m.Msg, m.WParam.ToInt32(), m.LParam.ToInt32());
                    return true;
                }
            }

            return false;
        }
    }
}
