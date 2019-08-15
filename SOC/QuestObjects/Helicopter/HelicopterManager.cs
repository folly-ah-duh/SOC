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
    class HelicopterManager : NonLocationalManager
    {
        static HelicopterControl control = new HelicopterControl();

        static HelicopterVisualizer visualizer = new HelicopterVisualizer(control);

        public HelicopterManager(HelicopterDetail detail) : base(detail, visualizer) { }

        public override void AddToDefinitionLua(DefinitionLua definitionLua)
        {
            HelicopterLua.GetDefinition((HelicopterDetail)base.detail, definitionLua);
        }

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {
            HelicopterFox2.AddQuestEntities((HelicopterDetail)base.detail, dataSet, entityList);
        }

        public override void AddToMainLua(MainLua mainLua)
        {
            HelicopterLua.GetMain((HelicopterDetail)base.detail, mainLua);
        }
    }
}
