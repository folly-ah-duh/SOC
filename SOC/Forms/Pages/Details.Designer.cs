using SOC.Classes;
using System;
using System.IO;
using System.Windows.Forms;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.UI
{
    public class HostageDetail
    {
        Coordinates hostageCoords;
        int hostageNum;

        public GroupBox h_groupBox_main;
        public Label h_label_rot;
        public Label h_label_coords;
        public Label h_label_skill;
        public Label h_label_staff;
        public Label h_label_lang;
        public Label h_label_untied;
        public Label h_label_scared;
        public Label h_label_injured;
        public TextBox h_textBox_zcoord;
        public TextBox h_textBox_ycoord;
        public CheckBox h_checkBox_target;
        public ComboBox h_comboBox_rot;
        public TextBox h_textBox_xcoord;
        public Label h_label_target;
        public ComboBox h_comboBox_skill;
        public ComboBox h_comboBox_staff;
        public ComboBox h_comboBox_lang;
        public ComboBox h_comboBox_scared;
        public CheckBox h_checkBox_injured;
        public CheckBox h_checkBox_untied;

        public HostageDetail(Coordinates hcoord, int hnum)
        {
            hostageCoords = hcoord;
            hostageNum = hnum;
        }

        public void BuildDetail()
        {
            this.h_groupBox_main = new System.Windows.Forms.GroupBox();
            this.h_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.h_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.h_checkBox_target = new System.Windows.Forms.CheckBox();
            this.h_comboBox_rot = new System.Windows.Forms.ComboBox();
            this.h_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.h_label_target = new System.Windows.Forms.Label();
            this.h_label_rot = new System.Windows.Forms.Label();
            this.h_label_coords = new System.Windows.Forms.Label();
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
            this.h_groupBox_main.Controls.Add(this.h_comboBox_rot);
            this.h_groupBox_main.Controls.Add(this.h_textBox_xcoord);
            this.h_groupBox_main.Controls.Add(this.h_label_target);
            this.h_groupBox_main.Controls.Add(this.h_label_rot);
            this.h_groupBox_main.Controls.Add(this.h_label_coords);

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
            this.h_groupBox_main.Location = new System.Drawing.Point(4, 55 + (253 * hostageNum));
            this.h_groupBox_main.Name = "h_groupBox_main";
            this.h_groupBox_main.Size = new System.Drawing.Size(245, 236);
            this.h_groupBox_main.TabStop = false;
            this.h_groupBox_main.TabIndex = 1;
            this.h_groupBox_main.Text = "Hostage_" + hostageNum;
            // 
            // h_textBox_coord
            // 
            this.h_textBox_xcoord.Location = new System.Drawing.Point(84, 14);
            this.h_textBox_xcoord.Name = "h_textBox_xcoord";
            this.h_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.h_textBox_xcoord.TabIndex = 2;
            this.h_textBox_xcoord.Text = hostageCoords.xCoord;

            this.h_textBox_ycoord.Location = new System.Drawing.Point(139, 14);
            this.h_textBox_ycoord.Name = "h_textBox_ycoord";
            this.h_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.h_textBox_ycoord.TabIndex = 3;
            this.h_textBox_ycoord.Text = hostageCoords.yCoord;

            this.h_textBox_zcoord.Location = new System.Drawing.Point(193, 14);
            this.h_textBox_zcoord.Name = "h_textBox_zcoord";
            this.h_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.h_textBox_zcoord.TabIndex = 4;
            this.h_textBox_zcoord.Text = hostageCoords.zCoord;

            this.h_label_coords.AutoSize = true;
            this.h_label_coords.Location = new System.Drawing.Point(4, 17);
            this.h_label_coords.Name = "h_label_coords";
            this.h_label_coords.Size = new System.Drawing.Size(66, 13);
            this.h_label_coords.Text = "Coordinates:";
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
            // h_comboBox_rot
            // 
            this.h_comboBox_rot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.h_comboBox_rot.FormattingEnabled = true;
            this.h_comboBox_rot.Location = new System.Drawing.Point(84, 39);
            this.h_comboBox_rot.Items.AddRange(new string[] {
            "0",
            "45",
            "90",
            "135",
            "180",
            "225",
            "270",
            "315"
            });
            this.h_comboBox_rot.Name = "h_comboBox_rot";
            this.h_comboBox_rot.Size = new System.Drawing.Size(150, 21);
            this.h_comboBox_rot.TabIndex = 5;
            this.h_comboBox_rot.Text = hostageCoords.roty;
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
            this.h_comboBox_scared.Size = new System.Drawing.Size(150, 21);
            this.h_comboBox_scared.TabIndex = 7;
            this.h_comboBox_scared.Text = "NORMAL";
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
            this.h_comboBox_lang.Size = new System.Drawing.Size(150, 21);
            this.h_comboBox_lang.TabIndex = 9;
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
            this.h_comboBox_staff.Size = new System.Drawing.Size(150, 21);
            this.h_comboBox_staff.TabIndex = 10;
            this.h_comboBox_staff.Text = "NONE";
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
            this.h_comboBox_skill.Size = new System.Drawing.Size(150, 21);
            this.h_comboBox_skill.TabIndex = 11;
            this.h_comboBox_skill.Text = "NONE";
            this.h_label_skill.AutoSize = true;
            this.h_label_skill.Location = new System.Drawing.Point(41, 199);
            this.h_label_skill.Name = "h_label_skill";
            this.h_label_skill.Size = new System.Drawing.Size(29, 13);
            this.h_label_skill.Text = "Skill:";

            this.h_groupBox_main.ResumeLayout(false);
            this.h_groupBox_main.PerformLayout();
        }
    }
    public class VehicleDetail
    {
        Coordinates vehicleCoords;
        int VehicleNum;

        public GroupBox v_groupBox_main;
        public TextBox v_textBox_zcoord;
        public TextBox v_textBox_ycoord;
        public CheckBox v_checkBox_target;
        public ComboBox v_comboBox_rot;
        public TextBox v_textBox_xcoord;
        public Label v_label_target;
        public Label v_label_rot;
        public Label v_label_coords;
        public ComboBox v_comboBox_class;
        public ComboBox v_comboBox_vehicle;
        public Label v_label_class;
        public Label v_label_vehicle;

        public VehicleDetail(Coordinates vehcoords, int vehnum)
        {
            vehicleCoords = vehcoords;
            VehicleNum = vehnum;
        }
        public void BuildDetail()
        {
            this.v_groupBox_main = new System.Windows.Forms.GroupBox();
            this.v_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.v_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.v_checkBox_target = new System.Windows.Forms.CheckBox();
            this.v_comboBox_rot = new System.Windows.Forms.ComboBox();
            this.v_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.v_label_target = new System.Windows.Forms.Label();
            this.v_label_rot = new System.Windows.Forms.Label();
            this.v_label_coords = new System.Windows.Forms.Label();
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
            this.v_groupBox_main.Controls.Add(this.v_comboBox_rot);
            this.v_groupBox_main.Controls.Add(this.v_textBox_xcoord);
            this.v_groupBox_main.Controls.Add(this.v_label_target);
            this.v_groupBox_main.Controls.Add(this.v_label_rot);
            this.v_groupBox_main.Controls.Add(this.v_label_coords);
            this.v_groupBox_main.Controls.Add(this.v_comboBox_class);
            this.v_groupBox_main.Controls.Add(this.v_comboBox_vehicle);
            this.v_groupBox_main.Controls.Add(this.v_label_class);
            this.v_groupBox_main.Controls.Add(this.v_label_vehicle);
            this.v_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.v_groupBox_main.Location = new System.Drawing.Point(3, 4 + (170 * VehicleNum));
            this.v_groupBox_main.Name = "v_groupBox_main";
            this.v_groupBox_main.Size = new System.Drawing.Size(252, 140);
            this.v_groupBox_main.TabIndex = 1;
            this.v_groupBox_main.TabStop = false;
            this.v_groupBox_main.Text = "Vehicle_" + VehicleNum;
            // 
            // v_textBox_zcoord
            // 
            this.v_label_coords.AutoSize = true;
            this.v_label_coords.Location = new System.Drawing.Point(4, 17);
            this.v_label_coords.Name = "v_label_coords";
            this.v_label_coords.Size = new System.Drawing.Size(66, 13);
            this.v_label_coords.TabIndex = 6;
            this.v_label_coords.Text = "Coordinates:";

            this.v_textBox_xcoord.Location = new System.Drawing.Point(78, 14);
            this.v_textBox_xcoord.Name = "v_textBox_xcoord";
            this.v_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.v_textBox_xcoord.TabIndex = 2;
            this.v_textBox_xcoord.Text = vehicleCoords.xCoord;

            this.v_textBox_ycoord.Location = new System.Drawing.Point(133, 14);
            this.v_textBox_ycoord.Name = "v_textBox_ycoord";
            this.v_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.v_textBox_ycoord.TabIndex = 3;
            this.v_textBox_ycoord.Text = vehicleCoords.yCoord;

            this.v_textBox_zcoord.Location = new System.Drawing.Point(187, 14);
            this.v_textBox_zcoord.Name = "v_textBox_zcoord";
            this.v_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.v_textBox_zcoord.TabIndex = 4;
            this.v_textBox_zcoord.Text = vehicleCoords.zCoord;
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
            // v_comboBox_rot
            // 
            this.v_comboBox_rot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_comboBox_rot.FormattingEnabled = true;
            this.v_comboBox_rot.Location = new System.Drawing.Point(78, 39);
            this.v_comboBox_rot.Items.AddRange(new string[] {
            "0",
            "45",
            "90",
            "135",
            "180",
            "225",
            "270",
            "315"
            });
            this.v_comboBox_rot.Name = "v_comboBox_rot";
            this.v_comboBox_rot.Size = new System.Drawing.Size(150, 21);
            this.v_comboBox_rot.TabIndex = 5;
            this.v_comboBox_rot.Text = vehicleCoords.roty;

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
            this.v_comboBox_class.Items.AddRange(new object[] {
                "DEFAULT","DARK_GRAY","OXIDE_RED"
            });
            this.v_comboBox_class.Name = "v_comboBox_class";
            this.v_comboBox_class.Size = new System.Drawing.Size(150, 21);
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
            this.v_comboBox_vehicle.Size = new System.Drawing.Size(150, 21);
            this.v_comboBox_vehicle.TabIndex = 7;
            this.v_comboBox_vehicle.Text = "TT77 NOSOROG";
            this.v_label_vehicle.AutoSize = true;
            this.v_label_vehicle.Location = new System.Drawing.Point(25, 94);
            this.v_label_vehicle.Name = "v_label_vehicle";
            this.v_label_vehicle.Size = new System.Drawing.Size(45, 13);
            this.v_label_vehicle.Text = "Vehicle:";
            
            

            this.v_groupBox_main.ResumeLayout(false);
            this.v_groupBox_main.PerformLayout();
        }
    }
    public class ItemDetail
    {
        Coordinates itemCoords;
        int itemNum;
        double quatNum = 0;

        public GroupBox i_groupBox_main;
        public TextBox i_textBox_zcoord;
        public TextBox i_textBox_ycoord;
        public TextBox i_textBox_zrot;
        public TextBox i_textBox_yrot;
        public TextBox i_textBox_xrot;
        public TextBox i_textBox_wrot;
        public TextBox i_textBox_xcoord;
        public Label i_label_rot;
        public Label i_label_coords;
        public ComboBox i_comboBox_count;
        public CheckBox i_checkBox_boxed;
        public Label i_label_boxed;
        public ComboBox i_comboBox_item;
        public Label i_label_count;
        public Label i_label_item;

        public ItemDetail(Coordinates itcoords, int inum)
        {
            itemCoords = itcoords;
            itemNum = inum;
            Double.TryParse(itemCoords.roty, out quatNum);
            quatNum = quatNum * Math.PI / 360;
        }

        public void BuildDetail()
        {
            this.i_groupBox_main = new System.Windows.Forms.GroupBox();
            this.i_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.i_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.i_textBox_xrot = new System.Windows.Forms.TextBox();
            this.i_textBox_yrot = new System.Windows.Forms.TextBox();
            this.i_textBox_zrot = new System.Windows.Forms.TextBox();
            this.i_textBox_wrot = new System.Windows.Forms.TextBox();
            this.i_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.i_label_rot = new System.Windows.Forms.Label();
            this.i_label_coords = new System.Windows.Forms.Label();
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
            this.i_groupBox_main.Controls.Add(this.i_label_coords);
            this.i_groupBox_main.Controls.Add(this.i_comboBox_count);
            this.i_groupBox_main.Controls.Add(this.i_checkBox_boxed);
            this.i_groupBox_main.Controls.Add(this.i_label_boxed);
            this.i_groupBox_main.Controls.Add(this.i_comboBox_item);
            this.i_groupBox_main.Controls.Add(this.i_label_count);
            this.i_groupBox_main.Controls.Add(this.i_label_item);

            this.i_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.i_groupBox_main.Location = new System.Drawing.Point(3, 3 + (171 * itemNum));
            this.i_groupBox_main.Name = "i_groupBox_main";
            this.i_groupBox_main.Size = new System.Drawing.Size(252, 150);
            this.i_groupBox_main.TabIndex = 1;
            this.i_groupBox_main.TabStop = false;
            this.i_groupBox_main.Text = "Item_" + itemNum;
            // 
            // i_textBox_zcoord
            // 
            this.i_label_coords.AutoSize = true;
            this.i_label_coords.Location = new System.Drawing.Point(4, 17);
            this.i_label_coords.Name = "i_label_coords";
            this.i_label_coords.Size = new System.Drawing.Size(66, 13);
            this.i_label_coords.TabIndex = 6;
            this.i_label_coords.Text = "Coordinates:";

            this.i_textBox_xcoord.Location = new System.Drawing.Point(78, 14);
            this.i_textBox_xcoord.Name = "i_textBox_xcoord";
            this.i_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.i_textBox_xcoord.TabIndex = 2;
            this.i_textBox_xcoord.Text = itemCoords.xCoord;

            this.i_textBox_ycoord.Location = new System.Drawing.Point(133, 14);
            this.i_textBox_ycoord.Name = "i_textBox_ycoord";
            this.i_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.i_textBox_ycoord.TabIndex = 3;
            this.i_textBox_ycoord.Text = itemCoords.yCoord;

            this.i_textBox_zcoord.Location = new System.Drawing.Point(187, 14);
            this.i_textBox_zcoord.Name = "i_textBox_zcoord";
            this.i_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.i_textBox_zcoord.TabIndex = 4;
            this.i_textBox_zcoord.Text = itemCoords.zCoord;

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
            this.i_textBox_xrot.Name = "m_textBox_xrocoords";
            this.i_textBox_xrot.Size = new System.Drawing.Size(31, 20);
            this.i_textBox_xrot.TabIndex = 5;
            this.i_textBox_xrot.Text = "0";
            this.i_textBox_yrot.Location = new System.Drawing.Point(117, 39);
            this.i_textBox_yrot.Name = "m_textBox_yrocoords";
            this.i_textBox_yrot.Size = new System.Drawing.Size(31, 20);
            this.i_textBox_yrot.TabIndex = 6;
            this.i_textBox_yrot.Text = Math.Sin(quatNum).ToString();
            this.i_textBox_zrot.Location = new System.Drawing.Point(157, 39);
            this.i_textBox_zrot.Name = "m_textBox_zrocoords";
            this.i_textBox_zrot.Size = new System.Drawing.Size(31, 20);
            this.i_textBox_zrot.TabIndex = 7;
            this.i_textBox_zrot.Text = "0";
            this.i_textBox_wrot.Location = new System.Drawing.Point(197, 39);
            this.i_textBox_wrot.Name = "m_textBox_wrocoords";
            this.i_textBox_wrot.Size = new System.Drawing.Size(31, 20);
            this.i_textBox_wrot.TabIndex = 8;
            this.i_textBox_wrot.Text = Math.Cos(quatNum).ToString();
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
            this.i_comboBox_count.Size = new System.Drawing.Size(150, 21);
            this.i_comboBox_count.TabIndex = 8;
            this.i_comboBox_count.Text = i_comboBox_count.Items[0].ToString();
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
            this.i_checkBox_boxed.TabIndex = 9;
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
            this.i_comboBox_item.Size = new System.Drawing.Size(150, 21);
            this.i_comboBox_item.TabIndex = 7;
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
    }
    public class ModelDetail
    {
        Coordinates StMdCoords;
        int StMdNum;
        double quatNum = 0;
        
        public string modelAssetsPath = AssetsBuilder.modelAssetsPath;
        public GroupBox m_groupBox_main;
        public TextBox m_textBox_zcoords;
        public TextBox m_textBox_ycoords;
        public TextBox m_textBox_xcoords;
        public Label m_label_preset;
        public TextBox m_textBox_zrot;
        public TextBox m_textBox_yrot;
        public TextBox m_textBox_xrot;
        public TextBox m_textBox_wrot;
        public ComboBox m_comboBox_preset;
        public Label m_label_rot;
        public Label m_label_coords;
        public Label m_label_GeomNotFound;

        public ModelDetail(Coordinates StMdC, int StMdN)
        {
            StMdCoords = StMdC;
            StMdNum = StMdN;
            Double.TryParse(StMdC.roty, out quatNum);
            quatNum = quatNum * Math.PI / 360;
        }

        public void BuildDetail()
        {

            this.m_groupBox_main = new System.Windows.Forms.GroupBox();
            this.m_textBox_zcoords = new System.Windows.Forms.TextBox();
            this.m_textBox_ycoords = new System.Windows.Forms.TextBox();
            this.m_textBox_xcoords = new System.Windows.Forms.TextBox();
            this.m_label_preset = new System.Windows.Forms.Label();
            this.m_textBox_xrot = new System.Windows.Forms.TextBox();
            this.m_textBox_yrot = new System.Windows.Forms.TextBox();
            this.m_textBox_zrot = new System.Windows.Forms.TextBox();
            this.m_textBox_wrot = new System.Windows.Forms.TextBox();
            this.m_comboBox_preset = new System.Windows.Forms.ComboBox();
            this.m_label_rot = new System.Windows.Forms.Label();
            this.m_label_coords = new System.Windows.Forms.Label();
            this.m_label_GeomNotFound = new System.Windows.Forms.Label();
            this.m_groupBox_main.SuspendLayout();

            // 
            // m_groupBox_main
            // 
            this.m_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_groupBox_main.AutoSize = true;
            this.m_groupBox_main.Controls.Add(this.m_textBox_zcoords);
            this.m_groupBox_main.Controls.Add(this.m_textBox_ycoords);
            this.m_groupBox_main.Controls.Add(this.m_textBox_xcoords);
            this.m_groupBox_main.Controls.Add(this.m_label_rot);
            this.m_groupBox_main.Controls.Add(this.m_label_coords);
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
            this.m_groupBox_main.Size = new System.Drawing.Size(252, 95);
            this.m_groupBox_main.TabIndex = 1;
            this.m_groupBox_main.TabStop = false;
            this.m_groupBox_main.Text = "Model_" + StMdNum;
            // 
            // m_textBox_zcoords
            // 
            this.m_textBox_zcoords.Location = new System.Drawing.Point(193, 14);
            this.m_textBox_zcoords.Name = "m_textBox_zcoords";
            this.m_textBox_zcoords.Size = new System.Drawing.Size(41, 20);
            this.m_textBox_zcoords.TabIndex = 4;
            this.m_textBox_zcoords.Text = StMdCoords.zCoord;
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
            // m_textBox_ycoords
            // 
            this.m_textBox_ycoords.Location = new System.Drawing.Point(139, 14);
            this.m_textBox_ycoords.Name = "m_textBox_ycoords";
            this.m_textBox_ycoords.Size = new System.Drawing.Size(41, 20);
            this.m_textBox_ycoords.TabIndex = 3;
            this.m_textBox_ycoords.Text = StMdCoords.yCoord;
            // 
            // m_comboBox_rot
            // 
            //this.m_comboBox_rot.FormattingEnabled = true;
            //this.m_comboBox_rot.Location = new System.Drawing.Point(84, 39);
            //this.m_comboBox_rot.Name = "m_comboBox_rot";
            //this.m_comboBox_rot.Size = new System.Drawing.Size(150, 21);
            //this.m_comboBox_rot.TabIndex = 12;
            //this.m_comboBox_rot.Items.AddRange(QuestComponents.rotation);
            // 
            // m_textBox_xcoords
            // 
            this.m_textBox_xcoords.Location = new System.Drawing.Point(84, 14);
            this.m_textBox_xcoords.Name = "m_textBox_xcoords";
            this.m_textBox_xcoords.Size = new System.Drawing.Size(41, 20);
            this.m_textBox_xcoords.TabIndex = 2;
            this.m_textBox_xcoords.Text = StMdCoords.xCoord;
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
            this.m_textBox_xrot.Name = "m_textBox_xrocoords";
            this.m_textBox_xrot.Size = new System.Drawing.Size(31, 20);
            this.m_textBox_xrot.TabIndex = 5;
            this.m_textBox_xrot.Text = "0";
            this.m_textBox_yrot.Location = new System.Drawing.Point(123, 39);
            this.m_textBox_yrot.Name = "m_textBox_yrocoords";
            this.m_textBox_yrot.Size = new System.Drawing.Size(31, 20);
            this.m_textBox_yrot.TabIndex = 6;
            this.m_textBox_yrot.Text = Math.Sin(quatNum).ToString();
            this.m_textBox_zrot.Location = new System.Drawing.Point(163, 39);
            this.m_textBox_zrot.Name = "m_textBox_zrocoords";
            this.m_textBox_zrot.Size = new System.Drawing.Size(31, 20);
            this.m_textBox_zrot.TabIndex = 7;
            this.m_textBox_zrot.Text = "0";
            this.m_textBox_wrot.Location = new System.Drawing.Point(203, 39);
            this.m_textBox_wrot.Name = "m_textBox_wrocoords";
            this.m_textBox_wrot.Size = new System.Drawing.Size(31, 20);
            this.m_textBox_wrot.TabIndex = 8;
            this.m_textBox_wrot.Text = Math.Cos(quatNum).ToString();
            // 
            // m_label_coords
            // 
            this.m_label_coords.AutoSize = true;
            this.m_label_coords.Location = new System.Drawing.Point(4, 17);
            this.m_label_coords.Name = "m_label_coords";
            this.m_label_coords.Size = new System.Drawing.Size(66, 13);
            this.m_label_coords.TabIndex = 6;
            this.m_label_coords.Text = "Coordinates:";

            this.m_comboBox_preset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_comboBox_preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBox_preset.FormattingEnabled = true;
            this.m_comboBox_preset.Location = new System.Drawing.Point(84, 66);
            this.m_comboBox_preset.Items.AddRange(getPresetModelList());
            this.m_comboBox_preset.Name = "m_comboBox_preset";
            this.m_comboBox_preset.Size = new System.Drawing.Size(150, 21);
            this.m_comboBox_preset.TabIndex = 7;
            this.m_comboBox_preset.SelectedIndexChanged += new System.EventHandler(this.m_comboBox_preset_selectedIndexChanged);
            this.m_comboBox_preset.SelectedIndex = 0;

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
    }

    public class ActiveItemDetail
    {
        Coordinates activeItemCoords;
        int activeItemNum;
        double quatNum;

        public GroupBox ai_groupBox_main;
        public TextBox ai_textBox_zcoord;
        public TextBox ai_textBox_ycoord;
        public TextBox ai_textBox_xcoord;
        public Label ai_label_coords;
        public Label ai_label_Rot;
        public ComboBox ai_comboBox_activeitem;
        public Label ai_label_activeitem;
        public TextBox ai_textBox_wrot;
        public TextBox ai_textBox_zrot;
        public TextBox ai_textBox_yrot;
        public TextBox ai_textBox_xrot;

        public ActiveItemDetail(Coordinates AcItCoord, int AcItN)
        {
            activeItemCoords = AcItCoord;
            activeItemNum = AcItN;
            Double.TryParse(activeItemCoords.roty, out quatNum);
            quatNum = quatNum * Math.PI / 360;

        }
        public void BuildDetail()
        {
            this.ai_groupBox_main = new System.Windows.Forms.GroupBox();
            this.ai_label_coords = new System.Windows.Forms.Label();
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
            this.ai_groupBox_main.Controls.Add(this.ai_label_coords);
            this.ai_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.ai_groupBox_main.Location = new System.Drawing.Point(3, 3 + (activeItemNum * 118));
            this.ai_groupBox_main.Name = "ai_groupBox_main";
            this.ai_groupBox_main.Size = new System.Drawing.Size(252, 80);
            this.ai_groupBox_main.TabIndex = 0;
            this.ai_groupBox_main.TabStop = false;
            this.ai_groupBox_main.Text = "Active_Item_" + activeItemNum;
            // 
            // ai_label_coords
            // 
            this.ai_label_coords.AutoSize = true;
            this.ai_label_coords.Location = new System.Drawing.Point(4, 17);
            this.ai_label_coords.Name = "ai_label_coords";
            this.ai_label_coords.Size = new System.Drawing.Size(66, 13);
            this.ai_label_coords.TabIndex = 0;
            this.ai_label_coords.Text = "Coordinates:";
            // 
            // ai_textBox_xcoord
            // 
            this.ai_textBox_xcoord.Location = new System.Drawing.Point(84, 13);
            this.ai_textBox_xcoord.Name = "ai_textBox_xcoord";
            this.ai_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.ai_textBox_xcoord.TabIndex = 1;
            this.ai_textBox_xcoord.Text = activeItemCoords.xCoord;
            // 
            // ai_textBox_ycoord
            // 
            this.ai_textBox_ycoord.Location = new System.Drawing.Point(139, 13);
            this.ai_textBox_ycoord.Name = "ai_textBox_ycoord";
            this.ai_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.ai_textBox_ycoord.TabIndex = 2;
            this.ai_textBox_ycoord.Text = activeItemCoords.yCoord;
            // 
            // ai_textBox_zcoord
            // 
            this.ai_textBox_zcoord.Location = new System.Drawing.Point(193, 13);
            this.ai_textBox_zcoord.Name = "ai_textBox_zcoord";
            this.ai_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.ai_textBox_zcoord.TabIndex = 3;
            this.ai_textBox_zcoord.Text = activeItemCoords.zCoord;
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
            this.ai_textBox_yrot.Text = Math.Sin(quatNum).ToString();
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
            this.ai_textBox_wrot.Text = Math.Cos(quatNum).ToString();
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
            this.ai_comboBox_activeitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ai_comboBox_activeitem.FormattingEnabled = true;
            this.ai_comboBox_activeitem.Location = new System.Drawing.Point(84, 65);
            this.ai_comboBox_activeitem.Name = "ai_comboBox_activeitem";
            this.ai_comboBox_activeitem.Items.AddRange(activeItems);
            this.ai_comboBox_activeitem.Size = new System.Drawing.Size(150, 21);
            this.ai_comboBox_activeitem.TabIndex = 10;
            this.ai_comboBox_activeitem.Text = "EQP_SWP_DMine";

            this.ai_groupBox_main.ResumeLayout(false);
            this.ai_groupBox_main.PerformLayout();
        }
    }

    public class AnimalDetail
    {
        public Coordinates animalCoords;
        int animalNum;

        
        public GroupBox a_groupBox_main;
        public ComboBox a_comboBox_targetcount;
        public Label a_label_targetcount;
        public ComboBox a_comboBox_count;
        public Label a_label_count;
        public ComboBox a_comboBox_animal;
        public Label a_label_animal;
        public CheckBox a_checkBox_isTarget;
        public Label a_label_isTarget;
        public ComboBox a_comboBox_rot;
        public Label a_label_rot;
        public TextBox a_textBox_zcoord;
        public TextBox a_textBox_ycoord;
        public TextBox a_textBox_xcoord;
        public Label a_label_coords;

        public AnimalDetail(Coordinates acoord, int anum)
        {
            animalCoords = acoord;
            animalNum = anum;
        }

        public void BuildDetail()
        {

            this.a_groupBox_main = new System.Windows.Forms.GroupBox();
            this.a_comboBox_targetcount = new System.Windows.Forms.ComboBox();
            this.a_label_targetcount = new System.Windows.Forms.Label();
            this.a_comboBox_count = new System.Windows.Forms.ComboBox();
            this.a_label_count = new System.Windows.Forms.Label();
            this.a_comboBox_animal = new System.Windows.Forms.ComboBox();
            this.a_label_animal = new System.Windows.Forms.Label();
            this.a_checkBox_isTarget = new System.Windows.Forms.CheckBox();
            this.a_label_isTarget = new System.Windows.Forms.Label();
            this.a_comboBox_rot = new System.Windows.Forms.ComboBox();
            this.a_label_rot = new System.Windows.Forms.Label();
            this.a_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.a_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.a_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.a_label_coords = new System.Windows.Forms.Label();
            this.a_groupBox_main.SuspendLayout();

            this.a_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.a_groupBox_main.Controls.Add(this.a_comboBox_targetcount);
            this.a_groupBox_main.Controls.Add(this.a_label_targetcount);
            this.a_groupBox_main.Controls.Add(this.a_comboBox_count);
            this.a_groupBox_main.Controls.Add(this.a_label_count);
            this.a_groupBox_main.Controls.Add(this.a_comboBox_animal);
            this.a_groupBox_main.Controls.Add(this.a_label_animal);
            this.a_groupBox_main.Controls.Add(this.a_checkBox_isTarget);
            this.a_groupBox_main.Controls.Add(this.a_label_isTarget);
            this.a_groupBox_main.Controls.Add(this.a_comboBox_rot);
            this.a_groupBox_main.Controls.Add(this.a_label_rot);
            this.a_groupBox_main.Controls.Add(this.a_textBox_zcoord);
            this.a_groupBox_main.Controls.Add(this.a_textBox_ycoord);
            this.a_groupBox_main.Controls.Add(this.a_textBox_xcoord);
            this.a_groupBox_main.Controls.Add(this.a_label_coords);
            this.a_groupBox_main.Location = new System.Drawing.Point(3, 3 + (animalNum * 180));
            this.a_groupBox_main.Name = "a_groupBox_main";
            this.a_groupBox_main.Size = new System.Drawing.Size(252, 166);
            this.a_groupBox_main.TabIndex = 0;
            this.a_groupBox_main.TabStop = false;
            this.a_groupBox_main.Text = "Animal_Cluster_" + animalNum;
            // 
            // a_comboBox_targetcount
            // 
            this.a_comboBox_targetcount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a_comboBox_targetcount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a_comboBox_targetcount.FormattingEnabled = true;
            this.a_comboBox_targetcount.Location = new System.Drawing.Point(193, 137);
            this.a_comboBox_targetcount.Name = "a_comboBox_targetcount";
            this.a_comboBox_targetcount.Size = new System.Drawing.Size(43, 21);
            this.a_comboBox_targetcount.TabIndex = 13;
            // 
            // a_label_targetcount
            // 
            this.a_label_targetcount.AutoSize = true;
            this.a_label_targetcount.Location = new System.Drawing.Point(115, 141);
            this.a_label_targetcount.Name = "a_label_targetcount";
            this.a_label_targetcount.Size = new System.Drawing.Size(72, 13);
            this.a_label_targetcount.TabIndex = 12;
            this.a_label_targetcount.Text = "Target Count:";
            // 
            // a_comboBox_count
            // 
            this.a_comboBox_count.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a_comboBox_count.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a_comboBox_count.FormattingEnabled = true;
            this.a_comboBox_count.Location = new System.Drawing.Point(84, 108);
            this.a_comboBox_count.Name = "a_comboBox_count";
            this.a_comboBox_count.Size = new System.Drawing.Size(152, 21);
            this.a_comboBox_count.TabIndex = 11;
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
            this.a_comboBox_animal.Name = "a_comboBox_animal";
            this.a_comboBox_animal.Size = new System.Drawing.Size(152, 21);
            this.a_comboBox_animal.TabIndex = 9;
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
            // a_comboBox_rot
            // 
            this.a_comboBox_rot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a_comboBox_rot.FormattingEnabled = true;
            this.a_comboBox_rot.Location = new System.Drawing.Point(84, 48);
            this.a_comboBox_rot.Name = "a_comboBox_rot";
            this.a_comboBox_rot.Size = new System.Drawing.Size(152, 21);
            this.a_comboBox_rot.TabIndex = 5;
            this.a_comboBox_rot.Items.AddRange(new string[] {
            "0",
            "45",
            "90",
            "135",
            "180",
            "225",
            "270",
            "315"
            });
            this.a_comboBox_rot.Text = animalCoords.roty;
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
            // 
            // a_textBox_ycoord
            // 
            this.a_textBox_ycoord.Location = new System.Drawing.Point(139, 22);
            this.a_textBox_ycoord.Name = "a_textBox_ycoord";
            this.a_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.a_textBox_ycoord.TabIndex = 2;
            this.a_textBox_ycoord.Text = animalCoords.yCoord;
            // 
            // a_textBox_xcoord
            // 
            this.a_textBox_xcoord.Location = new System.Drawing.Point(84, 22);
            this.a_textBox_xcoord.Name = "a_textBox_xcoord";
            this.a_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.a_textBox_xcoord.TabIndex = 1;
            this.a_textBox_xcoord.Text = animalCoords.xCoord;
            // 
            // a_label_coords
            // 
            this.a_label_coords.AutoSize = true;
            this.a_label_coords.Location = new System.Drawing.Point(4, 25);
            this.a_label_coords.Name = "a_label_coords";
            this.a_label_coords.Size = new System.Drawing.Size(66, 13);
            this.a_label_coords.TabIndex = 0;
            this.a_label_coords.Text = "Coordinates:";


            this.a_groupBox_main.ResumeLayout(false);
            this.a_groupBox_main.PerformLayout();
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
            this.groupAcItDet = new System.Windows.Forms.GroupBox();
            this.panelAcItDet = new System.Windows.Forms.Panel();
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
            this.panelDetails.SuspendLayout();
            this.groupAcItDet.SuspendLayout();
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
            this.panelDetails.Controls.Add(this.groupAcItDet);
            this.panelDetails.Controls.Add(this.groupAnimalDet);
            this.panelDetails.Controls.Add(this.groupVehDet);
            this.panelDetails.Controls.Add(this.groupStMdDet);
            this.panelDetails.Controls.Add(this.groupItemDet);
            this.panelDetails.Controls.Add(this.groupHosDet);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(1080, 450);
            this.panelDetails.TabIndex = 0;
            // 
            // groupAcItDet
            // 
            this.groupAcItDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupAcItDet.Controls.Add(this.panelAcItDet);
            this.groupAcItDet.Location = new System.Drawing.Point(1081, 3);
            this.groupAcItDet.Name = "groupAcItDet";
            this.groupAcItDet.Size = new System.Drawing.Size(264, 427);
            this.groupAcItDet.TabIndex = 31;
            this.groupAcItDet.TabStop = false;
            this.groupAcItDet.Text = "Active Item Details";
            // 
            // panelAcItDet
            // 
            this.panelAcItDet.AutoScroll = true;
            this.panelAcItDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAcItDet.Location = new System.Drawing.Point(3, 16);
            this.panelAcItDet.Name = "panelAcItDet";
            this.panelAcItDet.Size = new System.Drawing.Size(258, 408);
            this.panelAcItDet.TabIndex = 0;
            // 
            // groupAnimalDet
            // 
            this.groupAnimalDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupAnimalDet.Controls.Add(this.panelAnimalDet);
            this.groupAnimalDet.Location = new System.Drawing.Point(1351, 3);
            this.groupAnimalDet.Name = "groupAnimalDet";
            this.groupAnimalDet.Size = new System.Drawing.Size(264, 427);
            this.groupAnimalDet.TabIndex = 31;
            this.groupAnimalDet.TabStop = false;
            this.groupAnimalDet.Text = "Animal Details";
            // 
            // panelAnimalDet
            // 
            this.panelAnimalDet.AutoScroll = true;
            this.panelAnimalDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnimalDet.Location = new System.Drawing.Point(3, 16);
            this.panelAnimalDet.Name = "panelAnimalDet";
            this.panelAnimalDet.Size = new System.Drawing.Size(258, 408);
            this.panelAnimalDet.TabIndex = 0;
            // 
            // groupVehDet
            // 
            this.groupVehDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupVehDet.Controls.Add(this.panelVehDet);
            this.groupVehDet.Location = new System.Drawing.Point(271, 3);
            this.groupVehDet.Name = "groupVehDet";
            this.groupVehDet.Size = new System.Drawing.Size(264, 427);
            this.groupVehDet.TabIndex = 12;
            this.groupVehDet.TabStop = false;
            this.groupVehDet.Text = "Vehicle Details";
            // 
            // panelVehDet
            // 
            this.panelVehDet.AutoScroll = true;
            this.panelVehDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVehDet.Location = new System.Drawing.Point(3, 16);
            this.panelVehDet.Name = "panelVehDet";
            this.panelVehDet.Size = new System.Drawing.Size(258, 408);
            this.panelVehDet.TabIndex = 0;
            // 
            // groupStMdDet
            // 
            this.groupStMdDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupStMdDet.Controls.Add(this.panelStMdDet);
            this.groupStMdDet.Location = new System.Drawing.Point(811, 3);
            this.groupStMdDet.Name = "groupStMdDet";
            this.groupStMdDet.Size = new System.Drawing.Size(264, 427);
            this.groupStMdDet.TabIndex = 30;
            this.groupStMdDet.TabStop = false;
            this.groupStMdDet.Text = "Static Model Details";
            // 
            // panelStMdDet
            // 
            this.panelStMdDet.AutoScroll = true;
            this.panelStMdDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStMdDet.Location = new System.Drawing.Point(3, 16);
            this.panelStMdDet.Name = "panelStMdDet";
            this.panelStMdDet.Size = new System.Drawing.Size(258, 408);
            this.panelStMdDet.TabIndex = 0;
            // 
            // groupItemDet
            // 
            this.groupItemDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupItemDet.Controls.Add(this.panelItemDet);
            this.groupItemDet.Location = new System.Drawing.Point(541, 3);
            this.groupItemDet.Name = "groupItemDet";
            this.groupItemDet.Size = new System.Drawing.Size(264, 427);
            this.groupItemDet.TabIndex = 20;
            this.groupItemDet.TabStop = false;
            this.groupItemDet.Text = "Item Details";
            // 
            // panelItemDet
            // 
            this.panelItemDet.AutoScroll = true;
            this.panelItemDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelItemDet.Location = new System.Drawing.Point(3, 16);
            this.panelItemDet.Name = "panelItemDet";
            this.panelItemDet.Size = new System.Drawing.Size(258, 408);
            this.panelItemDet.TabIndex = 0;
            // 
            // groupHosDet
            // 
            this.groupHosDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupHosDet.Controls.Add(this.panelHosDet);
            this.groupHosDet.Location = new System.Drawing.Point(4, 3);
            this.groupHosDet.Name = "groupHosDet";
            this.groupHosDet.Size = new System.Drawing.Size(264, 427);
            this.groupHosDet.TabIndex = 1;
            this.groupHosDet.TabStop = false;
            this.groupHosDet.Text = "Hostage Details";
            // 
            // panelHosDet
            // 
            this.panelHosDet.AutoScroll = true;
            this.panelHosDet.Controls.Add(this.h_label_intrgt);
            this.panelHosDet.Controls.Add(this.h_checkBox_intrgt);
            this.panelHosDet.Controls.Add(this.comboBox_Body);
            this.panelHosDet.Controls.Add(this.label_Body);
            this.panelHosDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHosDet.Location = new System.Drawing.Point(3, 16);
            this.panelHosDet.Name = "panelHosDet";
            this.panelHosDet.Size = new System.Drawing.Size(258, 408);
            this.panelHosDet.TabIndex = 0;
            // 
            // h_label_intrgt
            // 
            this.h_label_intrgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.h_label_intrgt.AutoSize = true;
            this.h_label_intrgt.Location = new System.Drawing.Point(78, 30);
            this.h_label_intrgt.Name = "h_label_intrgt";
            this.h_label_intrgt.Size = new System.Drawing.Size(146, 13);
            this.h_label_intrgt.TabIndex = 0;
            this.h_label_intrgt.Text = "Interrogate For Whereabouts:";
            // 
            // h_checkBox_intrgt
            // 
            this.h_checkBox_intrgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.h_checkBox_intrgt.AutoSize = true;
            this.h_checkBox_intrgt.Location = new System.Drawing.Point(230, 30);
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
            this.comboBox_Body.Location = new System.Drawing.Point(88, 3);
            this.comboBox_Body.Name = "comboBox_Body";
            this.comboBox_Body.Size = new System.Drawing.Size(157, 21);
            this.comboBox_Body.TabIndex = 1;
            this.comboBox_Body.SelectedIndexChanged += new System.EventHandler(this.comboBox_Body_SelectedIndexChanged);
            // 
            // label_Body
            // 
            this.label_Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Body.AutoSize = true;
            this.label_Body.Location = new System.Drawing.Point(48, 6);
            this.label_Body.Name = "label_Body";
            this.label_Body.Size = new System.Drawing.Size(34, 13);
            this.label_Body.TabIndex = 2;
            this.label_Body.Text = "Body:";
            // 
            // Details
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelDetails);
            this.Name = "Details";
            this.Size = new System.Drawing.Size(1080, 450);
            this.panelDetails.ResumeLayout(false);
            this.groupAcItDet.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelHosDet;
        private System.Windows.Forms.Label label_Body;
        public System.Windows.Forms.ComboBox comboBox_Body;
        public System.Windows.Forms.GroupBox groupItemDet;
        private System.Windows.Forms.Panel panelItemDet;
        public System.Windows.Forms.GroupBox groupVehDet;
        private System.Windows.Forms.Panel panelVehDet;
        public System.Windows.Forms.GroupBox groupStMdDet;
        private System.Windows.Forms.Panel panelStMdDet;
        private Panel panelAnimalDet;
        private Label h_label_intrgt;
        public CheckBox h_checkBox_intrgt;
        public GroupBox groupAcItDet;
        private Panel panelAcItDet;
        public GroupBox groupAnimalDet;

    }
}