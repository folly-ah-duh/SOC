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
using SOC.QuestObjects.Enemy;

namespace SOC.QuestObjects.Helicopter
{
    class HelicopterVisualizer : LocationalVisualizer
    {
        public HelicopterVisualizer(LocationalDataStub stub, HelicopterControl control) : base(stub, control, control.panelQuestBoxes) { }

        private List<string> routes = new List<string>();

        public override void DrawMetadata(Metadata meta)
        {
            HelicopterControl heliControl = (HelicopterControl)detailControl;
            heliControl.SetMetadata((HelicopterMetadata)meta);
        }

        public override Metadata GetMetadataFromControl()
        {
            return new HelicopterMetadata((HelicopterControl)detailControl);
        }

        public override QuestBox NewBox(QuestObject qObject)
        {
            return new HelicopterBox((Helicopter)qObject, routes);
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            return new HelicopterDetail(qObjects.Cast<Helicopter>().ToList(), (HelicopterMetadata)meta);
        }

        public override QuestObject NewObject(Position pos, int index)
        {
            return new Helicopter(pos, index);
        }

        public override void SetDetailsFromSetup(Detail detail, CoreDetails core)
        {
            RouteManager heliRouter = new RouteManager();
            List<string> heliRoutes = heliRouter.GetRouteNames(core.routeName);
            heliRoutes.AddRange(EnemyInfo.GetCP(core.CPName).CPheliRoutes);

            routes = heliRoutes;
            base.SetDetailsFromSetup(detail, core);

        }
    }
}
