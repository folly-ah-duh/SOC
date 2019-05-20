namespace SOC.Forms.Pages
{
    partial class LocationalDataStub
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.originAnchor = new System.Windows.Forms.Label();
            this.textBoxHosCoords = new System.Windows.Forms.TextBox();
            this.labelHos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.originAnchor);
            this.panel1.Controls.Add(this.textBoxHosCoords);
            this.panel1.Controls.Add(this.labelHos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 108);
            this.panel1.TabIndex = 24;
            // 
            // originAnchor
            // 
            this.originAnchor.AutoSize = true;
            this.originAnchor.Location = new System.Drawing.Point(0, 0);
            this.originAnchor.Name = "originAnchor";
            this.originAnchor.Size = new System.Drawing.Size(0, 13);
            this.originAnchor.TabIndex = 27;
            // 
            // textBoxHosCoords
            // 
            this.textBoxHosCoords.AcceptsReturn = true;
            this.textBoxHosCoords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHosCoords.BackColor = System.Drawing.Color.Silver;
            this.textBoxHosCoords.Location = new System.Drawing.Point(3, 21);
            this.textBoxHosCoords.Multiline = true;
            this.textBoxHosCoords.Name = "textBoxHosCoords";
            this.textBoxHosCoords.Size = new System.Drawing.Size(329, 80);
            this.textBoxHosCoords.TabIndex = 17;
            // 
            // labelHos
            // 
            this.labelHos.AutoSize = true;
            this.labelHos.Location = new System.Drawing.Point(3, 5);
            this.labelHos.Name = "labelHos";
            this.labelHos.Size = new System.Drawing.Size(237, 13);
            this.labelHos.TabIndex = 16;
            this.labelHos.Text = "Locations: {pos={X, Y, Z},rotY=Y-Axis Rotation,},";
            // 
            // LocationalDataStub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LocationalDataStub";
            this.Size = new System.Drawing.Size(335, 108);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label originAnchor;
        public System.Windows.Forms.TextBox textBoxHosCoords;
        public System.Windows.Forms.Label labelHos;
    }
}
