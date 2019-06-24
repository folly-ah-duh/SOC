namespace SOC.QuestObjects.Enemy
{
    partial class EnemyControl
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
            this.groupboxDetail = new System.Windows.Forms.GroupBox();
            this.panelQuestBoxes = new System.Windows.Forms.FlowLayoutPanel();
            this.label_ObjType = new System.Windows.Forms.Label();
            this.comboBox_ObjType = new System.Windows.Forms.ComboBox();
            this.label_Subtype = new System.Windows.Forms.Label();
            this.comboBox_Subtype = new System.Windows.Forms.ComboBox();
            this.groupboxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxDetail
            // 
            this.groupboxDetail.Controls.Add(this.panelQuestBoxes);
            this.groupboxDetail.Controls.Add(this.label_ObjType);
            this.groupboxDetail.Controls.Add(this.comboBox_ObjType);
            this.groupboxDetail.Controls.Add(this.label_Subtype);
            this.groupboxDetail.Controls.Add(this.comboBox_Subtype);
            this.groupboxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupboxDetail.Location = new System.Drawing.Point(0, 0);
            this.groupboxDetail.Name = "groupboxDetail";
            this.groupboxDetail.Size = new System.Drawing.Size(300, 449);
            this.groupboxDetail.TabIndex = 34;
            this.groupboxDetail.TabStop = false;
            this.groupboxDetail.Text = "Enemies";
            // 
            // panelQuestBoxes
            // 
            this.panelQuestBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestBoxes.AutoScroll = true;
            this.panelQuestBoxes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelQuestBoxes.Location = new System.Drawing.Point(3, 96);
            this.panelQuestBoxes.Margin = new System.Windows.Forms.Padding(0);
            this.panelQuestBoxes.Name = "panelQuestBoxes";
            this.panelQuestBoxes.Size = new System.Drawing.Size(294, 350);
            this.panelQuestBoxes.TabIndex = 3;
            this.panelQuestBoxes.WrapContents = false;
            // 
            // label_ObjType
            // 
            this.label_ObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ObjType.AutoSize = true;
            this.label_ObjType.Location = new System.Drawing.Point(6, 16);
            this.label_ObjType.Name = "label_ObjType";
            this.label_ObjType.Size = new System.Drawing.Size(113, 13);
            this.label_ObjType.TabIndex = 0;
            this.label_ObjType.Text = "Target Objective Type";
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
            this.comboBox_ObjType.TabIndex = 1;
            // 
            // label_Subtype
            // 
            this.label_Subtype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Subtype.AutoSize = true;
            this.label_Subtype.Location = new System.Drawing.Point(6, 56);
            this.label_Subtype.Name = "label_Subtype";
            this.label_Subtype.Size = new System.Drawing.Size(53, 13);
            this.label_Subtype.TabIndex = 0;
            this.label_Subtype.Text = "Sub Type";
            // 
            // comboBox_Subtype
            // 
            this.comboBox_Subtype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Subtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Subtype.FormattingEnabled = true;
            this.comboBox_Subtype.Location = new System.Drawing.Point(6, 72);
            this.comboBox_Subtype.Name = "comboBox_Subtype";
            this.comboBox_Subtype.Size = new System.Drawing.Size(288, 21);
            this.comboBox_Subtype.TabIndex = 2;
            // 
            // EnemyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupboxDetail);
            this.Name = "EnemyControl";
            this.Size = new System.Drawing.Size(300, 449);
            this.groupboxDetail.ResumeLayout(false);
            this.groupboxDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupboxDetail;
        public System.Windows.Forms.FlowLayoutPanel panelQuestBoxes;
        private System.Windows.Forms.Label label_ObjType;
        public System.Windows.Forms.ComboBox comboBox_ObjType;
        private System.Windows.Forms.Label label_Subtype;
        public System.Windows.Forms.ComboBox comboBox_Subtype;
    }
}
