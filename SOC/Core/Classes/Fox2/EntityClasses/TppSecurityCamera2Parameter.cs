namespace SOC.Classes.Fox2
{
    class TppSecurityCamera2Parameter : Fox2EntityClass
    {
        private Fox2EntityClass owner;

        public TppSecurityCamera2Parameter(Fox2EntityClass _owner)
        {
            owner = _owner;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""TppSecurityCamera2Parameter"" classVersion=""0"" addr=""{GetHexAddress()}"" unknown1=""104"" unknown2=""104"">
          <staticProperties>
	        <property name=""owner"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
	          <value>{owner.GetHexAddress()}</value>
	        </property>
	        <property name=""partsFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
	          <value>/Assets/tpp/parts/mecha/ctv/ctv0_main0_def_v00.parts</value>
	        </property>
	        <property name=""vfxFiles"" type=""FilePtr"" container=""StringMap"" />
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
