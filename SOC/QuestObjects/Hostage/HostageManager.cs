using SOC.Classes.Fox2;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using SOC.Forms.Pages;
using SOC.Classes.Lua;
using SOC.Classes.Assets;
using SOC.Classes.Common;

namespace SOC.QuestObjects.Hostage
{
    class HostageManager : DetailManager
    {
        static LocationalDataStub hostageStub = new LocationalDataStub("Prisoner Locations");

        static HostageControl hostageControl = new HostageControl();

        static HostageVisualizer hostageVisualizer = new HostageVisualizer(hostageStub, hostageControl);

        public HostageManager(HostageDetail hostageDetail) : base(hostageDetail, hostageVisualizer) { }

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {
            HostageFox2.AddQuestEntities((HostageDetail)base.questDetail, dataSet, entityList);
        }

        public override void AddToMainLua(MainLua mainLua)
        {
            HostageLua.GetMain((HostageDetail)base.questDetail, mainLua);
        }

        public override void AddToDefinitionLua(DefinitionLua definitionLua)
        {
            HostageLua.GetDefinition((HostageDetail)base.questDetail, definitionLua);
        }
    }
}
