using SOC.Classes.Fox2;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using SOC.Forms.Pages;
using SOC.Classes.Lua;
using SOC.Classes.Assets;
using SOC.Classes.Common;

namespace SOC.QuestObjects.Helicopter
{
    class HelicopterManager : DetailManager
    {
        static LocationalDataStub helicopterStub = new LocationalDataStub("Helicopter Spawn Locations");

        static HelicopterControl helicopterControl = new HelicopterControl();

        static HelicopterVisualizer helicopterVisualizer = new HelicopterVisualizer(helicopterStub, helicopterControl);

        public HelicopterManager(HelicopterDetail detail) : base(detail, helicopterVisualizer) { }

        public override void AddToDefinitionLua(DefinitionLua definitionLua)
        {
            HelicopterLua.GetDefinition((HelicopterDetail)base.questDetail, definitionLua);
        }

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {
            HelicopterFox2.AddQuestEntities((HelicopterDetail)base.questDetail, dataSet, entityList);
        }

        public override void AddToMainLua(MainLua mainLua)
        {
            HelicopterLua.GetMain((HelicopterDetail)base.questDetail, mainLua);
        }
    }
}
