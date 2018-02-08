using SOC.QuestComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.Forms.Pages.QuestBoxes
{
    public class EnemyBox : QuestBox
    {
        public int enemyNumber = -1;
        CP enemyCP = new CP();
        Enemy enemy = new Enemy();
        int region;
        string[] frtRouteNames;

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

        public EnemyBox(Enemy e, CP cp, string[] frtRoutes, int locId) : base(new Coordinates("", "", ""), e.number)
        {
            enemy = e; enemyCP = cp; region = locId;
            enemyNumber = e.number; frtRouteNames = frtRoutes;
        }

        public override void BuildObject(int width)
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
            this.e_groupBox_main.Location = new System.Drawing.Point(3, 55 + (334 * enemyNumber));
            this.e_groupBox_main.Name = "e_groupBox_main";
            this.e_groupBox_main.Size = new System.Drawing.Size(width, 317);
            this.e_groupBox_main.TabIndex = 0;
            this.e_groupBox_main.TabStop = false;
            this.e_groupBox_main.Text = enemy.name;
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
            // 
            // e_label_power
            // 
            this.e_label_power.AutoSize = true;
            this.e_label_power.Location = new System.Drawing.Point(9, 129);
            this.e_label_power.Name = "e_label_power";
            this.e_label_power.Size = new System.Drawing.Size(76, 13);
            this.e_label_power.TabIndex = 19;
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
            e_listBox_power.Items.AddRange(enemy.powers);
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
            this.e_comboBox_skill.Text = enemy.skill;
            this.e_comboBox_skill.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.e_comboBox_skill.TabIndex = 17;
            e_comboBox_skill.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            // 
            // e_label_skill
            // 
            this.e_label_skill.AutoSize = true;
            this.e_label_skill.Location = new System.Drawing.Point(56, 293);
            this.e_label_skill.Name = "e_label_skill";
            this.e_label_skill.Size = new System.Drawing.Size(29, 13);
            this.e_label_skill.TabIndex = 16;
            this.e_label_skill.Text = "Skill:";
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
            this.e_comboBox_staff.Text = enemy.staffType;
            this.e_comboBox_staff.TabIndex = 15;
            e_comboBox_staff.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            // 
            // e_label_staff
            // 
            this.e_label_staff.AutoSize = true;
            this.e_label_staff.Location = new System.Drawing.Point(26, 268);
            this.e_label_staff.Name = "e_label_staff";
            this.e_label_staff.Size = new System.Drawing.Size(59, 13);
            this.e_label_staff.TabIndex = 14;
            this.e_label_staff.Text = "Staff Type:";
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

            if (isAfgh(region))
                e_comboBox_body.Items.AddRange(BodyInfo.afghBodies);
            else if (isMafr(region))
                e_comboBox_body.Items.AddRange(BodyInfo.mafrBodies);

            if (e_comboBox_body.Items.Contains(enemy.body))
                this.e_comboBox_body.Text = enemy.body;
            else if (e_comboBox_body.Items.Count > 0)
                e_comboBox_body.SelectedIndex = 0;

            e_comboBox_body.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
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

            e_comboBox_cautionroute.Items.AddRange(frtRouteNames);
            e_comboBox_cautionroute.Items.AddRange(enemyCP.CProutes);

            if (!e_comboBox_cautionroute.Items.Contains(enemy.cRoute))
                e_comboBox_cautionroute.SelectedIndex = 0;
            else
                e_comboBox_cautionroute.Text = enemy.cRoute;

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

            e_comboBox_sneakroute.Items.AddRange(frtRouteNames);
            e_comboBox_sneakroute.Items.AddRange(enemyCP.CProutes);

            if (!e_comboBox_sneakroute.Items.Contains(enemy.dRoute))
                e_comboBox_sneakroute.SelectedIndex = 0;
            else
                e_comboBox_sneakroute.Text = enemy.dRoute;

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
            // 
            // e_label_body
            // 
            this.e_label_body.AutoSize = true;
            this.e_label_body.Location = new System.Drawing.Point(51, 243);
            this.e_label_body.Name = "e_label_body";
            this.e_label_body.Size = new System.Drawing.Size(34, 13);
            this.e_label_body.TabIndex = 8;
            this.e_label_body.Text = "Body:";
            // 
            // e_checkBox_target
            // 
            this.e_checkBox_target.AutoSize = true;
            this.e_checkBox_target.Location = new System.Drawing.Point(205, 21);
            this.e_checkBox_target.Name = "e_checkBox_target";
            this.e_checkBox_target.Size = new System.Drawing.Size(15, 14);
            this.e_checkBox_target.TabIndex = 5;
            this.e_checkBox_target.UseVisualStyleBackColor = true;
            e_checkBox_target.Checked = enemy.isTarget;
            // 
            // e_label_target
            // 
            this.e_label_target.AutoSize = true;
            this.e_label_target.Location = new System.Drawing.Point(139, 21);
            this.e_label_target.Name = "e_label_target";
            this.e_label_target.Size = new System.Drawing.Size(52, 13);
            this.e_label_target.TabIndex = 4;
            this.e_label_target.Text = "Is Target:";
            // 
            // e_checkBox_Balaclava
            // 
            this.e_checkBox_balaclava.AutoSize = true;
            this.e_checkBox_balaclava.Location = new System.Drawing.Point(99, 41);
            this.e_checkBox_balaclava.Name = "e_checkBox_balaclava";
            this.e_checkBox_balaclava.Size = new System.Drawing.Size(15, 14);
            this.e_checkBox_balaclava.TabIndex = 5;
            this.e_checkBox_balaclava.UseVisualStyleBackColor = true;
            e_checkBox_balaclava.Checked = enemy.isBalaclava;
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
            // 
            // e_checkBox_zombie
            // 
            this.e_checkBox_zombie.AutoSize = true;
            this.e_checkBox_zombie.Location = new System.Drawing.Point(205, 41);
            this.e_checkBox_zombie.Name = "e_checkBox_zombie";
            this.e_checkBox_zombie.Size = new System.Drawing.Size(15, 14);
            this.e_checkBox_zombie.TabIndex = 1;
            this.e_checkBox_zombie.UseVisualStyleBackColor = true;
            e_checkBox_zombie.Checked = enemy.isZombie;
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
            this.e_groupBox_main.ResumeLayout(false);
            this.e_groupBox_main.PerformLayout();
            // 
            // e_checkBox_armor
            // 
            this.e_checkBox_armor.AutoSize = true;
            this.e_checkBox_armor.Location = new System.Drawing.Point(99, 210);
            this.e_checkBox_armor.Name = "e_checkBox_armor";
            this.e_checkBox_armor.Size = new System.Drawing.Size(15, 14);
            this.e_checkBox_armor.TabIndex = 3;
            this.e_checkBox_armor.UseVisualStyleBackColor = true;
            e_checkBox_armor.Checked = enemy.isArmored;
            this.e_checkBox_armor.Click += new EventHandler(this.armor_Checkbox_Clicked);
            // 
            // e_label_armor
            // 
            this.e_label_armor.AutoSize = true;
            this.e_label_armor.Location = new System.Drawing.Point(14, 210);
            this.e_label_armor.Name = "e_label_armor";
            this.e_label_armor.Size = new System.Drawing.Size(71, 13);
            this.e_label_armor.TabIndex = 2;
            this.e_label_armor.Text = "Heavy Armor:";
            // 
            // e_checkBox_spawn
            // 
            this.e_checkBox_spawn.AutoSize = true;
            this.e_checkBox_spawn.Location = new System.Drawing.Point(99, 21);
            this.e_checkBox_spawn.Name = "e_checkBox_spawn";
            this.e_checkBox_spawn.Size = new System.Drawing.Size(15, 14);
            this.e_checkBox_spawn.TabIndex = 1;
            this.e_checkBox_spawn.UseVisualStyleBackColor = true;
            e_checkBox_spawn.Checked = enemy.isSpawn;
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

            UpdateSpawn();

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
            UpdateSpawn();
        }

        private void UpdateSpawn()
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
                e_button_removepower.Enabled = true;

                if (e_checkBox_balaclava.Checked) { updateBalaclava(); }
                if (e_checkBox_zombie.Checked) { updateZombie(); }
                if (e_checkBox_armor.Checked) { updateArmor(); }
            }
            else
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
                e_button_removepower.Enabled = false;
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
                    if (!e_listBox_power.Items.Contains("QUEST_ARMOR"))
                    {
                        e_listBox_power.Items.Add("QUEST_ARMOR");
                        e_listBox_power.SelectedIndex = e_listBox_power.Items.Count - 1;
                    }
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

        public override void SetObject(QuestBox detail)
        {
            EnemyBox enemyDetail = (EnemyBox)detail;

            e_checkBox_armor.Checked = enemyDetail.e_checkBox_armor.Checked;
            e_checkBox_spawn.Checked = enemyDetail.e_checkBox_spawn.Checked;
            e_checkBox_target.Checked = enemyDetail.e_checkBox_target.Checked;
            e_checkBox_balaclava.Checked = enemyDetail.e_checkBox_balaclava.Checked;
            e_checkBox_zombie.Checked = enemyDetail.e_checkBox_zombie.Checked;

            e_listBox_power.Text = enemyDetail.e_listBox_power.Text;

            string[] cautionArray = new string[enemyDetail.e_comboBox_cautionroute.Items.Count];
            enemyDetail.e_comboBox_cautionroute.Items.CopyTo(cautionArray, 0);
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
}
