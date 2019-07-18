using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    class OnInitialize : LuaMainComponent
    {
        public override string GetComponent()
        {
            return @"
function this.OnInitialize()
	TppQuest.QuestBlockOnInitialize( this )
end";
        }
    }
}
