using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    class CheckQuestItem : CheckQuestMethodsPair
    {
        static readonly LuaFunction IsTargetSetMessageIdForItem = new LuaFunction("IsTargetSetMessageIdForItem",
    @"
function this.IsTargetSetMessageIdForItem(gameId, messageId, checkAnimalId)
	if messageId == ""PickUp"" or messageId == ""Activate"" then
		for i, targetInfo in pairs(this.QUEST_TABLE.targetItemList) do
			if gameId == targetInfo.equipId and targetInfo.messageId == ""None"" then
				targetInfo.messageId = messageId
				return true, true
			end
		end
	end
	return false, false
end");

        static readonly LuaFunction TallyItemTargets = new LuaFunction("TallyItemTargets",
            @"
function this.TallyAnimalTargets(totalTargets, objectiveCompleteCount, objectiveFailedCount)
	local dynamicQuestType = RECOVERED
  for animalId, targetInfo in pairs(mvars.ani_questTargetList) do
    local targetMessageId = targetInfo.messageId

    if targetMessageId ~= ""None"" then
      if dynamicQuestType == RECOVERED then
        if (targetMessageId == ""Fulton"") then
          objectiveCompleteCount = objectiveCompleteCount + 1
        elseif (targetMessageId == ""FultonFailed"") or (targetMessageId == ""Dead"") then
          objectiveFailedCount = objectiveFailedCount + 1
        end

      elseif dynamicQuestType == ELIMINATE then
        if (targetMessageId == ""Fulton"") or (targetMessageId == ""FultonFailed"") or (targetMessageId == ""Dead"") then
          objectiveCompleteCount = objectiveCompleteCount + 1
        end

		  elseif dynamicQuestType == KILLREQUIRED then
		    if (targetMessageId == ""FultonFailed"") or (targetMessageId == ""Dead"") then
	          objectiveCompleteCount = objectiveCompleteCount + 1
        elseif (targetMessageIfunction this.TallyItemTargets(totalTargets, objectiveCompleteCount, objectiveFailedCount)
	local dynamicQuestType = RECOVERED
  for i, targetInfo in pairs(this.QUEST_TABLE.targetItemList) do
    local targetMessageId = targetInfo.messageId

	  if targetMessageId ~= ""None"" then
	    if dynamicQuestType == RECOVERED then
	      if (targetMessageId == ""PickUp"") then
	        objectiveCompleteCount = objectiveCompleteCount + 1
	      elseif (targetMessageId == ""Activate"") then
	        objectiveFailedCount = objectiveFailedCount + 1
	      end

	    elseif dynamicQuestType == ELIMINATE then
	      if (targetMessageId == ""PickUp"") or (targetMessageId == ""Activate"") then
	        objectiveCompleteCount = objectiveCompleteCount + 1
	      end

			elseif dynamicQuestType == KILLREQUIRED then
			  if (targetMessageId == ""Activate"") then
		        objectiveCompleteCount = objectiveCompleteCount + 1
	      elseif (targetMessageId == ""PickUp"") then
	        objectiveFailedCount = objectiveFailedCount + 1
	      end
    	end
  	end
    totalTargets = totalTargets + 1
  end
	return totalTargets, objectiveCompleteCount, objectiveFailedCount
end");
        
        public CheckQuestItem(MainLua mainLua) : base(mainLua, IsTargetSetMessageIdForItem, TallyItemTargets) { }
    }
}
