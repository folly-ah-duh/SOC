using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    public class ObjectiveTypesPair
    {
        public LuaFunction checkMethod;
        public string ObjectiveType;

        public ObjectiveTypesPair(MainLua mainLua, LuaFunction check, string type)
        {
            checkMethod = check; ObjectiveType = type;
            mainLua.AddToObjectiveTypes(this);
        }

        public string GetTableFormat()
        {
            return $"{{Check = this.{checkMethod.FunctionName}, Type = {ObjectiveType}}}";
        }
    }
}
