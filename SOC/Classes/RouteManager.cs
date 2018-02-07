using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FoxLib.Tpp.RouteSet;

namespace SOC.Classes
{
    class RouteManager
    {

        public static string[] GetRouteNames(string frtName)
        {
            string frtPath = GetRouteFileName(frtName);
            RouteSet frtRoutes;
            string[] routeNames = new string[0];

            if (File.Exists(frtPath))
            {
                using (var reader = new BinaryReader(new FileStream(frtPath, FileMode.Open), getEncoding()))
                {
                    Action<int> skipBytes = numberOfBytes => SkipBytes(reader, numberOfBytes);
                    var readFunctions = new ReadFunctions(reader.ReadSingle, reader.ReadUInt16, reader.ReadUInt32, reader.ReadInt32, reader.ReadBytes, skipBytes);
                    frtRoutes = Read(readFunctions);
                }

                IEnumerable<string> routes = from route in frtRoutes.Routes
                                                 select route.Name.ToString();

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
    }
}
