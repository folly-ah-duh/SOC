using SOC.QuestObjects.Common;
using System.Collections.Generic;
using System.Linq;
using SOC.Core.Classes.InfiniteHeaven;
using SOC.UI;
using SOC.Forms.Pages;

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

        public override QuestBox NewBox(QuestObject qObject)
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
