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
        private static Vehicle.VehicleManager vehicleManager = new Vehicle.VehicleManager(new Vehicle.VehicleDetails());

        private static QuestObjectManager[] managerArray = { hostageManager, vehicleManager};



        public ManagerArray() { }

        public ManagerArray(List<QuestObjectDetails> questObjects)
        {
            managerArray = questObjects.Select(entry => entry.GetNewManager()).ToArray();
        }

        public QuestObjectManager[] GetManagers()
        {
            return managerArray;
        }

        public LocationalQuestObjectManager[] GetLocationalManagers()
        {
            List<LocationalQuestObjectManager> locationalManagers = new List<LocationalQuestObjectManager>();

            foreach(QuestObjectManager manager in managerArray)
            {
                if (manager is LocationalQuestObjectManager)
                    locationalManagers.Add((LocationalQuestObjectManager)manager);
            }

            return locationalManagers.ToArray();
        }

        public static Type[] GetDetailsTypes()
        {
            return managerArray.Select(entry => entry.questDetail.GetType()).ToArray();
        }
    }
}
