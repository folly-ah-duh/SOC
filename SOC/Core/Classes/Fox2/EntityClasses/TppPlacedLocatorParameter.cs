using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Fox2
{
    class TppPlacedLocatorParameter : Fox2EntityClass
    {
        private Fox2EntityClass owner;
        private string equipIdStrCode32;

        public TppPlacedLocatorParameter(Fox2EntityClass _owner, string itemId)
        {
            owner = _owner; equipIdStrCode32 = itemId;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""TppPlacedLocatorParameter"" classVersion=""0"" addr=""{GetHexAddress()}"" unknown1=""32"" unknown2=""5408"">
          <staticProperties>
            <property name=""owner"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
              <value>{owner.GetHexAddress()}</value>
            </property>
            <property name=""equipIdStrCode32"" type=""uint32"" container=""StaticArray"" arraySize=""1"">
              <value>{equipIdStrCode32}</value>
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
