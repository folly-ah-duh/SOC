local this = {}
local quest_step = {}
local StrCode32 = Fox.StrCode32
local StrCode32Table = Tpp.StrCode32Table
local GetGameObjectId = GameObject.GetGameObjectId
local i = 0

local hostageCount = 0
local CPNAME = ""
local useInter = true
local qType = TppDefine.QUEST_TYPE.RECOVERED
local SUBTYPE = ""

this.QUEST_TABLE = {

    questType = qType,
	soldierSubType = SUBTYPE,
	isQuestArmor = true,
	isQuestZombie = true,
	isQuestBalaclava = true,

    cpList = {
      nil
    },

    enemyList = {

    },

    vehicleList = {

    },

    heliList = {

    },

    hostageList = {

    },

    animalList = {

    },

    targetList = {

    },

    targetAnimalList = {

    },
}

this.InterCall_hostage_pos01 = function( soldier2GameObjectId, cpID, interName )
  Fox.Log("CallBack : Quest InterCall_hostage_pos01")

  for i,hostageInfo in ipairs(this.QUEST_TABLE.hostageList)do
	if hostageInfo.isTarget then
		TppMarker.EnableQuestTargetMarker(hostageInfo.hostageName)
	else
		TppMarker.Enable(hostageInfo.hostageName,0,"defend","map_and_world_only_icon",0,false,true)
	end
  end
end

this.questCpInterrogation = {


    { name = "enqt1000_271b10", func = this.InterCall_hostage_pos01, },


}

function this.OnAllocate()
  TppQuest.RegisterQuestStepList{
    "QStep_Start",
    "QStep_Main",
    nil
  }
  
  TppEnemy.OnAllocateQuestFova( this.QUEST_TABLE )

  TppQuest.RegisterQuestStepTable( quest_step )
  TppQuest.RegisterQuestSystemCallbacks{
    OnActivate = function()
      TppEnemy.OnActivateQuest( this.QUEST_TABLE )
      TppAnimal.OnActivateQuest(this.QUEST_TABLE)
    end,
    OnDeactivate = function()
      TppEnemy.OnDeactivateQuest( this.QUEST_TABLE )
      TppAnimal.OnDeactivateQuest(this.QUEST_TABLE)
    end,
    OnOutOfAcitveArea = function()
    end,
    OnTerminate = function()
      this.SwitchEnableQuestHighIntTable( false, CPNAME, this.questCpInterrogation )
      TppEnemy.OnTerminateQuest( this.QUEST_TABLE )
      TppAnimal.OnTerminateQuest(this.QUEST_TABLE)
    end,
  }

  mvars.fultonInfo = TppDefine.QUEST_CLEAR_TYPE.NONE
end

this.Messages = function()
  return
    StrCode32Table {
      Block = {
        {
          msg = "StageBlockCurrentSmallBlockIndexUpdated",
          func = function() end,
        },
      },
    }
end

function this.OnInitialize()
  TppQuest.QuestBlockOnInitialize( this )
end

function this.OnUpdate()
  TppQuest.QuestBlockOnUpdate( this )
end

function this.OnTerminate()
  TppQuest.QuestBlockOnTerminate( this )
end

quest_step.QStep_Start = {
  OnEnter = function()
    InfCore.PCall(this.WarpHostages)
    InfCore.PCall(this.WarpVehicles)

    this.SwitchEnableQuestHighIntTable( true, CPNAME, this.questCpInterrogation ) --
    TppQuest.SetNextQuestStep( "QStep_Main" )

    local commandScared =   {id = "SetForceScared",   scared=true, ever=true }
    local commandUnlocked = {id = "SetHostage2Flag",  flag="unlocked",   on=true,}
    local commandInjured =  {id = "SetHostage2Flag",  flag="disableFulton",on=true }
    local commandBrave =    {id = "SetHostage2Flag",  flag="disableScared",on=true }

    --Hostage Attributes List--


  end,
}

