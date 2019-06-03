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

        public abstract void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList);

        public abstract string AddToDefinitionLua();

        public abstract string AddToPackListLua();

        public abstract void AddToMainLua(List<string> luaTemplate);

        public DetailVisualizer GetVisualizer()
        {
            return visualizer;
        }

        public void LoadStub()
        {
            visualizer.DrawStubText(questDetail);
        }

        public void UpdateDetailFromControl()
        {
            questDetail = visualizer.GetDetailFromControl();
        }

        public void RefreshStub()
        {
            visualizer.DrawStubText(questDetail);
        }

        public void UpdateDetailFromStub()
        {
            visualizer.GetDetailsFromStub(questDetail);
        }

        public void RefreshPanel()
        {
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
