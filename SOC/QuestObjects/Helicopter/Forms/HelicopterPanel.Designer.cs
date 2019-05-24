namespace SOC.QuestObjects.Helicopter.Forms
{
    partial class HelicopterPanel
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
            this.groupHeliDet = new System.Windows.Forms.GroupBox();
            this.panelHeliDet = new System.Windows.Forms.Panel();
            this.label_HeliObjType = new System.Windows.Forms.Label();
            this.comboBox_heliObjType = new System.Windows.Forms.ComboBox();
            this.groupHeliDet.SuspendLayout();
            this.panelHeliDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupHeliDet
            // 
            this.groupHeliDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupHeliDet.Controls.Add(this.panelHeliDet);
            this.groupHeliDet.Location = new System.Drawing.Point(0, 0);
            this.groupHeliDet.Name = "groupHeliDet";
            this.groupHeliDet.Size = new System.Drawing.Size(264, 449);
            this.groupHeliDet.TabIndex = 36;
            this.groupHeliDet.TabStop = false;
            this.groupHeliDet.Text = "Enemy Helicopter";
            // 
            // panelHeliDet
            // 
            this.panelHeliDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeliDet.AutoScroll = true;
            this.panelHeliDet.Controls.Add(this.label_HeliObjType);
            this.panelHeliDet.Controls.Add(this.comboBox_heliObjType);
            this.panelHeliDet.Location = new System.Drawing.Point(3, 16);
            this.panelHeliDet.Name = "panelHeliDet";
            this.panelHeliDet.Size = new System.Drawing.Size(258, 424);
            this.panelHeliDet.TabIndex = 0;
            // 
            // label_HeliObjType
            // 
            this.label_HeliObjType.AutoSize = true;
            this.label_HeliObjType.Enabled = false;
            this.label_HeliObjType.Location = new System.Drawing.Point(3, 3);
            this.label_HeliObjType.Name = "label_HeliObjType";
            this.label_HeliObjType.Size = new System.Drawing.Size(116, 13);
            this.label_HeliObjType.TabIndex = 13;
            this.label_HeliObjType.Text = "Target Objective Type:";
            // 
            // comboBox_heliObjType
            // 
            this.comboBox_heliObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_heliObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_heliObjType.Enabled = false;
            this.comboBox_heliObjType.FormattingEnabled = true;
            this.comboBox_heliObjType.Items.AddRange(new object[] {
            "KILLREQUIRED"});
            this.comboBox_heliObjType.Location = new System.Drawing.Point(125, 0);
            this.comboBox_heliObjType.Name = "comboBox_heliObjType";
            this.comboBox_heliObjType.Size = new System.Drawing.Size(130, 21);
            this.comboBox_heliObjType.TabIndex = 12;
            // 
            // HelicopterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupHeliDet);
            this.Name = "HelicopterPanel";
            this.Size = new System.Drawing.Size(264, 449);
            this.groupHeliDet.ResumeLayout(false);
            this.panelHeliDet.ResumeLayout(false);
            this.panelHeliDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupHeliDet;
        public System.Windows.Forms.Panel panelHeliDet;
        private System.Windows.Forms.Label label_HeliObjType;
        private System.Windows.Forms.ComboBox comboBox_heliObjType;
    }
}
