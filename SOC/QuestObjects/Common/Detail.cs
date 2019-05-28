using SOC.Core.Classes.InfiniteHeaven;
using SOC.Forms;
using SOC.Forms.Pages;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SOC.QuestObjects.Common
{
    public abstract class Detail
    {
        public IEnumerable<QuestObject> questObjects;

        public Metadata metaData;

        public Detail(IEnumerable<QuestObject> qObjects, Metadata meta)
        {
            questObjects = qObjects; metaData = meta;
        }

        public abstract DetailManager GetNewManager();
    }

    public abstract class QuestObject
    {
        public Position position;

        public int ID;

        public QuestObject(Position pos, int i)
        {
            position = pos; ID = i;
        }

        public abstract string GetObjectName();
    }

    public abstract class Metadata
    {

    }

    public abstract class DetailVisualizer
    {
        public UserControl detailPanel { get; }

        public LocationalDataStub detailStub { get; }

        public List<QuestBox> objectBoxes { get; }
        
        public DetailVisualizer(LocationalDataStub stub, UserControl panel)
        {
            detailPanel = panel; detailStub = stub;
            objectBoxes = new List<QuestBox>();
        }

        public void VisualizeDetail(Detail detail)
        {
            DrawMetadata(detail.metaData);
            DrawBoxes(detail.questObjects);
        }
        public abstract void DrawMetadata(Metadata meta);

        public void DrawBoxes(IEnumerable<QuestObject> questObjects)
        {
            objectBoxes.Clear();
            foreach (QuestObject qObject in questObjects)
            {
                objectBoxes.Add(NewBox(qObject));
            }
        }

        public Detail GetDetailFromPanel()
        {
            return NewDetail(GetQuestObjects(), GetMetadata());
        }

        public Metadata GetMetadata()
        {
            return NewMetadata(detailPanel);
        }

        public List<QuestObject> GetQuestObjects()
        {
            return objectBoxes.Select(entry => entry.getQuestObject()).ToList();
        }

        public void RefreshStubText(Detail detail)
        {
            List<Position> posList = new List<Position>();

            foreach (QuestObject qObject in detail.questObjects)
            {
                posList.Add(qObject.position);
            }

            detailStub.SetStubText(new IHLogPositions(posList));
        }

        public void GetDetailsFromStub(ref Detail detail)
        {
            List<Position> stubPositions = detailStub.GetStubLocations().GetPositions();
            List<QuestObject> qObjects = detail.questObjects.ToList();
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
                    qObjects[i].position = stubPositions[i];
                }
            }

            for (int i = objectCount - 1; i >= positionCount; i--) //remove
            {
                qObjects.RemoveAt(i);
            }

            detail.questObjects = qObjects;
        }

        public abstract QuestObject NewObject(Position objectPosition, int objectID);
        public abstract QuestBox NewBox(QuestObject qObject);
        public abstract Detail NewDetail(List<QuestObject> qObjects, Metadata meta);
        public abstract Metadata NewMetadata(UserControl detailPanel);
    }
}
