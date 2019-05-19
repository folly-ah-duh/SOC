using SOC.Classes.Common;
using SOC.Classes.Fox2;
using SOC.QuestComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.QuestObjects.Hostage
{
    static class HostageFox2 // : (abstract) objectFox2?
    {
        static void AddQuestEntities(List<Hostage> HostageList, ref List<Fox2EntityClass> entityList)
        {
            if (HostageList.Count > 0)
            {
                DataSet dataSet = GetQuestDataSet(entityList);
                GameObject gameObjectTppHostageUnique = new GameObject("GameObjectTppHostageUnique", dataSet, "TppHostageUnique2", HostageList.Count, HostageList.Count);
                TppHostage2Parameter hostageParameter = new TppHostage2Parameter(gameObjectTppHostageUnique, )//parts path. instead of a hostagelist, maybe this class should recieve some sort of hostageData struct?


                entityList.Add();
                entityList.Add(new TppHostage2Parameter("GameObjectTppHostageUnique", "TppHostageUnique2", HostageList.Count));
                entityList.Add(new QuestEntity(entityClass.TppHostage2Parameter));

                foreach (Hostage hostage in HostageList)
                {
                    entityList.Add(new QuestEntity(entityClass.GameObjectLocator, hostage.GetHostageName(), "TppHostageUnique2"));
                    entityList.Add(new QuestEntity(entityClass.TransformEntity, eDetails: new object[] { hostage.coordinates, hostage.rotation }));
                    entityList.Add(new QuestEntity(entityClass.TppHostage2LocatorParameter));
                }
            }
        }

        private static DataSet GetQuestDataSet(List<Fox2EntityClass> entityList)
        {
            foreach (Fox2EntityClass entity in entityList)
            {
                if (entity is DataSet)
                    return (DataSet)entity;
            }
            return null;
        }
    }
}
