using SOC.Core.Classes.InfiniteHeaven;
using SOC.Forms;
using SOC.Forms.Pages;
using SOC.UI;
using System;
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
        public abstract void DrawMetadata(UserControl control);
    }

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
            /*
            string refreshPanel = "[VisualizeDetail] detail contains: ";
            foreach (QuestObject qob in detail.questObjects)
            {
                refreshPanel += qob.GetObjectName() + ": " + qob.position.coords.xCoord + ", " + qob.position.coords.yCoord + ", " + qob.position.coords.zCoord + " || ";
            }
            Console.WriteLine(refreshPanel);
            */

            DrawMetadata(detail.metaData);
            //Console.WriteLine("object count in details: " + detail.questObjects.Count());
            //Console.WriteLine("object count in flowpanel: " + flowPanel.Controls.Count);
            DrawBoxes(detail.questObjects);
        }
        public abstract void DrawMetadata(Metadata meta);

        public void DrawBoxes(IEnumerable<QuestObject> questObjects)
        {
            /*
            string refreshPanel = "[DrawBoxes] questObjects: ";
            foreach (QuestObject qob in questObjects)
            {
                refreshPanel += qob.GetObjectName() + ": " + qob.position.coords.xCoord + ", " + qob.position.coords.yCoord + ", " + qob.position.coords.zCoord + " || ";
            }
            Console.WriteLine(refreshPanel);
            */

            int FailedToFindAllBoxesCount = 0;
            while(flowPanel.Controls.Count != 1) { // No idea what's going on here. There should only be one control remaining (the width label).
                /*
                if (FailedToFindAllBoxesCount > 0) // This really screams "There's a reason I don't have a job", doesn't it?
                {
                    Console.WriteLine($"For some reason, this hasn't found all the boxes (Fail count: {FailedToFindAllBoxesCount}). Running again...");
                }
                */
                foreach (QuestBox qBox in flowPanel.Controls.OfType<QuestBox>())
                {
                    flowPanel.Controls.Remove(qBox);
                    //Console.WriteLine("removing old box from flowpanel..");
                }
                FailedToFindAllBoxesCount++;
            }

            foreach (QuestObject qObject in questObjects)
            {
                flowPanel.Controls.Add(NewBox(qObject));
                //Console.WriteLine("adding new box to flowpanel. ID: " + qObject.ID);
            }
            /*
            foreach (QuestBox qBox in flowPanel.Controls.OfType<QuestBox>())
            {
                Console.WriteLine("flowPanel box: " + qBox.getQuestObject().position.coords.xCoord);
            }
            */
        }

        public Detail GetDetailFromControl()
        {
            return NewDetail(GetMetadataFromControl(), GetQuestObjectsFromControl());
        }

        public IEnumerable<QuestObject> GetQuestObjectsFromControl()
        {
            /*
            foreach(QuestBox qbox in flowPanel.Controls.OfType<QuestBox>())
            {
                Console.WriteLine("[GetQuestObjectsFromControl]");
                Console.WriteLine(qbox.getQuestObject().ID);
            }
            */
            return flowPanel.Controls.OfType<QuestBox>().Select(box => box.getQuestObject());
        }

        public abstract Metadata GetMetadataFromControl();

        public void RefreshStubText(Detail detail)
        {
            List<Position> posList = new List<Position>();

            foreach (QuestObject qObject in detail.questObjects)
            {
                posList.Add(qObject.position);
                //Console.WriteLine("Added Position to Stub: " + qObject.GetObjectName() + " | " + qObject.position.coords.xCoord + ", " + qObject.position.coords.yCoord + ", " + qObject.position.coords.zCoord);
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
                    //Console.WriteLine("ADD");
                }
                else // modify
                {
                    qObjects[i].position = stubPositions[i];
                    //Console.WriteLine(qObjects[i].position.coords.xCoord + " : " + qObjects[i].position.coords.yCoord + " : " + qObjects[i].position.coords.zCoord);
                    //Console.WriteLine("MODIFY");
                }
            }

            for (int i = objectCount - 1; i >= positionCount; i--) //remove
            {
                qObjects.RemoveAt(i);
                //Console.WriteLine("REMOVE");
            }

            detail.questObjects = qObjects;
            /*
            string detailContains = "Detail Contains: ";
            foreach(QuestObject qObject in detail.questObjects)
            {
                detailContains += qObject.GetObjectName() + ", ";
            }
            Console.WriteLine(detailContains);
            */
        }

        public abstract QuestObject NewObject(Position pos, int index);
        public abstract QuestBox NewBox(QuestObject qObject);
        public abstract Detail NewDetail(Metadata meta, IEnumerable<QuestObject> qObjects);
    }
}
