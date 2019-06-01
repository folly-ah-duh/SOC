using SOC.Classes.Common;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace SOC.Classes.QuestBuild.Lua
{
    static class LuaBuilder
    {

        static string[] questLuaInput = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//questScript.lua"));

        public static void WriteDefinitionLua(CoreDetails coreDetails, MasterManager masterManager)
        {
            /*
            BodyInfoEntry bodyInfo = new BodyInfoEntry();
            if (questObjectDetails.hostageBodyIndex >= 0)
                bodyInfo = BodyInfo.BodyInfoArray[questObjectDetails.hostageBodyIndex];

            string packFiles = "";
            string locName = "";
            string gender = "MALE";
            if (bodyInfo.isFemale)
                gender = "FEMALE";

            if (coreDetails.locationID == 10)
                locName = "AFGH";

            else if (coreDetails.locationID == 20)
                locName = "MAFR";

            if( questObjectDetails.walkerGears.Count > 0)
                packFiles += "\n\t\t\"/Assets/tpp/pack/mission2/common/mis_com_walkergear.fpk\",";

            if (questObjectDetails.hostages.Count > 0)
            {
                packFiles += "\n\t\t\"/Assets/tpp/pack/mission2/ih/ih_hostage_base.fpk\", ";
                packFiles += string.Format("\n\t\t\"{0}\", ", bodyInfo.missionPackPath);
            }

            packFiles += string.Format("\n\t\t\"/Assets/tpp/pack/mission2/quest/ih/{0}.fpk\", ", coreDetails.FpkName);

            if (questObjectDetails.hostages.Count > 0)
                if (!bodyInfo.hasface)
                    packFiles += string.Format("\n\t\trandomFaceListIH = {{gender = \"{0}\", count = {1}}}, ", gender, questObjectDetails.hostages.Count);

            string bodies = "";
            string faces = "";

            if (locName.Equals("AFGH") || locName.Equals("MAFR"))
            {
                if(EnemyInfo.balaCount > 0) { faces += string.Format("TppDefine.QUEST_FACE_ID_LIST.{0}_BALACLAVA, ", locName); }
                if(EnemyInfo.armorCount > 0) { bodies += string.Format("TppDefine.QUEST_BODY_ID_LIST.{0}_ARMOR, ", locName); }
            }

            foreach (string body in getEnemyBodies(questObjectDetails.cpEnemies))
                bodies += string.Format("TppEnemyBodyId.{0}, ", body);
            foreach (string body in getEnemyBodies(questObjectDetails.questEnemies))
                bodies += string.Format("TppEnemyBodyId.{0}, ", body);

            packFiles += string.Format("\n\t\tfaceIdList={{{0}}}, ", faces);
            packFiles += string.Format("\n\t\tbodyIdList={{{0}}}, ", bodies);

            string questPackList = string.Format("\tquestPackList = {{ {0} \n\t}},", packFiles);

            string locationInfo = string.Format("\tlocationId={0}, areaName=\"{1}\", iconPos=Vector3({2},{3},{4}), radius={5},", coreDetails.locationID, coreDetails.loadArea, coreDetails.coords.xCoord, coreDetails.coords.yCoord, coreDetails.coords.zCoord, coreDetails.radius);
            
            string progressLangId = string.Format("\tquestCompleteLangId=\"{0}\",", UpdateNotifsManager.getLangIds()[coreDetails.progNotif]);

            string canOpenQuestFunction = "\tcanOpenQuest=InfQuest.AllwaysOpenQuest, --function that decides whether the quest is open or not"; //todo in future update?

            string disableLzs = "\tdisableLzs={ }, --disables lzs while the quest is active. Turn on the debugMessages option and look in ih_log.txt for StartedMoveToLandingZone after calling in a support heli to find the lz name."; // todo in future update

            string equipIds = ""; List<string> requestHistory = new List<string>();

            foreach (Item item in questObjectDetails.items)
                if (item.item.Contains("EQP_WP_") && !requestHistory.Contains(item.item))
                {
                    equipIds += string.Format("\"{0}\", ", item.item);
                    requestHistory.Add(item.item);
                }
                    
            string requestEquipIds = string.Format("\trequestEquipIds={{ {0} }},", equipIds);
            
            string hasEnemyHeli = string.Format("\thasEnemyHeli = {0},", isAnyHeliSpawned(questObjectDetails.enemyHelicopters).ToString().ToLower());
            
            string DefinitionLuaPath = "Sideop_Build//GameDir//mod//quests//";
            string DefinitionLuaFile = Path.Combine(DefinitionLuaPath, string.Format("ih_quest_q{0}.lua", coreDetails.QuestNum));

            Directory.CreateDirectory(DefinitionLuaPath);

            using (StreamWriter defFile =
            new StreamWriter(DefinitionLuaFile))
            {
                defFile.WriteLine("local this={");
                defFile.WriteLine(questPackList);
                defFile.WriteLine(locationInfo);
                if (coreDetails.locationID == 50)
                    defFile.WriteLine(string.Format("\tclusterName=\"{0}\",", coreDetails.loadArea.Substring(4)));
                defFile.WriteLine(string.Format("\tcategory=TppQuest.QUEST_CATEGORIES_ENUM.{0},", coreDetails.category));
                defFile.WriteLine(progressLangId);
                defFile.WriteLine(canOpenQuestFunction);
                defFile.WriteLine(string.Format("\tquestRank=TppDefine.QUEST_RANK.{0},", coreDetails.reward));
                defFile.WriteLine(disableLzs);
                defFile.WriteLine(requestEquipIds);
                defFile.WriteLine(hasEnemyHeli);
                defFile.WriteLine("} return this");
            }
            */
        }

        public static void WriteMainQuestLua(CoreDetails coreDetails, MasterManager masterManager)
        {
            /*
            List<string> questLua = new List<string>(questLuaInput);

            questLua[GetLineOf("local hostageCount =", questLua)] = string.Format("local hostageCount = {0}", questObjects.hostages.Count);
            questLua[GetLineOf("local CPNAME =", questLua)] = string.Format("local CPNAME = \"{0}\"", coreDetails.CPName);
            questLua[GetLineOf("local useInter =", questLua)] = string.Format("local useInter = {0}", questObjects.canInter.ToString().ToLower());
            questLua[GetLineOf("local SUBTYPE =", questLua)] = string.Format("local SUBTYPE = \"{0}\"", questObjects.soldierSubType);
            questLua[GetLineOf("local questTrapName =", questLua)] = string.Format("local questTrapName = \"trap_preDeactiveQuestArea_{0}\"", coreDetails.loadArea);

            questLua[GetLineOf("local enemyQuestType =", questLua)] = string.Format("local enemyQuestType = {0}", questObjects.enemyObjectiveType);
            questLua[GetLineOf("local vehicleQuestType =", questLua)] = string.Format("local vehicleQuestType = {0}", questObjects.vehicleObjectiveType);
            questLua[GetLineOf("local hostageQuestType =", questLua)] = string.Format("local hostageQuestType = {0}", questObjects.hostageObjectiveType);
            questLua[GetLineOf("local animalQuestType =", questLua)] = string.Format("local animalQuestType = {0}", questObjects.animalObjectiveType);
            questLua[GetLineOf("local walkerQuestType =", questLua)] = string.Format("local walkerQuestType = {0}", questObjects.walkerGearObjectiveType);
            if (questObjects.activeItems.Count > 0)
                questLua[GetLineOf("local itemQuestType =", questLua)] = string.Format("local itemQuestType = {0}", questObjects.activeItemObjectiveType);
            else
                questLua[GetLineOf("local itemQuestType =", questLua)] = "local itemQuestType = RECOVERED";

            questLua[GetLineOf("isQuestArmor =", questLua)] = string.Format("	isQuestArmor =  {0},", (EnemyInfo.armorCount > 0).ToString().ToLower());
            questLua[GetLineOf("isQuestZombie =", questLua)] = string.Format("	isQuestZombie = {0},", (EnemyInfo.zombieCount > 0).ToString().ToLower());
            questLua[GetLineOf("isQuestBalaclava =", questLua)] = string.Format("	isQuestBalaclava = {0},", (EnemyInfo.balaCount > 0).ToString().ToLower());

            questLua.InsertRange(GetLineOf("enemyList = {", questLua) + 1, BuildEnemyList(questObjects));
            questLua.InsertRange(GetLineOf("vehicleList = {", questLua) + 1, BuildVehicleList(questObjects));
            questLua.InsertRange(GetLineOf("walkerList = {", questLua) + 1, BuildWalkerGearList(questObjects.walkerGears));
            questLua.InsertRange(GetLineOf("heliList = {", questLua) + 1, BuildHelicopterList(questObjects));
            questLua.InsertRange(GetLineOf("hostageList = {", questLua) + 1, BuildHostageList(questObjects));
            questLua.InsertRange(GetLineOf("animalList = {", questLua) + 1, BuildAnimalList(questObjects));
            questLua.InsertRange(GetLineOf("targetList = {", questLua) + 1, BuildTargetList(questObjects));
            questLua.InsertRange(GetLineOf("targetItemList = {", questLua) + 1, BuildItemTargetList(questObjects));
            questLua.InsertRange(GetLineOf("targetAnimalList = {", questLua) + 1, BuildAnimalTargetList(questObjects));
            questLua.InsertRange(GetLineOf("Hostage Attributes List", questLua) + 1, BuildHostageAttributes(questObjects));


            string LuaScriptPath = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd//Assets//tpp//level//mission2//quest//ih", coreDetails.FpkName);
            string LuaScriptFile = Path.Combine(LuaScriptPath, coreDetails.FpkName + ".lua");

            Directory.CreateDirectory(LuaScriptPath);
            File.WriteAllLines(LuaScriptFile, questLua);
            */
        }

        public static int GetLineOf(string text, List<string> questLua)
        {
            for (int i = 0; i < questLua.Count; i++)
                if (questLua[i].Contains(text))
                    return i;

            return -1;
        }
        /*
        public static List<string> getEnemyBodies(List<Enemy> enemyDetails)
        {
            List<string> bodyList = new List<string>();

            foreach (Enemy enemy in enemyDetails)
                if (!enemy.isArmored && !enemy.body.Equals("DEFAULT"))
                    if (!bodyList.Contains(enemy.body))
                        bodyList.Add(enemy.body);

            return bodyList;
        }

        public static List<string> BuildAnimalList(QuestEntities questDetails)
        {
            List<string> animalList = new List<string>();
            if (questDetails.animals.Count == 0)
                animalList.Add("        nil");
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

        public static List<string> BuildAnimalTargetList(QuestEntities questDetails)
        {
            List<string> animalTargetList = new List<string>();

            bool hasTarget = false;
            foreach (Animal animal in questDetails.animals)
                if (animal.isTarget)
                    hasTarget = true;

            animalTargetList.Add("	markerList = {");
            if (!hasTarget)
                animalTargetList.Add("      nil");
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
                animalTargetList.Add("      nil");
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

        public static List<string> BuildEnemyList(QuestEntities questDetails)
        {
            List<string> enemyList = new List<string>();

            List<Enemy> detailList = new List<Enemy>();
            detailList.AddRange(questDetails.questEnemies);
            detailList.AddRange(questDetails.cpEnemies);
            int enemyCount = 0;

            foreach (Enemy enemy in detailList)
            {

                string powerlist = "";
                if (!enemy.isSpawn)
                    continue;

                enemyCount++;
                enemyList.Add("		{");
                enemyList.Add(string.Format("			enemyName = \"{0}\",", enemy.name));
                uint unhashedRouteName;
                if (!enemy.dRoute.Equals("NONE"))
                {
                    if (uint.TryParse(enemy.dRoute, out unhashedRouteName))
                        enemyList.Add(string.Format("			route_d = {0},", unhashedRouteName));
                    else
                        enemyList.Add(string.Format("			route_d = \"{0}\",", enemy.dRoute));

                    if (uint.TryParse(enemy.cRoute, out unhashedRouteName))
                        enemyList.Add(string.Format("			route_c = {0},", unhashedRouteName));
                    else
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
                enemyList.Add("     nil");

            return enemyList;
        }

        public static List<string> BuildHelicopterList(QuestEntities questDetails)
        {
            List<string> heliList = new List<string>();

            if (!isAnyHeliSpawned(questDetails.enemyHelicopters))
                heliList.Add("       nil");
            else
                foreach (Helicopter heli in questDetails.enemyHelicopters)
                {
                    if (!heli.isSpawn)
                        continue;

                    heliList.Add("		{");

                    uint unhashedRouteName;
                    if (!heli.heliRoute.Equals("NONE"))
                    {
                        if (uint.TryParse(heli.heliRoute, out unhashedRouteName))
                            heliList.Add(string.Format("			routeName = {0},", unhashedRouteName));
                        else
                            heliList.Add(string.Format("			routeName = \"{0}\",", heli.heliRoute));
                    }

                    if (!heli.heliClass.Equals("DEFAULT"))
                        heliList.Add(string.Format("			coloringType = TppDefine.ENEMY_HELI_COLORING_TYPE.{0},", heli.heliClass));

                    heliList.Add("		},");
                }

            return heliList;
        }

        public static bool isAnyHeliSpawned(List<Helicopter> helicopters)
        {

            foreach (Helicopter helicopter in helicopters)
                if (helicopter.isSpawn)
                    return true;

            return false;
        }

        public static List<string> BuildHostageList(QuestEntities questDetails)
        {
            List<string> hostageList = new List<string>();

            BodyInfoEntry bodyInfo = new BodyInfoEntry();
            if (questDetails.hostageBodyIndex >= 0)
                bodyInfo = BodyInfo.BodyInfoArray[questDetails.hostageBodyIndex];

            if (questDetails.hostages.Count == 0)
                hostageList.Add("       nil");
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

        public static List<string> BuildWalkerGearList(List<WalkerGear> walkers)
        {
            List<string> walkerList = new List<string>();

            if (walkers.Count == 0)
                walkerList.Add("       nil");
            else
                foreach(WalkerGear walker in walkers)
                {
                    walkerList.Add("		{");
                    walkerList.Add(string.Format("			walkerName = \"{0}\",", walker.name));

                    if (!walker.rider.Equals("NONE"))
                        walkerList.Add(string.Format("			riderName = \"{0}\",", walker.rider));

                    walkerList.Add(string.Format("			colorType = {0},", walker.color));

                    walkerList.Add(string.Format("			primaryWeapon = {0},", walker.weapon));

                    double rotation = 0; Double.TryParse(walker.coordinates.roty, out rotation);
                    double toRadians = rotation * Math.PI / 180;

                    double yOffset = 0.0;
                    double.TryParse(walker.coordinates.yCoord, out yOffset);
                    yOffset += 0.783;

                    walkerList.Add(string.Format("			position={{pos={{{0},{1},{2}}},rotY={3},}},", walker.coordinates.xCoord, yOffset, walker.coordinates.zCoord, toRadians));

                    walkerList.Add("		},");
                }
            return walkerList;
        }

        public static List<string> BuildVehicleList(QuestEntities questDetails)
        {
            List<string> vehicleList = new List<string>();

            if (questDetails.vehicles.Count == 0)
                vehicleList.Add("       nil");
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

        public static List<string> BuildItemTargetList(QuestEntities questdetails)
        {
            int totalCount = 0;
            List<string> targetItemList = new List<string>();
            
            foreach (Item item in questdetails.items)
            {
                if (item.isTarget)
                {
                    totalCount++;
                    targetItemList.Add("		{");
                    targetItemList.Add(string.Format("		   equipId = TppEquip.{0},", item.item));
                    targetItemList.Add("		  messageId = \"None\",");
                    targetItemList.Add("		},");
                }
            }
            foreach (ActiveItem item in questdetails.activeItems)
            {
                if (item.isTarget)
                {
                    totalCount++;
                    targetItemList.Add("		{");
                    targetItemList.Add(string.Format("		  equipId = TppEquip.{0},", item.activeItem));
                    targetItemList.Add("		  messageId = \"None\",");
                    targetItemList.Add("		},");
                }
            }

            if (totalCount == 0)
                targetItemList.Add("        nil");

            return targetItemList;

        }

        public static List<string> BuildTargetList(QuestEntities questDetails)
        {
            int totalCount = 0;
            List<string> targetList = new List<string>();

            foreach(Enemy enemy in questDetails.questEnemies)
                if (enemy.isSpawn && enemy.isTarget)
                {
                    targetList.Add(string.Format("		\"{0}\",", enemy.name));
                    totalCount++;
                }

            foreach (Enemy enemy in questDetails.cpEnemies)
                if (enemy.isSpawn && enemy.isTarget)
                {
                    targetList.Add(string.Format("		\"{0}\",", enemy.name));
                    totalCount++;
                }

            foreach (Helicopter heli in questDetails.enemyHelicopters)
                if (heli.isSpawn && heli.isTarget)
                {
                    targetList.Add("		TppReinforceBlock.REINFORCE_HELI_NAME,");
                    totalCount++;
                }

            foreach(WalkerGear walker in questDetails.walkerGears)
                if (walker.isTarget)
                {
                    targetList.Add(string.Format("		\"{0}\",", walker.name));
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
                targetList.Add("        nil");

            return targetList;
        }

        public static List<string> BuildHostageAttributes(QuestEntities questDetails)
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
        */
    }
}
