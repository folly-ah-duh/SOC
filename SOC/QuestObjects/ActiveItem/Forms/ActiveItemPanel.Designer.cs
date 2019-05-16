namespace SOC.QuestObjects.ActiveItem.Forms
{
    partial class ActiveItemPanel
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
            this.groupActiveItemDet = new System.Windows.Forms.GroupBox();
            this.panelAcItDet = new System.Windows.Forms.Panel();
            this.label_acItObjType = new System.Windows.Forms.Label();
            this.comboBox_acItObjType = new System.Windows.Forms.ComboBox();
            this.groupActiveItemDet.SuspendLayout();
            this.panelAcItDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupActiveItemDet
            // 
            this.groupActiveItemDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupActiveItemDet.Controls.Add(this.panelAcItDet);
            this.groupActiveItemDet.Location = new System.Drawing.Point(0, 0);
            this.groupActiveItemDet.Name = "groupActiveItemDet";
            this.groupActiveItemDet.Size = new System.Drawing.Size(264, 449);
            this.groupActiveItemDet.TabIndex = 29;
            this.groupActiveItemDet.TabStop = false;
            this.groupActiveItemDet.Text = "Active Items";
            // 
            // panelAcItDet
            // 
            this.panelAcItDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAcItDet.AutoScroll = true;
            this.panelAcItDet.Controls.Add(this.label_acItObjType);
            this.panelAcItDet.Controls.Add(this.comboBox_acItObjType);
            this.panelAcItDet.Location = new System.Drawing.Point(3, 16);
            this.panelAcItDet.Name = "panelAcItDet";
            this.panelAcItDet.Size = new System.Drawing.Size(258, 424);
            this.panelAcItDet.TabIndex = 0;
            // 
            // label_acItObjType
            // 
            this.label_acItObjType.AutoSize = true;
            this.label_acItObjType.Location = new System.Drawing.Point(3, 3);
            this.label_acItObjType.Name = "label_acItObjType";
            this.label_acItObjType.Size = new System.Drawing.Size(116, 13);
            this.label_acItObjType.TabIndex = 19;
            this.label_acItObjType.Text = "Target Objective Type:";
            // 
            // comboBox_acItObjType
            // 
            this.comboBox_acItObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_acItObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_acItObjType.FormattingEnabled = true;
            this.comboBox_acItObjType.Items.AddRange(new object[] {
            "ELIMINATE",
            "RECOVERED",
            "KILLREQUIRED"});
            this.comboBox_acItObjType.Location = new System.Drawing.Point(125, 0);
            this.comboBox_acItObjType.Name = "comboBox_acItObjType";
            this.comboBox_acItObjType.Size = new System.Drawing.Size(130, 21);
            this.comboBox_acItObjType.TabIndex = 18;
            // 
            // ActiveItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupActiveItemDet);
            this.Name = "ActiveItemPanel";
            this.Size = new System.Drawing.Size(264, 449);
            this.groupActiveItemDet.ResumeLayout(false);
            this.panelAcItDet.ResumeLayout(false);
            this.panelAcItDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupActiveItemDet;
        private System.Windows.Forms.Panel panelAcItDet;
        private System.Windows.Forms.Label label_acItObjType;
        private System.Windows.Forms.ComboBox comboBox_acItObjType;
    }
}
