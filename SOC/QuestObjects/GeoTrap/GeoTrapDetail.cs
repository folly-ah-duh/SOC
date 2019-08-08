using SOC.Classes.Common;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SOC.QuestObjects.GeoTrap
{
    public class GeoTrapDetail : Detail
    {
        public GeoTrapDetail() { }

        public GeoTrapDetail(List<GeoTrapShape> TrapList, GeoTrapMetadata meta)
        {
            trapShapes = TrapList; trapMetadata = meta;
        }

        [XmlElement]
        public GeoTrapMetadata trapMetadata { get; set; } = new GeoTrapMetadata();

        [XmlArray]
        public List<GeoTrapShape> trapShapes { get; set; } = new List<GeoTrapShape>();

        public override Metadata GetMetadata()
        {
            return trapMetadata;
        }

        public override DetailManager GetNewManager()
        {
            return new GeoTrapManager(this);
        }

        public override List<QuestObject> GetQuestObjects()
        {
            return trapShapes.Cast<QuestObject>().ToList();
        }

        public override void SetQuestObjects(List<QuestObject> qObjects)
        {
            trapShapes = qObjects.Cast<GeoTrapShape>().ToList();
        }
    }

    public class GeoTrapShape : QuestObject
    {
        public GeoTrapShape() { }

        public GeoTrapShape(GeoTrapBox box)
        {
            ID = box.ID;

            geoTrap = box.comboBox_geotrap.Text;

            if (box.radioButton_box.Checked)
                type = "box";
            else
                type = "sphere";

            length = box.textBox_xscale.Text;
            width = box.textBox_zscale.Text;
            height = box.textBox_yscale.Text;

            position = new Position(new Coordinates(box.textBox_xcoord.Text, box.textBox_ycoord.Text, box.textBox_zcoord.Text), new Rotation(box.textBox_rot.Text));
        }

        public GeoTrapShape(Position pos, int num)
        {
            position = pos; ID = num;
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
            return "Shape_" + ID;
        }

        [XmlAttribute]
        public int ID { get; set; } = 0;

        [XmlElement]
        public string geoTrap { get; set; } = "GeoTrap_0";

        [XmlElement]
        public string type { get; set; } = "box";

        [XmlElement]
        public string length { get; set; } = "1";

        [XmlElement]
        public string width { get; set; } = "1";

        [XmlElement]
        public string height { get; set; } = "1";

        [XmlElement]
        public Position position { get; set; } = new Position(new Coordinates(), new Rotation());
    }
    
    public class GeoTrapMetadata : Metadata
    {
        public GeoTrapMetadata() { }

        public GeoTrapMetadata(GeoTrapControl control) { }
    }
}
