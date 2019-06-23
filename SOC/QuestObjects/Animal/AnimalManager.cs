using SOC.Classes.Fox2;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using SOC.Forms.Pages;
using SOC.Classes.Lua;
using SOC.Classes.Assets;
using SOC.Classes.Common;

namespace SOC.QuestObjects.Animal
{
    class AnimalManager : LocationalManager
    {
        static LocationalDataStub stub = new LocationalDataStub("Animal Herd Locations");

        static AnimalControl control = new AnimalControl();

        static AnimalVisualizer visualizer = new AnimalVisualizer(stub, control);

        public AnimalManager(AnimalDetail detail) : base(detail, visualizer) { }

        public override void AddToDefinitionLua(DefinitionLua definitionLua)
        {
        }

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {
            AnimalFox2.AddQuestEntities((AnimalDetail)detail, dataSet, entityList);
        }

        public override void AddToMainLua(MainLua mainLua)
        {
        }
    }
}
