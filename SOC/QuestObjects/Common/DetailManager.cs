using SOC.Classes.Fox2;
using SOC.Forms.Pages;
using System;
using System.Collections.Generic;

namespace SOC.QuestObjects.Common
{
    // a Manager is in charge of interactions between the base program and the manager's QuestObject module.
    public abstract class DetailManager
    {
        public Detail questDetail;

        private DetailVisualizer visualizer;
        
        public DetailManager(Detail detail, DetailVisualizer visual)
        {
            questDetail = detail; visualizer = visual;
        }

        public abstract void AddFox2Entities(ref List<Fox2EntityClass> entityList);

        public DetailVisualizer GetVisualizer()
        {
            return visualizer;
        }

        public void LoadStub()
        {
            visualizer.DrawStubText(questDetail);
        }

        public void RefreshStub()
        {
            questDetail = visualizer.GetDetailFromControl();
            visualizer.DrawStubText(questDetail);
        }

        public void RefreshPanel()
        {
            visualizer.GetDetailsFromStub(ref questDetail);
            /*
            string refreshPanel = "[RefreshPanel] questDetail contains: ";
            foreach(QuestObject qob in questDetail.questObjects)
            {
                refreshPanel += qob.GetObjectName() + ": " + qob.GetPosition().coords.xCoord + ", " + qob.GetPosition().coords.yCoord + ", " + qob.GetPosition().coords.zCoord + " || ";
            }
            Console.WriteLine(refreshPanel);
            */
            visualizer.VisualizeDetail(questDetail);
        }
        
    }
}
