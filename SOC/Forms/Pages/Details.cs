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
        List<QuestBox> questEnemyBoxes;
        List<QuestBox> CPEnemyBoxes;
        List<QuestBox> hostageBoxes;
        List<QuestBox> vehicleBoxes;
        List<QuestBox> itemBoxes;
        List<QuestBox> modelBoxes;
        List<QuestBox> activeItemBoxes;
        List<QuestBox> animalBoxes;
        int dynamicPanelWidth = 0;
        public QuestEntities questDetails;

        public Details()
        {
            InitializeComponent();
            DoubleBuffered = true;
            detailLists = new List<GroupBox>();
            questEnemyBoxes = new List<QuestBox>();
            CPEnemyBoxes = new List<QuestBox>();
            hostageBoxes = new List<QuestBox>();
            vehicleBoxes = new List<QuestBox>();
            itemBoxes = new List<QuestBox>();
            modelBoxes = new List<QuestBox>();
            activeItemBoxes = new List<QuestBox>();
            animalBoxes = new List<QuestBox>();

            foreach (BodyInfoEntry infoEntry in BodyInfo.BodyInfoArray)
            {
                this.comboBox_Body.Items.Add(infoEntry.bodyName);
            }
            comboBox_Body.Text = "AFGH_HOSTAGE";
        }

        internal void clearPanel(Panel panel, List<QuestBox> objectlist)
        {
            foreach (QuestBox qbox in objectlist)
            {
                panel.Controls.Remove(qbox.getGroupBoxMain());
            }
        }

        public void ResetAllPanels()
        {
            clearPanel(panelQuestEnemyDet, questEnemyBoxes);
            clearPanel(panelCPEnemyDet, CPEnemyBoxes);
            clearPanel(panelHosDet, hostageBoxes);
            clearPanel(panelVehDet, vehicleBoxes);
            clearPanel(panelAnimalDet, animalBoxes);
            clearPanel(panelItemDet, itemBoxes);
            clearPanel(panelAcItDet, activeItemBoxes);
            clearPanel(panelStMdDet, modelBoxes);
            questEnemyBoxes = new List<QuestBox>();
            CPEnemyBoxes = new List<QuestBox>();
            hostageBoxes = new List<QuestBox>();
            vehicleBoxes = new List<QuestBox>();
            itemBoxes = new List<QuestBox>();
            modelBoxes = new List<QuestBox>();
            activeItemBoxes = new List<QuestBox>();
            animalBoxes = new List<QuestBox>();
            EnemyInfo.armorCount = 0;
            EnemyInfo.balaCount = 0;
            EnemyInfo.zombieCount = 0;
        }

        public void LoadEntityLists(CP enemyCP, QuestEntities questDetails)
        {
            ShiftVisibilities(true);
            string currentRegion = enemyCP.CPname.Substring(0,4);

            string[] subtypes = new string[0];
            comboBox_subtype.Items.Clear();
            comboBox_subtype2.Items.Clear();
            if (currentRegion.Equals("afgh"))
                subtypes = BodyInfo.afghSubTypes;
            else
                subtypes = BodyInfo.mafrSubTypes;

            comboBox_subtype.Items.AddRange(subtypes);
            comboBox_subtype2.Items.AddRange(subtypes);

            if (comboBox_subtype.Items.Contains(questDetails.soldierSubType))
                comboBox_subtype.Text = questDetails.soldierSubType;
            else
                comboBox_subtype.SelectedIndex = 0;

            h_checkBox_intrgt.Checked = questDetails.canInter;

            comboBox_Body.Items.Clear();
            if (currentRegion.Equals("mtbs"))
                foreach (BodyInfoEntry infoEntry in BodyInfo.BodyInfoArray)
                {
                    if (infoEntry.hasface)
                        this.comboBox_Body.Items.Add(infoEntry.bodyName);
                }
            else
                foreach (BodyInfoEntry infoEntry in BodyInfo.BodyInfoArray)
                {
                    this.comboBox_Body.Items.Add(infoEntry.bodyName);
                }

            if (comboBox_Body.Items.Count <= questDetails.hostageBodyIndex)
                comboBox_Body.SelectedIndex = 0;
            else
                comboBox_Body.SelectedIndex = questDetails.hostageBodyIndex;

            //
            // Quest-Specific Soldiers
            //
            Panel currentPanel = panelQuestEnemyDet;
            currentPanel.AutoScroll = false;
            foreach (Enemy questEnemy in questDetails.questEnemies)
            {
                EnemyBox questEnemyBox = new EnemyBox(questEnemy, enemyCP);
                questEnemyBox.BuildObject(currentPanel.Width);
                currentPanel.Controls.Add(questEnemyBox.getGroupBoxMain());
                questEnemyBoxes.Add(questEnemyBox);
            }
            currentPanel.AutoScroll = true;
            //
            // CP-Specific soldiers
            //
            currentPanel = panelCPEnemyDet;
            currentPanel.AutoScroll = false;
            foreach (Enemy cpEnemy in questDetails.cpEnemies)
            {
                EnemyBox cpEnemyBox = new EnemyBox(cpEnemy, enemyCP);
                cpEnemyBox.BuildObject(currentPanel.Width);
                cpEnemyBox.e_label_spawn.Text = "Customize:"; cpEnemyBox.e_label_spawn.Left = 26;
                currentPanel.Controls.Add(cpEnemyBox.getGroupBoxMain());
                CPEnemyBoxes.Add(cpEnemyBox);
            }
            currentPanel.AutoScroll = true;
            //
            // Hostages
            //
            currentPanel = panelHosDet;
            currentPanel.AutoScroll = false;
            foreach (Hostage hostage in questDetails.hostages)
            {
                HostageBox hostageBox = new HostageBox(hostage, questDetails.hostageBodyIndex);
                hostageBox.BuildObject(currentPanel.Width);
                currentPanel.Controls.Add(hostageBox.getGroupBoxMain());
                hostageBoxes.Add(hostageBox);
            }
            currentPanel.AutoScroll = true;
            //
            // Heavy Vehicles
            //
            currentPanel = panelVehDet;
            currentPanel.AutoScroll = false;
            foreach (Vehicle vehicle in questDetails.vehicles)
            {
                VehicleBox vehiclebox = new VehicleBox(vehicle);
                vehiclebox.BuildObject(currentPanel.Width);
                currentPanel.Controls.Add(vehiclebox.getGroupBoxMain());
                vehicleBoxes.Add(vehiclebox);
            }
            currentPanel.AutoScroll = true;
            //
            // Animal Clusters
            //
            currentPanel = panelAnimalDet;
            currentPanel.AutoScroll = false;
            foreach (Animal animal in questDetails.animals)
            {
                AnimalBox anibox = new AnimalBox(animal);
                anibox.BuildObject(currentPanel.Width);
                currentPanel.Controls.Add(anibox.getGroupBoxMain());
                animalBoxes.Add(anibox);
            }
            currentPanel.AutoScroll = true;
            //
            // Dormant Items
            //
            currentPanel = panelItemDet;
            currentPanel.AutoScroll = false;
            foreach (Item item in questDetails.items)
            {
                ItemBox itemBox = new ItemBox(item);
                itemBox.BuildObject(currentPanel.Width);
                currentPanel.Controls.Add(itemBox.getGroupBoxMain());
                itemBoxes.Add(itemBox);
            }
            currentPanel.AutoScroll = true;
            //
            // Active Items
            //
            currentPanel = panelAcItDet;
            currentPanel.AutoScroll = false;
            foreach (ActiveItem acitem in questDetails.activeItems)
            {
                ActiveItemBox activeItemBox = new ActiveItemBox(acitem);
                activeItemBox.BuildObject(currentPanel.Width);
                currentPanel.Controls.Add(activeItemBox.getGroupBoxMain());
                activeItemBoxes.Add(activeItemBox);
            }
            currentPanel.AutoScroll = true;
            //
            // Models
            //
            currentPanel = panelStMdDet;
            currentPanel.AutoScroll = false;
            foreach (Model model in questDetails.models)
            {
                ModelBox modelBox = new ModelBox(model);
                modelBox.BuildObject(currentPanel.Width);
                currentPanel.Controls.Add(modelBox.getGroupBoxMain());
                modelBoxes.Add(modelBox);
            }
            currentPanel.AutoScroll = true;


            panelDetails.AutoScroll = false;
            ShiftVisibilities(false);
            ShiftGroups(Height, Width);
            panelDetails.AutoScroll = true;
        }

        internal void ShiftVisibilities(bool hideAll)
        {
            detailLists = new List<GroupBox>();
            Tuple<List<QuestBox>, GroupBox>[] detailTuples =
            {
                new Tuple<List<QuestBox>, GroupBox>(questEnemyBoxes, groupNewEneDet),
                new Tuple<List<QuestBox>, GroupBox>(CPEnemyBoxes, groupExistingEneDet),
                new Tuple<List<QuestBox>, GroupBox>(hostageBoxes, groupHosDet),
                new Tuple<List<QuestBox>, GroupBox>(vehicleBoxes, groupVehDet),
                new Tuple<List<QuestBox>, GroupBox>(animalBoxes, groupAnimalDet),
                new Tuple<List<QuestBox>, GroupBox>(itemBoxes, groupItemDet),
                new Tuple<List<QuestBox>, GroupBox>(activeItemBoxes, groupActiveItemDet),
                new Tuple<List<QuestBox>, GroupBox>(modelBoxes, groupStMdDet),
            };
            foreach (Tuple<List<QuestBox>, GroupBox> tuple in detailTuples)
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
            int bufferSpace = 4 + dynamicPanelWidth;
            
            for (int i = 0; i < detailLists.Count; i++)
            {
                detailLists[i].Left = xOffset + bufferSpace * i;
            }
        }

        public QuestEntities GetEntityLists()
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
                cpenemies.Add(new Enemy(d.e_checkBox_spawn.Checked, d.e_checkBox_target.Checked, d.e_checkBox_balaclava.Checked, d.e_checkBox_zombie.Checked, d.e_checkBox_armor.Checked, CPEnemyBoxes.IndexOf(d), d.e_groupBox_main.Text, d.e_comboBox_body.Text, d.e_comboBox_cautionroute.Text, d.e_comboBox_sneakroute.Text, d.e_comboBox_skill.Text, d.e_comboBox_staff.Text, powerlist));
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
                    int languageindex = hostageDetail.h_comboBox_lang.SelectedIndex;
                    hostageDetail.h_comboBox_lang.Items.Clear();
                    hostageDetail.h_comboBox_lang.Items.AddRange(new string[] { "english", "russian", "pashto", "kikongo", "afrikaans" });
                    hostageDetail.h_comboBox_lang.SelectedIndex = languageindex;
                }
            }
            comboBox_Body.Focus(); panelHosDet.Focus();

        }

        private void checkbox_spawnAll_Click(object sender, EventArgs e)
        {
            checkBox_spawnall.Checked = true;
            foreach (Control control in panelQuestEnemyDet.Controls.Find("e_checkBox_spawn", true))
            {
                CheckBox checkbox = (CheckBox)control;
                checkbox.Checked = true;
            }
            comboBox_subtype.Focus(); panelQuestEnemyDet.Focus();
        }

        private void checkbox_customizeAll_Click(object sender, EventArgs e)
        {
            checkBox_customizeall.Checked = true;
            foreach (Control control in panelCPEnemyDet.Controls.Find("e_checkBox_spawn", true))
            {
                CheckBox checkbox = (CheckBox)control;
                checkbox.Checked = true;
            }
            comboBox_subtype2.Enabled = true;
            comboBox_subtype2.Focus();
            comboBox_subtype2.Enabled = false;
            panelCPEnemyDet.Focus();
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
