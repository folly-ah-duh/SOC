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
            this.label1 = new System.Windows.Forms.Label();
            this.panelWaiting = new System.Windows.Forms.Panel();
            this.panelWaiting.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Building Details...";
            // 
            // panelWaiting
            // 
            this.panelWaiting.Controls.Add(this.label1);
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

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelWaiting;
    }
}
