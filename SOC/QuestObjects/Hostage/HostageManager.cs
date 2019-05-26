using SOC.Classes.Fox2;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using SOC.Forms.Pages;
using SOC.Core.Classes.InfiniteHeaven;

namespace SOC.QuestObjects.Hostage
{
    class HostageManager : LocationalQuestObjectManager
    {
        static LocationalDataStub hostageStub = new LocationalDataStub("Prisoner Locations");

        private HostageDetails hostageDetails;

        public HostageManager(HostageDetails hdetails) : base(hostageStub, hdetails)
        {
            hostageDetails = hdetails;
        }

        public override void AddFox2Entities(ref List<Fox2EntityClass> entityList)
        {
            throw new NotImplementedException();
        }

        public override void RefreshStubText()
        {
            List<Position> prsPosList = new List<Position>();
            
            foreach(Hostage hostage in hostageDetails.Hostages)
            {
                prsPosList.Add(new Position(hostage.coordinates, hostage.rotation));
            }

            hostageStub.SetStubText(new IHLogPositions(prsPosList));
        }
    }
}
