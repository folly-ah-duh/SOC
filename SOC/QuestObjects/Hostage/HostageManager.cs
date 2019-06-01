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

        static HostageControl hostagePanel = new HostageControl();

        static HostageVisualizer hostageVisualizer = new HostageVisualizer(hostageStub, hostagePanel);

        public HostageManager(HostageDetail hostageDetail) : base(hostageDetail, hostageVisualizer) { }

        public override void AddFox2Entities(DataSet dataSet, ref List<Fox2EntityClass> entityList)
        {
            HostageFox2.AddQuestEntities((HostageDetail)base.questDetail, dataSet, ref entityList);
        }

    }
}
