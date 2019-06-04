using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    public class DefinitionLua
    {
        List<string> packPaths = new List<string>();
        List<string> packInfos = new List<string>();
        List<string> definitions = new List<string>();

        public void AddPackPath(string packPath)
        {
            packPaths.Add(packPath);
        }

        public void AddPackInfo(string packInfo)
        {
            packInfos.Add(packInfo);
        }

        public void AddDefinition(string definition)
        {
            definitions.Add(definition);
        }

        public string GetDefinitionLuaFormatted()
        {
            StringBuilder definitionLua = new StringBuilder("local this = { questPackList = {");
            foreach (string path in packPaths)
                definitionLua.Append($@"""{path}"", ");

            foreach (string info in packInfos)
                definitionLua.Append(info + ", ");

            definitionLua.Append("},");

            foreach (string definition in definitions)
                definitionLua.Append(definition + ", ");

            definitionLua.Append("} return this");

            return definitionLua.ToString();
        }
    }
}
