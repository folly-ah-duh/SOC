using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Fox2
{
    class TppVehicle2LocatorParameter : Fox2EntityClass
    {
        private Fox2EntityClass owner;

        public TppVehicle2LocatorParameter(Fox2EntityClass _owner)
        {
            owner = _owner;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""TppVehicle2LocatorParameter"" classVersion=""2"" addr=""{GetHexAddress()}"" unknown1=""28"" unknown2=""245793"">
          <staticProperties>
            <property name=""owner"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
              <value>{owner.GetHexAddress()}</value>
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
