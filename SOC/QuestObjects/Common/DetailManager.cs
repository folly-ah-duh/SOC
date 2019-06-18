using SOC.Classes.Assets;
using SOC.Classes.Common;
using SOC.Classes.Fox2;
using SOC.Classes.Lua;
using SOC.Forms.Pages;
using System;
using System.Collections.Generic;

namespace SOC.QuestObjects.Common
{
    public abstract class DetailManager
    {
        public Detail questDetail;
        
        public DetailManager(Detail detail)
        {
            questDetail = detail;
        }

        public abstract DetailVisualizer GetVisualizer();

        public abstract void UpdateDetailFromControl();

        public abstract void UpdateDetailFromSetup(CoreDetails core);

        public abstract void RefreshPanel(CoreDetails core);

        public virtual void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList) { return; }

        public virtual void AddToDefinitionLua(DefinitionLua definitionLua) { return; }

        public virtual void AddToMainLua(MainLua mainLua) { return; }

        public virtual void AddToAssets(FileAssets fileAssets) { return; }
    }

    public abstract class LocationalManager : DetailManager
    {
        private LocationalVisualizer visualizer;

        public LocationalManager(Detail detail, LocationalVisualizer visual) : base(detail)
        {
            visualizer = visual;
        }

        public override DetailVisualizer GetVisualizer()
        {
            return visualizer;
        }

        public override void UpdateDetailFromControl()
        {
            questDetail = visualizer.GetDetailFromControl();
        }

        public void LoadStub()
        {
            visualizer.DrawStubText(questDetail);
        }

        public void RefreshStub()
        {
            visualizer.DrawStubText(questDetail);
        }

        public override void UpdateDetailFromSetup(CoreDetails core)
        {
            visualizer.SetDetailsFromStub(questDetail);
        }

        public override void RefreshPanel(CoreDetails core)
        {
            if (questDetail.GetQuestObjects().Count > 0)
            {
                visualizer.ShowDetail();
            }
            else
            {
                visualizer.HideDetail();
            }

            visualizer.VisualizeDetail(questDetail, core);
        }
    }

    public abstract class NonLocationalManager : DetailManager
    {
        private NonLocationalVisualizer visualizer;

        public NonLocationalManager(Detail detail) : base(detail) { }

        public override DetailVisualizer GetVisualizer()
        {
            return visualizer;
        }

        public override void UpdateDetailFromControl()
        {
            questDetail = visualizer.GetDetailFromControl();
        }

        public override void UpdateDetailFromSetup(CoreDetails core)
        {
            visualizer.SetDetailsFromCore(core);
        }

        public override void RefreshPanel(CoreDetails core)
        {
            if (questDetail.GetQuestObjects().Count > 0)
            {
                visualizer.ShowDetail();
            }
            else
            {
                visualizer.HideDetail();
            }

            visualizer.VisualizeDetail(questDetail, core);
        }
    }
}
