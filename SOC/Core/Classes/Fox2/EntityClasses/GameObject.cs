namespace SOC.Classes.Fox2
{
    class GameObject : Fox2EntityClass
    {
        private string name, typeName;
        private int totalCount, realizedCount;
        private Fox2EntityClass dataSet, parameters;

        public GameObject(string _name, Fox2EntityClass _dataSet, string _typeName, int _totalCount, int _realizedCount)
        {
            name = _name; typeName = _typeName;
            totalCount = _totalCount; realizedCount = _realizedCount;
            dataSet = _dataSet;
        }

        public void SetParameter(Fox2EntityClass c)
        {
            parameters = c;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""GameObject"" classVersion=""2"" addr=""{GetHexAddress()}"" unknown1=""88"" unknown2=""29243"">
          <staticProperties>
            <property name=""name"" type=""String"" container=""StaticArray"" arraySize=""1"">
                <value>{name}</value>
            </property>
            <property name=""dataSet"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
                <value>{dataSet.GetHexAddress()}</value>
            </property>
            <property name=""typeName"" type=""String"" container=""StaticArray"" arraySize=""1"">
                <value>{typeName}</value>
            </property>
            <property name=""groupId"" type=""uint32"" container=""StaticArray"" arraySize=""1"">
                <value>0</value>
            </property>
            <property name=""totalCount"" type=""uint32"" container=""StaticArray"" arraySize=""1"">
                <value>{totalCount}</value>
            </property>
            <property name=""realizedCount"" type=""uint32"" container=""StaticArray"" arraySize=""1"">
                <value>{realizedCount}</value>
            </property>
            <property name=""parameters"" type=""EntityPtr"" container=""StaticArray"" arraySize=""1"">
                <value>{parameters.GetHexAddress()}</value>
            </property>
          </staticProperties>
          <dynamicProperties />
        </entity>
            ");
        }
        public override string GetName()
        {
            return name;
        }

        public override Fox2EntityClass GetOwner()
        {
            return dataSet;
        }
    }
}
