using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace SOC.Classes.GzsTool
{
    public static class Hashing
    {
        public static ulong ToStr64(string text)
        {
            const ulong seed0 = 0x9ae16a3b2f90404f;
            ulong seed1 = text.Length > 0 ? (uint)((text[0]) << 16) + (uint)text.Length : 0;
            return (CityHash.CityHash.CityHash64WithSeeds(text + "\0", seed0, seed1) & 0xFFFFFFFFFFFF);
        } //GzsTool HashFileNameLegacy

        public static string ToStr32(string text)
        {
            ulong str64 = ToStr64(text);
            ulong str32 = str64 % 0x100000000;
            return str32.ToString();
        }

        public static Dictionary<uint, string> MakeHashLookupTableFromFile(string path)
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
                uint hash = (uint)ToStr64(entry);
                table.TryAdd(hash, entry);
            });

            // Return lookup table
            return new Dictionary<uint, string>(table);
        }
    }
}
