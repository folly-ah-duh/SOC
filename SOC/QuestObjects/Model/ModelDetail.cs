using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.Linq;

namespace SOC.QuestObjects.Model
{
    [XmlType("ModelDetail")]
    public class ModelDetail : Detail
    {
        public ModelDetail() { }

        public ModelDetail(List<Model> modelList, ModelMetadata meta)
        {
            models = modelList; modelMetadata = meta;
        }

        [XmlArray]
        public List<Model> models { get; set; } = new List<Model>();

        [XmlElement]
        public ModelMetadata modelMetadata { get; set; } = new ModelMetadata();

        public override Metadata GetMetadata()
        {
            return modelMetadata;
        }

        public override DetailManager GetNewManager()
        {
            return new ModelManager(this);
        }

        public override List<QuestObject> GetQuestObjects()
        {
            return models.Cast<QuestObject>().ToList();
        }

        public override void SetQuestObjects(List<QuestObject> qObjects)
        {
            models = qObjects.Cast<Model>().ToList();
        }
    }

    public class Model : QuestObject
    {

        public Model() { }

        public Model(ModelBox mBox)
        {
            ID = mBox.modelID;

            collision = mBox.m_checkBox_collision.Checked;
            model = mBox.m_comboBox_model.Text;
            position = new Position(new Coordinates(mBox.m_textBox_xcoord.Text, mBox.m_textBox_ycoord.Text, mBox.m_textBox_zcoord.Text), new Rotation(new Quaternion(mBox.m_textBox_xrot.Text, mBox.m_textBox_yrot.Text, mBox.m_textBox_zrot.Text, mBox.m_textBox_wrot.Text)));
        }

        public Model(Position pos, int index)
        {
            position = pos; ID = index;
        }

        public override Position GetPosition()
        {
            return position;
        }

        public override void SetPosition(Position pos)
        {
            position = pos;
        }

        public override int GetID()
        {
            return ID;
        }

        public override string GetObjectName()
        {
            return "Model_" + ID;
        }

        [XmlElement]
        public bool collision { get; set; } = true; // default to true, yeah?

        [XmlElement]
        public int ID { get; set; } = 0;

        [XmlElement]
        public string model { get; set; } = "";

        [XmlElement]
        public Position position = new Position(new Coordinates(), new Rotation());

    }

    public class ModelMetadata : Metadata
    {
        public ModelMetadata() { }
    }
}
