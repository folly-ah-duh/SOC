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
        public VehicleVisualizer(LocationalDataStub vehicleStub, VehicleControl vehicleControl) : base(vehicleStub, vehicleControl, vehicleControl.panelVehDet)
        {
        }

        public override void DrawMetadata(Metadata meta)
        {
            VehicleMetadata vehicleMeta = (VehicleMetadata)meta;
            VehicleControl vehiclePanel = (VehicleControl)detailControl;
            vehiclePanel.comboBox_vehObjType.Text = vehicleMeta.vehicleObjectiveType;
        }

        public override Metadata GetMetadataFromControl()
        {
            throw new NotImplementedException();
        }

        public override QuestBox NewBox(QuestObject qObject)
        {
            throw new NotImplementedException();
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            throw new NotImplementedException();
        }

        public override QuestObject NewObject(Position objectPosition, int objectID)
        {
            throw new NotImplementedException();
        }
    }
}
