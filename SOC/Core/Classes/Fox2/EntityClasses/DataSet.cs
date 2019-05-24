using System.Collections.Generic;

namespace SOC.Classes.Fox2
{
    class DataSet : Fox2EntityClass
    {
        List<Fox2EntityClass> fox2List;

        public DataSet(List<Fox2EntityClass> entities)
        {
            fox2List = entities;
        }

        public override string GetFox2Format()
        {
            return string.Format($@"
                                  <entity class=""DataSet"" classVersion=""0"" addr=""{GetHexAddress()}"" unknown1=""232"" unknown2=""29239"">
                                    <staticProperties>
                                      <property name=""name"" type=""String"" container=""StaticArray"" arraySize=""1"">
                                        <value></value>
                                      </property>
                                      <property name=""dataSet"" type=""EntityHandle"" container=""StaticArray"" arraySize=""1"">
                                        <value>0x00000000</value>
                                      </property>
                                        <property name=""dataList"" type=""EntityPtr"" container=""StringMap"" arraySize=""1"">
                                          {GetDataList()}
                                      </property>
                                    </staticProperties>
                                    <dynamicProperties />
                                  </entity>
                                ");
        }

        private string GetDataList()
        {
            string dataList = "";
            foreach (Fox2EntityClass entity in fox2List)
            {
                if (entity.GetOwner() != null && entity.GetOwner() == this)
                {
                    dataList += string.Format($@"
                                                <value key=""{entity.GetName()}""{entity.GetHexAddress()}</value>
                                              ");
                }
            }

            return dataList;
        }

        public override string GetName()
        {
            return "";
        }

        public override Fox2EntityClass GetOwner()
        {
            return null;
        }
    }
}