quest_step.QStep_Main = {
  Messages = function( self )
    return
      StrCode32Table {
        Marker = {
          {
            msg = "ChangeToEnable",
            func = function ( arg0, arg1 )
              Fox.Log("### Marker ChangeToEnable  ###"..arg0 )
              if arg0 == StrCode32("Hostage_0") then
                i = i + 1
                if i >= hostageCount then
                  this.SwitchEnableQuestHighIntTable( false, CPNAME, this.questCpInterrogation )
                end
              end
            end
          },
        },
        GameObject = {
          {
            msg = "Dead",
            func = function(gameObjectId,gameObjectId01,animalId)
              local isClearType = this.CheckQuestAllTarget(this.QUEST_TABLE.questType,"Dead",gameObjectId,animalId)
              TppQuest.ClearWithSave( isClearType )
            end
          },
          {
            msg = "FultonInfo",
            func = function( gameObjectId )
              if mvars.fultonInfo ~= TppDefine.QUEST_CLEAR_TYPE.NONE then
                TppQuest.ClearWithSave( mvars.fultonInfo )
              end
              mvars.fultonInfo = TppDefine.QUEST_CLEAR_TYPE.NONE
            end
          },
          {
            msg = "Fulton",
            func = function(gameObjectId,animalId)
              local isClearType = this.CheckQuestAllTarget(this.QUEST_TABLE.questType, "Fulton", gameObjectId,animalId)
              TppQuest.ClearWithSave( isClearType )
            end
          },
          {
            msg = "FultonFailed",
            func = function(gameObjectId,locatorName,locatorNameUpper,failureType)
              if failureType == TppGameObject.FULTON_FAILED_TYPE_ON_FINISHED_RISE then
                local isClearType = this.CheckQuestAllTarget(this.QUEST_TABLE.questType,"FultonFailed",gameObjectId,locatorName)
                TppQuest.ClearWithSave( isClearType )
              end
            end
          },
          {
            msg = "PlacedIntoVehicle",
            func = function( gameObjectId, vehicleGameObjectId )
              if Tpp.IsHelicopter( vehicleGameObjectId ) then
                local isClearType = this.CheckQuestAllTarget(this.QUEST_TABLE.questType, "InHelicopter", gameObjectId)
                TppQuest.ClearWithSave( isClearType )
              end
            end
          },
        },
      }
  end,
  OnEnter = function()
    Fox.Log("QStep_Main OnEnter")
  end,
  OnLeave = function()
    Fox.Log("QStep_Main OnLeave")
  end,
}

function this.WarpHostages()
  for i,hostageInfo in ipairs(this.QUEST_TABLE.hostageList)do
    local gameObjectId=GameObject.GetGameObjectId(hostageInfo.hostageName)
    if gameObjectId~=GameObject.NULL_ID then
      local position=hostageInfo.position
      local command={id="Warp",degRotationY=position.rotY,position=Vector3(position.pos[1],position.pos[2],position.pos[3])}
      GameObject.SendCommand(gameObjectId,command)
    end
  end
end

function this.WarpVehicles()
  for i,vehicleInfo in ipairs(this.QUEST_TABLE.vehicleList)do
    local gameObjectId=GameObject.GetGameObjectId(vehicleInfo.locator)
    if gameObjectId~=GameObject.NULL_ID then
      local position=vehicleInfo.position
      local command={id="SetPosition",rotY=position.rotY,position=Vector3(position.pos[1],position.pos[2],position.pos[3])}
      GameObject.SendCommand(gameObjectId,command)
    end
  end
end

this.SwitchEnableQuestHighIntTable = function( flag, commandPostName, questCpInterrogation)
  local commandPostId = GameObject.GetGameObjectId( "TppCommandPost2" , commandPostName )
  if useInter then
    if flag then

      TppInterrogation.SetQuestHighIntTable( commandPostId, questCpInterrogation )
    else

      TppInterrogation.RemoveQuestHighIntTable( commandPostId, questCpInterrogation )
    end
  end
end

