namespace SOC.UI
{
    partial class formCustomProgressLang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLangId = new System.Windows.Forms.TextBox();
            this.textBoxLangValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLangId
            // 
            this.textBoxLangId.Location = new System.Drawing.Point(12, 25);
            this.textBoxLangId.Name = "textBoxLangId";
            this.textBoxLangId.Size = new System.Drawing.Size(312, 20);
            this.textBoxLangId.TabIndex = 0;
            // 
            // textBoxLangValue
            // 
            this.textBoxLangValue.Location = new System.Drawing.Point(12, 68);
            this.textBoxLangValue.Name = "textBoxLangValue";
            this.textBoxLangValue.Size = new System.Drawing.Size(312, 20);
            this.textBoxLangValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LangId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value";
            // 
            // buttonCreateEntry
            // 
            this.buttonCreateEntry.Location = new System.Drawing.Point(243, 95);
            this.buttonCreateEntry.Name = "buttonCreateEntry";
            this.buttonCreateEntry.Size = new System.Drawing.Size(81, 23);
            this.buttonCreateEntry.TabIndex = 4;
            this.buttonCreateEntry.Text = "Create Entry";
            this.buttonCreateEntry.UseVisualStyleBackColor = true;
            this.buttonCreateEntry.Click += new System.EventHandler(this.buttonCreateEntry_Click);
            // 
            // formCustomProgressLang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 128);
            this.Controls.Add(this.buttonCreateEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLangValue);
            this.Controls.Add(this.textBoxLangId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCustomProgressLang";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Progress Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLangId;
        private System.Windows.Forms.TextBox textBoxLangValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreateEntry;
    }
}