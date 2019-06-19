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

namespace SOC.QuestObjects.Animal
{
    class AnimalVisualizer : LocationalVisualizer
    {
        public AnimalVisualizer(LocationalDataStub stub, AnimalControl control) : base(stub, control, control.panelQuestBoxes) { }

        public override void DrawMetadata(Metadata meta)
        {
            AnimalControl control = (AnimalControl)detailControl;
            control.SetMetadata((AnimalMetadata)meta);
        }

        public override Metadata GetMetadataFromControl()
        {
            return new AnimalMetadata((AnimalControl)detailControl);
        }

        public override QuestBox NewBox(QuestObject qObject, CoreDetails core)
        {
            return new AnimalBox((Animal)qObject);
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            return new AnimalDetail(qObjects.Cast<Animal>().ToList(), (AnimalMetadata)meta);
        }

        public override QuestObject NewObject(Position pos, int index)
        {
            return new Animal(pos, index);
        }
    }
}
