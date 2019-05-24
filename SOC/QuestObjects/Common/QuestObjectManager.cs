using SOC.Classes.Fox2;
using SOC.Forms.Pages;
using System.Collections.Generic;

namespace SOC.QuestObjects.Common
{
    // a Manager is in charge of interactions between the base program and the manager's QuestObject module.
    public abstract class QuestObjectManager
    {
        public abstract void AddFox2Entities(ref List<Fox2EntityClass> entityList);
    }
}
