using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    class OnAllocate : LuaMainComponent
    {
        public override string GetComponent()
        {
            return @"
function this.OnAllocate()
  TppQuest.RegisterQuestStepList{
    ""QStep_Start"",
    ""QStep_Main"",
    nil
  }
  TppEnemy.OnAllocateQuestFova(this.QUEST_TABLE)
  TppQuest.RegisterQuestStepTable(quest_step)
  TppQuest.RegisterQuestSystemCallbacks{
    OnActivate = function()
      TppEnemy.OnActivateQuest(this.QUEST_TABLE)
      TppAnimal.OnActivateQuest(this.QUEST_TABLE)
    end,
    OnDeactivate = function()
      TppEnemy.OnDeactivateQuest(this.QUEST_TABLE)
      TppAnimal.OnDeactivateQuest(this.QUEST_TABLE)

    end,
    OnOutOfAcitveArea = function()

    end,
    OnTerminate = function()
      this.SwitchEnableQuestHighIntTable(false, CPNAME, this.questCpInterrogation)
      TppEnemy.OnTerminateQuest(this.QUEST_TABLE)
      TppAnimal.OnTerminateQuest(this.QUEST_TABLE)
    end,
  }
  mvars.fultonInfo = NONE
end";
        }
    }
}
