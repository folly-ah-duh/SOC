using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    public class GenericTargetPair
    {
        public LuaFunction checkMethod;
        public string ObjectiveType;

        public GenericTargetPair(LuaFunction check, string type)
        {
            checkMethod = check; ObjectiveType = type;
        }

        public string GetTableFormat()
        {
            return $"{{Check = this.{checkMethod.FunctionName}, Type = {ObjectiveType}}}";
        }
    }
}
