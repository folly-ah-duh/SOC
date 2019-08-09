using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Fox2
{
    class GeoTrap : Fox2EntityClass
    {
        private string name;
        private Fox2EntityClass dataSet, transform, conditional;
        private List<Fox2EntityClass> shapes = new List<Fox2EntityClass>();

        public GeoTrap(string _name, Fox2EntityClass _dataSet)
        {
            name = _name; dataSet = _dataSet;
        }

        public void SetTransform(Fox2EntityClass t)
        {
            transform = t;
        }

        public void SetConditional(Fox2EntityClass c)
        {
            conditional = c;
        }

        public void AddShape(Fox2EntityClass s)
        {
            shapes.Add(s);
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
	    <entity class=""GeoTrap"" classVersion=""2"" addr=""{GetHexAddress()}"" unknown1=""288"" unknown2=""249869"">
          <staticProperties>
            <property name=""name"" type=""String"" container=""StaticArray"" arraySize=""1"">
              <value>{name}</value>
            </property>
            <property name=""dataSet"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
              <value>{dataSet.GetHexAddress()}</value>
            </property>
            <property name=""parent"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
              <value>0x00000000</value>
            </property>
            <property name=""transform"" type=""EntityPtr"" container=""StaticArray"" arraySize=""1"">
              <value>{transform.GetHexAddress()}</value>
            </property>
            <property name=""shearTransform"" type=""EntityPtr"" container=""StaticArray"" arraySize=""1"">
              <value>0x00000000</value>
            </property>
            <property name=""pivotTransform"" type=""EntityPtr"" container=""StaticArray"" arraySize=""1"">
              <value>0x00000000</value>
            </property>
            <property name=""children"" type=""EntityHandle"" container=""List"" arraySize=""2"">
              <value>{conditional.GetHexAddress()}</value>{GetShapeAddressesFormat()}
            </property>
            <property name=""flags"" type=""uint32"" container=""StaticArray"" arraySize=""1"">
              <value>7</value>
            </property>
            <property name=""conditionArray"" type=""EntityLink"" container=""DynamicArray"" arraySize=""1"">
              <value packagePath="""" archivePath="""" nameInArchive="""">{conditional.GetHexAddress()}</value>
            </property>
            <property name=""enable"" type=""bool"" container=""StaticArray"" arraySize=""1"">
              <value>true</value>
            </property>
          </staticProperties>
          <dynamicProperties />
        </entity>
            ");
        }

        private string GetShapeAddressesFormat()
        {
            StringBuilder formatBuilder = new StringBuilder();
            foreach (Fox2EntityClass shape in shapes)
            {
                formatBuilder.Append($@"
              <value>{shape.GetHexAddress()}</value>");
            }
            return formatBuilder.ToString();
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
