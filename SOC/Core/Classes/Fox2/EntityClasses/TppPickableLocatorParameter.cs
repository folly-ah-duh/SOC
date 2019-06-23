namespace SOC.Classes.Fox2
{
    class TppPickableLocatorParameter : Fox2EntityClass
    {
        private Fox2EntityClass owner;
        private string equipIdStrCode32;
        private string countRaw;
        private bool flag;

        public TppPickableLocatorParameter(Fox2EntityClass _owner, string itemId, string count, bool boxed)
        {
            owner = _owner; equipIdStrCode32 = itemId; countRaw = count; flag = boxed;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""TppPickableLocatorParameter"" classVersion=""0"" addr=""{GetHexAddress()}"" unknown1=""40"" unknown2=""17661759"">
          <staticProperties>
            <property name=""owner"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
              <value>{owner.GetHexAddress()}</value>
            </property>
            <property name=""equipIdStrCode32"" type=""uint32"" container=""StaticArray"" arraySize=""1"">
              <value>{equipIdStrCode32}</value>
            </property>
            <property name=""countRaw"" type=""uint16"" container=""StaticArray"" arraySize=""1"">
              <value>{countRaw}</value>
            </property>
            <property name=""countSubRaw"" type=""uint16"" container=""StaticArray"" arraySize=""1"">
              <value>0</value>
            </property>
            <property name=""flag"" type=""uint16"" container=""StaticArray"" arraySize=""1"">
              <value>{(flag ? "1" : "0")}</value>
            </property>
            <property name=""reserved"" type=""uint16"" container=""StaticArray"" arraySize=""1"">
              <value>0</value>
            </property>
          </staticProperties>
          <dynamicProperties />
        </entity>
                                ");
        }

        public override string GetName()
        {
            return "";
        }

        public override Fox2EntityClass GetOwner()
        {
            return owner;
        }
    }
}
