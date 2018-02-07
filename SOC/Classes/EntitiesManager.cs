using SOC.QuestComponents;
using System.Collections.Generic;
using System.Windows.Forms;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.Classes
{
    static class EntitiesManager
    {
        private static List<Enemy> questEnemies = new List<Enemy>();
        private static List<Enemy> cpEnemies = new List<Enemy>();
        private static List<Hostage> hostages = new List<Hostage>();
        private static List<Vehicle> vehicles = new List<Vehicle>();
        private static List<Animal> animals = new List<Animal>();
        private static List<Item> items = new List<Item>();
        private static List<ActiveItem> activeItems = new List<ActiveItem>();
        private static List<Model> models = new List<Model>();

        private static int hostageBodyIndex = 0;
        private static bool interrogateForHostages = false;
        private static string enemySubType = "SOVIET_A";

        public static void check()
        {
            MessageBox.Show(questEnemies.Count + "");
        }

        public static QuestEntities GetQuestEntities()
        {
            return new QuestEntities(questEnemies, cpEnemies, hostages, vehicles, animals, items, activeItems, models, hostageBodyIndex, interrogateForHostages, enemySubType); ;
        }

        public static void setQuestEntities(QuestEntities q)
        {
            questEnemies = q.questEnemies; cpEnemies = q.cpEnemies;
            hostages = q.hostages; vehicles = q.vehicles; animals = q.animals; items = q.items; activeItems = q.activeItems; models = q.models;
            hostageBodyIndex = q.hostageBodyIndex; interrogateForHostages = q.canInter; enemySubType = q.soldierSubType;
        }

        public static void ClearEntities()
        {
            questEnemies.Clear(); cpEnemies.Clear(); hostages.Clear(); vehicles.Clear(); animals.Clear(); items.Clear(); activeItems.Clear(); models.Clear();
            hostageBodyIndex = 0;
            interrogateForHostages = false;
            enemySubType = "SOVIET_A";
        }

        public static void InitializeEntities(CP enemyCP, string routeFile, List<Coordinates> hostageCoords, List<Coordinates> vehicleCoords, List<Coordinates> animalCoords, List<Coordinates> itemCoords, List<Coordinates> activeitemCoords, List<Coordinates> modelCoords)
        {
            int newEntityCount, oldEntityCount;

            //
            // Add/Remove Quest-specific Enemies
            //
            newEntityCount = EnemyInfo.MAXQUESTFOVA;
            oldEntityCount = questEnemies.Count;
            if (enemyCP.CProutes.Length > 0 || !routeFile.Equals("NONE"))
                for (int i = oldEntityCount; i < newEntityCount; i++)
                    questEnemies.Add(new Enemy(i, "sol_quest_000" + i));
            else
                questEnemies.Clear();

            //
            // add/remove cp-specific enemies
            //
            newEntityCount = enemyCP.CPsoldiers.Length;
            oldEntityCount = cpEnemies.Count;
            if ((oldEntityCount > 0 && newEntityCount > 0) && !cpEnemies[0].name.Equals(enemyCP.CPsoldiers[0])) // swapping names for new CP
                for (int i = 0; i < cpEnemies.Count && i < newEntityCount; i++)
                    cpEnemies[i].name = enemyCP.CPsoldiers[i];

            if (newEntityCount < oldEntityCount) // less than current count
                cpEnemies.RemoveRange(newEntityCount, oldEntityCount - newEntityCount);
            
            if (newEntityCount > oldEntityCount) // more than current count
                for (int i = oldEntityCount; i < newEntityCount; i++)
                    cpEnemies.Add(new Enemy(i, enemyCP.CPsoldiers[i]));

            //
            // add/remove hostages
            //
            newEntityCount = hostageCoords.Count;
            oldEntityCount = hostages.Count;
            if (newEntityCount < oldEntityCount)
                hostages.RemoveRange(newEntityCount, oldEntityCount - newEntityCount);

            if (newEntityCount > oldEntityCount)
                for (int i = oldEntityCount; i < newEntityCount; i++)
                    hostages.Add(new Hostage(hostageCoords[i], i, "Hostage_" + i));

            for (int i = 0; i < newEntityCount && i < oldEntityCount; i++)
                hostages[i].coordinates = hostageCoords[i];

            //
            // add/remove vehicles
            //
            newEntityCount = vehicleCoords.Count;
            oldEntityCount = vehicles.Count;
            if (newEntityCount < oldEntityCount)
                vehicles.RemoveRange(newEntityCount, oldEntityCount - newEntityCount);

            if (newEntityCount > oldEntityCount)
                for (int i = oldEntityCount; i < newEntityCount; i++)
                    vehicles.Add(new Vehicle(vehicleCoords[i], i, "Vehicle_" + i));

            for (int i = 0; i < newEntityCount && i < oldEntityCount; i++)
                vehicles[i].coordinates = vehicleCoords[i];
            //
            // add/remove animals
            //
            newEntityCount = animalCoords.Count;
            oldEntityCount = animals.Count;
            if (newEntityCount < oldEntityCount)
                animals.RemoveRange(newEntityCount, oldEntityCount - newEntityCount);

            if (newEntityCount > oldEntityCount)
                for (int i = oldEntityCount; i < newEntityCount; i++)
                    animals.Add(new Animal(animalCoords[i], i, "Animal_Cluster_" + i));

            for (int i = 0; i < newEntityCount && i < oldEntityCount; i++)
                animals[i].coordinates = animalCoords[i];
            //
            // add/remove items
            //
            newEntityCount = itemCoords.Count;
            oldEntityCount = items.Count;
            if (newEntityCount < oldEntityCount)
                items.RemoveRange(newEntityCount, oldEntityCount - newEntityCount);

            if (newEntityCount > oldEntityCount)
                for (int i = oldEntityCount; i < newEntityCount; i++)
                    items.Add(new Item(itemCoords[i], i, "Item_" + i));

            for (int i = 0; i < newEntityCount && i < oldEntityCount; i++)
            {
                items[i].coordinates = itemCoords[i];
                items[i].setRotation(itemCoords[i]);
            }
            //
            // add/remove activeitems
            //
            newEntityCount = activeitemCoords.Count;
            oldEntityCount = activeItems.Count;
            if (newEntityCount < oldEntityCount)
                activeItems.RemoveRange(newEntityCount, oldEntityCount - newEntityCount);

            if (newEntityCount > oldEntityCount)
                for (int i = oldEntityCount; i < newEntityCount; i++)
                    activeItems.Add(new ActiveItem(activeitemCoords[i], i, "Active_Item_" + i));

            for (int i = 0; i < newEntityCount && i < oldEntityCount; i++)
            {
                activeItems[i].coordinates = activeitemCoords[i];
                activeItems[i].setRotation(activeitemCoords[i]);
            }
            //
            // add/remove models
            //
            newEntityCount = modelCoords.Count;
            oldEntityCount = models.Count;
            if (newEntityCount < oldEntityCount)
                models.RemoveRange(newEntityCount, oldEntityCount - newEntityCount);

            if (newEntityCount > oldEntityCount)
                for (int i = oldEntityCount; i < newEntityCount; i++)
                    models.Add(new Model(modelCoords[i], i, "Model_" + i));

            for (int i = 0; i < newEntityCount && i < oldEntityCount; i++)
            {
                models[i].coordinates = modelCoords[i];
                models[i].setRotation(modelCoords[i]);
            }
        }

    }
}
