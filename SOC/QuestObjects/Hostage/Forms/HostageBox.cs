using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.Forms;
using System;
using System.Windows.Forms;

namespace SOC.QuestObjects.Hostage
{
    public class HostageBox : QuestBox
    {
        Hostage hostage;
        int hostageBodyIndex;

        public GroupBox h_groupBox_main;
        public Label h_label_rot;
        public Label h_label_coord;
        public Label h_label_skill;
        public Label h_label_staff;
        public Label h_label_lang;
        public Label h_label_untied;
        public Label h_label_scared;
        public Label h_label_injured;
        public TextBox h_textBox_zcoord;
        public TextBox h_textBox_ycoord;
        public CheckBox h_checkBox_target;
        public TextBox h_textBox_rot;
        public TextBox h_textBox_xcoord;
        public Label h_label_target;
        public ComboBox h_comboBox_skill;
        public ComboBox h_comboBox_staff;
        public ComboBox h_comboBox_lang;
        public ComboBox h_comboBox_scared;
        public CheckBox h_checkBox_injured;
        public CheckBox h_checkBox_untied;

        public HostageBox(Hostage h) : base(h)
        {
            hostage = h;
        }

        public override void SetObject(QuestBox detail)
        {
            HostageBox hostageDetail = (HostageBox)detail;
            h_checkBox_injured.Text = hostageDetail.h_checkBox_injured.Text;
            h_checkBox_target.Text = hostageDetail.h_checkBox_target.Text;
            h_checkBox_untied.Text = hostageDetail.h_checkBox_untied.Text;
            h_comboBox_lang.Text = hostageDetail.h_comboBox_lang.Text;
            h_comboBox_scared.Text = hostageDetail.h_comboBox_scared.Text;
            h_comboBox_skill.Text = hostageDetail.h_comboBox_skill.Text;
            h_comboBox_staff.Text = hostageDetail.h_comboBox_staff.Text;
        }

