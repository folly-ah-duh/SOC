using SOC.Classes.Fox2;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using SOC.Forms.Pages;
using SOC.Classes.Lua;
using SOC.Classes.Assets;
using SOC.Classes.Common;

namespace SOC.QuestObjects.Item
{
    class ItemManager : LocationalManager
    {
        public ItemManager(ItemDetail detail) : base(detail, visualizer) { }

        static LocationalDataStub stub = new LocationalDataStub("Dormant Item Locations");

        static ItemControl control = new ItemControl();

        static ItemVisualizer visualizer = new ItemVisualizer(stub, control);

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {

        }

        public override void AddToMainLua(MainLua mainLua)
        {

        }

        public override void AddToDefinitionLua(DefinitionLua definitionLua)
        {

        }
    }
}
