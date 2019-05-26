using SOC.Forms.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.QuestObjects.Common
{
    public abstract class LocationalQuestObjectManager : QuestObjectManager
    {
        private LocationalDataStub locationStub;

        public LocationalQuestObjectManager(LocationalDataStub stub, QuestObjectDetails details) : base(details)
        {
            locationStub = stub;
        }

        public LocationalDataStub GetStub()
        {
            return locationStub;
        }

        public abstract void RefreshStubText();

    }
}
