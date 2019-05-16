namespace SOC.QuestObjects.Model.Forms
{
    partial class ModelPanel
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
            this.groupStMdDet = new System.Windows.Forms.GroupBox();
            this.panelStMdDet = new System.Windows.Forms.Panel();
            this.groupStMdDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupStMdDet
            // 
            this.groupStMdDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupStMdDet.Controls.Add(this.panelStMdDet);
            this.groupStMdDet.Location = new System.Drawing.Point(0, 0);
            this.groupStMdDet.Name = "groupStMdDet";
            this.groupStMdDet.Size = new System.Drawing.Size(264, 449);
            this.groupStMdDet.TabIndex = 32;
            this.groupStMdDet.TabStop = false;
            this.groupStMdDet.Text = "Static Models";
            // 
            // panelStMdDet
            // 
            this.panelStMdDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStMdDet.AutoScroll = true;
            this.panelStMdDet.Location = new System.Drawing.Point(3, 16);
            this.panelStMdDet.Name = "panelStMdDet";
            this.panelStMdDet.Size = new System.Drawing.Size(258, 424);
            this.panelStMdDet.TabIndex = 0;
            // 
            // ModelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupStMdDet);
            this.Name = "ModelPanel";
            this.Size = new System.Drawing.Size(264, 449);
            this.groupStMdDet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupStMdDet;
        private System.Windows.Forms.Panel panelStMdDet;
    }
}
