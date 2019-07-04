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

namespace SOC.QuestObjects.Camera
{
    class CameraVisualizer : LocationalVisualizer
    {
        public CameraVisualizer(LocationalDataStub stub, CameraControl control) : base(stub, control, control.panelQuestBoxes) { }

        public override void DrawMetadata(Metadata meta)
        {
            CameraControl control = (CameraControl)detailControl;
            control.SetMetadata((CameraMetadata)meta);
        }

        public override Metadata GetMetadataFromControl()
        {
            return new CameraMetadata();
        }

        public override QuestBox NewBox(QuestObject qObject)
        {
            return new CameraBox((Camera)qObject);
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            return new CameraDetail(qObjects.Cast<Camera>().ToList(), (CameraMetadata)meta);
        }

        public override QuestObject NewObject(Position pos, int index)
        {
            return new Camera(pos, index);
        }
    }
}
