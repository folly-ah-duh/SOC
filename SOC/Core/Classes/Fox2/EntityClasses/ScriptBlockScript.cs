using System;

namespace SOC.Classes.Fox2
{
    class ScriptBlockScript : Fox2EntityClass
    {
        private string fpkName;
        private string blockName;
        private DataSet dataSet;

        public ScriptBlockScript(string name, Fox2EntityClass data, string fpkName)
        {
            blockName = name; dataSet = (DataSet)data; this.fpkName = fpkName;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
                                  <entity class=""ScriptBlockScript"" classVersion=""0"" addr=""{GetHexAddress()}"" unknown1=""88"" unknown2=""29241"">
                                    <staticProperties>
                                      <property name=""name"" type=""String"" container=""StaticArray"" arraySize=""1"">
                                        <value>{blockName}</value>
                                      </property>
                                      <property name=""dataSet"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
                                        <value>{dataSet.GetHexAddress()}</value>
                                      </property>
                                      <property name=""script"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
                                        <value>/Assets/tpp/level/mission2/quest/ih/{fpkName}.lua</value>
                                      </property>
                                    </staticProperties>
                                    <dynamicProperties />
                                  </entity>
                                ");
        }

        public override string GetName()
        {
            return blockName;
        }

        public override Fox2EntityClass GetOwner()
        {
            return dataSet;
        }
    }
}
