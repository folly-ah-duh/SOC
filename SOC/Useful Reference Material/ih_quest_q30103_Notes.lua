-- ih_quest_q30103.lua
-- IH quest definition - example quest
local this={
  questPackList={
    "/Assets/tpp/pack/mission2/ih/ih_hostage_base.fpk",--base hostage pack
    "/Assets/tpp/pack/mission2/ih/prs3_main0_mdl.fpk",--model pack, edit the partsType in the TppHostage2Parameter in the quest .fox2 to match, see InfBodyInfo.lua for different body types.
    "/Assets/tpp/pack/mission2/quest/ih/ih_example_quest.fpk",--quest fpk
    bodyIdList={
	  TppDefine.QUEST_BODY_ID_LIST.AFGH_ARMOR,
	  TppEnemyBodyId.pfs0_unq_v280,
	},
  },
  locationId=TppDefine.LOCATION_ID.AFGH,
  areaName="field",--tex use the 'Show position' command in the debug menu to print the quest area you are in to ih_log.txt, see TppQuest. afgAreaList,mafrAreaList,mtbsAreaList. 
  --If areaName doesn't match the area the iconPos is in the quest fpk will fail to load (even though the Commencing Sideop message will trigger fine).
  iconPos=Vector3(489.741,321.901,1187.506),--position of the quest area circle in idroid
  radius=4,--radius of the quest area circle
  category=TppQuest.QUEST_CATEGORIES_ENUM.PRISONER,--Category for the IH selection/filtering options.
  questCompleteLangId="quest_extract_hostage",--Used for feedback of quest progress, see REF questCompleteLangId in InfQuest
  canOpenQuest=InfQuest.AllwaysOpenQuest,--function that decides whether the quest is open or not
  questRank=TppDefine.QUEST_RANK.G,--reward rank for clearing quest, see TppDefine.QUEST_BONUS_GMP and TppHero.QUEST_CLEAR
  hasEnemyHeli=false,--set to true if you have added heliList in the quest script.
}

return this

