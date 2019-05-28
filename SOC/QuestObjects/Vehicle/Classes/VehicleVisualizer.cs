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

namespace SOC.QuestObjects.Vehicle
{
    class VehicleVisualizer : DetailVisualizer
    {
        public VehicleVisualizer(LocationalDataStub vehicleStub, VehiclePanel vehiclePanel) : base(vehicleStub, vehiclePanel)
        {
        }

        public override void DrawMetadata(Metadata meta)
        {
            VehicleMetadata vehicleMeta = (VehicleMetadata)meta;
            VehiclePanel vehiclePanel = (VehiclePanel)detailPanel;
            vehiclePanel.comboBox_vehObjType.Text = vehicleMeta.vehicleObjectiveType;
        }

        public override QuestBox NewBox(QuestObject qObject)
        {
            throw new NotImplementedException();
        }

        public override Detail NewDetail(List<QuestObject> qObjects, Metadata meta)
        {
            throw new NotImplementedException();
        }

        public override Metadata NewMetadata(UserControl detailPanel)
        {
            throw new NotImplementedException();
        }

        public override QuestObject NewObject(Position objectPosition, int objectID)
        {
            throw new NotImplementedException();
        }
    }
}
