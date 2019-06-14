namespace SOC.QuestObjects.Hostage
{
    partial class HostageControl
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
            this.groupHosDet = new System.Windows.Forms.GroupBox();
            this.panelHosDet = new System.Windows.Forms.FlowLayoutPanel();
            this.label_hosObjType = new System.Windows.Forms.Label();
            this.comboBox_hosObjType = new System.Windows.Forms.ComboBox();
            this.checkBox_intrgt = new System.Windows.Forms.CheckBox();
            this.label_Body = new System.Windows.Forms.Label();
            this.comboBox_Body = new System.Windows.Forms.ComboBox();
            this.groupHosDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupHosDet
            // 
            this.groupHosDet.Controls.Add(this.panelHosDet);
            this.groupHosDet.Controls.Add(this.label_hosObjType);
            this.groupHosDet.Controls.Add(this.comboBox_hosObjType);
            this.groupHosDet.Controls.Add(this.checkBox_intrgt);
            this.groupHosDet.Controls.Add(this.label_Body);
            this.groupHosDet.Controls.Add(this.comboBox_Body);
            this.groupHosDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupHosDet.Location = new System.Drawing.Point(0, 0);
            this.groupHosDet.Name = "groupHosDet";
            this.groupHosDet.Size = new System.Drawing.Size(300, 449);
            this.groupHosDet.TabIndex = 2;
            this.groupHosDet.TabStop = false;
            this.groupHosDet.Text = "Prisoners";
            // 
            // panelHosDet
            // 
            this.panelHosDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHosDet.AutoScroll = true;
            this.panelHosDet.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelHosDet.Location = new System.Drawing.Point(3, 119);
            this.panelHosDet.Margin = new System.Windows.Forms.Padding(0);
            this.panelHosDet.Name = "panelHosDet";
            this.panelHosDet.Size = new System.Drawing.Size(294, 327);
            this.panelHosDet.TabIndex = 3;
            this.panelHosDet.WrapContents = false;
            // 
            // label_hosObjType
            // 
            this.label_hosObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_hosObjType.AutoSize = true;
            this.label_hosObjType.Location = new System.Drawing.Point(6, 16);
            this.label_hosObjType.Name = "label_hosObjType";
            this.label_hosObjType.Size = new System.Drawing.Size(113, 13);
            this.label_hosObjType.TabIndex = 13;
            this.label_hosObjType.Text = "Target Objective Type";
            // 
            // comboBox_hosObjType
            // 
            this.comboBox_hosObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_hosObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hosObjType.FormattingEnabled = true;
            this.comboBox_hosObjType.Items.AddRange(new object[] {
            "ELIMINATE",
            "RECOVERED",
            "KILLREQUIRED"});
            this.comboBox_hosObjType.Location = new System.Drawing.Point(6, 32);
            this.comboBox_hosObjType.Name = "comboBox_hosObjType";
            this.comboBox_hosObjType.Size = new System.Drawing.Size(288, 21);
            this.comboBox_hosObjType.TabIndex = 12;
            // 
            // h_checkBox_intrgt
            // 
            this.checkBox_intrgt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_intrgt.AutoSize = true;
            this.checkBox_intrgt.Location = new System.Drawing.Point(6, 99);
            this.checkBox_intrgt.Name = "h_checkBox_intrgt";
            this.checkBox_intrgt.Size = new System.Drawing.Size(162, 17);
            this.checkBox_intrgt.TabIndex = 0;
            this.checkBox_intrgt.Text = "Interrogate For Whereabouts";
            this.checkBox_intrgt.UseVisualStyleBackColor = true;
            // 
            // label_Body
            // 
            this.label_Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Body.AutoSize = true;
            this.label_Body.Location = new System.Drawing.Point(6, 56);
            this.label_Body.Name = "label_Body";
            this.label_Body.Size = new System.Drawing.Size(31, 13);
            this.label_Body.TabIndex = 2;
            this.label_Body.Text = "Body";
            // 
            // comboBox_Body
            // 
            this.comboBox_Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Body.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Body.FormattingEnabled = true;
            this.comboBox_Body.Location = new System.Drawing.Point(6, 72);
            this.comboBox_Body.Name = "comboBox_Body";
            this.comboBox_Body.Size = new System.Drawing.Size(288, 21);
            this.comboBox_Body.TabIndex = 1;
            // 
            // HostageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupHosDet);
            this.Name = "HostageControl";
            this.Size = new System.Drawing.Size(300, 449);
            this.groupHosDet.ResumeLayout(false);
            this.groupHosDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupHosDet;
        private System.Windows.Forms.Label label_hosObjType;
        public System.Windows.Forms.CheckBox checkBox_intrgt;
        public System.Windows.Forms.ComboBox comboBox_Body;
        private System.Windows.Forms.Label label_Body;
        public System.Windows.Forms.ComboBox comboBox_hosObjType;
        public System.Windows.Forms.FlowLayoutPanel panelHosDet;
    }
}
