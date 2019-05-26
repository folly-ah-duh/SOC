using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SOC.UI
{
    public partial class FormMain : Form
    {
        ManagerMaster managerMaster = new ManagerMaster(new ManagerArray());

        private Setup setupPage;
        private Details detailPage;
        private int pageNum = 0;

        public FormMain()
        {
            setupPage = new Setup(managerMaster);
            detailPage = new Details(managerMaster);
            InitializeComponent();

            GoToPanel();
            buttonBack.Visible = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            pageNum++;
            this.GoToPanel();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            pageNum--;
            this.GoToPanel();
        }
        private bool isFilled()
        {
            //return true; // FOR DEBUG
            if (string.IsNullOrEmpty(setupPage.textBoxFPKName.Text) || string.IsNullOrEmpty(setupPage.textBoxQuestNum.Text) || string.IsNullOrEmpty(setupPage.textBoxQuestTitle.Text) || string.IsNullOrEmpty(setupPage.textBoxQuestDesc.Text))
                return false;
            if (setupPage.comboBoxCategory.SelectedIndex == -1 || setupPage.comboBoxReward.SelectedIndex == -1 || setupPage.comboBoxProgressNotifs.SelectedIndex == -1 || setupPage.comboBoxRegion.SelectedIndex == -1)
                return false;
            if (setupPage.comboBoxCP.Enabled)
                if (setupPage.comboBoxCP.SelectedIndex == -1 || setupPage.comboBoxLoadArea.SelectedIndex == -1 || setupPage.comboBoxRadius.SelectedIndex == -1 || string.IsNullOrEmpty(setupPage.textBoxXCoord.Text) || string.IsNullOrEmpty(setupPage.textBoxYCoord.Text) || string.IsNullOrEmpty(setupPage.textBoxZCoord.Text))
                    return false;

            return true;
        }
        private void GoToPanel()
        {
            switch (pageNum)
            {
                case 0:
                    ShowSetup();
                    break;

                case 1:
                    if (isFilled())
                    {
                        ShowWait();
                        Application.DoEvents();

                        ShowDetails();
                    }
                    else
                    {
                        MessageBox.Show("Please fill in the remaining Setup and Flavor Text fields.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pageNum--;
                        return;
                    }
                    break;

                case 2:
                    BuildQuest();
                    MessageBox.Show("Build Complete", "Sideop Companion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pageNum--;
                    break;
            }
        }

        private void ShowSetup()
        {
            buttonBack.Visible = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(setupPage);
            managerMaster.RefreshAllStubTexts();
            buttonNext.Text = "Next >>";
        }

        private void ShowWait()
        {
            panelMain.Controls.Clear();
            Waiting waitingPage = new Waiting();
            panelMain.Controls.Add(waitingPage);
            buttonNext.Enabled = false;
            Application.DoEvents();
        }

        private void ShowDetails()
        {
            panelMain.Controls.Clear();
            buttonBack.Visible = true;
            buttonNext.Text = "Build";
            panelMain.Controls.Add(detailPage);
            buttonNext.Enabled = true;
        }

        private void BuildQuest()
        {
            /*
            definitionDetails = setupPage.getDefinitionDetails();
            questDetails = detailPage.GetEntityLists();

            AssetsBuilder.ClearQuestFolders(definitionDetails);

            LangBuilder.WriteQuestLangs(definitionDetails);

            LuaBuilder.WriteDefinitionLua(definitionDetails, questDetails);
            LuaBuilder.WriteMainQuestLua(definitionDetails, questDetails);

            Fox2Builder.WriteItemFox2(definitionDetails, questDetails);
            Fox2Builder.WriteQuestFox2(definitionDetails, questDetails);

            AssetsBuilder.BuildAssets(definitionDetails, questDetails);
            */
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            //setupPage.ShiftGroups(Height - 100, Width - 42);
            //detailPage.ShiftGroups(Height - 100, Width - 42);
            //Console.WriteLine(setupPage.Width + ", " + setupPage.Height);
            //Console.WriteLine(this.panelMain.Width);
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            setupPage.refreshNotifsList();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFile = new OpenFileDialog();
            loadFile.Filter = "Xml Files|*.xml|All Files|*.*";

            DialogResult result = loadFile.ShowDialog();
            if (result != DialogResult.OK) return;

            if (pageNum != 0)
            {
                pageNum = 0; GoToPanel();
            }

            Quest quest = new Quest();

            if (quest.Load(loadFile.FileName))
            {
                managerMaster.SetManagerArray(new ManagerArray(quest.questObjectDetails));
                setupPage.SetCoreDetails(quest.coreDetails);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isFilled())
            {
                DialogResult result = MessageBox.Show("Do you want to save this Sideop to an Xml file?", "SOC", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    Save();
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void Save()
        {
            CoreDetails core = setupPage.GetCoreDetails();
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Xml File|*.xml";
            saveFile.FileName = core.FpkName;
            DialogResult saveResult = saveFile.ShowDialog();
            if (saveResult != DialogResult.OK) return;
            if (pageNum != 0)
            {
                pageNum = 0; GoToPanel();
            }
            Quest quest = new Quest(core, managerMaster.GetQuestObjectDetails());
            quest.Save(saveFile.FileName);
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(AppDomain.CurrentDomain.BaseDirectory);
            }
            catch { }
        }
    }
}
