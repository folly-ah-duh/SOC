using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.UI;
using SOC.Forms.Pages;
using System.Windows.Forms;
using SOC.Classes.Common;
using SOC.Core.Classes.Route;

namespace SOC.QuestObjects.ActiveItem
{
    class ActiveItemVisualizer : LocationalVisualizer
    {
        public ActiveItemVisualizer(LocationalDataStub stub, ActiveItemControl control) : base(stub, control, control.panelQuestBoxes) { }

        public override void DrawMetadata(Metadata meta)
        {
            ActiveItemControl control = (ActiveItemControl)detailControl;
            control.SetMetadata((ActiveItemMetadata)meta);
        }

        public override Metadata GetMetadataFromControl()
        {
            return new ActiveItemMetadata((ActiveItemControl)detailControl);
        }

        public override QuestBox NewBox(QuestObject qObject, CoreDetails core)
        {
            return new ActiveItemBox((ActiveItem)qObject);
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            return new ActiveItemDetail(qObjects.Cast<ActiveItem>().ToList(), (ActiveItemMetadata)meta);
        }

        public override QuestObject NewObject(Position pos, int index)
        {
            return new ActiveItem(pos, index);
        }
    }
}
