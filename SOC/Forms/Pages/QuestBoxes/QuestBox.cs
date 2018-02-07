using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SOC.QuestComponents.GameObjectInfo;

namespace SOC.Forms.Pages.QuestBoxes
{
    public abstract class QuestBox
    {
        Coordinates objectCoordinates;
        int objectNumber;

        public QuestBox(Coordinates coord, int num)
        {
            objectCoordinates = coord;
            objectNumber = num;
        }

        public int getIndex()
        {
            return objectNumber;
        }

        public Coordinates getCoords()
        {
            return objectCoordinates;
        }

        public void FocusGroupBox(object sender, EventArgs e)
        {
            getGroupBoxMain().Focus();
        }

        public abstract GroupBox getGroupBoxMain();

        public abstract void SetObject(QuestBox detail);

        public abstract void BuildObject(int width);


    }
}
