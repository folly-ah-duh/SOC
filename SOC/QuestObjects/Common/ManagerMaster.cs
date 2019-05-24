using SOC.Forms.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SOC.QuestObjects.Common
{
    public class ManagerMaster
    {

        private QuestObjectManager[] managerList = { new Hostage.HostageManager(), new Vehicle.VehicleManager() };

        public List<LocationalDataStub> GetLocationalStubs()
        {
            List<LocationalDataStub> stubList = new List<LocationalDataStub>();

            foreach(QuestObjectManager manager in managerList)
            {
                if (manager is LocationalQuestObjectManager)
                {
                    LocationalQuestObjectManager locationalManager = (LocationalQuestObjectManager)manager;
                    stubList.Add(locationalManager.GetStub());
                }
            }
            return stubList;
        }

        internal void DisableVehicleBox()
        {
            foreach(QuestObjectManager manager in managerList)
            {
                if (manager is Vehicle.VehicleManager)
                {
                    Vehicle.VehicleManager vehicleManager = (Vehicle.VehicleManager)manager;
                    vehicleManager.GetStub().DisableStub("Disabled On Mother Base");
                }
            }
        }

        internal void EnableVehicleBox()
        {
            foreach (QuestObjectManager manager in managerList)
            {
                if (manager is Vehicle.VehicleManager)
                {
                    Vehicle.VehicleManager vehicleManager = (Vehicle.VehicleManager)manager;
                    vehicleManager.GetStub().EnableStub();
                }
            }
        }
    }
}
