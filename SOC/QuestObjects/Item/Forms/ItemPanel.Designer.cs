namespace SOC.QuestObjects.Item.Forms
{
    partial class ItemPanel
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
            this.groupItemDet = new System.Windows.Forms.GroupBox();
            this.panelItemDet = new System.Windows.Forms.Panel();
            this.label_ItObjType = new System.Windows.Forms.Label();
            this.comboBox_itObjType = new System.Windows.Forms.ComboBox();
            this.groupItemDet.SuspendLayout();
            this.panelItemDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDet
            // 
            this.groupItemDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupItemDet.Controls.Add(this.panelItemDet);
            this.groupItemDet.Location = new System.Drawing.Point(0, 0);
            this.groupItemDet.Name = "groupItemDet";
            this.groupItemDet.Size = new System.Drawing.Size(264, 449);
            this.groupItemDet.TabIndex = 30;
            this.groupItemDet.TabStop = false;
            this.groupItemDet.Text = "Dormant Items";
            // 
            // panelItemDet
            // 
            this.panelItemDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelItemDet.AutoScroll = true;
            this.panelItemDet.Controls.Add(this.label_ItObjType);
            this.panelItemDet.Controls.Add(this.comboBox_itObjType);
            this.panelItemDet.Location = new System.Drawing.Point(3, 16);
            this.panelItemDet.Name = "panelItemDet";
            this.panelItemDet.Size = new System.Drawing.Size(258, 424);
            this.panelItemDet.TabIndex = 0;
            // 
            // label_ItObjType
            // 
            this.label_ItObjType.AutoSize = true;
            this.label_ItObjType.Enabled = false;
            this.label_ItObjType.Location = new System.Drawing.Point(3, 3);
            this.label_ItObjType.Name = "label_ItObjType";
            this.label_ItObjType.Size = new System.Drawing.Size(116, 13);
            this.label_ItObjType.TabIndex = 19;
            this.label_ItObjType.Text = "Target Objective Type:";
            // 
            // comboBox_itObjType
            // 
            this.comboBox_itObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_itObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_itObjType.Enabled = false;
            this.comboBox_itObjType.FormattingEnabled = true;
            this.comboBox_itObjType.Items.AddRange(new object[] {
            "RECOVERED"});
            this.comboBox_itObjType.Location = new System.Drawing.Point(125, 0);
            this.comboBox_itObjType.Name = "comboBox_itObjType";
            this.comboBox_itObjType.Size = new System.Drawing.Size(130, 21);
            this.comboBox_itObjType.TabIndex = 18;
            // 
            // ItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupItemDet);
            this.Name = "ItemPanel";
            this.Size = new System.Drawing.Size(264, 449);
            this.groupItemDet.ResumeLayout(false);
            this.panelItemDet.ResumeLayout(false);
            this.panelItemDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupItemDet;
        private System.Windows.Forms.Panel panelItemDet;
        private System.Windows.Forms.Label label_ItObjType;
        private System.Windows.Forms.ComboBox comboBox_itObjType;
    }
}
