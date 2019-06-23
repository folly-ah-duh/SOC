using SOC.QuestObjects.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Fox2
{
    class TppVehicle2BodyData : Fox2EntityClass
    {
        private string colloquialName, fox2Name, vehicleTypeIndex, bodyImplTypeIndex, partsFile;
        private Fox2EntityClass dataSet;

        public TppVehicle2BodyData(string colloquial, Fox2EntityClass _dataSet)
        {
            colloquialName = colloquial;
            dataSet = _dataSet;
            VehicleInfo.GetVehicle2Body(colloquial, out fox2Name, out vehicleTypeIndex, out bodyImplTypeIndex, out partsFile);
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""TppVehicle2BodyData"" classVersion=""3"" addr=""{GetHexAddress()}"" unknown1=""128"" unknown2=""547300"">
          <staticProperties>
            <property name=""name"" type=""String"" container=""StaticArray"" arraySize=""1"">
              <value>{fox2Name}</value>
            </property>
            <property name=""dataSet"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
              <value>{dataSet.GetHexAddress()}</value>
            </property>
            <property name=""vehicleTypeIndex"" type=""uint8"" container=""StaticArray"" arraySize=""1"">
              <value>{vehicleTypeIndex}</value>
            </property>
            <property name=""proxyVehicleTypeIndex"" type=""uint8"" container=""StaticArray"" arraySize=""1"">
              <value>{vehicleTypeIndex}</value>
            </property>
            <property name=""bodyImplTypeIndex"" type=""uint8"" container=""StaticArray"" arraySize=""1"">
              <value>{bodyImplTypeIndex}</value>
            </property>
            <property name=""partsFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
              <value>{partsFile}</value>
            </property>
            <property name=""bodyInstanceCount"" type=""uint8"" container=""StaticArray"" arraySize=""1"">
              <value>2</value>
            </property>
            <property name=""weaponParams"" type=""EntityPtr"" container=""DynamicArray"" />
            <property name=""fovaFiles"" type=""FilePtr"" container=""DynamicArray"" />
          </staticProperties>
          <dynamicProperties />
        </entity>
                                ");
        }

        public override string GetName()
        {
            return fox2Name;
        }

        public override Fox2EntityClass GetOwner()
        {
            return dataSet;
        }
    }
}
