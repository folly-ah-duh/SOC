using SOC.Classes.Fox2;
using SOC.Forms.Pages;
using System;
using System.Collections.Generic;

namespace SOC.QuestObjects.Common
{
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
            visualizer.GetDetailsFromStub(questDetail);

            if (questDetail.GetQuestObjects().Count > 0)
            {
                visualizer.ShowDetail();
            }
            else
            {
                visualizer.HideDetail();
            }

            visualizer.VisualizeDetail(questDetail);
        }
        
    }
}
