using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    class OnTerminate : LuaMainComponent
    {
        public override string GetComponent()
        {
            return @"
function this.OnTerminate()
	TppQuest.QuestBlockOnTerminate(this)
end";
        }
    }
}
