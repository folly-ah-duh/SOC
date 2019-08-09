using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;

namespace SOC.Classes.Fox2
{
    class Transform : Fox2EntityClass
    {
        Fox2EntityClass owner;
        Rotation transform_rotation;
        Coordinates transform_translation;
        string xscale, yscale, zscale;

        public Transform(Fox2EntityClass _owner, Position position, string _xscale = "1", string _yscale = "1", string _zscale = "1")
        {
            owner = _owner;
            transform_rotation = position.rotation;
            transform_translation = position.coords;
            zscale = _zscale; xscale = _xscale; yscale = _yscale;
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
                <value x=""{xscale}"" y=""{yscale}"" z=""{zscale}"" w=""0"" />
            </property>
            {transform_rotation.ToFox2String()}
            {transform_translation.ToFox2String()}
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
