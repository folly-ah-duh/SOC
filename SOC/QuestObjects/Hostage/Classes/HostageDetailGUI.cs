using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOC.QuestObjects.Hostage
{
    class HostageDetailGUI
    {
        UserControl displayControl;

        HostagePanel hostagePanel = new HostagePanel();

        List<HostageBox> hostageBoxes = new List<HostageBox>();

        public HostageDetailGUI(UserControl display)
        {
            displayControl = display;
            display.Controls.Add(hostagePanel);
        }

        public void ShowPanel(int x)
        {
            hostagePanel.Visible = true;
            hostagePanel.Left = x;
        }

        public void HidePanel()
        {
            hostagePanel.Visible = false;
        }

        public void AddHostageBoxes(List<Hostage> hostages)
        {
            foreach (Hostage h in hostages)
            {
                HostageBox hBox = new HostageBox(h);
                hBox.BuildObject();
                hostagePanel.Controls.Add(hBox.getGroupBoxMain());
                hostageBoxes.Add(hBox);
            }
            hostagePanel.comboBox_Body.SelectedIndexChanged += OnBodyIndexChanged;
            RefreshHostageLanguage();
        }

        private void OnBodyIndexChanged(object sender, EventArgs e)
        {
            RefreshHostageLanguage();
        }

        public void ClearAllHostageBoxes()
        {
            foreach (HostageBox hbox in hostageBoxes)
            {
                hostagePanel.Controls.Remove(hbox.getGroupBoxMain());
            }
            hostageBoxes.Clear();
        }

        private void RefreshHostageLanguage()
        {
            if (hostagePanel.comboBox_Body.Text.ToUpper().Contains("FEMALE"))
            {

                foreach (HostageBox hostageDetail in hostageBoxes)
                {
                    hostageDetail.h_comboBox_lang.Items.Clear();
                    hostageDetail.h_comboBox_lang.Items.Add("english");
                    hostageDetail.h_comboBox_lang.SelectedIndex = 0;
                }
            }
            else
            {
                foreach (HostageBox hostageDetail in hostageBoxes)
                {
                    int languageindex = hostageDetail.h_comboBox_lang.SelectedIndex;
                    hostageDetail.h_comboBox_lang.Items.Clear();
                    hostageDetail.h_comboBox_lang.Items.AddRange(new string[] { "english", "russian", "pashto", "kikongo", "afrikaans" });
                    hostageDetail.h_comboBox_lang.SelectedIndex = languageindex;
                }
            }

        }

        public List<Hostage> GetHostageList()
        {
            List<Hostage> hostages = new List<Hostage>();
            for (int i = 0; i < hostageBoxes.Count; i++)
            {
                hostages.Add(new Hostage(hostageBoxes[i], i));
            }
            return hostages;
        }

        public HostageMetadata GetHostageMetaData()
        {
            return new HostageMetadata(hostagePanel);
        }
    }
}
