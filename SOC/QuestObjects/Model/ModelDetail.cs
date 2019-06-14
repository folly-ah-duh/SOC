using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.Linq;

namespace SOC.QuestObjects.Model
{
    public class ModelDetail : Detail
    {
        public ModelDetail() { }

        public ModelDetail(List<Model> modelList, ModelMetadata meta)
        {
            models = modelList; modelMetadata = meta;
        }

        [XmlElement]
        public ModelMetadata modelMetadata { get; set; } = new ModelMetadata();
        
        [XmlArray]
        public List<Model> models { get; set; } = new List<Model>();

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

        public Model(ModelBox box)
        {
            ID = box.ID;

            collision = box.checkBox_collision.Checked;
            model = box.comboBox_model.Text;
            position = new Position(new Coordinates(box.textBox_xcoord.Text, box.textBox_ycoord.Text, box.textBox_zcoord.Text), new Rotation(new Quaternion(box.textBox_xrot.Text, box.textBox_yrot.Text, box.textBox_zrot.Text, box.textBox_wrot.Text)));
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
