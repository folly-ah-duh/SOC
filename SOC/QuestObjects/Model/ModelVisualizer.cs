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

namespace SOC.QuestObjects.Model
{
    class ModelVisualizer : DetailVisualizer
    {
        public ModelVisualizer(LocationalDataStub stub, ModelControl control) : base(stub, control, control.panelStMdDet) { }

        public override void DrawMetadata(Metadata meta)
        {
            return;
        }

        public override Metadata GetMetadataFromControl()
        {
            return new ModelMetadata();
        }

        public override QuestBox NewBox(QuestObject qObject, CoreDetails core)
        {
            return new ModelBox((Model)qObject);
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            return new ModelDetail(qObjects.Cast<Model>().ToList(), (ModelMetadata)meta);
        }

        public override QuestObject NewObject(Position pos, int index)
        {
            return new Model(pos, index);
        }
    }
}
