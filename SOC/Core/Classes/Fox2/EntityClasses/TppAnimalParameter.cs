using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOC.QuestObjects.Animal;

namespace SOC.Classes.Fox2
{
    class TppAnimalParameter : Fox2EntityClass
    {
        private Fox2EntityClass owner;
        private string partsFile, motionGraphFile, mtarFile, fovaFile;

        public TppAnimalParameter(Fox2EntityClass _owner, string animalName)
        {
            owner = _owner; AnimalInfo.getAnimalPaths(animalName, out partsFile, out motionGraphFile, out mtarFile, out fovaFile);
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""TppAnimalParameter"" classVersion=""1"" addr=""{GetHexAddress()}"" unknown1=""168"" unknown2=""54088"">
          <staticProperties>
            <property name=""owner"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
              <value>{owner.GetHexAddress()}</value>
            </property>
            <property name=""partsFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
              <value>{partsFile}</value>
            </property>
            <property name=""motionGraphFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
              <value>{motionGraphFile}</value>
            </property>
            <property name=""mtarFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
              <value>{mtarFile}</value>
            </property>
            <property name=""fovaFiles"" type=""FilePtr"" container=""DynamicArray"" arraySize=""1"">
              <value>{fovaFile}</value>
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
