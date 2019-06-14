namespace SOC.QuestObjects.Model
{
    partial class ModelControl
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
            this.groupboxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxDetail
            // 
            this.groupboxDetail.Controls.Add(this.panelQuestBoxes);
            this.groupboxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupboxDetail.Location = new System.Drawing.Point(0, 0);
            this.groupboxDetail.Name = "groupboxDetail";
            this.groupboxDetail.Size = new System.Drawing.Size(300, 449);
            this.groupboxDetail.TabIndex = 32;
            this.groupboxDetail.TabStop = false;
            this.groupboxDetail.Text = "Static Models";
            // 
            // panelQuestBoxes
            // 
            this.panelQuestBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestBoxes.AutoScroll = true;
            this.panelQuestBoxes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelQuestBoxes.Location = new System.Drawing.Point(3, 16);
            this.panelQuestBoxes.Margin = new System.Windows.Forms.Padding(0);
            this.panelQuestBoxes.Name = "panelQuestBoxes";
            this.panelQuestBoxes.Size = new System.Drawing.Size(294, 430);
            this.panelQuestBoxes.TabIndex = 4;
            this.panelQuestBoxes.WrapContents = false;
            // 
            // ModelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupboxDetail);
            this.Name = "ModelControl";
            this.Size = new System.Drawing.Size(300, 449);
            this.groupboxDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupboxDetail;
        public System.Windows.Forms.FlowLayoutPanel panelQuestBoxes;
    }
}
