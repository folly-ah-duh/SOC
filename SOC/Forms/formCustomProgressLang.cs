using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SOC.UI
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
            if (string.IsNullOrEmpty(textBoxLangId.Text) || string.IsNullOrEmpty(textBoxLangValue.Text))
                return;
            string[] langEntry = {textBoxLangValue.Text, textBoxLangId.Text};
            File.AppendAllLines(Setup.NotifsListPath, langEntry);
            MessageBox.Show("Lang Entry added to UpdateNotifsList.txt", "Entry Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void textBoxLangId_Leave(object sender, EventArgs e)
        {
            string invalidchars = "[\\/\\?\\\\\\|\\*\\:\\\"\\<\\> ]";
            string replacement = "_";
            Regex fileNameFixer = new Regex(invalidchars);
            textBoxLangId.Text = fileNameFixer.Replace(textBoxLangId.Text, replacement);
        }
    }
}
