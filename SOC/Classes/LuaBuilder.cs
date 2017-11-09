using SOC.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SOC.Classes
{
    static class LuaBuilder
    {

        static string[] questLuaInput = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "questScript.lua"));

        public static void WriteDefinitionLua(QuestDefinitionLua info, QuestDetails details, string gender)
        {
            
            string packFiles = "";
            string locName = "";

            if (info.locationID == 10)
                locName = "AFGH";

            else if (info.locationID == 20)
                locName = "MAFR";

            if (details.hostageDetails.Count > 0) //todo - better implementation
            {
                packFiles += "\n\t\t\"/Assets/tpp/pack/mission2/ih/ih_hostage_base.fpk\", ";
                if (gender.Equals("Male"))
                {
                    if (locName.Equals("AFGH")) //afgh male
                        packFiles += "\n\t\t\"/Assets/tpp/pack/mission2/ih/prs2_main0_mdl.fpk\", ";

                    else if (locName.Equals("MAFR")) //mafr male
                        packFiles += "\n\t\t\"/Assets/tpp/pack/mission2/ih/prs5_main0_mdl.fpk\", ";
                }
                else
                {
                    if (locName.Equals("AFGH")) // afgh female
                        packFiles += "\n\t\t\"/Assets/tpp/pack/mission2/ih/prs3_main0_mdl.fpk\", ";

                    else if (locName.Equals("MAFR")) // mafr female
                        packFiles += "\n\t\t\"/Assets/tpp/pack/mission2/ih/prs6_main0_mdl.fpk\", ";
                }

            }

            packFiles += string.Format("\n\t\t\"/Assets/tpp/pack/mission2/quest/ih/{0}.fpk\", ", info.FpkName);

            if (details.hostageDetails.Count > 0)
                packFiles += string.Format("\n\t\trandomFaceListIH = {{gender = \"{0}\", count = {1}}}, ", gender.ToUpper(), details.hostageDetails.Count);

            if (locName.Equals("AFGH") || locName.Equals("MAFR"))
                packFiles += string.Format("\n\t\tbodyIdList={{ TppDefine.QUEST_BODY_ID_LIST.{0}_ARMOR, }}, ", locName);

            string questPackList = string.Format("\tquestPackList = {{ {0} \n\t}},", packFiles);

            string locationInfo = string.Format("\tlocationId={0}, areaName=\"{1}\", iconPos=Vector3({2},{3},{4}), radius={5},", info.locationID, info.loadArea, info.coords.xCoord, info.coords.yCoord, info.coords.zCoord, info.radius);

            string progressLangId = string.Format("\tquestCompleteLangId=\"{0}\",", UI.Setup.UpdateNotifsList[info.progNotif * 2 + 1]);

            string canOpenQuestFunction = "\tcanOpenQuest=InfQuest.AllwaysOpenQuest, --function that decides whether the quest is open or not"; //todo in future update?

            string disableLzs = "\tdisableLzs={ }, --disables lzs while the quest is active. Turn on the debugMessages option and look in ih_log.txt for StartedMoveToLandingZone after calling in a support heli to find the lz name."; // todo in future update

            string equipIds = "";

            foreach (ItemDetail item in details.itemDetails)
                if (item.i_comboBox_item.Text.Contains("EQP_WP_"))
                    equipIds += string.Format("\"{0}\", ", item.i_comboBox_item.Text);

            string requestEquipIds = string.Format("\trequestEquipIds={{ {0} }},", equipIds);

            string hasEnemyHeli = "\thasEnemyHeli = false, --reserves an enemy helicopter for the sideop. set to true if the sideop has a heli.";
            

            string DefinitionLuaPath = "Sideop_Build//GameDir//mod//quests//";
            string DefinitionLuaFile = Path.Combine(DefinitionLuaPath, string.Format("ih_quest_q{0}.lua", info.QuestNum));

            Directory.CreateDirectory(DefinitionLuaPath);

            using (StreamWriter defFile =
            new StreamWriter(DefinitionLuaFile))
            {
                defFile.WriteLine("local this={");
                defFile.WriteLine(questPackList);
                defFile.WriteLine(locationInfo);
                defFile.WriteLine(string.Format("\tcategory=TppQuest.QUEST_CATEGORIES_ENUM.{0},", info.category));
                defFile.WriteLine(progressLangId);
                defFile.WriteLine(canOpenQuestFunction);
                defFile.WriteLine(string.Format("\tquestRank=TppDefine.QUEST_RANK.{0},", info.reward));
                defFile.WriteLine(disableLzs);
                defFile.WriteLine(requestEquipIds);
                defFile.WriteLine(hasEnemyHeli);
                defFile.WriteLine("} return this");
            }
        }

        public static void WriteMainQuestLua(QuestDefinitionLua definitionDetails, QuestDetails questDetails, bool enableInterogate, string gender)
        {
            List<string> questLua = new List<string>(questLuaInput);

            questLua[GetLineOf("local hostageCount =", questLua)] = string.Format("local hostageCount = {0}", questDetails.hostageDetails.Count);
            questLua[GetLineOf("local CPNAME =", questLua)] = string.Format("local CPNAME = \"{0}\"", definitionDetails.CPName); //add cp combobox to setup
            questLua[GetLineOf("local useInter =", questLua)] = string.Format("local useInter = {0}", enableInterogate.ToString().ToLower()); //add interogation checkbox to setup
            questLua[GetLineOf("local qType =", questLua)] = string.Format("local qType = TppDefine.QUEST_TYPE.{0}", definitionDetails.objectiveType); //add questtype combobox to setup

            questLua.InsertRange(GetLineOf("vehicleList = {", questLua) + 1, BuildVehicleList(questDetails));
            questLua.InsertRange(GetLineOf("hostageList = {", questLua) + 1, BuildHostageList(definitionDetails, questDetails, gender));
            questLua.InsertRange(GetLineOf("targetList = {", questLua) + 1, BuildTargetList(questDetails));
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

        public static List<string> BuildHostageList(QuestDefinitionLua definitionDetails, QuestDetails questDetails, string gender)
        {
            List<string> hostageList = new List<string>();

            string locName = "";

            if (definitionDetails.locationID == 10)
                locName = "AFGH";
            else if (definitionDetails.locationID == 20)
                locName = "MAFR";

            if (questDetails.hostageDetails.Count == 0)
                hostageList.Add("nil");
            else
                foreach (HostageDetail hostageDetail in questDetails.hostageDetails)
                {
                    hostageList.Add("		{");
                    hostageList.Add(string.Format("			hostageName = \"{0}\",", hostageDetail.h_groupBox_main.Text));
                    hostageList.Add("			isFaceRandom = true,");

                    if (hostageDetail.h_comboBox_lang.Text.Equals("english"))
                        hostageList.Add("			voiceType = { \"hostage_a\", \"hostage_b\", \"hostage_c\", \"hostage_d\",},");
                    else
                        hostageList.Add("			voiceType = { \"hostage_a\", \"hostage_b\", },");

                    hostageList.Add(string.Format("			langType = \"{0}\",", hostageDetail.h_comboBox_lang.Text));

                    if (!hostageDetail.h_comboBox_staff.Text.Equals("NONE"))
                        hostageList.Add(string.Format("			staffTypeId = TppDefine.STAFF_TYPE_ID.{0},", hostageDetail.h_comboBox_staff.Text));

                    if (!hostageDetail.h_comboBox_skill.Text.Equals("NONE"))
                        hostageList.Add(string.Format("			skill = \"{0}\",", hostageDetail.h_comboBox_skill.Text));

                    hostageList.Add(string.Format("			bodyId = TppDefine.QUEST_BODY_ID_LIST.{0}_HOSTAGE_{1},", locName.ToUpper(), gender.ToUpper())); // All gender/body related params seriously need a better implementation

                    hostageList.Add(string.Format("			position={{pos={{{0},{1},{2}}},rotY={3},}},", hostageDetail.h_textBox_xcoord.Text, hostageDetail.h_textBox_ycoord.Text, hostageDetail.h_textBox_zcoord.Text, hostageDetail.h_comboBox_rot.Text));

                    hostageList.Add("		},");
                }

            return hostageList;
        }

        public static List<string> BuildVehicleList(QuestDetails questDetails)
        {
            List<string> vehicleList = new List<string>();
            if (questDetails.vehicleDetails.Count == 0)
                vehicleList.Add("nil");
            else
                foreach (VehicleDetail vehicleDetail in questDetails.vehicleDetails)
                {
                    string vehicleName = QuestComponents.vehicleNames[vehicleDetail.v_comboBox_vehicle.SelectedIndex];
                    

                    vehicleList.Add("		{");
                    vehicleList.Add("			id = \"Spawn\",");
                    vehicleList.Add(string.Format("			locator = \"{0}\",", vehicleDetail.v_groupBox_main.Text));
                    
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


                    if (!vehicleDetail.v_comboBox_class.Text.Equals("DEFAULT"))
                        vehicleList.Add(string.Format("			class	= Vehicle.class.{0},", vehicleDetail.v_comboBox_class.Text));

                    vehicleList.Add(string.Format("			position={{pos={{{0},{1},{2}}},rotY={3},}},", vehicleDetail.v_textBox_xcoord.Text, vehicleDetail.v_textBox_ycoord.Text, vehicleDetail.v_textBox_zcoord.Text, vehicleDetail.v_comboBox_rot.Text));

                    vehicleList.Add("		},");
                }

            return vehicleList;
        }

        public static List<string> BuildTargetList(QuestDetails questDetails)
        {
            int totalCount = 0;
            List<string> targetList = new List<string>();

            foreach (HostageDetail hostage in questDetails.hostageDetails)
                if (hostage.h_checkBox_target.Checked)
                {
                    targetList.Add(string.Format("		\"{0}\",", hostage.h_groupBox_main.Text));
                    totalCount++;
                }

            foreach (VehicleDetail vehicle in questDetails.vehicleDetails)
                if (vehicle.v_checkBox_target.Checked)
                {
                    targetList.Add(string.Format("		\"{0}\",", vehicle.v_groupBox_main.Text));
                    totalCount++;
                }

            if (totalCount == 0)
                targetList.Add("nil");

            return targetList;
        }

        public static List<string> BuildHostageAttributes(QuestDetails questDetails)
        {
            List<string> hosAttributeList = new List<string>();

            foreach (HostageDetail hostage in questDetails.hostageDetails)
            {
                if (hostage.h_checkBox_untied.Checked)
                    hosAttributeList.Add(string.Format("GameObject.SendCommand(GameObject.GetGameObjectId(\"TppHostageUnique\", \"{0}\"),commandUnlocked)", hostage.h_groupBox_main.Text));

                if (hostage.h_checkBox_injured.Checked)
                    hosAttributeList.Add(string.Format("GameObject.SendCommand(GameObject.GetGameObjectId(\"TppHostageUnique\", \"{0}\"),commandInjured)", hostage.h_groupBox_main.Text));

                if (hostage.h_comboBox_scared.Text.Equals("NEVER")) //"NORMAL", "NEVER", "ALWAYS"
                    hosAttributeList.Add(string.Format("GameObject.SendCommand(GameObject.GetGameObjectId(\"TppHostageUnique\", \"{0}\"),commandBrave)", hostage.h_groupBox_main.Text));

                else if (hostage.h_comboBox_scared.Text.Equals("ALWAYS"))
                    hosAttributeList.Add(string.Format("GameObject.SendCommand(GameObject.GetGameObjectId(\"TppHostageUnique\", \"{0}\"),commandScared)", hostage.h_groupBox_main.Text));
            }

            return hosAttributeList;
        }

    }
}
