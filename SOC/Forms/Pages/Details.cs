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
        List<QuestObject> questEnemyBoxes;
        List<QuestObject> CPEnemyBoxes;
        List<QuestObject> hostageBoxes;
        List<QuestObject> vehicleBoxes;
        List<QuestObject> itemBoxes;
        List<QuestObject> modelBoxes;
        List<QuestObject> activeItemBoxes;
        List<QuestObject> animalBoxes;
        int dynamicPanelWidth = 0;
        public QuestEntities questDetails;
        
        public string lastCP = "";
        public string lastRegion = "";

        public Details()
        {
            InitializeComponent();
            DoubleBuffered = true;
            detailLists = new List<GroupBox>();
            questEnemyBoxes = new List<QuestObject>();
            CPEnemyBoxes = new List<QuestObject>();
            hostageBoxes = new List<QuestObject>();
            vehicleBoxes = new List<QuestObject>();
            itemBoxes = new List<QuestObject>();
            modelBoxes = new List<QuestObject>();
            activeItemBoxes = new List<QuestObject>();
            animalBoxes = new List<QuestObject>();

            foreach (BodyInfoEntry infoEntry in BodyInfo.BodyInfoArray)
            {
                this.comboBox_Body.Items.Add(infoEntry.bodyName);
            }
            comboBox_Body.Text = "AFGH_HOSTAGE";
        }

        public void RefreshOrAddDetail(QuestObject newDetail, List<QuestObject> details, Panel panel)
        {
            int detailIndex = newDetail.getIndex();
            newDetail.BuildObject(panel.Width);

            if (detailIndex < details.Count)
            {
                QuestObject oldDetail = details[detailIndex];
                newDetail.SetObject(oldDetail);
                panel.Controls.Remove(oldDetail.getGroupBoxMain());
                details[detailIndex] = newDetail;
            }
            else
            {
                details.Add(newDetail);
            }
            panel.Controls.Add(details[detailIndex].getGroupBoxMain());
        }

        public void RemoveExtraDetails(List<QuestObject> details, int remainder, Panel panel)
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

        internal void refreshCoordinateBoxes(Setup setupPage)
        {
            Tuple<List<QuestObject>, TextBox>[] detailTuples =
            {
                new Tuple<List<QuestObject>, TextBox>(hostageBoxes, setupPage.textBoxHosCoords),
                new Tuple<List<QuestObject>, TextBox>(vehicleBoxes, setupPage.textBoxVehCoords),
                new Tuple<List<QuestObject>, TextBox>(animalBoxes, setupPage.textBoxAnimalCoords),
                new Tuple<List<QuestObject>, TextBox>(itemBoxes, setupPage.textBoxItemCoords),
                new Tuple<List<QuestObject>, TextBox>(activeItemBoxes, setupPage.textBoxActiveItemCoords),
                new Tuple<List<QuestObject>, TextBox>(modelBoxes, setupPage.textBoxStMdCoords),
            };
            foreach (Tuple<List<QuestObject>, TextBox> tuple in detailTuples)
            {
                string updatedTest = "";
                foreach (QuestObject detail in tuple.Item1)
                {
                    Coordinates detailCoords = detail.getCoords();
                    updatedTest += string.Format("{{pos={{{0},{1},{2}}},rotY={3},}}, ", detailCoords.xCoord, detailCoords.yCoord, detailCoords.zCoord, detailCoords.roty);
                }
                tuple.Item2.Text = updatedTest;
            }
        }

        public void RefreshDetails(CP questCP, List<Coordinates> HostageCoords, List<Coordinates> VehicleCoords, List<Coordinates> ItemCoords, List<Coordinates> ModelCoords, List<Coordinates> ActItemsCoords, List<Coordinates> AnimalCoords)
        {
            ShiftVisibilities(true);
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
                for (int i = 0; i < EnemyInfo.MAXQUESTFOVA; i++)
                {
                    EnemyBox enemyDetail = new EnemyBox(i);
                    RefreshOrAddDetail(enemyDetail, questEnemyBoxes, panelQuestEnemyDet);
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
                RemoveExtraDetails(questEnemyBoxes, EnemyInfo.MAXQUESTFOVA, panelQuestEnemyDet);

                for (int i = 0; i < questCP.CPsoldiers.Length; i++)
                {
                    EnemyBox enemyDetail = new EnemyBox(i);
                    RefreshOrAddDetail(enemyDetail, CPEnemyBoxes, panelCPEnemyDet);
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
                RemoveExtraDetails(CPEnemyBoxes, questCP.CPsoldiers.Length, panelCPEnemyDet);

                panelQuestEnemyDet.AutoScroll = true;
                panelCPEnemyDet.AutoScroll = true;
            }
            else
            {
                RemoveExtraDetails(questEnemyBoxes, 0, panelQuestEnemyDet);
                RemoveExtraDetails(CPEnemyBoxes, 0, panelCPEnemyDet);
            }

            Tuple<List<QuestObject>, List<Coordinates>, Panel>[] detailTuples =
            {
                new Tuple<List<QuestObject>, List<Coordinates>, Panel>(hostageBoxes, HostageCoords, panelHosDet),
                new Tuple<List<QuestObject>, List<Coordinates>, Panel>(vehicleBoxes, VehicleCoords, panelVehDet),
                new Tuple<List<QuestObject>, List<Coordinates>, Panel>(animalBoxes, AnimalCoords, panelAnimalDet),
                new Tuple<List<QuestObject>, List<Coordinates>, Panel>(itemBoxes, ItemCoords, panelItemDet),
                new Tuple<List<QuestObject>, List<Coordinates>, Panel>(activeItemBoxes, ActItemsCoords, panelAcItDet),
                new Tuple<List<QuestObject>, List<Coordinates>, Panel>(modelBoxes, ModelCoords, panelStMdDet),
            };
            Tuple<List<QuestObject>, List<Coordinates>, Panel> detailTuple;

            for (int i = 0; i < detailTuples.Length; i++)
            {
                detailTuple = detailTuples[i];
                detailTuple.Item3.AutoScroll = false;
                switch (i)
                {
                    case 0: // hostages
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            RefreshOrAddDetail(new HostageBox(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 1: // vehicles
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            RefreshOrAddDetail(new VehicleBox(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 2: // animals
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            RefreshOrAddDetail(new AnimalBox(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 3: // items
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            RefreshOrAddDetail(new ItemBox(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 4: // active items
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            RefreshOrAddDetail(new ActiveItemBox(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                    case 5: // models
                        for (int j = 0; j < detailTuple.Item2.Count; j++)
                            RefreshOrAddDetail(new ModelBox(detailTuple.Item2[j], j), detailTuple.Item1, detailTuple.Item3);
                        RemoveExtraDetails(detailTuple.Item1, detailTuple.Item2.Count, detailTuple.Item3);
                        break;
                }
                detailTuple.Item3.AutoScroll = true;
            }

            RefreshHostageLanguage();
            ShiftVisibilities(false);
            ShiftGroups(Height, Width);
        }

        internal void ShiftVisibilities(bool hideAll)
        {
            detailLists = new List<GroupBox>();
            Tuple<List<QuestObject>, GroupBox>[] detailTuples =
            {
                new Tuple<List<QuestObject>, GroupBox>(questEnemyBoxes, groupNewEneDet),
                new Tuple<List<QuestObject>, GroupBox>(CPEnemyBoxes, groupExistingEneDet),
                new Tuple<List<QuestObject>, GroupBox>(hostageBoxes, groupHosDet),
                new Tuple<List<QuestObject>, GroupBox>(vehicleBoxes, groupVehDet),
                new Tuple<List<QuestObject>, GroupBox>(animalBoxes, groupAnimalDet),
                new Tuple<List<QuestObject>, GroupBox>(itemBoxes, groupItemDet),
                new Tuple<List<QuestObject>, GroupBox>(activeItemBoxes, groupActiveItemDet),
                new Tuple<List<QuestObject>, GroupBox>(modelBoxes, groupStMdDet),
            };
            foreach (Tuple<List<QuestObject>, GroupBox> tuple in detailTuples)
            {
                if (tuple.Item1.Count > 0 && !hideAll)
                {
                    tuple.Item2.Visible = true;
                    detailLists.Add(tuple.Item2);
                }
                else tuple.Item2.Visible = false;
            }
        }

        internal void ShiftGroups(int height, int width)
        {
            Height = height; Width = width;
            dynamicPanelWidth = width / 5 + 30;
            int maxPanelWidth = 285;

            if (dynamicPanelWidth >= maxPanelWidth)
                dynamicPanelWidth = maxPanelWidth;

            if (detailLists.Count > 0)
                dynamicPanelWidth += (150 / detailLists.Count);

            foreach (GroupBox detailGroupBox in detailLists)
            {
                detailGroupBox.Width = dynamicPanelWidth;
            }

            int xOffset = 3 + originAnchor.Left;
            int bufferSpace = 2 + dynamicPanelWidth;

            for (int i = 0; i < detailLists.Count; i++)
            {
                detailLists[i].Left = xOffset + bufferSpace * i;
            }
        }

        public QuestEntities GetChanges()
        {

            List<Enemy> qenemies = new List<Enemy>();
            List<Enemy> cpenemies = new List<Enemy>();
            List<Hostage> hostages = new List<Hostage>();
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Animal> animals = new List<Animal>();
            List<Item> items = new List<Item>();
            List<ActiveItem> activeItems = new List<ActiveItem>();
            List<Model> models = new List<Model>();

            foreach (EnemyBox d in questEnemyBoxes)
            {
                string[] powerlist = new string[d.e_listBox_power.Items.Count];
                d.e_listBox_power.Items.CopyTo(powerlist, 0);
                qenemies.Add(new Enemy(d.e_checkBox_spawn.Checked, d.e_checkBox_target.Checked, d.e_checkBox_balaclava.Checked, d.e_checkBox_zombie.Checked, d.e_checkBox_armor.Checked, questEnemyBoxes.IndexOf(d), d.e_groupBox_main.Text, d.e_comboBox_body.Text, d.e_comboBox_cautionroute.Text, d.e_comboBox_sneakroute.Text, d.e_comboBox_skill.Text, d.e_comboBox_staff.Text, powerlist));
            }
            foreach (EnemyBox d in CPEnemyBoxes)
            {
                string[] powerlist = new string[d.e_listBox_power.Items.Count];
                d.e_listBox_power.Items.CopyTo(powerlist, 0);
                cpenemies.Add(new Enemy(d.e_checkBox_spawn.Checked, d.e_checkBox_target.Checked, d.e_checkBox_balaclava.Checked, d.e_checkBox_zombie.Checked, d.e_checkBox_armor.Checked, questEnemyBoxes.IndexOf(d), d.e_groupBox_main.Text, d.e_comboBox_body.Text, d.e_comboBox_cautionroute.Text, d.e_comboBox_sneakroute.Text, d.e_comboBox_skill.Text, d.e_comboBox_staff.Text, powerlist));
            }
            foreach (HostageBox d in hostageBoxes)
                hostages.Add(new Hostage(d.h_checkBox_target.Checked, d.h_checkBox_untied.Checked, d.h_checkBox_injured.Checked, hostageBoxes.IndexOf(d), d.h_groupBox_main.Text, d.h_comboBox_skill.Text, d.h_comboBox_staff.Text, d.h_comboBox_scared.Text, d.h_comboBox_lang.Text, new Coordinates(d.h_textBox_xcoord.Text, d.h_textBox_ycoord.Text, d.h_textBox_zcoord.Text, d.h_textBox_rot.Text)));

            foreach (VehicleBox d in vehicleBoxes)
                vehicles.Add(new Vehicle(d.v_checkBox_target.Checked, vehicleBoxes.IndexOf(d), d.v_groupBox_main.Text, d.v_comboBox_vehicle.SelectedIndex, d.v_comboBox_class.Text, new Coordinates(d.v_textBox_xcoord.Text, d.v_textBox_ycoord.Text, d.v_textBox_zcoord.Text, d.v_textBox_rot.Text)));

            foreach (AnimalBox d in animalBoxes)
                animals.Add(new Animal(d.a_checkBox_isTarget.Checked, animalBoxes.IndexOf(d), d.a_groupBox_main.Text, d.a_comboBox_count.Text, d.a_comboBox_animal.Text, d.a_comboBox_TypeID.Text, new Coordinates(d.a_textBox_xcoord.Text, d.a_textBox_ycoord.Text, d.a_textBox_zcoord.Text, d.a_textBox_rot.Text)));

            foreach (ItemBox d in itemBoxes)
                items.Add(new Item(d.i_checkBox_boxed.Checked, itemBoxes.IndexOf(d), d.i_groupBox_main.Text, d.i_comboBox_count.Text, d.i_comboBox_item.Text, new Coordinates(d.i_textBox_xcoord.Text, d.i_textBox_ycoord.Text, d.i_textBox_zcoord.Text), new RotationQuat(d.i_textBox_xrot.Text, d.i_textBox_yrot.Text, d.i_textBox_zrot.Text, d.i_textBox_wrot.Text)));

            foreach (ActiveItemBox d in activeItemBoxes)
                activeItems.Add(new ActiveItem(activeItemBoxes.IndexOf(d), d.ai_groupBox_main.Text, d.ai_comboBox_activeitem.Text, new Coordinates(d.ai_textBox_xcoord.Text, d.ai_textBox_ycoord.Text, d.ai_textBox_zcoord.Text), new RotationQuat(d.ai_textBox_xrot.Text, d.ai_textBox_yrot.Text, d.ai_textBox_zrot.Text, d.ai_textBox_wrot.Text)));

            foreach (ModelBox d in modelBoxes)
                models.Add(new Model(d.m_label_GeomNotFound.Visible, modelBoxes.IndexOf(d), d.m_groupBox_main.Text, d.m_comboBox_preset.Text, new Coordinates(d.m_textBox_xcoord.Text, d.m_textBox_ycoord.Text, d.m_textBox_zcoord.Text), new RotationQuat(d.m_textBox_xrot.Text, d.m_textBox_yrot.Text, d.m_textBox_zrot.Text, d.m_textBox_wrot.Text)));

            questDetails = new QuestEntities(qenemies, cpenemies, hostages, vehicles, animals, items, activeItems, models, comboBox_Body.SelectedIndex, h_checkBox_intrgt.Checked, comboBox_subtype.Text);
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
                foreach (HostageBox hostageDetail in hostageBoxes)
                {
                    hostageDetail.h_comboBox_lang.Items.Clear();
                    hostageDetail.h_comboBox_lang.Items.Add("english");
                    hostageDetail.h_comboBox_lang.SelectedIndex = 0;
                }
            }
            else
            {
                foreach (HostageBox hostageDetail in hostageBoxes)
                {
                    hostageDetail.h_comboBox_lang.Items.Clear();
                    hostageDetail.h_comboBox_lang.Items.AddRange(new string[] { "english", "russian", "pashto", "kikongo", "afrikaans" });
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

        private void DetailFocus(object sender, EventArgs e)
        {
            ((Panel)sender).Focus();
        }
    }

    
}
