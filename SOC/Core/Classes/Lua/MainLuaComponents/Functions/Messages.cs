using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    class Messages : LuaMainComponent
    {
        public override string GetComponent()
        {
            return @"
this.Messages = function()
  return
    StrCode32Table {
      Block = {
        {
          msg = ""StageBlockCurrentSmallBlockIndexUpdated"",
          func = function() end,
        },
      },
    }
end";
        }
    }
}
