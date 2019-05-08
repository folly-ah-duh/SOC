using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.GzsTool
{
    public static class Hashing
    {
        public static ulong ToStr64(string text, bool removeExtension = true)
        {
            const ulong seed0 = 0x9ae16a3b2f90404f;
            ulong seed1 = text.Length > 0 ? (uint)((text[0]) << 16) + (uint)text.Length : 0;

            return (CityHash.CityHash.CityHash64WithSeeds(text + "\0", seed0, seed1) & 0xFFFFFFFFFFFF);
        } //GzsTool HashFileNameLegacy

        public static string ToStr32(string text)
        {
            ulong str64 = ToStr64(text);
            ulong str32 = str64 % 0x100000000;

            Console.WriteLine("str32: " + str32.ToString());
            return str32.ToString();

        }
    }
}
