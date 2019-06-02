using System;

namespace SOC.Classes.Fox2
{
    class TexturePackLoadConditioner : Fox2EntityClass
    {
        private string conditionerName;
        private DataSet dataSet;

        public TexturePackLoadConditioner(string name, Fox2EntityClass dataset)
        {
            conditionerName = name; dataSet = (DataSet)dataset;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""TexturePackLoadConditioner"" classVersion=""0"" addr=""{GetHexAddress()}"" unknown1=""72"" unknown2=""0"">
          <staticProperties>
            <property name=""name"" type=""String"" container=""StaticArray"" arraySize=""1"">
                <value>{conditionerName}</value>
            </property>
            <property name=""dataSet"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
                <value>{GetOwner().GetHexAddress()}</value>
            </property>
            <property name=""texturePackPath"" type=""Path"" container=""StaticArray"" arraySize=""1"">
                <value></value>
            </property>
          </staticProperties>
          <dynamicProperties />
        </entity>
            ");
        }

        public override string GetName()
        {
            return conditionerName;
        }

        public override Fox2EntityClass GetOwner()
        {
            return dataSet;
        }
    }
}