function this.CheckQuestAllTarget(questType,messageId,gameId,checkAnimalId)
  local clearType=TppDefine.QUEST_CLEAR_TYPE.NONE
  local inTargetList=false
  local totalTargets=0
  local fultonedCount=0
  local failedFultonCount=0
  local killedOrDestroyedCount=0
  local vanishedCount=0
  local inHeliCount=0
  local countIncreased=true
  local RENAMEsomeBool=false
  local currentQuestName=TppQuest.GetCurrentQuestName()

  if TppQuest.IsEnd(currentQuestName)then
    return clearType
  end

  -- human targets

  if mvars.ene_questTargetList[gameId]then
    local targetInfo=mvars.ene_questTargetList[gameId]
    if targetInfo.messageId~="None"and targetInfo.isTarget==true then
      RENAMEsomeBool=true
    elseif targetInfo.isTarget==false then
      RENAMEsomeBool=true
    end
    targetInfo.messageId=messageId or"None"
    inTargetList=true
  end

  -- animal targets
  
  if Tpp.IsAnimal(gameId)then
    local databaseId=TppAnimal.GetDataBaseIdFromAnimalId(checkAnimalId)
	
    for animalId,targetInfo in pairs(mvars.ani_questTargetList)do
      if targetInfo.idType=="animalId"then
        if animalId==checkAnimalId then
          targetInfo.messageId=messageId or"None"
          inTargetList=true
        end
      elseif targetInfo.idType=="databaseId"then
        if animalId==databaseId then
          targetInfo.messageId=messageId or"None"
          inTargetList=true
        end
      elseif targetInfo.idType=="targetName"then
        local animalGameId=GetGameObjectId(animalId)
        if animalGameId==gameId then
          targetInfo.messageId=messageId or"None"
          inTargetList=true
        end
		
      end
    end
  end
  if inTargetList==false then
    return clearType
  end

  -- human count builder

  for targetGameId,targetInfo in pairs(mvars.ene_questTargetList)do 
    local isTarget=targetInfo.isTarget or false

    if isTarget==true then
      local targetMessageId=targetInfo.messageId
      if targetMessageId~="None"then 
        if targetMessageId=="Fulton"then
          fultonedCount=fultonedCount+1
          countIncreased=true
      elseif targetMessageId=="InHelicopter"then
        inHeliCount=inHeliCount+1
        countIncreased=true
      elseif targetMessageId=="FultonFailed"then
        failedFultonCount=failedFultonCount+1
        countIncreased=true
      elseif targetMessageId=="Dead" or targetMessageId=="VehicleBroken" or targetMessageId=="LostControl" then
        killedOrDestroyedCount=killedOrDestroyedCount+1
        countIncreased=true
      elseif targetMessageId=="Vanished"then
        vanishedCount=vanishedCount+1
        countIncreased=true
      end
      end
      totalTargets=totalTargets+1 
    end
  end

  -- animal count builder

  for animalId,targetInfo in pairs(mvars.ani_questTargetList)do
    local targetMessageId = targetInfo.messageId
    if targetMessageId~="None"then
      if targetMessageId=="Fulton"then
        fultonedCount=fultonedCount+1
        countIncreased=true
      elseif targetMessageId=="FultonFailed"then
        failedFultonCount=failedFultonCount+1
        countIncreased=true
      elseif targetMessageId == "Dead" then
        killedOrDestroyedCount=killedOrDestroyedCount+1
        countIncreased=true
      end
    end
    totalTargets=totalTargets+1
  end
  if RENAMEsomeBool==true then
    countIncreased=false
  end

  if totalTargets>0 then 
    if questType==TppDefine.QUEST_TYPE.RECOVERED then
      if fultonedCount + inHeliCount >= totalTargets then 
        clearType=TppDefine.QUEST_CLEAR_TYPE.CLEAR
      elseif failedFultonCount > 0 or killedOrDestroyedCount > 0 then 
        clearType=TppDefine.QUEST_CLEAR_TYPE.FAILURE
      elseif fultonedCount+inHeliCount>0 then
        if countIncreased==true then
          clearType=TppDefine.QUEST_CLEAR_TYPE.UPDATE
      end
      end

  elseif questType==TppDefine.QUEST_TYPE.ELIMINATE then
    if fultonedCount + failedFultonCount + killedOrDestroyedCount + inHeliCount >= totalTargets then
      clearType=TppDefine.QUEST_CLEAR_TYPE.CLEAR
    elseif fultonedCount + failedFultonCount + killedOrDestroyedCount + inHeliCount > 0 then
      if countIncreased == true then
        clearType = TppDefine.QUEST_CLEAR_TYPE.UPDATE 
      end
    end

  elseif questType == TppDefine.QUEST_TYPE.MSF_RECOVERED then
    if fultonedCount >= totalTargets or inHeliCount >= totalTargets then 
      clearType=TppDefine.QUEST_CLEAR_TYPE.CLEAR
    elseif failedFultonCount > 0 or killedOrDestroyedCount > 0 or vanishedCount > 0 then 
      clearType=TppDefine.QUEST_CLEAR_TYPE.FAILURE
    end
  end
  end

  return clearType
end

return this
