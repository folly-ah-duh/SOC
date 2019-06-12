namespace SOC.QuestObjects.Helicopter
{
    partial class HelicopterBox
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
            this.h_groupBox_main = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.h_comboBox_route = new System.Windows.Forms.ComboBox();
            this.h_comboBox_class = new System.Windows.Forms.ComboBox();
            this.h_checkBox_target = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.h_textBox_rot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.h_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.h_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.h_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.h_groupBox_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // h_groupBox_main
            // 
            this.h_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.h_groupBox_main.Controls.Add(this.label2);
            this.h_groupBox_main.Controls.Add(this.h_textBox_rot);
            this.h_groupBox_main.Controls.Add(this.label1);
            this.h_groupBox_main.Controls.Add(this.h_textBox_zcoord);
            this.h_groupBox_main.Controls.Add(this.h_textBox_ycoord);
            this.h_groupBox_main.Controls.Add(this.h_textBox_xcoord);
            this.h_groupBox_main.Controls.Add(this.label4);
            this.h_groupBox_main.Controls.Add(this.label3);
            this.h_groupBox_main.Controls.Add(this.h_comboBox_route);
            this.h_groupBox_main.Controls.Add(this.h_comboBox_class);
            this.h_groupBox_main.Controls.Add(this.h_checkBox_target);
            this.h_groupBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.h_groupBox_main.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.h_groupBox_main.Location = new System.Drawing.Point(0, 0);
            this.h_groupBox_main.Name = "h_groupBox_main";
            this.h_groupBox_main.Size = new System.Drawing.Size(268, 156);
            this.h_groupBox_main.TabIndex = 2;
            this.h_groupBox_main.TabStop = false;
            this.h_groupBox_main.Text = "HelicopterBox";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Route:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Class:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // h_comboBox_route
            // 
            this.h_comboBox_route.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.h_comboBox_route.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.h_comboBox_route.FormattingEnabled = true;
            this.h_comboBox_route.Location = new System.Drawing.Point(85, 129);
            this.h_comboBox_route.Name = "h_comboBox_route";
            this.h_comboBox_route.Size = new System.Drawing.Size(174, 21);
            this.h_comboBox_route.TabIndex = 18;
            // 
            // h_comboBox_class
            // 
            this.h_comboBox_class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.h_comboBox_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.h_comboBox_class.FormattingEnabled = true;
            this.h_comboBox_class.Items.AddRange(new object[] {
            "DEFAULT",
            "BLACK",
            "RED"});
            this.h_comboBox_class.Location = new System.Drawing.Point(85, 102);
            this.h_comboBox_class.Name = "h_comboBox_class";
            this.h_comboBox_class.Size = new System.Drawing.Size(174, 21);
            this.h_comboBox_class.TabIndex = 17;
            // 
            // h_checkBox_target
            // 
            this.h_checkBox_target.AutoSize = true;
            this.h_checkBox_target.Location = new System.Drawing.Point(85, 75);
            this.h_checkBox_target.Name = "h_checkBox_target";
            this.h_checkBox_target.Size = new System.Drawing.Size(68, 17);
            this.h_checkBox_target.TabIndex = 16;
            this.h_checkBox_target.Text = "Is Target";
            this.h_checkBox_target.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Rotation:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // h_textBox_rot
            // 
            this.h_textBox_rot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.h_textBox_rot.Location = new System.Drawing.Point(85, 45);
            this.h_textBox_rot.Name = "h_textBox_rot";
            this.h_textBox_rot.Size = new System.Drawing.Size(174, 20);
            this.h_textBox_rot.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Coordinates:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // h_textBox_zcoord
            // 
            this.h_textBox_zcoord.Location = new System.Drawing.Point(205, 19);
            this.h_textBox_zcoord.Name = "h_textBox_zcoord";
            this.h_textBox_zcoord.Size = new System.Drawing.Size(54, 20);
            this.h_textBox_zcoord.TabIndex = 23;
            // 
            // h_textBox_ycoord
            // 
            this.h_textBox_ycoord.Location = new System.Drawing.Point(145, 19);
            this.h_textBox_ycoord.Name = "h_textBox_ycoord";
            this.h_textBox_ycoord.Size = new System.Drawing.Size(54, 20);
            this.h_textBox_ycoord.TabIndex = 22;
            // 
            // h_textBox_xcoord
            // 
            this.h_textBox_xcoord.Location = new System.Drawing.Point(85, 19);
            this.h_textBox_xcoord.Name = "h_textBox_xcoord";
            this.h_textBox_xcoord.Size = new System.Drawing.Size(54, 20);
            this.h_textBox_xcoord.TabIndex = 21;
            // 
            // HelicopterBoxF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.h_groupBox_main);
            this.Name = "HelicopterBoxF";
            this.Size = new System.Drawing.Size(268, 156);
            this.h_groupBox_main.ResumeLayout(false);
            this.h_groupBox_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox h_groupBox_main;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox h_comboBox_route;
        public System.Windows.Forms.ComboBox h_comboBox_class;
        public System.Windows.Forms.CheckBox h_checkBox_target;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox h_textBox_rot;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox h_textBox_zcoord;
        public System.Windows.Forms.TextBox h_textBox_ycoord;
        public System.Windows.Forms.TextBox h_textBox_xcoord;
    }
}
