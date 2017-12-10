using SOC.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.UI
{
    public abstract class Detail
    {
        Coordinates detailCoords;
        int detailNum;

        public Detail(Coordinates coord, int num)
        {
            detailCoords = coord;
            detailNum = num;
        }

        public int getIndex()
        {
            return detailNum;
        }

        public Coordinates getCoords()
        {
            return detailCoords;
        }

        public void FocusGroupBox(object sender, EventArgs e)
        {
            getGroupBoxMain().Focus();
        }

        public abstract GroupBox getGroupBoxMain();

        public abstract void SetDetail(Detail detail);

        public abstract void BuildDetail(int width);


    }

    public class HostageDetail : Detail
    {
        Coordinates hostageCoords;
        int hostageNum;

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

        public HostageDetail(Coordinates coord, int num) : base (coord, num)
        {
            hostageCoords = coord;
            hostageNum = num;
        }

        public override void SetDetail(Detail detail)
        {
            HostageDetail hostageDetail = (HostageDetail)detail;
            h_checkBox_injured.Text = hostageDetail.h_checkBox_injured.Text;
            h_checkBox_target.Text = hostageDetail.h_checkBox_target.Text;
            h_checkBox_untied.Text = hostageDetail.h_checkBox_untied.Text;
            h_comboBox_lang.Text = hostageDetail.h_comboBox_lang.Text;
            h_comboBox_scared.Text = hostageDetail.h_comboBox_scared.Text;
            h_comboBox_skill.Text = hostageDetail.h_comboBox_skill.Text;
            h_comboBox_staff.Text = hostageDetail.h_comboBox_staff.Text;
        }

        public override void BuildDetail(int width)
        {
            width -= 15;
            int comboboxWidth = width - 100;
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
            this.h_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.h_groupBox_main.AutoSize = true;
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
            this.h_groupBox_main.Location = new System.Drawing.Point(3, 55 + (253 * hostageNum));
            this.h_groupBox_main.Name = "h_groupBox_main";
            this.h_groupBox_main.Size = new System.Drawing.Size(width, 236);
            this.h_groupBox_main.TabStop = false;
            this.h_groupBox_main.TabIndex = 1;
            this.h_groupBox_main.Text = "Hostage_" + hostageNum;
            this.h_groupBox_main.Click += new System.EventHandler(FocusGroupBox);
            // 
            // h_textBox_coord
            // 
            this.h_textBox_xcoord.Location = new System.Drawing.Point(84, 14);
            this.h_textBox_xcoord.Name = "h_textBox_xcoord";
            this.h_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.h_textBox_xcoord.TabIndex = 2;
            this.h_textBox_xcoord.Text = hostageCoords.xCoord;
            h_textBox_xcoord.Leave += new EventHandler(onXcoordChange);

            this.h_textBox_ycoord.Location = new System.Drawing.Point(139, 14);
            this.h_textBox_ycoord.Name = "h_textBox_ycoord";
            this.h_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.h_textBox_ycoord.TabIndex = 3;
            this.h_textBox_ycoord.Text = hostageCoords.yCoord;
            h_textBox_ycoord.Leave += new EventHandler(onYcoordChange);

            this.h_textBox_zcoord.Location = new System.Drawing.Point(193, 14);
            this.h_textBox_zcoord.Name = "h_textBox_zcoord";
            this.h_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.h_textBox_zcoord.TabIndex = 4;
            this.h_textBox_zcoord.Text = hostageCoords.zCoord;
            h_textBox_zcoord.Leave += new EventHandler(onZcoordChange);

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
            this.h_textBox_rot.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.h_textBox_rot.TabIndex = 5;
            this.h_textBox_rot.Text = hostageCoords.roty;
            h_textBox_rot.Leave += new EventHandler(onYRotChange);
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
            this.h_comboBox_scared.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.h_comboBox_scared.TabIndex = 7;
            this.h_comboBox_scared.Text = "NORMAL";
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
            this.h_comboBox_lang.Items.AddRange(new object[] { "english", "russian", "pashto", "kikongo", "afrikaans" });
            this.h_comboBox_lang.Name = "h_comboBox_lang";
            this.h_comboBox_lang.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.h_comboBox_lang.TabIndex = 9;
            h_comboBox_lang.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
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
            this.h_comboBox_staff.Items.AddRange(Staff_Type_ID);
            this.h_comboBox_staff.Name = "h_comboBox_staff";
            this.h_comboBox_staff.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.h_comboBox_staff.TabIndex = 10;
            this.h_comboBox_staff.Text = "NONE";
            h_comboBox_staff.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            this.h_label_staff.AutoSize = true;
            this.h_label_staff.Location = new System.Drawing.Point(11, 174);
            this.h_label_staff.Name = "h_label_staff";
            this.h_label_staff.Size = new System.Drawing.Size(59, 13);
            this.h_label_staff.Text = "Staff Type:";
            // 
            // h_comboBox_skill
            // 
            this.h_comboBox_skill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.h_comboBox_skill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.h_comboBox_skill.FormattingEnabled = true;
            this.h_comboBox_skill.Location = new System.Drawing.Point(84, 196);
            this.h_comboBox_skill.Items.AddRange(skills);
            this.h_comboBox_skill.Name = "h_comboBox_skill";
            this.h_comboBox_skill.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.h_comboBox_skill.TabIndex = 11;
            this.h_comboBox_skill.Text = "NONE";
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

        public void onXcoordChange(object sender, EventArgs e)
        {
            hostageCoords.xCoord = h_textBox_xcoord.Text;
        }

        public void onYcoordChange(object sender, EventArgs e)
        {
            hostageCoords.yCoord = h_textBox_ycoord.Text;
        }

        public void onZcoordChange(object sender, EventArgs e)
        {
            hostageCoords.zCoord = h_textBox_zcoord.Text;
        }

        public void onYRotChange(object sender, EventArgs e)
        {
            hostageCoords.roty = h_textBox_rot.Text;
        }

    }
    public class VehicleDetail : Detail
    {
        Coordinates vehicleCoords;
        int VehicleNum;

        public GroupBox v_groupBox_main;
        public TextBox v_textBox_zcoord;
        public TextBox v_textBox_ycoord;
        public CheckBox v_checkBox_target;
        public TextBox v_textBox_rot;
        public TextBox v_textBox_xcoord;
        public Label v_label_target;
        public Label v_label_rot;
        public Label v_label_coord;
        public ComboBox v_comboBox_class;
        public ComboBox v_comboBox_vehicle;
        public Label v_label_class;
        public Label v_label_vehicle;

        public VehicleDetail(Coordinates coord, int num) : base(coord, num)
        {
            vehicleCoords = coord;
            VehicleNum = num;
        }

        public override void SetDetail(Detail detail)
        {
            VehicleDetail vehicleDetail = (VehicleDetail)detail;
            v_checkBox_target.Checked = vehicleDetail.v_checkBox_target.Checked;
            v_comboBox_class.Text = vehicleDetail.v_comboBox_class.Text;
            v_comboBox_vehicle.Text = vehicleDetail.v_comboBox_vehicle.Text;
        }

        public override void BuildDetail(int width)
        {
            width -= 15;
            int comboboxWidth = width - 96;
            this.v_groupBox_main = new System.Windows.Forms.GroupBox();
            this.v_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.v_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.v_checkBox_target = new System.Windows.Forms.CheckBox();
            this.v_textBox_rot = new System.Windows.Forms.TextBox();
            this.v_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.v_label_target = new System.Windows.Forms.Label();
            this.v_label_rot = new System.Windows.Forms.Label();
            this.v_label_coord = new System.Windows.Forms.Label();
            this.v_comboBox_class = new System.Windows.Forms.ComboBox();
            this.v_comboBox_vehicle = new System.Windows.Forms.ComboBox();
            this.v_label_class = new System.Windows.Forms.Label();
            this.v_label_vehicle = new System.Windows.Forms.Label();
            this.v_groupBox_main.SuspendLayout();
            // 
            // v_groupBox_main
            // 
            this.v_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_groupBox_main.AutoSize = true;
            this.v_groupBox_main.Controls.Add(this.v_textBox_zcoord);
            this.v_groupBox_main.Controls.Add(this.v_textBox_ycoord);
            this.v_groupBox_main.Controls.Add(this.v_checkBox_target);
            this.v_groupBox_main.Controls.Add(this.v_textBox_rot);
            this.v_groupBox_main.Controls.Add(this.v_textBox_xcoord);
            this.v_groupBox_main.Controls.Add(this.v_label_target);
            this.v_groupBox_main.Controls.Add(this.v_label_rot);
            this.v_groupBox_main.Controls.Add(this.v_label_coord);
            this.v_groupBox_main.Controls.Add(this.v_comboBox_class);
            this.v_groupBox_main.Controls.Add(this.v_comboBox_vehicle);
            this.v_groupBox_main.Controls.Add(this.v_label_class);
            this.v_groupBox_main.Controls.Add(this.v_label_vehicle);
            this.v_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.v_groupBox_main.Location = new System.Drawing.Point(3, 4 + (170 * VehicleNum));
            this.v_groupBox_main.Name = "v_groupBox_main";
            this.v_groupBox_main.Size = new System.Drawing.Size(width, 140);
            this.v_groupBox_main.TabIndex = 1;
            this.v_groupBox_main.TabStop = false;
            this.v_groupBox_main.Text = "Vehicle_" + VehicleNum;
            this.v_groupBox_main.Click += new System.EventHandler(FocusGroupBox);

            // 
            // v_textBox_zcoord
            // 
            this.v_label_coord.AutoSize = true;
            this.v_label_coord.Location = new System.Drawing.Point(4, 17);
            this.v_label_coord.Name = "v_label_coord";
            this.v_label_coord.Size = new System.Drawing.Size(66, 13);
            this.v_label_coord.TabIndex = 6;
            this.v_label_coord.Text = "Coordinates:";

            this.v_textBox_xcoord.Location = new System.Drawing.Point(78, 14);
            this.v_textBox_xcoord.Name = "v_textBox_xcoord";
            this.v_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.v_textBox_xcoord.TabIndex = 2;
            this.v_textBox_xcoord.Text = vehicleCoords.xCoord;
            v_textBox_xcoord.Leave += new EventHandler(onXcoordChange);

            this.v_textBox_ycoord.Location = new System.Drawing.Point(133, 14);
            this.v_textBox_ycoord.Name = "v_textBox_ycoord";
            this.v_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.v_textBox_ycoord.TabIndex = 3;
            this.v_textBox_ycoord.Text = vehicleCoords.yCoord;
            v_textBox_ycoord.Leave += new EventHandler(onYcoordChange);

            this.v_textBox_zcoord.Location = new System.Drawing.Point(187, 14);
            this.v_textBox_zcoord.Name = "v_textBox_zcoord";
            this.v_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.v_textBox_zcoord.TabIndex = 4;
            this.v_textBox_zcoord.Text = vehicleCoords.zCoord;
            v_textBox_zcoord.Leave += new EventHandler(onZcoordChange);
            // 
            // v_checkBox_target
            // 
            this.v_checkBox_target.Location = new System.Drawing.Point(78, 66);
            this.v_checkBox_target.Name = "v_checkBox_target";
            this.v_checkBox_target.Size = new System.Drawing.Size(17, 18);
            this.v_checkBox_target.UseVisualStyleBackColor = true;

            this.v_label_target.AutoSize = true;
            this.v_label_target.Location = new System.Drawing.Point(18, 67);
            this.v_label_target.Name = "v_label_target";
            this.v_label_target.Size = new System.Drawing.Size(52, 13);
            this.v_label_target.TabIndex = 10;
            this.v_label_target.Text = "Is Target:";
            // 
            // v_textBox_rot
            // 
            this.v_textBox_rot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_textBox_rot.Location = new System.Drawing.Point(78, 39);
            this.v_textBox_rot.Name = "v_textBox_rot";
            this.v_textBox_rot.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.v_textBox_rot.TabIndex = 5;
            this.v_textBox_rot.Text = vehicleCoords.roty;
            v_textBox_rot.Leave += new EventHandler(onYRotChange);

            this.v_label_rot.AutoSize = true;
            this.v_label_rot.Location = new System.Drawing.Point(20, 42);
            this.v_label_rot.Name = "v_label_rot";
            this.v_label_rot.Size = new System.Drawing.Size(50, 13);
            this.v_label_rot.TabIndex = 7;
            this.v_label_rot.Text = "Rotation:";
            // 
            // v_comboBox_class
            // 
            this.v_comboBox_class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_comboBox_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_comboBox_class.FormattingEnabled = true;
            this.v_comboBox_class.Location = new System.Drawing.Point(78, 116);
            v_comboBox_class.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            this.v_comboBox_class.Items.AddRange(new object[] {
                "DEFAULT","DARK_GRAY","OXIDE_RED"
            });
            this.v_comboBox_class.Name = "v_comboBox_class";
            this.v_comboBox_class.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.v_comboBox_class.TabIndex = 8;
            this.v_comboBox_class.Text = "DEFAULT";
            this.v_label_class.AutoSize = true;
            this.v_label_class.Location = new System.Drawing.Point(35, 119);
            this.v_label_class.Name = "v_label_class";
            this.v_label_class.Size = new System.Drawing.Size(35, 13);
            this.v_label_class.Text = "Class:";
            // 
            // v_comboBox_vehicle
            // 
            this.v_comboBox_vehicle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_comboBox_vehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_comboBox_vehicle.FormattingEnabled = true;
            this.v_comboBox_vehicle.Location = new System.Drawing.Point(78, 91);
            this.v_comboBox_vehicle.Items.AddRange(new object[] {
                "TT77 NOSOROG","M84A MAGLOADER", "ZHUK BR-3", "ZHUK RS-ZO","STOUT IFV-SC","STOUT IFV-FS"
            });
            this.v_comboBox_vehicle.Name = "v_comboBox_vehicle";
            this.v_comboBox_vehicle.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.v_comboBox_vehicle.TabIndex = 7;
            v_comboBox_vehicle.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            this.v_comboBox_vehicle.Text = "TT77 NOSOROG";
            this.v_label_vehicle.AutoSize = true;
            this.v_label_vehicle.Location = new System.Drawing.Point(25, 94);
            this.v_label_vehicle.Name = "v_label_vehicle";
            this.v_label_vehicle.Size = new System.Drawing.Size(45, 13);
            this.v_label_vehicle.Text = "Vehicle:";



            this.v_groupBox_main.ResumeLayout(false);
            this.v_groupBox_main.PerformLayout();
        }

        public override GroupBox getGroupBoxMain()
        {
            return v_groupBox_main;
        }

        public void onXcoordChange(object sender, EventArgs e)
        {
            vehicleCoords.xCoord = v_textBox_xcoord.Text;
        }

        public void onYcoordChange(object sender, EventArgs e)
        {
            vehicleCoords.yCoord = v_textBox_ycoord.Text;
        }

        public void onZcoordChange(object sender, EventArgs e)
        {
            vehicleCoords.zCoord = v_textBox_zcoord.Text;
        }

        public void onYRotChange(object sender, EventArgs e)
        {
            vehicleCoords.roty = v_textBox_rot.Text;
        }
    }
    public class ItemDetail : Detail
    {
        Coordinates itemCoords;
        int itemNum;

        public GroupBox i_groupBox_main;
        public TextBox i_textBox_zcoord;
        public TextBox i_textBox_ycoord;
        public TextBox i_textBox_zrot;
        public TextBox i_textBox_yrot;
        public TextBox i_textBox_xrot;
        public TextBox i_textBox_wrot;
        public TextBox i_textBox_xcoord;
        public Label i_label_rot;
        public Label i_label_coord;
        public ComboBox i_comboBox_count;
        public CheckBox i_checkBox_boxed;
        public Label i_label_boxed;
        public ComboBox i_comboBox_item;
        public Label i_label_count;
        public Label i_label_item;

        public ItemDetail(Coordinates coord, int num) : base(coord, num)
        {
            itemCoords = coord;
            itemNum = num;
        }

        public override void SetDetail(Detail detail)
        {
            ItemDetail itemDetail = (ItemDetail)detail;
            i_comboBox_count.Text = itemDetail.i_comboBox_count.Text;
            i_label_boxed.Text = itemDetail.i_label_boxed.Text;
            i_comboBox_item.Text = itemDetail.i_comboBox_item.Text;

        }

        public override void BuildDetail(int width)
        {
            width -= 15;
            int comboboxWidth = width - 96;
            this.i_groupBox_main = new System.Windows.Forms.GroupBox();
            this.i_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.i_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.i_textBox_xrot = new System.Windows.Forms.TextBox();
            this.i_textBox_yrot = new System.Windows.Forms.TextBox();
            this.i_textBox_zrot = new System.Windows.Forms.TextBox();
            this.i_textBox_wrot = new System.Windows.Forms.TextBox();
            this.i_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.i_label_rot = new System.Windows.Forms.Label();
            this.i_label_coord = new System.Windows.Forms.Label();
            this.i_comboBox_count = new System.Windows.Forms.ComboBox();
            this.i_checkBox_boxed = new System.Windows.Forms.CheckBox();
            this.i_label_boxed = new System.Windows.Forms.Label();
            this.i_comboBox_item = new System.Windows.Forms.ComboBox();
            this.i_label_count = new System.Windows.Forms.Label();
            this.i_label_item = new System.Windows.Forms.Label();
            this.i_groupBox_main.SuspendLayout();
            // 
            // i_groupBox_main
            // 
            this.i_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_groupBox_main.AutoSize = true;
            this.i_groupBox_main.Controls.Add(this.i_textBox_zcoord);
            this.i_groupBox_main.Controls.Add(this.i_textBox_ycoord);
            this.i_groupBox_main.Controls.Add(this.i_textBox_xcoord);
            this.i_groupBox_main.Controls.Add(this.i_label_rot);
            this.i_groupBox_main.Controls.Add(this.i_textBox_xrot);
            this.i_groupBox_main.Controls.Add(this.i_textBox_yrot);
            this.i_groupBox_main.Controls.Add(this.i_textBox_zrot);
            this.i_groupBox_main.Controls.Add(this.i_textBox_wrot);
            this.i_groupBox_main.Controls.Add(this.i_label_coord);
            this.i_groupBox_main.Controls.Add(this.i_comboBox_count);
            this.i_groupBox_main.Controls.Add(this.i_checkBox_boxed);
            this.i_groupBox_main.Controls.Add(this.i_label_boxed);
            this.i_groupBox_main.Controls.Add(this.i_comboBox_item);
            this.i_groupBox_main.Controls.Add(this.i_label_count);
            this.i_groupBox_main.Controls.Add(this.i_label_item);

            this.i_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.i_groupBox_main.Location = new System.Drawing.Point(3, 3 + (171 * itemNum));
            this.i_groupBox_main.Name = "i_groupBox_main";
            this.i_groupBox_main.Size = new System.Drawing.Size(width, 150);
            this.i_groupBox_main.TabIndex = 1;
            this.i_groupBox_main.TabStop = false;
            this.i_groupBox_main.Text = "Item_" + itemNum;
            this.i_groupBox_main.Click += new System.EventHandler(FocusGroupBox);
            // 
            // i_textBox_zcoord
            // 
            this.i_label_coord.AutoSize = true;
            this.i_label_coord.Location = new System.Drawing.Point(4, 17);
            this.i_label_coord.Name = "i_label_coord";
            this.i_label_coord.Size = new System.Drawing.Size(66, 13);
            this.i_label_coord.TabIndex = 6;
            this.i_label_coord.Text = "Coordinates:";

            this.i_textBox_xcoord.Location = new System.Drawing.Point(78, 14);
            this.i_textBox_xcoord.Name = "i_textBox_xcoord";
            this.i_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.i_textBox_xcoord.TabIndex = 2;
            this.i_textBox_xcoord.Text = itemCoords.xCoord;
            i_textBox_xcoord.Leave += new EventHandler(onXcoordChange);

            this.i_textBox_ycoord.Location = new System.Drawing.Point(133, 14);
            this.i_textBox_ycoord.Name = "i_textBox_ycoord";
            this.i_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.i_textBox_ycoord.TabIndex = 3;
            this.i_textBox_ycoord.Text = itemCoords.yCoord;
            i_textBox_ycoord.Leave += new EventHandler(onYcoordChange);

            this.i_textBox_zcoord.Location = new System.Drawing.Point(187, 14);
            this.i_textBox_zcoord.Name = "i_textBox_zcoord";
            this.i_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.i_textBox_zcoord.TabIndex = 4;
            this.i_textBox_zcoord.Text = itemCoords.zCoord;
            i_textBox_zcoord.Leave += new EventHandler(onZcoordChange);

            //
            // rotation
            //
            this.i_label_rot.AutoSize = true;
            this.i_label_rot.Location = new System.Drawing.Point(20, 42);
            this.i_label_rot.Name = "i_label_rot";
            this.i_label_rot.Size = new System.Drawing.Size(50, 13);
            this.i_label_rot.TabIndex = 7;
            this.i_label_rot.Text = "Rotation:";

            this.i_textBox_xrot.Location = new System.Drawing.Point(78, 39);
            this.i_textBox_xrot.Name = "m_textBox_xrocoord";
            this.i_textBox_xrot.Size = new System.Drawing.Size(31, 20);
            this.i_textBox_xrot.TabIndex = 5;
            this.i_textBox_xrot.Text = "0";
            this.i_textBox_yrot.Location = new System.Drawing.Point(117, 39);
            this.i_textBox_yrot.Name = "m_textBox_yrocoord";
            this.i_textBox_yrot.Size = new System.Drawing.Size(31, 20);
            this.i_textBox_yrot.TabIndex = 6;
            this.i_textBox_yrot.Text = QuestComponents.Fox2Info.getQuaternionY(itemCoords.roty);
            this.i_textBox_zrot.Location = new System.Drawing.Point(157, 39);
            this.i_textBox_zrot.Name = "m_textBox_zrocoord";
            this.i_textBox_zrot.Size = new System.Drawing.Size(31, 20);
            this.i_textBox_zrot.TabIndex = 7;
            this.i_textBox_zrot.Text = "0";
            this.i_textBox_wrot.Location = new System.Drawing.Point(197, 39);
            this.i_textBox_wrot.Name = "m_textBox_wrocoord";
            this.i_textBox_wrot.Size = new System.Drawing.Size(31, 20);
            this.i_textBox_wrot.TabIndex = 8;
            this.i_textBox_wrot.Text = QuestComponents.Fox2Info.getQuaternionW(itemCoords.roty);
            // 
            // i_comboBox_count
            // 
            this.i_label_count.AutoSize = true;
            this.i_label_count.Location = new System.Drawing.Point(32, 97);
            this.i_label_count.Name = "i_label_count";
            this.i_label_count.Size = new System.Drawing.Size(38, 13);
            this.i_label_count.TabIndex = 7;
            this.i_label_count.Text = "Count:";

            this.i_comboBox_count.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_comboBox_count.FormattingEnabled = true;
            this.i_comboBox_count.Location = new System.Drawing.Point(78, 94);
            this.i_comboBox_count.Items.AddRange(new object[] {
                "1","4","8","12","16"
            });
            this.i_comboBox_count.Name = "i_comboBox_count";
            this.i_comboBox_count.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.i_comboBox_count.TabIndex = 9;
            this.i_comboBox_count.Text = i_comboBox_count.Items[0].ToString();
            i_comboBox_count.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            // 
            // i_checkBox_boxed
            // 
            this.i_label_boxed.AutoSize = true;
            this.i_label_boxed.Location = new System.Drawing.Point(30, 122);
            this.i_label_boxed.Name = "i_label_boxed";
            this.i_label_boxed.Size = new System.Drawing.Size(40, 13);
            this.i_label_boxed.TabIndex = 20;
            this.i_label_boxed.Text = "Boxed:";

            this.i_checkBox_boxed.Location = new System.Drawing.Point(78, 120);
            this.i_checkBox_boxed.Name = "i_checkBox_boxed";
            this.i_checkBox_boxed.Size = new System.Drawing.Size(17, 18);
            this.i_checkBox_boxed.UseVisualStyleBackColor = true;
            // 
            // i_comboBox_item
            // 
            this.i_label_item.AutoSize = true;
            this.i_label_item.Location = new System.Drawing.Point(40, 73);
            this.i_label_item.Name = "i_label_item";
            this.i_label_item.Size = new System.Drawing.Size(30, 13);
            this.i_label_item.TabIndex = 6;
            this.i_label_item.Text = "Item:";

            this.i_comboBox_item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_comboBox_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.i_comboBox_item.FormattingEnabled = true;
            this.i_comboBox_item.Location = new System.Drawing.Point(78, 68);
            this.i_comboBox_item.Items.AddRange(items);
            this.i_comboBox_item.Name = "i_comboBox_item";
            this.i_comboBox_item.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.i_comboBox_item.TabIndex = 8;
            i_comboBox_item.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            this.i_comboBox_item.Text = "EQP_SWP_Magazine";
            this.i_comboBox_item.SelectedIndexChanged += new System.EventHandler(this.i_comboBox_item_SelectedIndexChanged);
            this.i_groupBox_main.ResumeLayout(false);
            this.i_groupBox_main.PerformLayout();
        }

        private void i_comboBox_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.i_comboBox_item.Text.Contains("EQP_WP_"))
            {
                this.i_comboBox_count.Text = "0";
                this.i_comboBox_count.Enabled = false;
            }
            else
            {
                this.i_comboBox_count.Text = i_comboBox_count.Items[0].ToString();
                this.i_comboBox_count.Enabled = true;
            }
        }

        public override GroupBox getGroupBoxMain()
        {
            return i_groupBox_main;
        }

        public void onXcoordChange(object sender, EventArgs e)
        {
            itemCoords.xCoord = i_textBox_xcoord.Text;
        }

        public void onYcoordChange(object sender, EventArgs e)
        {
            itemCoords.yCoord = i_textBox_ycoord.Text;
        }

        public void onZcoordChange(object sender, EventArgs e)
        {
            itemCoords.zCoord = i_textBox_zcoord.Text;
        }
    }
    public class ModelDetail : Detail
    {
        Coordinates StMdCoords;
        int StMdNum;
        
        public string modelAssetsPath = AssetsBuilder.modelAssetsPath;
        public GroupBox m_groupBox_main;
        public TextBox m_textBox_zcoord;
        public TextBox m_textBox_ycoord;
        public TextBox m_textBox_xcoord;
        public Label m_label_preset;
        public TextBox m_textBox_zrot;
        public TextBox m_textBox_yrot;
        public TextBox m_textBox_xrot;
        public TextBox m_textBox_wrot;
        public ComboBox m_comboBox_preset;
        public Label m_label_rot;
        public Label m_label_coord;
        public Label m_label_GeomNotFound;

        public ModelDetail(Coordinates coord, int num) : base(coord, num)
        {
            StMdCoords = coord;
            StMdNum = num;
        }

        public override void SetDetail(Detail detail)
        {
            ModelDetail modelDetail = (ModelDetail)detail;
            m_comboBox_preset.Text = modelDetail.m_comboBox_preset.Text;
            
        }

        public override void BuildDetail(int width)
        {

            width -= 15;
            int comboboxWidth = width - 100;
            this.m_groupBox_main = new System.Windows.Forms.GroupBox();
            this.m_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.m_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.m_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.m_label_preset = new System.Windows.Forms.Label();
            this.m_textBox_xrot = new System.Windows.Forms.TextBox();
            this.m_textBox_yrot = new System.Windows.Forms.TextBox();
            this.m_textBox_zrot = new System.Windows.Forms.TextBox();
            this.m_textBox_wrot = new System.Windows.Forms.TextBox();
            this.m_comboBox_preset = new System.Windows.Forms.ComboBox();
            this.m_label_rot = new System.Windows.Forms.Label();
            this.m_label_coord = new System.Windows.Forms.Label();
            this.m_label_GeomNotFound = new System.Windows.Forms.Label();
            this.m_groupBox_main.SuspendLayout();

            // 
            // m_groupBox_main
            // 
            this.m_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_groupBox_main.AutoSize = true;
            this.m_groupBox_main.Controls.Add(this.m_textBox_zcoord);
            this.m_groupBox_main.Controls.Add(this.m_textBox_ycoord);
            this.m_groupBox_main.Controls.Add(this.m_textBox_xcoord);
            this.m_groupBox_main.Controls.Add(this.m_label_rot);
            this.m_groupBox_main.Controls.Add(this.m_label_coord);
            this.m_groupBox_main.Controls.Add(this.m_textBox_xrot);
            this.m_groupBox_main.Controls.Add(this.m_textBox_yrot);
            this.m_groupBox_main.Controls.Add(this.m_textBox_zrot);
            this.m_groupBox_main.Controls.Add(this.m_textBox_wrot);
            this.m_groupBox_main.Controls.Add(this.m_comboBox_preset);
            this.m_groupBox_main.Controls.Add(this.m_label_preset);
            this.m_groupBox_main.Controls.Add(this.m_label_GeomNotFound);
            this.m_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.m_groupBox_main.Location = new System.Drawing.Point(3, 3 + (StMdNum * 118));
            this.m_groupBox_main.Name = "m_groupBox_main";
            this.m_groupBox_main.Size = new System.Drawing.Size(width, 95);
            this.m_groupBox_main.TabIndex = 1;
            this.m_groupBox_main.TabStop = false;
            this.m_groupBox_main.Text = "Model_" + StMdNum;
            // 
            // m_textBox_zcoord
            // 
            this.m_textBox_zcoord.Location = new System.Drawing.Point(193, 14);
            this.m_textBox_zcoord.Name = "m_textBox_zcoord";
            this.m_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.m_textBox_zcoord.TabIndex = 4;
            this.m_textBox_zcoord.Text = StMdCoords.zCoord;
            m_textBox_zcoord.Leave += new EventHandler(onZcoordChange);
            // 
            // m_label_filename
            // 
            this.m_label_GeomNotFound.AutoSize = true;
            this.m_label_GeomNotFound.Location = new System.Drawing.Point(22, 94);
            this.m_label_GeomNotFound.Name = "m_label_filePath";
            this.m_label_GeomNotFound.Size = new System.Drawing.Size(54, 13);
            this.m_label_GeomNotFound.TabIndex = 6;
            this.m_label_GeomNotFound.ForeColor = System.Drawing.Color.Yellow;
            this.m_label_GeomNotFound.Text = "";
            // 
            // m_textBox_ycoord
            // 
            this.m_textBox_ycoord.Location = new System.Drawing.Point(139, 14);
            this.m_textBox_ycoord.Name = "m_textBox_ycoord";
            this.m_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.m_textBox_ycoord.TabIndex = 3;
            this.m_textBox_ycoord.Text = StMdCoords.yCoord;
            m_textBox_ycoord.Leave += new EventHandler(onYcoordChange);
            // 
            // m_textBox_rot
            // 
            //this.m_textBox_rot.FormattingEnabled = true;
            //this.m_textBox_rot.Location = new System.Drawing.Point(84, 39);
            //this.m_textBox_rot.Name = "m_textBox_rot";
            //this.m_textBox_rot.Size = new System.Drawing.Size(150, 21);
            //this.m_textBox_rot.TabIndex = 12;
            //this.m_textBox_rot.Items.AddRange(QuestComponents.rotation);
            // 
            // m_textBox_xcoord
            // 
            this.m_textBox_xcoord.Location = new System.Drawing.Point(84, 14);
            this.m_textBox_xcoord.Name = "m_textBox_xcoord";
            this.m_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.m_textBox_xcoord.TabIndex = 2;
            this.m_textBox_xcoord.Text = StMdCoords.xCoord;
            m_textBox_xcoord.Leave += new EventHandler(onXcoordChange);
            // 
            // m_label_rot
            // 
            this.m_label_rot.AutoSize = true;
            this.m_label_rot.Location = new System.Drawing.Point(20, 42);
            this.m_label_rot.Name = "m_label_rot";
            this.m_label_rot.Size = new System.Drawing.Size(50, 13);
            this.m_label_rot.TabIndex = 7;
            this.m_label_rot.Text = "Rotation: ";

            this.m_textBox_xrot.Location = new System.Drawing.Point(84, 39);
            this.m_textBox_xrot.Name = "m_textBox_xrocoord";
            this.m_textBox_xrot.Size = new System.Drawing.Size(31, 20);
            this.m_textBox_xrot.TabIndex = 5;
            this.m_textBox_xrot.Text = "0";
            this.m_textBox_yrot.Location = new System.Drawing.Point(123, 39);
            this.m_textBox_yrot.Name = "m_textBox_yrocoord";
            this.m_textBox_yrot.Size = new System.Drawing.Size(31, 20);
            this.m_textBox_yrot.TabIndex = 6;
            this.m_textBox_yrot.Text = QuestComponents.Fox2Info.getQuaternionY(StMdCoords.roty);
            this.m_textBox_zrot.Location = new System.Drawing.Point(163, 39);
            this.m_textBox_zrot.Name = "m_textBox_zrocoord";
            this.m_textBox_zrot.Size = new System.Drawing.Size(31, 20);
            this.m_textBox_zrot.TabIndex = 7;
            this.m_textBox_zrot.Text = "0";
            this.m_textBox_wrot.Location = new System.Drawing.Point(203, 39);
            this.m_textBox_wrot.Name = "m_textBox_wrocoord";
            this.m_textBox_wrot.Size = new System.Drawing.Size(31, 20);
            this.m_textBox_wrot.TabIndex = 8;
            this.m_textBox_wrot.Text = QuestComponents.Fox2Info.getQuaternionW(StMdCoords.roty);
            // 
            // m_label_coord
            // 
            this.m_label_coord.AutoSize = true;
            this.m_label_coord.Location = new System.Drawing.Point(4, 17);
            this.m_label_coord.Name = "m_label_coord";
            this.m_label_coord.Size = new System.Drawing.Size(66, 13);
            this.m_label_coord.TabIndex = 6;
            this.m_label_coord.Text = "Coordinates:";

            this.m_comboBox_preset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_comboBox_preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBox_preset.FormattingEnabled = true;
            this.m_comboBox_preset.Location = new System.Drawing.Point(84, 66);
            this.m_comboBox_preset.Items.AddRange(getPresetModelList());
            this.m_comboBox_preset.Name = "m_comboBox_preset";
            this.m_comboBox_preset.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.m_comboBox_preset.TabIndex = 7;
            this.m_comboBox_preset.SelectedIndexChanged += new System.EventHandler(this.m_comboBox_preset_selectedIndexChanged);
            this.m_comboBox_preset.SelectedIndex = 0;
            m_comboBox_preset.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);

            this.m_label_preset.AutoSize = true;
            this.m_label_preset.Location = new System.Drawing.Point(31, 69);
            this.m_label_preset.Name = "m_label_preset";
            this.m_label_preset.Size = new System.Drawing.Size(50, 13);
            this.m_label_preset.TabIndex = 6;
            this.m_label_preset.Text = "Model:";

            this.m_groupBox_main.ResumeLayout(false);
            this.m_groupBox_main.PerformLayout();

        }

        private string[] getPresetModelList()
        {
            
            string[] FileNames = Directory.GetFiles(modelAssetsPath, "*.fmdl");
            for (int i = 0; i < FileNames.Length; i++)
            {
                int filenameLength = FileNames[i].Substring(FileNames[i].LastIndexOf('\\') + 1).Length - 1;
                FileNames[i] = FileNames[i].Substring(FileNames[i].LastIndexOf('\\') + 1, filenameLength - 4);
            }
            return FileNames;
        }

        private bool hasGeom()
        {
            if (!string.IsNullOrEmpty(m_comboBox_preset.Text))
            {
                string[] geomNames = Directory.GetFiles(modelAssetsPath, "*.geom");
                for (int i = 0; i < geomNames.Length; i++)
                {
                    if (geomNames[i].Contains(m_comboBox_preset.Text + ".geom"))
                        return true;
                }
            }
            return false;
        }

        private void m_comboBox_preset_selectedIndexChanged(object sender, EventArgs e)
        {
            if (!hasGeom() && !string.IsNullOrEmpty(m_comboBox_preset.Text))
            {
                m_label_GeomNotFound.Visible = true;
                m_label_GeomNotFound.Text = "Geom File Not Found For " + m_comboBox_preset.Text;
            }
            else
                m_label_GeomNotFound.Visible = false;

        }

        public override GroupBox getGroupBoxMain()
        {
            return m_groupBox_main;
        }

        public void onXcoordChange(object sender, EventArgs e)
        {
            StMdCoords.xCoord = m_textBox_xcoord.Text;
        }

        public void onYcoordChange(object sender, EventArgs e)
        {
            StMdCoords.yCoord = m_textBox_ycoord.Text;
        }

        public void onZcoordChange(object sender, EventArgs e)
        {
            StMdCoords.zCoord = m_textBox_zcoord.Text;
        }
    }

    public class ActiveItemDetail : Detail
    {
        Coordinates activeItemCoords;
        int activeItemNum;

        public GroupBox ai_groupBox_main;
        public TextBox ai_textBox_zcoord;
        public TextBox ai_textBox_ycoord;
        public TextBox ai_textBox_xcoord;
        public Label ai_label_coord;
        public Label ai_label_Rot;
        public ComboBox ai_comboBox_activeitem;
        public Label ai_label_activeitem;
        public TextBox ai_textBox_wrot;
        public TextBox ai_textBox_zrot;
        public TextBox ai_textBox_yrot;
        public TextBox ai_textBox_xrot;

        public ActiveItemDetail(Coordinates coord, int num) : base(coord, num)
        {
            activeItemCoords = coord;
            activeItemNum = num;

        }
        
        public override void SetDetail(Detail detail)
        {
            ActiveItemDetail acItDet = (ActiveItemDetail)detail;
            ai_comboBox_activeitem.Text = acItDet.ai_comboBox_activeitem.Text;
        }

        public override void BuildDetail(int width)
        {
            width -= 15;
            int comboboxWidth = width - 100;
            this.ai_groupBox_main = new System.Windows.Forms.GroupBox();
            this.ai_label_coord = new System.Windows.Forms.Label();
            this.ai_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.ai_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.ai_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.ai_label_Rot = new System.Windows.Forms.Label();
            this.ai_textBox_xrot = new System.Windows.Forms.TextBox();
            this.ai_textBox_yrot = new System.Windows.Forms.TextBox();
            this.ai_textBox_zrot = new System.Windows.Forms.TextBox();
            this.ai_textBox_wrot = new System.Windows.Forms.TextBox();
            this.ai_label_activeitem = new System.Windows.Forms.Label();
            this.ai_comboBox_activeitem = new System.Windows.Forms.ComboBox();
            this.ai_groupBox_main.SuspendLayout();

            this.ai_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ai_groupBox_main.AutoSize = true;
            this.ai_groupBox_main.Controls.Add(this.ai_comboBox_activeitem);
            this.ai_groupBox_main.Controls.Add(this.ai_label_activeitem);
            this.ai_groupBox_main.Controls.Add(this.ai_textBox_wrot);
            this.ai_groupBox_main.Controls.Add(this.ai_textBox_zrot);
            this.ai_groupBox_main.Controls.Add(this.ai_textBox_yrot);
            this.ai_groupBox_main.Controls.Add(this.ai_textBox_xrot);
            this.ai_groupBox_main.Controls.Add(this.ai_label_Rot);
            this.ai_groupBox_main.Controls.Add(this.ai_textBox_zcoord);
            this.ai_groupBox_main.Controls.Add(this.ai_textBox_ycoord);
            this.ai_groupBox_main.Controls.Add(this.ai_textBox_xcoord);
            this.ai_groupBox_main.Controls.Add(this.ai_label_coord);
            this.ai_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.ai_groupBox_main.Location = new System.Drawing.Point(3, 3 + (activeItemNum * 118));
            this.ai_groupBox_main.Name = "ai_groupBox_main";
            this.ai_groupBox_main.Size = new System.Drawing.Size(width, 80);
            this.ai_groupBox_main.TabIndex = 0;
            this.ai_groupBox_main.TabStop = false;
            this.ai_groupBox_main.Text = "Active_Item_" + activeItemNum;
            this.ai_groupBox_main.Click += new System.EventHandler(FocusGroupBox);
            // 
            // ai_label_coord
            // 
            this.ai_label_coord.AutoSize = true;
            this.ai_label_coord.Location = new System.Drawing.Point(4, 17);
            this.ai_label_coord.Name = "ai_label_coord";
            this.ai_label_coord.Size = new System.Drawing.Size(66, 13);
            this.ai_label_coord.TabIndex = 0;
            this.ai_label_coord.Text = "Coordinates:";
            // 
            // ai_textBox_xcoord
            // 
            this.ai_textBox_xcoord.Location = new System.Drawing.Point(84, 13);
            this.ai_textBox_xcoord.Name = "ai_textBox_xcoord";
            this.ai_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.ai_textBox_xcoord.TabIndex = 1;
            this.ai_textBox_xcoord.Text = activeItemCoords.xCoord;
            ai_textBox_xcoord.Leave += new EventHandler(onXcoordChange);
            // 
            // ai_textBox_ycoord
            // 
            this.ai_textBox_ycoord.Location = new System.Drawing.Point(139, 13);
            this.ai_textBox_ycoord.Name = "ai_textBox_ycoord";
            this.ai_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.ai_textBox_ycoord.TabIndex = 2;
            this.ai_textBox_ycoord.Text = activeItemCoords.yCoord;
            ai_textBox_ycoord.Leave += new EventHandler(onYcoordChange);
            // 
            // ai_textBox_zcoord
            // 
            this.ai_textBox_zcoord.Location = new System.Drawing.Point(193, 13);
            this.ai_textBox_zcoord.Name = "ai_textBox_zcoord";
            this.ai_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.ai_textBox_zcoord.TabIndex = 3;
            this.ai_textBox_zcoord.Text = activeItemCoords.zCoord;
            ai_textBox_zcoord.Leave += new EventHandler(onZcoordChange);
            // 
            // ai_label_Rot
            // 
            this.ai_label_Rot.AutoSize = true;
            this.ai_label_Rot.Location = new System.Drawing.Point(20, 41);
            this.ai_label_Rot.Name = "ai_label_Rot";
            this.ai_label_Rot.Size = new System.Drawing.Size(50, 13);
            this.ai_label_Rot.TabIndex = 4;
            this.ai_label_Rot.Text = "Rotation:";
            // 
            // ai_textBox_xrot
            // 
            this.ai_textBox_xrot.Location = new System.Drawing.Point(84, 39);
            this.ai_textBox_xrot.Name = "ai_textBox_xrot";
            this.ai_textBox_xrot.Size = new System.Drawing.Size(31, 20);
            this.ai_textBox_xrot.TabIndex = 5;
            this.ai_textBox_xrot.Text = "0";
            // 
            // ai_textBox_yrot
            // 
            this.ai_textBox_yrot.Location = new System.Drawing.Point(123, 38);
            this.ai_textBox_yrot.Name = "ai_textBox_yrot";
            this.ai_textBox_yrot.Size = new System.Drawing.Size(31, 20);
            this.ai_textBox_yrot.TabIndex = 6;
            this.ai_textBox_yrot.Text = QuestComponents.Fox2Info.getQuaternionY(activeItemCoords.roty);
            // 
            // ai_textBox_zrot
            // 
            this.ai_textBox_zrot.Location = new System.Drawing.Point(163, 39);
            this.ai_textBox_zrot.Name = "ai_textBox_zrot";
            this.ai_textBox_zrot.Size = new System.Drawing.Size(31, 20);
            this.ai_textBox_zrot.TabIndex = 7;
            this.ai_textBox_zrot.Text = "0";
            // 
            // ai_textBox_wrot
            // 
            this.ai_textBox_wrot.Location = new System.Drawing.Point(203, 38);
            this.ai_textBox_wrot.Name = "ai_textBox_wrot";
            this.ai_textBox_wrot.Size = new System.Drawing.Size(31, 20);
            this.ai_textBox_wrot.TabIndex = 8;
            this.ai_textBox_wrot.Text = QuestComponents.Fox2Info.getQuaternionW(activeItemCoords.roty);
            // 
            // ai_label_activeitem
            // 
            this.ai_label_activeitem.AutoSize = true;
            this.ai_label_activeitem.Location = new System.Drawing.Point(7, 68);
            this.ai_label_activeitem.Name = "ai_label_activeitem";
            this.ai_label_activeitem.Size = new System.Drawing.Size(63, 13);
            this.ai_label_activeitem.TabIndex = 9;
            this.ai_label_activeitem.Text = "Active Item:";
            // 
            // ai_comboBox_activeitem
            // 
            this.ai_comboBox_activeitem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ai_comboBox_activeitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ai_comboBox_activeitem.FormattingEnabled = true;
            this.ai_comboBox_activeitem.Location = new System.Drawing.Point(84, 65);
            this.ai_comboBox_activeitem.Name = "ai_comboBox_activeitem";
            this.ai_comboBox_activeitem.Items.AddRange(activeItems);
            this.ai_comboBox_activeitem.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.ai_comboBox_activeitem.TabIndex = 10;
            this.ai_comboBox_activeitem.Text = "EQP_SWP_DMine";
            ai_comboBox_activeitem.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            this.ai_groupBox_main.ResumeLayout(false);
            this.ai_groupBox_main.PerformLayout();
        }

        public override GroupBox getGroupBoxMain()
        {
            return ai_groupBox_main;
        }

        public void onXcoordChange(object sender, EventArgs e)
        {
            activeItemCoords.xCoord = ai_textBox_xcoord.Text;
        }

        public void onYcoordChange(object sender, EventArgs e)
        {
            activeItemCoords.yCoord = ai_textBox_ycoord.Text;
        }

        public void onZcoordChange(object sender, EventArgs e)
        {
            activeItemCoords.zCoord = ai_textBox_zcoord.Text;
        }

    }

    public class AnimalDetail : Detail
    {
        public Coordinates animalCoords;
        int animalNum;

        
        public GroupBox a_groupBox_main;
        public ComboBox a_comboBox_TypeID;
        public Label a_label_targetcount;
        public ComboBox a_comboBox_count;
        public Label a_label_count;
        public ComboBox a_comboBox_animal;
        public Label a_label_animal;
        public CheckBox a_checkBox_isTarget;
        public Label a_label_isTarget;
        public TextBox a_textBox_rot;
        public Label a_label_rot;
        public TextBox a_textBox_zcoord;
        public TextBox a_textBox_ycoord;
        public TextBox a_textBox_xcoord;
        public Label a_label_coord;

        public AnimalDetail(Coordinates coord, int num) : base(coord, num)
        {
            animalCoords = coord;
            animalNum = num;
        }

        public override void SetDetail(Detail detail)
        {
            AnimalDetail animalDetail = (AnimalDetail)detail;
            a_checkBox_isTarget.Checked = animalDetail.a_checkBox_isTarget.Checked;
            a_comboBox_animal.Text = animalDetail.a_comboBox_animal.Text;
            a_comboBox_TypeID.Text = animalDetail.a_comboBox_TypeID.Text;
            a_comboBox_count.Text = animalDetail.a_comboBox_count.Text;
        }

        public override void BuildDetail(int width)
        {

            width -= 15;
            int comboboxWidth = width - 96;
            this.a_groupBox_main = new System.Windows.Forms.GroupBox();
            this.a_comboBox_TypeID = new System.Windows.Forms.ComboBox();
            this.a_label_targetcount = new System.Windows.Forms.Label();
            this.a_comboBox_count = new System.Windows.Forms.ComboBox();
            this.a_label_count = new System.Windows.Forms.Label();
            this.a_comboBox_animal = new System.Windows.Forms.ComboBox();
            this.a_label_animal = new System.Windows.Forms.Label();
            this.a_checkBox_isTarget = new System.Windows.Forms.CheckBox();
            this.a_label_isTarget = new System.Windows.Forms.Label();
            this.a_textBox_rot = new System.Windows.Forms.TextBox();
            this.a_label_rot = new System.Windows.Forms.Label();
            this.a_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.a_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.a_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.a_label_coord = new System.Windows.Forms.Label();
            this.a_groupBox_main.SuspendLayout();

            this.a_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.a_groupBox_main.Controls.Add(this.a_comboBox_TypeID);
            this.a_groupBox_main.Controls.Add(this.a_label_targetcount);
            this.a_groupBox_main.Controls.Add(this.a_comboBox_count);
            this.a_groupBox_main.Controls.Add(this.a_label_count);
            this.a_groupBox_main.Controls.Add(this.a_comboBox_animal);
            this.a_groupBox_main.Controls.Add(this.a_label_animal);
            this.a_groupBox_main.Controls.Add(this.a_checkBox_isTarget);
            this.a_groupBox_main.Controls.Add(this.a_label_isTarget);
            this.a_groupBox_main.Controls.Add(this.a_textBox_rot);
            this.a_groupBox_main.Controls.Add(this.a_label_rot);
            this.a_groupBox_main.Controls.Add(this.a_textBox_zcoord);
            this.a_groupBox_main.Controls.Add(this.a_textBox_ycoord);
            this.a_groupBox_main.Controls.Add(this.a_textBox_xcoord);
            this.a_groupBox_main.Controls.Add(this.a_label_coord);
            this.a_groupBox_main.Location = new System.Drawing.Point(3, 3 + (animalNum * 180));
            this.a_groupBox_main.Name = "a_groupBox_main";
            this.a_groupBox_main.Size = new System.Drawing.Size(width, 166);
            this.a_groupBox_main.TabIndex = 0;
            this.a_groupBox_main.TabStop = false;
            this.a_groupBox_main.Text = "Animal_Cluster_" + animalNum;
            this.a_groupBox_main.Click += new System.EventHandler(FocusGroupBox);
            // 
            // a_comboBox_targetcount
            // 
            this.a_comboBox_TypeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a_comboBox_TypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a_comboBox_TypeID.FormattingEnabled = true;
            this.a_comboBox_TypeID.Location = new System.Drawing.Point(173, 137);
            this.a_comboBox_TypeID.Name = "a_comboBox_TypeID";
            this.a_comboBox_TypeID.Size = new System.Drawing.Size(comboboxWidth - 89, 21);
            this.a_comboBox_TypeID.TabIndex = 13;
            a_comboBox_TypeID.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            a_comboBox_TypeID.Items.AddRange(new string[] { "TppGoat", "TppNubian" });
            a_comboBox_TypeID.Text = "TppGoat";
            // 
            // a_label_targetcount
            // 
            this.a_label_targetcount.AutoSize = true;
            this.a_label_targetcount.Location = new System.Drawing.Point(115, 141);
            this.a_label_targetcount.Name = "a_label_targetcount";
            this.a_label_targetcount.Size = new System.Drawing.Size(72, 13);
            this.a_label_targetcount.TabIndex = 12;
            this.a_label_targetcount.Text = "Type ID:";
            // 
            // a_comboBox_count
            // 
            this.a_comboBox_count.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a_comboBox_count.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a_comboBox_count.FormattingEnabled = true;
            this.a_comboBox_count.Location = new System.Drawing.Point(84, 108);
            this.a_comboBox_count.Name = "a_comboBox_count";
            this.a_comboBox_count.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.a_comboBox_count.TabIndex = 11;
            a_comboBox_count.Items.AddRange( new string[] { "1", "2", "3", "4", "5", "6"});
            a_comboBox_count.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            a_comboBox_count.Text = "1";
            // 
            // a_label_count
            // 
            this.a_label_count.AutoSize = true;
            this.a_label_count.Location = new System.Drawing.Point(32, 111);
            this.a_label_count.Name = "a_label_count";
            this.a_label_count.Size = new System.Drawing.Size(38, 13);
            this.a_label_count.TabIndex = 10;
            this.a_label_count.Text = "Count:";
            // 
            // a_comboBox_animal
            // 
            this.a_comboBox_animal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a_comboBox_animal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a_comboBox_animal.FormattingEnabled = true;
            this.a_comboBox_animal.Location = new System.Drawing.Point(84, 81);
            this.a_comboBox_animal.Items.AddRange(QuestComponents.AnimalInfo.animals);
            this.a_comboBox_animal.Text = "Sheep";
            this.a_comboBox_animal.Name = "a_comboBox_animal";
            this.a_comboBox_animal.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.a_comboBox_animal.TabIndex = 9;
            this.a_comboBox_animal.SelectedIndexChanged += new System.EventHandler(this.a_comboBox_animal_selectedIndexChanged);
            a_comboBox_animal.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            // 
            // a_label_animal
            // 
            this.a_label_animal.AutoSize = true;
            this.a_label_animal.Location = new System.Drawing.Point(29, 84);
            this.a_label_animal.Name = "a_label_animal";
            this.a_label_animal.Size = new System.Drawing.Size(41, 13);
            this.a_label_animal.TabIndex = 8;
            this.a_label_animal.Text = "Animal:";
            // 
            // a_checkBox_isTarget
            // 
            this.a_checkBox_isTarget.AutoSize = true;
            this.a_checkBox_isTarget.Location = new System.Drawing.Point(84, 141);
            this.a_checkBox_isTarget.Name = "a_checkBox_isTarget";
            this.a_checkBox_isTarget.Size = new System.Drawing.Size(15, 14);
            this.a_checkBox_isTarget.TabIndex = 7;
            this.a_checkBox_isTarget.UseVisualStyleBackColor = true;
            // 
            // a_label_isTarget
            // 
            this.a_label_isTarget.AutoSize = true;
            this.a_label_isTarget.Location = new System.Drawing.Point(18, 140);
            this.a_label_isTarget.Name = "a_label_isTarget";
            this.a_label_isTarget.Size = new System.Drawing.Size(52, 13);
            this.a_label_isTarget.TabIndex = 6;
            this.a_label_isTarget.Text = "Is Target:";
            // 
            // a_textBox_rot
            // 
            this.a_textBox_rot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a_textBox_rot.Location = new System.Drawing.Point(84, 48);
            this.a_textBox_rot.Name = "a_textBox_rot";
            this.a_textBox_rot.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.a_textBox_rot.TabIndex = 5;
            this.a_textBox_rot.Text = animalCoords.roty;
            a_textBox_rot.Leave += new EventHandler(this.onYRotChange);

            // 
            // a_label_rot
            // 
            this.a_label_rot.AutoSize = true;
            this.a_label_rot.Location = new System.Drawing.Point(20, 51);
            this.a_label_rot.Name = "a_label_rot";
            this.a_label_rot.Size = new System.Drawing.Size(50, 13);
            this.a_label_rot.TabIndex = 4;
            this.a_label_rot.Text = "Rotation:";
            // 
            // a_textBox_zcoord
            // 
            this.a_textBox_zcoord.Location = new System.Drawing.Point(193, 22);
            this.a_textBox_zcoord.Name = "a_textBox_zcoord";
            this.a_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.a_textBox_zcoord.TabIndex = 3;
            this.a_textBox_zcoord.Text = animalCoords.zCoord;
            a_textBox_zcoord.Leave += new EventHandler(this.onZcoordChange);
            // 
            // a_textBox_ycoord
            // 
            this.a_textBox_ycoord.Location = new System.Drawing.Point(139, 22);
            this.a_textBox_ycoord.Name = "a_textBox_ycoord";
            this.a_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.a_textBox_ycoord.TabIndex = 2;
            this.a_textBox_ycoord.Text = animalCoords.yCoord;
            a_textBox_ycoord.Leave += new EventHandler(this.onYcoordChange);
            // 
            // a_textBox_xcoord
            // 
            this.a_textBox_xcoord.Location = new System.Drawing.Point(84, 22);
            this.a_textBox_xcoord.Name = "a_textBox_xcoord";
            this.a_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.a_textBox_xcoord.TabIndex = 1;
            this.a_textBox_xcoord.Text = animalCoords.xCoord;
            a_textBox_xcoord.Leave += new EventHandler(this.onXcoordChange);
            // 
            // a_label_coord
            // 
            this.a_label_coord.AutoSize = true;
            this.a_label_coord.Location = new System.Drawing.Point(4, 25);
            this.a_label_coord.Name = "a_label_coord";
            this.a_label_coord.Size = new System.Drawing.Size(66, 13);
            this.a_label_coord.TabIndex = 0;
            this.a_label_coord.Text = "Coordinates:";


            this.a_groupBox_main.ResumeLayout(false);
            this.a_groupBox_main.PerformLayout();
        }

        private void a_comboBox_animal_selectedIndexChanged(object sender, EventArgs e)
        {
            a_comboBox_count.Items.Clear();
            a_comboBox_TypeID.Items.Clear();

            switch (a_comboBox_animal.Text)
            {
                case "Sheep":
                case "Cashmere_Goat":
                    a_comboBox_count.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6" });
                    a_comboBox_TypeID.Items.AddRange(new string[] {"TppGoat", "TppNubian" });
                    break;
                case "Boer_Goat":
                case "Nubian":
                    a_comboBox_count.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6" });
                    a_comboBox_TypeID.Items.AddRange(new string[] { "TppGoat", "TppNubian"});
                    break;

                case "Donkey":
                case "Zebra":
                case "Okapi":
                    a_comboBox_count.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6" });
                    a_comboBox_TypeID.Items.AddRange(new string[] { "TppZebra" });
                    break;

                case "Wolf":
                    a_comboBox_count.Items.AddRange(new string[] { "1", "2", "3", "4" });
                    a_comboBox_TypeID.Items.AddRange(new string[] {"TppWolf", "TppJackal"});
                    break;

                case "Jackal":
                case "African_Wild_Dog":
                    a_comboBox_count.Items.AddRange(new string[] { "1", "2", "3", "4" });
                    a_comboBox_TypeID.Items.AddRange(new string[] { "TppWolf", "TppJackal",});
                    break;

                case "Bear":
                    a_comboBox_count.Items.AddRange(new string[] { "1"});
                    a_comboBox_TypeID.Items.AddRange(new string[] { "TppBear" });
                    break;
            }
            a_comboBox_TypeID.Text = QuestComponents.AnimalInfo.getAnimalType(a_comboBox_animal.Text);
            a_comboBox_count.Text = "1";
        }

        public override GroupBox getGroupBoxMain()
        {
            return a_groupBox_main;
        }

        public void onXcoordChange(object sender, EventArgs e)
        {
            animalCoords.xCoord = a_textBox_xcoord.Text;
        }

        public void onYcoordChange(object sender, EventArgs e)
        {
            animalCoords.yCoord = a_textBox_ycoord.Text;
        }

        public void onZcoordChange(object sender, EventArgs e)
        {
            animalCoords.zCoord = a_textBox_zcoord.Text;
        }

        public void onYRotChange(object sender, EventArgs e)
        {
            animalCoords.roty = a_textBox_rot.Text;
        }
    }

    public class EnemyDetail : Detail
    {
        int enemyNum;

        public GroupBox e_groupBox_main;
        public CheckBox e_checkBox_target;
        public Label e_label_target;
        public CheckBox e_checkBox_spawn;
        public Label e_label_spawn;
        public CheckBox e_checkBox_balaclava;
        public Label e_label_balaclava;
        public CheckBox e_checkBox_zombie;
        public Label e_label_zombie;
        public CheckBox e_checkBox_armor;
        public Label e_label_armor;
        public Label e_label_body;
        public ComboBox e_comboBox_body;
        public ComboBox e_comboBox_cautionroute;
        public Label e_label_cautionroute;
        public ComboBox e_comboBox_sneakroute;
        public Label e_label_sneakroute;
        public ComboBox e_comboBox_skill;
        public Label e_label_skill;
        public ComboBox e_comboBox_staff;
        public Label e_label_staff;
        public ComboBox e_comboBox_power;
        public Button e_button_removepower;
        public Label e_label_power;
        public ListBox e_listBox_power;

        public EnemyDetail(int num) : base(new Coordinates("","",""), num)
        {
            enemyNum = num;
        }

        public override void BuildDetail(int width)
        {
            width -= 15;
            int comboboxWidth = width - 110;
            e_checkBox_balaclava = new System.Windows.Forms.CheckBox();
            e_label_balaclava = new System.Windows.Forms.Label();
            e_checkBox_zombie = new System.Windows.Forms.CheckBox();
            e_label_zombie = new System.Windows.Forms.Label();
            this.e_groupBox_main = new System.Windows.Forms.GroupBox();
            this.e_comboBox_power = new System.Windows.Forms.ComboBox();
            this.e_button_removepower = new System.Windows.Forms.Button();
            this.e_label_power = new System.Windows.Forms.Label();
            this.e_listBox_power = new System.Windows.Forms.ListBox();
            this.e_comboBox_skill = new System.Windows.Forms.ComboBox();
            this.e_label_skill = new System.Windows.Forms.Label();
            this.e_comboBox_staff = new System.Windows.Forms.ComboBox();
            this.e_label_staff = new System.Windows.Forms.Label();
            this.e_comboBox_body = new System.Windows.Forms.ComboBox();
            this.e_comboBox_cautionroute = new System.Windows.Forms.ComboBox();
            this.e_label_cautionroute = new System.Windows.Forms.Label();
            this.e_comboBox_sneakroute = new System.Windows.Forms.ComboBox();
            this.e_label_sneakroute = new System.Windows.Forms.Label();
            this.e_label_body = new System.Windows.Forms.Label();
            this.e_checkBox_target = new System.Windows.Forms.CheckBox();
            this.e_label_target = new System.Windows.Forms.Label();
            this.e_checkBox_armor = new System.Windows.Forms.CheckBox();
            this.e_label_armor = new System.Windows.Forms.Label();
            this.e_checkBox_spawn = new System.Windows.Forms.CheckBox();
            this.e_label_spawn = new System.Windows.Forms.Label();
            this.e_groupBox_main.SuspendLayout();

            // 
            // e_groupBox_main
            // 
            this.e_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.e_groupBox_main.Controls.Add(this.e_comboBox_power);
            this.e_groupBox_main.Controls.Add(this.e_button_removepower);
            this.e_groupBox_main.Controls.Add(this.e_label_power);
            this.e_groupBox_main.Controls.Add(this.e_comboBox_skill);
            this.e_groupBox_main.Controls.Add(this.e_listBox_power);
            this.e_groupBox_main.Controls.Add(this.e_label_skill);
            this.e_groupBox_main.Controls.Add(this.e_comboBox_staff);
            this.e_groupBox_main.Controls.Add(this.e_label_staff);
            this.e_groupBox_main.Controls.Add(this.e_comboBox_body);
            this.e_groupBox_main.Controls.Add(this.e_comboBox_cautionroute);
            this.e_groupBox_main.Controls.Add(this.e_label_cautionroute);
            this.e_groupBox_main.Controls.Add(this.e_comboBox_sneakroute);
            this.e_groupBox_main.Controls.Add(this.e_label_sneakroute);
            this.e_groupBox_main.Controls.Add(this.e_label_body);
            this.e_groupBox_main.Controls.Add(this.e_checkBox_target);
            this.e_groupBox_main.Controls.Add(this.e_checkBox_armor);
            this.e_groupBox_main.Controls.Add(this.e_label_armor);
            this.e_groupBox_main.Controls.Add(this.e_checkBox_spawn);
            this.e_groupBox_main.Controls.Add(this.e_label_spawn);
            this.e_groupBox_main.Controls.Add(this.e_label_target);
            this.e_groupBox_main.Controls.Add(this.e_label_zombie);
            this.e_groupBox_main.Controls.Add(this.e_checkBox_zombie);
            this.e_groupBox_main.Controls.Add(this.e_label_balaclava);
            this.e_groupBox_main.Controls.Add(this.e_checkBox_balaclava);
            e_groupBox_main.Disposed += new EventHandler(this.e_groupBox_main_Disposed);
            this.e_groupBox_main.Location = new System.Drawing.Point(3, 55 + (334 * enemyNum));
            this.e_groupBox_main.Name = "e_groupBox_main";
            this.e_groupBox_main.Size = new System.Drawing.Size(width, 317);
            this.e_groupBox_main.TabIndex = 0;
            this.e_groupBox_main.TabStop = false;
            this.e_groupBox_main.Text = "sol_quest_000" + enemyNum;
            this.e_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_groupBox_main.Click += new System.EventHandler(FocusGroupBox);
            // 
            // e_comboBox_power
            // 
            this.e_comboBox_power.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_comboBox_power.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_comboBox_power.FormattingEnabled = true;
            this.e_comboBox_power.Location = new System.Drawing.Point(99, 125);
            this.e_comboBox_power.Name = "e_comboBox_power";
            this.e_comboBox_power.Items.AddRange(QuestComponents.EnemyInfo.powerSetting);
            this.e_comboBox_power.Text = "SOFT_ARMOR";
            this.e_comboBox_power.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.e_comboBox_power.TabIndex = 22;
            this.e_comboBox_power.Enabled = false;
            this.e_comboBox_power.SelectedIndexChanged += new EventHandler(this.powerChanged);
            // 
            // e_button_removepower
            // 
            this.e_button_removepower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.e_button_removepower.Location = new System.Drawing.Point(comboboxWidth + 46, 205);
            this.e_button_removepower.Name = "e_button_removepower";
            this.e_button_removepower.Size = new System.Drawing.Size(55, 23);
            this.e_button_removepower.TabIndex = 21;
            this.e_button_removepower.Text = "Remove";
            this.e_button_removepower.UseVisualStyleBackColor = true;
            this.e_button_removepower.Click += new EventHandler(this.e_button_removepower_Click);
            this.e_button_removepower.Enabled = false;
            // 
            // e_label_power
            // 
            this.e_label_power.AutoSize = true;
            this.e_label_power.Location = new System.Drawing.Point(9, 129);
            this.e_label_power.Name = "e_label_power";
            this.e_label_power.Size = new System.Drawing.Size(76, 13);
            this.e_label_power.TabIndex = 19;
            e_label_power.Enabled = false;
            this.e_label_power.Text = "Gear | Tactics:";
            // 
            // e_listBox_power
            // 
            this.e_listBox_power.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_listBox_power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.e_listBox_power.FormattingEnabled = true;
            this.e_listBox_power.Location = new System.Drawing.Point(99, 150);
            this.e_listBox_power.Name = "e_listBox_power";
            this.e_listBox_power.Size = new System.Drawing.Size(comboboxWidth, 54);
            this.e_listBox_power.TabIndex = 18;
            e_listBox_power.Enabled = false;
            this.e_listBox_power.SelectedIndexChanged += new EventHandler(this.e_listBox_power_selectedIndexChanged);
            // 
            // e_comboBox_skill
            // 
            this.e_comboBox_skill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_comboBox_skill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_comboBox_skill.FormattingEnabled = true;
            this.e_comboBox_skill.Location = new System.Drawing.Point(99, 290);
            this.e_comboBox_skill.Name = "e_comboBox_skill";
            this.e_comboBox_skill.Items.AddRange(skills);
            this.e_comboBox_skill.Text = "NONE";
            this.e_comboBox_skill.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.e_comboBox_skill.TabIndex = 17;
            e_comboBox_skill.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            e_comboBox_skill.Enabled = false;
            // 
            // e_label_skill
            // 
            this.e_label_skill.AutoSize = true;
            this.e_label_skill.Location = new System.Drawing.Point(56, 293);
            this.e_label_skill.Name = "e_label_skill";
            this.e_label_skill.Size = new System.Drawing.Size(29, 13);
            this.e_label_skill.TabIndex = 16;
            this.e_label_skill.Text = "Skill:";
            e_label_skill.Enabled = false;
            // 
            // e_comboBox_staff
            // 
            this.e_comboBox_staff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_comboBox_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_comboBox_staff.FormattingEnabled = true;
            this.e_comboBox_staff.Location = new System.Drawing.Point(99, 265);
            this.e_comboBox_staff.Name = "e_comboBox_staff";
            this.e_comboBox_staff.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.e_comboBox_staff.Items.AddRange(Staff_Type_ID);
            this.e_comboBox_staff.Text = "NONE";
            this.e_comboBox_staff.TabIndex = 15;
            e_comboBox_staff.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            e_comboBox_staff.Enabled = false;
            // 
            // e_label_staff
            // 
            this.e_label_staff.AutoSize = true;
            this.e_label_staff.Location = new System.Drawing.Point(26, 268);
            this.e_label_staff.Name = "e_label_staff";
            this.e_label_staff.Size = new System.Drawing.Size(59, 13);
            this.e_label_staff.TabIndex = 14;
            this.e_label_staff.Text = "Staff Type:";
            e_label_staff.Enabled = false;
            // 
            // e_comboBox_body
            // 
            this.e_comboBox_body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_comboBox_body.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_comboBox_body.FormattingEnabled = true;
            this.e_comboBox_body.Location = new System.Drawing.Point(99, 240);
            this.e_comboBox_body.Name = "e_comboBox_body";
            this.e_comboBox_body.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.e_comboBox_body.TabIndex = 13;
            e_comboBox_body.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            e_comboBox_body.Enabled = false;
            // 
            // e_comboBox_cautionroute
            // 
            this.e_comboBox_cautionroute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_comboBox_cautionroute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_comboBox_cautionroute.FormattingEnabled = true;
            this.e_comboBox_cautionroute.Location = new System.Drawing.Point(99, 89);
            this.e_comboBox_cautionroute.Name = "e_comboBox_cautionroute";
            this.e_comboBox_cautionroute.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.e_comboBox_cautionroute.TabIndex = 12;
            e_comboBox_cautionroute.Enabled = false;
            e_comboBox_cautionroute.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            // 
            // e_label_cautionroute
            // 
            this.e_label_cautionroute.AutoSize = true;
            this.e_label_cautionroute.Location = new System.Drawing.Point(7, 92);
            this.e_label_cautionroute.Name = "e_label_cautionroute";
            this.e_label_cautionroute.Size = new System.Drawing.Size(78, 13);
            this.e_label_cautionroute.TabIndex = 11;
            this.e_label_cautionroute.Text = "Caution Route:";
            e_label_cautionroute.Enabled = false;
            // 
            // e_comboBox_sneakroute
            // 
            this.e_comboBox_sneakroute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_comboBox_sneakroute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_comboBox_sneakroute.FormattingEnabled = true;
            this.e_comboBox_sneakroute.Location = new System.Drawing.Point(99, 64);
            this.e_comboBox_sneakroute.Name = "e_comboBox_sneakroute";
            this.e_comboBox_sneakroute.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.e_comboBox_sneakroute.TabIndex = 10;
            e_comboBox_sneakroute.Enabled = false;
            e_comboBox_sneakroute.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            // 
            // e_label_sneakroute
            // 
            this.e_label_sneakroute.AutoSize = true;
            this.e_label_sneakroute.Location = new System.Drawing.Point(12, 68);
            this.e_label_sneakroute.Name = "e_label_sneakroute";
            this.e_label_sneakroute.Size = new System.Drawing.Size(73, 13);
            this.e_label_sneakroute.TabIndex = 9;
            this.e_label_sneakroute.Text = "Sneak Route:";
            e_label_sneakroute.Enabled = false;
            // 
            // e_label_body
            // 
            this.e_label_body.AutoSize = true;
            this.e_label_body.Location = new System.Drawing.Point(51, 243);
            this.e_label_body.Name = "e_label_body";
            this.e_label_body.Size = new System.Drawing.Size(34, 13);
            this.e_label_body.TabIndex = 8;
            this.e_label_body.Text = "Body:";
            e_label_body.Enabled = false;
            // 
            // e_checkBox_armor
            // 
            this.e_checkBox_armor.AutoSize = true;
            this.e_checkBox_armor.Location = new System.Drawing.Point(99, 210);
            this.e_checkBox_armor.Name = "e_checkBox_armor";
            this.e_checkBox_armor.Size = new System.Drawing.Size(15, 14);
            this.e_checkBox_armor.TabIndex = 3;
            this.e_checkBox_armor.UseVisualStyleBackColor = true;
            this.e_checkBox_armor.Click += new EventHandler(this.armor_Checkbox_Clicked);
            e_checkBox_armor.Enabled = false;
            // 
            // e_label_armor
            // 
            this.e_label_armor.AutoSize = true;
            this.e_label_armor.Location = new System.Drawing.Point(14, 210);
            this.e_label_armor.Name = "e_label_armor";
            this.e_label_armor.Size = new System.Drawing.Size(71, 13);
            this.e_label_armor.TabIndex = 2;
            this.e_label_armor.Text = "Heavy Armor:";
            e_label_armor.Enabled = false;
            // 
            // e_checkBox_target
            // 
            this.e_checkBox_target.AutoSize = true;
            this.e_checkBox_target.Location = new System.Drawing.Point(205, 21);
            this.e_checkBox_target.Name = "e_checkBox_target";
            this.e_checkBox_target.Size = new System.Drawing.Size(15, 14);
            this.e_checkBox_target.TabIndex = 5;
            this.e_checkBox_target.UseVisualStyleBackColor = true;
            e_checkBox_target.Enabled = false;
            // 
            // e_label_target
            // 
            this.e_label_target.AutoSize = true;
            this.e_label_target.Location = new System.Drawing.Point(139, 21);
            this.e_label_target.Name = "e_label_target";
            this.e_label_target.Size = new System.Drawing.Size(52, 13);
            this.e_label_target.TabIndex = 4;
            this.e_label_target.Text = "Is Target:";
            e_label_target.Enabled = false;
            // 
            // e_checkBox_spawn
            // 
            this.e_checkBox_spawn.AutoSize = true;
            this.e_checkBox_spawn.Location = new System.Drawing.Point(99, 21);
            this.e_checkBox_spawn.Name = "e_checkBox_spawn";
            this.e_checkBox_spawn.Size = new System.Drawing.Size(15, 14);
            this.e_checkBox_spawn.TabIndex = 1;
            this.e_checkBox_spawn.UseVisualStyleBackColor = true;
            e_checkBox_spawn.CheckedChanged += new EventHandler(this.e_checkBox_spawn_CheckedChanged);
            // 
            // e_label_spawn
            // 
            this.e_label_spawn.AutoSize = true;
            this.e_label_spawn.Location = new System.Drawing.Point(42, 21);
            this.e_label_spawn.Name = "e_label_spawn";
            this.e_label_spawn.Size = new System.Drawing.Size(43, 13);
            this.e_label_spawn.TabIndex = 0;
            this.e_label_spawn.Text = "Spawn:";
            // 
            // e_checkBox_Balaclava
            // 
            this.e_checkBox_balaclava.AutoSize = true;
            this.e_checkBox_balaclava.Location = new System.Drawing.Point(99, 41);
            this.e_checkBox_balaclava.Name = "e_checkBox_balaclava";
            this.e_checkBox_balaclava.Size = new System.Drawing.Size(15, 14);
            this.e_checkBox_balaclava.TabIndex = 5;
            this.e_checkBox_balaclava.UseVisualStyleBackColor = true;
            e_checkBox_balaclava.Enabled = false;
            e_checkBox_balaclava.CheckedChanged += new EventHandler(this.balaclava_checkbox_clicked);
            // 
            // e_label_Balaclava
            // 
            this.e_label_balaclava.AutoSize = true;
            this.e_label_balaclava.Location = new System.Drawing.Point(28, 41);
            this.e_label_balaclava.Name = "e_label_balaclava";
            this.e_label_balaclava.Size = new System.Drawing.Size(52, 13);
            this.e_label_balaclava.TabIndex = 4;
            this.e_label_balaclava.Text = "Balaclava:";
            e_label_balaclava.Enabled = false;
            // 
            // e_checkBox_zombie
            // 
            this.e_checkBox_zombie.AutoSize = true;
            this.e_checkBox_zombie.Location = new System.Drawing.Point(205, 41);
            this.e_checkBox_zombie.Name = "e_checkBox_zombie";
            this.e_checkBox_zombie.Size = new System.Drawing.Size(15, 14);
            this.e_checkBox_zombie.TabIndex = 1;
            this.e_checkBox_zombie.UseVisualStyleBackColor = true;
            e_checkBox_zombie.Enabled = false;
            e_checkBox_zombie.CheckedChanged += new EventHandler(this.zombie_checkbox_clicked);
            // 
            // e_label_zombie
            // 
            this.e_label_zombie.AutoSize = true;
            this.e_label_zombie.Location = new System.Drawing.Point(136, 41);
            this.e_label_zombie.Name = "e_label_zombie";
            this.e_label_zombie.Size = new System.Drawing.Size(43, 13);
            this.e_label_zombie.TabIndex = 0;
            this.e_label_zombie.Text = "Is Zombie:";
            e_label_zombie.Enabled = false;
            this.e_groupBox_main.ResumeLayout(false);
            this.e_groupBox_main.PerformLayout();
        }

        private void e_groupBox_main_Disposed(object sender, EventArgs e)
        {
            if (e_checkBox_armor.Checked)
                QuestComponents.EnemyInfo.armorCount--;
            if (e_checkBox_armor.Checked)
                QuestComponents.EnemyInfo.zombieCount--;
            if (e_checkBox_balaclava.Checked)
                QuestComponents.EnemyInfo.balaCount--;
        }

        private void e_checkBox_spawn_CheckedChanged(object sender, EventArgs e)
        {
            if (e_checkBox_spawn.Checked)
            {
                e_label_skill.Enabled = true;
                e_label_sneakroute.Enabled = true;
                e_label_staff.Enabled = true;
                e_label_target.Enabled = true;
                e_listBox_power.Enabled = true;
                e_checkBox_armor.Enabled = true;
                e_checkBox_target.Enabled = true;
                e_comboBox_body.Enabled = true;
                e_comboBox_cautionroute.Enabled = true;
                e_comboBox_power.Enabled = true;
                e_comboBox_skill.Enabled = true;
                e_comboBox_sneakroute.Enabled = true;
                e_comboBox_staff.Enabled = true;
                e_label_armor.Enabled = true;
                e_label_body.Enabled = true;
                e_label_cautionroute.Enabled = true;
                e_label_power.Enabled = true;
                e_label_balaclava.Enabled = true;
                e_checkBox_balaclava.Enabled = true;
                e_label_zombie.Enabled = true;
                e_checkBox_zombie.Enabled = true;
            } else
            {
                e_label_skill.Enabled = false;
                e_label_sneakroute.Enabled = false;
                e_label_staff.Enabled = false;
                e_label_target.Enabled = false;
                e_listBox_power.Enabled = false;
                e_checkBox_armor.Enabled = false;
                e_checkBox_target.Enabled = false;
                e_comboBox_body.Enabled = false;
                e_comboBox_cautionroute.Enabled = false;
                e_comboBox_power.Enabled = false;
                e_comboBox_skill.Enabled = false;
                e_comboBox_sneakroute.Enabled = false;
                e_comboBox_staff.Enabled = false;
                e_label_armor.Enabled = false;
                e_label_body.Enabled = false;
                e_label_cautionroute.Enabled = false;
                e_label_power.Enabled = false;
                e_label_balaclava.Enabled = false;
                e_checkBox_balaclava.Enabled = false;
                e_label_zombie.Enabled = false;
                e_checkBox_zombie.Enabled = false;
            }
        }

        private void armor_Checkbox_Clicked(object sender, EventArgs e)
        {
            updateArmor();
            e_groupBox_main.Focus();
        }
        private void balaclava_checkbox_clicked(object sender, EventArgs e)
        {
            updateBalaclava();
            e_groupBox_main.Focus();
            
        }
        private void zombie_checkbox_clicked(object sender, EventArgs e)
        {
            updateZombie();
            e_groupBox_main.Focus();
        }

        private void updateArmor()
        {
            if (e_checkBox_armor.Checked)
            {
                if (QuestComponents.EnemyInfo.armorCount >= QuestComponents.EnemyInfo.MAXQUESTFOVA)
                {
                    MessageBox.Show("Heavy Armor can only be applied to 8 soldiers maximum.", "Game Limitation Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e_checkBox_armor.Checked = false;
                }
                else
                {
                    QuestComponents.EnemyInfo.armorCount++;
                    e_listBox_power.Items.Add("QUEST_ARMOR");
                    e_listBox_power.SelectedIndex = e_listBox_power.Items.Count - 1;
                    e_comboBox_body.Enabled = false;
                    e_checkBox_balaclava.Enabled = false;
                    e_label_body.Enabled = false;
                    e_label_balaclava.Enabled = false;
                }
            }
            else
            {
                QuestComponents.EnemyInfo.armorCount--;
                e_comboBox_body.Enabled = true;
                e_checkBox_balaclava.Enabled = true;
                e_label_body.Enabled = true;
                e_label_balaclava.Enabled = true;
                e_listBox_power.Items.Remove("QUEST_ARMOR");
                e_listBox_power.SelectedIndex = e_listBox_power.Items.Count - 1;
            }

            e_groupBox_main.Focus();
        }

        private void updateZombie()
        {
            if (e_checkBox_zombie.Checked)
                QuestComponents.EnemyInfo.zombieCount++;
            else
                QuestComponents.EnemyInfo.zombieCount--;
            e_groupBox_main.Focus();
        }
        private void updateBalaclava()
        {
            if (e_checkBox_balaclava.Checked)
            {
                if (QuestComponents.EnemyInfo.balaCount >= QuestComponents.EnemyInfo.MAXQUESTFOVA)
                {
                    MessageBox.Show("Balaclavas can only be applied to 8 soldiers maximum.", "Game Limitation Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e_checkBox_balaclava.Checked = false;
                }
                else
                {
                    QuestComponents.EnemyInfo.balaCount++;
                    e_checkBox_armor.Enabled = false;
                    e_label_armor.Enabled = false;
                }
            }
            else
            {
                QuestComponents.EnemyInfo.balaCount--;
                e_checkBox_armor.Enabled = true;
                e_label_armor.Enabled = true;
            }
        }

        private void e_listBox_power_selectedIndexChanged(object sender, EventArgs e)
        {
            if (e_listBox_power.SelectedIndex > -1)
                e_button_removepower.Enabled = true;
            else
                e_button_removepower.Enabled = false;
            e_groupBox_main.Focus();
        }

        public override GroupBox getGroupBoxMain()
        {
            return e_groupBox_main;
        }

        public override void SetDetail(Detail detail)
        {
            EnemyDetail enemyDetail = (EnemyDetail)detail;

            e_checkBox_armor.Checked = enemyDetail.e_checkBox_armor.Checked;
            e_checkBox_spawn.Checked = enemyDetail.e_checkBox_spawn.Checked;
            e_checkBox_target.Checked = enemyDetail.e_checkBox_target.Checked;
            e_checkBox_balaclava.Checked = enemyDetail.e_checkBox_balaclava.Checked;
            e_checkBox_zombie.Checked = enemyDetail.e_checkBox_zombie.Checked;

            e_listBox_power.Text = enemyDetail.e_listBox_power.Text;

            string[] cautionArray = new string[enemyDetail.e_comboBox_cautionroute.Items.Count];
            enemyDetail.e_comboBox_cautionroute.Items.CopyTo(cautionArray,0);
            e_comboBox_cautionroute.Items.AddRange(cautionArray);

            string[] sneakArray = new string[enemyDetail.e_comboBox_sneakroute.Items.Count];
            enemyDetail.e_comboBox_sneakroute.Items.CopyTo(sneakArray, 0);
            e_comboBox_sneakroute.Items.AddRange(sneakArray);

            string[] bodyArray = new string[enemyDetail.e_comboBox_body.Items.Count];
            enemyDetail.e_comboBox_body.Items.CopyTo(bodyArray, 0);
            e_comboBox_body.Items.AddRange(bodyArray);

            e_comboBox_cautionroute.Text = enemyDetail.e_comboBox_cautionroute.Text;
            e_comboBox_sneakroute.Text = enemyDetail.e_comboBox_sneakroute.Text;

            e_comboBox_body.Text = enemyDetail.e_comboBox_body.Text;
            e_comboBox_skill.Text = enemyDetail.e_comboBox_skill.Text;
            e_comboBox_staff.Text = enemyDetail.e_comboBox_staff.Text;
        }

        private void powerChanged(object sender, EventArgs e)
        {
            if (!e_listBox_power.Items.Contains(e_comboBox_power.Text))
            {
                e_listBox_power.Items.Add(e_comboBox_power.Text);
                e_listBox_power.SelectedIndex = e_listBox_power.Items.Count - 1;
                e_groupBox_main.Focus();
            }
        }
        private void e_button_removepower_Click(object sender, EventArgs e)
        {

            if (e_listBox_power.Text.Equals("QUEST_ARMOR"))
            {
                e_checkBox_armor.Checked = false;
                updateArmor();
            }
            else if (e_listBox_power.SelectedIndex != -1)
            {
                e_listBox_power.Items.RemoveAt(e_listBox_power.SelectedIndex);
                e_listBox_power.SelectedIndex = e_listBox_power.Items.Count - 1;
                e_groupBox_main.Focus();
            }
        }
    }

    partial class Details
    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDetails = new System.Windows.Forms.Panel();
            this.groupActiveItemDet = new System.Windows.Forms.GroupBox();
            this.panelAcItDet = new System.Windows.Forms.Panel();
            this.groupExistingEneDet = new System.Windows.Forms.GroupBox();
            this.panelCPEnemyDet = new System.Windows.Forms.Panel();
            this.label_subtype2 = new System.Windows.Forms.Label();
            this.comboBox_subtype2 = new System.Windows.Forms.ComboBox();
            this.label_customizeall = new System.Windows.Forms.Label();
            this.checkBox_customizeall = new System.Windows.Forms.CheckBox();
            this.groupNewEneDet = new System.Windows.Forms.GroupBox();
            this.panelQuestEnemyDet = new System.Windows.Forms.Panel();
            this.label_spawnall = new System.Windows.Forms.Label();
            this.checkBox_spawnall = new System.Windows.Forms.CheckBox();
            this.label_subtype = new System.Windows.Forms.Label();
            this.comboBox_subtype = new System.Windows.Forms.ComboBox();
            this.groupAnimalDet = new System.Windows.Forms.GroupBox();
            this.panelAnimalDet = new System.Windows.Forms.Panel();
            this.groupVehDet = new System.Windows.Forms.GroupBox();
            this.panelVehDet = new System.Windows.Forms.Panel();
            this.groupStMdDet = new System.Windows.Forms.GroupBox();
            this.panelStMdDet = new System.Windows.Forms.Panel();
            this.groupItemDet = new System.Windows.Forms.GroupBox();
            this.panelItemDet = new System.Windows.Forms.Panel();
            this.groupHosDet = new System.Windows.Forms.GroupBox();
            this.panelHosDet = new System.Windows.Forms.Panel();
            this.h_label_intrgt = new System.Windows.Forms.Label();
            this.h_checkBox_intrgt = new System.Windows.Forms.CheckBox();
            this.comboBox_Body = new System.Windows.Forms.ComboBox();
            this.label_Body = new System.Windows.Forms.Label();
            this.originAnchor = new System.Windows.Forms.Label();
            this.panelDetails.SuspendLayout();
            this.groupActiveItemDet.SuspendLayout();
            this.groupExistingEneDet.SuspendLayout();
            this.panelCPEnemyDet.SuspendLayout();
            this.groupNewEneDet.SuspendLayout();
            this.panelQuestEnemyDet.SuspendLayout();
            this.groupAnimalDet.SuspendLayout();
            this.groupVehDet.SuspendLayout();
            this.groupStMdDet.SuspendLayout();
            this.groupItemDet.SuspendLayout();
            this.groupHosDet.SuspendLayout();
            this.panelHosDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetails
            // 
            this.panelDetails.AutoScroll = true;
            this.panelDetails.Controls.Add(this.originAnchor);
            this.panelDetails.Controls.Add(this.groupActiveItemDet);
            this.panelDetails.Controls.Add(this.groupExistingEneDet);
            this.panelDetails.Controls.Add(this.groupNewEneDet);
            this.panelDetails.Controls.Add(this.groupAnimalDet);
            this.panelDetails.Controls.Add(this.groupVehDet);
            this.panelDetails.Controls.Add(this.groupStMdDet);
            this.panelDetails.Controls.Add(this.groupItemDet);
            this.panelDetails.Controls.Add(this.groupHosDet);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(2169, 452);
            this.panelDetails.TabIndex = 0;
            // 
            // groupActiveItemDet
            // 
            this.groupActiveItemDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupActiveItemDet.Controls.Add(this.panelAcItDet);
            this.groupActiveItemDet.Location = new System.Drawing.Point(1621, 3);
            this.groupActiveItemDet.Name = "groupActiveItemDet";
            this.groupActiveItemDet.Size = new System.Drawing.Size(264, 449);
            this.groupActiveItemDet.TabIndex = 28;
            this.groupActiveItemDet.TabStop = false;
            this.groupActiveItemDet.Text = "Active Items";
            // 
            // panelAcItDet
            // 
            this.panelAcItDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAcItDet.AutoScroll = true;
            this.panelAcItDet.Location = new System.Drawing.Point(3, 16);
            this.panelAcItDet.Name = "panelAcItDet";
            this.panelAcItDet.Size = new System.Drawing.Size(258, 424);
            this.panelAcItDet.TabIndex = 0;
            this.panelAcItDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // groupExistingEneDet
            // 
            this.groupExistingEneDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupExistingEneDet.Controls.Add(this.panelCPEnemyDet);
            this.groupExistingEneDet.Location = new System.Drawing.Point(273, 3);
            this.groupExistingEneDet.Name = "groupExistingEneDet";
            this.groupExistingEneDet.Size = new System.Drawing.Size(264, 449);
            this.groupExistingEneDet.TabIndex = 33;
            this.groupExistingEneDet.TabStop = false;
            this.groupExistingEneDet.Text = "Existing Enemies";
            // 
            // panelCPEnemyDet
            // 
            this.panelCPEnemyDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCPEnemyDet.AutoScroll = true;
            this.panelCPEnemyDet.Controls.Add(this.label_subtype2);
            this.panelCPEnemyDet.Controls.Add(this.comboBox_subtype2);
            this.panelCPEnemyDet.Controls.Add(this.label_customizeall);
            this.panelCPEnemyDet.Controls.Add(this.checkBox_customizeall);
            this.panelCPEnemyDet.Location = new System.Drawing.Point(3, 16);
            this.panelCPEnemyDet.Name = "panelCPEnemyDet";
            this.panelCPEnemyDet.Size = new System.Drawing.Size(258, 424);
            this.panelCPEnemyDet.TabIndex = 0;
            this.panelCPEnemyDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // label_subtype2
            // 
            this.label_subtype2.AutoSize = true;
            this.label_subtype2.Location = new System.Drawing.Point(14, 6);
            this.label_subtype2.Name = "label_subtype2";
            this.label_subtype2.Size = new System.Drawing.Size(88, 13);
            this.label_subtype2.TabIndex = 8;
            this.label_subtype2.Text = "Soldier SubType:";
            // 
            // comboBox_subtype2
            // 
            this.comboBox_subtype2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_subtype2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_subtype2.Enabled = false;
            this.comboBox_subtype2.FormattingEnabled = true;
            this.comboBox_subtype2.Location = new System.Drawing.Point(108, 3);
            this.comboBox_subtype2.Name = "comboBox_subtype2";
            this.comboBox_subtype2.Size = new System.Drawing.Size(147, 21);
            this.comboBox_subtype2.TabIndex = 9;
            // 
            // label_customizeall
            // 
            this.label_customizeall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_customizeall.AutoSize = true;
            this.label_customizeall.Location = new System.Drawing.Point(105, 30);
            this.label_customizeall.Name = "label_customizeall";
            this.label_customizeall.Size = new System.Drawing.Size(129, 13);
            this.label_customizeall.TabIndex = 2;
            this.label_customizeall.Text = "Customize All CP Soldiers:";
            // 
            // checkBox_customizeall
            // 
            this.checkBox_customizeall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_customizeall.AutoSize = true;
            this.checkBox_customizeall.Checked = true;
            this.checkBox_customizeall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_customizeall.Location = new System.Drawing.Point(240, 30);
            this.checkBox_customizeall.Name = "checkBox_customizeall";
            this.checkBox_customizeall.Size = new System.Drawing.Size(15, 14);
            this.checkBox_customizeall.TabIndex = 3;
            this.checkBox_customizeall.UseVisualStyleBackColor = true;
            this.checkBox_customizeall.Click += new System.EventHandler(this.checkbox_customizeAll_Click);
            // 
            // groupNewEneDet
            // 
            this.groupNewEneDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupNewEneDet.Controls.Add(this.panelQuestEnemyDet);
            this.groupNewEneDet.Location = new System.Drawing.Point(3, 3);
            this.groupNewEneDet.Name = "groupNewEneDet";
            this.groupNewEneDet.Size = new System.Drawing.Size(264, 449);
            this.groupNewEneDet.TabIndex = 32;
            this.groupNewEneDet.TabStop = false;
            this.groupNewEneDet.Text = "New Enemies";
            // 
            // panelQuestEnemyDet
            // 
            this.panelQuestEnemyDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestEnemyDet.AutoScroll = true;
            this.panelQuestEnemyDet.Controls.Add(this.label_spawnall);
            this.panelQuestEnemyDet.Controls.Add(this.checkBox_spawnall);
            this.panelQuestEnemyDet.Controls.Add(this.label_subtype);
            this.panelQuestEnemyDet.Controls.Add(this.comboBox_subtype);
            this.panelQuestEnemyDet.Location = new System.Drawing.Point(3, 16);
            this.panelQuestEnemyDet.Name = "panelQuestEnemyDet";
            this.panelQuestEnemyDet.Size = new System.Drawing.Size(258, 424);
            this.panelQuestEnemyDet.TabIndex = 0;
            this.panelQuestEnemyDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // label_spawnall
            // 
            this.label_spawnall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_spawnall.AutoSize = true;
            this.label_spawnall.Location = new System.Drawing.Point(106, 30);
            this.label_spawnall.Name = "label_spawnall";
            this.label_spawnall.Size = new System.Drawing.Size(128, 13);
            this.label_spawnall.TabIndex = 1;
            this.label_spawnall.Text = "Spawn All Quest Soldiers:";
            // 
            // checkBox_spawnall
            // 
            this.checkBox_spawnall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_spawnall.AutoSize = true;
            this.checkBox_spawnall.Checked = true;
            this.checkBox_spawnall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_spawnall.Location = new System.Drawing.Point(240, 30);
            this.checkBox_spawnall.Name = "checkBox_spawnall";
            this.checkBox_spawnall.Size = new System.Drawing.Size(15, 14);
            this.checkBox_spawnall.TabIndex = 2;
            this.checkBox_spawnall.UseVisualStyleBackColor = true;
            this.checkBox_spawnall.Click += new System.EventHandler(this.checkbox_spawnAll_Click);
            // 
            // label_subtype
            // 
            this.label_subtype.AutoSize = true;
            this.label_subtype.Location = new System.Drawing.Point(14, 6);
            this.label_subtype.Name = "label_subtype";
            this.label_subtype.Size = new System.Drawing.Size(88, 13);
            this.label_subtype.TabIndex = 6;
            this.label_subtype.Text = "Soldier SubType:";
            // 
            // comboBox_subtype
            // 
            this.comboBox_subtype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_subtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_subtype.FormattingEnabled = true;
            this.comboBox_subtype.Location = new System.Drawing.Point(108, 3);
            this.comboBox_subtype.Name = "comboBox_subtype";
            this.comboBox_subtype.Size = new System.Drawing.Size(147, 21);
            this.comboBox_subtype.TabIndex = 7;
            this.comboBox_subtype.SelectedIndexChanged += new System.EventHandler(this.comboBox_subtype_SelectedIndexChanged);
            // 
            // groupAnimalDet
            // 
            this.groupAnimalDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupAnimalDet.Controls.Add(this.panelAnimalDet);
            this.groupAnimalDet.Location = new System.Drawing.Point(1081, 3);
            this.groupAnimalDet.Name = "groupAnimalDet";
            this.groupAnimalDet.Size = new System.Drawing.Size(264, 449);
            this.groupAnimalDet.TabIndex = 20;
            this.groupAnimalDet.TabStop = false;
            this.groupAnimalDet.Text = "Animals";
            // 
            // panelAnimalDet
            // 
            this.panelAnimalDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimalDet.AutoScroll = true;
            this.panelAnimalDet.Location = new System.Drawing.Point(3, 16);
            this.panelAnimalDet.Name = "panelAnimalDet";
            this.panelAnimalDet.Size = new System.Drawing.Size(258, 424);
            this.panelAnimalDet.TabIndex = 0;
            this.panelAnimalDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // groupVehDet
            // 
            this.groupVehDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupVehDet.Controls.Add(this.panelVehDet);
            this.groupVehDet.Location = new System.Drawing.Point(812, 3);
            this.groupVehDet.Name = "groupVehDet";
            this.groupVehDet.Size = new System.Drawing.Size(264, 449);
            this.groupVehDet.TabIndex = 12;
            this.groupVehDet.TabStop = false;
            this.groupVehDet.Text = "Heavy Vehicles";
            // 
            // panelVehDet
            // 
            this.panelVehDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVehDet.AutoScroll = true;
            this.panelVehDet.Location = new System.Drawing.Point(3, 16);
            this.panelVehDet.Name = "panelVehDet";
            this.panelVehDet.Size = new System.Drawing.Size(258, 424);
            this.panelVehDet.TabIndex = 0;
            this.panelVehDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // groupStMdDet
            // 
            this.groupStMdDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupStMdDet.Controls.Add(this.panelStMdDet);
            this.groupStMdDet.Location = new System.Drawing.Point(1888, 3);
            this.groupStMdDet.Name = "groupStMdDet";
            this.groupStMdDet.Size = new System.Drawing.Size(264, 449);
            this.groupStMdDet.TabIndex = 31;
            this.groupStMdDet.TabStop = false;
            this.groupStMdDet.Text = "Static Models";
            // 
            // panelStMdDet
            // 
            this.panelStMdDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStMdDet.AutoScroll = true;
            this.panelStMdDet.Location = new System.Drawing.Point(3, 16);
            this.panelStMdDet.Name = "panelStMdDet";
            this.panelStMdDet.Size = new System.Drawing.Size(258, 424);
            this.panelStMdDet.TabIndex = 0;
            this.panelStMdDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // groupItemDet
            // 
            this.groupItemDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupItemDet.Controls.Add(this.panelItemDet);
            this.groupItemDet.Location = new System.Drawing.Point(1351, 3);
            this.groupItemDet.Name = "groupItemDet";
            this.groupItemDet.Size = new System.Drawing.Size(264, 449);
            this.groupItemDet.TabIndex = 29;
            this.groupItemDet.TabStop = false;
            this.groupItemDet.Text = "Dormant Items";
            // 
            // panelItemDet
            // 
            this.panelItemDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelItemDet.AutoScroll = true;
            this.panelItemDet.Location = new System.Drawing.Point(3, 16);
            this.panelItemDet.Name = "panelItemDet";
            this.panelItemDet.Size = new System.Drawing.Size(258, 424);
            this.panelItemDet.TabIndex = 0;
            this.panelItemDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // groupHosDet
            // 
            this.groupHosDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupHosDet.Controls.Add(this.panelHosDet);
            this.groupHosDet.Location = new System.Drawing.Point(543, 3);
            this.groupHosDet.Name = "groupHosDet";
            this.groupHosDet.Size = new System.Drawing.Size(264, 449);
            this.groupHosDet.TabIndex = 1;
            this.groupHosDet.TabStop = false;
            this.groupHosDet.Text = "Prisoners";
            // 
            // panelHosDet
            // 
            this.panelHosDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHosDet.AutoScroll = true;
            this.panelHosDet.Controls.Add(this.h_label_intrgt);
            this.panelHosDet.Controls.Add(this.h_checkBox_intrgt);
            this.panelHosDet.Controls.Add(this.comboBox_Body);
            this.panelHosDet.Controls.Add(this.label_Body);
            this.panelHosDet.Location = new System.Drawing.Point(3, 16);
            this.panelHosDet.Name = "panelHosDet";
            this.panelHosDet.Size = new System.Drawing.Size(258, 424);
            this.panelHosDet.TabIndex = 0;
            this.panelHosDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // h_label_intrgt
            // 
            this.h_label_intrgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.h_label_intrgt.AutoSize = true;
            this.h_label_intrgt.Location = new System.Drawing.Point(88, 30);
            this.h_label_intrgt.Name = "h_label_intrgt";
            this.h_label_intrgt.Size = new System.Drawing.Size(146, 13);
            this.h_label_intrgt.TabIndex = 0;
            this.h_label_intrgt.Text = "Interrogate For Whereabouts:";
            // 
            // h_checkBox_intrgt
            // 
            this.h_checkBox_intrgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.h_checkBox_intrgt.AutoSize = true;
            this.h_checkBox_intrgt.Location = new System.Drawing.Point(240, 30);
            this.h_checkBox_intrgt.Name = "h_checkBox_intrgt";
            this.h_checkBox_intrgt.Size = new System.Drawing.Size(15, 14);
            this.h_checkBox_intrgt.TabIndex = 0;
            this.h_checkBox_intrgt.UseVisualStyleBackColor = true;
            // 
            // comboBox_Body
            // 
            this.comboBox_Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Body.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Body.FormattingEnabled = true;
            this.comboBox_Body.Location = new System.Drawing.Point(81, 3);
            this.comboBox_Body.Name = "comboBox_Body";
            this.comboBox_Body.Size = new System.Drawing.Size(174, 21);
            this.comboBox_Body.TabIndex = 1;
            this.comboBox_Body.SelectedIndexChanged += new System.EventHandler(this.comboBox_Body_SelectedIndexChanged);
            // 
            // label_Body
            // 
            this.label_Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Body.AutoSize = true;
            this.label_Body.Location = new System.Drawing.Point(41, 6);
            this.label_Body.Name = "label_Body";
            this.label_Body.Size = new System.Drawing.Size(34, 13);
            this.label_Body.TabIndex = 2;
            this.label_Body.Text = "Body:";
            // 
            // originAnchor
            // 
            this.originAnchor.AutoSize = true;
            this.originAnchor.Location = new System.Drawing.Point(0, 0);
            this.originAnchor.Name = "originAnchor";
            this.originAnchor.Size = new System.Drawing.Size(0, 13);
            this.originAnchor.TabIndex = 34;
            // 
            // Details
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelDetails);
            this.Name = "Details";
            this.Size = new System.Drawing.Size(2169, 452);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.groupActiveItemDet.ResumeLayout(false);
            this.groupExistingEneDet.ResumeLayout(false);
            this.panelCPEnemyDet.ResumeLayout(false);
            this.panelCPEnemyDet.PerformLayout();
            this.groupNewEneDet.ResumeLayout(false);
            this.panelQuestEnemyDet.ResumeLayout(false);
            this.panelQuestEnemyDet.PerformLayout();
            this.groupAnimalDet.ResumeLayout(false);
            this.groupVehDet.ResumeLayout(false);
            this.groupStMdDet.ResumeLayout(false);
            this.groupItemDet.ResumeLayout(false);
            this.groupHosDet.ResumeLayout(false);
            this.panelHosDet.ResumeLayout(false);
            this.panelHosDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetails;
        public System.Windows.Forms.GroupBox groupHosDet;
        private System.Windows.Forms.Label label_Body;
        public System.Windows.Forms.ComboBox comboBox_Body;
        public System.Windows.Forms.GroupBox groupItemDet;
        private System.Windows.Forms.Panel panelItemDet;
        public System.Windows.Forms.GroupBox groupVehDet;
        public System.Windows.Forms.GroupBox groupStMdDet;
        private System.Windows.Forms.Panel panelStMdDet;
        private Panel panelAnimalDet;
        private Label h_label_intrgt;
        public CheckBox h_checkBox_intrgt;
        private Panel panelAcItDet;
        public GroupBox groupAnimalDet;
        public Panel panelHosDet;
        public Panel panelVehDet;
        public GroupBox groupNewEneDet;
        public Panel panelQuestEnemyDet;
        public GroupBox groupExistingEneDet;
        public Panel panelCPEnemyDet;
        private ComboBox comboBox_subtype;
        private Label label_subtype;
        private Label label_customizeall;
        public CheckBox checkBox_customizeall;
        private Label label_spawnall;
        public CheckBox checkBox_spawnall;
        private Label label_subtype2;
        private ComboBox comboBox_subtype2;
        private GroupBox groupActiveItemDet;
        private Label originAnchor;
    }
}