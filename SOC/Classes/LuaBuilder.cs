using SOC.QuestComponents;
using SOC.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.Classes
{
    static class LuaBuilder
    {

        static string[] questLuaInput = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "assets//questScript.lua"));

        public static void WriteDefinitionLua(DefinitionDetails definitionDetails, QuestObjects questDetails)
        {
            BodyInfoEntry bodyInfo = new BodyInfoEntry();
            if (questDetails.hostageBodyIndex >= 0)
                bodyInfo = BodyInfo.BodyInfoArray[questDetails.hostageBodyIndex];

            string packFiles = "";
            string locName = "";
            string gender = "MALE";
            if (bodyInfo.isFemale)
                gender = "FEMALE";

            if (definitionDetails.locationID == 10)
                locName = "AFGH";

            else if (definitionDetails.locationID == 20)
                locName = "MAFR";

            if (questDetails.hostages.Count > 0)
            {
                packFiles += "\n\t\t\"/Assets/tpp/pack/mission2/ih/ih_hostage_base.fpk\", ";
                packFiles += string.Format("\n\t\t\"{0}\", ", bodyInfo.missionPackPath);
            }

            packFiles += string.Format("\n\t\t\"/Assets/tpp/pack/mission2/quest/ih/{0}.fpk\", ", definitionDetails.FpkName);

            if (questDetails.hostages.Count > 0)
                if (!bodyInfo.hasface)
                    packFiles += string.Format("\n\t\trandomFaceListIH = {{gender = \"{0}\", count = {1}}}, ", gender, questDetails.hostages.Count);

            string bodies = "";
            string faces = "";

            if (locName.Equals("AFGH") || locName.Equals("MAFR"))
            {
                if(EnemyInfo.balaCount > 0) { faces += string.Format("TppDefine.QUEST_FACE_ID_LIST.{0}_BALACLAVA, ", locName); }
                if(EnemyInfo.armorCount > 0) { bodies += string.Format("TppDefine.QUEST_BODY_ID_LIST.{0}_ARMOR, ", locName); }
            }

            foreach (string body in getEnemyBodies(questDetails.enemies))
                bodies += string.Format("TppEnemyBodyId.{0}, ", body);

            packFiles += string.Format("\n\t\tfaceIdList={{{0}}}, ", faces);
            packFiles += string.Format("\n\t\tbodyIdList={{{0}}}, ", bodies);

            string questPackList = string.Format("\tquestPackList = {{ {0} \n\t}},", packFiles);

            string locationInfo = string.Format("\tlocationId={0}, areaName=\"{1}\", iconPos=Vector3({2},{3},{4}), radius={5},", definitionDetails.locationID, definitionDetails.loadArea, definitionDetails.coords.xCoord, definitionDetails.coords.yCoord, definitionDetails.coords.zCoord, definitionDetails.radius);
            
            string progressLangId = string.Format("\tquestCompleteLangId=\"{0}\",", UpdateNotifsManager.getLangIds()[definitionDetails.progNotif]);

            string canOpenQuestFunction = "\tcanOpenQuest=InfQuest.AllwaysOpenQuest, --function that decides whether the quest is open or not"; //todo in future update?

            string disableLzs = "\tdisableLzs={ }, --disables lzs while the quest is active. Turn on the debugMessages option and look in ih_log.txt for StartedMoveToLandingZone after calling in a support heli to find the lz name."; // todo in future update

            string equipIds = ""; List<string> requestHistory = new List<string>();

            foreach (Item item in questDetails.items)
                if (item.item.Contains("EQP_WP_") && !requestHistory.Contains(item.item))
                {
                    equipIds += string.Format("\"{0}\", ", item.item);
                    requestHistory.Add(item.item);
                }
                    

            string requestEquipIds = string.Format("\trequestEquipIds={{ {0} }},", equipIds);

            string hasEnemyHeli = "\thasEnemyHeli = false, --reserves an enemy helicopter for the sideop. set to true if the sideop has a heli.";
            

            string DefinitionLuaPath = "Sideop_Build//GameDir//mod//quests//";
            string DefinitionLuaFile = Path.Combine(DefinitionLuaPath, string.Format("ih_quest_q{0}.lua", definitionDetails.QuestNum));

            Directory.CreateDirectory(DefinitionLuaPath);

            using (StreamWriter defFile =
            new StreamWriter(DefinitionLuaFile))
            {
                defFile.WriteLine("local this={");
                defFile.WriteLine(questPackList);
                defFile.WriteLine(locationInfo);
                if (definitionDetails.locationID == 50)
                    defFile.WriteLine(string.Format("\tclusterName=\"{0}\",", definitionDetails.loadArea.Substring(4)));
                defFile.WriteLine(string.Format("\tcategory=TppQuest.QUEST_CATEGORIES_ENUM.{0},", definitionDetails.category));
                defFile.WriteLine(progressLangId);
                defFile.WriteLine(canOpenQuestFunction);
                defFile.WriteLine(string.Format("\tquestRank=TppDefine.QUEST_RANK.{0},", definitionDetails.reward));
                defFile.WriteLine(disableLzs);
                defFile.WriteLine(requestEquipIds);
                defFile.WriteLine(hasEnemyHeli);
                defFile.WriteLine("} return this");
            }
        }

        public static void WriteMainQuestLua(DefinitionDetails definitionDetails, QuestObjects questDetails)
        {
            List<string> questLua = new List<string>(questLuaInput);

            questLua[GetLineOf("local hostageCount =", questLua)] = string.Format("local hostageCount = {0}", questDetails.hostages.Count);
            questLua[GetLineOf("local CPNAME =", questLua)] = string.Format("local CPNAME = \"{0}\"", definitionDetails.CPName); //add cp combobox to setup
            questLua[GetLineOf("local useInter =", questLua)] = string.Format("local useInter = {0}", questDetails.canInter.ToString().ToLower()); //add interogation checkbox to setup
            questLua[GetLineOf("local qType =", questLua)] = string.Format("local qType = TppDefine.QUEST_TYPE.{0}", definitionDetails.objectiveType); //add questtype combobox to setup
            questLua[GetLineOf("local SUBTYPE =", questLua)] = string.Format("local SUBTYPE = \"{0}\"", questDetails.soldierSubType);

            string luaBool;
            if (EnemyInfo.armorCount > 0) luaBool = "true"; else luaBool = "false";
            questLua[GetLineOf("	isQuestArmor =", questLua)] = string.Format("	isQuestArmor =  {0},", luaBool);
            if (EnemyInfo.zombieCount > 0) luaBool = "true"; else luaBool = "false";
            questLua[GetLineOf("	isQuestZombie =", questLua)] = string.Format("	isQuestZombie = {0},", luaBool);
            if (EnemyInfo.balaCount > 0) luaBool = "true"; else luaBool = "false";
            questLua[GetLineOf("	isQuestBalaclava =", questLua)] = string.Format("	isQuestBalaclava = {0},", luaBool);

            questLua.InsertRange(GetLineOf("    enemyList = {", questLua) + 1, BuildEnemyList(questDetails));
            questLua.InsertRange(GetLineOf("    vehicleList = {", questLua) + 1, BuildVehicleList(questDetails));
            questLua.InsertRange(GetLineOf("    hostageList = {", questLua) + 1, BuildHostageList(questDetails));
            questLua.InsertRange(GetLineOf("    animalList = {", questLua) + 1, BuildAnimalList(questDetails));
            questLua.InsertRange(GetLineOf("    targetList = {", questLua) + 1, BuildTargetList(questDetails));
            questLua.InsertRange(GetLineOf("    targetAnimalList = {", questLua) + 1, BuildAnimalTargetList(questDetails));
            questLua.InsertRange(GetLineOf("Hostage Attributes List", questLua) + 1, BuildHostageAttributes(questDetails));


            string LuaScriptPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd//Assets//tpp//level//mission2//quest//ih", definitionDetails.FpkName);
            string LuaScriptFile = Path.Combine(LuaScriptPath, definitionDetails.FpkName + ".lua");

            Directory.CreateDirectory(LuaScriptPath);
            File.WriteAllLines(LuaScriptFile, questLua);
        }

        public static int GetLineOf(string text, List<string> questLua)
        {
            for (int i = 0; i < questLua.Count; i++)
                if (questLua[i].Contains(text))
                    return i;

            return -1;
        }

        public static List<string> getEnemyBodies(List<Enemy> enemyDetails)
        {
            List<string> bodyList = new List<string>();

            foreach (Enemy enemy in enemyDetails)
                if (!enemy.isArmored && !enemy.body.Equals("DEFAULT"))
                    if (!bodyList.Contains(enemy.body))
                        bodyList.Add(enemy.body);

            return bodyList;
        }

        public static List<string> BuildAnimalList(QuestObjects questDetails)
        {
            List<string> animalList = new List<string>();
            if (questDetails.animals.Count == 0)
                animalList.Add("nil");
            else
            {
                foreach(Animal animal in questDetails.animals)
                {
                    string animalType = animal.typeID;
                    animalList.Add("	{");
                    animalList.Add(string.Format("		animalName = \"{0}\",", animal.name));
                    animalList.Add(string.Format("		animalType = \"{0}\",", animalType));
                    animalList.Add("	},");
                }
            }
            return animalList;
        }

        public static List<string> BuildAnimalTargetList(QuestObjects questDetails)
        {
            List<string> animalTargetList = new List<string>();

            bool hasTarget = false;
            foreach (Animal animal in questDetails.animals)
                if (animal.isTarget)
                    hasTarget = true;

            animalTargetList.Add("	markerList = {");
            if (!hasTarget)
                animalTargetList.Add("nil");
            else
            {
                foreach (Animal animal in questDetails.animals)
                {
                    if (animal.isTarget)
                        animalTargetList.Add(string.Format("		\"{0}\",", animal.name));
                }
            }
            animalTargetList.Add("	},");
            animalTargetList.Add("	nameList={");
            if (!hasTarget)
                animalTargetList.Add("nil");
            else
            {
                foreach (Animal animal in questDetails.animals)
                {
                    if (animal.isTarget)
                        animalTargetList.Add(string.Format("		\"{0}\",", animal.name));
                }
            }
            animalTargetList.Add("	},");

            return animalTargetList;
        }

        public static List<string> BuildEnemyList(QuestObjects questDetails)
        {
            List<string> enemyList = new List<string>();

            List<Enemy> detailList = questDetails.enemies;
            int enemyCount = 0;

            foreach (Enemy enemy in detailList)
            {

                string powerlist = "";
                if (!enemy.isSpawn)
                    continue;
                enemyCount++;
                enemyList.Add("		{");
                enemyList.Add(string.Format("			enemyName = \"{0}\",", enemy.name));
                if (!enemy.dRoute.Equals("NONE")) {
                    enemyList.Add(string.Format("			route_d = \"{0}\",", enemy.dRoute));
                    enemyList.Add(string.Format("			route_c = \"{0}\",", enemy.cRoute));
                }
                enemyList.Add("			cpName = CPNAME,");
                if (enemy.powers.Length > 0)
                {
                    foreach (string power in enemy.powers)
                    {
                        powerlist += string.Format("\"{0}\", ", power);
                    }
                    enemyList.Add(string.Format("			powerSetting = {{ {0} }},", powerlist));
                }
                enemyList.Add("			soldierSubType = SUBTYPE,");

                if (!enemy.staffType.Equals("NONE"))
                    enemyList.Add(string.Format("			staffTypeId = TppDefine.STAFF_TYPE_ID.{0},", enemy.staffType));

                if (!enemy.skill.Equals("NONE"))
                    enemyList.Add(string.Format("			skill = \"{0}\",", enemy.skill));

                if (!enemy.body.Equals("DEFAULT") && !enemy.isArmored)
                    enemyList.Add(string.Format("			bodyId = TppEnemyBodyId.{0},", enemy.body));

                if (EnemyInfo.balaCount > 0)
                {
                    if (enemy.isBalaclava)
                        enemyList.Add("			isBalaclava = true,");
                    else
                        enemyList.Add("			isBalaclava = false,");
                }

                if (EnemyInfo.zombieCount > 0)
                {
                    if (enemy.isZombie)
                    {
                        enemyList.Add("			isZombie = true,");
                        enemyList.Add("			isZombieUseRoute = true,");
                    }
                }

                enemyList.Add("		},");
            }
            if (enemyCount == 0)
                enemyList.Add("nil");

            return enemyList;
        }

        public static List<string> BuildHostageList(QuestObjects questDetails)
        {
            List<string> hostageList = new List<string>();

            BodyInfoEntry bodyInfo = new BodyInfoEntry();
            if (questDetails.hostageBodyIndex >= 0)
                bodyInfo = BodyInfo.BodyInfoArray[questDetails.hostageBodyIndex];

            if (questDetails.hostages.Count == 0)
                hostageList.Add("nil");
            else
                foreach (Hostage hostage in questDetails.hostages)
                {
                    hostageList.Add("		{");
                    hostageList.Add(string.Format("			hostageName = \"{0}\",", hostage.name));
                    hostageList.Add("			isFaceRandom = true,");
                    if (hostage.isTarget)
                        hostageList.Add("			isTarget = true,");
                    if (hostage.language.Equals("english"))
                        hostageList.Add("			voiceType = { \"hostage_a\", \"hostage_b\", \"hostage_c\", \"hostage_d\",},");
                    else
                        hostageList.Add("			voiceType = { \"hostage_a\", \"hostage_b\", },");

                    hostageList.Add(string.Format("			langType = \"{0}\",", hostage.language));

                    if (!hostage.staffType.Equals("NONE"))
                        hostageList.Add(string.Format("			staffTypeId = TppDefine.STAFF_TYPE_ID.{0},", hostage.staffType));

                    if (!hostage.skill.Equals("NONE"))
                        hostageList.Add(string.Format("			skill = \"{0}\",", hostage.skill));

                    double rotation = 0; Double.TryParse(hostage.coordinates.roty, out rotation);
                    
                    hostageList.Add(string.Format("			bodyId = {0},", bodyInfo.bodyId));

                    double yOffset = 0.0;
                    double.TryParse(hostage.coordinates.yCoord, out yOffset);
                    yOffset += 0.783;

                    hostageList.Add(string.Format("			position={{pos={{{0},{1},{2}}},rotY={3},}},", hostage.coordinates.xCoord, yOffset, hostage.coordinates.zCoord, rotation));

                    hostageList.Add("		},");
                }

            return hostageList;
        }

        public static List<string> BuildVehicleList(QuestObjects questDetails)
        {
            List<string> vehicleList = new List<string>();

            if (questDetails.vehicles.Count == 0)
                vehicleList.Add("nil");
            else
                foreach (Vehicle vehicle in questDetails.vehicles)
                {
                    string vehicleName = vehicleNames[vehicle.vehicleIndex];
                    

                    vehicleList.Add("		{");
                    vehicleList.Add("			id = \"Spawn\",");
                    vehicleList.Add(string.Format("			locator = \"{0}\",", vehicle.name));
                    
                    if (vehicleName.Equals("EASTERN_WHEELED_ARMORED_VEHICLE_ROCKET_ARTILLERY"))
                    {
                        vehicleList.Add(string.Format("			type	= Vehicle.type.{0},", "EASTERN_WHEELED_ARMORED_VEHICLE"));
                        vehicleList.Add(string.Format("			subType	= Vehicle.subType.{0},", vehicleName));
                    }
                    else if (vehicleName.Equals("WESTERN_WHEELED_ARMORED_VEHICLE_TURRET_MACHINE_GUN") || vehicleName.Equals("WESTERN_WHEELED_ARMORED_VEHICLE_TURRET_CANNON"))
                    {
                        vehicleList.Add(string.Format("			type	= Vehicle.type.{0},", "WESTERN_WHEELED_ARMORED_VEHICLE"));
                        vehicleList.Add(string.Format("			subType	= Vehicle.subType.{0},", vehicleName));
                    }
                    else
                    {
                        vehicleList.Add(string.Format("			type	= Vehicle.type.{0},", vehicleName));
                    }


                    if (!vehicle.vehicleClass.Equals("DEFAULT"))
                        vehicleList.Add(string.Format("			class	= Vehicle.class.{0},", vehicle.vehicleClass));

                    double rotationdegrees = 0; Double.TryParse(vehicle.coordinates.roty, out rotationdegrees);
                    double toRadians = rotationdegrees * Math.PI / 180;

                    double yOffset = 0.0;
                    double.TryParse(vehicle.coordinates.yCoord, out yOffset);
                    yOffset += 0.783;

                    vehicleList.Add(string.Format("			position={{pos={{{0},{1},{2}}},rotY={3},}},", vehicle.coordinates.xCoord, yOffset, vehicle.coordinates.zCoord, toRadians));

                    vehicleList.Add("		},");
                }

            return vehicleList;
        }

        public static List<string> BuildTargetList(QuestObjects questDetails)
        {
            int totalCount = 0;
            List<string> targetList = new List<string>();

            foreach(Enemy enemy in questDetails.enemies)
                if (enemy.isSpawn && enemy.isTarget)
                {
                    targetList.Add(string.Format("		\"{0}\",", enemy.name));
                    totalCount++;
                }

            foreach (Hostage hostage in questDetails.hostages)
                if (hostage.isTarget)
                {
                    targetList.Add(string.Format("		\"{0}\",", hostage.name));
                    totalCount++;
                }

            foreach (Vehicle vehicle in questDetails.vehicles)
                if (vehicle.isTarget)
                {
                    targetList.Add(string.Format("		\"{0}\",", vehicle.name));
                    totalCount++;
                }

            if (totalCount == 0)
                targetList.Add("nil");

            return targetList;
        }

        public static List<string> BuildHostageAttributes(QuestObjects questDetails)
        {
            List<string> hosAttributeList = new List<string>();

            foreach (Hostage hostage in questDetails.hostages)
            {
                if (hostage.isUntied)
                    hosAttributeList.Add(string.Format("GameObject.SendCommand(GameObject.GetGameObjectId(\"TppHostageUnique2\", \"{0}\"),commandUnlocked)", hostage.name));

                if (hostage.isInjured)
                    hosAttributeList.Add(string.Format("GameObject.SendCommand(GameObject.GetGameObjectId(\"TppHostageUnique2\", \"{0}\"),commandInjured)", hostage.name));

                if (hostage.scared.Equals("NEVER")) //"NORMAL", "NEVER", "ALWAYS"
                    hosAttributeList.Add(string.Format("GameObject.SendCommand(GameObject.GetGameObjectId(\"TppHostageUnique2\", \"{0}\"),commandBrave)", hostage.name));

                else if (hostage.scared.Equals("ALWAYS"))
                    hosAttributeList.Add(string.Format("GameObject.SendCommand(GameObject.GetGameObjectId(\"TppHostageUnique2\", \"{0}\"),commandScared)", hostage.name));
            }

            return hosAttributeList;
        }

    }
}
