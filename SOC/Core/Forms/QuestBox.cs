using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System;
using System.Windows.Forms;

namespace SOC.Forms
{
    public abstract class QuestBox
    {
        QuestObject questObject;

        public QuestBox(QuestObject qObject)
        {
            questObject = qObject;
        }

        public int getIndex()
        {
            return questObject.ID;
        }

        public Position GetPosition()
        {
            return questObject.position;
        }

        public void FocusGroupBox(object sender, EventArgs e)
        {
            getGroupBoxMain().Focus();
        }

        public abstract GroupBox getGroupBoxMain();

        public abstract void SetObject(QuestBox detail);

        public abstract void BuildObject();

        public QuestObject getQuestObject()
        {
            return questObject;
        }
            
    }
}
