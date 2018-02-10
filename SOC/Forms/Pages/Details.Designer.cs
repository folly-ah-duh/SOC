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
            this.groupHeliDet = new System.Windows.Forms.GroupBox();
            this.panelHeliDetail = new System.Windows.Forms.Panel();
            this.label_HeliObjType = new System.Windows.Forms.Label();
            this.comboBox_heliObjType = new System.Windows.Forms.ComboBox();
            this.originAnchor = new System.Windows.Forms.Label();
            this.groupActiveItemDet = new System.Windows.Forms.GroupBox();
            this.panelAcItDet = new System.Windows.Forms.Panel();
            this.groupExistingEneDet = new System.Windows.Forms.GroupBox();
            this.panelCPEnemyDet = new System.Windows.Forms.Panel();
            this.label_eneObjType2 = new System.Windows.Forms.Label();
            this.comboBox_eneObjType2 = new System.Windows.Forms.ComboBox();
            this.label_subtype2 = new System.Windows.Forms.Label();
            this.comboBox_subtype2 = new System.Windows.Forms.ComboBox();
            this.label_customizeall = new System.Windows.Forms.Label();
            this.checkBox_customizeall = new System.Windows.Forms.CheckBox();
            this.groupNewEneDet = new System.Windows.Forms.GroupBox();
            this.panelQuestEnemyDet = new System.Windows.Forms.Panel();
            this.label_eneObjType1 = new System.Windows.Forms.Label();
            this.label_spawnall = new System.Windows.Forms.Label();
            this.checkBox_spawnall = new System.Windows.Forms.CheckBox();
            this.comboBox_eneObjType1 = new System.Windows.Forms.ComboBox();
            this.label_subtype = new System.Windows.Forms.Label();
            this.comboBox_subtype = new System.Windows.Forms.ComboBox();
            this.groupAnimalDet = new System.Windows.Forms.GroupBox();
            this.panelAnimalDet = new System.Windows.Forms.Panel();
            this.label_aniObjType = new System.Windows.Forms.Label();
            this.comboBox_aniObjType = new System.Windows.Forms.ComboBox();
            this.groupVehDet = new System.Windows.Forms.GroupBox();
            this.panelVehDet = new System.Windows.Forms.Panel();
            this.label_vehObjType = new System.Windows.Forms.Label();
            this.comboBox_vehObjType = new System.Windows.Forms.ComboBox();
            this.groupStMdDet = new System.Windows.Forms.GroupBox();
            this.panelStMdDet = new System.Windows.Forms.Panel();
            this.groupItemDet = new System.Windows.Forms.GroupBox();
            this.panelItemDet = new System.Windows.Forms.Panel();
            this.groupHosDet = new System.Windows.Forms.GroupBox();
            this.panelHosDet = new System.Windows.Forms.Panel();
            this.label_hosObjType = new System.Windows.Forms.Label();
            this.comboBox_hosObjType = new System.Windows.Forms.ComboBox();
            this.h_label_intrgt = new System.Windows.Forms.Label();
            this.h_checkBox_intrgt = new System.Windows.Forms.CheckBox();
            this.comboBox_Body = new System.Windows.Forms.ComboBox();
            this.label_Body = new System.Windows.Forms.Label();
            this.panelDetails.SuspendLayout();
            this.groupHeliDet.SuspendLayout();
            this.panelHeliDetail.SuspendLayout();
            this.groupActiveItemDet.SuspendLayout();
            this.groupExistingEneDet.SuspendLayout();
            this.panelCPEnemyDet.SuspendLayout();
            this.groupNewEneDet.SuspendLayout();
            this.panelQuestEnemyDet.SuspendLayout();
            this.groupAnimalDet.SuspendLayout();
            this.panelAnimalDet.SuspendLayout();
            this.groupVehDet.SuspendLayout();
            this.panelVehDet.SuspendLayout();
            this.groupStMdDet.SuspendLayout();
            this.groupItemDet.SuspendLayout();
            this.groupHosDet.SuspendLayout();
            this.panelHosDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetails
            // 
            this.panelDetails.AutoScroll = true;
            this.panelDetails.Controls.Add(this.groupHeliDet);
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
            this.panelDetails.Size = new System.Drawing.Size(2438, 452);
            this.panelDetails.TabIndex = 0;
            // 
            // groupHeliDet
            // 
            this.groupHeliDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupHeliDet.Controls.Add(this.panelHeliDetail);
            this.groupHeliDet.Location = new System.Drawing.Point(543, 3);
            this.groupHeliDet.Name = "groupHeliDet";
            this.groupHeliDet.Size = new System.Drawing.Size(264, 449);
            this.groupHeliDet.TabIndex = 35;
            this.groupHeliDet.TabStop = false;
            this.groupHeliDet.Text = "Enemy Helicopter";
            // 
            // panelHeliDetail
            // 
            this.panelHeliDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeliDetail.AutoScroll = true;
            this.panelHeliDetail.Controls.Add(this.label_HeliObjType);
            this.panelHeliDetail.Controls.Add(this.comboBox_heliObjType);
            this.panelHeliDetail.Location = new System.Drawing.Point(3, 16);
            this.panelHeliDetail.Name = "panelHeliDetail";
            this.panelHeliDetail.Size = new System.Drawing.Size(258, 424);
            this.panelHeliDetail.TabIndex = 0;
            // 
            // label_HeliObjType
            // 
            this.label_HeliObjType.AutoSize = true;
            this.label_HeliObjType.Location = new System.Drawing.Point(3, 3);
            this.label_HeliObjType.Name = "label_HeliObjType";
            this.label_HeliObjType.Size = new System.Drawing.Size(116, 13);
            this.label_HeliObjType.TabIndex = 13;
            this.label_HeliObjType.Text = "Target Objective Type:";
            // 
            // comboBox_heliObjType
            // 
            this.comboBox_heliObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_heliObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_heliObjType.Enabled = false;
            this.comboBox_heliObjType.FormattingEnabled = true;
            this.comboBox_heliObjType.Items.AddRange(new object[] {
            "ELIMINATE"});
            this.comboBox_heliObjType.Location = new System.Drawing.Point(125, 0);
            this.comboBox_heliObjType.Name = "comboBox_heliObjType";
            this.comboBox_heliObjType.Size = new System.Drawing.Size(130, 21);
            this.comboBox_heliObjType.TabIndex = 12;
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
            this.groupActiveItemDet.Location = new System.Drawing.Point(1891, 3);
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
            this.panelCPEnemyDet.Controls.Add(this.label_eneObjType2);
            this.panelCPEnemyDet.Controls.Add(this.comboBox_eneObjType2);
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
            // label_eneObjType2
            // 
            this.label_eneObjType2.AutoSize = true;
            this.label_eneObjType2.Location = new System.Drawing.Point(3, 3);
            this.label_eneObjType2.Name = "label_eneObjType2";
            this.label_eneObjType2.Size = new System.Drawing.Size(116, 13);
            this.label_eneObjType2.TabIndex = 11;
            this.label_eneObjType2.Text = "Target Objective Type:";
            // 
            // comboBox_eneObjType2
            // 
            this.comboBox_eneObjType2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_eneObjType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_eneObjType2.Enabled = false;
            this.comboBox_eneObjType2.FormattingEnabled = true;
            this.comboBox_eneObjType2.Items.AddRange(new object[] {
            "ELIMINATE",
            "RECOVERED"});
            this.comboBox_eneObjType2.Location = new System.Drawing.Point(125, 0);
            this.comboBox_eneObjType2.Name = "comboBox_eneObjType2";
            this.comboBox_eneObjType2.Size = new System.Drawing.Size(130, 21);
            this.comboBox_eneObjType2.TabIndex = 10;
            // 
            // label_subtype2
            // 
            this.label_subtype2.AutoSize = true;
            this.label_subtype2.Location = new System.Drawing.Point(31, 27);
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
            this.comboBox_subtype2.Location = new System.Drawing.Point(125, 24);
            this.comboBox_subtype2.Name = "comboBox_subtype2";
            this.comboBox_subtype2.Size = new System.Drawing.Size(130, 21);
            this.comboBox_subtype2.TabIndex = 9;
            // 
            // label_customizeall
            // 
            this.label_customizeall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_customizeall.AutoSize = true;
            this.label_customizeall.Location = new System.Drawing.Point(105, 51);
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
            this.checkBox_customizeall.Location = new System.Drawing.Point(240, 51);
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
            this.panelQuestEnemyDet.Click += new System.EventHandler(this.DetailFocus);
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
            this.checkBox_spawnall.Click += new System.EventHandler(this.checkbox_spawnAll_Click);
            // 
            // comboBox_eneObjType1
            // 
            this.comboBox_eneObjType1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_eneObjType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_eneObjType1.FormattingEnabled = true;
            this.comboBox_eneObjType1.Items.AddRange(new object[] {
            "ELIMINATE",
            "RECOVERED"});
            this.comboBox_eneObjType1.Location = new System.Drawing.Point(125, 0);
            this.comboBox_eneObjType1.Name = "comboBox_eneObjType1";
            this.comboBox_eneObjType1.Size = new System.Drawing.Size(130, 21);
            this.comboBox_eneObjType1.TabIndex = 1;
            this.comboBox_eneObjType1.SelectedIndexChanged += new System.EventHandler(this.comboBox_eneObjType1_SelectedIndexChanged);
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
            this.comboBox_subtype.SelectedIndexChanged += new System.EventHandler(this.comboBox_subtype_SelectedIndexChanged);
            // 
            // groupAnimalDet
            // 
            this.groupAnimalDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupAnimalDet.Controls.Add(this.panelAnimalDet);
            this.groupAnimalDet.Location = new System.Drawing.Point(1351, 3);
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
            this.panelAnimalDet.Controls.Add(this.label_aniObjType);
            this.panelAnimalDet.Controls.Add(this.comboBox_aniObjType);
            this.panelAnimalDet.Location = new System.Drawing.Point(3, 16);
            this.panelAnimalDet.Name = "panelAnimalDet";
            this.panelAnimalDet.Size = new System.Drawing.Size(258, 424);
            this.panelAnimalDet.TabIndex = 0;
            this.panelAnimalDet.Click += new System.EventHandler(this.DetailFocus);
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
            "RECOVERED"});
            this.comboBox_aniObjType.Location = new System.Drawing.Point(125, 0);
            this.comboBox_aniObjType.Name = "comboBox_aniObjType";
            this.comboBox_aniObjType.Size = new System.Drawing.Size(130, 21);
            this.comboBox_aniObjType.TabIndex = 16;
            // 
            // groupVehDet
            // 
            this.groupVehDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupVehDet.Controls.Add(this.panelVehDet);
            this.groupVehDet.Location = new System.Drawing.Point(1082, 3);
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
            this.panelVehDet.Controls.Add(this.label_vehObjType);
            this.panelVehDet.Controls.Add(this.comboBox_vehObjType);
            this.panelVehDet.Location = new System.Drawing.Point(3, 16);
            this.panelVehDet.Name = "panelVehDet";
            this.panelVehDet.Size = new System.Drawing.Size(258, 424);
            this.panelVehDet.TabIndex = 0;
            this.panelVehDet.Click += new System.EventHandler(this.DetailFocus);
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
            "RECOVERED"});
            this.comboBox_vehObjType.Location = new System.Drawing.Point(125, 0);
            this.comboBox_vehObjType.Name = "comboBox_vehObjType";
            this.comboBox_vehObjType.Size = new System.Drawing.Size(130, 21);
            this.comboBox_vehObjType.TabIndex = 14;
            // 
            // groupStMdDet
            // 
            this.groupStMdDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupStMdDet.Controls.Add(this.panelStMdDet);
            this.groupStMdDet.Location = new System.Drawing.Point(2158, 3);
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
            this.groupItemDet.Location = new System.Drawing.Point(1621, 3);
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
            this.groupHosDet.Location = new System.Drawing.Point(813, 3);
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
            this.panelHosDet.Controls.Add(this.label_hosObjType);
            this.panelHosDet.Controls.Add(this.comboBox_hosObjType);
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
            // label_hosObjType
            // 
            this.label_hosObjType.AutoSize = true;
            this.label_hosObjType.Location = new System.Drawing.Point(3, 3);
            this.label_hosObjType.Name = "label_hosObjType";
            this.label_hosObjType.Size = new System.Drawing.Size(116, 13);
            this.label_hosObjType.TabIndex = 13;
            this.label_hosObjType.Text = "Target Objective Type:";
            // 
            // comboBox_hosObjType
            // 
            this.comboBox_hosObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_hosObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hosObjType.FormattingEnabled = true;
            this.comboBox_hosObjType.Items.AddRange(new object[] {
            "ELIMINATE",
            "RECOVERED"});
            this.comboBox_hosObjType.Location = new System.Drawing.Point(125, 0);
            this.comboBox_hosObjType.Name = "comboBox_hosObjType";
            this.comboBox_hosObjType.Size = new System.Drawing.Size(130, 21);
            this.comboBox_hosObjType.TabIndex = 12;
            // 
            // h_label_intrgt
            // 
            this.h_label_intrgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.h_label_intrgt.AutoSize = true;
            this.h_label_intrgt.Location = new System.Drawing.Point(88, 51);
            this.h_label_intrgt.Name = "h_label_intrgt";
            this.h_label_intrgt.Size = new System.Drawing.Size(146, 13);
            this.h_label_intrgt.TabIndex = 0;
            this.h_label_intrgt.Text = "Interrogate For Whereabouts:";
            // 
            // h_checkBox_intrgt
            // 
            this.h_checkBox_intrgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.h_checkBox_intrgt.AutoSize = true;
            this.h_checkBox_intrgt.Location = new System.Drawing.Point(240, 51);
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
            this.comboBox_Body.Location = new System.Drawing.Point(125, 24);
            this.comboBox_Body.Name = "comboBox_Body";
            this.comboBox_Body.Size = new System.Drawing.Size(130, 21);
            this.comboBox_Body.TabIndex = 1;
            this.comboBox_Body.SelectedIndexChanged += new System.EventHandler(this.comboBox_Body_SelectedIndexChanged);
            // 
            // label_Body
            // 
            this.label_Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Body.AutoSize = true;
            this.label_Body.Location = new System.Drawing.Point(85, 27);
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
            this.Size = new System.Drawing.Size(2438, 452);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.groupHeliDet.ResumeLayout(false);
            this.panelHeliDetail.ResumeLayout(false);
            this.panelHeliDetail.PerformLayout();
            this.groupActiveItemDet.ResumeLayout(false);
            this.groupExistingEneDet.ResumeLayout(false);
            this.panelCPEnemyDet.ResumeLayout(false);
            this.panelCPEnemyDet.PerformLayout();
            this.groupNewEneDet.ResumeLayout(false);
            this.panelQuestEnemyDet.ResumeLayout(false);
            this.panelQuestEnemyDet.PerformLayout();
            this.groupAnimalDet.ResumeLayout(false);
            this.panelAnimalDet.ResumeLayout(false);
            this.panelAnimalDet.PerformLayout();
            this.groupVehDet.ResumeLayout(false);
            this.panelVehDet.ResumeLayout(false);
            this.panelVehDet.PerformLayout();
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
        public GroupBox groupHeliDet;
        public Panel panelHeliDetail;
        private ComboBox comboBox_eneObjType1;
        private Label label_eneObjType1;
        private Label label_eneObjType2;
        private ComboBox comboBox_eneObjType2;
        private Label label_HeliObjType;
        private ComboBox comboBox_heliObjType;
        private Label label_hosObjType;
        private ComboBox comboBox_hosObjType;
        private Label label_aniObjType;
        private ComboBox comboBox_aniObjType;
        private Label label_vehObjType;
        private ComboBox comboBox_vehObjType;
    }
}