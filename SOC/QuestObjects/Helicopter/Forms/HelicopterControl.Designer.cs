namespace SOC.QuestObjects.Helicopter
{
    partial class HelicopterControl
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
            this.label_HeliObjType = new System.Windows.Forms.Label();
            this.comboBox_heliObjType = new System.Windows.Forms.ComboBox();
            this.panelHeliDet = new System.Windows.Forms.FlowLayoutPanel();
            this.groupHeliDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupHeliDet
            // 
            this.groupHeliDet.Controls.Add(this.label_HeliObjType);
            this.groupHeliDet.Controls.Add(this.comboBox_heliObjType);
            this.groupHeliDet.Controls.Add(this.panelHeliDet);
            this.groupHeliDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupHeliDet.Location = new System.Drawing.Point(0, 0);
            this.groupHeliDet.Name = "groupHeliDet";
            this.groupHeliDet.Size = new System.Drawing.Size(300, 449);
            this.groupHeliDet.TabIndex = 36;
            this.groupHeliDet.TabStop = false;
            this.groupHeliDet.Text = "Enemy Helicopter";
            // 
            // label_HeliObjType
            // 
            this.label_HeliObjType.AutoSize = true;
            this.label_HeliObjType.Location = new System.Drawing.Point(6, 16);
            this.label_HeliObjType.Name = "label_HeliObjType";
            this.label_HeliObjType.Size = new System.Drawing.Size(113, 13);
            this.label_HeliObjType.TabIndex = 16;
            this.label_HeliObjType.Text = "Target Objective Type";
            // 
            // comboBox_heliObjType
            // 
            this.comboBox_heliObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_heliObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_heliObjType.FormattingEnabled = true;
            this.comboBox_heliObjType.Items.AddRange(new object[] {
            "KILLREQUIRED"});
            this.comboBox_heliObjType.Location = new System.Drawing.Point(6, 32);
            this.comboBox_heliObjType.Name = "comboBox_heliObjType";
            this.comboBox_heliObjType.Size = new System.Drawing.Size(288, 21);
            this.comboBox_heliObjType.TabIndex = 15;
            // 
            // panelHeliDet
            // 
            this.panelHeliDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeliDet.AutoScroll = true;
            this.panelHeliDet.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelHeliDet.Location = new System.Drawing.Point(3, 56);
            this.panelHeliDet.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeliDet.Name = "panelHeliDet";
            this.panelHeliDet.Size = new System.Drawing.Size(294, 390);
            this.panelHeliDet.TabIndex = 17;
            this.panelHeliDet.WrapContents = false;
            // 
            // HelicopterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupHeliDet);
            this.Name = "HelicopterControl";
            this.Size = new System.Drawing.Size(300, 449);
            this.groupHeliDet.ResumeLayout(false);
            this.groupHeliDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupHeliDet;
        public System.Windows.Forms.Label label_HeliObjType;
        public System.Windows.Forms.ComboBox comboBox_heliObjType;
        public System.Windows.Forms.FlowLayoutPanel panelHeliDet;
    }
}
