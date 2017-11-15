using SOC.QuestComponents;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.UI
{
    public partial class Details : UserControl
    {
        List<HostageDetail> hostageDetails;
        List<VehicleDetail> vehicleDetails;
        List<ItemDetail> itemDetails;
        List<ModelDetail> modelDetails;
        List<ActiveItemDetail> activeItemDetails;
        List<AnimalDetail> animalDetails;
        public QuestDetails questDetails;

        public string[] Langs = { "english", "russian", "pashto", "kikongo", "afrikaans" };

        public Details(List<Coordinates> HostageCoords, List<Coordinates> VehicleCoords, List<Coordinates> ItemCoords, List<Coordinates> ModelCoords, List<Coordinates> ActItemsCoords, List<Coordinates> AnimalCoords)
        {
            InitializeComponent();

            hostageDetails = new List<HostageDetail>();
            for (int i = 0; i < HostageCoords.Count; i++)
            {
                var hosDet = new HostageDetail(HostageCoords[i], i);
                hosDet.BuildDetail();
                hostageDetails.Add(hosDet);
                panelHosDet.Controls.Add(hosDet.h_groupBox_main);
            }

            vehicleDetails = new List<VehicleDetail>();
            for (int i = 0; i < VehicleCoords.Count; i++)
            {
                var vehDet = new VehicleDetail(VehicleCoords[i], i);
                vehDet.BuildDetail();
                vehicleDetails.Add(vehDet);
                panelVehDet.Controls.Add(vehDet.v_groupBox_main);
            }

            itemDetails = new List<ItemDetail>();
            for (int i = 0; i < ItemCoords.Count; i++)
            {
                var itDet = new ItemDetail(ItemCoords[i], i);
                itDet.BuildDetail();
                itemDetails.Add(itDet);
                panelItemDet.Controls.Add(itDet.i_groupBox_main);
            }

            modelDetails = new List<ModelDetail>();
            for (int i = 0; i < ModelCoords.Count; i++)
            {
                var stmdDet = new ModelDetail(ModelCoords[i], i);
                stmdDet.BuildDetail();
                modelDetails.Add(stmdDet);
                panelStMdDet.Controls.Add(stmdDet.m_groupBox_main);
            }

            activeItemDetails = new List<ActiveItemDetail>();
            for (int i = 0; i < ActItemsCoords.Count; i++)
            {
                var acitDet = new ActiveItemDetail(ActItemsCoords[i], i);
                acitDet.BuildDetail();
                activeItemDetails.Add(acitDet);
                panelAcItDet.Controls.Add(acitDet.ai_groupBox_main);
            }

            animalDetails = new List<AnimalDetail>();
            for (int i = 0; i < AnimalCoords.Count; i++)
            {
                var animDet = new AnimalDetail(AnimalCoords[i], i);
                animDet.BuildDetail();
                animalDetails.Add(animDet);
                panelAnimalDet.Controls.Add(animDet.a_groupBox_main);
            }

            this.comboBox_Body.Items.Clear();
            foreach (BodyInfoEntry infoEntry in BodyInfo.BodyInfoArray)
            {
                this.comboBox_Body.Items.Add(infoEntry.bodyName);
            }

            if (hostageDetails.Count > 0)
            {
                h_checkBox_intrgt.Visible = true;
                h_label_intrgt.Visible = true;
                label_Body.Visible = true;
                comboBox_Body.Visible = true;
                comboBox_Body.Text = "AFGH_HOSTAGE";

            } else
            {
                h_checkBox_intrgt.Visible = false;
                h_label_intrgt.Visible = false;
                label_Body.Visible = false;
                comboBox_Body.Visible = false;
            }

        }

        public QuestDetails getQuestDetails()
        {
            questDetails = new QuestDetails(hostageDetails, vehicleDetails, itemDetails, modelDetails, comboBox_Body.SelectedIndex, h_checkBox_intrgt.Checked);
            return questDetails;
        }

        private void comboBox_Body_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Body.Text.ToUpper().Contains("FEMALE"))
            {
                foreach (HostageDetail hostageDetail in hostageDetails)
                {
                    hostageDetail.h_comboBox_lang.Items.Clear();
                    hostageDetail.h_comboBox_lang.Items.Add("english");
                    hostageDetail.h_comboBox_lang.SelectedIndex = 0;
                }
            }
            else
            {
                foreach (HostageDetail hostageDetail in hostageDetails)
                {
                    hostageDetail.h_comboBox_lang.Items.Clear();
                    hostageDetail.h_comboBox_lang.Items.AddRange(Langs);
                    hostageDetail.h_comboBox_lang.SelectedIndex = 0;
                }
            }
        }
    }

    
}
