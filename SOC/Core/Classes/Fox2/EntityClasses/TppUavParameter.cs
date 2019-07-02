using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Fox2
{
    class TppUavParameter : Fox2EntityClass
    {
        private Fox2EntityClass owner; 

        public TppUavParameter(Fox2EntityClass _owner)
        {
            owner = _owner;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""TppUavParameter"" classVersion=""1"" addr=""{GetHexAddress()}"" unknown1=""56"" unknown2=""295015"">
          <staticProperties>
	        <property name=""owner"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
	          <value>{owner.GetHexAddress()}</value>
	        </property>
	        <property name=""partsFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
	          <value>/Assets/tpp/parts/mecha/uav/uav0_main0_def_v00.parts</value>
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
