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
        public Detail detail;

        public DetailVisualizer detailVisualizer;
        
        public DetailManager(Detail detail, DetailVisualizer visual)
        {
            this.detail = detail;
            detailVisualizer = visual;
        }

        public abstract DetailVisualizer GetVisualizer();

        public abstract void UpdateDetailFromControl();

        public abstract void UpdateDetailFromSetup(CoreDetails core);

        public void RefreshPanel(CoreDetails core)
        {
            if (detail.GetQuestObjects().Count > 0)
            {
                detailVisualizer.ShowDetail();
            }
            else
            {
                detailVisualizer.HideDetail();
            }

            detailVisualizer.VisualizeDetail(detail);
        }

        public virtual void AddToFox2Entities(DataSet dataSet, List<Fox2EntityClass> entityList) { return; }

        public virtual void AddToDefinitionLua(DefinitionLua definitionLua) { return; }

        public virtual void AddToMainLua(MainLua mainLua) { return; }

        public virtual void AddToAssets(FileAssets fileAssets) { return; }
    }

    public abstract class LocationalManager : DetailManager
    {
        public LocationalManager(Detail detail, LocationalVisualizer visual) : base(detail, visual)
        {
            detailVisualizer = visual;
        }

        public override DetailVisualizer GetVisualizer()
        {
            return detailVisualizer;
        }

        public override void UpdateDetailFromControl()
        {
            detail = detailVisualizer.GetDetailFromControl();
        }

        public LocationalDataStub GetStub()
        {
            LocationalVisualizer locVisualizer = (LocationalVisualizer)detailVisualizer;
            return locVisualizer.detailStub;
        }

        public void LoadStub()
        {
            LocationalVisualizer locVisualizer = (LocationalVisualizer)detailVisualizer;
            locVisualizer.DrawStubText(detail);
        }

        public void RefreshStub()
        {
            LocationalVisualizer locVisualizer = (LocationalVisualizer)detailVisualizer;
            locVisualizer.DrawStubText(detail);
        }

        public override void UpdateDetailFromSetup(CoreDetails core)
        {
            detailVisualizer.SetDetailsFromSetup(detail, core);
        }

        
    }

    public abstract class NonLocationalManager : DetailManager
    {
        public NonLocationalManager(Detail detail, NonLocationalVisualizer visual) : base(detail, visual)
        {
            detailVisualizer = visual;
        }

        public override DetailVisualizer GetVisualizer()
        {
            return detailVisualizer;
        }

        public override void UpdateDetailFromControl()
        {
            detail = detailVisualizer.GetDetailFromControl();
        }

        public override void UpdateDetailFromSetup(CoreDetails core)
        {
            detailVisualizer.SetDetailsFromSetup(detail, core);
        }
    }
}
