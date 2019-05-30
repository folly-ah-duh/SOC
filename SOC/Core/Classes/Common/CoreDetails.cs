using SOC.UI;
using System.Xml.Serialization;

namespace SOC.Classes.Common
{
    [XmlType("DefinitionDetails")]
    public class CoreDetails
    {

        public CoreDetails() { }

        public CoreDetails(string fpk, string quest, int locID, string loada, Coordinates c, string rad, string cat, string rew, int prog, string cpnme, string qtitle, string qdesc, string route)
        {
            FpkName = fpk;
            QuestNum = quest;
            QuestTitle = qtitle;
            QuestDesc = qdesc;

            locationID = locID;
            loadArea = loada;
            coords = c;
            radius = rad;
            CPName = cpnme;

            category = cat;
            progNotif = prog;
            reward = rew;

            routeName = route;
        }

        public CoreDetails(Setup setupPage)
        {
            QuestTitle = setupPage.textBoxQuestTitle.Text;
            QuestDesc = setupPage.textBoxQuestDesc.Text;
            FpkName = setupPage.textBoxFPKName.Text;
            QuestNum = setupPage.textBoxQuestNum.Text;

            locationID = setupPage.locationID;
            loadArea = setupPage.comboBoxLoadArea.Text;
            coords = new Coordinates(setupPage.textBoxXCoord.Text, setupPage.textBoxYCoord.Text, setupPage.textBoxZCoord.Text);
            radius = setupPage.comboBoxRadius.Text;
            CPName = setupPage.comboBoxCP.Text;

            category = setupPage.comboBoxCategory.Text;
            progNotif = setupPage.comboBoxProgressNotifs.SelectedIndex;
            reward = setupPage.comboBoxReward.Text;

            routeName = setupPage.comboBoxRoute.Text;
        }

        [XmlElement]
        public string QuestTitle { get; set; } = "";

        [XmlElement]
        public string QuestDesc { get; set; } = "";

        [XmlAttribute]
        public string FpkName { get; set; } = "";

        [XmlAttribute]
        public string QuestNum { get; set; } = "";

        [XmlElement]
        public int locationID { get; set; } = -1;

        [XmlElement]
        public string loadArea { get; set; } = "";

        [XmlElement]
        public Coordinates coords { get; set; } = new Coordinates();

        [XmlElement]
        public string radius { get; set; } = "";

        [XmlElement]
        public string category { get; set; } = "";

        [XmlElement]
        public string CPName { get; set; } = "";

        [XmlElement]
        public string reward { get; set; } = "";

        [XmlElement]
        public int progNotif { get; set; } = -1;

        [XmlElement]
        public string routeName { get; set; } = "";

    }
}
