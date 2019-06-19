namespace SOC.QuestObjects.Model
{
    partial class ModelBox
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
            this.textBox_wrot = new System.Windows.Forms.TextBox();
            this.textBox_zrot = new System.Windows.Forms.TextBox();
            this.textBox_yrot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_model = new System.Windows.Forms.ComboBox();
            this.textBox_xrot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_zcoord = new System.Windows.Forms.TextBox();
            this.textBox_ycoord = new System.Windows.Forms.TextBox();
            this.textBox_xcoord = new System.Windows.Forms.TextBox();
            this.checkBox_collision = new System.Windows.Forms.CheckBox();
            this.groupBox_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_groupBox_main
            // 
            this.groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox_main.Controls.Add(this.checkBox_collision);
            this.groupBox_main.Controls.Add(this.textBox_wrot);
            this.groupBox_main.Controls.Add(this.textBox_zrot);
            this.groupBox_main.Controls.Add(this.textBox_yrot);
            this.groupBox_main.Controls.Add(this.label5);
            this.groupBox_main.Controls.Add(this.label2);
            this.groupBox_main.Controls.Add(this.comboBox_model);
            this.groupBox_main.Controls.Add(this.textBox_xrot);
            this.groupBox_main.Controls.Add(this.label1);
            this.groupBox_main.Controls.Add(this.textBox_zcoord);
            this.groupBox_main.Controls.Add(this.textBox_ycoord);
            this.groupBox_main.Controls.Add(this.textBox_xcoord);
            this.groupBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_main.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_main.Location = new System.Drawing.Point(0, 0);
            this.groupBox_main.Name = "m_groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(268, 125);
            this.groupBox_main.TabIndex = 2;
            this.groupBox_main.TabStop = false;
            this.groupBox_main.Text = "ModelBox";
            // 
            // m_textBox_wrot
            // 
            this.textBox_wrot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_wrot.Location = new System.Drawing.Point(220, 45);
            this.textBox_wrot.Name = "m_textBox_wrot";
            this.textBox_wrot.Size = new System.Drawing.Size(39, 20);
            this.textBox_wrot.TabIndex = 18;
            // 
            // m_textBox_zrot
            // 
            this.textBox_zrot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_zrot.Location = new System.Drawing.Point(175, 45);
            this.textBox_zrot.Name = "m_textBox_zrot";
            this.textBox_zrot.Size = new System.Drawing.Size(39, 20);
            this.textBox_zrot.TabIndex = 17;
            // 
            // m_textBox_yrot
            // 
            this.textBox_yrot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_yrot.Location = new System.Drawing.Point(130, 45);
            this.textBox_yrot.Name = "m_textBox_yrot";
            this.textBox_yrot.Size = new System.Drawing.Size(39, 20);
            this.textBox_yrot.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Model:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rotation:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_comboBox_model
            // 
            this.comboBox_model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_model.FormattingEnabled = true;
            this.comboBox_model.Location = new System.Drawing.Point(85, 71);
            this.comboBox_model.Name = "m_comboBox_model";
            this.comboBox_model.Size = new System.Drawing.Size(174, 21);
            this.comboBox_model.TabIndex = 10;
            this.comboBox_model.SelectedIndexChanged += new System.EventHandler(this.m_comboBox_model_selectedIndexChanged);
            // 
            // m_textBox_xrot
            // 
            this.textBox_xrot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_xrot.Location = new System.Drawing.Point(85, 45);
            this.textBox_xrot.Name = "m_textBox_xrot";
            this.textBox_xrot.Size = new System.Drawing.Size(39, 20);
            this.textBox_xrot.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coordinates:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_textBox_zcoord
            // 
            this.textBox_zcoord.Location = new System.Drawing.Point(205, 19);
            this.textBox_zcoord.Name = "m_textBox_zcoord";
            this.textBox_zcoord.Size = new System.Drawing.Size(54, 20);
            this.textBox_zcoord.TabIndex = 2;
            // 
            // m_textBox_ycoord
            // 
            this.textBox_ycoord.Location = new System.Drawing.Point(145, 19);
            this.textBox_ycoord.Name = "m_textBox_ycoord";
            this.textBox_ycoord.Size = new System.Drawing.Size(54, 20);
            this.textBox_ycoord.TabIndex = 1;
            // 
            // m_textBox_xcoord
            // 
            this.textBox_xcoord.Location = new System.Drawing.Point(85, 19);
            this.textBox_xcoord.Name = "m_textBox_xcoord";
            this.textBox_xcoord.Size = new System.Drawing.Size(54, 20);
            this.textBox_xcoord.TabIndex = 0;
            // 
            // m_checkBox_collision
            // 
            this.checkBox_collision.AutoSize = true;
            this.checkBox_collision.Location = new System.Drawing.Point(85, 100);
            this.checkBox_collision.Name = "m_checkBox_collision";
            this.checkBox_collision.Size = new System.Drawing.Size(100, 17);
            this.checkBox_collision.TabIndex = 19;
            this.checkBox_collision.Text = "Enable Collision";
            this.checkBox_collision.UseVisualStyleBackColor = true;
            // 
            // ModelBoxF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_main);
            this.Name = "ModelBoxF";
            this.Size = new System.Drawing.Size(268, 125);
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_main;
        public System.Windows.Forms.TextBox textBox_wrot;
        public System.Windows.Forms.TextBox textBox_zrot;
        public System.Windows.Forms.TextBox textBox_yrot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBox_model;
        public System.Windows.Forms.TextBox textBox_xrot;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_zcoord;
        public System.Windows.Forms.TextBox textBox_ycoord;
        public System.Windows.Forms.TextBox textBox_xcoord;
        public System.Windows.Forms.CheckBox checkBox_collision;
    }
}
