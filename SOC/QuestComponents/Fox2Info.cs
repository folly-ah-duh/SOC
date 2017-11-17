namespace SOC.QuestComponents
{
    public static class Fox2Info
    {
        public const int baseQuestAddress = 0x02D7BCA0;
        public const int baseItemAddress = 0x10000000;

        public static int[] entityClassSizes =
        {
            0x0,
            0x70,
            0x70,
            0x70,
            0x70,
            0x70,
            0xE0,
            0x70,
            0xE0,
            0x70,
            0x70,
            0x150,
            0x1,
            0xE,
            0x70,
            0x150,
            0x0,
            0x1,
            0xE,
            0x70,
            0x70,
            0x70,
            0x70,
            0x70,
            0x70,
            0x70,
            0x150,
        };
    }

    public enum entityClass
    {
        UNASSIGNED,
        DataSet,
        ScriptBlockScript,
        GameObject,
        TppHostage2Parameter,
        GameObjectLocator,
        TransformEntity_Hostage,
        TppHostage2LocatorParameter,
        TppVehicle2AttachmentData,
        TppVehicle2LocatorParameter,
        TppVehicle2BodyData,
        TransformEntity_Vehicle,
        TransformEntity_Item,
        TppPickableLocatorParameter,
        StaticModel,
        TransformEntity_StaticModel,
        TexturePackLoadConditioner,
        GameObjectLocator_Item,
        TransformEntity_ActiveItem,
        TppPlacedLocatorParameter,
        TppBearParameter,
        TppBearLocatorParameter, 
        TppWolfParameter,
        TppWolfLocatorParameter, 
        TppAnimalParameter, 
        TppAnimalLocatorParameter,
        TransformEntity_Animal

    }


    public class QuestEntity
    {

        public string entityName { get; set; }

        public int hexAddress { get; set; }

        public entityClass className { get; set; }

        public object info1 { get; set; }

        public object info2 { get; set; }

        public object info3 { get; set; }

        public object info4 { get; set; }

        public QuestEntity(string ename, int address, entityClass cname)
        {
            entityName = ename;
            hexAddress = address;
            className = cname;
        }
        public QuestEntity(string ename, int address, entityClass cname, object inf1)
        {
            entityName = ename;
            hexAddress = address;
            className = cname;
            info1 = inf1;
        }
        public QuestEntity(string ename, int address, entityClass cname, object inf1, object inf2)
        {
            entityName = ename;
            hexAddress = address;
            className = cname;
            info1 = inf1;
            info2 = inf2;
        }

        public QuestEntity(string ename, int address, entityClass cname, object inf1, object inf2, object inf3)
        {
            entityName = ename;
            hexAddress = address;
            className = cname;
            info1 = inf1;
            info2 = inf2;
            info3 = inf3;
        }

        public QuestEntity(string ename, int address, entityClass cname, object inf1, object inf2, object inf3, object inf4)
        {
            entityName = ename;
            hexAddress = address;
            className = cname;
            info1 = inf1;
            info2 = inf2;
            info3 = inf3;
            info4 = inf4;
        }
    }

    public class Vehicle2Body
    {
        public string vehicleType { get; set; }

        public int TypeIndex { get; set; }

        public int ImplTypeIndex { get; set; }

        public string partsFileName { get; set; }

        public Vehicle2Body(string name)
        {
            vehicleType = name;
            switch (name)
            {
                case "veh_bd_east_tnk":
                    TypeIndex = 8;
                    ImplTypeIndex = 5;
                    partsFileName = "/Assets/tpp/parts/mecha/mbt/mbt0_main0_def.parts";
                    break;
                case "veh_bd_west_tnk":
                    TypeIndex = 7;
                    ImplTypeIndex = 5;
                    partsFileName = "/Assets/tpp/parts/mecha/nbt/nbt0_main0_def.parts";
                    break;
                case "veh_bd_east_wav":
                    TypeIndex = 6;
                    ImplTypeIndex = 3;
                    partsFileName = "/Assets/tpp/parts/mecha/sav/sav0_main0_def.parts";
                    break;
                case "veh_bd_west_wav":
                    TypeIndex = 5;
                    ImplTypeIndex = 4;
                    partsFileName = "/Assets/tpp/parts/mecha/wav/wav0_main0_def.parts";
                    break;
            }
        }
    }
    public class Vehicle2Attachment
    {
        public string attachmentType { get; set; }

        public int typeCode { get; set; }

        public int ImplTypeIndex { get; set; }

        public int instanceCount { get; set; }

        public string partsFileName { get; set; }

        public string CnpName { get; set; }

        public Vehicle2Attachment(string name)
        {
            attachmentType = name;
            switch (name)
            {
                case "veh_at_east_wav_rocket":
                    typeCode = 97;
                    ImplTypeIndex = 4;
                    partsFileName = "/Assets/tpp/parts/mecha/sav/sav0_wepn0_def.parts";
                    instanceCount = 2;
                    CnpName = "CNP_weapon";
                    break;
                case "veh_at_west_wav_trt_machinegun":
                    typeCode = 81;
                    ImplTypeIndex = 2;
                    partsFileName = "/Assets/tpp/parts/mecha/wav/wav0_turt1_def.parts";
                    instanceCount = 1;
                    CnpName = "CNP_TURRET";
                    break;
                case "veh_at_west_wav_trt_cannon":
                    typeCode = 82;
                    ImplTypeIndex = 3;
                    partsFileName = "/Assets/tpp/parts/mecha/wav/wav0_turt0_def.parts";
                    instanceCount = 2;
                    CnpName = "CNP_TURRET";
                    break;
            }
        }

    }

}
