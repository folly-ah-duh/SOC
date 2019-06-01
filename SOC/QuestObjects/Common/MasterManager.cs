using SOC.Forms.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SOC.QuestObjects.Common
{
    public class MasterManager
    {
        private ManagerArray managerArray = new ManagerArray();

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
                qodList.Add(manager.questDetail);
            }

            return qodList;
        }

        public List<LocationalDataStub> GetLocationalStubs()
        {
            return managerArray.GetManagers().Select(manager => manager.GetVisualizer().detailStub).ToList();
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
                manager.UpdateDetailFromControl();
                manager.RefreshStub();
            }
        }

        public void LoadAllStubTexts()
        {
            foreach (DetailManager manager in managerArray.GetManagers())
            {
                manager.LoadStub();
            }
        }

        public void RefreshAllPanels()
        {
            foreach (DetailManager manager in managerArray.GetManagers())
            {
                manager.UpdateDetailFromStub();
                manager.RefreshPanel();
            }
        }

        internal void DisableVehicleBox()
        {
            foreach(DetailManager manager in managerArray.GetManagers())
            {
                if (manager is Vehicle.VehicleManager)
                {
                    Vehicle.VehicleManager vehicleManager = (Vehicle.VehicleManager)manager;
                    vehicleManager.GetVisualizer().detailStub.DisableStub("Disabled On Mother Base");
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
                    vehicleManager.GetVisualizer().detailStub.EnableStub();
                }
            }
        }
    }
}
