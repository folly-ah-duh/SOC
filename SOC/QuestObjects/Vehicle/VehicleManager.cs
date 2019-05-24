using SOC.Classes.Fox2;
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
        public VehicleManager() : base(new LocationalDataStub("Heavy Vehicle Locations"))
        {
        }

        public override void AddFox2Entities(ref List<Fox2EntityClass> entityList)
        {
            throw new NotImplementedException();
        }

    }
}
