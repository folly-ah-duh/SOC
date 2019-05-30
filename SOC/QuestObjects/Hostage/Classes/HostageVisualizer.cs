using SOC.Core.Classes.InfiniteHeaven;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using SOC.Forms.Pages;
using SOC.Forms;
using SOC.UI;

namespace SOC.QuestObjects.Hostage
{
    class HostageVisualizer : DetailVisualizer
    {
        public HostageVisualizer(LocationalDataStub hostageStub, HostageControl hostageControl) : base(hostageStub, hostageControl, hostageControl.panelHosDet)
        {
            hostageControl.comboBox_Body.SelectedIndexChanged += OnBodyIndexChanged;
        }

        public override void DrawMetadata(Metadata meta)
        {
            HostageMetadata hostageMeta = (HostageMetadata)meta;
            hostageMeta.DrawMetadata(detailControl);
        }

        public override QuestBox NewBox(QuestObject qObject)
        {
            //Console.WriteLine("[Hostage NewBox] " + qObject.GetObjectName() + ": " + qObject.position.coords.xCoord + ", " + qObject.position.coords.yCoord + ", " + qObject.position.coords.zCoord + " || ");
            HostageBox hBox = new HostageBox((Hostage)qObject, (HostageMetadata)GetMetadataFromControl());
            //Console.WriteLine("Hostage NewBox2: " + hBox.getQuestObject().position.coords.xCoord);
            return hBox;
        }

        public override Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects)
        {
            return new HostageDetail(qObjects.Cast<Hostage>().ToList(), (HostageMetadata)meta);
        }

        public override Metadata GetMetadataFromControl()
        {
            return new HostageMetadata((HostageControl)detailControl);
        }

        public override QuestObject NewObject(Position objectPosition, int objectID)
        {
            Hostage h = new Hostage(objectPosition, objectID);
            //Console.WriteLine("[New Object] " + h.GetObjectName());
            return h;
        }

        private void OnBodyIndexChanged(object sender, EventArgs e)
        {
            RefreshHostageLanguage();
        }

        private void RefreshHostageLanguage()
        {
            HostageMetadata meta = (HostageMetadata)GetMetadataFromControl();
            foreach (HostageBox hBox in flowPanel.Controls.OfType<HostageBox>())
            {
                //Console.WriteLine("Refreshing language");
                hBox.RefreshLanguage(meta.hostageBodyName);
            }
        }
    }
}
