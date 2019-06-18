using SOC.Classes.Fox2;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.Forms.Pages;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOC.Classes.Lua;
using SOC.Classes.Assets;
using SOC.Classes.Common;

namespace SOC.QuestObjects.Vehicle
{
    class VehicleManager : LocationalManager
    {
        static LocationalDataStub vehicleStub = new LocationalDataStub("Heavy Vehicle Locations");

        static VehicleControl vehiclePanel = new VehicleControl();

        static VehicleVisualizer vehicleVisualizer = new VehicleVisualizer(vehicleStub, vehiclePanel);

        public VehicleManager(VehicleDetail vehicleDetail) : base(vehicleDetail, vehicleVisualizer) { }

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {
        }

        public override void AddToDefinitionLua(DefinitionLua definitionLua)
        {
        }

        public override void AddToMainLua(MainLua mainLua)
        {
        }

        public override void AddToAssets(FileAssets fileAssets)
        {
            VehicleAssets.GetVehicleAssets((VehicleDetail)base.questDetail, fileAssets);
        }
    }
}
