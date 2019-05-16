namespace SOC.QuestObjects.Enemy.Forms
{
    partial class NewEnemiesPanel
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
            this.groupNewEneDet = new System.Windows.Forms.GroupBox();
            this.panelQuestEnemyDet = new System.Windows.Forms.Panel();
            this.label_eneObjType1 = new System.Windows.Forms.Label();
            this.label_spawnall = new System.Windows.Forms.Label();
            this.checkBox_spawnall = new System.Windows.Forms.CheckBox();
            this.comboBox_eneObjType1 = new System.Windows.Forms.ComboBox();
            this.label_subtype = new System.Windows.Forms.Label();
            this.comboBox_subtype = new System.Windows.Forms.ComboBox();
            this.groupNewEneDet.SuspendLayout();
            this.panelQuestEnemyDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupNewEneDet
            // 
            this.groupNewEneDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupNewEneDet.Controls.Add(this.panelQuestEnemyDet);
            this.groupNewEneDet.Location = new System.Drawing.Point(0, 0);
            this.groupNewEneDet.Name = "groupNewEneDet";
            this.groupNewEneDet.Size = new System.Drawing.Size(264, 449);
            this.groupNewEneDet.TabIndex = 33;
            this.groupNewEneDet.TabStop = false;
            this.groupNewEneDet.Text = "New Enemies";
            // 
            // panelQuestEnemyDet
            // 
            this.panelQuestEnemyDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestEnemyDet.AutoScroll = true;
            this.panelQuestEnemyDet.Controls.Add(this.label_eneObjType1);
            this.panelQuestEnemyDet.Controls.Add(this.label_spawnall);
            this.panelQuestEnemyDet.Controls.Add(this.checkBox_spawnall);
            this.panelQuestEnemyDet.Controls.Add(this.comboBox_eneObjType1);
            this.panelQuestEnemyDet.Controls.Add(this.label_subtype);
            this.panelQuestEnemyDet.Controls.Add(this.comboBox_subtype);
            this.panelQuestEnemyDet.Location = new System.Drawing.Point(3, 16);
            this.panelQuestEnemyDet.Name = "panelQuestEnemyDet";
            this.panelQuestEnemyDet.Size = new System.Drawing.Size(258, 424);
            this.panelQuestEnemyDet.TabIndex = 0;
            // 
            // label_eneObjType1
            // 
            this.label_eneObjType1.AutoSize = true;
            this.label_eneObjType1.Location = new System.Drawing.Point(3, 3);
            this.label_eneObjType1.Name = "label_eneObjType1";
            this.label_eneObjType1.Size = new System.Drawing.Size(116, 13);
            this.label_eneObjType1.TabIndex = 2;
            this.label_eneObjType1.Text = "Target Objective Type:";
            // 
            // label_spawnall
            // 
            this.label_spawnall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_spawnall.AutoSize = true;
            this.label_spawnall.Location = new System.Drawing.Point(106, 51);
            this.label_spawnall.Name = "label_spawnall";
            this.label_spawnall.Size = new System.Drawing.Size(128, 13);
            this.label_spawnall.TabIndex = 1;
            this.label_spawnall.Text = "Spawn All Quest Soldiers:";
            // 
            // checkBox_spawnall
            // 
            this.checkBox_spawnall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_spawnall.AutoSize = true;
            this.checkBox_spawnall.Checked = true;
            this.checkBox_spawnall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_spawnall.Location = new System.Drawing.Point(240, 51);
            this.checkBox_spawnall.Name = "checkBox_spawnall";
            this.checkBox_spawnall.Size = new System.Drawing.Size(15, 14);
            this.checkBox_spawnall.TabIndex = 2;
            this.checkBox_spawnall.UseVisualStyleBackColor = true;
            // 
            // comboBox_eneObjType1
            // 
            this.comboBox_eneObjType1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_eneObjType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_eneObjType1.FormattingEnabled = true;
            this.comboBox_eneObjType1.Items.AddRange(new object[] {
            "ELIMINATE",
            "RECOVERED",
            "KILLREQUIRED"});
            this.comboBox_eneObjType1.Location = new System.Drawing.Point(125, 0);
            this.comboBox_eneObjType1.Name = "comboBox_eneObjType1";
            this.comboBox_eneObjType1.Size = new System.Drawing.Size(130, 21);
            this.comboBox_eneObjType1.TabIndex = 1;
            // 
            // label_subtype
            // 
            this.label_subtype.AutoSize = true;
            this.label_subtype.Location = new System.Drawing.Point(31, 27);
            this.label_subtype.Name = "label_subtype";
            this.label_subtype.Size = new System.Drawing.Size(88, 13);
            this.label_subtype.TabIndex = 6;
            this.label_subtype.Text = "Soldier SubType:";
            // 
            // comboBox_subtype
            // 
            this.comboBox_subtype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_subtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_subtype.FormattingEnabled = true;
            this.comboBox_subtype.Location = new System.Drawing.Point(125, 24);
            this.comboBox_subtype.Name = "comboBox_subtype";
            this.comboBox_subtype.Size = new System.Drawing.Size(130, 21);
            this.comboBox_subtype.TabIndex = 7;
            // 
            // NewEnemiesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupNewEneDet);
            this.Name = "NewEnemiesPanel";
            this.Size = new System.Drawing.Size(264, 449);
            this.groupNewEneDet.ResumeLayout(false);
            this.panelQuestEnemyDet.ResumeLayout(false);
            this.panelQuestEnemyDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupNewEneDet;
        public System.Windows.Forms.Panel panelQuestEnemyDet;
        private System.Windows.Forms.Label label_eneObjType1;
        private System.Windows.Forms.Label label_spawnall;
        public System.Windows.Forms.CheckBox checkBox_spawnall;
        private System.Windows.Forms.ComboBox comboBox_eneObjType1;
        private System.Windows.Forms.Label label_subtype;
        private System.Windows.Forms.ComboBox comboBox_subtype;
    }
}
