using SOC.Classes.Fox2;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using SOC.Forms.Pages;
using SOC.Classes.Lua;
using SOC.Classes.Assets;
using SOC.Classes.Common;

namespace SOC.QuestObjects.ActiveItem
{
    class ActiveItemManager : LocationalManager
    {
        public ActiveItemManager(ActiveItemDetail detail) : base(detail, visualizer) { }

        static LocationalDataStub stub = new LocationalDataStub("Active Item Locations");

        static ActiveItemControl control = new ActiveItemControl();

        static ActiveItemVisualizer visualizer = new ActiveItemVisualizer(stub, control);

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {
            ActiveItemFox2.AddQuestEntities((ActiveItemDetail)detail, dataSet, entityList);
        }

        public override void AddToMainLua(MainLua mainLua)
        {
            ActiveItemLua.GetMain((ActiveItemDetail)detail, mainLua);
        }
    }
}
