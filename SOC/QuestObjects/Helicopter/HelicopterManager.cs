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

        public HelicopterManager(HelicopterDetail detail) : base(detail, helicopterVisualizer)
        {
        }

        public override void AddToAssets(FileAssets fileAssets)
        {
            throw new NotImplementedException();
        }

        public override void AddToDefinitionLua(DefinitionLua definitionLua)
        {
            throw new NotImplementedException();
        }

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {
            throw new NotImplementedException();
        }

        public override void AddToMainLua(MainLua mainLua)
        {
            throw new NotImplementedException();
        }
    }
}
