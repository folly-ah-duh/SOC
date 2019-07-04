using SOC.Classes.Fox2;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using SOC.Forms.Pages;
using SOC.Classes.Lua;
using SOC.Classes.Assets;
using SOC.Classes.Common;

namespace SOC.QuestObjects.Camera
{
    class CameraManager : LocationalManager
    {
        static LocationalDataStub stub = new LocationalDataStub("Camera Locations");

        static CameraControl control = new CameraControl();

        static CameraVisualizer visualizer = new CameraVisualizer(stub, control);

        public CameraManager(Detail detail) : base(detail, visualizer) { }

        public override void AddToAssets(FileAssets fileAssets)
        {
            CameraAssets.GetCameraAssets((CameraDetail)base.detail, fileAssets);
        }

        public override void AddToMainLua(MainLua mainLua)
        {
            CameraLua.GetMain((CameraDetail)base.detail, mainLua);
        }

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {
            CameraFox2.AddQuestEntities((CameraDetail)base.detail, dataSet, entityList);
        }
    }
}
