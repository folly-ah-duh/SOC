namespace SOC.UI
{
    partial class Waiting
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
            this.labelWaiting = new System.Windows.Forms.Label();
            this.panelWaiting = new System.Windows.Forms.Panel();
            this.panelWaiting.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWaiting
            // 
            this.labelWaiting.AutoSize = true;
            this.labelWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaiting.Location = new System.Drawing.Point(500, 200);
            this.labelWaiting.Name = "labelWaiting";
            this.labelWaiting.Size = new System.Drawing.Size(179, 25);
            this.labelWaiting.TabIndex = 0;
            this.labelWaiting.Text = "Building Details...";
            // 
            // panelWaiting
            // 
            this.panelWaiting.AutoScroll = true;
            this.panelWaiting.AutoSize = true;
            this.panelWaiting.Controls.Add(this.labelWaiting);
            this.panelWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWaiting.Location = new System.Drawing.Point(0, 0);
            this.panelWaiting.Name = "panelWaiting";
            this.panelWaiting.Size = new System.Drawing.Size(1160, 450);
            this.panelWaiting.TabIndex = 1;
            // 
            // Waiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelWaiting);
            this.Name = "Waiting";
            this.Size = new System.Drawing.Size(1160, 450);
            this.panelWaiting.ResumeLayout(false);
            this.panelWaiting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWaiting;
        private System.Windows.Forms.Panel panelWaiting;
    }
}
