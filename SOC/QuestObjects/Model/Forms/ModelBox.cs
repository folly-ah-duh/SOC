using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOC.UI;
using SOC.QuestObjects.Common;
using System.IO;

namespace SOC.QuestObjects.Model
{
    public partial class ModelBox : QuestBox
    {
        public int ID;

        public ModelBox(Model m)
        {
            InitializeComponent();
            ID = m.ID;

            textBox_xcoord.Text = m.position.coords.xCoord;
            textBox_ycoord.Text = m.position.coords.yCoord;
            textBox_zcoord.Text = m.position.coords.zCoord;

            textBox_xrot.Text = m.position.rotation.quatRotation.xval;
            textBox_yrot.Text = m.position.rotation.quatRotation.yval;
            textBox_zrot.Text = m.position.rotation.quatRotation.zval;
            textBox_wrot.Text = m.position.rotation.quatRotation.wval;

            comboBox_model.Items.AddRange(getModelList());

            if (comboBox_model.Items.Contains(m.model))
                comboBox_model.Text = m.model;
            else if (comboBox_model.Items.Count > 0)
                comboBox_model.SelectedIndex = 0;

            if (checkBox_collision.Enabled)
                checkBox_collision.Checked = m.collision;
        }

        private string[] getModelList()
        {

            string[] FileNames = Directory.GetFiles(ModelAssets.modelAssetsPath, "*.fmdl");
            for (int i = 0; i < FileNames.Length; i++)
            {
                FileNames[i] = Path.GetFileNameWithoutExtension(FileNames[i]);
            }
            return FileNames;
        }

        private bool hasGeom()
        {
            if (!string.IsNullOrEmpty(comboBox_model.Text))
            {
                string[] geomNames = Directory.GetFiles(ModelAssets.modelAssetsPath, "*.geom");
                for (int i = 0; i < geomNames.Length; i++)
                {
                    if (geomNames[i].Contains(comboBox_model.Text + ".geom"))
                        return true;
                }
            }
            return false;
        }

        private void m_comboBox_model_selectedIndexChanged(object sender, EventArgs e)
        {
            if (!hasGeom() && !string.IsNullOrEmpty(comboBox_model.Text))
            {
                DisableCollisionCheckBox("Missing .Geom");
            }
            else
            {
                EnableCollisionCheckBox();
            }

        }

        private void EnableCollisionCheckBox()
        {
            checkBox_collision.Enabled = true;
            checkBox_collision.Text = "Enable Collision";
        }

        private void DisableCollisionCheckBox(string reason)
        {
            checkBox_collision.Text = $"Enable Collision ({reason})";
            checkBox_collision.Checked = false;
            checkBox_collision.Enabled = false;
        }

        public override QuestObject getQuestObject()
        {
            return new Model(this);
        }
    }
}
