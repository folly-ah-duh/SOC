namespace SOC.QuestObjects.Item
{
    partial class ItemControl
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
            this.label_itemObjType = new System.Windows.Forms.Label();
            this.comboBox_itemObjType = new System.Windows.Forms.ComboBox();
            this.panelItemDet = new System.Windows.Forms.FlowLayoutPanel();
            this.groupItemDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDet
            // 
            this.groupItemDet.Controls.Add(this.label_itemObjType);
            this.groupItemDet.Controls.Add(this.panelItemDet);
            this.groupItemDet.Controls.Add(this.comboBox_itemObjType);
            this.groupItemDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupItemDet.Location = new System.Drawing.Point(0, 0);
            this.groupItemDet.Name = "groupItemDet";
            this.groupItemDet.Size = new System.Drawing.Size(300, 449);
            this.groupItemDet.TabIndex = 30;
            this.groupItemDet.TabStop = false;
            this.groupItemDet.Text = "Dormant Items";
            // 
            // label_itemObjType
            // 
            this.label_itemObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_itemObjType.AutoSize = true;
            this.label_itemObjType.Location = new System.Drawing.Point(6, 16);
            this.label_itemObjType.Name = "label_itemObjType";
            this.label_itemObjType.Size = new System.Drawing.Size(116, 13);
            this.label_itemObjType.TabIndex = 32;
            this.label_itemObjType.Text = "Target Objective Type:";
            // 
            // comboBox_itemObjType
            // 
            this.comboBox_itemObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_itemObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_itemObjType.FormattingEnabled = true;
            this.comboBox_itemObjType.Items.AddRange(new object[] {
            "RECOVERED"});
            this.comboBox_itemObjType.Location = new System.Drawing.Point(6, 32);
            this.comboBox_itemObjType.Name = "comboBox_itemObjType";
            this.comboBox_itemObjType.Size = new System.Drawing.Size(288, 21);
            this.comboBox_itemObjType.TabIndex = 31;
            // 
            // panelItemDet
            // 
            this.panelItemDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelItemDet.AutoScroll = true;
            this.panelItemDet.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelItemDet.Location = new System.Drawing.Point(3, 59);
            this.panelItemDet.Name = "panelItemDet";
            this.panelItemDet.Size = new System.Drawing.Size(294, 387);
            this.panelItemDet.TabIndex = 33;
            this.panelItemDet.WrapContents = false;
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupItemDet);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(300, 449);
            this.groupItemDet.ResumeLayout(false);
            this.groupItemDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupItemDet;
        private System.Windows.Forms.Label label_itemObjType;
        public System.Windows.Forms.FlowLayoutPanel panelItemDet;
        public System.Windows.Forms.ComboBox comboBox_itemObjType;
    }
}
