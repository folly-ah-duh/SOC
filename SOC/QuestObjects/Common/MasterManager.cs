using SOC.Classes.Common;
using SOC.Forms.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SOC.QuestObjects.Common
{
    public class MasterManager
    {
        private ManagerArray managerArray;

        public MasterManager(ManagerArray managers)
        {
            managerArray = managers;
        }

        public void SetManagerArray(ManagerArray array)
        {
            managerArray = array;
        }

        public DetailManager[] GetManagers()
        {
            return managerArray.GetManagers();
        }

        internal UserControl[] GetModulePanels()
        {
            return managerArray.GetManagers().Select(manager => manager.GetVisualizer().detailControl).ToArray();
        }

        public List<Detail> GetQuestObjectDetails()
        {
            List<Detail> qodList = new List<Detail>();

            foreach(DetailManager manager in managerArray.GetManagers())
            {
                qodList.Add(manager.detail);
            }

            return qodList;
        }

        public List<LocationalDataStub> GetLocationalStubs()
        {
            return managerArray.GetManagers().OfType<LocationalManager>().Select(manager => manager.GetStub()).ToList();
        }

        public void UpdateAllDetailsFromControl()
        {
            foreach (DetailManager manager in managerArray.GetManagers())
            {
                manager.UpdateDetailFromControl();
            }
        }

        public void RefreshAllStubTexts()
        {
            foreach (DetailManager manager in managerArray.GetManagers())
            {
                if(manager is LocationalManager)
                {
                    LocationalManager locManager = (LocationalManager)manager;
                    locManager.RefreshStub();
                }
            }
        }

        public void RefreshAllPanels(CoreDetails core)
        {
            foreach (DetailManager manager in managerArray.GetManagers())
            {
                manager.UpdateDetailFromSetup(core);
                manager.RefreshPanel(core);
            }
        }

        internal void DisableVehicleBox()
        {
            foreach(DetailManager manager in managerArray.GetManagers())
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
            foreach (DetailManager manager in managerArray.GetManagers())
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
