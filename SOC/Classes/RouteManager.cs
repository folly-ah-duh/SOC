using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FoxLib.Tpp.RouteSet;

namespace SOC.Classes
{
    class RouteManager
    {

        public static string RouteNameDictionaryFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "assets\\ToolAssets\\route_name_dictionary.txt");
        public static Dictionary<uint, string> RouteNameHashDictionary = new Dictionary<uint, string>();


        public static string[] GetRouteNames(string frtName)
        {
            string frtPath = GetRouteFileName(frtName);
            uint[] frtUintNames = GetUintNames(frtPath);

            if (File.Exists(RouteNameDictionaryFile))
                RouteNameHashDictionary = MakeHashLookupTableFromFile(RouteNameDictionaryFile);
            else
                MessageBox.Show("Route Dictionary Not Found. \n\n" + RouteNameDictionaryFile, "Dictionary Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            List<string> routeStringNames = new List<string>();

            foreach (uint routeUintName in frtUintNames)
            {
                string routeStringName = "";
                if (RouteNameHashDictionary.TryGetValue(routeUintName, out routeStringName))
                    routeStringNames.Add(routeStringName);
                else
                    routeStringNames.Add(routeUintName.ToString());
            }

            routeStringNames.Sort();
            return routeStringNames.ToArray();
        }

        public static uint[] GetUintNames(string frtPath)
        {
            RouteSet frtRoutes;
            uint[] routeNames = new uint[0];

            if (File.Exists(frtPath))
            {
                using (var reader = new BinaryReader(new FileStream(frtPath, FileMode.Open), getEncoding()))
                {
                    Action<int> skipBytes = numberOfBytes => SkipBytes(reader, numberOfBytes);
                    var readFunctions = new ReadFunctions(reader.ReadSingle, reader.ReadUInt16, reader.ReadUInt32, reader.ReadInt32, reader.ReadBytes, skipBytes);
                    frtRoutes = Read(readFunctions);
                }

                IEnumerable<uint> routes = from route in frtRoutes.Routes
                                                 select route.Name;

                routeNames = routes.ToArray();
            }
            return routeNames;
        }

        private static void SkipBytes(BinaryReader reader, int numberOfBytes)
        {
            reader.BaseStream.Position += numberOfBytes;
        }

        public static string GetRouteFileName(string frtName)
        {
            return Path.Combine(AssetsBuilder.routeAssetsPath, frtName) + ".frt";
        }

        public static uint HashString(string text)
        {
            if (text == null) throw new ArgumentNullException("null text!");
            const ulong seed0 = 0x9ae16a3b2f90404f;
            ulong seed1 = text.Length > 0 ? (uint)((text[0]) << 16) + (uint)text.Length : 0;
            return (uint)(CityHash.CityHash.CityHash64WithSeeds(text + "\0", seed0, seed1) & 0xFFFFFFFFFFFF);
        }

        static Dictionary<uint, string> MakeHashLookupTableFromFile(string path)
        {
            ConcurrentDictionary<uint, string> table = new ConcurrentDictionary<uint, string>();


            List<string> stringLiterals = new List<string>();
            using (StreamReader file = new StreamReader(path))
            {

                string line;
                while ((line = file.ReadLine()) != null)
                {
                    stringLiterals.Add(line);
                }
            }

            // Hash entries
            Parallel.ForEach(stringLiterals, delegate (string entry)
            {
                uint hash = HashString(entry);
                table.TryAdd(hash, entry);
            });

            // Return lookup table
            return new Dictionary<uint, string>(table);
        }

    }
}
