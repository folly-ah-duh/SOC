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

namespace SOC.QuestObjects.Enemy
{
    public partial class EnemyBoxF : UserControl
    {
        public EnemyBoxF()
        {
            InitializeComponent();
        }

        /*
        private void groupBox_main_Disposed(object sender, EventArgs e)
        {
            if (checkBox_armor.Checked)
                QuestComponents.EnemyInfo.armorCount--;
            if (checkBox_armor.Checked)
                QuestComponents.EnemyInfo.zombieCount--;
            if (checkBox_balaclava.Checked)
                QuestComponents.EnemyInfo.balaCount--;
        }

        private void checkBox_spawn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSpawn();
        }

        private void UpdateSpawn()
        {
            if (checkBox_spawn.Checked)
            {
                label_skill.Enabled = true;
                label_sneakroute.Enabled = true;
                label_staff.Enabled = true;
                label_target.Enabled = true;
                listBox_power.Enabled = true;
                checkBox_armor.Enabled = true;
                checkBox_target.Enabled = true;
                comboBox_body.Enabled = true;
                comboBox_cautionroute.Enabled = true;
                comboBox_power.Enabled = true;
                comboBox_skill.Enabled = true;
                comboBox_sneakroute.Enabled = true;
                comboBox_staff.Enabled = true;
                label_armor.Enabled = true;
                label_body.Enabled = true;
                label_cautionroute.Enabled = true;
                label_power.Enabled = true;
                label_balaclava.Enabled = true;
                checkBox_balaclava.Enabled = true;
                label_zombie.Enabled = true;
                checkBox_zombie.Enabled = true;
                button_removepower.Enabled = true;
                button_SwapRoutes.Enabled = true;
                button_SneakToCaution.Enabled = true;
                button_CautionToSneak.Enabled = true;

                if (checkBox_balaclava.Checked) { updateBalaclava(); }
                if (checkBox_zombie.Checked) { updateZombie(); }
                if (checkBox_armor.Checked) { updateArmor(); }
            }
            else
            {
                label_skill.Enabled = false;
                label_sneakroute.Enabled = false;
                label_staff.Enabled = false;
                label_target.Enabled = false;
                listBox_power.Enabled = false;
                checkBox_armor.Enabled = false;
                checkBox_target.Enabled = false;
                comboBox_body.Enabled = false;
                comboBox_cautionroute.Enabled = false;
                comboBox_power.Enabled = false;
                comboBox_skill.Enabled = false;
                comboBox_sneakroute.Enabled = false;
                comboBox_staff.Enabled = false;
                label_armor.Enabled = false;
                label_body.Enabled = false;
                label_cautionroute.Enabled = false;
                label_power.Enabled = false;
                label_balaclava.Enabled = false;
                checkBox_balaclava.Enabled = false;
                label_zombie.Enabled = false;
                checkBox_zombie.Enabled = false;
                button_removepower.Enabled = false;
                button_SwapRoutes.Enabled = false;
                button_SneakToCaution.Enabled = false;
                button_CautionToSneak.Enabled = false;

                if (checkBox_balaclava.Checked) { QuestComponents.EnemyInfo.balaCount--; }
                if (checkBox_zombie.Checked) { QuestComponents.EnemyInfo.zombieCount--; }
                if (checkBox_armor.Checked) { QuestComponents.EnemyInfo.armorCount--; }
            }

        }
        private void SwapRoute_Button_Clicked(object sender, EventArgs e)
        {
            string cRoute = comboBox_cautionroute.Text;
            comboBox_cautionroute.Text = comboBox_sneakroute.Text;
            comboBox_sneakroute.Text = cRoute;
            groupBox_main.Focus();
        }

        private void SneakToCaution_Button_Clicked(object sender, EventArgs e)
        {
            comboBox_cautionroute.Text = comboBox_sneakroute.Text;
            groupBox_main.Focus();
        }

        private void CautionToSneak_Button_Clicked(object sender, EventArgs e)
        {
            comboBox_sneakroute.Text = comboBox_cautionroute.Text;
            groupBox_main.Focus();
        }

        private void armor_Checkbox_Clicked(object sender, EventArgs e)
        {
            updateArmor();
            groupBox_main.Focus();
        }
        private void balaclava_checkbox_clicked(object sender, EventArgs e)
        {
            updateBalaclava();
            groupBox_main.Focus();

        }
        private void zombie_checkbox_clicked(object sender, EventArgs e)
        {
            updateZombie();
            groupBox_main.Focus();
        }

        private void updateArmor()
        {
            if (checkBox_armor.Checked)
            {
                if (QuestComponents.EnemyInfo.armorCount >= QuestComponents.EnemyInfo.MAXQUESTFOVA)
                {
                    MessageBox.Show("Heavy Armor can only be applied to 8 soldiers maximum.", "Game Limitation Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkBox_armor.Checked = false;
                    if (listBox_power.Items.Contains("QUEST_ARMOR"))
                    {
                        listBox_power.Items.Remove("QUEST_ARMOR");
                        listBox_power.SelectedIndex = listBox_power.Items.Count - 1;
                    }
                }
                else
                {
                    QuestComponents.EnemyInfo.armorCount++;
                    if (!listBox_power.Items.Contains("QUEST_ARMOR"))
                    {
                        listBox_power.Items.Add("QUEST_ARMOR");
                        listBox_power.SelectedIndex = listBox_power.Items.Count - 1;
                    }
                    comboBox_body.Enabled = false;
                    checkBox_balaclava.Enabled = false;
                    label_body.Enabled = false;
                    label_balaclava.Enabled = false;
                }
            }
            else
            {
                QuestComponents.EnemyInfo.armorCount--;
                comboBox_body.Enabled = true;
                checkBox_balaclava.Enabled = true;
                label_body.Enabled = true;
                label_balaclava.Enabled = true;
                listBox_power.Items.Remove("QUEST_ARMOR");
                listBox_power.SelectedIndex = listBox_power.Items.Count - 1;
            }

            groupBox_main.Focus();
        }

        private void updateZombie()
        {
            if (checkBox_zombie.Checked)
                QuestComponents.EnemyInfo.zombieCount++;
            else
                QuestComponents.EnemyInfo.zombieCount--;
            groupBox_main.Focus();
        }

        private void updateBalaclava()
        {
            if (checkBox_balaclava.Checked)
            {
                if (QuestComponents.EnemyInfo.balaCount >= QuestComponents.EnemyInfo.MAXQUESTFOVA)
                {
                    MessageBox.Show("Balaclavas can only be applied to 8 soldiers maximum.", "Game Limitation Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkBox_balaclava.Checked = false;
                }
                else
                {
                    QuestComponents.EnemyInfo.balaCount++;
                    checkBox_armor.Enabled = false;
                    label_armor.Enabled = false;
                }
            }
            else
            {
                QuestComponents.EnemyInfo.balaCount--;
                checkBox_armor.Enabled = true;
                label_armor.Enabled = true;
            }
        }

        private void listBox_power_selectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_power.SelectedIndex > -1)
                button_removepower.Enabled = true;
            else
                button_removepower.Enabled = false;
            groupBox_main.Focus();
        }

        public override GroupBox getGroupBoxMain()
        {
            return groupBox_main;
        }

        public override void SetObject(QuestBox detail)
        {
            EnemyBox enemyDetail = (EnemyBox)detail;

            checkBox_armor.Checked = enemyDetail.checkBox_armor.Checked;
            checkBox_spawn.Checked = enemyDetail.checkBox_spawn.Checked;
            checkBox_target.Checked = enemyDetail.checkBox_target.Checked;
            checkBox_balaclava.Checked = enemyDetail.checkBox_balaclava.Checked;
            checkBox_zombie.Checked = enemyDetail.checkBox_zombie.Checked;

            listBox_power.Text = enemyDetail.listBox_power.Text;

            comboBox_cautionroute.Text = enemyDetail.comboBox_cautionroute.Text;
            comboBox_sneakroute.Text = enemyDetail.comboBox_sneakroute.Text;

            comboBox_body.Text = enemyDetail.comboBox_body.Text;
            comboBox_skill.Text = enemyDetail.comboBox_skill.Text;
            comboBox_staff.Text = enemyDetail.comboBox_staff.Text;
        }

        private void powerChanged(object sender, EventArgs e)
        {
            if (!listBox_power.Items.Contains(comboBox_power.Text))
            {
                listBox_power.Items.Add(comboBox_power.Text);
                listBox_power.SelectedIndex = listBox_power.Items.Count - 1;
                groupBox_main.Focus();
            }
        }
        private void button_removepower_Click(object sender, EventArgs e)
        {

            if (listBox_power.Text.Equals("QUEST_ARMOR"))
            {
                checkBox_armor.Checked = false;
                updateArmor();
            }
            else if (listBox_power.SelectedIndex != -1)
            {
                listBox_power.Items.RemoveAt(listBox_power.SelectedIndex);
                listBox_power.SelectedIndex = listBox_power.Items.Count - 1;
                groupBox_main.Focus();
            }
        }
        */
    }
}
