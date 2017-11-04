using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOC
{
    public partial class formCustomProgressLang : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
        const int EM_SETCUEBANNER = 0x1501;
        public formCustomProgressLang()
        {
            InitializeComponent();
            SendMessage(textBoxLangId.Handle, EM_SETCUEBANNER, 1, "quest_extract_animal");
            SendMessage(textBoxLangValue.Handle, EM_SETCUEBANNER, 1, "Animal Extracted [%d/%d]");
        }

        private void buttonCreateEntry_Click(object sender, EventArgs e)
        {
            string[] langEntry = {textBoxLangValue.Text, textBoxLangId.Text};
            File.AppendAllLines("UpdateNotifsList.txt", langEntry);
            Close();
        }
    }
}
