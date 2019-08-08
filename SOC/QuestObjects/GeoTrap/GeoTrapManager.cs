using SOC.Classes.Fox2;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using SOC.Forms.Pages;
using SOC.Classes.Lua;
using SOC.Classes.Assets;
using SOC.Classes.Common;

namespace SOC.QuestObjects.GeoTrap
{
    class GeoTrapManager : LocationalManager
    {
        public GeoTrapManager(Detail detail, LocationalVisualizer visual) : base(detail, visual) { }

        static LocationalDataStub stub = new LocationalDataStub("GeoTrap Shape Locations");

        static GeoTrapControl control = new GeoTrapControl();

        static GeoTrapVisualizer visualizer = new GeoTrapVisualizer(stub, control);

        public GeoTrapManager(GeoTrapDetail detail) : base(detail, visualizer) { }

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {
            //GeoTrapFox2.AddQuestEntities((GeoTrapDetail)detail, dataSet, entityList);
        }

        public override void AddToMainLua(MainLua mainLua)
        {
            //GeoTrapLua.GetMain((GeoTrapDetail)detail, mainLua);
        }
    }
}
