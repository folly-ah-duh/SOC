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

namespace SOC.QuestObjects.Enemy
{
    class EnemyVisualizer
    {
        /*
        public EnemyVisualizer(LocationalDataStub stub, EnemyControl control) : base(stub, control, control.panelQuestBoxes) { }

        public override void DrawMetadata(Metadata meta)
        {
            EnemyControl control = (EnemyControl)detailControl;
            control.SetMetadata((EnemyMetadata)meta);
        }

        public override Metadata GetMetadataFromControl()
        {
            return new EnemyMetadata((EnemyControl)detailControl);
        }

        public override QuestBox NewBox(QuestObject qObject, CoreDetails core)
        {
            return new EnemyBox((Enemy)qObject, core);
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            return new EnemyDetail(qObjects.Cast<Enemy>().ToList(), (EnemyMetadata)meta);
        }

        public override QuestObject NewObject(Position pos, int index)
        {
            return new Enemy(index);
        }
        */
    }
}
