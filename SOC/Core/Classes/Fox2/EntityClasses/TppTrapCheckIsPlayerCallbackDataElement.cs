using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Fox2
{
    class TppTrapCheckIsPlayerCallbackDataElement : Fox2EntityClass
    {
        private Fox2EntityClass owner;

        public TppTrapCheckIsPlayerCallbackDataElement(Fox2EntityClass _owner)
        {
            owner = _owner;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
	    <entity class=""TppTrapCheckIsPlayerCallbackDataElement"" classVersion=""0"" addr=""{GetHexAddress()}"" unknown1=""32"" unknown2=""9784914"">
          <staticProperties>
            <property name=""owner"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
              <value>{owner.GetHexAddress()}</value>
            </property>
            <property name=""funcName"" type=""String"" container=""StaticArray"" arraySize=""1"">
              <value>IsPlayer</value>
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
