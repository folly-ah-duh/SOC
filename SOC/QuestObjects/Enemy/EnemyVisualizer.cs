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
    class EnemyVisualizer : NonLocationalVisualizer
    {
        public EnemyVisualizer(EnemyControl control) : base(control, control.panelQuestBoxes) { }

        List<string> routes = new List<string>();

        public override void DrawMetadata(Metadata meta)
        {
            EnemyControl control = (EnemyControl)detailControl;
            control.SetMetadata((EnemyMetadata)meta);
        }

        public override Metadata GetMetadataFromControl()
        {
            return new EnemyMetadata((EnemyControl)detailControl);
        }

        public override QuestBox NewBox(QuestObject qObject)
        {
            return new EnemyBox((Enemy)qObject, routes); // also: regional body fovas
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            return new EnemyDetail(qObjects.Cast<Enemy>().ToList(), (EnemyMetadata)meta);
        }

        public override void SetDetailsFromSetup(Detail detail, CoreDetails core)
        {
            RouteManager router = new RouteManager();
            List<string> eneRoutes = router.GetRouteNames(core.routeName);
            eneRoutes.AddRange(EnemyInfo.GetCP(core.CPName).CPsoldierRoutes);
            routes = eneRoutes;

            string[] soldiers = EnemyInfo.GetCP(core.CPName).CPsoldiers;
            List<Enemy> qObjects = detail.GetQuestObjects().Cast<Enemy>().ToList();
            int soldierCount = soldiers.Length;
            int objectCount = qObjects.Count;

            for (int i = 0; i < soldierCount; i++)
            {
                if (i >= objectCount) // add
                {
                    qObjects.Add(new Enemy(soldiers[i]));
                    Console.WriteLine(soldiers[i]);
                }
                else // modify
                {
                    qObjects[i].name = soldiers[i];
                }
            }

            for (int i = objectCount - 1; i >= soldierCount; i--) //remove
            {
                qObjects.RemoveAt(i);
            }

            detail.SetQuestObjects(qObjects.Cast<QuestObject>().ToList());
        }
    }
}
