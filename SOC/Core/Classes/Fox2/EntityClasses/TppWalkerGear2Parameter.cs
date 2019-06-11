using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Fox2
{
    class TppWalkerGear2Parameter : Fox2EntityClass
    {
        private Fox2EntityClass owner;

        public TppWalkerGear2Parameter(Fox2EntityClass _owner)
        {
            owner = _owner;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""TppWalkerGear2Parameter"" classVersion=""0"" addr=""{GetHexAddress()}"" unknown1=""224"" unknown2=""69417"">
          <staticProperties>
	        <property name=""owner"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
	          <value>{owner.GetHexAddress()}</value>
	        </property>
	        <property name=""partsFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
	          <value>/Assets/tpp/parts/mecha/mgm/mgm1_main0_def.parts</value>
	        </property>
	        <property name=""motionGraphFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
	          <value>/Assets/tpp/motion/motion_graph/walkergear2/walkergear2_layers.mog</value>
	        </property>
	        <property name=""mtarFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
	          <value>/Assets/tpp/motion/mtar/walkergear2/walkergear2_layers.mtar</value>
	        </property>
	        <property name=""extensionMtarFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
	          <value>/Assets/tpp/motion/mtar/walkergear2/walkergear2_attc_layers.mtar</value>
	        </property>
	        <property name=""vfxFiles"" type=""FilePtr"" container=""StringMap"" arraySize=""1"">
	          <value key=""TestKey0""></value>
	        </property>
	        <property name=""extraPartsFiles"" type=""FilePtr"" container=""StringMap"" arraySize=""8"">
	          <value key=""TestKey0"">/Assets/tpp/parts/mecha/mgm/mgm0_mgun0_def.parts</value>
	          <value key=""TestKey1"">/Assets/tpp/parts/mecha/mgm/mgm0_towm0_def_v00.parts</value>
	          <value key=""TestKey2"">/Assets/tpp/parts/mecha/mgm/mgm0_ammo0_def_v00.parts</value>
	          <value key=""TestKey3"">/Assets/tpp/parts/mecha/mgm/mgm1_head0_def.parts</value>
	          <value key=""TestKey4"">/Assets/tpp/parts/mecha/mgm/mgm1_rarm0_def.parts</value>
	          <value key=""TestKey5"">/Assets/tpp/parts/mecha/mgm/mgm0_attc0_def.parts</value>
	          <value key=""TestKey6"">/Assets/tpp/parts/mecha/mgm/mgm1_shed0_def.parts</value>
	          <value key=""TestKey7"">/Assets/tpp/parts/mecha/mgm/mgm0_sids0_def.parts</value>
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
