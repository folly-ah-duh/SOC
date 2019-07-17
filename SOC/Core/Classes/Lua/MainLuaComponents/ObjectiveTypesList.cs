using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    public class ObjectiveTypesList : LuaMainComponent
    {
        public List<GenericTargetPair> genericTargets = new List<GenericTargetPair>();
        public List<string> oneLineObjectiveTypes = new List<string>();

        public override string GetComponent()
        {
            return $@"{GetObjectiveFunctions()}
{GetObjectiveTypesList()}
";
        }

        private string GetObjectiveFunctions()
        {
            StringBuilder functionsBuilder = new StringBuilder();
            foreach (GenericTargetPair pair in genericTargets)
            {
                functionsBuilder.Append($@"
{pair.checkMethod.FunctionFull}");
            }
            return functionsBuilder.ToString();
        }

        private string GetObjectiveTypesList()
        {
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
            return objectiveListBuilder.ToString();
        }
    }
}
