using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using SOC.Forms.Pages;
using SOC.Forms;

namespace SOC.QuestObjects.Hostage
{
    class HostageVisualizer : DetailVisualizer
    {
        public HostageVisualizer(LocationalDataStub hostageStub, HostagePanel hostagePanel) : base(hostageStub, hostagePanel)
        {
            hostagePanel.comboBox_Body.SelectedIndexChanged += OnBodyIndexChanged;
        }

        public override void DrawMetadata(Metadata meta)
        {
            HostagePanel hostagePanel = (HostagePanel)detailPanel;
            HostageMetadata hostageMeta = (HostageMetadata)meta;
            hostagePanel.comboBox_hosObjType.Text = hostageMeta.hostageObjectiveType;
            hostagePanel.comboBox_Body.Text = hostageMeta.hostageBodyName;
            hostagePanel.h_checkBox_intrgt.Checked = hostageMeta.canInterrogate;
        }

        public override QuestBox NewBox(QuestObject qObject)
        {
            throw new NotImplementedException();
        }

        public override Detail NewDetail(List<QuestObject> qObjects, Metadata meta)
        {
            throw new NotImplementedException();
        }

        public override Metadata NewMetadata(UserControl detailPanel)
        {
            throw new NotImplementedException();
        }

        public override QuestObject NewObject(Position objectPosition, int objectID)
        {
            throw new NotImplementedException();
        }

        private void OnBodyIndexChanged(object sender, EventArgs e)
        {
            RefreshHostageLanguage();
        }

        private void RefreshHostageLanguage()
        {
            HostagePanel hostagePanel = (HostagePanel)detailPanel;
            if (hostagePanel.comboBox_Body.Text.ToUpper().Contains("FEMALE"))
            {

                foreach (HostageBox hBox in objectBoxes)
                {
                    hBox.h_comboBox_lang.Items.Clear();
                    hBox.h_comboBox_lang.Items.Add("english");
                    hBox.h_comboBox_lang.SelectedIndex = 0;
                }
            }
            else
            {
                foreach (HostageBox hostageDetail in objectBoxes)
                {
                    int languageindex = hostageDetail.h_comboBox_lang.SelectedIndex;
                    hostageDetail.h_comboBox_lang.Items.Clear();
                    hostageDetail.h_comboBox_lang.Items.AddRange(new string[] { "english", "russian", "pashto", "kikongo", "afrikaans" });
                    hostageDetail.h_comboBox_lang.SelectedIndex = languageindex;
                }
            }

        }
    }
}
