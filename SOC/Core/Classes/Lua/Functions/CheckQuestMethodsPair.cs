using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    public abstract class CheckQuestMethodsPair
    {
        public LuaFunction TargetMessageMethod, TallyMethod;

        public CheckQuestMethodsPair(MainLua mainLua, LuaFunction a, LuaFunction b)
        {
            TargetMessageMethod = a; TallyMethod = b;
            mainLua.AddToCheckQuestMethod(this);
        }

        public string GetTableFormat()
        {
            return $"{{IsTargetSetMessageMethod = this.{TargetMessageMethod.FunctionName}, TallyMethod = this.{TallyMethod.FunctionName}}}";
        }
    }
}
