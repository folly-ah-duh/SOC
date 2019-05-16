namespace SOC.QuestObjects.Vehicle.Forms
{
    partial class VehiclePanel
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
            this.groupVehDet = new System.Windows.Forms.GroupBox();
            this.panelVehDet = new System.Windows.Forms.Panel();
            this.label_vehObjType = new System.Windows.Forms.Label();
            this.comboBox_vehObjType = new System.Windows.Forms.ComboBox();
            this.groupVehDet.SuspendLayout();
            this.panelVehDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupVehDet
            // 
            this.groupVehDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupVehDet.Controls.Add(this.panelVehDet);
            this.groupVehDet.Location = new System.Drawing.Point(0, 0);
            this.groupVehDet.Name = "groupVehDet";
            this.groupVehDet.Size = new System.Drawing.Size(264, 449);
            this.groupVehDet.TabIndex = 13;
            this.groupVehDet.TabStop = false;
            this.groupVehDet.Text = "Heavy Vehicles";
            // 
            // panelVehDet
            // 
            this.panelVehDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVehDet.AutoScroll = true;
            this.panelVehDet.Controls.Add(this.label_vehObjType);
            this.panelVehDet.Controls.Add(this.comboBox_vehObjType);
            this.panelVehDet.Location = new System.Drawing.Point(3, 16);
            this.panelVehDet.Name = "panelVehDet";
            this.panelVehDet.Size = new System.Drawing.Size(258, 424);
            this.panelVehDet.TabIndex = 0;
            // 
            // label_vehObjType
            // 
            this.label_vehObjType.AutoSize = true;
            this.label_vehObjType.Location = new System.Drawing.Point(3, 3);
            this.label_vehObjType.Name = "label_vehObjType";
            this.label_vehObjType.Size = new System.Drawing.Size(116, 13);
            this.label_vehObjType.TabIndex = 15;
            this.label_vehObjType.Text = "Target Objective Type:";
            // 
            // comboBox_vehObjType
            // 
            this.comboBox_vehObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_vehObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vehObjType.FormattingEnabled = true;
            this.comboBox_vehObjType.Items.AddRange(new object[] {
            "ELIMINATE",
            "RECOVERED",
            "KILLREQUIRED"});
            this.comboBox_vehObjType.Location = new System.Drawing.Point(125, 0);
            this.comboBox_vehObjType.Name = "comboBox_vehObjType";
            this.comboBox_vehObjType.Size = new System.Drawing.Size(130, 21);
            this.comboBox_vehObjType.TabIndex = 14;
            // 
            // VehiclePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupVehDet);
            this.Name = "VehiclePanel";
            this.Size = new System.Drawing.Size(264, 449);
            this.groupVehDet.ResumeLayout(false);
            this.panelVehDet.ResumeLayout(false);
            this.panelVehDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupVehDet;
        public System.Windows.Forms.Panel panelVehDet;
        private System.Windows.Forms.Label label_vehObjType;
        private System.Windows.Forms.ComboBox comboBox_vehObjType;
    }
}
