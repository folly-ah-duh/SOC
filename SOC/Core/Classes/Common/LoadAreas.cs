namespace SOC.Classes.Common
{
    static class LoadAreas
    {
        public static string[] afgh = {
            "tent",
            "field",
            "ruins",
            "waterway",
            "cliffTown",
            "commFacility",
            "sovietBase",
            "fort",
            "citadel"
        };

        public static string[] mafr = {
            "outland",
            "pfCamp",
            "savannah",
            "hill",
            "banana",
            "diamond",
            "lab"
        };

        public static string[] mtbs =  {
            "MtbsCommand",
            "MtbsCombat",
            "MtbsDevelop",
            "MtbsMedical",
            "MtbsSupport",
            "MtbsSpy",
            "MtbsBaseDev"
        };

        public static bool isAfgh(int locId)
        {
            return locId == 10;
        }

        public static bool isMafr(int locId)
        {
            return locId == 20;
        }

        public static bool isMtbs(int locId)
        {
            return locId == 50;
        }
    }
}
