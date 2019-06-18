namespace SOC.QuestObjects.ActiveItem
{
    partial class ActiveItemControl
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
            this.label_ObjType = new System.Windows.Forms.Label();
            this.panelQuestBoxes = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox_ObjType = new System.Windows.Forms.ComboBox();
            this.groupActiveItemDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupActiveItemDet
            // 
            this.groupActiveItemDet.Controls.Add(this.label_ObjType);
            this.groupActiveItemDet.Controls.Add(this.panelQuestBoxes);
            this.groupActiveItemDet.Controls.Add(this.comboBox_ObjType);
            this.groupActiveItemDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupActiveItemDet.Location = new System.Drawing.Point(0, 0);
            this.groupActiveItemDet.Name = "groupActiveItemDet";
            this.groupActiveItemDet.Size = new System.Drawing.Size(300, 449);
            this.groupActiveItemDet.TabIndex = 29;
            this.groupActiveItemDet.TabStop = false;
            this.groupActiveItemDet.Text = "Active Items";
            // 
            // label_ObjType
            // 
            this.label_ObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ObjType.AutoSize = true;
            this.label_ObjType.Location = new System.Drawing.Point(6, 16);
            this.label_ObjType.Name = "label_ObjType";
            this.label_ObjType.Size = new System.Drawing.Size(116, 13);
            this.label_ObjType.TabIndex = 35;
            this.label_ObjType.Text = "Target Objective Type:";
            // 
            // panelQuestBoxes
            // 
            this.panelQuestBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestBoxes.AutoScroll = true;
            this.panelQuestBoxes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelQuestBoxes.Location = new System.Drawing.Point(3, 59);
            this.panelQuestBoxes.Name = "panelQuestBoxes";
            this.panelQuestBoxes.Size = new System.Drawing.Size(294, 387);
            this.panelQuestBoxes.TabIndex = 36;
            this.panelQuestBoxes.WrapContents = false;
            // 
            // comboBox_ObjType
            // 
            this.comboBox_ObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ObjType.FormattingEnabled = true;
            this.comboBox_ObjType.Items.AddRange(new object[] {
            "ELIMINATE",
            "RECOVERED",
            "KILLREQUIRED"});
            this.comboBox_ObjType.Location = new System.Drawing.Point(6, 32);
            this.comboBox_ObjType.Name = "comboBox_ObjType";
            this.comboBox_ObjType.Size = new System.Drawing.Size(288, 21);
            this.comboBox_ObjType.TabIndex = 34;
            // 
            // ActiveItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupActiveItemDet);
            this.Name = "ActiveItemControl";
            this.Size = new System.Drawing.Size(300, 449);
            this.groupActiveItemDet.ResumeLayout(false);
            this.groupActiveItemDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupActiveItemDet;
        private System.Windows.Forms.Label label_ObjType;
        public System.Windows.Forms.FlowLayoutPanel panelQuestBoxes;
        public System.Windows.Forms.ComboBox comboBox_ObjType;
    }
}
