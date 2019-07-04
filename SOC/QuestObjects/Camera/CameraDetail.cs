using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.Linq;

namespace SOC.QuestObjects.Camera
{
    public class CameraDetail : Detail
    {
        public CameraDetail() { }

        public CameraDetail(List<Camera> cameraList, CameraMetadata meta)
        {
            cameras = cameraList; cameraMetadata = meta;
        }

        [XmlElement]
        public CameraMetadata cameraMetadata { get; set; } = new CameraMetadata();

        [XmlArray]
        public List<Camera> cameras { get; set; } = new List<Camera>();

        public override Metadata GetMetadata()
        {
            return cameraMetadata;
        }

        public override DetailManager GetNewManager()
        {
            return new CameraManager(this);
        }

        public override List<QuestObject> GetQuestObjects()
        {
            return cameras.Cast<QuestObject>().ToList();
        }

        public override void SetQuestObjects(List<QuestObject> qObjects)
        {
            cameras = qObjects.Cast<Camera>().ToList();
        }
    }

    public class Camera : QuestObject
    {
        public Camera() { }

        public Camera(Position pos, int numId)
        {
            position = pos; ID = numId;
        }

        public Camera(CameraBox box)
        {
            ID = box.ID;
            isTarget = box.checkBox_target.Checked;
            weapon = box.checkBox_weapon.Checked;
            position = new Position(new Coordinates(box.textBox_xcoord.Text, box.textBox_ycoord.Text, box.textBox_zcoord.Text), new Rotation(box.textBox_rot.Text));
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
            return "Camera_" + ID;
        }

        [XmlAttribute]
        public int ID { get; set; } = 0;

        [XmlElement]
        public bool isTarget { get; set; } = false;

        [XmlElement]
        public bool weapon { get; set; } = false;

        [XmlElement]
        public Position position = new Position(new Coordinates(), new Rotation());
    }

    public class CameraMetadata : Metadata
    {
        public CameraMetadata() { }

        public CameraMetadata(CameraControl control)
        {
            objectiveType = control.comboBox_ObjType.Text;
        }

        [XmlAttribute]
        public string objectiveType { get; set; } = "KILLREQUIRED";
    }
}
