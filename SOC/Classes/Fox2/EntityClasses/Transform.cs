using SOC.Classes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Fox2
{
    class Transform : Fox2EntityClass
    {
        Fox2EntityClass owner;
        Rotation transform_rotation;
        Coordinates transform_translation;

        public Transform(Fox2EntityClass _owner, Rotation _rot, Coordinates _coord)
        {
            owner = _owner;
            transform_rotation = _rot;
            transform_translation = _coord;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
                                  <entity class=""TransformEntity"" classVersion=""0"" addr=""{GetHexAddress()}"" unknown1=""80"" unknown2=""29250"">
                                    <staticProperties>
                                      <property name=""owner"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
                                          <value>{owner.GetHexAddress()}</value>
                                      </property>
                                      <property name=""transform_scale"" type=""Vector3"" container=""StaticArray"" arraySize=""1"">
                                        <value x=""1"" y=""1"" z=""1"" w=""0"" />
                                      </property>
                                      {transform_translation.ToFox2String()}
                                      {transform_rotation.ToFox2String()}
                                    </staticProperties>
                                    <dynamicProperties />
                                  </entity>
                                 ");
        }

        public override string GetName()
        {
            return null;
        }

        public override Fox2EntityClass GetOwner()
        {
            return owner;
        }
    }
}
