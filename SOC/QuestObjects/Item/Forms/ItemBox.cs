using SOC.Forms;
using System;
using System.Windows.Forms;

namespace SOC.QuestObjects.Item
{
    public class ItemBox : QuestBox
    {
        Item item;

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
        public CheckBox i_checkBox_target;
        public Label i_label_target;
        public Label i_label_boxed;
        public ComboBox i_comboBox_item;
        public Label i_label_count;
        public Label i_label_item;

        public ItemBox(Item i) : base(i.coordinates, i.number)
        {
            item = i;
        }

        public override void SetObject(QuestBox detail)
        {
            ItemBox itemDetail = (ItemBox)detail;
            i_comboBox_count.Text = itemDetail.i_comboBox_count.Text;
            i_label_boxed.Text = itemDetail.i_label_boxed.Text;
            i_comboBox_item.Text = itemDetail.i_comboBox_item.Text;

        }

        public override void BuildObject()
        {
            int width = 6;
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
            i_checkBox_target = new CheckBox();
            i_label_target = new Label();
            this.i_groupBox_main.SuspendLayout();
            // 
            // i_groupBox_main
            // 
            this.i_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.i_groupBox_main.Controls.Add(this.i_checkBox_target);
            this.i_groupBox_main.Controls.Add(this.i_label_target);

            this.i_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.i_groupBox_main.Location = new System.Drawing.Point(3, 27 + (171 * item.number));
            this.i_groupBox_main.Name = "i_groupBox_main";
            this.i_groupBox_main.Size = new System.Drawing.Size(width, 150);
            this.i_groupBox_main.TabIndex = 1;
            this.i_groupBox_main.TabStop = false;
            this.i_groupBox_main.Text = "Item_" + item.number;
            this.i_groupBox_main.Click += new System.EventHandler(FocusGroupBox);
            // 
            // i_checkBox_target
            // 
            this.i_checkBox_target.Location = new System.Drawing.Point(78, 66);
            this.i_checkBox_target.Name = "i_checkBox_target";
            this.i_checkBox_target.Size = new System.Drawing.Size(17, 18);
            this.i_checkBox_target.UseVisualStyleBackColor = true;
            i_checkBox_target.Checked = item.isTarget;
            this.i_label_target.AutoSize = true;
            this.i_label_target.Location = new System.Drawing.Point(18, 67);
            this.i_label_target.Name = "i_label_target";
            this.i_label_target.Size = new System.Drawing.Size(52, 13);
            this.i_label_target.Text = "Is Target:";
            // 
            // i_comboBox_item
            // 
            this.i_label_item.AutoSize = true;
            this.i_label_item.Location = new System.Drawing.Point(40, 97);
            this.i_label_item.Name = "i_label_item";
            this.i_label_item.Size = new System.Drawing.Size(30, 13);
            this.i_label_item.TabIndex = 6;
            this.i_label_item.Text = "Item:";

            this.i_comboBox_item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_comboBox_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.i_comboBox_item.FormattingEnabled = true;
            this.i_comboBox_item.Location = new System.Drawing.Point(78, 92);
            this.i_comboBox_item.Items.AddRange(ItemNames.itemNames);
            this.i_comboBox_item.Name = "i_comboBox_item";
            this.i_comboBox_item.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.i_comboBox_item.TabIndex = 8;
            i_comboBox_item.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            this.i_comboBox_item.SelectedIndexChanged += new System.EventHandler(this.i_comboBox_item_SelectedIndexChanged);
            this.i_comboBox_item.Text = item.item;
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
            this.i_textBox_xcoord.Text = item.coordinates.xCoord;

            this.i_textBox_ycoord.Location = new System.Drawing.Point(133, 14);
            this.i_textBox_ycoord.Name = "i_textBox_ycoord";
            this.i_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.i_textBox_ycoord.TabIndex = 3;
            this.i_textBox_ycoord.Text = item.coordinates.yCoord;

            this.i_textBox_zcoord.Location = new System.Drawing.Point(187, 14);
            this.i_textBox_zcoord.Name = "i_textBox_zcoord";
            this.i_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.i_textBox_zcoord.TabIndex = 4;
            this.i_textBox_zcoord.Text = item.coordinates.zCoord;

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
            this.i_textBox_xrot.Text = item.rotation.quatRotation.xval;
            this.i_textBox_yrot.Location = new System.Drawing.Point(117, 39);
            this.i_textBox_yrot.Name = "m_textBox_yrocoord";
            this.i_textBox_yrot.Size = new System.Drawing.Size(31, 20);
            this.i_textBox_yrot.TabIndex = 6;
            this.i_textBox_yrot.Text = item.rotation.quatRotation.yval;
            this.i_textBox_zrot.Location = new System.Drawing.Point(157, 39);
            this.i_textBox_zrot.Name = "m_textBox_zrocoord";
            this.i_textBox_zrot.Size = new System.Drawing.Size(31, 20);
            this.i_textBox_zrot.TabIndex = 7;
            this.i_textBox_zrot.Text = item.rotation.quatRotation.zval;
            this.i_textBox_wrot.Location = new System.Drawing.Point(197, 39);
            this.i_textBox_wrot.Name = "m_textBox_wrocoord";
            this.i_textBox_wrot.Size = new System.Drawing.Size(31, 20);
            this.i_textBox_wrot.TabIndex = 8;
            this.i_textBox_wrot.Text = item.rotation.quatRotation.wval;
            // 
            // i_comboBox_count
            // 
            this.i_label_count.AutoSize = true;
            this.i_label_count.Location = new System.Drawing.Point(32, 121);
            this.i_label_count.Name = "i_label_count";
            this.i_label_count.Size = new System.Drawing.Size(38, 13);
            this.i_label_count.TabIndex = 7;
            this.i_label_count.Text = "Count:";

            this.i_comboBox_count.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_comboBox_count.FormattingEnabled = true;
            this.i_comboBox_count.Location = new System.Drawing.Point(78, 118);
            this.i_comboBox_count.Items.AddRange(new object[] {
                "1","4","8","12","16"
            });
            this.i_comboBox_count.Name = "i_comboBox_count";
            this.i_comboBox_count.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.i_comboBox_count.TabIndex = 9;
            this.i_comboBox_count.Text = item.count;
            i_comboBox_count.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            // 
            // i_checkBox_boxed
            // 
            this.i_label_boxed.AutoSize = true;
            this.i_label_boxed.Location = new System.Drawing.Point(117, 67);
            this.i_label_boxed.Name = "i_label_boxed";
            this.i_label_boxed.Size = new System.Drawing.Size(40, 13);
            this.i_label_boxed.TabIndex = 20;
            this.i_label_boxed.Text = "Boxed:";

            this.i_checkBox_boxed.Location = new System.Drawing.Point(165, 66);
            this.i_checkBox_boxed.Name = "i_checkBox_boxed";
            this.i_checkBox_boxed.Size = new System.Drawing.Size(17, 18);
            this.i_checkBox_boxed.UseVisualStyleBackColor = true;
            i_checkBox_boxed.Checked = item.isBoxed;

            this.i_groupBox_main.ResumeLayout(false);
            this.i_groupBox_main.PerformLayout();
        }

        private void i_comboBox_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.i_comboBox_item.Text.Contains("EQP_WP_"))
            {
                this.i_comboBox_count.Text = "0";
                this.i_comboBox_count.Enabled = false;
                this.i_checkBox_target.Enabled = true;
                this.i_label_target.Enabled = true;

            }
            else
            {
                this.i_comboBox_count.Text = "1";
                this.i_comboBox_count.Enabled = true;
                this.i_checkBox_target.Checked = false;
                this.i_checkBox_target.Enabled = false;
                this.i_label_target.Enabled = false;
            }
        }

        public override GroupBox getGroupBoxMain()
        {
            return i_groupBox_main;
        }
    }
}
