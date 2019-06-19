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

namespace SOC.QuestObjects.Helicopter
{
    class HelicopterVisualizer : LocationalVisualizer
    {
        public HelicopterVisualizer(LocationalDataStub stub, HelicopterControl control) : base(stub, control, control.panelQuestBoxes) { }

        public override void DrawMetadata(Metadata meta)
        {
            HelicopterControl heliControl = (HelicopterControl)detailControl;
            heliControl.SetMetadata((HelicopterMetadata)meta);
        }

        public override Metadata GetMetadataFromControl()
        {
            return new HelicopterMetadata((HelicopterControl)detailControl);
        }

        public override QuestBox NewBox(QuestObject qObject, CoreDetails core)
        {
            RouteManager router = new RouteManager();
            List<string> routes = router.GetRouteNames(core.routeName);
            routes.AddRange(EnemyInfo.GetCP(core.CPName).CPheliRoutes);

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
    }
}
