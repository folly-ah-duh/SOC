using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.QuestObjects.Common
{
    public class ManagerArray
    {
        private static Hostage.HostageManager hostageManager = new Hostage.HostageManager(new Hostage.HostageDetails());
        //private static Vehicle.VehicleManager vehicleManager = new Vehicle.VehicleManager(new Vehicle.VehicleDetails());

        private static DetailManager[] managerArray = { hostageManager };//, vehicleManager};

        public ManagerArray() { }

        public ManagerArray(List<Detail> questObjects)
        {
            managerArray = questObjects.Select(entry => entry.GetNewManager()).ToArray();
        }

        public DetailManager[] GetManagers()
        {
            return managerArray;
        }

        public static Type[] GetDetailsTypes()
        {
            return managerArray.Select(entry => entry.questDetail.GetType()).ToArray();
        }
    }
}
