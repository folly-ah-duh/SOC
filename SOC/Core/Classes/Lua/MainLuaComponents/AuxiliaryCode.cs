using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    class AuxiliaryCode : LuaMainComponent
    {
        List<string> auxiliaryCodes = new List<string>();

        public void Add(string code)
        {
            auxiliaryCodes.Add(code);
        }

        public override string GetComponent()
        {
            StringBuilder auxCodeBuilder = new StringBuilder();
            foreach (string auxCode in auxiliaryCodes)
                auxCodeBuilder.Append($@"
{auxCode}");
            return auxCodeBuilder.ToString();
        }
    }
}
