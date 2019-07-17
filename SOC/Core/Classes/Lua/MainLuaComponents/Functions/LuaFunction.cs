using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    public class LuaFunction
    {
        public string FunctionFull;
        public string FunctionName;

        public LuaFunction(string name, string function)
        {
            FunctionName = name; FunctionFull = function;
        }
    }
}
