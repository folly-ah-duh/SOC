namespace SOC.QuestObjects.Enemy
{
    partial class EnemyBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_balaclava = new System.Windows.Forms.CheckBox();
            this.checkBox_zombie = new System.Windows.Forms.CheckBox();
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.comboBox_power = new System.Windows.Forms.ComboBox();
            this.button_removepower = new System.Windows.Forms.Button();
            this.label_power = new System.Windows.Forms.Label();
            this.comboBox_skill = new System.Windows.Forms.ComboBox();
            this.listBox_power = new System.Windows.Forms.ListBox();
            this.label_skill = new System.Windows.Forms.Label();
            this.comboBox_staff = new System.Windows.Forms.ComboBox();
            this.label_staff = new System.Windows.Forms.Label();
            this.comboBox_body = new System.Windows.Forms.ComboBox();
            this.comboBox_cautionroute = new System.Windows.Forms.ComboBox();
            this.label_cautionroute = new System.Windows.Forms.Label();
            this.comboBox_sneakroute = new System.Windows.Forms.ComboBox();
            this.label_sneakroute = new System.Windows.Forms.Label();
            this.label_body = new System.Windows.Forms.Label();
            this.checkBox_target = new System.Windows.Forms.CheckBox();
            this.checkBox_armor = new System.Windows.Forms.CheckBox();
            this.checkBox_spawn = new System.Windows.Forms.CheckBox();
            this.button_SneakToCaution = new System.Windows.Forms.Button();
            this.button_CautionToSneak = new System.Windows.Forms.Button();
            this.button_SwapRoutes = new System.Windows.Forms.Button();
            this.groupBox_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_balaclava
            // 
            this.checkBox_balaclava.AutoSize = true;
            this.checkBox_balaclava.Location = new System.Drawing.Point(171, 40);
            this.checkBox_balaclava.Name = "checkBox_balaclava";
            this.checkBox_balaclava.Size = new System.Drawing.Size(73, 17);
            this.checkBox_balaclava.TabIndex = 5;
            this.checkBox_balaclava.Text = "Balaclava";
            this.checkBox_balaclava.UseVisualStyleBackColor = true;
            this.checkBox_balaclava.Click += new System.EventHandler(this.checkBox_balaclava_Click);
            // 
            // checkBox_zombie
            // 
            this.checkBox_zombie.AutoSize = true;
            this.checkBox_zombie.Location = new System.Drawing.Point(85, 41);
            this.checkBox_zombie.Name = "checkBox_zombie";
            this.checkBox_zombie.Size = new System.Drawing.Size(61, 17);
            this.checkBox_zombie.TabIndex = 1;
            this.checkBox_zombie.Text = "Zombie";
            this.checkBox_zombie.UseVisualStyleBackColor = true;
            // 
            // groupBox_main
            // 
            this.groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox_main.Controls.Add(this.comboBox_power);
            this.groupBox_main.Controls.Add(this.button_removepower);
            this.groupBox_main.Controls.Add(this.label_power);
            this.groupBox_main.Controls.Add(this.comboBox_skill);
            this.groupBox_main.Controls.Add(this.listBox_power);
            this.groupBox_main.Controls.Add(this.label_skill);
            this.groupBox_main.Controls.Add(this.comboBox_staff);
            this.groupBox_main.Controls.Add(this.label_staff);
            this.groupBox_main.Controls.Add(this.comboBox_body);
            this.groupBox_main.Controls.Add(this.comboBox_cautionroute);
            this.groupBox_main.Controls.Add(this.label_cautionroute);
            this.groupBox_main.Controls.Add(this.comboBox_sneakroute);
            this.groupBox_main.Controls.Add(this.label_sneakroute);
            this.groupBox_main.Controls.Add(this.label_body);
            this.groupBox_main.Controls.Add(this.checkBox_target);
            this.groupBox_main.Controls.Add(this.checkBox_armor);
            this.groupBox_main.Controls.Add(this.checkBox_spawn);
            this.groupBox_main.Controls.Add(this.checkBox_zombie);
            this.groupBox_main.Controls.Add(this.checkBox_balaclava);
            this.groupBox_main.Controls.Add(this.button_SneakToCaution);
            this.groupBox_main.Controls.Add(this.button_CautionToSneak);
            this.groupBox_main.Controls.Add(this.button_SwapRoutes);
            this.groupBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_main.Location = new System.Drawing.Point(0, 0);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(268, 319);
            this.groupBox_main.TabIndex = 0;
            this.groupBox_main.TabStop = false;
            this.groupBox_main.Text = "EnemyBox";
            // 
            // comboBox_power
            // 
            this.comboBox_power.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_power.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_power.FormattingEnabled = true;
            this.comboBox_power.Location = new System.Drawing.Point(85, 127);
            this.comboBox_power.Name = "comboBox_power";
            this.comboBox_power.Size = new System.Drawing.Size(174, 21);
            this.comboBox_power.TabIndex = 22;
            this.comboBox_power.SelectedIndexChanged += new System.EventHandler(this.comboBox_power_selectedIndexChanged);
            // 
            // button_removepower
            // 
            this.button_removepower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_removepower.Location = new System.Drawing.Point(204, 212);
            this.button_removepower.Name = "button_removepower";
            this.button_removepower.Size = new System.Drawing.Size(55, 23);
            this.button_removepower.TabIndex = 21;
            this.button_removepower.Text = "Remove";
            this.button_removepower.UseVisualStyleBackColor = true;
            this.button_removepower.Click += new System.EventHandler(this.button_removepower_Click);
            // 
            // label_power
            // 
            this.label_power.Location = new System.Drawing.Point(3, 131);
            this.label_power.Name = "label_power";
            this.label_power.Size = new System.Drawing.Size(76, 13);
            this.label_power.TabIndex = 19;
            this.label_power.Text = "Gear | Tactics:";
            this.label_power.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_skill
            // 
            this.comboBox_skill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_skill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_skill.FormattingEnabled = true;
            this.comboBox_skill.Location = new System.Drawing.Point(85, 292);
            this.comboBox_skill.Name = "comboBox_skill";
            this.comboBox_skill.Size = new System.Drawing.Size(174, 21);
            this.comboBox_skill.TabIndex = 17;
            // 
            // listBox_power
            // 
            this.listBox_power.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_power.FormattingEnabled = true;
            this.listBox_power.Location = new System.Drawing.Point(85, 152);
            this.listBox_power.Name = "listBox_power";
            this.listBox_power.Size = new System.Drawing.Size(174, 54);
            this.listBox_power.TabIndex = 18;
            this.listBox_power.SelectedIndexChanged += new System.EventHandler(this.listBox_power_selectedIndexChanged);
            // 
            // label_skill
            // 
            this.label_skill.Location = new System.Drawing.Point(3, 295);
            this.label_skill.Name = "label_skill";
            this.label_skill.Size = new System.Drawing.Size(76, 13);
            this.label_skill.TabIndex = 16;
            this.label_skill.Text = "Skill:";
            this.label_skill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_staff
            // 
            this.comboBox_staff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_staff.FormattingEnabled = true;
            this.comboBox_staff.Location = new System.Drawing.Point(85, 267);
            this.comboBox_staff.Name = "comboBox_staff";
            this.comboBox_staff.Size = new System.Drawing.Size(174, 21);
            this.comboBox_staff.TabIndex = 15;
            // 
            // label_staff
            // 
            this.label_staff.Location = new System.Drawing.Point(3, 270);
            this.label_staff.Name = "label_staff";
            this.label_staff.Size = new System.Drawing.Size(76, 13);
            this.label_staff.TabIndex = 14;
            this.label_staff.Text = "Staff Type:";
            this.label_staff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_body
            // 
            this.comboBox_body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_body.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_body.FormattingEnabled = true;
            this.comboBox_body.Location = new System.Drawing.Point(85, 242);
            this.comboBox_body.Name = "comboBox_body";
            this.comboBox_body.Size = new System.Drawing.Size(174, 21);
            this.comboBox_body.TabIndex = 13;
            // 
            // comboBox_cautionroute
            // 
            this.comboBox_cautionroute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_cautionroute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cautionroute.FormattingEnabled = true;
            this.comboBox_cautionroute.Location = new System.Drawing.Point(102, 91);
            this.comboBox_cautionroute.Name = "comboBox_cautionroute";
            this.comboBox_cautionroute.Size = new System.Drawing.Size(140, 21);
            this.comboBox_cautionroute.TabIndex = 12;
            // 
            // label_cautionroute
            // 
            this.label_cautionroute.Location = new System.Drawing.Point(3, 94);
            this.label_cautionroute.Name = "label_cautionroute";
            this.label_cautionroute.Size = new System.Drawing.Size(78, 13);
            this.label_cautionroute.TabIndex = 11;
            this.label_cautionroute.Text = "Caution Route:";
            this.label_cautionroute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_sneakroute
            // 
            this.comboBox_sneakroute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_sneakroute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sneakroute.FormattingEnabled = true;
            this.comboBox_sneakroute.Location = new System.Drawing.Point(102, 65);
            this.comboBox_sneakroute.Name = "comboBox_sneakroute";
            this.comboBox_sneakroute.Size = new System.Drawing.Size(140, 21);
            this.comboBox_sneakroute.TabIndex = 10;
            // 
            // label_sneakroute
            // 
            this.label_sneakroute.Location = new System.Drawing.Point(3, 70);
            this.label_sneakroute.Name = "label_sneakroute";
            this.label_sneakroute.Size = new System.Drawing.Size(78, 13);
            this.label_sneakroute.TabIndex = 9;
            this.label_sneakroute.Text = "Sneak Route:";
            this.label_sneakroute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_body
            // 
            this.label_body.Location = new System.Drawing.Point(3, 245);
            this.label_body.Name = "label_body";
            this.label_body.Size = new System.Drawing.Size(76, 13);
            this.label_body.TabIndex = 8;
            this.label_body.Text = "Body:";
            this.label_body.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox_target
            // 
            this.checkBox_target.AutoSize = true;
            this.checkBox_target.Location = new System.Drawing.Point(171, 21);
            this.checkBox_target.Name = "checkBox_target";
            this.checkBox_target.Size = new System.Drawing.Size(68, 17);
            this.checkBox_target.TabIndex = 5;
            this.checkBox_target.Text = "Is Target";
            this.checkBox_target.UseVisualStyleBackColor = true;
            // 
            // checkBox_armor
            // 
            this.checkBox_armor.AutoSize = true;
            this.checkBox_armor.Location = new System.Drawing.Point(85, 216);
            this.checkBox_armor.Name = "checkBox_armor";
            this.checkBox_armor.Size = new System.Drawing.Size(87, 17);
            this.checkBox_armor.TabIndex = 3;
            this.checkBox_armor.Text = "Heavy Armor";
            this.checkBox_armor.UseVisualStyleBackColor = true;
            this.checkBox_armor.Click += new System.EventHandler(this.checkBox_armor_Click);
            // 
            // checkBox_spawn
            // 
            this.checkBox_spawn.AutoSize = true;
            this.checkBox_spawn.Location = new System.Drawing.Point(85, 21);
            this.checkBox_spawn.Name = "checkBox_spawn";
            this.checkBox_spawn.Size = new System.Drawing.Size(59, 17);
            this.checkBox_spawn.TabIndex = 1;
            this.checkBox_spawn.Text = "Spawn";
            this.checkBox_spawn.UseVisualStyleBackColor = true;
            this.checkBox_spawn.CheckedChanged += new System.EventHandler(this.checkBox_spawn_CheckedChanged);
            // 
            // button_SneakToCaution
            // 
            this.button_SneakToCaution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SneakToCaution.Location = new System.Drawing.Point(245, 65);
            this.button_SneakToCaution.Name = "button_SneakToCaution";
            this.button_SneakToCaution.Size = new System.Drawing.Size(14, 23);
            this.button_SneakToCaution.TabIndex = 21;
            this.button_SneakToCaution.Text = "↓";
            this.button_SneakToCaution.UseVisualStyleBackColor = true;
            this.button_SneakToCaution.Click += new System.EventHandler(this.SneakToCaution_Button_Clicked);
            // 
            // button_CautionToSneak
            // 
            this.button_CautionToSneak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CautionToSneak.Location = new System.Drawing.Point(245, 90);
            this.button_CautionToSneak.Name = "button_CautionToSneak";
            this.button_CautionToSneak.Size = new System.Drawing.Size(14, 23);
            this.button_CautionToSneak.TabIndex = 21;
            this.button_CautionToSneak.Text = "↑";
            this.button_CautionToSneak.UseVisualStyleBackColor = true;
            this.button_CautionToSneak.Click += new System.EventHandler(this.CautionToSneak_Button_Clicked);
            // 
            // button_SwapRoutes
            // 
            this.button_SwapRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SwapRoutes.Location = new System.Drawing.Point(85, 65);
            this.button_SwapRoutes.Name = "button_SwapRoutes";
            this.button_SwapRoutes.Size = new System.Drawing.Size(14, 48);
            this.button_SwapRoutes.TabIndex = 21;
            this.button_SwapRoutes.Text = "↕";
            this.button_SwapRoutes.UseVisualStyleBackColor = true;
            this.button_SwapRoutes.Click += new System.EventHandler(this.SwapRoute_Button_Clicked);
            // 
            // EnemyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_main);
            this.Name = "EnemyBox";
            this.Size = new System.Drawing.Size(268, 319);
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox_main;
        public System.Windows.Forms.CheckBox checkBox_target;
        public System.Windows.Forms.CheckBox checkBox_spawn;
        public System.Windows.Forms.CheckBox checkBox_balaclava;
        public System.Windows.Forms.CheckBox checkBox_zombie;
        public System.Windows.Forms.CheckBox checkBox_armor;
        public System.Windows.Forms.Label label_body;
        public System.Windows.Forms.ComboBox comboBox_body;
        public System.Windows.Forms.ComboBox comboBox_cautionroute;
        public System.Windows.Forms.Label label_cautionroute;
        public System.Windows.Forms.ComboBox comboBox_sneakroute;
        public System.Windows.Forms.Label label_sneakroute;
        public System.Windows.Forms.ComboBox comboBox_skill;
        public System.Windows.Forms.Label label_skill;
        public System.Windows.Forms.ComboBox comboBox_staff;
        public System.Windows.Forms.Label label_staff;
        public System.Windows.Forms.ComboBox comboBox_power;
        public System.Windows.Forms.Button button_removepower;
        public System.Windows.Forms.Label label_power;
        public System.Windows.Forms.ListBox listBox_power;
        public System.Windows.Forms.Button button_SneakToCaution;
        public System.Windows.Forms.Button button_CautionToSneak;
        public System.Windows.Forms.Button button_SwapRoutes;
    }
}
