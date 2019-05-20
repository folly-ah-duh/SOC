using SOC.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOC.QuestObjects.ActiveItem
{
    public class ActiveItemBox : QuestBox
    {
        ActiveItem activeitem;

        public GroupBox ai_groupBox_main;
        public CheckBox ai_checkBox_target;
        public Label ai_label_target;
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

        public ActiveItemBox(ActiveItem ai) : base(ai.coordinates, ai.number)
        {
            activeitem = ai;
        }

        public override void SetObject(QuestBox detail)
        {
            ActiveItemBox acItDet = (ActiveItemBox)detail;
            ai_comboBox_activeitem.Text = acItDet.ai_comboBox_activeitem.Text;
        }

        public override void BuildObject()
        {
            int width = 10;
            int comboboxWidth = width - 96;
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
            this.ai_checkBox_target = new CheckBox();
            this.ai_label_target = new Label();
            this.ai_groupBox_main.SuspendLayout();

            this.ai_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.ai_groupBox_main.Controls.Add(this.ai_label_target);
            this.ai_groupBox_main.Controls.Add(this.ai_checkBox_target);
            this.ai_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.ai_groupBox_main.Location = new System.Drawing.Point(3, 27 + (activeitem.number * 134));
            this.ai_groupBox_main.Name = "ai_groupBox_main";
            this.ai_groupBox_main.Size = new System.Drawing.Size(width, 119);
            this.ai_groupBox_main.TabIndex = 0;
            this.ai_groupBox_main.TabStop = false;
            this.ai_groupBox_main.Text = activeitem.name;
            this.ai_groupBox_main.Click += new System.EventHandler(FocusGroupBox);
            // 
            // i_checkBox_target
            // 
            this.ai_checkBox_target.Location = new System.Drawing.Point(84, 66);
            this.ai_checkBox_target.Name = "i_checkBox_target";
            this.ai_checkBox_target.Size = new System.Drawing.Size(17, 18);
            this.ai_checkBox_target.UseVisualStyleBackColor = true;
            ai_checkBox_target.Checked = activeitem.isTarget;
            this.ai_label_target.AutoSize = true;
            this.ai_label_target.Location = new System.Drawing.Point(18, 67);
            this.ai_label_target.Name = "i_label_target";
            this.ai_label_target.Size = new System.Drawing.Size(52, 13);
            this.ai_label_target.Text = "Is Target:";
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
            this.ai_textBox_xcoord.Text = activeitem.coordinates.xCoord;
            // 
            // ai_textBox_ycoord
            // 
            this.ai_textBox_ycoord.Location = new System.Drawing.Point(139, 13);
            this.ai_textBox_ycoord.Name = "ai_textBox_ycoord";
            this.ai_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.ai_textBox_ycoord.TabIndex = 2;
            this.ai_textBox_ycoord.Text = activeitem.coordinates.yCoord;
            // 
            // ai_textBox_zcoord
            // 
            this.ai_textBox_zcoord.Location = new System.Drawing.Point(193, 13);
            this.ai_textBox_zcoord.Name = "ai_textBox_zcoord";
            this.ai_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.ai_textBox_zcoord.TabIndex = 3;
            this.ai_textBox_zcoord.Text = activeitem.coordinates.zCoord;
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
            this.ai_textBox_xrot.Text = activeitem.rotation.quatRotation.xval;
            // 
            // ai_textBox_yrot
            // 
            this.ai_textBox_yrot.Location = new System.Drawing.Point(123, 38);
            this.ai_textBox_yrot.Name = "ai_textBox_yrot";
            this.ai_textBox_yrot.Size = new System.Drawing.Size(31, 20);
            this.ai_textBox_yrot.TabIndex = 6;
            this.ai_textBox_yrot.Text = activeitem.rotation.quatRotation.yval;
            // 
            // ai_textBox_zrot
            // 
            this.ai_textBox_zrot.Location = new System.Drawing.Point(163, 39);
            this.ai_textBox_zrot.Name = "ai_textBox_zrot";
            this.ai_textBox_zrot.Size = new System.Drawing.Size(31, 20);
            this.ai_textBox_zrot.TabIndex = 7;
            this.ai_textBox_zrot.Text = activeitem.rotation.quatRotation.zval;
            // 
            // ai_textBox_wrot
            // 
            this.ai_textBox_wrot.Location = new System.Drawing.Point(203, 38);
            this.ai_textBox_wrot.Name = "ai_textBox_wrot";
            this.ai_textBox_wrot.Size = new System.Drawing.Size(31, 20);
            this.ai_textBox_wrot.TabIndex = 8;
            this.ai_textBox_wrot.Text = activeitem.rotation.quatRotation.wval;
            // 
            // ai_label_activeitem
            // 
            this.ai_label_activeitem.AutoSize = true;
            this.ai_label_activeitem.Location = new System.Drawing.Point(7, 92);
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
            this.ai_comboBox_activeitem.Location = new System.Drawing.Point(84, 89);
            this.ai_comboBox_activeitem.Name = "ai_comboBox_activeitem";
            this.ai_comboBox_activeitem.Items.AddRange(ActiveItemNames.activeItems);
            this.ai_comboBox_activeitem.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.ai_comboBox_activeitem.TabIndex = 10;
            this.ai_comboBox_activeitem.Text = activeitem.activeItem;
            ai_comboBox_activeitem.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            this.ai_groupBox_main.ResumeLayout(false);
            this.ai_groupBox_main.PerformLayout();
        }

        public override GroupBox getGroupBoxMain()
        {
            return ai_groupBox_main;
        }
    }
}
