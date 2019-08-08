using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Linq;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.UI;
using SOC.Forms.Pages;

namespace SOC.QuestObjects.GeoTrap
{
    class GeoTrapVisualizer : LocationalVisualizer
    {
        public GeoTrapVisualizer(LocationalDataStub stub, GeoTrapControl control) : base(stub, control, control.panelQuestBoxes) { }

        public override void DrawMetadata(Metadata meta) { }

        public override Metadata GetMetadataFromControl()
        {
            return new GeoTrapMetadata((GeoTrapControl)detailControl);
        }

        public override QuestBox NewBox(QuestObject qObject)
        {
            return new GeoTrapBox((GeoTrapShape)qObject);
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            return new GeoTrapDetail(qObjects.Cast<GeoTrapShape>().ToList(), (GeoTrapMetadata)meta);
        }

        public override QuestObject NewObject(Position pos, int index)
        {
            return new GeoTrapShape(pos, index);
        }
    }
}
