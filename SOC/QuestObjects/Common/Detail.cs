using SOC.Core.Classes.InfiniteHeaven;
using SOC.Forms;
using SOC.Forms.Pages;
using SOC.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SOC.QuestObjects.Common
{
    public abstract class Detail
    {
        public abstract List<QuestObject> GetQuestObjects();

        public abstract void SetQuestObjects(List<QuestObject> qObjects);

        public abstract Metadata GetMetadata();

        public abstract DetailManager GetNewManager();
    }

    public abstract class QuestObject
    {
        public abstract Position GetPosition();

        public abstract void SetPosition(Position pos);

        public abstract int GetID();

        public abstract string GetObjectName();
    }

    public abstract class Metadata { }

    public abstract class DetailVisualizer
    {
        public UserControl detailControl { get; }

        public LocationalDataStub detailStub { get; }

        public FlowLayoutPanel flowPanel { get; }

        public DetailVisualizer(LocationalDataStub stub, UserControl control, FlowLayoutPanel panel)
        {
            detailControl = control; detailStub = stub; flowPanel = panel;
        }

        public void VisualizeDetail(Detail detail)
        {
            DrawMetadata(detail.GetMetadata());
            DrawBoxes(detail.GetQuestObjects());
        }

        public void ShowDetail()
        {
            detailControl.Visible = true;
        }

        public void HideDetail()
        {
            detailControl.Visible = false;
        }

        public abstract void DrawMetadata(Metadata meta);

        public void DrawBoxes(IEnumerable<QuestObject> questObjects)
        {
            int FailedToFindAllBoxesCount = 0;
            while(flowPanel.Controls.Count != 1) {
                foreach (QuestBox qBox in flowPanel.Controls.OfType<QuestBox>())
                {
                    flowPanel.Controls.Remove(qBox);
                }
                FailedToFindAllBoxesCount++;
            }

            foreach (QuestObject qObject in questObjects)
            {
                flowPanel.Controls.Add(NewBox(qObject));
            }
        }

        public Detail GetDetailFromControl()
        {
            return NewDetail(GetMetadataFromControl(), GetQuestObjectsFromControl());
        }

        public IEnumerable<QuestObject> GetQuestObjectsFromControl()
        {
            return flowPanel.Controls.OfType<QuestBox>().Select(box => box.getQuestObject());
        }

        public abstract Metadata GetMetadataFromControl();

        public void DrawStubText(Detail detail)
        {
            List<Position> posList = new List<Position>();

            foreach (QuestObject qObject in detail.GetQuestObjects())
            {
                posList.Add(qObject.GetPosition());
            }
            detailStub.SetStubText(new IHLogPositions(posList));
        }

        public void GetDetailsFromStub(Detail detail)
        {
            List<Position> stubPositions = detailStub.GetStubLocations().GetPositions();
            List<QuestObject> qObjects = detail.GetQuestObjects().ToList();
            int positionCount = stubPositions.Count;
            int objectCount = qObjects.Count;

            for (int i = 0; i < positionCount; i++)
            {
                if (i >= objectCount) // add
                {
                    qObjects.Add(NewObject(stubPositions[i], i));
                }
                else // modify
                {
                    qObjects[i].SetPosition(stubPositions[i]);
                }
            }

            for (int i = objectCount - 1; i >= positionCount; i--) //remove
            {
                qObjects.RemoveAt(i);
            }

            detail.SetQuestObjects(qObjects);
        }

        public abstract QuestObject NewObject(Position pos, int index);
        public abstract QuestBox NewBox(QuestObject qObject);
        public abstract Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects);
    }
}
