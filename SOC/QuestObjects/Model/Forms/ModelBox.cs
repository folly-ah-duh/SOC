using SOC.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace SOC.QuestObjects.Model
{
    /*
    public class ModelBox : QuestBox
    {
        Model model;

        public GroupBox m_groupBox_main;
        public TextBox m_textBox_zcoord;
        public TextBox m_textBox_ycoord;
        public TextBox m_textBox_xcoord;
        public Label m_label_preset;
        public TextBox m_textBox_zrot;
        public TextBox m_textBox_yrot;
        public TextBox m_textBox_xrot;
        public TextBox m_textBox_wrot;
        public ComboBox m_comboBox_preset;
        public Label m_label_rot;
        public Label m_label_coord;
        public Label m_label_GeomNotFound;

        public ModelBox(Model m) : base(m.coordinates, m.number)
        {
            model = m;
        }

        public override void SetObject(QuestBox detail)
        {
            ModelBox modelDetail = (ModelBox)detail;
            m_comboBox_preset.Text = modelDetail.m_comboBox_preset.Text;

        }

        public override void BuildObject()
        {

            int width = 6;
            int comboboxWidth = width - 100;
            this.m_groupBox_main = new System.Windows.Forms.GroupBox();
            this.m_textBox_zcoord = new System.Windows.Forms.TextBox();
            this.m_textBox_ycoord = new System.Windows.Forms.TextBox();
            this.m_textBox_xcoord = new System.Windows.Forms.TextBox();
            this.m_label_preset = new System.Windows.Forms.Label();
            this.m_textBox_xrot = new System.Windows.Forms.TextBox();
            this.m_textBox_yrot = new System.Windows.Forms.TextBox();
            this.m_textBox_zrot = new System.Windows.Forms.TextBox();
            this.m_textBox_wrot = new System.Windows.Forms.TextBox();
            this.m_comboBox_preset = new System.Windows.Forms.ComboBox();
            this.m_label_rot = new System.Windows.Forms.Label();
            this.m_label_coord = new System.Windows.Forms.Label();
            this.m_label_GeomNotFound = new System.Windows.Forms.Label();
            this.m_groupBox_main.SuspendLayout();

            // 
            // m_groupBox_main
            // 
            this.m_groupBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_groupBox_main.Controls.Add(this.m_textBox_zcoord);
            this.m_groupBox_main.Controls.Add(this.m_textBox_ycoord);
            this.m_groupBox_main.Controls.Add(this.m_textBox_xcoord);
            this.m_groupBox_main.Controls.Add(this.m_label_rot);
            this.m_groupBox_main.Controls.Add(this.m_label_coord);
            this.m_groupBox_main.Controls.Add(this.m_textBox_xrot);
            this.m_groupBox_main.Controls.Add(this.m_textBox_yrot);
            this.m_groupBox_main.Controls.Add(this.m_textBox_zrot);
            this.m_groupBox_main.Controls.Add(this.m_textBox_wrot);
            this.m_groupBox_main.Controls.Add(this.m_comboBox_preset);
            this.m_groupBox_main.Controls.Add(this.m_label_preset);
            this.m_groupBox_main.Controls.Add(this.m_label_GeomNotFound);
            this.m_groupBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.m_groupBox_main.Location = new System.Drawing.Point(3, 3 + (model.number * 113));
            this.m_groupBox_main.Name = "m_groupBox_main";
            this.m_groupBox_main.Size = new System.Drawing.Size(width, 95);
            this.m_groupBox_main.TabIndex = 1;
            this.m_groupBox_main.TabStop = false;
            this.m_groupBox_main.Text = model.name;
            // 
            // m_textBox_zcoord
            // 
            this.m_textBox_zcoord.Location = new System.Drawing.Point(193, 14);
            this.m_textBox_zcoord.Name = "m_textBox_zcoord";
            this.m_textBox_zcoord.Size = new System.Drawing.Size(41, 20);
            this.m_textBox_zcoord.TabIndex = 4;
            this.m_textBox_zcoord.Text = model.coordinates.zCoord;
            // 
            // m_label_filename
            // 
            this.m_label_GeomNotFound.AutoSize = true;
            this.m_label_GeomNotFound.Location = new System.Drawing.Point(22, 94);
            this.m_label_GeomNotFound.Name = "m_label_filePath";
            this.m_label_GeomNotFound.Size = new System.Drawing.Size(54, 13);
            this.m_label_GeomNotFound.TabIndex = 6;
            this.m_label_GeomNotFound.ForeColor = System.Drawing.Color.Yellow;
            this.m_label_GeomNotFound.Text = "";
            // 
            // m_textBox_ycoord
            // 
            this.m_textBox_ycoord.Location = new System.Drawing.Point(139, 14);
            this.m_textBox_ycoord.Name = "m_textBox_ycoord";
            this.m_textBox_ycoord.Size = new System.Drawing.Size(41, 20);
            this.m_textBox_ycoord.TabIndex = 3;
            this.m_textBox_ycoord.Text = model.coordinates.yCoord;
            // 
            // m_textBox_rot
            // 
            //this.m_textBox_rot.FormattingEnabled = true;
            //this.m_textBox_rot.Location = new System.Drawing.Point(84, 39);
            //this.m_textBox_rot.Name = "m_textBox_rot";
            //this.m_textBox_rot.Size = new System.Drawing.Size(150, 21);
            //this.m_textBox_rot.TabIndex = 12;
            //this.m_textBox_rot.Items.AddRange(QuestComponents.rotation);
            // 
            // m_textBox_xcoord
            // 
            this.m_textBox_xcoord.Location = new System.Drawing.Point(84, 14);
            this.m_textBox_xcoord.Name = "m_textBox_xcoord";
            this.m_textBox_xcoord.Size = new System.Drawing.Size(41, 20);
            this.m_textBox_xcoord.TabIndex = 2;
            this.m_textBox_xcoord.Text = model.coordinates.xCoord;
            // 
            // m_label_rot
            // 
            this.m_label_rot.AutoSize = true;
            this.m_label_rot.Location = new System.Drawing.Point(20, 42);
            this.m_label_rot.Name = "m_label_rot";
            this.m_label_rot.Size = new System.Drawing.Size(50, 13);
            this.m_label_rot.TabIndex = 7;
            this.m_label_rot.Text = "Rotation: ";

            this.m_textBox_xrot.Location = new System.Drawing.Point(84, 39);
            this.m_textBox_xrot.Name = "m_textBox_xrocoord";
            this.m_textBox_xrot.Size = new System.Drawing.Size(31, 20);
            this.m_textBox_xrot.TabIndex = 5;
            this.m_textBox_xrot.Text = model.rotation.quatRotation.xval;
            this.m_textBox_yrot.Location = new System.Drawing.Point(123, 39);
            this.m_textBox_yrot.Name = "m_textBox_yrocoord";
            this.m_textBox_yrot.Size = new System.Drawing.Size(31, 20);
            this.m_textBox_yrot.TabIndex = 6;
            this.m_textBox_yrot.Text = model.rotation.quatRotation.yval;
            this.m_textBox_zrot.Location = new System.Drawing.Point(163, 39);
            this.m_textBox_zrot.Name = "m_textBox_zrocoord";
            this.m_textBox_zrot.Size = new System.Drawing.Size(31, 20);
            this.m_textBox_zrot.TabIndex = 7;
            this.m_textBox_zrot.Text = model.rotation.quatRotation.zval;
            this.m_textBox_wrot.Location = new System.Drawing.Point(203, 39);
            this.m_textBox_wrot.Name = "m_textBox_wrocoord";
            this.m_textBox_wrot.Size = new System.Drawing.Size(31, 20);
            this.m_textBox_wrot.TabIndex = 8;
            this.m_textBox_wrot.Text = model.rotation.quatRotation.wval;
            // 
            // m_label_coord
            // 
            this.m_label_coord.AutoSize = true;
            this.m_label_coord.Location = new System.Drawing.Point(4, 17);
            this.m_label_coord.Name = "m_label_coord";
            this.m_label_coord.Size = new System.Drawing.Size(66, 13);
            this.m_label_coord.TabIndex = 6;
            this.m_label_coord.Text = "Coordinates:";

            this.m_comboBox_preset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_comboBox_preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBox_preset.FormattingEnabled = true;
            this.m_comboBox_preset.Location = new System.Drawing.Point(84, 66);
            this.m_comboBox_preset.Items.AddRange(getPresetModelList());
            this.m_comboBox_preset.Name = "m_comboBox_preset";
            this.m_comboBox_preset.Size = new System.Drawing.Size(comboboxWidth, 21);
            this.m_comboBox_preset.TabIndex = 7;
            this.m_comboBox_preset.SelectedIndexChanged += new System.EventHandler(this.m_comboBox_preset_selectedIndexChanged);

            if (m_comboBox_preset.Items.Contains(model.model))
                this.m_comboBox_preset.Text = model.model;
            else if (m_comboBox_preset.Items.Count > 0)
                this.m_comboBox_preset.SelectedIndex = 0;

            m_comboBox_preset.SelectedIndexChanged += new EventHandler(this.FocusGroupBox);

            this.m_label_preset.AutoSize = true;
            this.m_label_preset.Location = new System.Drawing.Point(31, 69);
            this.m_label_preset.Name = "m_label_preset";
            this.m_label_preset.Size = new System.Drawing.Size(50, 13);
            this.m_label_preset.TabIndex = 6;
            this.m_label_preset.Text = "Model:";

            this.m_groupBox_main.ResumeLayout(false);
            this.m_groupBox_main.PerformLayout();

        }

        private string[] getPresetModelList()
        {

            string[] FileNames = Directory.GetFiles(ModelAssets.modelAssetsPath, "*.fmdl");
            for (int i = 0; i < FileNames.Length; i++)
            {
                int filenameLength = FileNames[i].Substring(FileNames[i].LastIndexOf('\\') + 1).Length - 1;
                FileNames[i] = FileNames[i].Substring(FileNames[i].LastIndexOf('\\') + 1, filenameLength - 4);
            }
            return FileNames;
        }

        private bool hasGeom()
        {
            if (!string.IsNullOrEmpty(m_comboBox_preset.Text))
            {
                string[] geomNames = Directory.GetFiles(ModelAssets.modelAssetsPath, "*.geom");
                for (int i = 0; i < geomNames.Length; i++)
                {
                    if (geomNames[i].Contains(m_comboBox_preset.Text + ".geom"))
                        return true;
                }
            }
            return false;
        }

        private void m_comboBox_preset_selectedIndexChanged(object sender, EventArgs e)
        {
            if (!hasGeom() && !string.IsNullOrEmpty(m_comboBox_preset.Text))
            {
                m_label_GeomNotFound.Visible = true;
                m_label_GeomNotFound.Text = "Geom File Not Found For " + m_comboBox_preset.Text;
            }
            else
                m_label_GeomNotFound.Visible = false;

        }

        public override GroupBox getGroupBoxMain()
        {
            return m_groupBox_main;
        }
    }
    */
}
