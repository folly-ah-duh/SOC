using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Fox2
{
    class StaticModel : Fox2EntityClass
    {
        private string name, modelName;
        private bool enableCollision;
        private Fox2EntityClass dataSet, parameters;

        public StaticModel(string _name, Fox2EntityClass _dataSet, string _modelName, bool _collide)
        {
            name = _name;
            modelName = _modelName;
            enableCollision = _collide;
            dataSet = _dataSet;
        }

        public void SetParameter(Fox2EntityClass c)
        {
            parameters = c;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""StaticModel"" classVersion=""9"" addr=""{GetHexAddress()}"" unknown1=""352"" unknown2=""548876795"">
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
	        <property name=""modelFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
	          <value>/Assets/{modelName}.fmdl</value>
	        </property>
	        <property name=""geomFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
	          <value>{((enableCollision) ? $"/Assets/{modelName}.geom" : "")}</value>
	        </property>
	        <property name=""isVisibleGeom"" type=""bool"" container=""StaticArray"" arraySize=""1"">
	          <value>false</value>
	        </property>
	        <property name=""isIsolated"" type=""bool"" container=""StaticArray"" arraySize=""1"">
	          <value>false</value>
	        </property>
	        <property name=""lodFarSize"" type=""float"" container=""StaticArray"" arraySize=""1"">
	          <value>-1</value>
	        </property>
	        <property name=""lodNearSize"" type=""float"" container=""StaticArray"" arraySize=""1"">
	          <value>-1</value>
	        </property>
	        <property name=""lodPolygonSize"" type=""float"" container=""StaticArray"" arraySize=""1"">
	          <value>-1</value>
	        </property>
	        <property name=""color"" type=""Color"" container=""StaticArray"" arraySize=""1"">
	          <value r=""1"" g=""1"" b=""1"" a=""1"" />
	        </property>
	        <property name=""drawRejectionLevel"" type=""int32"" container=""StaticArray"" arraySize=""1"">
	          <value>8</value>
	        </property>
	        <property name=""drawMode"" type=""int32"" container=""StaticArray"" arraySize=""1"">
	          <value>0</value>
	        </property>
	        <property name=""rejectFarRangeShadowCast"" type=""int32"" container=""StaticArray"" arraySize=""1"">
	          <value>2</value>
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
