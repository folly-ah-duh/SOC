using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using SOC.Forms.Pages;
using SOC.UI;
using SOC.Classes.Common;
using System.Windows.Forms;

namespace SOC.QuestObjects.Item
{
    class ItemVisualizer : LocationalVisualizer
    {
        public ItemVisualizer(LocationalDataStub stub, ItemControl control) : base(stub, control, control.panelQuestBoxes) { }

        public override void DrawMetadata(Metadata meta)
        {
            ItemControl iControl = (ItemControl)detailControl;
            iControl.SetMetadata((ItemMetadata)meta);
        }

        public override Metadata GetMetadataFromControl()
        {
            return new ItemMetadata((ItemControl)detailControl);
        }

        public override QuestBox NewBox(QuestObject qObject, CoreDetails core)
        {
            return new ItemBox((Item)qObject);
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            return new ItemDetail(qObjects.Cast<Item>().ToList(), (ItemMetadata)meta);
        }

        public override QuestObject NewObject(Position pos, int index)
        {
            return new Item(pos, index);
        }
    }
}