        public override void BuildObject()
        {
            //width -= 6;
            //int comboboxWidth = width - 100;
            this.h_groupBox_main = new System.Windows.Forms.GroupBox();
            this.h_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.h_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.h_checkBox_target = new System.Windows.Forms.CheckBox();
            this.h_textBox_rot = new System.Windows.Forms.TextBox();
            this.h_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.h_label_target = new System.Windows.Forms.Label();
            this.h_label_rot = new System.Windows.Forms.Label();
            this.h_label_coord = new System.Windows.Forms.Label();
            this.h_comboBox_skill = new System.Windows.Forms.ComboBox();
            this.h_comboBox_staff = new System.Windows.Forms.ComboBox();
            this.h_comboBox_lang = new System.Windows.Forms.ComboBox();
            this.h_label_skill = new System.Windows.Forms.Label();
            this.h_label_staff = new System.Windows.Forms.Label();
            this.h_label_lang = new System.Windows.Forms.Label();
            this.h_comboBox_scared = new System.Windows.Forms.ComboBox();
            this.h_checkBox_injured = new System.Windows.Forms.CheckBox();
            this.h_checkBox_untied = new System.Windows.Forms.CheckBox();
            this.h_label_untied = new System.Windows.Forms.Label();
            this.h_label_scared = new System.Windows.Forms.Label();
            this.h_label_injured = new System.Windows.Forms.Label();
            this.h_groupBox_main.SuspendLayout();
            // 
            // h_groupBox_main
            // 
            this.h_groupBox_main.Anchor = ((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right);
            this.h_groupBox_main.Controls.Add(this.h_textBox_zcoord);
            this.h_groupBox_main.Controls.Add(this.h_textBox_ycoord);
            this.h_groupBox_main.Controls.Add(this.h_checkBox_target);
            this.h_groupBox_main.Controls.Add(this.h_textBox_rot);
            this.h_groupBox_main.Controls.Add(this.h_textBox_xcoord);
            this.h_groupBox_main.Controls.Add(this.h_label_target);
            this.h_groupBox_main.Controls.Add(this.h_label_rot);
            this.h_groupBox_main.Controls.Add(this.h_label_coord);

            this.h_groupBox_main.Controls.Add(this.h_comboBox_scared);
            this.h_groupBox_main.Controls.Add(this.h_checkBox_injured);
            this.h_groupBox_main.Controls.Add(this.h_checkBox_untied);
            this.h_groupBox_main.Controls.Add(this.h_label_untied);
            this.h_groupBox_main.Controls.Add(this.h_label_scared);
            this.h_groupBox_main.Controls.Add(this.h_label_injured);

            this.h_groupBox_main.Controls.Add(this.h_comboBox_skill);
            this.h_groupBox_main.Controls.Add(this.h_comboBox_staff);
            this.h_groupBox_main.Controls.Add(this.h_comboBox_lang);
            this.h_groupBox_main.Controls.Add(this.h_label_skill);
            this.h_groupBox_main.Controls.Add(this.h_label_staff);
            this.h_groupBox_main.Controls.Add(this.h_label_lang);

            this.h_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.h_groupBox_main.Location = new System.Drawing.Point(3, 69 + (253 * hostage.ID));
            this.h_groupBox_main.Name = "h_groupBox_main";
            this.h_groupBox_main.Height = 236;
            this.h_groupBox_main.TabStop = false;
            this.h_groupBox_main.TabIndex = 1;
            this.h_groupBox_main.Text = "Hostage_" + hostage.ID;
            this.h_groupBox_main.Click += new System.EventHandler(FocusGroupBox);
            // 
            // h_textBox_coord
            // 
            this.h_textBox_xcoord.Location = new System.Drawing.Point(84, 14);
            this.h_textBox_xcoord.Name = "h_textBox_xcoord";
            this.h_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.h_textBox_xcoord.TabIndex = 2;
            this.h_textBox_xcoord.Text = hostage.position.coords.xCoord;

            this.h_textBox_ycoord.Location = new System.Drawing.Point(139, 14);
            this.h_textBox_ycoord.Name = "h_textBox_ycoord";
            this.h_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.h_textBox_ycoord.TabIndex = 3;
            this.h_textBox_ycoord.Text = hostage.position.coords.yCoord;

            this.h_textBox_zcoord.Location = new System.Drawing.Point(193, 14);
            this.h_textBox_zcoord.Name = "h_textBox_zcoord";
            this.h_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.h_textBox_zcoord.TabIndex = 4;
            this.h_textBox_zcoord.Text = hostage.position.coords.zCoord;

            this.h_label_coord.AutoSize = true;
            this.h_label_coord.Location = new System.Drawing.Point(4, 17);
            this.h_label_coord.Name = "h_label_coord";
            this.h_label_coord.Size = new System.Drawing.Size(66, 13);
            this.h_label_coord.Text = "Coordinates:";
            // 
            // h_checkBox_target
            // 
            this.h_checkBox_target.Location = new System.Drawing.Point(84, 66);
            this.h_checkBox_target.Name = "h_checkBox_target";
            this.h_checkBox_target.Size = new System.Drawing.Size(17, 18);
            this.h_checkBox_target.UseVisualStyleBackColor = true;
            h_checkBox_target.Checked = hostage.isTarget;
            this.h_label_target.AutoSize = true;
            this.h_label_target.Location = new System.Drawing.Point(18, 67);
            this.h_label_target.Name = "h_label_target";
            this.h_label_target.Size = new System.Drawing.Size(52, 13);
            this.h_label_target.Text = "Is Target:";
            // 
            // h_textBox_rot
            // 
            this.h_textBox_rot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.h_textBox_rot.Location = new System.Drawing.Point(84, 39);
            this.h_textBox_rot.Name = "h_textBox_rot";
            this.h_textBox_rot.Height = 21;
            this.h_textBox_rot.TabIndex = 5;
            this.h_textBox_rot.Text = hostage.position.rotation.GetDegreeRotY();
            this.h_label_rot.AutoSize = true;
            this.h_label_rot.Location = new System.Drawing.Point(20, 42);
            this.h_label_rot.Name = "h_label_rot";
            this.h_label_rot.Size = new System.Drawing.Size(50, 13);
            this.h_label_rot.Text = "Rotation:";
            // 
            // scared
            // 
            this.h_comboBox_scared.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.h_comboBox_scared.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.h_comboBox_scared.FormattingEnabled = true;
            this.h_comboBox_scared.Location = new System.Drawing.Point(84, 121);
            this.h_comboBox_scared.Items.AddRange(new object[] {
            "NORMAL", "ALWAYS", "NEVER"});
            this.h_comboBox_scared.Name = "h_comboBox_scared";
            this.h_comboBox_scared.Height = 21;
            this.h_comboBox_scared.TabIndex = 7;
            this.h_comboBox_scared.Text = hostage.scared;
            h_comboBox_scared.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            this.h_label_scared.AutoSize = true;
            this.h_label_scared.Location = new System.Drawing.Point(26, 124);
            this.h_label_scared.Name = "h_label_scared";
            this.h_label_scared.Size = new System.Drawing.Size(44, 13);
            this.h_label_scared.Text = "Scared:";
            // 
            // h_checkBox_injured
            // 
            this.h_checkBox_injured.Location = new System.Drawing.Point(165, 94);
            this.h_checkBox_injured.Name = "h_checkBox_injured";
            this.h_checkBox_injured.Size = new System.Drawing.Size(17, 18);
            this.h_checkBox_injured.UseVisualStyleBackColor = true;
            h_checkBox_injured.Checked = hostage.isInjured;
            this.h_label_injured.AutoSize = true;
            this.h_label_injured.Location = new System.Drawing.Point(117, 96);
            this.h_label_injured.Name = "h_label_injured";
            this.h_label_injured.Size = new System.Drawing.Size(42, 13);
            this.h_label_injured.Text = "Injured:";
            // 
            // h_checkBox_untied
            // 
            this.h_checkBox_untied.Location = new System.Drawing.Point(84, 94);
            this.h_checkBox_untied.Name = "h_checkBox_untied";
            this.h_checkBox_untied.Size = new System.Drawing.Size(17, 18);
            this.h_checkBox_untied.UseVisualStyleBackColor = true;
            h_checkBox_untied.Checked = hostage.isUntied;
            this.h_label_untied.AutoSize = true;
            this.h_label_untied.Location = new System.Drawing.Point(29, 96);
            this.h_label_untied.Name = "h_label_untied";
            this.h_label_untied.Size = new System.Drawing.Size(41, 13);
            this.h_label_untied.Text = "Untied:";
            // 
            // lang
            // 
            this.h_comboBox_lang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.h_comboBox_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; //genderDependant
            this.h_comboBox_lang.FormattingEnabled = true;
            this.h_comboBox_lang.Location = new System.Drawing.Point(84, 146);
            if (NPCBodyInfo.BodyInfoArray[hostageBodyIndex].Name.Contains("FEMALE"))
                this.h_comboBox_lang.Items.AddRange(new object[] { "english", });
            else
                this.h_comboBox_lang.Items.AddRange(new object[] { "english", "russian", "pashto", "kikongo", "afrikaans" });
            this.h_comboBox_lang.Name = "h_comboBox_lang";
            this.h_comboBox_lang.Height = 21;
            this.h_comboBox_lang.TabIndex = 9;
            h_comboBox_lang.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            h_comboBox_lang.Text = hostage.language;
            this.h_label_lang.AutoSize = true;
            this.h_label_lang.Location = new System.Drawing.Point(12, 149);
            this.h_label_lang.Name = "h_label_lang";
            this.h_label_lang.Size = new System.Drawing.Size(58, 13);
            this.h_label_lang.Text = "Language:";
            // 
            // h_comboBox_staff
            // 
            this.h_comboBox_staff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.h_comboBox_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.h_comboBox_staff.FormattingEnabled = true;
            this.h_comboBox_staff.Location = new System.Drawing.Point(84, 171);
            this.h_comboBox_staff.Items.AddRange(NPCMtbsInfo.Staff_Type_ID);
            this.h_comboBox_staff.Name = "h_comboBox_staff";
            this.h_comboBox_staff.Height = 21;
            this.h_comboBox_staff.TabIndex = 10;
            h_comboBox_staff.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            h_comboBox_staff.Text = hostage.staffType;
            this.h_label_staff.AutoSize = true;
            this.h_label_staff.Location = new System.Drawing.Point(11, 174);
            this.h_label_staff.Name = "h_label_staff";
            this.h_label_staff.Text = "Staff Type:";
            this.h_label_staff.Size = new System.Drawing.Size(59, 13);
            // 
            // h_comboBox_skill
            // 
            this.h_comboBox_skill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.h_comboBox_skill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.h_comboBox_skill.FormattingEnabled = true;
            this.h_comboBox_skill.Location = new System.Drawing.Point(84, 196);
            this.h_comboBox_skill.Items.AddRange(NPCMtbsInfo.skills);
            this.h_comboBox_skill.Name = "h_comboBox_skill";
            this.h_comboBox_skill.Height = 21;
            this.h_comboBox_skill.TabIndex = 11;
            this.h_comboBox_skill.Text = hostage.skill;
            h_comboBox_skill.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);

            this.h_label_skill.AutoSize = true;
            this.h_label_skill.Location = new System.Drawing.Point(41, 199);
            this.h_label_skill.Name = "h_label_skill";
            this.h_label_skill.Size = new System.Drawing.Size(29, 13);
            this.h_label_skill.Text = "Skill:";

            this.h_groupBox_main.ResumeLayout(false);
            this.h_groupBox_main.PerformLayout();
        }

        public override GroupBox getGroupBoxMain()
        {
            return h_groupBox_main;
        }

        public void SetPosition(Position pos)
        {
            h_textBox_xcoord.Text = pos.coords.xCoord;
            h_textBox_ycoord.Text = pos.coords.yCoord;
            h_textBox_zcoord.Text = pos.coords.zCoord;
            h_textBox_rot.Text = pos.rotation.GetDegreeRotY();
        }

        public Hostage GetHostage()
        {
            return new Hostage(this, base.getIndex());
        }
    }
}
