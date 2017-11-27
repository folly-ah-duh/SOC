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

        public Details()
        {
            InitializeComponent();
            hostageDetails = new List<HostageDetail>();
            vehicleDetails = new List<VehicleDetail>();
            itemDetails = new List<ItemDetail>();
            modelDetails = new List<ModelDetail>();
            activeItemDetails = new List<ActiveItemDetail>();
            animalDetails = new List<AnimalDetail>();

            foreach (BodyInfoEntry infoEntry in BodyInfo.BodyInfoArray)
            {
                this.comboBox_Body.Items.Add(infoEntry.bodyName);
            }
            comboBox_Body.Text = "AFGH_HOSTAGE";
        }

        public void RefreshDetails(List<Coordinates> HostageCoords, List<Coordinates> VehicleCoords, List<Coordinates> ItemCoords, List<Coordinates> ModelCoords, List<Coordinates> ActItemsCoords, List<Coordinates> AnimalCoords)
        {
            //
            // Add/Remove for Hostages
            //
            for (int i = 0; i < HostageCoords.Count; i++)
            {
                if (i < hostageDetails.Count)
                    continue;
                var hosDet = new HostageDetail(HostageCoords[i], i);
                hosDet.BuildDetail();
                hostageDetails.Add(hosDet);
                panelHosDet.Controls.Add(hosDet.h_groupBox_main);
            }
            for (int i = hostageDetails.Count - 1; i > -1; i--)
            {
                if (i <= HostageCoords.Count - 1)
                    continue;
                panelHosDet.Controls.Remove(hostageDetails[i].h_groupBox_main);
                hostageDetails.RemoveAt(i);
            }
            for (int i = 0; i < hostageDetails.Count; i++)
            {
                hostageDetails[i].h_textBox_xcoord.Text = HostageCoords[i].xCoord;
                hostageDetails[i].h_textBox_ycoord.Text = HostageCoords[i].yCoord;
                hostageDetails[i].h_textBox_zcoord.Text = HostageCoords[i].zCoord;
                hostageDetails[i].h_comboBox_rot.Text = HostageCoords[i].roty;
            }
            //
            // Add/Remove for Vehicles
            //
            for (int i = 0; i < VehicleCoords.Count; i++)
            {
                if (i < vehicleDetails.Count)
                    continue;
                var vehDet = new VehicleDetail(VehicleCoords[i], i);
                vehDet.BuildDetail();
                vehicleDetails.Add(vehDet);
                panelVehDet.Controls.Add(vehDet.v_groupBox_main);
            }
            for (int i = vehicleDetails.Count - 1; i > -1; i--)
            {
                if (i <= VehicleCoords.Count - 1)
                    continue;
                panelVehDet.Controls.RemoveAt(i);
                vehicleDetails.RemoveAt(i);
            }
            for (int i = 0; i < vehicleDetails.Count; i++)
            {
                vehicleDetails[i].v_textBox_xcoord.Text = VehicleCoords[i].xCoord;
                vehicleDetails[i].v_textBox_ycoord.Text = VehicleCoords[i].yCoord;
                vehicleDetails[i].v_textBox_zcoord.Text = VehicleCoords[i].zCoord;
                vehicleDetails[i].v_comboBox_rot.Text = VehicleCoords[i].roty;
            }
            //
            // Add/Remove for Items
            //
            for (int i = 0; i < ItemCoords.Count; i++)
            {
                if (i < itemDetails.Count)
                    continue;
                var itDet = new ItemDetail(ItemCoords[i], i);
                itDet.BuildDetail();
                itemDetails.Add(itDet);
                panelItemDet.Controls.Add(itDet.i_groupBox_main);
            }
            for (int i = itemDetails.Count - 1; i > -1; i--)
            {
                if (i <= ItemCoords.Count - 1)
                    continue;
                panelItemDet.Controls.RemoveAt(i);
                itemDetails.RemoveAt(i);
            }
            for (int i = 0; i < itemDetails.Count; i++)
            {
                itemDetails[i].i_textBox_xcoord.Text = VehicleCoords[i].xCoord;
                itemDetails[i].i_textBox_ycoord.Text = VehicleCoords[i].yCoord;
                itemDetails[i].i_textBox_zcoord.Text = VehicleCoords[i].zCoord;
                itemDetails[i].i_textBox_yrot.Text = Fox2Info.getQuaternionY(VehicleCoords[i].roty);
                itemDetails[i].i_textBox_wrot.Text = Fox2Info.getQuaternionW(VehicleCoords[i].roty);
            }
            //
            // Add/Remove for Models
            //
            for (int i = 0; i < ModelCoords.Count; i++)
            {
                if (i < modelDetails.Count)
                    continue;
                var stmdDet = new ModelDetail(ModelCoords[i], i);
                stmdDet.BuildDetail();
                modelDetails.Add(stmdDet);
                panelStMdDet.Controls.Add(stmdDet.m_groupBox_main);
            }
            for (int i = modelDetails.Count - 1; i > -1; i--)
            {
                if (i <= ModelCoords.Count - 1)
                    continue;
                panelStMdDet.Controls.RemoveAt(i);
                modelDetails.RemoveAt(i);
            }
            for (int i = 0; i < modelDetails.Count; i++)
            {
                modelDetails[i].m_textBox_xcoord.Text = ModelCoords[i].xCoord;
                modelDetails[i].m_textBox_ycoord.Text = ModelCoords[i].yCoord;
                modelDetails[i].m_textBox_zcoord.Text = ModelCoords[i].zCoord;
                modelDetails[i].m_textBox_yrot.Text = Fox2Info.getQuaternionY(ModelCoords[i].roty);
                modelDetails[i].m_textBox_wrot.Text = Fox2Info.getQuaternionW(ModelCoords[i].roty);
            }
            //
            // Add/Remove for Active Items
            //
            for (int i = 0; i < ActItemsCoords.Count; i++)
            {
                if (i < activeItemDetails.Count)
                    continue;
                var acitDet = new ActiveItemDetail(ActItemsCoords[i], i);
                acitDet.BuildDetail();
                activeItemDetails.Add(acitDet);
                panelAcItDet.Controls.Add(acitDet.ai_groupBox_main);
            }
            for (int i = activeItemDetails.Count - 1; i > -1; i--)
            {
                if (i <= ActItemsCoords.Count - 1)
                    continue;
                panelAcItDet.Controls.RemoveAt(i);
                activeItemDetails.RemoveAt(i);
            }
            for (int i = 0; i < activeItemDetails.Count; i++)
            {
                activeItemDetails[i].ai_textBox_xcoord.Text = ActItemsCoords[i].xCoord;
                activeItemDetails[i].ai_textBox_ycoord.Text = ActItemsCoords[i].yCoord;
                activeItemDetails[i].ai_textBox_zcoord.Text = ActItemsCoords[i].zCoord;
                activeItemDetails[i].ai_textBox_yrot.Text = Fox2Info.getQuaternionY(ActItemsCoords[i].roty);
                activeItemDetails[i].ai_textBox_wrot.Text = Fox2Info.getQuaternionW(ActItemsCoords[i].roty);
            }
            //
            // Add/Remove for Animals
            //
            for (int i = 0; i < AnimalCoords.Count; i++)
            {
                if (i < animalDetails.Count)
                    continue;
                var animDet = new AnimalDetail(AnimalCoords[i], i);
                animDet.BuildDetail();
                animalDetails.Add(animDet);
                panelAnimalDet.Controls.Add(animDet.a_groupBox_main);
            }
            for (int i = animalDetails.Count - 1; i > -1; i--)
            {
                if (i <= AnimalCoords.Count - 1)
                    continue;
                panelAnimalDet.Controls.RemoveAt(i);
                animalDetails.RemoveAt(i);
            }
            for (int i = 0; i < animalDetails.Count; i++)
            {
                animalDetails[i].a_textBox_xcoord.Text = AnimalCoords[i].xCoord;
                animalDetails[i].a_textBox_ycoord.Text = AnimalCoords[i].yCoord;
                animalDetails[i].a_textBox_zcoord.Text = AnimalCoords[i].zCoord;
                animalDetails[i].a_comboBox_rot.Text = AnimalCoords[i].roty;
            }
            
            if (HostageCoords.Count > 0)
            {
                h_checkBox_intrgt.Visible = true;
                h_label_intrgt.Visible = true;
                label_Body.Visible = true;
                comboBox_Body.Visible = true;
            }
            else
            {
                h_checkBox_intrgt.Visible = false;
                h_label_intrgt.Visible = false;
                label_Body.Visible = false;
                comboBox_Body.Visible = false;
            }
            RefreshHostageLanguage();
        }

        public QuestDetails getQuestDetails()
        {
            questDetails = new QuestDetails(hostageDetails, vehicleDetails, itemDetails, modelDetails, activeItemDetails, animalDetails,comboBox_Body.SelectedIndex, h_checkBox_intrgt.Checked);
            return questDetails;
        }

        private void comboBox_Body_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshHostageLanguage();
        }

        private void RefreshHostageLanguage()
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
