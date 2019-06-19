using SOC.Classes.Fox2;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using SOC.Forms.Pages;
using SOC.Classes.Lua;
using SOC.Classes.Assets;
using SOC.Classes.Common;

namespace SOC.QuestObjects.Model
{
    class ModelManager : LocationalManager
    {
        static LocationalDataStub modelStub = new LocationalDataStub("Static Model Locations");

        static ModelControl modelControl = new ModelControl();

        static ModelVisualizer modelVisualizer = new ModelVisualizer(modelStub, modelControl);

        public ModelManager(Detail detail) : base(detail, modelVisualizer) { }

        public override void AddToAssets(FileAssets fileAssets)
        {
            ModelAssets.AddAssets((ModelDetail)base.detail, fileAssets);
        }

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {
            ModelFox2.AddQuestEntities((ModelDetail)base.detail, dataSet, entityList);
        }
    }
}
