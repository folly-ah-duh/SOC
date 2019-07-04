namespace SOC.QuestObjects.Camera
{
    partial class CameraBox
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
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.checkBox_weapon = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_target = new System.Windows.Forms.CheckBox();
            this.textBox_rot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_zcoord = new System.Windows.Forms.TextBox();
            this.textBox_ycoord = new System.Windows.Forms.TextBox();
            this.textBox_xcoord = new System.Windows.Forms.TextBox();
            this.groupBox_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_main
            // 
            this.groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox_main.Controls.Add(this.checkBox_weapon);
            this.groupBox_main.Controls.Add(this.label2);
            this.groupBox_main.Controls.Add(this.checkBox_target);
            this.groupBox_main.Controls.Add(this.textBox_rot);
            this.groupBox_main.Controls.Add(this.label1);
            this.groupBox_main.Controls.Add(this.textBox_zcoord);
            this.groupBox_main.Controls.Add(this.textBox_ycoord);
            this.groupBox_main.Controls.Add(this.textBox_xcoord);
            this.groupBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_main.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_main.Location = new System.Drawing.Point(0, 0);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(268, 98);
            this.groupBox_main.TabIndex = 1;
            this.groupBox_main.TabStop = false;
            this.groupBox_main.Text = "CameraBox";
            // 
            // checkBox_weapon
            // 
            this.checkBox_weapon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_weapon.AutoSize = true;
            this.checkBox_weapon.Location = new System.Drawing.Point(171, 75);
            this.checkBox_weapon.Name = "checkBox_weapon";
            this.checkBox_weapon.Size = new System.Drawing.Size(67, 17);
            this.checkBox_weapon.TabIndex = 7;
            this.checkBox_weapon.TabStop = false;
            this.checkBox_weapon.Text = "Weapon";
            this.checkBox_weapon.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rotation:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox_target
            // 
            this.checkBox_target.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_target.AutoSize = true;
            this.checkBox_target.Location = new System.Drawing.Point(85, 75);
            this.checkBox_target.Name = "checkBox_target";
            this.checkBox_target.Size = new System.Drawing.Size(68, 17);
            this.checkBox_target.TabIndex = 0;
            this.checkBox_target.TabStop = false;
            this.checkBox_target.Text = "Is Target";
            this.checkBox_target.UseVisualStyleBackColor = true;
            // 
            // textBox_rot
            // 
            this.textBox_rot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_rot.Location = new System.Drawing.Point(85, 45);
            this.textBox_rot.Name = "textBox_rot";
            this.textBox_rot.Size = new System.Drawing.Size(174, 20);
            this.textBox_rot.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coordinates:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_zcoord
            // 
            this.textBox_zcoord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_zcoord.Location = new System.Drawing.Point(205, 19);
            this.textBox_zcoord.Name = "textBox_zcoord";
            this.textBox_zcoord.Size = new System.Drawing.Size(54, 20);
            this.textBox_zcoord.TabIndex = 3;
            // 
            // textBox_ycoord
            // 
            this.textBox_ycoord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_ycoord.Location = new System.Drawing.Point(145, 19);
            this.textBox_ycoord.Name = "textBox_ycoord";
            this.textBox_ycoord.Size = new System.Drawing.Size(54, 20);
            this.textBox_ycoord.TabIndex = 2;
            // 
            // textBox_xcoord
            // 
            this.textBox_xcoord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_xcoord.Location = new System.Drawing.Point(85, 19);
            this.textBox_xcoord.Name = "textBox_xcoord";
            this.textBox_xcoord.Size = new System.Drawing.Size(54, 20);
            this.textBox_xcoord.TabIndex = 1;
            // 
            // CameraBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_main);
            this.Name = "CameraBox";
            this.Size = new System.Drawing.Size(268, 98);
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_main;
        public System.Windows.Forms.CheckBox checkBox_weapon;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox checkBox_target;
        public System.Windows.Forms.TextBox textBox_rot;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_zcoord;
        public System.Windows.Forms.TextBox textBox_ycoord;
        public System.Windows.Forms.TextBox textBox_xcoord;
    }
}
