using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.QuestObjects.Common
{
    public class ManagerArray
    {
        public static Type[] GetAllDetailTypes() // Note: attach modules here
        {
            Type[] AllDetailTypes = {
                typeof(Hostage.HostageDetail),
                typeof(Vehicle.VehicleDetail),
                typeof(WalkerGear.WalkerDetail)
            }; 
            return AllDetailTypes;
        }

        private DetailManager[] managerArray;

        public ManagerArray()
        {
            List<DetailManager> managers = new List<DetailManager>();

            foreach (Type type in GetAllDetailTypes())
            {
                Detail questDetail = (Detail)Activator.CreateInstance(type);
                managers.Add(questDetail.GetNewManager());
            }
            managerArray = managers.ToArray();
        }

        public ManagerArray(List<Detail> questDetails)
        {
            List<DetailManager> managers = questDetails.Select(detail => detail.GetNewManager()).ToList();
            Type[] questDetailTypes = questDetails.Select(detail => detail.GetType()).ToArray();

            foreach (Type type in GetAllDetailTypes())
            {
                if (!questDetailTypes.Contains(type))
                {
                    Detail questDetail = (Detail)Activator.CreateInstance(type);
                    managers.Add(questDetail.GetNewManager());
                }
            }
            managerArray = managers.ToArray();
        }

        public DetailManager[] GetManagers()
        {
            return managerArray;
        }
    }
}
