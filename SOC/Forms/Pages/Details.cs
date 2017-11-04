using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOC.UI
{
    public partial class Details : UserControl
    {
        List<HostageDetail> hostageDetails;
        List<VehicleDetail> vehicleDetails;
        List<ItemDetail> itemDetails;
        List<ModelDetail> modelDetails;
        public QuestDetails questDetails;

        public string[] Langs = { "english", "russian", "pashto", "kikongo", "afrikaans" };

        public Details(List<Coordinates> HostageCoords, List<Coordinates> VehicleCoords, List<Coordinates> ItemCoords, List<Coordinates> ModelCoords)
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

            questDetails = new QuestDetails(hostageDetails, vehicleDetails, itemDetails, modelDetails);

            if (questDetails.hostageDetails.Count > 0)
            {
                h_checkBox_intrgt.Visible = true;
                h_label_intrgt.Visible = true;
                label_Gender.Visible = true;
                comboBox_Gender.Visible = true;
                comboBox_Gender.Text = "Male";

            } else
            {
                h_checkBox_intrgt.Visible = false;
                h_label_intrgt.Visible = false;
                label_Gender.Visible = false;
                comboBox_Gender.Visible = false;
            }

        }
        public Details()
        {
            InitializeComponent();
        }

        private void comboBox_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Gender.Text.Equals("Female"))
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
