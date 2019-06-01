using SOC.Classes.QuestBuild;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SOC.UI
{
    public partial class formCustomProgressLang : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
        public formCustomProgressLang()
        {
            InitializeComponent();
            SendMessage(textBoxLangId.Handle, 0x1501, 1, "quest_extract_animal");
            SendMessage(textBoxLangValue.Handle, 0x1501, 1, "Animal Extracted");
        }

        private void buttonCreateEntry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLangId.Text) || string.IsNullOrEmpty(textBoxLangValue.Text))
                return;
            UpdateNotifsManager.addNotification(textBoxLangId.Text, textBoxLangValue.Text);
            MessageBox.Show(string.Format("\"{0}\" added to UpdateNotifsList.txt", textBoxLangValue.Text), "Entry Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
