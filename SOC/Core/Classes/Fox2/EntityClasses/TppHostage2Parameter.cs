using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Fox2
{
    class TppHostage2Parameter : Fox2EntityClass
    {
        private Fox2EntityClass owner;
        private string partsPath;

        public TppHostage2Parameter(Fox2EntityClass _owner, string _partsPath)
        {
            owner = _owner;
            partsPath = _partsPath;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
                                  <entity class=""TppHostage2Parameter"" classVersion=""1"" addr=""{GetHexAddress()}"" unknown1=""176"" unknown2=""29245"">
                                    <staticProperties>
                                      <property name=""owner"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
                                          <value>{owner.GetHexAddress()}</value>
                                      </property>
                                      <property name=""partsFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
                                          <value>{partsPath}</value>
                                      </property>
                                      <property name=""motionGraphFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
                                        <value>/Assets/tpp/motion/motion_graph/hostage2/Hostage2_layers.mog</value>
                                      </property>
                                      <property name=""mtarFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
                                        <value>/Assets/tpp/motion/mtar/hostage2/Hostage2_layers.mtar</value>
                                      </property>
                                      <property name=""extensionMtarFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
                                        <value></value>
                                      </property>
                                      <property name=""vfxFiles"" type=""FilePtr"" container=""StringMap"" />
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
