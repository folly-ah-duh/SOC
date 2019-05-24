using SOC.Forms.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.QuestObjects.Common
{
    abstract class LocationalQuestObjectManager : QuestObjectManager
    {
        private LocationalDataStub locationStub;

        public LocationalQuestObjectManager(LocationalDataStub stub)
        {
            locationStub = stub;
        }

        public LocationalDataStub GetStub()
        {
            return locationStub;
        }

    }
}
