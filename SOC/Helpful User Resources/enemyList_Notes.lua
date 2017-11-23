local this = {}
local quest_step = {}
local StrCode32 = Fox.StrCode32
local StrCode32Table = Tpp.StrCode32Table
local GetGameObjectId = GameObject.GetGameObjectId
local i = 0

local hostageCount = 0
local CPNAME = "afgh_field_cp"
local useInter = true
local qType = TppDefine.QUEST_TYPE.RECOVERED

this.QUEST_TABLE = {

  questType = qType,
  
  isQuestArmor = true,
  
  --soldierSubType = "PF_A", -- CFA				If the sideop is located in Central Africa, you should assign the sideop with a soldier subtype.
  --soldierSubType = "PF_B", -- ZRS
  --soldierSubType = "PF_C", -- Rogue Coyote
  
  cpList = {
    nil
  },
  
  enemyList = {
    {
      enemyName = "sol_quest_0000",  							-- sol_quest_0000 through sol_quest_0007 are available to use for any sideop.
      route_d = "rt_field_d_0000",  							-- route_d is the "sneak route", the route that the enemy will walk if they are unaware of the player. Check Afghanistan_CP_Reference.lua -> sneakRoutes = { }.
	  route_c = "rt_field_c_0000",								-- route_c is the "caution route", the route travelled if the enemy is on alert. Check Afghanistan_CP_Reference.lua -> cautionRoutes = { }.
      cpName = CPNAME,											-- cpName is the CP that the soldier belongs to.
      powerSetting = { "SNIPER", "HELMET", "SOFT_ARMOR", },		-- powerSetting determines the specific equipment and tactics of the soldier. Check Soldier_Settings_Reference.lua -> powerSetting={} for a list of settings.
	},
	{
	  enemyName = "sol_quest_0001",		
      route_d = "rt_field_c_0001",  	-- you can assign caution routes to sneak routes, and vice versa. Using a c_route instead of a d_route will make the soldier look like he is on alert during sneak phases.
	  route_c = "rt_field_d_0001",		-- soldiers with d_routes instead of c_routes will still appear alert during the caution phases.
      cpName = CPNAME,
      powerSetting = {},
	  staffTypeId = TppDefine.STAFF_TYPE_ID.COMBAT,		-- you can assign a staff preference for each soldier. Check Soldier_Settings_Reference.lua -> staffTypeId = {} for preference types.
	  skill = "Counselor",								-- you can assign a skill to each soldier. Check Soldier_Settings_Reference.lua -> skill = {} for skill types.
	  bodyId = TppEnemyBodyId.svs0_unq_v421,			-- you can assign a unique outfit to each soldier. These outfits need to be added to the bodyIdList in the sideop definition. (GameDir\mod\quests\ih_quest_q# -> bodyIdList={})
														-- Check InfBodyInfo.lua in MGS_TPP\mod\modules\ for bodyIds and descriptions.
	},
	{
	  enemyName = "sol_quest_0002",
      route_d = "rt_field_d_0001",  
	  route_c = "rt_field_c_0001",
      cpName = CPNAME,
      powerSetting = { "QUEST_ARMOR", },		-- QUEST_ARMOR is the powerSetting for the heavily armored sideop soldiers. This should only be assigned to 8 soldiers at most, for any sideop.
	  --soldierSubType = "PF_A",				-- If the sideop is located in Central Africa, you should assign each soldier with a PF subtype.
	},
	{
	  enemyName = "sol_field_0000",  			-- Soldiers that are already loaded can also be retooled for sideops. Check Afghanistan_CP_Reference.lua -> soldier_names = {} for enemyNames
      route_d = "rt_field_d_0002",  
	  route_c = "rt_field_c_0002",
      cpName = CPNAME,
      powerSetting = { },
	},
	{
	  enemyName = "sol_fieldWest_0000",  		-- You can retool enemies from nearby outposts too. Check Afghanistan_OB_Reference.lua -> soldier_names = {} for enemyNames
      route_d = "rt_field_d_0003",  
	  route_c = "rt_field_c_0003",
      cpName = CPNAME,
      powerSetting = {},
	},
  },
  
  vehicleList = {
    
  },
  
  heliList = {
  
  },
  
  hostageList = {
    
  },
  
  targetList = {
	"sol_quest_0000",
	"sol_quest_0002",
  },
}


this.InterCall_hostage_pos01 = function( soldier2GameObjectId, cpID, interName )
  Fox.Log("CallBack : Quest InterCall_hostage_pos01")
  
	for i,hostageInfo in ipairs(this.QUEST_TABLE.hostageList)do
		TppMarker.EnableQuestTargetMarker(hostageInfo.hostageName)    
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
      Fox.Log("quest_recv_child OnActivate")
      
      TppEnemy.OnActivateQuest( this.QUEST_TABLE )
    end,
    OnDeactivate = function()
      Fox.Log("quest_recv_child OnDeactivate")
      
      TppEnemy.OnDeactivateQuest( this.QUEST_TABLE )
    end,
    OnOutOfAcitveArea = function()
    end,
    OnTerminate = function()
      
      this.SwitchEnableQuestHighIntTable( false, CPNAME, this.questCpInterrogation ) --
      
      TppEnemy.OnTerminateQuest( this.QUEST_TABLE )
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
	
	local commandScared = 	{id = "SetForceScared", 	scared=true, ever=true }
	local commandUnlocked = {id = "SetHostage2Flag", 	flag="unlocked",	 on=true,}
	local commandInjured =  {id = "SetHostage2Flag",	flag="disableFulton",on=true }
    local commandBrave =    {id = "SetHostage2Flag",	flag="disableScared",on=true }
	
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
          func = function( gameObjectId )
            local isClearType = TppEnemy.CheckQuestAllTarget( this.QUEST_TABLE.questType, "Dead", gameObjectId )
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
          func = function( gameObjectId )
            local isClearType = TppEnemy.CheckQuestAllTarget( this.QUEST_TABLE.questType, "Fulton", gameObjectId )
            mvars.fultonInfo = isClearType
          end
        },
        { 
          msg = "FultonFailed",
          func = function( gameObjectId, locatorName, locatorNameUpper, failureType )
            if failureType == TppGameObject.FULTON_FAILED_TYPE_ON_FINISHED_RISE then
              local isClearType = TppEnemy.CheckQuestAllTarget( this.QUEST_TABLE.questType, "FultonFailed", gameObjectId )
              TppQuest.ClearWithSave( isClearType )
            end
          end
        },
        { 
          msg = "PlacedIntoVehicle",
          func = function( gameObjectId, vehicleGameObjectId )
            if Tpp.IsHelicopter( vehicleGameObjectId ) then
              local isClearType = TppEnemy.CheckQuestAllTarget( this.QUEST_TABLE.questType, "InHelicopter", gameObjectId )
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
return this
