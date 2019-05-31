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

namespace SOC.QuestObjects.Vehicle
{
    class VehicleVisualizer : DetailVisualizer
    {
        public VehicleVisualizer(LocationalDataStub vehicleStub, VehicleControl vehicleControl) : base(vehicleStub, vehicleControl, vehicleControl.panelVehDet) { }

        public override void DrawMetadata(Metadata meta)
        {
            VehicleControl vehicleControl = (VehicleControl)detailControl;
            vehicleControl.SetMetadata((VehicleMetadata)meta);
        }

        public override Metadata GetMetadataFromControl()
        {
            return new VehicleMetadata((VehicleControl)detailControl);
        }

        public override QuestBox NewBox(QuestObject qObject)
        {
            return new VehicleBoxF((Vehicle)qObject, (VehicleMetadata)GetMetadataFromControl());
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            return new VehicleDetail(qObjects.Cast<Vehicle>().ToList(), (VehicleMetadata)meta);
        }

        public override QuestObject NewObject(Position objectPosition, int objectID)
        {
            return new Vehicle(objectPosition, objectID);
        }
    }
}
