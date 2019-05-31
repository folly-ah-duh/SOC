using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.Forms;
using SOC.QuestObjects.Common;
using SOC.UI;

namespace SOC.QuestObjects.Hostage
{
    public partial class HostageBox : QuestBox // Note: inherit from UserControl to show box in designer
    {
        public int hostageID;

        public HostageBox(Hostage h, HostageMetadata meta)
        {
            InitializeComponent();
            hostageID = h.ID;

            h_textBox_xcoord.Text = h.position.coords.xCoord;
            h_textBox_ycoord.Text = h.position.coords.yCoord;
            h_textBox_zcoord.Text = h.position.coords.zCoord;
            h_textBox_rot.Text = h.position.rotation.GetDegreeRotY();

            h_checkBox_target.Checked = h.isTarget;
            h_checkBox_untied.Checked = h.isUntied;
            h_checkBox_injured.Checked = h.isInjured;

            h_comboBox_scared.Items.AddRange(new string[] {
                "NORMAL", "ALWAYS", "NEVER"
            });
            h_comboBox_scared.Text = h.scared;

            h_comboBox_lang.Text = h.language; // Note: h_combobox_lang has the male languages prelisted in the designer
            RefreshLanguage(meta.hostageBodyName);

            h_comboBox_staff.Items.AddRange(NPCMtbsInfo.Staff_Type_ID);
            h_comboBox_staff.Text = h.staffType;

            h_comboBox_skill.Items.AddRange(NPCMtbsInfo.skills);
            h_comboBox_skill.Text = h.skill;
        }

        public override QuestObject getQuestObject()
        {
            return new Hostage(this);
        }

        public void RefreshLanguage(string body) 
        {
            if (body.ToUpper().Contains("FEMALE"))
            {
                h_comboBox_lang.Items.Clear();
                h_comboBox_lang.Items.Add("english");
                h_comboBox_lang.SelectedIndex = 0;
            }
            else
            {
                int languageindex = h_comboBox_lang.SelectedIndex; 
                h_comboBox_lang.Items.Clear();
                h_comboBox_lang.Items.AddRange(new string[] { "english", "russian", "pashto", "kikongo", "afrikaans" });
                h_comboBox_lang.SelectedIndex = languageindex;

            }
        }
    }
}
