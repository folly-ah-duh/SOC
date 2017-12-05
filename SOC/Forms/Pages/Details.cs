using SOC.QuestComponents;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.UI
{
    public partial class Details : UserControl
    {
        List<GroupBox> detailLists;
        List<Detail> questEnemyDetails;
        List<Detail> CPEnemyDetails;
        List<Detail> hostageDetails;
        List<Detail> vehicleDetails;
        List<Detail> itemDetails;
        List<Detail> modelDetails;
        List<Detail> activeItemDetails;
        List<Detail> animalDetails;
        int dynamicPanelWidth;
        public QuestDetails questDetails;

        public string[] Langs = { "english", "russian", "pashto", "kikongo", "afrikaans" };
        public string lastCP = "";
        public string lastRegion = "";

        public Details()
        {
            InitializeComponent();
            DoubleBuffered = true;
            detailLists = new List<GroupBox>();
            questEnemyDetails = new List<Detail>();
            CPEnemyDetails = new List<Detail>();
            hostageDetails = new List<Detail>();
            vehicleDetails = new List<Detail>();
            itemDetails = new List<Detail>();
            modelDetails = new List<Detail>();
            activeItemDetails = new List<Detail>();
            animalDetails = new List<Detail>();
            dynamicPanelWidth = Width / 4 - 20;

            foreach (BodyInfoEntry infoEntry in BodyInfo.BodyInfoArray)
            {
                this.comboBox_Body.Items.Add(infoEntry.bodyName);
            }
            comboBox_Body.Text = "AFGH_HOSTAGE";
        }

        public void RefreshOrAddDetail(Detail newDetail, List<Detail> details, Panel panel)
        {
            newDetail.BuildDetail(dynamicPanelWidth);
            int detailIndex = newDetail.getIndex();

            if (detailIndex < details.Count)
            {
                Detail oldDetail = details[detailIndex];

                newDetail.SetDetail(oldDetail);
                panel.Controls.Remove(oldDetail.getGroupBoxMain());
                details[detailIndex] = newDetail;
            }
            else
            {
                details.Add(newDetail);
            }
            panel.Controls.Add(details[detailIndex].getGroupBoxMain());
        }

        public void RemoveExtraDetails(List<Detail> details, int remainder, Panel panel)
        {
            for (int i = details.Count - 1; i > -1; i--)
            {
                if (i <= remainder - 1)
                    continue;
                {
                    GroupBox detailGroupBox = details[i].getGroupBoxMain();
                    panel.Controls.Remove(detailGroupBox);
                    details.RemoveAt(i);
                    detailGroupBox.Dispose();
                }
            }
        }

        public void RefreshDetails(CP questCP, List<Coordinates> HostageCoords, List<Coordinates> VehicleCoords, List<Coordinates> ItemCoords, List<Coordinates> ModelCoords, List<Coordinates> ActItemsCoords, List<Coordinates> AnimalCoords)
        {
            
            string currentRegion = EnemyInfo.getRegion(questCP);

            if (!currentRegion.Equals("mtbs"))
            {
                string[] enemyBodies = new string[0];
                bool islastRegion = true;

                if (!lastRegion.Equals(currentRegion))
                {
                    islastRegion = false;
                    comboBox_subtype.Items.Clear();
                    comboBox_subtype2.Items.Clear();
                    if (currentRegion.Equals("afgh"))
                    {
                        comboBox_subtype.Items.AddRange(BodyInfo.afghSubTypes);
                        comboBox_subtype2.Items.AddRange(BodyInfo.afghSubTypes);
                        enemyBodies = BodyInfo.afghBodies;
                    }
                    else
                    {
                        comboBox_subtype.Items.AddRange(BodyInfo.mafrSubTypes);
                        comboBox_subtype2.Items.AddRange(BodyInfo.mafrSubTypes);
                        enemyBodies = BodyInfo.mafrBodies;
                    }
                    comboBox_subtype.SelectedIndex = 0;
                }
                else if (lastCP.Equals("NONE"))
                {
                    islastRegion = false;
                    if (currentRegion.Equals("afgh"))
                        enemyBodies = BodyInfo.afghBodies;
                    else
                        enemyBodies = BodyInfo.mafrBodies;
                }
                lastRegion = currentRegion;


                bool isLastCP = false;
                if (lastCP.Equals(questCP.CPname))
                {
                    isLastCP = true;
                }
                lastCP = questCP.CPname;

                panelQuestEnemyDet.AutoScroll = false;
                panelCPEnemyDet.AutoScroll = false;
                for (int i = 0; i < EnemyInfo.MAXHEAVYARMOR; i++)
                {
                    EnemyDetail enemyDetail = new EnemyDetail(i);
                    RefreshOrAddDetail(enemyDetail, questEnemyDetails, panelQuestEnemyDet);
                    if (!isLastCP)
                    {
                        enemyDetail.e_comboBox_sneakroute.Items.Clear();
                        enemyDetail.e_comboBox_cautionroute.Items.Clear();

                        if (questCP.CProutes.Length > 0)
                        {
                            enemyDetail.e_comboBox_sneakroute.Items.AddRange(questCP.CProutes);
                            enemyDetail.e_comboBox_cautionroute.Items.AddRange(questCP.CProutes);
                            enemyDetail.e_comboBox_sneakroute.SelectedIndex = 0;
                            enemyDetail.e_comboBox_cautionroute.SelectedIndex = 0;
                        }
                    }
                    if (!islastRegion)
                    {
                        enemyDetail.e_comboBox_body.Items.Clear();
                        enemyDetail.e_comboBox_body.Items.AddRange(enemyBodies);
                        enemyDetail.e_comboBox_body.SelectedIndex = 0;
                    }

                }
                RemoveExtraDetails(questEnemyDetails, EnemyInfo.MAXHEAVYARMOR, panelQuestEnemyDet);

                for (int i = 0; i < questCP.CPsoldiers.Length; i++)
                {
                    EnemyDetail enemyDetail = new EnemyDetail(i);
                    RefreshOrAddDetail(enemyDetail, CPEnemyDetails, panelCPEnemyDet);
                    enemyDetail.e_groupBox_main.Text = questCP.CPsoldiers[i];
                    enemyDetail.e_label_spawn.Text = "Customize:"; enemyDetail.e_label_spawn.Left = 26;
                    if (!isLastCP)
                    {
                        enemyDetail.e_comboBox_cautionroute.Items.Clear();
                        enemyDetail.e_comboBox_sneakroute.Items.Clear();
                        enemyDetail.e_comboBox_cautionroute.Items.AddRange(questCP.CProutes);
                        enemyDetail.e_comboBox_sneakroute.Items.AddRange(questCP.CProutes);
                        enemyDetail.e_comboBox_cautionroute.SelectedIndex = 0;
                        enemyDetail.e_comboBox_sneakroute.SelectedIndex = 0;
                    }
                    if (!islastRegion)
                    {
                        enemyDetail.e_comboBox_body.Items.Clear();
                        enemyDetail.e_comboBox_body.Items.AddRange(enemyBodies);
                        enemyDetail.e_comboBox_body.SelectedIndex = 0;
                    }
                }
                RemoveExtraDetails(CPEnemyDetails, questCP.CPsoldiers.Length, panelCPEnemyDet);

                panelQuestEnemyDet.AutoScroll = true;
                panelCPEnemyDet.AutoScroll = true;

                if (CPEnemyDetails.Count == 0)
                {
                    checkBox_customizeall.Visible = false;
                    comboBox_subtype2.Visible = false;
                    label_customizeall.Visible = false;
                    label_subtype2.Visible = false;
                }
                else
                {
                    checkBox_customizeall.Visible = true;
                    comboBox_subtype2.Visible = true;
                    label_customizeall.Visible = true;
                    label_subtype2.Visible = true;
                }
                checkBox_spawnall.Visible = true;
                comboBox_subtype.Visible = true;
                label_spawnall.Visible = true;
                label_subtype.Visible = true;
            }
            else
            {
                RemoveExtraDetails(questEnemyDetails, 0, panelQuestEnemyDet);
                RemoveExtraDetails(CPEnemyDetails, 0, panelCPEnemyDet);
                checkBox_customizeall.Visible = false;
                comboBox_subtype2.Visible = false;
                label_customizeall.Visible = false;
                label_subtype2.Visible = false;
                checkBox_spawnall.Visible = false;
                comboBox_subtype.Visible = false;
                label_spawnall.Visible = false;
                label_subtype.Visible = false;
            }

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
                            RefreshOrAddDetail(new HostageDetail(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 1: // vehicles
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            RefreshOrAddDetail(new VehicleDetail(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 2: // animals
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            RefreshOrAddDetail(new AnimalDetail(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 3: // items
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            RefreshOrAddDetail(new ItemDetail(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 4: // active items
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            RefreshOrAddDetail(new ActiveItemDetail(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 5: // models
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            RefreshOrAddDetail(new ModelDetail(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                }
                detailTuple.Item3.AutoScroll = true;
            }

            if (HostageCoords.Count == 0)
            {
                h_checkBox_intrgt.Visible = false;
                h_label_intrgt.Visible = false;
                label_Body.Visible = false;
                comboBox_Body.Visible = false;
            }
            else
            {
                h_checkBox_intrgt.Visible = true;
                h_label_intrgt.Visible = true;
                label_Body.Visible = true;
                comboBox_Body.Visible = true;
            }
            // set selected visible
            ShiftVisibilities(false);
            ShiftGroups();
            RefreshHostageLanguage();
        }

        private void ShiftVisibilities(bool hideAll)
        {
            detailLists = new List<GroupBox>();
            Tuple<List<Detail>, GroupBox>[] detailTuples =
            {
                new Tuple<List<Detail>, GroupBox>(questEnemyDetails, groupNewEneDet),
                new Tuple<List<Detail>, GroupBox>(CPEnemyDetails, groupExistingEneDet),
                new Tuple<List<Detail>, GroupBox>(hostageDetails, groupHosDet),
                new Tuple<List<Detail>, GroupBox>(vehicleDetails, groupVehDet),
                new Tuple<List<Detail>, GroupBox>(animalDetails, groupAnimalDet),
                new Tuple<List<Detail>, GroupBox>(itemDetails, groupItemDet),
                new Tuple<List<Detail>, GroupBox>(activeItemDetails, groupActiveItemDet),
                new Tuple<List<Detail>, GroupBox>(modelDetails, groupStMdDet),
            };
            foreach (Tuple<List<Detail>, GroupBox> tuple in detailTuples)
            {
                if (tuple.Item1.Count > 0 && !hideAll)
                {
                    tuple.Item2.Visible = true;
                    detailLists.Add(tuple.Item2);
                }
                else tuple.Item2.Visible = false;
            }
        }

        internal void ShiftGroups()
        {
            int dynamicMaxAdjust = 210 / (detailLists.Count + 1);
            int maxPanelWidth = 290 + dynamicMaxAdjust;
            dynamicPanelWidth = Width / 4 - 20;

            if (dynamicPanelWidth >= maxPanelWidth)
                dynamicPanelWidth = maxPanelWidth;

            foreach (GroupBox detailGroupBox in detailLists)
            {
                detailGroupBox.Width = dynamicPanelWidth;
            }
            if (detailLists.Count > 0)
            {
                int xOffset = detailLists[0].Location.X;
                int bufferSpace = 2 + dynamicPanelWidth;

                for (int i = 1; i < detailLists.Count; i++)
                {
                    detailLists[i].Left = xOffset + bufferSpace * i;
                }
            }
        }

        public QuestDetails getQuestDetails()
        {
            List<EnemyDetail> eDetailsCasted = new List<EnemyDetail>();
            List<HostageDetail> hDetailsCasted = new List<HostageDetail>();
            List<VehicleDetail> vDetailsCasted = new List<VehicleDetail>();
            List<AnimalDetail> aDetailsCasted = new List<AnimalDetail>();
            List<ItemDetail> iDetailsCasted = new List<ItemDetail>();
            List<ActiveItemDetail> aiDetailsCasted = new List<ActiveItemDetail>();
            List<ModelDetail> mDetailsCasted = new List<ModelDetail>();

            foreach (EnemyDetail enemyDetail in questEnemyDetails)
                eDetailsCasted.Add(enemyDetail);

            foreach (EnemyDetail enemyDetail in CPEnemyDetails)
                eDetailsCasted.Add(enemyDetail);

            foreach (HostageDetail detail in hostageDetails)
                hDetailsCasted.Add(detail);

            foreach (VehicleDetail detail in vehicleDetails)
                vDetailsCasted.Add(detail);

            foreach (AnimalDetail detail in animalDetails)
                aDetailsCasted.Add(detail);

            foreach (ItemDetail detail in itemDetails)
                iDetailsCasted.Add(detail);

            foreach (ActiveItemDetail detail in activeItemDetails)
                aiDetailsCasted.Add(detail);

            foreach (ModelDetail detail in modelDetails)
                mDetailsCasted.Add(detail);

            questDetails = new QuestDetails(eDetailsCasted, hDetailsCasted, vDetailsCasted, aDetailsCasted, iDetailsCasted, aiDetailsCasted, mDetailsCasted, comboBox_Body.SelectedIndex, h_checkBox_intrgt.Checked, comboBox_subtype.Text);
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

        private void checkbox_spawnAll_Click(object sender, EventArgs e)
        {
            checkBox_spawnall.Checked = true;
            foreach (Control control in panelQuestEnemyDet.Controls.Find("e_checkBox_spawn", true))
            {
                CheckBox checkbox = (CheckBox)control;
                checkbox.Checked = true;
            }
        }

        private void checkbox_customizeAll_Click(object sender, EventArgs e)
        {
            checkBox_customizeall.Checked = true;
            foreach (Control control in panelCPEnemyDet.Controls.Find("e_checkBox_spawn", true))
            {
                CheckBox checkbox = (CheckBox)control;
                checkbox.Checked = true;
            }
        }

        private void comboBox_subtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_subtype2.SelectedIndex = comboBox_subtype.SelectedIndex;
        }
    }

    
}
