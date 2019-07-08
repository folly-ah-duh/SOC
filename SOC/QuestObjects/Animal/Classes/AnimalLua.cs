using SOC.Classes.Lua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.QuestObjects.Animal
{
    class AnimalLua
    {
        public static void GetMain(AnimalDetail detail, MainLua mainLua)
        {
            if(detail.animals.Count > 0)
            {
                mainLua.AddToQuestTable(BuildAnimalList(detail.animals));
                if (detail.animals.Any(animal => animal.target))
                {
                    CheckQuestAnimal checkAnimal = new CheckQuestAnimal(mainLua, detail.animalMetadata.objectiveType);
                    mainLua.AddToQuestTable(BuildAnimalTargetList(detail.animals));
                }
            }
        }

        private static string BuildAnimalList(List<Animal> animals)
        {
            StringBuilder animalListBuilder = new StringBuilder("animalList  = {");

            if (animals.Count == 0)
            {
                animalListBuilder.Append(@"
        nil ");
            } else
            {
                foreach (Animal animal in animals)
                {
                    animalListBuilder.Append($@"
        {{
            animalName = ""{animal.GetObjectName()}"",
            animalType = ""{animal.typeID}"",");
                    animalListBuilder.Append(@"
        },");
                }
            }

            animalListBuilder.Append(@"
    }");
            return animalListBuilder.ToString();
        }

        private static string BuildAnimalTargetList(List<Animal> animals)
        {
            StringBuilder animalTargetListBuilder = new StringBuilder("targetAnimalList = {");
            bool hasTargets = animals.Any(animal => animal.target == true);
            animalTargetListBuilder.Append(@"
        markerList = {");
            if (hasTargets)
            {
                foreach(Animal animal in animals)
                {
                    if (animal.target)
                        animalTargetListBuilder.Append($@"
            ""{animal.GetObjectName()}"",");
                }
            }
            else
            {
                animalTargetListBuilder.Append(@"
        nil ");
            }
            animalTargetListBuilder.Append(@"
        },
        nameList = {");
            if (hasTargets)
            {
                foreach (Animal animal in animals)
                {
                    if (animal.target)
                        animalTargetListBuilder.Append($@"
            ""{animal.GetObjectName()}"",");
                }
            }
            else
            {
                animalTargetListBuilder.Append(@"
        nil ");
            }
            animalTargetListBuilder.Append(@"
        },
    }");

            return animalTargetListBuilder.ToString();
        }
    }
}
