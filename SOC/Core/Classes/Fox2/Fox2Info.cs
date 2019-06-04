using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace SOC.Classes.Fox2
{
    public static class Fox2Info
    {
        public const uint baseQuestAddress = 0x02D7BCA0;
        public const uint baseItemAddress = 0x10000000;

        public const uint entityClassSize = 0x70;

        public static string FoxToolPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//ToolAssets//FoxTool.exe");

        public static void CompileFile(string toolArg, string ToolPath)
        {
            Process compileProcess = new Process();
            compileProcess.StartInfo.FileName = ToolPath;
            compileProcess.StartInfo.Arguments = toolArg;
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.StartInfo.CreateNoWindow = true;
            compileProcess.Start();
            compileProcess.WaitForExit();
        }

    }

    public enum entityClass
    {
        UNASSIGNED,
        DataSet,
        ScriptBlockScript,
        GameObject,
        TppHostage2Parameter,
        GameObjectLocator,
        TransformEntity,
        TppHostage2LocatorParameter,
        TppVehicle2AttachmentData,
        TppVehicle2LocatorParameter,
        TppVehicle2BodyData,
        TppPickableLocatorParameter,
        StaticModel,
        TexturePackLoadConditioner,
        TppPlacedLocatorParameter,
        TppBearParameter,
        TppBearLocatorParameter,
        TppWolfParameter,
        TppWolfLocatorParameter,
        TppAnimalParameter,
        TppAnimalLocatorParameter,
        TppWalkerGear2Parameter,
        TppWalkerGear2LocatorParameter

    }

    public class QuestEntity
    {

        public string name { get; set; }

        public int hexAddress { get; set; }

        public entityClass className { get; set; }

        public object[] details { get; set; }

        public QuestEntity(entityClass cName = entityClass.UNASSIGNED, string eName = "", params object[] eDetails)
        {
            name = eName;
            hexAddress = -1;
            className = cName;
            details = eDetails;
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
