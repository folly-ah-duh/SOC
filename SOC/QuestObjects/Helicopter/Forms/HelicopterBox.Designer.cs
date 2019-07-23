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
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_route = new System.Windows.Forms.ComboBox();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.checkBox_target = new System.Windows.Forms.CheckBox();
            this.groupBox_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_main
            // 
            this.groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox_main.Controls.Add(this.label4);
            this.groupBox_main.Controls.Add(this.label3);
            this.groupBox_main.Controls.Add(this.comboBox_route);
            this.groupBox_main.Controls.Add(this.comboBox_class);
            this.groupBox_main.Controls.Add(this.checkBox_target);
            this.groupBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_main.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_main.Location = new System.Drawing.Point(0, 0);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(268, 156);
            this.groupBox_main.TabIndex = 2;
            this.groupBox_main.TabStop = false;
            this.groupBox_main.Text = "HelicopterBox";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Route:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Class:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_route
            // 
            this.comboBox_route.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_route.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_route.FormattingEnabled = true;
            this.comboBox_route.Location = new System.Drawing.Point(85, 69);
            this.comboBox_route.Name = "comboBox_route";
            this.comboBox_route.Size = new System.Drawing.Size(174, 21);
            this.comboBox_route.TabIndex = 6;
            // 
            // comboBox_class
            // 
            this.comboBox_class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            "DEFAULT",
            "BLACK",
            "RED"});
            this.comboBox_class.Location = new System.Drawing.Point(85, 42);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(174, 21);
            this.comboBox_class.TabIndex = 5;
            // 
            // checkBox_target
            // 
            this.checkBox_target.AutoSize = true;
            this.checkBox_target.Location = new System.Drawing.Point(85, 19);
            this.checkBox_target.Name = "checkBox_target";
            this.checkBox_target.Size = new System.Drawing.Size(68, 17);
            this.checkBox_target.TabIndex = 0;
            this.checkBox_target.TabStop = false;
            this.checkBox_target.Text = "Is Target";
            this.checkBox_target.UseVisualStyleBackColor = true;
            // 
            // HelicopterBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_main);
            this.Name = "HelicopterBox";
            this.Size = new System.Drawing.Size(268, 156);
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_main;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox_route;
        public System.Windows.Forms.ComboBox comboBox_class;
        public System.Windows.Forms.CheckBox checkBox_target;
    }
}
