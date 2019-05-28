using SOC.Classes.Fox2;
using SOC.Forms.Pages;
using System.Collections.Generic;

namespace SOC.QuestObjects.Common
{
    // a Manager is in charge of interactions between the base program and the manager's QuestObject module.
    public abstract class DetailManager
    {
        public Detail questDetail;
        
        public DetailVisualizer visualizer { get; set; }
        
        public DetailManager(Detail detail, DetailVisualizer visual)
        {
            questDetail = detail; visualizer = visual;
        }

        public abstract void AddFox2Entities(ref List<Fox2EntityClass> entityList);

        public DetailVisualizer GetVisualizer()
        {
            return visualizer;
        }
    }
}
