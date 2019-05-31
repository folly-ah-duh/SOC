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
                typeof(Hostage.HostageDetail)//,
                //typeof(Vehicle.VehicleDetail)
            }; 
            return AllDetailTypes;
        }

        private DetailManager[] managerArray;

        public ManagerArray()
        {
            List<DetailManager> detailManagers = new List<DetailManager>();
            foreach (Type type in GetAllDetailTypes())
            {
                Detail questDetail = (Detail)Activator.CreateInstance(type);
                detailManagers.Add(questDetail.GetNewManager());
            }
            managerArray = detailManagers.ToArray();
        }

        public ManagerArray(List<Detail> questDetails)
        {
            managerArray = questDetails.Select(detail => detail.GetNewManager()).ToArray();
        }

        public DetailManager[] GetManagers()
        {
            return managerArray;
        }
    }
}
