using SOC.Classes.Fox2;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.Forms.Pages;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.QuestObjects.Vehicle
{
    class VehicleManager : DetailManager
    {
        static LocationalDataStub vehicleStub = new LocationalDataStub("Heavy Vehicle Locations");

        static VehicleControl vehiclePanel = new VehicleControl();

        static VehicleVisualizer vehicleVisualizer = new VehicleVisualizer(vehicleStub, vehiclePanel);

        public VehicleManager(VehicleDetail vehicleDetail) : base(vehicleDetail, vehicleVisualizer) { }

        public override void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList)
        {
            //todo
        }

        public override string AddToDefinitionLua()
        {
            return "";
        }

        public override string AddToPackListLua()
        {
            return "";
        }

        public override void AddToMainLua(List<string> luaTemplate)
        {
        }
    }
}
