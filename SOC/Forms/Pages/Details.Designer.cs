using SOC.Classes;
using SOC.QuestComponents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.UI
{

    partial class Details
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
            this.panelDetails = new System.Windows.Forms.Panel();
            this.originAnchor = new System.Windows.Forms.Label();
            this.groupActiveItemDet = new System.Windows.Forms.GroupBox();
            this.panelAcItDet = new System.Windows.Forms.Panel();
            this.groupExistingEneDet = new System.Windows.Forms.GroupBox();
            this.panelCPEnemyDet = new System.Windows.Forms.Panel();
            this.label_subtype2 = new System.Windows.Forms.Label();
            this.comboBox_subtype2 = new System.Windows.Forms.ComboBox();
            this.label_customizeall = new System.Windows.Forms.Label();
            this.checkBox_customizeall = new System.Windows.Forms.CheckBox();
            this.groupNewEneDet = new System.Windows.Forms.GroupBox();
            this.panelQuestEnemyDet = new System.Windows.Forms.Panel();
            this.label_spawnall = new System.Windows.Forms.Label();
            this.checkBox_spawnall = new System.Windows.Forms.CheckBox();
            this.label_subtype = new System.Windows.Forms.Label();
            this.comboBox_subtype = new System.Windows.Forms.ComboBox();
            this.groupAnimalDet = new System.Windows.Forms.GroupBox();
            this.panelAnimalDet = new System.Windows.Forms.Panel();
            this.groupVehDet = new System.Windows.Forms.GroupBox();
            this.panelVehDet = new System.Windows.Forms.Panel();
            this.groupStMdDet = new System.Windows.Forms.GroupBox();
            this.panelStMdDet = new System.Windows.Forms.Panel();
            this.groupItemDet = new System.Windows.Forms.GroupBox();
            this.panelItemDet = new System.Windows.Forms.Panel();
            this.groupHosDet = new System.Windows.Forms.GroupBox();
            this.panelHosDet = new System.Windows.Forms.Panel();
            this.h_label_intrgt = new System.Windows.Forms.Label();
            this.h_checkBox_intrgt = new System.Windows.Forms.CheckBox();
            this.comboBox_Body = new System.Windows.Forms.ComboBox();
            this.label_Body = new System.Windows.Forms.Label();
            this.panelDetails.SuspendLayout();
            this.groupActiveItemDet.SuspendLayout();
            this.groupExistingEneDet.SuspendLayout();
            this.panelCPEnemyDet.SuspendLayout();
            this.groupNewEneDet.SuspendLayout();
            this.panelQuestEnemyDet.SuspendLayout();
            this.groupAnimalDet.SuspendLayout();
            this.groupVehDet.SuspendLayout();
            this.groupStMdDet.SuspendLayout();
            this.groupItemDet.SuspendLayout();
            this.groupHosDet.SuspendLayout();
            this.panelHosDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetails
            // 
            this.panelDetails.AutoScroll = true;
            this.panelDetails.Controls.Add(this.originAnchor);
            this.panelDetails.Controls.Add(this.groupActiveItemDet);
            this.panelDetails.Controls.Add(this.groupExistingEneDet);
            this.panelDetails.Controls.Add(this.groupNewEneDet);
            this.panelDetails.Controls.Add(this.groupAnimalDet);
            this.panelDetails.Controls.Add(this.groupVehDet);
            this.panelDetails.Controls.Add(this.groupStMdDet);
            this.panelDetails.Controls.Add(this.groupItemDet);
            this.panelDetails.Controls.Add(this.groupHosDet);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(2169, 452);
            this.panelDetails.TabIndex = 0;
            // 
            // originAnchor
            // 
            this.originAnchor.AutoSize = true;
            this.originAnchor.Location = new System.Drawing.Point(0, 0);
            this.originAnchor.Name = "originAnchor";
            this.originAnchor.Size = new System.Drawing.Size(0, 13);
            this.originAnchor.TabIndex = 34;
            // 
            // groupActiveItemDet
            // 
            this.groupActiveItemDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupActiveItemDet.Controls.Add(this.panelAcItDet);
            this.groupActiveItemDet.Location = new System.Drawing.Point(1621, 3);
            this.groupActiveItemDet.Name = "groupActiveItemDet";
            this.groupActiveItemDet.Size = new System.Drawing.Size(264, 449);
            this.groupActiveItemDet.TabIndex = 28;
            this.groupActiveItemDet.TabStop = false;
            this.groupActiveItemDet.Text = "Active Items";
            // 
            // panelAcItDet
            // 
            this.panelAcItDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAcItDet.AutoScroll = true;
            this.panelAcItDet.Location = new System.Drawing.Point(3, 16);
            this.panelAcItDet.Name = "panelAcItDet";
            this.panelAcItDet.Size = new System.Drawing.Size(258, 424);
            this.panelAcItDet.TabIndex = 0;
            this.panelAcItDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // groupExistingEneDet
            // 
            this.groupExistingEneDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupExistingEneDet.Controls.Add(this.panelCPEnemyDet);
            this.groupExistingEneDet.Location = new System.Drawing.Point(273, 3);
            this.groupExistingEneDet.Name = "groupExistingEneDet";
            this.groupExistingEneDet.Size = new System.Drawing.Size(264, 449);
            this.groupExistingEneDet.TabIndex = 33;
            this.groupExistingEneDet.TabStop = false;
            this.groupExistingEneDet.Text = "Existing Enemies";
            // 
            // panelCPEnemyDet
            // 
            this.panelCPEnemyDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCPEnemyDet.AutoScroll = true;
            this.panelCPEnemyDet.Controls.Add(this.label_subtype2);
            this.panelCPEnemyDet.Controls.Add(this.comboBox_subtype2);
            this.panelCPEnemyDet.Controls.Add(this.label_customizeall);
            this.panelCPEnemyDet.Controls.Add(this.checkBox_customizeall);
            this.panelCPEnemyDet.Location = new System.Drawing.Point(3, 16);
            this.panelCPEnemyDet.Name = "panelCPEnemyDet";
            this.panelCPEnemyDet.Size = new System.Drawing.Size(258, 424);
            this.panelCPEnemyDet.TabIndex = 0;
            this.panelCPEnemyDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // label_subtype2
            // 
            this.label_subtype2.AutoSize = true;
            this.label_subtype2.Location = new System.Drawing.Point(7, 3);
            this.label_subtype2.Name = "label_subtype2";
            this.label_subtype2.Size = new System.Drawing.Size(88, 13);
            this.label_subtype2.TabIndex = 8;
            this.label_subtype2.Text = "Soldier SubType:";
            // 
            // comboBox_subtype2
            // 
            this.comboBox_subtype2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_subtype2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_subtype2.Enabled = false;
            this.comboBox_subtype2.FormattingEnabled = true;
            this.comboBox_subtype2.Location = new System.Drawing.Point(101, 0);
            this.comboBox_subtype2.Name = "comboBox_subtype2";
            this.comboBox_subtype2.Size = new System.Drawing.Size(147, 21);
            this.comboBox_subtype2.TabIndex = 9;
            // 
            // label_customizeall
            // 
            this.label_customizeall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_customizeall.AutoSize = true;
            this.label_customizeall.Location = new System.Drawing.Point(98, 27);
            this.label_customizeall.Name = "label_customizeall";
            this.label_customizeall.Size = new System.Drawing.Size(129, 13);
            this.label_customizeall.TabIndex = 2;
            this.label_customizeall.Text = "Customize All CP Soldiers:";
            // 
            // checkBox_customizeall
            // 
            this.checkBox_customizeall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_customizeall.AutoSize = true;
            this.checkBox_customizeall.Checked = true;
            this.checkBox_customizeall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_customizeall.Location = new System.Drawing.Point(233, 27);
            this.checkBox_customizeall.Name = "checkBox_customizeall";
            this.checkBox_customizeall.Size = new System.Drawing.Size(15, 14);
            this.checkBox_customizeall.TabIndex = 3;
            this.checkBox_customizeall.UseVisualStyleBackColor = true;
            this.checkBox_customizeall.Click += new System.EventHandler(this.checkbox_customizeAll_Click);
            // 
            // groupNewEneDet
            // 
            this.groupNewEneDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupNewEneDet.Controls.Add(this.panelQuestEnemyDet);
            this.groupNewEneDet.Location = new System.Drawing.Point(3, 3);
            this.groupNewEneDet.Name = "groupNewEneDet";
            this.groupNewEneDet.Size = new System.Drawing.Size(264, 449);
            this.groupNewEneDet.TabIndex = 32;
            this.groupNewEneDet.TabStop = false;
            this.groupNewEneDet.Text = "New Enemies";
            // 
            // panelQuestEnemyDet
            // 
            this.panelQuestEnemyDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestEnemyDet.AutoScroll = true;
            this.panelQuestEnemyDet.Controls.Add(this.label_spawnall);
            this.panelQuestEnemyDet.Controls.Add(this.checkBox_spawnall);
            this.panelQuestEnemyDet.Controls.Add(this.label_subtype);
            this.panelQuestEnemyDet.Controls.Add(this.comboBox_subtype);
            this.panelQuestEnemyDet.Location = new System.Drawing.Point(3, 16);
            this.panelQuestEnemyDet.Name = "panelQuestEnemyDet";
            this.panelQuestEnemyDet.Size = new System.Drawing.Size(258, 424);
            this.panelQuestEnemyDet.TabIndex = 0;
            this.panelQuestEnemyDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // label_spawnall
            // 
            this.label_spawnall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_spawnall.AutoSize = true;
            this.label_spawnall.Location = new System.Drawing.Point(99, 27);
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
            this.checkBox_spawnall.Location = new System.Drawing.Point(233, 27);
            this.checkBox_spawnall.Name = "checkBox_spawnall";
            this.checkBox_spawnall.Size = new System.Drawing.Size(15, 14);
            this.checkBox_spawnall.TabIndex = 2;
            this.checkBox_spawnall.UseVisualStyleBackColor = true;
            this.checkBox_spawnall.Click += new System.EventHandler(this.checkbox_spawnAll_Click);
            // 
            // label_subtype
            // 
            this.label_subtype.AutoSize = true;
            this.label_subtype.Location = new System.Drawing.Point(7, 3);
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
            this.comboBox_subtype.Location = new System.Drawing.Point(101, 0);
            this.comboBox_subtype.Name = "comboBox_subtype";
            this.comboBox_subtype.Size = new System.Drawing.Size(147, 21);
            this.comboBox_subtype.TabIndex = 7;
            this.comboBox_subtype.SelectedIndexChanged += new System.EventHandler(this.comboBox_subtype_SelectedIndexChanged);
            // 
            // groupAnimalDet
            // 
            this.groupAnimalDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupAnimalDet.Controls.Add(this.panelAnimalDet);
            this.groupAnimalDet.Location = new System.Drawing.Point(1081, 3);
            this.groupAnimalDet.Name = "groupAnimalDet";
            this.groupAnimalDet.Size = new System.Drawing.Size(264, 449);
            this.groupAnimalDet.TabIndex = 20;
            this.groupAnimalDet.TabStop = false;
            this.groupAnimalDet.Text = "Animals";
            // 
            // panelAnimalDet
            // 
            this.panelAnimalDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimalDet.AutoScroll = true;
            this.panelAnimalDet.Location = new System.Drawing.Point(3, 16);
            this.panelAnimalDet.Name = "panelAnimalDet";
            this.panelAnimalDet.Size = new System.Drawing.Size(258, 424);
            this.panelAnimalDet.TabIndex = 0;
            this.panelAnimalDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // groupVehDet
            // 
            this.groupVehDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupVehDet.Controls.Add(this.panelVehDet);
            this.groupVehDet.Location = new System.Drawing.Point(812, 3);
            this.groupVehDet.Name = "groupVehDet";
            this.groupVehDet.Size = new System.Drawing.Size(264, 449);
            this.groupVehDet.TabIndex = 12;
            this.groupVehDet.TabStop = false;
            this.groupVehDet.Text = "Heavy Vehicles";
            // 
            // panelVehDet
            // 
            this.panelVehDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVehDet.AutoScroll = true;
            this.panelVehDet.Location = new System.Drawing.Point(3, 16);
            this.panelVehDet.Name = "panelVehDet";
            this.panelVehDet.Size = new System.Drawing.Size(258, 424);
            this.panelVehDet.TabIndex = 0;
            this.panelVehDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // groupStMdDet
            // 
            this.groupStMdDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupStMdDet.Controls.Add(this.panelStMdDet);
            this.groupStMdDet.Location = new System.Drawing.Point(1888, 3);
            this.groupStMdDet.Name = "groupStMdDet";
            this.groupStMdDet.Size = new System.Drawing.Size(264, 449);
            this.groupStMdDet.TabIndex = 31;
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
            this.panelStMdDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // groupItemDet
            // 
            this.groupItemDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupItemDet.Controls.Add(this.panelItemDet);
            this.groupItemDet.Location = new System.Drawing.Point(1351, 3);
            this.groupItemDet.Name = "groupItemDet";
            this.groupItemDet.Size = new System.Drawing.Size(264, 449);
            this.groupItemDet.TabIndex = 29;
            this.groupItemDet.TabStop = false;
            this.groupItemDet.Text = "Dormant Items";
            // 
            // panelItemDet
            // 
            this.panelItemDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelItemDet.AutoScroll = true;
            this.panelItemDet.Location = new System.Drawing.Point(3, 16);
            this.panelItemDet.Name = "panelItemDet";
            this.panelItemDet.Size = new System.Drawing.Size(258, 424);
            this.panelItemDet.TabIndex = 0;
            this.panelItemDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // groupHosDet
            // 
            this.groupHosDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupHosDet.Controls.Add(this.panelHosDet);
            this.groupHosDet.Location = new System.Drawing.Point(543, 3);
            this.groupHosDet.Name = "groupHosDet";
            this.groupHosDet.Size = new System.Drawing.Size(264, 449);
            this.groupHosDet.TabIndex = 1;
            this.groupHosDet.TabStop = false;
            this.groupHosDet.Text = "Prisoners";
            // 
            // panelHosDet
            // 
            this.panelHosDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHosDet.AutoScroll = true;
            this.panelHosDet.Controls.Add(this.h_label_intrgt);
            this.panelHosDet.Controls.Add(this.h_checkBox_intrgt);
            this.panelHosDet.Controls.Add(this.comboBox_Body);
            this.panelHosDet.Controls.Add(this.label_Body);
            this.panelHosDet.Location = new System.Drawing.Point(3, 16);
            this.panelHosDet.Name = "panelHosDet";
            this.panelHosDet.Size = new System.Drawing.Size(258, 424);
            this.panelHosDet.TabIndex = 0;
            this.panelHosDet.Click += new System.EventHandler(this.DetailFocus);
            // 
            // h_label_intrgt
            // 
            this.h_label_intrgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.h_label_intrgt.AutoSize = true;
            this.h_label_intrgt.Location = new System.Drawing.Point(81, 27);
            this.h_label_intrgt.Name = "h_label_intrgt";
            this.h_label_intrgt.Size = new System.Drawing.Size(146, 13);
            this.h_label_intrgt.TabIndex = 0;
            this.h_label_intrgt.Text = "Interrogate For Whereabouts:";
            // 
            // h_checkBox_intrgt
            // 
            this.h_checkBox_intrgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.h_checkBox_intrgt.AutoSize = true;
            this.h_checkBox_intrgt.Location = new System.Drawing.Point(233, 27);
            this.h_checkBox_intrgt.Name = "h_checkBox_intrgt";
            this.h_checkBox_intrgt.Size = new System.Drawing.Size(15, 14);
            this.h_checkBox_intrgt.TabIndex = 0;
            this.h_checkBox_intrgt.UseVisualStyleBackColor = true;
            // 
            // comboBox_Body
            // 
            this.comboBox_Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Body.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Body.FormattingEnabled = true;
            this.comboBox_Body.Location = new System.Drawing.Point(74, 0);
            this.comboBox_Body.Name = "comboBox_Body";
            this.comboBox_Body.Size = new System.Drawing.Size(174, 21);
            this.comboBox_Body.TabIndex = 1;
            this.comboBox_Body.SelectedIndexChanged += new System.EventHandler(this.comboBox_Body_SelectedIndexChanged);
            // 
            // label_Body
            // 
            this.label_Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Body.AutoSize = true;
            this.label_Body.Location = new System.Drawing.Point(34, 3);
            this.label_Body.Name = "label_Body";
            this.label_Body.Size = new System.Drawing.Size(34, 13);
            this.label_Body.TabIndex = 2;
            this.label_Body.Text = "Body:";
            // 
            // Details
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelDetails);
            this.Name = "Details";
            this.Size = new System.Drawing.Size(2169, 452);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.groupActiveItemDet.ResumeLayout(false);
            this.groupExistingEneDet.ResumeLayout(false);
            this.panelCPEnemyDet.ResumeLayout(false);
            this.panelCPEnemyDet.PerformLayout();
            this.groupNewEneDet.ResumeLayout(false);
            this.panelQuestEnemyDet.ResumeLayout(false);
            this.panelQuestEnemyDet.PerformLayout();
            this.groupAnimalDet.ResumeLayout(false);
            this.groupVehDet.ResumeLayout(false);
            this.groupStMdDet.ResumeLayout(false);
            this.groupItemDet.ResumeLayout(false);
            this.groupHosDet.ResumeLayout(false);
            this.panelHosDet.ResumeLayout(false);
            this.panelHosDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetails;
        public System.Windows.Forms.GroupBox groupHosDet;
        private System.Windows.Forms.Label label_Body;
        public System.Windows.Forms.ComboBox comboBox_Body;
        public System.Windows.Forms.GroupBox groupItemDet;
        private System.Windows.Forms.Panel panelItemDet;
        public System.Windows.Forms.GroupBox groupVehDet;
        public System.Windows.Forms.GroupBox groupStMdDet;
        private System.Windows.Forms.Panel panelStMdDet;
        private Panel panelAnimalDet;
        private Label h_label_intrgt;
        public CheckBox h_checkBox_intrgt;
        private Panel panelAcItDet;
        public GroupBox groupAnimalDet;
        public Panel panelHosDet;
        public Panel panelVehDet;
        public GroupBox groupNewEneDet;
        public Panel panelQuestEnemyDet;
        public GroupBox groupExistingEneDet;
        public Panel panelCPEnemyDet;
        private ComboBox comboBox_subtype;
        private Label label_subtype;
        private Label label_customizeall;
        public CheckBox checkBox_customizeall;
        private Label label_spawnall;
        public CheckBox checkBox_spawnall;
        private Label label_subtype2;
        private ComboBox comboBox_subtype2;
        private GroupBox groupActiveItemDet;
        private Label originAnchor;
    }
}