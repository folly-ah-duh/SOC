using SOC.Forms;
using System.Windows.Forms;

namespace SOC.QuestObjects.WalkerGear
{
    public class WalkerGearBox : QuestBox
    {
        WalkerGear walkerGear;

        public GroupBox wg_groupBox_main;
        public Label wg_label_target;
        public Label wg_label_rot;
        public Label wg_label_coords;
        public Label wg_label_weapon;
        public Label wg_label_paint;
        public Label wg_label_rider;
        public TextBox wg_textBox_zcoord;
        public TextBox wg_textBox_ycoord;
        public TextBox wg_textBox_xcoord;
        public TextBox wg_textBox_rot;
        public CheckBox wg_checkBox_target;
        public ComboBox wg_comboBox_weapon;
        public ComboBox wg_comboBox_paint;
        public ComboBox wg_comboBox_rider;

        public WalkerGearBox(WalkerGear w) : base(w.coordinates, w.number)
        {
            walkerGear = w;
        }

        public override void SetObject(QuestBox detail)
        {
            WalkerGearBox wd = (WalkerGearBox)detail;
            wg_checkBox_target.Checked = wd.wg_checkBox_target.Checked;
            wg_comboBox_paint.Text = wd.wg_comboBox_paint.Text;
            wg_comboBox_weapon.Text = wd.wg_comboBox_weapon.Text;
            wg_comboBox_rider.Text = wd.wg_comboBox_rider.Text;
        }

