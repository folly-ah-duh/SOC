using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Fox2
{
    class BoxShape : Fox2EntityClass
    {
        private string name;
        private Fox2EntityClass dataSet, parent, parameters;

        public BoxShape(string _name, Fox2EntityClass _dataSet, Fox2EntityClass _parent)
        {
            name = _name;
            dataSet = _dataSet;
            parent = _parent;
        }

        public void SetParameter(Fox2EntityClass c)
        {
            parameters = c;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""BoxShape"" classVersion=""0"" addr=""{GetHexAddress()}"" unknown1=""256"" unknown2=""249881"">
          <staticProperties>
            <property name=""name"" type=""String"" container=""StaticArray"" arraySize=""1"">
              <value>{name}</value>
            </property>
            <property name=""dataSet"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
              <value>{dataSet.GetHexAddress()}</value>
            </property>
            <property name=""parent"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
              <value>{parent.GetHexAddress()}</value>
            </property>
            <property name=""transform"" type=""EntityPtr"" container=""StaticArray"" arraySize=""1"">
              <value>{parameters.GetHexAddress()}</value>
            </property>
            <property name=""shearTransform"" type=""EntityPtr"" container=""StaticArray"" arraySize=""1"">
              <value>0x00000000</value>
            </property>
            <property name=""pivotTransform"" type=""EntityPtr"" container=""StaticArray"" arraySize=""1"">
              <value>0x00000000</value>
            </property>
            <property name=""children"" type=""EntityHandle"" container=""List"" />
            <property name=""flags"" type=""uint32"" container=""StaticArray"" arraySize=""1"">
              <value>7</value>
            </property>
          </staticProperties>
          <dynamicProperties />
        </entity>
            ");
        }
        public override string GetName()
        {
            return name;
        }

        public override Fox2EntityClass GetOwner()
        {
            return dataSet;
        }
    }
}
