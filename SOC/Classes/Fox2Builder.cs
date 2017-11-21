using SOC.QuestComponents;
using SOC.UI;
using System.Collections.Generic;
using System.IO;
using static SOC.QuestComponents.GameObjectInfo;
using static SOC.QuestComponents.Fox2Info;

namespace SOC.Classes
{

    public static class Fox2Builder
    {

        static string unassignedName = "";
        static int unassignedAddress = -1;  
        static object unnassignedObject = "";

        public static void SetAddresses(List<QuestEntity> QuestEntities, int baseOffset)
        {

            for (int i = 0; i < QuestEntities.Count; i++)
            {
                QuestEntities[i].hexAddress = baseOffset;
                baseOffset += Fox2Info.entityClassSizes[(int)QuestEntities[i].className];
            }
        }

        public static List<string> BuildDataList(List<QuestEntity> entityList)
        {
            List<string> dataList = new List<string>();

            foreach (QuestEntity entity in entityList)
            {
                if (!entity.entityName.Equals(unassignedName))
                {
                    dataList.Add(string.Format("			<value key=\"{0}\">0x{1:X8}</value>", entity.entityName, entity.hexAddress));
                }
            }

            return dataList;
        }

        public static List<QuestEntity> BuildQuestEntityList(QuestDetails questDetails)
        {
            string vehicleHistory = "";
            List<QuestEntity> entityList = new List<QuestEntity>();

            entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.DataSet, unnassignedObject, unnassignedObject));
            entityList.Add(new QuestEntity("ScriptBlockScript0000", unassignedAddress, entityClass.ScriptBlockScript, unnassignedObject, unnassignedObject));
            if (questDetails.hostageDetails.Count > 0)
            {
                entityList.Add(new QuestEntity("GameObjectTppHostageUnique", unassignedAddress, entityClass.GameObject, "TppHostageUnique", questDetails.hostageDetails.Count));
                entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TppHostage2Parameter, unnassignedObject, unnassignedObject));

                foreach (HostageDetail hostageDetail in questDetails.hostageDetails)
                {
                    entityList.Add(new QuestEntity(hostageDetail.h_groupBox_main.Text, unassignedAddress, entityClass.GameObjectLocator, "TppHostageUnique", unnassignedObject));
                    entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TransformEntity_Hostage, new Coordinates(hostageDetail.h_textBox_xcoord.Text,hostageDetail.h_textBox_ycoord.Text,hostageDetail.h_textBox_zcoord.Text), new RotationQuat("0","0","0","1")));
                    entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TppHostage2LocatorParameter, unnassignedObject, unnassignedObject));
                }
            }
                foreach(VehicleDetail vehicleDetail in questDetails.vehicleDetails)
                {
                entityList.Add(new QuestEntity(vehicleDetail.v_groupBox_main.Text, unassignedAddress, entityClass.GameObjectLocator, "TppVehicle2", unnassignedObject));
                entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TransformEntity_Vehicle, new Coordinates(vehicleDetail.v_textBox_xcoord.Text, vehicleDetail.v_textBox_ycoord.Text, vehicleDetail.v_textBox_zcoord.Text), new RotationQuat("0", "0", "0", "1")));
                entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TppVehicle2LocatorParameter, unnassignedObject, unnassignedObject));

                switch (vehicleDetail.v_comboBox_vehicle.Text)
                {
                    case "TT77 NOSOROG":
                        if (!vehicleHistory.Contains("veh_bd_east_tnk"))
                        {
                            entityList.Add(new QuestEntity("veh_bd_east_tnk", unassignedAddress, entityClass.TppVehicle2BodyData, unnassignedObject, unnassignedObject));
                            vehicleHistory += "veh_bd_east_tnk ";
                        }
                        break;
                    case "M84A MAGLOADER":
                        if (!vehicleHistory.Contains("veh_bd_west_tnk"))
                        {
                            entityList.Add(new QuestEntity("veh_bd_west_tnk", unassignedAddress, entityClass.TppVehicle2BodyData, unnassignedObject, unnassignedObject));
                            vehicleHistory += "veh_bd_west_tnk ";
                        }
                        break;
                    case "ZHUK BR-3":
                        if (!vehicleHistory.Contains("veh_bd_east_wav"))
                        {
                            entityList.Add(new QuestEntity("veh_bd_east_wav", unassignedAddress, entityClass.TppVehicle2BodyData, unnassignedObject, unnassignedObject));
                            vehicleHistory += "veh_bd_east_wav ";
                        }
                        break;
                    case "ZHUK RS-ZO":
                        if (!vehicleHistory.Contains("veh_bd_east_wav"))
                        {
                            entityList.Add(new QuestEntity("veh_bd_east_wav", unassignedAddress, entityClass.TppVehicle2BodyData, unnassignedObject, unnassignedObject));
                            vehicleHistory += "veh_bd_east_wav ";
                        }
                        if (!vehicleHistory.Contains("veh_at_east_wav_rocket"))
                        {
                            entityList.Add(new QuestEntity("veh_at_east_wav_rocket", unassignedAddress, entityClass.TppVehicle2AttachmentData, unnassignedObject, unnassignedObject));
                            vehicleHistory += "veh_at_east_wav_rocket ";
                        }
                        break;
                    case "STOUT IFV-SC":
                        if (!vehicleHistory.Contains("veh_bd_west_wav"))
                        {
                            entityList.Add(new QuestEntity("veh_bd_west_wav", unassignedAddress, entityClass.TppVehicle2BodyData, unnassignedObject, unnassignedObject));
                            vehicleHistory += "veh_bd_west_wav ";
                        }
                        if (!vehicleHistory.Contains("veh_at_west_wav_trt_machinegun"))
                        {
                            entityList.Add(new QuestEntity("veh_at_west_wav_trt_machinegun", unassignedAddress, entityClass.TppVehicle2AttachmentData, unnassignedObject, unnassignedObject));
                            vehicleHistory += "veh_at_west_wav_trt_machinegun ";
                        }
                        break;
                    case "STOUT IFV-FS":
                        if (!vehicleHistory.Contains("veh_bd_west_wav"))
                        {
                            entityList.Add(new QuestEntity("veh_bd_west_wav", unassignedAddress, entityClass.TppVehicle2BodyData, unnassignedObject, unnassignedObject));
                            vehicleHistory += "veh_bd_west_wav ";
                        }
                        if (!vehicleHistory.Contains("veh_at_west_wav_trt_cannon"))
                        {
                            entityList.Add(new QuestEntity("veh_at_west_wav_trt_cannon", unassignedAddress, entityClass.TppVehicle2AttachmentData, unnassignedObject, unnassignedObject));
                            vehicleHistory += "veh_at_west_wav_trt_cannon ";
                        }
                        break;
                }
            }

            foreach (ActiveItemDetail activeItemDetail in questDetails.activeItemDetails)
            {
                entityList.Add(new QuestEntity(activeItemDetail.ai_groupBox_main.Text, unassignedAddress, entityClass.GameObjectLocator, "TppPlacedSystem"));
                entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TransformEntity_ActiveItem, new Coordinates(activeItemDetail.ai_textBox_xcoord.Text, activeItemDetail.ai_textBox_ycoord.Text, activeItemDetail.ai_textBox_zcoord.Text), new RotationQuat(activeItemDetail.ai_textBox_xrot.Text, activeItemDetail.ai_textBox_yrot.Text, activeItemDetail.ai_textBox_zrot.Text, activeItemDetail.ai_textBox_wrot.Text)));

                string equipID = EquipIDLookup(activeItemDetail.ai_comboBox_activeitem.Text);

                entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TppPlacedLocatorParameter, equipID));
            }
            string animalhistory = "";
            foreach (AnimalDetail animalDetail in questDetails.animalDetails)
            {
                string animalName = animalDetail.a_comboBox_animal.Text, typeName = animalDetail.a_comboBox_TypeID.Text, animalCategory = AnimalInfo.getAnimalCategory(animalName);

                if (!animalhistory.Contains(animalName))
                {
                    animalhistory += animalName;
                    int totalCount = 0;

                    foreach (AnimalDetail animalScan in questDetails.animalDetails)
                    {
                        if (animalScan.a_comboBox_animal.Text.Equals(animalName))
                        {
                            totalCount += (int.Parse(animalScan.a_comboBox_count.Text));
                        }
                    }

                    string partsPath = "", mogPath = "", mtarPath = "", fv2Path = "";
                    AnimalInfo.getAnimalPaths(animalName , out partsPath, out mogPath, out mtarPath, out fv2Path);

                    entityList.Add(new QuestEntity(animalName + "GameObject", unassignedAddress, entityClass.GameObject, typeName, totalCount));
                    switch (animalCategory)
                    {
                        case "animal":
                            entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TppAnimalParameter, partsPath, mogPath, mtarPath, fv2Path));
                            break;
                        case "wolf":
                            entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TppWolfParameter, partsPath, mogPath, mtarPath, fv2Path));
                            break;
                        case "bear":
                            entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TppBearParameter, partsPath, mogPath, mtarPath, fv2Path));
                            break;
                    }
                }

                entityList.Add(new QuestEntity(animalDetail.a_groupBox_main.Text, unassignedAddress, entityClass.GameObjectLocator, typeName));
                entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TransformEntity_Animal, new Coordinates(animalDetail.a_textBox_xcoord.Text, animalDetail.a_textBox_ycoord.Text, animalDetail.a_textBox_zcoord.Text), new RotationQuat("0", "0", "0", "1")));
                switch (animalCategory)
                {
                    case "animal":
                        entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TppAnimalLocatorParameter, animalDetail.a_comboBox_count.Text));
                        break;
                    case "wolf":
                        entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TppWolfLocatorParameter, animalDetail.a_comboBox_count.Text));
                        break;
                    case "bear":
                        entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TppBearLocatorParameter, animalDetail.a_comboBox_count.Text));
                        break;
                }

            }
            
            foreach (ModelDetail modelDetail in questDetails.modelDetails)
            {
                entityList.Add(new QuestEntity(modelDetail.m_groupBox_main.Text, unassignedAddress, entityClass.StaticModel, modelDetail.m_comboBox_preset.Text, modelDetail.m_label_GeomNotFound.Visible));
                entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TransformEntity_StaticModel, new Coordinates(modelDetail.m_textBox_xcoords.Text, modelDetail.m_textBox_ycoords.Text, modelDetail.m_textBox_zcoords.Text), new RotationQuat(modelDetail.m_textBox_xrot.Text, modelDetail.m_textBox_yrot.Text, modelDetail.m_textBox_zrot.Text, modelDetail.m_textBox_wrot.Text)));
            }

            entityList.Add(new QuestEntity("TexturePackLoadConditioner0000", unassignedAddress, entityClass.TexturePackLoadConditioner, unnassignedObject, unnassignedObject));

            return entityList;
        }

        public static List<string> BuildQuestClassList(QuestDetails questDetails)
        {
            List<string> classList = new List<string>();

            classList.Add("    <class name=\"Entity\" super=\"\" version=\"2\" />");
            classList.Add("    <class name=\"Data\" super=\"Entity\" version=\"2\" />");
            classList.Add("    <class name=\"DataSet\" super=\"\" version=\"0\" />");
            classList.Add("    <class name=\"ScriptBlockScript\" super=\"\" version=\"0\" />");
            if (questDetails.hostageDetails.Count + questDetails.vehicleDetails.Count + questDetails.modelDetails.Count + questDetails.animalDetails.Count + questDetails.activeItemDetails.Count > 0)
            {
                classList.Add("    <class name=\"TransformEntity\" super=\"\" version=\"0\" />");
                if (questDetails.hostageDetails.Count + questDetails.vehicleDetails.Count + questDetails.animalDetails.Count + questDetails.activeItemDetails.Count > 0)
                {
                    classList.Add("    <class name=\"GameObjectLocator\" super=\"\" version=\"2\" />");
                    if (questDetails.hostageDetails.Count + questDetails.animalDetails.Count > 0)
                    {
                        classList.Add("    <class name=\"GameObject\" super=\"\" version=\"2\" />");
                    }
                }
            }
            if (questDetails.hostageDetails.Count > 0)
            {
                classList.Add("    <class name=\"TppHostage2Parameter\" super=\"\" version=\"1\" />");
                classList.Add("    <class name=\"TppHostage2LocatorParameter\" super=\"\" version=\"2\" />");
            }
            if (questDetails.vehicleDetails.Count > 0)
            {
                classList.Add("    <class name=\"TppVehicle2BodyData\" super=\"\" version=\"3\" />");
                classList.Add("    <class name=\"TppVehicle2LocatorParameter\" super=\"\" version=\"2\" />");
            }
            if (questDetails.modelDetails.Count > 0)
            {
                classList.Add("    <class name=\"StaticModel\" super=\"\" version=\"9\" />");
            }
            if (questDetails.activeItemDetails.Count > 0) {
                classList.Add("    <class name=\"TppPlacedLocatorParameter\" super=\"\" version=\"0\" />");
            }
            if (questDetails.animalDetails.Count > 0)
            {
                string animalHistory = "";
                string animalcat = "";
                foreach (AnimalDetail animalDetail in questDetails.animalDetails)
                {
                    animalcat = AnimalInfo.getAnimalCategory(animalDetail.a_comboBox_animal.Text);

                    if (!animalHistory.Contains(animalcat)) {
                        animalHistory += animalcat;
                        switch (animalcat)
                        {
                            case "animal":
                                classList.Add("    <class name=\"TppAnimalLocatorParameter\" super=\"\" version=\"1\" />");
                                classList.Add("    <class name=\"TppAnimalParameter\" super=\"\" version=\"1\" />");
                                break;
                            case "wolf":
                                classList.Add("    <class name=\"TppWolfLocatorParameter\" super=\"\" version=\"0\" />");
                                classList.Add("    <class name=\"TppWolfParameter\" super=\"\" version=\"1\" />");
                                break;
                            case "bear":
                                classList.Add("    <class name=\"TppBearLocatorParameter\" super=\"\" version=\"0\" />");
                                classList.Add("    <class name=\"TppBearParameter\" super=\"\" version=\"1\" />");
                                break;
                        }
                    }
                }

            }

            classList.Add("    <class name=\"TexturePackLoadConditioner\" super=\"\" version=\"0\" />");
            
            return classList;
        }

        public static void WriteQuestFox2(DefinitionDetails definitionDetails, QuestDetails questDetails)
        {
            List<QuestEntity> entityList = BuildQuestEntityList(questDetails);
            BodyInfoEntry bodyInfo = new BodyInfoEntry();
            if (questDetails.hostageBodyIndex >= 0)
                bodyInfo = BodyInfo.BodyInfoArray[questDetails.hostageBodyIndex];

            int baseAddress = baseQuestAddress;
            SetAddresses(entityList, baseAddress);

            string fox2Path = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd//Assets//tpp//level//mission2//quest//ih", definitionDetails.FpkName);
            string fox2QuestFile = Path.Combine(fox2Path, string.Format("{0}.fox2.xml", definitionDetails.FpkName));

            Directory.CreateDirectory(fox2Path);
            using (System.IO.StreamWriter questFox2 =
            new System.IO.StreamWriter(fox2QuestFile))
            {
                questFox2.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                questFox2.WriteLine("<fox formatVersion=\"2\" fileVersion=\"0\" originalVersion=\"Sun Mar 16 00:00:00 UTC-05:00 1975\">");
                questFox2.WriteLine("  <classes>");
                
                foreach (string value in BuildQuestClassList(questDetails))
                {
                    questFox2.WriteLine(value);
                }

                questFox2.WriteLine("  </classes>");
                questFox2.WriteLine("  <entities>");
                for(int i = 0; i < entityList.Count; i++)
                {
                    QuestEntity entity = entityList[i];

                    switch(entity.className)
                    {
                        case entityClass.DataSet:
                            questFox2.WriteLine(string.Format("    <entity class=\"DataSet\" classVersion=\"0\" addr=\"0x{0:X8}\" unknown1=\"232\" unknown2=\"29239\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"name\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value></value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"dataSet\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0x00000000</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine(string.Format("        <property name=\"dataList\" type=\"EntityPtr\" container=\"StringMap\" arraySize=\"{0}\">", BuildDataList(entityList).Count));
                            foreach(string value in BuildDataList(entityList))
                            {
                                questFox2.WriteLine(value);
                            }
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.ScriptBlockScript:
                            questFox2.WriteLine(string.Format("    <entity class=\"ScriptBlockScript\" classVersion=\"0\" addr=\"0x{0:X8}\" unknown1=\"88\" unknown2=\"29241\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"name\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.entityName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"dataSet\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", baseAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"script\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>/Assets/tpp/level/mission2/quest/ih/{0}.lua</value>", definitionDetails.FpkName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.GameObject:
                            questFox2.WriteLine(string.Format("    <entity class=\"GameObject\" classVersion=\"2\" addr=\"0x{0:X8}\" unknown1=\"88\" unknown2=\"29243\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"name\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.entityName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"dataSet\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", baseAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"typeName\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info1));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"groupId\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"totalCount\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">"); 
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info2));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"realizedCount\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info2));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"parameters\" type=\"EntityPtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i + 1].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TppHostage2Parameter:
                            questFox2.WriteLine(string.Format("    <entity class=\"TppHostage2Parameter\" classVersion=\"1\" addr=\"0x{0:X8}\" unknown1=\"176\" unknown2=\"29245\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 1].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"partsFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", bodyInfo.partsPath));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"motionGraphFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>/Assets/tpp/motion/motion_graph/hostage2/Hostage2_layers.mog</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"mtarFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>/Assets/tpp/motion/mtar/hostage2/Hostage2_layers.mtar</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"extensionMtarFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value></value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"vfxFiles\" type=\"FilePtr\" container=\"StringMap\" />");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.GameObjectLocator:
                            questFox2.WriteLine(string.Format("    <entity class=\"GameObjectLocator\" classVersion=\"2\" addr=\"0x{0:X8}\" unknown1=\"272\" unknown2=\"29247\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"name\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("         <value>{0}</value>", entity.entityName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"dataSet\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", baseAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"parent\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0x00000000</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"transform\" type=\"EntityPtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i+1].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"shearTransform\" type=\"EntityPtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0x00000000</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"pivotTransform\" type=\"EntityPtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0x00000000</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"children\" type=\"EntityHandle\" container=\"List\" />");
                            questFox2.WriteLine("        <property name=\"flags\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>7</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"typeName\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info1));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"groupId\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"parameters\" type=\"EntityPtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i + 2].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TransformEntity_Hostage:
                        case entityClass.TransformEntity_StaticModel:
                        case entityClass.TransformEntity_Vehicle:
                        case entityClass.TransformEntity_ActiveItem:
                        case entityClass.TransformEntity_Animal:
                            questFox2.WriteLine(string.Format("    <entity class=\"TransformEntity\" classVersion=\"0\" addr=\"0x{0:X8}\" unknown1=\"80\" unknown2=\"29250\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 1].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"transform_scale\" type=\"Vector3\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value x=\"1\" y=\"1\" z=\"1\" w=\"0\" />");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"transform_rotation_quat\" type=\"Quat\" container=\"StaticArray\" arraySize=\"1\">");
                            RotationQuat entityrot = (RotationQuat)entity.info2;
                            questFox2.WriteLine(string.Format("          <value x=\"{0}\" y=\"{1}\" z=\"{2}\" w=\"{3}\" />", entityrot.xval, entityrot.yval, entityrot.zval, entityrot.wval));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"transform_translation\" type=\"Vector3\" container=\"StaticArray\" arraySize=\"1\">");
                            Coordinates entityCoords = (Coordinates)entity.info1;
                            questFox2.WriteLine(string.Format("          <value x = \"{0}\" y = \"{1}\" z = \"{2}\" w = \"0\" />", entityCoords.xCoord, entityCoords.yCoord, entityCoords.zCoord));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TppHostage2LocatorParameter:
                            questFox2.WriteLine(string.Format("    <entity class=\"TppHostage2LocatorParameter\" classVersion=\"0\" addr=\"0x{0:X8}\" unknown1=\"32\" unknown2=\"29254\">",entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 2].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"identifier\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value></value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TppVehicle2LocatorParameter:
                            questFox2.WriteLine(string.Format("    <entity class=\"TppVehicle2LocatorParameter\" classVersion=\"2\" addr=\"0x{0:X8}\" unknown1=\"28\" unknown2=\"245793\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 2].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TppVehicle2BodyData:
                            Vehicle2Body bodyData = new Vehicle2Body(entity.entityName);
                            questFox2.WriteLine(string.Format("<entity class=\"TppVehicle2BodyData\" classVersion=\"3\" addr=\"0x{0:X8}\" unknown1=\"128\" unknown2=\"547300\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"name\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.entityName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"dataSet\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", baseAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"vehicleTypeIndex\" type=\"uint8\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", bodyData.TypeIndex));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"proxyVehicleTypeIndex\" type=\"uint8\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", bodyData.TypeIndex));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"bodyImplTypeIndex\" type=\"uint8\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", bodyData.ImplTypeIndex));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"partsFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", bodyData.partsFileName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"bodyInstanceCount\" type=\"uint8\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>2</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"weaponParams\" type=\"EntityPtr\" container=\"DynamicArray\" />");
                            questFox2.WriteLine("        <property name=\"fovaFiles\" type=\"FilePtr\" container=\"DynamicArray\" />");
                            questFox2.WriteLine("        </staticProperties>");
                            questFox2.WriteLine("        <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TppVehicle2AttachmentData:
                            Vehicle2Attachment attachData = new Vehicle2Attachment(entity.entityName);
                            questFox2.WriteLine(string.Format("<entity class=\"TppVehicle2AttachmentData\" classVersion=\"1\" addr=\"0x{0:X8}\" unknown1=\"120\" unknown2=\"356482\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"name\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.entityName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"dataSet\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", baseAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"vehicleTypeCode\" type=\"uint8\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", attachData.typeCode));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"attachmentImplTypeIndex\" type=\"uint8\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", attachData.ImplTypeIndex));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"attachmentFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", attachData.partsFileName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"attachmentInstanceCount\" type=\"uint8\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", attachData.instanceCount));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"bodyCnpName\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", attachData.CnpName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"attachmentBoneName\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value></value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"weaponParams\" type=\"EntityPtr\" container=\"DynamicArray\" />");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.StaticModel:
                            questFox2.WriteLine(string.Format(" <entity class=\"StaticModel\" classVersion=\"9\" addr=\"0x{0:X8}\" unknown1=\"352\" unknown2=\"548876795\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"name\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.entityName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"dataSet\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", baseAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"parent\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0x00000000</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"transform\" type=\"EntityPtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i + 1].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"shearTransform\" type=\"EntityPtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0x00000000</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"pivotTransform\" type=\"EntityPtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0x00000000</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"children\" type=\"EntityHandle\" container=\"List\" />");
                            questFox2.WriteLine("        <property name=\"flags\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>7</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"modelFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>/Assets/{0}.fmdl</value>", entity.info1));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"geomFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            if ((bool)entity.info2)
                                questFox2.WriteLine(string.Format("          <value></value>", entity.info1));
                            else
                                questFox2.WriteLine(string.Format("          <value>/Assets/{0}.geom</value>", entity.info1));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"isVisibleGeom\" type=\"bool\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>false</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"isIsolated\" type=\"bool\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>false</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"lodFarSize\" type=\"float\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>-1</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"lodNearSize\" type=\"float\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>-1</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"lodPolygonSize\" type=\"float\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>-1</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"color\" type=\"Color\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value r=\"1\" g=\"1\" b=\"1\" a=\"1\" />");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"drawRejectionLevel\" type=\"int32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>8</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"drawMode\" type=\"int32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"rejectFarRangeShadowCast\" type=\"int32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>2</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TppPlacedLocatorParameter:
                            questFox2.WriteLine(string.Format("    <entity class=\"TppPlacedLocatorParameter\" classVersion=\"0\" addr=\"0x{0:X8}\" unknown1=\"32\" unknown2=\"5408\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 2].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"equipIdStrCode32\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info1));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;
                            
                        case entityClass.TppAnimalParameter:
                            questFox2.WriteLine(string.Format("	<entity class=\"TppAnimalParameter\" classVersion=\"1\" addr=\"0x{0:X8}\" unknown1=\"168\" unknown2=\"54088\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 1].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"partsFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info1));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"motionGraphFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info2));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"mtarFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info3));
                            questFox2.WriteLine("        </property>");
                            if (!entity.info4.Equals(""))
                            {
                                questFox2.WriteLine("        <property name=\"fovaFiles\" type=\"FilePtr\" container=\"DynamicArray\" arraySize=\"1\">");
                                questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info4));
                                questFox2.WriteLine("        </property>");
                            }
                            else
                            {
                                questFox2.WriteLine("        <property name = \"fovaFiles\" type = \"FilePtr\" container = \"DynamicArray\" />");
                            }
                            questFox2.WriteLine("        <property name=\"vfxFiles\" type=\"FilePtr\" container=\"StringMap\" />");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TppWolfParameter:
                            questFox2.WriteLine(string.Format("	<entity class=\"TppWolfParameter\" classVersion=\"1\" addr=\"0x{0:X8}\" unknown1=\"120\" unknown2=\"4763150\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 1].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"partsFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info1));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"mtarFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info2));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"mogFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info3));
                            questFox2.WriteLine("        </property>");
                            if (!entity.info4.Equals("")) {
                                questFox2.WriteLine("        <property name=\"fovaFiles\" type=\"FilePtr\" container=\"DynamicArray\" arraySize=\"1\">");
                                questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info4));
                                questFox2.WriteLine("        </property>");
                            }
                            else
                            {
                                questFox2.WriteLine("        <property name=\"fovaFiles\" type=\"FilePtr\" container=\"DynamicArray\" />");
                            }
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TppBearParameter:
                            questFox2.WriteLine(string.Format("	<entity class=\"TppBearParameter\" classVersion=\"1\" addr=\"0x{0:X8}\" unknown1=\"120\" unknown2=\"8422681\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 1].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"partsFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info1));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"mtarFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info2));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"mogFile\" type=\"FilePtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info3));
                            questFox2.WriteLine("        </property>");
                            if (!entity.info4.Equals(""))
                            {
                                questFox2.WriteLine("        <property name=\"fovaFiles\" type=\"FilePtr\" container=\"DynamicArray\" arraySize=\"1\">");
                                questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info4)); //if
                                questFox2.WriteLine("        </property>");
                            }
                            else
                            {
                                questFox2.WriteLine("        <property name = \"fovaFiles\" type = \"FilePtr\" container = \"DynamicArray\" />");
                            }
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TppAnimalLocatorParameter:
                            questFox2.WriteLine(string.Format("	<entity class=\"TppAnimalLocatorParameter\" classVersion=\"1\" addr=\"0x{0:X8}\" unknown1=\"40\" unknown2=\"54084\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 2].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"count\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info1));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"radius\" type=\"float\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>30</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TppWolfLocatorParameter:
                            questFox2.WriteLine(string.Format("	<entity class=\"TppWolfLocatorParameter\" classVersion=\"0\" addr=\"0x{0:X8}\" unknown1=\"40\" unknown2=\"4763161\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 2].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"count\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info1));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"radius\" type=\"uint8\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>50</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TppBearLocatorParameter:
                            questFox2.WriteLine(string.Format("	<entity class=\"TppBearLocatorParameter\" classVersion=\"0\" addr=\"0x{0:X8}\" unknown1=\"40\" unknown2=\"8422629\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 2].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"count\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info1));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"radius\" type=\"uint8\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>40</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;
                            
                        case entityClass.TexturePackLoadConditioner:
                            questFox2.WriteLine(string.Format("    <entity class=\"TexturePackLoadConditioner\" classVersion=\"0\" addr=\"0x{0:X8}\" unknown1=\"72\" unknown2=\"0\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"name\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.entityName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"dataSet\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", baseAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"texturePackPath\" type=\"Path\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value></value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;
                    }
                    
                }
                questFox2.WriteLine("  </entities>");
                questFox2.WriteLine("</fox>");
                
            }
        }

        public static List<QuestEntity> BuildItemEntityList(QuestDetails questDetails)
        {
            List<QuestEntity> entityList = new List<QuestEntity>();
            string boxed = "";
            string EquipID = "";
            entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.DataSet, unnassignedObject, unnassignedObject));

            foreach (ItemDetail itemDetail in questDetails.itemDetails)
            {

                entityList.Add(new QuestEntity(itemDetail.i_groupBox_main.Text, unassignedAddress, entityClass.GameObjectLocator_Item, unnassignedObject, unnassignedObject));
                entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TransformEntity_Item, new Coordinates(itemDetail.i_textBox_xcoord.Text, itemDetail.i_textBox_ycoord.Text, itemDetail.i_textBox_zcoord.Text), new RotationQuat(itemDetail.i_textBox_xrot.Text, itemDetail.i_textBox_yrot.Text, itemDetail.i_textBox_zrot.Text, itemDetail.i_textBox_wrot.Text)));

                boxed = "0";
                if (itemDetail.i_checkBox_boxed.Checked)
                {
                    boxed = "1";
                }

                EquipID = EquipIDLookup(itemDetail.i_comboBox_item.Text);

                entityList.Add(new QuestEntity(unassignedName, unassignedAddress, entityClass.TppPickableLocatorParameter, EquipID, itemDetail.i_comboBox_count.Text, boxed));
            }

            entityList.Add(new QuestEntity("TexturePackLoadConditioner0000", unassignedAddress, entityClass.TexturePackLoadConditioner, unnassignedObject, unnassignedObject));

            return entityList;
        }

        public static List<string> BuildItemClassList(QuestDetails questDetails)
        {
            List<string> classList = new List<string>();

            classList.Add("    <class name=\"Entity\" super=\"\" version=\"2\" />");
            classList.Add("    <class name=\"Data\" super=\"Entity\" version=\"2\" />");
            classList.Add("    <class name=\"DataSet\" super=\"\" version=\"0\" />");
            if (questDetails.itemDetails.Count > 0)
            {
                classList.Add("    <class name=\"TransformEntity\" super=\"\" version=\"0\" />");
                classList.Add("    <class name=\"GameObjectLocator\" super=\"\" version=\"2\" />");
                classList.Add("    <class name=\"TppPickableLocatorParameter\" super=\"\" version=\"0\" />");
            }
            classList.Add("    <class name=\"TexturePackLoadConditioner\" super=\"\" version=\"0\" />");

            return classList;
        }

        public static void WriteItemFox2(DefinitionDetails definitionDetails, QuestDetails questDetails)
        {
            int baseAddress = baseItemAddress;

            List<QuestEntity> entityList = BuildItemEntityList(questDetails);
            SetAddresses(entityList, baseAddress);

            string fox2Path = string.Format("Sideop_Build//Assets//tpp//pack//mission2//quest//ih//{0}_fpkd//Assets//tpp//level//mission2//quest//ih", definitionDetails.FpkName);
            string fox2ItemFile = Path.Combine(fox2Path, string.Format("{0}_items.fox2.xml", definitionDetails.FpkName));

            Directory.CreateDirectory(fox2Path);
            using (System.IO.StreamWriter questFox2 =
            new System.IO.StreamWriter(fox2ItemFile))
            {
                questFox2.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                questFox2.WriteLine("<fox formatVersion=\"2\" fileVersion=\"0\" originalVersion=\"Sun Mar 16 00:00:00 UTC-05:00 1975\">");
                questFox2.WriteLine("  <classes>");

                foreach (string value in BuildItemClassList(questDetails))
                {
                    questFox2.WriteLine(value);
                }

                questFox2.WriteLine("  </classes>");
                questFox2.WriteLine("  <entities>");
                for (int i = 0; i < entityList.Count; i++)
                {
                    QuestEntity entity = entityList[i];

                    switch (entity.className)
                    {
                        case entityClass.DataSet:
                            questFox2.WriteLine(string.Format("    <entity class=\"DataSet\" classVersion=\"0\" addr=\"0x{0:X8}\" unknown1=\"232\" unknown2=\"29239\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"name\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value></value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"dataSet\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0x00000000</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine(string.Format("        <property name=\"dataList\" type=\"EntityPtr\" container=\"StringMap\" arraySize=\"{0}\">", BuildDataList(entityList).Count));
                            foreach (string value in BuildDataList(entityList))
                            {
                                questFox2.WriteLine(value);
                            }
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.GameObjectLocator_Item:
                            questFox2.WriteLine(string.Format("    <entity class=\"GameObjectLocator\" classVersion=\"2\" addr=\"0x{0:X8}\" unknown1=\"272\" unknown2=\"29247\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"name\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("         <value>{0}</value>", entity.entityName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"dataSet\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", baseAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"parent\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0x00000000</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"transform\" type=\"EntityPtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i + 1].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"shearTransform\" type=\"EntityPtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0x00000000</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"pivotTransform\" type=\"EntityPtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0x00000000</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"children\" type=\"EntityHandle\" container=\"List\" />");
                            questFox2.WriteLine("        <property name=\"flags\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>7</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"typeName\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>TppPickableSystem</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"groupId\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"parameters\" type=\"EntityPtr\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i + 2].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TransformEntity_Item:
                            questFox2.WriteLine(string.Format("    <entity class=\"TransformEntity\" classVersion=\"0\" addr=\"0x{0:X8}\" unknown1=\"80\" unknown2=\"29250\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 1].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"transform_scale\" type=\"Vector3\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value x=\"1\" y=\"1\" z=\"1\" w=\"0\" />");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"transform_rotation_quat\" type=\"Quat\" container=\"StaticArray\" arraySize=\"1\">");
                            RotationQuat entityrot = (RotationQuat)entity.info2;
                            questFox2.WriteLine(string.Format("          <value x=\"{0}\" y=\"{1}\" z=\"{2}\" w=\"{3}\" />", entityrot.xval, entityrot.yval, entityrot.zval, entityrot.wval));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"transform_translation\" type=\"Vector3\" container=\"StaticArray\" arraySize=\"1\">");
                            Coordinates entityCoords = (Coordinates)entity.info1;
                            questFox2.WriteLine(string.Format("          <value x = \"{0}\" y = \"{1}\" z = \"{2}\" w = \"0\" />", entityCoords.xCoord, entityCoords.yCoord, entityCoords.zCoord));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TppPickableLocatorParameter:
                            questFox2.WriteLine(string.Format("	<entity class=\"TppPickableLocatorParameter\" classVersion=\"0\" addr=\"0x{0:X8}\" unknown1=\"40\" unknown2=\"17661759\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"owner\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", entityList[i - 2].hexAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"equipIdStrCode32\" type=\"uint32\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info1));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"countRaw\" type=\"uint16\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info2));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"countSubRaw\" type=\"uint16\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"flag\" type=\"uint16\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.info3));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"reserved\" type=\"uint16\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value>0</value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;

                        case entityClass.TexturePackLoadConditioner:
                            questFox2.WriteLine(string.Format("    <entity class=\"TexturePackLoadConditioner\" classVersion=\"0\" addr=\"0x{0:X8}\" unknown1=\"72\" unknown2=\"0\">", entity.hexAddress));
                            questFox2.WriteLine("      <staticProperties>");
                            questFox2.WriteLine("        <property name=\"name\" type=\"String\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>{0}</value>", entity.entityName));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"dataSet\" type=\"EntityHandle\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine(string.Format("          <value>0x{0:X8}</value>", baseAddress));
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("        <property name=\"texturePackPath\" type=\"Path\" container=\"StaticArray\" arraySize=\"1\">");
                            questFox2.WriteLine("          <value></value>");
                            questFox2.WriteLine("        </property>");
                            questFox2.WriteLine("      </staticProperties>");
                            questFox2.WriteLine("      <dynamicProperties />");
                            questFox2.WriteLine("    </entity>");
                            break;
                    }

                }
                questFox2.WriteLine("  </entities>");
                questFox2.WriteLine("</fox>");

            }
        }

    }
}
