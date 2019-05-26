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
    class VehicleManager : LocationalQuestObjectManager
    {
        static LocationalDataStub vehicleStub = new LocationalDataStub("Heavy Vehicle Locations");

        private VehicleDetails vehicleDetails;

        public VehicleManager(VehicleDetails vehicleDets) : base(vehicleStub, vehicleDets)
        {
            vehicleDetails = vehicleDets;
        }

        public override void AddFox2Entities(ref List<Fox2EntityClass> entityList)
        {
            throw new NotImplementedException();
        }

        public override void RefreshStubText()
        {
            List<Position> vehPosList = new List<Position>();

            foreach (Vehicle veh in vehicleDetails.Vehicles)
            {
                vehPosList.Add(new Position(veh.coordinates, veh.rotation));
            }
            vehPosList.Add(new Position(new SOC.Classes.Common.Coordinates("1", "2", "3"), new SOC.Classes.Common.Rotation("50")));

            vehicleStub.SetStubText(new IHLogPositions(vehPosList));
        }
    }
}
