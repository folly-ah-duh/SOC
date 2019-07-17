using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    public abstract class LuaMainComponent
    {
        public void BuildComponent(MainLua script)
        {
            script.AddCodeToScript(GetComponent());
        }

        public abstract string GetComponent();
    }
}
