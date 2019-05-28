using SOC.Classes.Fox2;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using SOC.Forms.Pages;
using SOC.Core.Classes.InfiniteHeaven;

namespace SOC.QuestObjects.Hostage
{
    class HostageManager : DetailManager
    {
        static LocationalDataStub hostageStub = new LocationalDataStub("Prisoner Locations");

        static HostagePanel hostagePanel = new HostagePanel();

        static HostageVisualizer hostageVisualizer = new HostageVisualizer(hostageStub, hostagePanel);

        private HostageDetails hostageDetails;

        public HostageManager(HostageDetails hdetails) : base(hdetails, hostageVisualizer)
        {
            hostageDetails = hdetails;
        }

        public override void AddFox2Entities(ref List<Fox2EntityClass> entityList)
        {
            throw new NotImplementedException();
        }
        
    }
}