        public override void BuildObject()
        {
            int width = 6;
            int comboboxWidth = width - 96;
            this.wg_groupBox_main = new System.Windows.Forms.GroupBox();
            this.wg_label_target = new System.Windows.Forms.Label();
            this.wg_label_coords = new System.Windows.Forms.Label();
            this.wg_label_rot = new System.Windows.Forms.Label();
            this.wg_label_rider = new System.Windows.Forms.Label();
            this.wg_label_paint = new System.Windows.Forms.Label();
            this.wg_label_weapon = new System.Windows.Forms.Label();
            this.wg_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.wg_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.wg_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.wg_textBox_rot = new System.Windows.Forms.TextBox();
            this.wg_checkBox_target = new System.Windows.Forms.CheckBox();
            this.wg_comboBox_rider = new System.Windows.Forms.ComboBox();
            this.wg_comboBox_paint = new System.Windows.Forms.ComboBox();
            this.wg_comboBox_weapon = new System.Windows.Forms.ComboBox();
            this.wg_groupBox_main.SuspendLayout();
            // 
            // wg_groupBox_main
            // 
            this.wg_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wg_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.wg_groupBox_main.Controls.Add(this.wg_comboBox_weapon);
            this.wg_groupBox_main.Controls.Add(this.wg_comboBox_paint);
            this.wg_groupBox_main.Controls.Add(this.wg_comboBox_rider);
            this.wg_groupBox_main.Controls.Add(this.wg_checkBox_target);
            this.wg_groupBox_main.Controls.Add(this.wg_textBox_rot);
            this.wg_groupBox_main.Controls.Add(this.wg_textBox_zcoord);
            this.wg_groupBox_main.Controls.Add(this.wg_textBox_ycoord);
            this.wg_groupBox_main.Controls.Add(this.wg_textBox_xcoord);
            this.wg_groupBox_main.Controls.Add(this.wg_label_weapon);
            this.wg_groupBox_main.Controls.Add(this.wg_label_paint);
            this.wg_groupBox_main.Controls.Add(this.wg_label_rider);
            this.wg_groupBox_main.Controls.Add(this.wg_label_rot);
            this.wg_groupBox_main.Controls.Add(this.wg_label_coords);
            this.wg_groupBox_main.Controls.Add(this.wg_label_target);
            this.wg_groupBox_main.Location = new System.Drawing.Point(3, 27 + (walkerGear.number * 191));
            this.wg_groupBox_main.Name = "wg_groupBox_main";
            this.wg_groupBox_main.Size = new System.Drawing.Size(width, 173);
            this.wg_groupBox_main.TabIndex = 14;
            this.wg_groupBox_main.TabStop = false;
            this.wg_groupBox_main.Text = walkerGear.name;
            // 
            // wg_label_target
            // 
            this.wg_label_target.AutoSize = true;
            this.wg_label_target.Location = new System.Drawing.Point(18, 67);
            this.wg_label_target.Name = "wg_label_target";
            this.wg_label_target.Size = new System.Drawing.Size(52, 13);
            this.wg_label_target.TabIndex = 0;
            this.wg_label_target.Text = "Is Target:";
            // 
            // wg_label_coords
            // 
            this.wg_label_coords.AutoSize = true;
            this.wg_label_coords.Location = new System.Drawing.Point(4, 17);
            this.wg_label_coords.Name = "wg_label_coords";
            this.wg_label_coords.Size = new System.Drawing.Size(66, 13);
            this.wg_label_coords.TabIndex = 1;
            this.wg_label_coords.Text = "Coordinates:";
            // 
            // wg_label_rot
            // 
            this.wg_label_rot.AutoSize = true;
            this.wg_label_rot.Location = new System.Drawing.Point(20, 42);
            this.wg_label_rot.Name = "wg_label_rot";
            this.wg_label_rot.Size = new System.Drawing.Size(50, 13);
            this.wg_label_rot.TabIndex = 2;
            this.wg_label_rot.Text = "Rotation:";
            // 
            // wg_label_rider
            // 
            this.wg_label_rider.AutoSize = true;
            this.wg_label_rider.Location = new System.Drawing.Point(5, 94);
            this.wg_label_rider.Name = "wg_label_rider";
            this.wg_label_rider.Size = new System.Drawing.Size(65, 13);
            this.wg_label_rider.TabIndex = 3;
            this.wg_label_rider.Text = "Enemy Pilot:";
            // 
            // wg_label_paint
            // 
            this.wg_label_paint.AutoSize = true;
            this.wg_label_paint.Location = new System.Drawing.Point(9, 119);
            this.wg_label_paint.Name = "wg_label_paint";
            this.wg_label_paint.Size = new System.Drawing.Size(61, 13);
            this.wg_label_paint.TabIndex = 4;
            this.wg_label_paint.Text = "Paint Type:";
            // 
            // wg_label_weapon
            // 
            this.wg_label_weapon.AutoSize = true;
            this.wg_label_weapon.Location = new System.Drawing.Point(19, 144);
            this.wg_label_weapon.Name = "wg_label_weapon";
            this.wg_label_weapon.Size = new System.Drawing.Size(51, 13);
            this.wg_label_weapon.TabIndex = 5;
            this.wg_label_weapon.Text = "Weapon:";
            // 
            // wg_textBox_xcoord
            // 
            this.wg_textBox_xcoord.Location = new System.Drawing.Point(78, 14);
            this.wg_textBox_xcoord.Name = "wg_textBox_xcoord";
            this.wg_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.wg_textBox_xcoord.TabIndex = 6;
            this.wg_textBox_xcoord.Text = walkerGear.coordinates.xCoord;
            // 
            // wg_textBox_ycoord
            // 
            this.wg_textBox_ycoord.Location = new System.Drawing.Point(133, 14);
            this.wg_textBox_ycoord.Name = "wg_textBox_ycoord";
            this.wg_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.wg_textBox_ycoord.TabIndex = 7;
            this.wg_textBox_ycoord.Text = walkerGear.coordinates.yCoord;
            // 
            // wg_textBox_zcoord
            // 
            this.wg_textBox_zcoord.Location = new System.Drawing.Point(187, 14);
            this.wg_textBox_zcoord.Name = "wg_textBox_zcoord";
            this.wg_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.wg_textBox_zcoord.TabIndex = 8;
            this.wg_textBox_zcoord.Text = walkerGear.coordinates.zCoord;
            // 
            // wg_textBox_rot
            // 
            this.wg_textBox_rot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wg_textBox_rot.Location = new System.Drawing.Point(78, 39);
            this.wg_textBox_rot.Name = "wg_textBox_rot";
            this.wg_textBox_rot.Size = new System.Drawing.Size(comboboxWidth, 20);
            this.wg_textBox_rot.TabIndex = 9;
            this.wg_textBox_rot.Text = walkerGear.rotation.GetDegreeRotY();
            // 
            // wg_checkBox_target
            // 
            this.wg_checkBox_target.AutoSize = true;
            this.wg_checkBox_target.Location = new System.Drawing.Point(78, 66);
            this.wg_checkBox_target.Name = "wg_checkBox_target";
            this.wg_checkBox_target.Size = new System.Drawing.Size(15, 14);
            this.wg_checkBox_target.TabIndex = 10;
            this.wg_checkBox_target.UseVisualStyleBackColor = true;
            this.wg_checkBox_target.Checked = walkerGear.isTarget;
            // 
            // wg_comboBox_rider
            // 
            this.wg_comboBox_rider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wg_comboBox_rider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wg_comboBox_rider.FormattingEnabled = true;
            this.wg_comboBox_rider.Items.AddRange(new object[] {
                "NONE", "sol_quest_0000", "sol_quest_0001", "sol_quest_0002", "sol_quest_0003", "sol_quest_0004", "sol_quest_0005", "sol_quest_0006", "sol_quest_0007"
            });
            this.wg_comboBox_rider.Text = walkerGear.rider;
            this.wg_comboBox_rider.Location = new System.Drawing.Point(78, 91);
            this.wg_comboBox_rider.Name = "wg_comboBox_rider";
            this.wg_comboBox_rider.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.wg_comboBox_rider.TabIndex = 11;
            // 
            // wg_comboBox_paint
            // 
            this.wg_comboBox_paint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wg_comboBox_paint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wg_comboBox_paint.FormattingEnabled = true;
            this.wg_comboBox_paint.Items.AddRange(new object[] {
            "SOVIET",
            "ROGUE_COYOTE",
            "CFA",
            "ZRS",
            "DDOGS"});
            this.wg_comboBox_paint.Text = walkerGear.color;
            this.wg_comboBox_paint.Location = new System.Drawing.Point(78, 116);
            this.wg_comboBox_paint.Name = "wg_comboBox_paint";
            this.wg_comboBox_paint.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.wg_comboBox_paint.TabIndex = 12;
            // 
            // wg_comboBox_weapon
            // 
            this.wg_comboBox_weapon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wg_comboBox_weapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wg_comboBox_weapon.FormattingEnabled = true;
            this.wg_comboBox_weapon.Items.AddRange(new object[] {
            "WG_MACHINEGUN",
            "WG_MISSILE"});
            this.wg_comboBox_weapon.Text = walkerGear.weapon;
            this.wg_comboBox_weapon.Location = new System.Drawing.Point(78, 141);
            this.wg_comboBox_weapon.Name = "wg_comboBox_weapon";
            this.wg_comboBox_weapon.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.wg_comboBox_weapon.TabIndex = 13;

            this.wg_groupBox_main.ResumeLayout(false);
            this.wg_groupBox_main.PerformLayout();
        }

        public override GroupBox getGroupBoxMain()
        {
            return wg_groupBox_main;
        }
    }
}
