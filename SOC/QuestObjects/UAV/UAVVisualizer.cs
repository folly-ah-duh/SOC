using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.Forms;
using SOC.Forms.Pages;
using SOC.UI;
using SOC.Classes.Common;

namespace SOC.QuestObjects.UAV
{
    class UAVVisualizer : LocationalVisualizer
    {
        public UAVVisualizer(LocationalDataStub stub, UAVControl control) : base(stub, control, control.panelQuestBoxes) { }

        List<string> routes = new List<string>();

        public override void DrawMetadata(Metadata meta)
        {
            UAVControl control = (UAVControl)detailControl;
            //UAVControl.SetMetadata((UAVMetadata)meta);
        }

        public override Metadata GetMetadataFromControl()
        {
            return new UAVMetadata();
        }

        public override QuestBox NewBox(QuestObject qObject)
        {
            return new UAVBox((UAV)qObject, routes);
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            return new UAVDetail(qObjects.Cast<UAV>().ToList(), (UAVMetadata)meta);
        }

        public override QuestObject NewObject(Position pos, int index)
        {
            return new UAV(pos, index);
        }
    }
}
