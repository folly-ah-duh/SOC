using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOC.UI
{
    public abstract class QuestBox : UserControl
    {

        public abstract QuestObject getQuestObject();

    }
}
