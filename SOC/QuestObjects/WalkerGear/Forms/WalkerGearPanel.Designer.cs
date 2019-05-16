namespace SOC.QuestObjects.WalkerGear.Forms
{
    partial class WalkerGearPanel
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
            this.groupWalkerDet = new System.Windows.Forms.GroupBox();
            this.panelWalkerDet = new System.Windows.Forms.Panel();
            this.label_WalkerObjType = new System.Windows.Forms.Label();
            this.comboBox_WalkerObjType = new System.Windows.Forms.ComboBox();
            this.groupWalkerDet.SuspendLayout();
            this.panelWalkerDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupWalkerDet
            // 
            this.groupWalkerDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupWalkerDet.Controls.Add(this.panelWalkerDet);
            this.groupWalkerDet.Location = new System.Drawing.Point(0, 0);
            this.groupWalkerDet.Name = "groupWalkerDet";
            this.groupWalkerDet.Size = new System.Drawing.Size(264, 449);
            this.groupWalkerDet.TabIndex = 37;
            this.groupWalkerDet.TabStop = false;
            this.groupWalkerDet.Text = "Walker Gears";
            // 
            // panelWalkerDet
            // 
            this.panelWalkerDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWalkerDet.AutoScroll = true;
            this.panelWalkerDet.Controls.Add(this.label_WalkerObjType);
            this.panelWalkerDet.Controls.Add(this.comboBox_WalkerObjType);
            this.panelWalkerDet.Location = new System.Drawing.Point(3, 16);
            this.panelWalkerDet.Name = "panelWalkerDet";
            this.panelWalkerDet.Size = new System.Drawing.Size(258, 424);
            this.panelWalkerDet.TabIndex = 0;
            // 
            // label_WalkerObjType
            // 
            this.label_WalkerObjType.AutoSize = true;
            this.label_WalkerObjType.Location = new System.Drawing.Point(3, 3);
            this.label_WalkerObjType.Name = "label_WalkerObjType";
            this.label_WalkerObjType.Size = new System.Drawing.Size(116, 13);
            this.label_WalkerObjType.TabIndex = 13;
            this.label_WalkerObjType.Text = "Target Objective Type:";
            // 
            // comboBox_WalkerObjType
            // 
            this.comboBox_WalkerObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_WalkerObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_WalkerObjType.FormattingEnabled = true;
            this.comboBox_WalkerObjType.Items.AddRange(new object[] {
            "ELIMINATE",
            "RECOVERED",
            "KILLREQUIRED"});
            this.comboBox_WalkerObjType.Location = new System.Drawing.Point(125, 0);
            this.comboBox_WalkerObjType.Name = "comboBox_WalkerObjType";
            this.comboBox_WalkerObjType.Size = new System.Drawing.Size(130, 21);
            this.comboBox_WalkerObjType.TabIndex = 12;
            // 
            // WalkerGearPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupWalkerDet);
            this.Name = "WalkerGearPanel";
            this.Size = new System.Drawing.Size(264, 449);
            this.groupWalkerDet.ResumeLayout(false);
            this.panelWalkerDet.ResumeLayout(false);
            this.panelWalkerDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupWalkerDet;
        public System.Windows.Forms.Panel panelWalkerDet;
        public System.Windows.Forms.Label label_WalkerObjType;
        public System.Windows.Forms.ComboBox comboBox_WalkerObjType;
    }
}
