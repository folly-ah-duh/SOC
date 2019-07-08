using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    public class ObjectiveTypesList
    {
        public List<GenericTargetPair> genericTargets = new List<GenericTargetPair>();
        public List<string> oneLineObjectiveTypes = new List<string>();

        public void BuildObjectiveTypesList(MainLua main)
        {
            foreach(GenericTargetPair pair in genericTargets)
            {
                main.AddCodeToScript(pair.checkMethod);
            }

            StringBuilder objectiveListBuilder = new StringBuilder(@"
ObjectiveTypeList = {
  genericTargets = {");
            foreach(GenericTargetPair pair in genericTargets)
            {
                objectiveListBuilder.Append($@"
    {pair.GetTableFormat()},");
            }
            objectiveListBuilder.Append(@"
  },");
            foreach(string oneLineObjectiveType in oneLineObjectiveTypes)
            {
                objectiveListBuilder.Append($@"
  {oneLineObjectiveType},");
            }
            objectiveListBuilder.Append(@"
}");
            main.AddCodeToScript(objectiveListBuilder.ToString());
        }
    }
}
