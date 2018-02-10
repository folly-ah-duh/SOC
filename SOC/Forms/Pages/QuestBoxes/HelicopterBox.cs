using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOC.QuestComponents;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.Forms.Pages.QuestBoxes
{
    public class HelicopterBox : QuestBox
    {
        Helicopter Heli;
        CP enemyCP;
        string[] frtRouteNames; 

        public GroupBox He_groupBox_main;
        public CheckBox He_checkBox_spawn;
        public CheckBox He_checkBox_target;
        public ComboBox He_comboBox_class;
        public ComboBox He_comboBox_route;
        public Label He_label_route;
        public Label He_label_class;
        public Label He_label_target;
        public Label He_label_spawn;

        public HelicopterBox(Helicopter H, CP cp, string[] frtroutes) : base(new Coordinates("", "", ""), 0)
        {
            Heli = H; enemyCP = cp; frtRouteNames = frtroutes;
        }

        public override void BuildObject(int width)
        {

            width -= 6;
            int comboboxWidth = width - 100;
            this.He_groupBox_main = new System.Windows.Forms.GroupBox();
            this.He_checkBox_spawn = new System.Windows.Forms.CheckBox();
            this.He_checkBox_target = new System.Windows.Forms.CheckBox();
            this.He_comboBox_route = new System.Windows.Forms.ComboBox();
            this.He_comboBox_class = new System.Windows.Forms.ComboBox();
            this.He_label_spawn = new System.Windows.Forms.Label();
            this.He_label_target = new System.Windows.Forms.Label();
            this.He_label_class = new System.Windows.Forms.Label();
            this.He_label_route = new System.Windows.Forms.Label();
            this.He_groupBox_main.SuspendLayout();

            // 
            // He_groupBox_main
            // 
            this.He_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.He_groupBox_main.Controls.Add(this.He_label_route);
            this.He_groupBox_main.Controls.Add(this.He_label_class);
            this.He_groupBox_main.Controls.Add(this.He_label_target);
            this.He_groupBox_main.Controls.Add(this.He_label_spawn);
            this.He_groupBox_main.Controls.Add(this.He_comboBox_class);
            this.He_groupBox_main.Controls.Add(this.He_comboBox_route);
            this.He_groupBox_main.Controls.Add(this.He_checkBox_target);
            this.He_groupBox_main.Controls.Add(this.He_checkBox_spawn);
            this.He_groupBox_main.Location = new System.Drawing.Point(3, 27);
            this.He_groupBox_main.Name = "He_groupBox_main";
            this.He_groupBox_main.Size = new System.Drawing.Size(width, 137);
            this.He_groupBox_main.TabIndex = 0;
            this.He_groupBox_main.TabStop = false;
            this.He_groupBox_main.Text = "EnemyHeli";
            this.He_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // He_checkBox_spawn
            // 
            this.He_checkBox_spawn.AutoSize = true;
            this.He_checkBox_spawn.Location = new System.Drawing.Point(85, 22);
            this.He_checkBox_spawn.Name = "He_checkBox_spawn";
            this.He_checkBox_spawn.Size = new System.Drawing.Size(15, 14);
            this.He_checkBox_spawn.TabIndex = 0;
            this.He_checkBox_spawn.UseVisualStyleBackColor = true;
            this.He_checkBox_spawn.CheckedChanged += new EventHandler(this.He_checkBox_spawn_CheckedChanged);
            this.He_checkBox_spawn.Checked = Heli.isSpawn;
            // 
            // He_checkBox_target
            // 
            this.He_checkBox_target.AutoSize = true;
            this.He_checkBox_target.Location = new System.Drawing.Point(205, 21);
            this.He_checkBox_target.Name = "He_checkBox_target";
            this.He_checkBox_target.Size = new System.Drawing.Size(15, 14);
            this.He_checkBox_target.TabIndex = 1;
            this.He_checkBox_target.UseVisualStyleBackColor = true;
            this.He_checkBox_target.Checked = Heli.isTarget;
            // 
            // He_comboBox_route
            // 
            this.He_comboBox_route.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.He_comboBox_route.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.He_comboBox_route.FormattingEnabled = true;
            this.He_comboBox_route.Location = new System.Drawing.Point(6, 97);
            this.He_comboBox_route.Name = "He_comboBox_route";
            this.He_comboBox_route.Size = new System.Drawing.Size(width - 20, 21);
            this.He_comboBox_route.TabIndex = 2;
            this.He_comboBox_route.Items.AddRange(enemyCP.CPheliRoutes);
            this.He_comboBox_route.Items.AddRange(frtRouteNames);

            if (!He_comboBox_route.Items.Contains(Heli.heliRoute))
                He_comboBox_route.SelectedIndex = 0;
            else
                He_comboBox_route.Text = Heli.heliRoute;

            // 
            // He_comboBox_class
            // 
            this.He_comboBox_class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.He_comboBox_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.He_comboBox_class.FormattingEnabled = true;
            this.He_comboBox_class.Location = new System.Drawing.Point(85, 46);
            this.He_comboBox_class.Name = "He_comboBox_class";
            this.He_comboBox_class.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.He_comboBox_class.TabIndex = 3;
            this.He_comboBox_class.Items.AddRange(new object[] {
                "DEFAULT","BLACK","RED"
            });
            this.He_comboBox_class.Text = Heli.heliClass;
            // 
            // He_label_spawn
            // 
            this.He_label_spawn.AutoSize = true;
            this.He_label_spawn.Location = new System.Drawing.Point(28, 22);
            this.He_label_spawn.Name = "He_label_spawn";
            this.He_label_spawn.Size = new System.Drawing.Size(43, 13);
            this.He_label_spawn.TabIndex = 4;
            this.He_label_spawn.Text = "Spawn:";
            // 
            // He_label_target
            // 
            this.He_label_target.AutoSize = true;
            this.He_label_target.Location = new System.Drawing.Point(139, 21);
            this.He_label_target.Name = "He_label_target";
            this.He_label_target.Size = new System.Drawing.Size(52, 13);
            this.He_label_target.TabIndex = 5;
            this.He_label_target.Text = "Is Target:";
            // 
            // He_label_class
            // 
            this.He_label_class.AutoSize = true;
            this.He_label_class.Location = new System.Drawing.Point(36, 49);
            this.He_label_class.Name = "He_label_class";
            this.He_label_class.Size = new System.Drawing.Size(35, 13);
            this.He_label_class.TabIndex = 6;
            this.He_label_class.Text = "Class:";
            // 
            // He_label_route
            // 
            this.He_label_route.AutoSize = true;
            this.He_label_route.Location = new System.Drawing.Point(6, 80);
            this.He_label_route.Name = "He_label_route";
            this.He_label_route.Size = new System.Drawing.Size(90, 13);
            this.He_label_route.TabIndex = 7;
            this.He_label_route.Text = "Helicopter Route:";

            this.He_groupBox_main.ResumeLayout(false);
            this.He_groupBox_main.PerformLayout();

            UpdateSpawn();
        }

        private void He_checkBox_spawn_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateSpawn();
        }

        private void UpdateSpawn()
        {
            if (He_checkBox_spawn.Checked)
            {
                He_checkBox_target.Enabled = true;
                He_comboBox_class.Enabled = true;
                He_comboBox_route.Enabled = true;
                He_label_class.Enabled = true;
                He_label_route.Enabled = true;
                He_label_target.Enabled = true;
            } else
            {
                He_checkBox_target.Enabled = false;
                He_comboBox_class.Enabled = false;
                He_comboBox_route.Enabled = false;
                He_label_class.Enabled = false;
                He_label_route.Enabled = false;
                He_label_target.Enabled = false;
            }
        }

        public override GroupBox getGroupBoxMain()
        {
            return He_groupBox_main;
        }

        public override void SetObject(QuestBox detail)
        {
            HelicopterBox HeliDetail = (HelicopterBox)detail;

            He_checkBox_spawn.Checked = HeliDetail.He_checkBox_spawn.Checked;
            He_checkBox_target.Checked = HeliDetail.He_checkBox_target.Checked;
            He_comboBox_class.Text = HeliDetail.He_comboBox_class.Text;

            He_comboBox_route.Text = HeliDetail.He_comboBox_route.Text;
        }
    }
}
