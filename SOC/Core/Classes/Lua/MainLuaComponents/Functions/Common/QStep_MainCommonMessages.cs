using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    public static class QStep_MainCommonMessages
    {
        static readonly QStep_Message PlayerPickUpWeapon = new QStep_Message("Player", @"""OnPickUpWeapon""", @"function(playerIndex, equipId)
              local isClearType = this.CheckQuestAllTargetDynamic(""PickUpDormant"", equipId)
              TppQuest.ClearWithSave(isClearType)
            end");

        static readonly QStep_Message PlayerPickUpPlaced = new QStep_Message("Player", @"""OnPickUpPlaced""", @"function(playerGameObjectId, equipId, index, isPlayer)
              if TppPlaced.IsQuestBlock(index) then
                local isClearType = this.CheckQuestAllTargetDynamic(""PickUpActive"", equipId)
                TppQuest.ClearWithSave(isClearType)
              end
            end");

        static readonly QStep_Message PlacedActivatePlaced = new QStep_Message("Placed", @"""OnActivatePlaced""", @"function(equipId, index)
              if TppPlaced.IsQuestBlock(index) then
                local isClearType = this.CheckQuestAllTargetDynamic(""Activate"", equipId)
                TppQuest.ClearWithSave(isClearType)
              end
            end");

        static readonly QStep_Message GameObjectDead = new QStep_Message("GameObject", @"""Dead""", @"function(gameObjectId,gameObjectId01,animalId)
              local isClearType = this.CheckQuestAllTargetDynamic(""Dead"",gameObjectId, animalId)
              TppQuest.ClearWithSave(isClearType)
            end");

        static readonly QStep_Message GameObjectFultonInfo = new QStep_Message("GameObject", @"""FultonInfo""", @"function(gameObjectId)
              if mvars.fultonInfo ~= NONE then
                TppQuest.ClearWithSave(mvars.fultonInfo)
              end
              mvars.fultonInfo = NONE
            end");

        static readonly QStep_Message GameObjectFulton = new QStep_Message("GameObject", @"""Fulton""", @"function(gameObjectId, animalId)
              local isClearType = this.CheckQuestAllTargetDynamic(""Fulton"", gameObjectId, animalId)
              TppQuest.ClearWithSave(isClearType)
            end");

        static readonly QStep_Message GameObjectFultonFailed = new QStep_Message("GameObject", @"""FultonFailed""", @"function(gameObjectId, locatorName, locatorNameUpper, failureType)
              if failureType == TppGameObject.FULTON_FAILED_TYPE_ON_FINISHED_RISE then
                local isClearType = this.CheckQuestAllTargetDynamic(""FultonFailed"", gameObjectId, locatorName)
                TppQuest.ClearWithSave(isClearType)
              end
            end");

        static readonly QStep_Message GameObjectPlacedIntoHeli = new QStep_Message("GameObject", @"""PlacedIntoVehicle""", @"function(gameObjectId, vehicleGameObjectId)
              if Tpp.IsHelicopter(vehicleGameObjectId) then
                local isClearType = this.CheckQuestAllTargetDynamic(""InHelicopter"", gameObjectId)
                TppQuest.ClearWithSave(isClearType)
              end
            end");

        static readonly QStep_Message GameObjectVehicleBroken = new QStep_Message("GameObject", @"""VehicleBroken""", @"function(gameObjectId, state)
			  if state == StrCode32(""End"") then
				local isClearType = this.CheckQuestAllTargetDynamic(""VehicleBroken"", gameObjectId)
				TppQuest.ClearWithSave(isClearType)
			  end
			end");

        static readonly QStep_Message GameObjectLostControl = new QStep_Message("GameObject", @"""LostControl""", @"function(gameObjectId, state)
			  if state == StrCode32(""End"") then
				local isClearType = this.CheckQuestAllTargetDynamic(""LostControl"", gameObjectId)
				TppQuest.ClearWithSave(isClearType)
			  end
			end");

        public static readonly QStep_Message[] allCommonMessages = { PlayerPickUpWeapon, PlayerPickUpPlaced, PlacedActivatePlaced, GameObjectDead, GameObjectFultonInfo, GameObjectFulton, GameObjectFultonFailed, GameObjectPlacedIntoHeli, GameObjectVehicleBroken, GameObjectLostControl };

        public static readonly QStep_Message[] genericTargetMessages = { GameObjectDead, GameObjectFultonInfo, GameObjectFulton, GameObjectFultonFailed, GameObjectPlacedIntoHeli, GameObjectVehicleBroken, GameObjectLostControl };

        public static readonly QStep_Message[] dormantItemTargetMessages = { PlayerPickUpWeapon };

        public static readonly QStep_Message[] activeItemTargetMessages = { PlayerPickUpPlaced, PlacedActivatePlaced };

        public static readonly QStep_Message[] mechaCaptureTargetMessages = { GameObjectDead, GameObjectFultonInfo, GameObjectFulton, GameObjectFultonFailed, GameObjectVehicleBroken };

        public static readonly QStep_Message[] mechaNoCaptureTargetMessages = { GameObjectDead, GameObjectVehicleBroken, GameObjectLostControl };

        public static readonly QStep_Message[] animalTargetMessages = { GameObjectDead, GameObjectFultonInfo, GameObjectFulton, GameObjectFultonFailed };
    }
}
