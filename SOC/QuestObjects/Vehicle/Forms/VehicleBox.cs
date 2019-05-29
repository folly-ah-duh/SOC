using SOC.Forms;
using System;
using System.Windows.Forms;
using SOC.QuestObjects.Common;
using SOC.UI;

namespace SOC.QuestObjects.Vehicle
{
    public class VehicleBox : QuestBox
    {

        Vehicle vehicle;

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

        public VehicleBox(Vehicle v)
        {
            vehicle = v;
        }

        public void SetObject(QuestBox detail)
        {
            VehicleBox vehicleDetail = (VehicleBox)detail;
            v_checkBox_target.Checked = vehicleDetail.v_checkBox_target.Checked;
            v_comboBox_class.Text = vehicleDetail.v_comboBox_class.Text;
            v_comboBox_vehicle.Text = vehicleDetail.v_comboBox_vehicle.Text;
        }

        public void BuildObject()
        {
            int width = 6;
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
            this.v_groupBox_main.Location = new System.Drawing.Point(3, 27 + (170 * vehicle.ID));
            this.v_groupBox_main.Name = "v_groupBox_main";
            this.v_groupBox_main.Size = new System.Drawing.Size(width, 152);
            this.v_groupBox_main.TabIndex = 1;
            this.v_groupBox_main.TabStop = false;
            this.v_groupBox_main.Text = vehicle.GetObjectName();
            //this.v_groupBox_main.Click += new System.EventHandler(FocusGroupBox);

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
            this.v_textBox_xcoord.Text = vehicle.position.coords.xCoord;

            this.v_textBox_ycoord.Location = new System.Drawing.Point(133, 14);
            this.v_textBox_ycoord.Name = "v_textBox_ycoord";
            this.v_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.v_textBox_ycoord.TabIndex = 3;
            this.v_textBox_ycoord.Text = vehicle.position.coords.yCoord;

            this.v_textBox_zcoord.Location = new System.Drawing.Point(187, 14);
            this.v_textBox_zcoord.Name = "v_textBox_zcoord";
            this.v_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.v_textBox_zcoord.TabIndex = 4;
            this.v_textBox_zcoord.Text = vehicle.position.coords.zCoord;
            // 
            // v_checkBox_target
            // 
            this.v_checkBox_target.Location = new System.Drawing.Point(78, 66);
            this.v_checkBox_target.Name = "v_checkBox_target";
            this.v_checkBox_target.Size = new System.Drawing.Size(17, 18);
            this.v_checkBox_target.UseVisualStyleBackColor = true;
            v_checkBox_target.Checked = vehicle.isTarget;

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
            this.v_textBox_rot.Text = vehicle.position.rotation.GetDegreeRotY();

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
            //v_comboBox_class.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            this.v_comboBox_class.Items.AddRange(new object[] {
                "DEFAULT","DARK_GRAY","OXIDE_RED"
            });
            this.v_comboBox_class.Name = "v_comboBox_class";
            this.v_comboBox_class.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.v_comboBox_class.TabIndex = 8;
            this.v_comboBox_class.Text = vehicle.vehicleClass;
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
            //v_comboBox_vehicle.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            this.v_comboBox_vehicle.SelectedIndex = vehicle.vehicleIndex;
            this.v_label_vehicle.AutoSize = true;
            this.v_label_vehicle.Location = new System.Drawing.Point(25, 94);
            this.v_label_vehicle.Name = "v_label_vehicle";
            this.v_label_vehicle.Size = new System.Drawing.Size(45, 13);
            this.v_label_vehicle.Text = "Vehicle:";



            this.v_groupBox_main.ResumeLayout(false);
            this.v_groupBox_main.PerformLayout();
        }

        public GroupBox getGroupBoxMain()
        {
            return v_groupBox_main;
        }

        public override QuestObject getQuestObject()
        {
            throw new NotImplementedException();
        }
    }
}
