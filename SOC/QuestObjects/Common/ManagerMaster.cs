using SOC.Forms.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SOC.QuestObjects.Common
{
    public class ManagerMaster
    {
        private ManagerArray managerArray = new ManagerArray();

        public ManagerMaster(ManagerArray managers)
        {
            managerArray = managers;
        }

        public void SetManagerArray(ManagerArray array)
        {
            managerArray = array;
        }

        public List<QuestObjectDetails> GetQuestObjectDetails()
        {
            List<QuestObjectDetails> qodList = new List<QuestObjectDetails>();

            foreach(QuestObjectManager manager in managerArray.GetManagers())
            {
                qodList.Add(manager.questDetail);
            }

            return qodList;
        }

        public List<LocationalDataStub> GetLocationalStubs()
        {
            List<LocationalDataStub> stubList = new List<LocationalDataStub>();

            foreach(LocationalQuestObjectManager locationalManager in managerArray.GetLocationalManagers())
            {
                stubList.Add(locationalManager.GetStub());
            }

            return stubList;
        }

        public void RefreshAllStubTexts()
        {
            foreach (LocationalQuestObjectManager locationalManager in managerArray.GetLocationalManagers())
            {
                locationalManager.RefreshStubText();
            }
        }

        internal void DisableVehicleBox()
        {
            foreach(QuestObjectManager manager in managerArray.GetManagers())
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
            foreach (QuestObjectManager manager in managerArray.GetManagers())
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
