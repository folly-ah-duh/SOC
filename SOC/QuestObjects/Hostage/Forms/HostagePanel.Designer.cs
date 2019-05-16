namespace SOC.QuestObjects.Hostage.Forms
{
    partial class HostagePanel
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
            this.panelHosDet = new System.Windows.Forms.Panel();
            this.label_hosObjType = new System.Windows.Forms.Label();
            this.comboBox_hosObjType = new System.Windows.Forms.ComboBox();
            this.h_label_intrgt = new System.Windows.Forms.Label();
            this.h_checkBox_intrgt = new System.Windows.Forms.CheckBox();
            this.comboBox_Body = new System.Windows.Forms.ComboBox();
            this.label_Body = new System.Windows.Forms.Label();
            this.groupHosDet.SuspendLayout();
            this.panelHosDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupHosDet
            // 
            this.groupHosDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupHosDet.Controls.Add(this.panelHosDet);
            this.groupHosDet.Location = new System.Drawing.Point(0, 0);
            this.groupHosDet.Name = "groupHosDet";
            this.groupHosDet.Size = new System.Drawing.Size(264, 449);
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
            this.panelHosDet.Controls.Add(this.label_hosObjType);
            this.panelHosDet.Controls.Add(this.comboBox_hosObjType);
            this.panelHosDet.Controls.Add(this.h_label_intrgt);
            this.panelHosDet.Controls.Add(this.h_checkBox_intrgt);
            this.panelHosDet.Controls.Add(this.comboBox_Body);
            this.panelHosDet.Controls.Add(this.label_Body);
            this.panelHosDet.Location = new System.Drawing.Point(3, 16);
            this.panelHosDet.Name = "panelHosDet";
            this.panelHosDet.Size = new System.Drawing.Size(258, 424);
            this.panelHosDet.TabIndex = 0;
            // 
            // label_hosObjType
            // 
            this.label_hosObjType.AutoSize = true;
            this.label_hosObjType.Location = new System.Drawing.Point(3, 3);
            this.label_hosObjType.Name = "label_hosObjType";
            this.label_hosObjType.Size = new System.Drawing.Size(116, 13);
            this.label_hosObjType.TabIndex = 13;
            this.label_hosObjType.Text = "Target Objective Type:";
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
            this.comboBox_hosObjType.Location = new System.Drawing.Point(125, 0);
            this.comboBox_hosObjType.Name = "comboBox_hosObjType";
            this.comboBox_hosObjType.Size = new System.Drawing.Size(130, 21);
            this.comboBox_hosObjType.TabIndex = 12;
            // 
            // h_label_intrgt
            // 
            this.h_label_intrgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.h_label_intrgt.AutoSize = true;
            this.h_label_intrgt.Location = new System.Drawing.Point(88, 51);
            this.h_label_intrgt.Name = "h_label_intrgt";
            this.h_label_intrgt.Size = new System.Drawing.Size(146, 13);
            this.h_label_intrgt.TabIndex = 0;
            this.h_label_intrgt.Text = "Interrogate For Whereabouts:";
            // 
            // h_checkBox_intrgt
            // 
            this.h_checkBox_intrgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.h_checkBox_intrgt.AutoSize = true;
            this.h_checkBox_intrgt.Location = new System.Drawing.Point(240, 51);
            this.h_checkBox_intrgt.Name = "h_checkBox_intrgt";
            this.h_checkBox_intrgt.Size = new System.Drawing.Size(15, 14);
            this.h_checkBox_intrgt.TabIndex = 0;
            this.h_checkBox_intrgt.UseVisualStyleBackColor = true;
            // 
            // comboBox_Body
            // 
            this.comboBox_Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Body.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Body.FormattingEnabled = true;
            this.comboBox_Body.Location = new System.Drawing.Point(125, 24);
            this.comboBox_Body.Name = "comboBox_Body";
            this.comboBox_Body.Size = new System.Drawing.Size(130, 21);
            this.comboBox_Body.TabIndex = 1;
            // 
            // label_Body
            // 
            this.label_Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Body.AutoSize = true;
            this.label_Body.Location = new System.Drawing.Point(85, 27);
            this.label_Body.Name = "label_Body";
            this.label_Body.Size = new System.Drawing.Size(34, 13);
            this.label_Body.TabIndex = 2;
            this.label_Body.Text = "Body:";
            // 
            // HostagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupHosDet);
            this.Name = "HostagePanel";
            this.Size = new System.Drawing.Size(264, 449);
            this.groupHosDet.ResumeLayout(false);
            this.panelHosDet.ResumeLayout(false);
            this.panelHosDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupHosDet;
        public System.Windows.Forms.Panel panelHosDet;
        private System.Windows.Forms.Label label_hosObjType;
        private System.Windows.Forms.ComboBox comboBox_hosObjType;
        private System.Windows.Forms.Label h_label_intrgt;
        public System.Windows.Forms.CheckBox h_checkBox_intrgt;
        public System.Windows.Forms.ComboBox comboBox_Body;
        private System.Windows.Forms.Label label_Body;
    }
}
