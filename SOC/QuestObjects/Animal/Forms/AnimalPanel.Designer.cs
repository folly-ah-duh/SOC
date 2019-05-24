namespace SOC.QuestObjects.Animal.Forms
{
    partial class AnimalPanel
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
            this.groupAnimalDet = new System.Windows.Forms.GroupBox();
            this.panelAnimalDet = new System.Windows.Forms.Panel();
            this.label_aniObjType = new System.Windows.Forms.Label();
            this.comboBox_aniObjType = new System.Windows.Forms.ComboBox();
            this.groupAnimalDet.SuspendLayout();
            this.panelAnimalDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAnimalDet
            // 
            this.groupAnimalDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupAnimalDet.Controls.Add(this.panelAnimalDet);
            this.groupAnimalDet.Location = new System.Drawing.Point(0, 0);
            this.groupAnimalDet.Name = "groupAnimalDet";
            this.groupAnimalDet.Size = new System.Drawing.Size(264, 449);
            this.groupAnimalDet.TabIndex = 21;
            this.groupAnimalDet.TabStop = false;
            this.groupAnimalDet.Text = "Animals";
            // 
            // panelAnimalDet
            // 
            this.panelAnimalDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimalDet.AutoScroll = true;
            this.panelAnimalDet.Controls.Add(this.label_aniObjType);
            this.panelAnimalDet.Controls.Add(this.comboBox_aniObjType);
            this.panelAnimalDet.Location = new System.Drawing.Point(3, 16);
            this.panelAnimalDet.Name = "panelAnimalDet";
            this.panelAnimalDet.Size = new System.Drawing.Size(258, 424);
            this.panelAnimalDet.TabIndex = 0;
            // 
            // label_aniObjType
            // 
            this.label_aniObjType.AutoSize = true;
            this.label_aniObjType.Location = new System.Drawing.Point(3, 3);
            this.label_aniObjType.Name = "label_aniObjType";
            this.label_aniObjType.Size = new System.Drawing.Size(116, 13);
            this.label_aniObjType.TabIndex = 17;
            this.label_aniObjType.Text = "Target Objective Type:";
            // 
            // comboBox_aniObjType
            // 
            this.comboBox_aniObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_aniObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_aniObjType.FormattingEnabled = true;
            this.comboBox_aniObjType.Items.AddRange(new object[] {
            "ELIMINATE",
            "RECOVERED",
            "KILLREQUIRED"});
            this.comboBox_aniObjType.Location = new System.Drawing.Point(125, 0);
            this.comboBox_aniObjType.Name = "comboBox_aniObjType";
            this.comboBox_aniObjType.Size = new System.Drawing.Size(130, 21);
            this.comboBox_aniObjType.TabIndex = 16;
            // 
            // AnimalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupAnimalDet);
            this.Name = "AnimalPanel";
            this.Size = new System.Drawing.Size(264, 449);
            this.groupAnimalDet.ResumeLayout(false);
            this.panelAnimalDet.ResumeLayout(false);
            this.panelAnimalDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupAnimalDet;
        private System.Windows.Forms.Panel panelAnimalDet;
        private System.Windows.Forms.Label label_aniObjType;
        private System.Windows.Forms.ComboBox comboBox_aniObjType;
    }
}
