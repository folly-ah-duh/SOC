using SOC.QuestComponents;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.UI
{
    public partial class Details : UserControl
    {
        List<Detail> hostageDetails;
        List<Detail> vehicleDetails;
        List<Detail> itemDetails;
        List<Detail> modelDetails;
        List<Detail> activeItemDetails;
        List<Detail> animalDetails;
        public QuestDetails questDetails;

        public string[] Langs = { "english", "russian", "pashto", "kikongo", "afrikaans" };

        public Details()
        {
            InitializeComponent();
            hostageDetails = new List<Detail>();
            vehicleDetails = new List<Detail>();
            itemDetails = new List<Detail>();
            modelDetails = new List<Detail>();
            activeItemDetails = new List<Detail>();
            animalDetails = new List<Detail>();

            foreach (BodyInfoEntry infoEntry in BodyInfo.BodyInfoArray)
            {
                this.comboBox_Body.Items.Add(infoEntry.bodyName);
            }
            comboBox_Body.Text = "AFGH_HOSTAGE";
        }

        public void AddDetail(Detail newDetail, List<Detail> details, Panel panel)
        {
            newDetail.BuildDetail();

            if (newDetail.getIndex() < details.Count)
            {
                newDetail.SetDetail(details[newDetail.getIndex()]);
                panel.Controls.Remove(details[newDetail.getIndex()].getGroupBoxMain());
                details[newDetail.getIndex()] = newDetail;
            }
            else
            {
                details.Add(newDetail);
            }

            panel.Controls.Add(details[newDetail.getIndex()].getGroupBoxMain());
        }

        public void RemoveExtraDetails(List<Detail> details, int remainder, Panel panel)
        {
            for (int i = details.Count - 1; i > -1; i--)
            {
                if (i <= remainder - 1)
                    continue;
                {
                    panel.Controls.Remove(details[i].getGroupBoxMain());
                    details.RemoveAt(i);
                }
            }
        }

        public void RefreshDetails(List<Coordinates> HostageCoords, List<Coordinates> VehicleCoords, List<Coordinates> ItemCoords, List<Coordinates> ModelCoords, List<Coordinates> ActItemsCoords, List<Coordinates> AnimalCoords)
        {

            Tuple<List<Detail>, List<Coordinates>, Panel>[] detailTuples =
            {
                new Tuple<List<Detail>, List<Coordinates>, Panel>(hostageDetails, HostageCoords, panelHosDet),
                new Tuple<List<Detail>, List<Coordinates>, Panel>(vehicleDetails, VehicleCoords, panelVehDet),
                new Tuple<List<Detail>, List<Coordinates>, Panel>(animalDetails, AnimalCoords, panelAnimalDet),
                new Tuple<List<Detail>, List<Coordinates>, Panel>(itemDetails, ItemCoords, panelItemDet),
                new Tuple<List<Detail>, List<Coordinates>, Panel>(activeItemDetails, ActItemsCoords, panelAcItDet),
                new Tuple<List<Detail>, List<Coordinates>, Panel>(modelDetails, ModelCoords, panelStMdDet),
            };
            Tuple<List<Detail>, List<Coordinates>, Panel> detailTuple;

            for (int i = 0; i < detailTuples.Length; i++)
            {
                detailTuple = detailTuples[i];
                detailTuple.Item3.AutoScroll = false;
                switch (i)
                {
                    case 0: // hostages
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            AddDetail(new HostageDetail(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 1: // vehicles
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            AddDetail(new VehicleDetail(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 2: // animals
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            AddDetail(new AnimalDetail(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 3: // items
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            AddDetail(new ItemDetail(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 4: // active items
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            AddDetail(new ActiveItemDetail(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 5: // models
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            AddDetail(new ModelDetail(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                }
                detailTuple.Item3.AutoScroll = true;
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

            if (ActItemsCoords.Count == 0)
            {
                panelItemDet.Visible = true;
                groupItemDet.Text = "Item Details";
                panelAcItDet.Visible = false;
            }
            else
            {
                panelAcItDet.Visible = true;
                groupItemDet.Text = "Active Item Details";
                panelItemDet.Visible = false;
            }
        }

        public QuestDetails getQuestDetails()
        {
            List<HostageDetail> hDetailsCasted = new List<HostageDetail>(); // If there's a better way of doing this....
            List<VehicleDetail> vDetailsCasted = new List<VehicleDetail>();
            List<AnimalDetail> aDetailsCasted = new List<AnimalDetail>();
            List<ItemDetail> iDetailsCasted = new List<ItemDetail>();
            List<ActiveItemDetail> aiDetailsCasted = new List<ActiveItemDetail>();
            List<ModelDetail> mDetailsCasted = new List<ModelDetail>();

            foreach (Detail detail in hostageDetails)
                hDetailsCasted.Add((HostageDetail)detail);

            foreach (Detail detail in vehicleDetails)
                vDetailsCasted.Add((VehicleDetail)detail);

            foreach (Detail detail in animalDetails)
                aDetailsCasted.Add((AnimalDetail)detail);

            foreach (Detail detail in itemDetails)
                iDetailsCasted.Add((ItemDetail)detail);

            foreach (Detail detail in activeItemDetails)
                aiDetailsCasted.Add((ActiveItemDetail)detail);

            foreach (Detail detail in modelDetails)
                mDetailsCasted.Add((ModelDetail)detail);

            questDetails = new QuestDetails(hDetailsCasted, vDetailsCasted, aDetailsCasted, iDetailsCasted, aiDetailsCasted, mDetailsCasted, comboBox_Body.SelectedIndex, h_checkBox_intrgt.Checked);
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
