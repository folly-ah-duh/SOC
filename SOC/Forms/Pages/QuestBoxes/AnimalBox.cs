using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.Forms.Pages.QuestBoxes
{
    public class AnimalBox : QuestBox
    {
        Animal animal;

        public GroupBox a_groupBox_main;
        public ComboBox a_comboBox_TypeID;
        public Label a_label_typeID;
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

        public AnimalBox(Animal a) : base(a.coordinates, a.number)
        {
            animal = a;
        }

        public override void SetObject(QuestBox detail)
        {
            AnimalBox animalDetail = (AnimalBox)detail;
            a_checkBox_isTarget.Checked = animalDetail.a_checkBox_isTarget.Checked;
            a_comboBox_animal.Text = animalDetail.a_comboBox_animal.Text;
            a_comboBox_TypeID.Text = animalDetail.a_comboBox_TypeID.Text;
            a_comboBox_count.Text = animalDetail.a_comboBox_count.Text;
        }

        public override void BuildObject(int width)
        {

            width -= 6;
            int comboboxWidth = width - 96;
            this.a_groupBox_main = new System.Windows.Forms.GroupBox();
            this.a_comboBox_TypeID = new System.Windows.Forms.ComboBox();
            this.a_label_typeID = new System.Windows.Forms.Label();
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
            this.a_groupBox_main.Controls.Add(this.a_label_typeID);
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
            this.a_groupBox_main.Location = new System.Drawing.Point(3, 27 + (animal.number * 180));
            this.a_groupBox_main.Name = "a_groupBox_main";
            this.a_groupBox_main.Size = new System.Drawing.Size(width, 166);
            this.a_groupBox_main.TabIndex = 0;
            this.a_groupBox_main.TabStop = false;
            this.a_groupBox_main.Text = animal.name;
            this.a_groupBox_main.Click += new System.EventHandler(FocusGroupBox);
            // 
            // a_comboBox_animal
            // 
            this.a_comboBox_animal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a_comboBox_animal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a_comboBox_animal.FormattingEnabled = true;
            this.a_comboBox_animal.Location = new System.Drawing.Point(84, 81);
            this.a_comboBox_animal.Items.AddRange(QuestComponents.AnimalInfo.animals);
            this.a_comboBox_animal.Name = "a_comboBox_animal";
            this.a_comboBox_animal.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.a_comboBox_animal.TabIndex = 9;
            this.a_comboBox_animal.SelectedIndexChanged += new System.EventHandler(this.a_comboBox_animal_selectedIndexChanged);
            a_comboBox_animal.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            this.a_comboBox_animal.Text = animal.animal;
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
            a_comboBox_TypeID.Text = animal.typeID;
            // 
            // a_label_targetcount
            // 
            this.a_label_typeID.AutoSize = true;
            this.a_label_typeID.Location = new System.Drawing.Point(115, 141);
            this.a_label_typeID.Name = "a_label_typeID";
            this.a_label_typeID.Size = new System.Drawing.Size(72, 13);
            this.a_label_typeID.TabIndex = 12;
            this.a_label_typeID.Text = "Type ID:";
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
            a_comboBox_count.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6" });
            a_comboBox_count.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);
            a_comboBox_count.Text = animal.count;
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
            // a_checkBox_isTarget
            // 
            this.a_checkBox_isTarget.AutoSize = true;
            this.a_checkBox_isTarget.Location = new System.Drawing.Point(84, 141);
            this.a_checkBox_isTarget.Name = "a_checkBox_isTarget";
            this.a_checkBox_isTarget.Size = new System.Drawing.Size(15, 14);
            this.a_checkBox_isTarget.TabIndex = 7;
            this.a_checkBox_isTarget.UseVisualStyleBackColor = true;
            a_checkBox_isTarget.Checked = animal.isTarget;
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
            this.a_textBox_rot.Text = animal.coordinates.roty;

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
            this.a_textBox_zcoord.Text = animal.coordinates.zCoord;
            // 
            // a_textBox_ycoord
            // 
            this.a_textBox_ycoord.Location = new System.Drawing.Point(139, 22);
            this.a_textBox_ycoord.Name = "a_textBox_ycoord";
            this.a_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.a_textBox_ycoord.TabIndex = 2;
            this.a_textBox_ycoord.Text = animal.coordinates.yCoord;
            // 
            // a_textBox_xcoord
            // 
            this.a_textBox_xcoord.Location = new System.Drawing.Point(84, 22);
            this.a_textBox_xcoord.Name = "a_textBox_xcoord";
            this.a_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.a_textBox_xcoord.TabIndex = 1;
            this.a_textBox_xcoord.Text = animal.coordinates.xCoord;
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
                    a_comboBox_TypeID.Items.AddRange(new string[] { "TppGoat", "TppNubian" });
                    break;
                case "Boer_Goat":
                case "Nubian":
                    a_comboBox_count.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6" });
                    a_comboBox_TypeID.Items.AddRange(new string[] { "TppGoat", "TppNubian" });
                    break;

                case "Donkey":
                case "Zebra":
                case "Okapi":
                    a_comboBox_count.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6" });
                    a_comboBox_TypeID.Items.AddRange(new string[] { "TppZebra" });
                    break;

                case "Wolf":
                    a_comboBox_count.Items.AddRange(new string[] { "1", "2", "3", "4" });
                    a_comboBox_TypeID.Items.AddRange(new string[] { "TppWolf", "TppJackal" });
                    break;

                case "Jackal":
                case "African_Wild_Dog":
                    a_comboBox_count.Items.AddRange(new string[] { "1", "2", "3", "4" });
                    a_comboBox_TypeID.Items.AddRange(new string[] { "TppWolf", "TppJackal", });
                    break;

                case "Bear":
                    a_comboBox_count.Items.AddRange(new string[] { "1" });
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
    }
}
