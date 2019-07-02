using SOC.Classes.Fox2;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using SOC.Forms.Pages;
using SOC.Classes.Lua;
using SOC.Classes.Assets;
using SOC.Classes.Common;

namespace SOC.QuestObjects.UAV
{
    class UAVManager : LocationalManager
    {
        static LocationalDataStub stub = new LocationalDataStub("UAV Drone Starting Locations");

        static UAVControl control = new UAVControl();

        static UAVVisualizer visualizer = new UAVVisualizer(stub, control);

        public UAVManager(Detail detail) : base(detail, visualizer) { }

        public override void AddToAssets(FileAssets fileAssets)
        {
            UAVAssets.GetUAVAssets((UAVDetail)base.detail, fileAssets);
        }

        public override void AddToMainLua(MainLua mainLua)
        {
            UAVLua.GetMain((UAVDetail)base.detail, mainLua);
        }

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {
            UAVFox2.AddQuestEntities((UAVDetail)base.detail, dataSet, entityList);
        }
    }
}
