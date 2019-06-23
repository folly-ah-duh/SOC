using SOC.QuestObjects.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Fox2
{
    class TppVehicle2AttachmentData : Fox2EntityClass
    {
        private string colloquialName, fox2Name, vehicleTypeCode, attachmentImplTypeIndex, attachmentFile, attachmentInstanceCount, bodyCnpName;
        private Fox2EntityClass dataSet;

        public TppVehicle2AttachmentData(string colloquial, Fox2EntityClass _dataSet)
        {
            colloquialName = colloquial;
            dataSet = _dataSet;
            VehicleInfo.GetVehicle2Attachment(colloquial, out fox2Name, out vehicleTypeCode, out attachmentImplTypeIndex, out attachmentFile, out attachmentInstanceCount, out bodyCnpName);
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
        <entity class=""TppVehicle2AttachmentData"" classVersion=""1"" addr=""{GetHexAddress()}"" unknown1=""120"" unknown2=""356482"">
          <staticProperties>
            <property name=""name"" type=""String"" container=""StaticArray"" arraySize=""1"">
              <value>{fox2Name}</value>
            </property>
            <property name=""dataSet"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
              <value>{dataSet.GetHexAddress()}</value>
            </property>
            <property name=""vehicleTypeCode"" type=""uint8"" container=""StaticArray"" arraySize=""1"">
              <value>{vehicleTypeCode}</value>
            </property>
            <property name=""attachmentImplTypeIndex"" type=""uint8"" container=""StaticArray"" arraySize=""1"">
              <value>{attachmentImplTypeIndex}</value>
            </property>
            <property name=""attachmentFile"" type=""FilePtr"" container=""StaticArray"" arraySize=""1"">
              <value>{attachmentFile}</value>
            </property>
            <property name=""attachmentInstanceCount"" type=""uint8"" container=""StaticArray"" arraySize=""1"">
              <value>{attachmentInstanceCount}</value>
            </property>
            <property name=""bodyCnpName"" type=""String"" container=""StaticArray"" arraySize=""1"">
              <value>{bodyCnpName}</value>
            </property>
            <property name=""attachmentBoneName"" type=""String"" container=""StaticArray"" arraySize=""1"">
              <value></value>
            </property>
            <property name=""weaponParams"" type=""EntityPtr"" container=""DynamicArray"" />
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
