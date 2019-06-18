using SOC.Core.Classes.InfiniteHeaven;
using SOC.Forms;
using SOC.Forms.Pages;
using SOC.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using SOC.Classes.Common;

namespace SOC.QuestObjects.Common
{
    public abstract class Detail
    {
        public abstract List<QuestObject> GetQuestObjects();

        public abstract void SetQuestObjects(List<QuestObject> qObjects);

        public abstract Metadata GetMetadata();

        public abstract DetailManager GetNewManager();
    }

    public abstract class QuestObject
    {
        public abstract Position GetPosition();

        public abstract void SetPosition(Position pos);

        public abstract int GetID();

        public abstract string GetObjectName();
    }

    public abstract class Metadata { }

}
