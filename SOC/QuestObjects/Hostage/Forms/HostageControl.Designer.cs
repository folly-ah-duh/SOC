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
            this.groupboxDetail = new System.Windows.Forms.GroupBox();
            this.panelQuestBoxes = new System.Windows.Forms.FlowLayoutPanel();
            this.label_ObjType = new System.Windows.Forms.Label();
            this.comboBox_ObjType = new System.Windows.Forms.ComboBox();
            this.checkBox_intrgt = new System.Windows.Forms.CheckBox();
            this.label_Body = new System.Windows.Forms.Label();
            this.comboBox_Body = new System.Windows.Forms.ComboBox();
            this.groupboxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxDetail
            // 
            this.groupboxDetail.Controls.Add(this.panelQuestBoxes);
            this.groupboxDetail.Controls.Add(this.label_ObjType);
            this.groupboxDetail.Controls.Add(this.comboBox_ObjType);
            this.groupboxDetail.Controls.Add(this.checkBox_intrgt);
            this.groupboxDetail.Controls.Add(this.label_Body);
            this.groupboxDetail.Controls.Add(this.comboBox_Body);
            this.groupboxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupboxDetail.Location = new System.Drawing.Point(0, 0);
            this.groupboxDetail.Name = "groupboxDetail";
            this.groupboxDetail.Size = new System.Drawing.Size(300, 449);
            this.groupboxDetail.TabIndex = 2;
            this.groupboxDetail.TabStop = false;
            this.groupboxDetail.Text = "Prisoners";
            // 
            // panelQuestBoxes
            // 
            this.panelQuestBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestBoxes.AutoScroll = true;
            this.panelQuestBoxes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelQuestBoxes.Location = new System.Drawing.Point(3, 119);
            this.panelQuestBoxes.Margin = new System.Windows.Forms.Padding(0);
            this.panelQuestBoxes.Name = "panelQuestBoxes";
            this.panelQuestBoxes.Size = new System.Drawing.Size(294, 327);
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
            this.label_ObjType.TabIndex = 13;
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
            this.comboBox_ObjType.TabIndex = 12;
            // 
            // checkBox_intrgt
            // 
            this.checkBox_intrgt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_intrgt.AutoSize = true;
            this.checkBox_intrgt.Location = new System.Drawing.Point(6, 99);
            this.checkBox_intrgt.Name = "checkBox_intrgt";
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
            this.Controls.Add(this.groupboxDetail);
            this.Name = "HostageControl";
            this.Size = new System.Drawing.Size(300, 449);
            this.groupboxDetail.ResumeLayout(false);
            this.groupboxDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupboxDetail;
        private System.Windows.Forms.Label label_ObjType;
        public System.Windows.Forms.CheckBox checkBox_intrgt;
        public System.Windows.Forms.ComboBox comboBox_Body;
        private System.Windows.Forms.Label label_Body;
        public System.Windows.Forms.ComboBox comboBox_ObjType;
        public System.Windows.Forms.FlowLayoutPanel panelQuestBoxes;
    }
}
