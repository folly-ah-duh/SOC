using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOC.Classes.Lua;

namespace SOC.QuestObjects.WalkerGear
{
    static class WalkerLua
    {
        static readonly LuaFunction SetupGearsQuest = new LuaFunction("SetupGearsQuest", @"
function this.SetupGearsQuest(setupOnce)
  if setupOnce == true then
    for i,walkerInfo in ipairs(this.QUEST_TABLE.walkerList)do
      local walkerId = GetGameObjectId(""TppCommonWalkerGear2"",walkerInfo.walkerName)
      if walkerId ~= GameObject.NULL_ID then

        local commandWeapon={ id = ""SetMainWeapon"", weapon = walkerInfo.primaryWeapon}
        GameObject.SendCommand(walkerId, commandWeapon)

        local commandColor = { id = ""SetColoringType"", type = walkerInfo.colorType }
        GameObject.SendCommand(walkerId, commandColor)

        if walkerInfo.riderName then
          local soldierId = GetGameObjectId( ""TppSoldier2"", walkerInfo.riderName )
          local commandRide = { id = ""SetRelativeVehicle"", targetId = walkerId, rideFromBeginning = true  }
          GameObject.SendCommand( soldierId, commandRide )
        end

		local position = walkerInfo.position
        local commandPos={ id = ""SetPosition"", rotY = position.rotY, pos = position.pos}
        GameObject.SendCommand(walkerId,commandPos)
      end
    end
  end
  return false
end");

        static readonly LuaFunction BuildWalkerGameObjectIdList = new LuaFunction("BuildWalkerGameObjectIdList", @"
function this.BuildWalkerGameObjectIdList()
  for i,walkerInfo in ipairs(this.QUEST_TABLE.walkerList)do
    local walkerId = GetGameObjectId(""TppCommonWalkerGear2"",walkerInfo.walkerName)
    if walkerId ~= GameObject.NULL_ID then
      questWalkerGearList[walkerId] = walkerInfo.walkerName
    end
  end
end");

        static readonly LuaFunction checkWalkerGear = new LuaFunction("CheckIsWalkerGear", @"
function this.CheckIsWalkerGear(gameId)
  return Tpp.IsEnemyWalkerGear(gameId)
end");

        internal static void GetDefinition(WalkerDetail walkerDetail, DefinitionLua definitionLua)
        {
            int walkerCount = walkerDetail.walkers.Count;

            if (walkerCount > 0)
            {
                definitionLua.AddPackPath("/Assets/tpp/pack/mission2/common/mis_com_walkergear.fpk");
            }
        }

        internal static void GetMain(WalkerDetail detail, MainLua mainLua)
        {
            List<WalkerGear> walkers = detail.walkers;
            WalkerMetadata meta = detail.walkerMetadata;

            if (detail.walkers.Count > 0)
            {
                mainLua.AddToQuestTable(BuildWalkerList(detail));

                mainLua.AddCodeToScript("local setupOnce = true");
                mainLua.AddToOnUpdate("setupOnce = this.SetupGearsQuest(setupOnce)");
                mainLua.AddCodeToScript(SetupGearsQuest);

                mainLua.AddToQStep_Start_OnEnter(BuildWalkerGameObjectIdList);
                mainLua.AddCodeToScript(BuildWalkerGameObjectIdList);

                if (walkers.Any(walker => walker.isTarget))
                {
                    CheckQuestGenericEnemy checkQuestMethod = new CheckQuestGenericEnemy(mainLua, checkWalkerGear, meta.objectiveType);
                    foreach (WalkerGear walker in walkers)
                    {
                        if (walker.isTarget)
                            mainLua.AddToTargetList(walker.GetObjectName());
                    }
                }
            }
        }

        private static Table BuildWalkerList(WalkerDetail walkerDetail)
        {
            Table walkerList = new Table("walkerList");
            List<WalkerGear> walkers = walkerDetail.walkers;
            WalkerMetadata meta = walkerDetail.walkerMetadata;

            foreach (WalkerGear walker in walkers)
            {
                walkerList.Add($@"
        {{
            walkerName = ""{walker.GetObjectName()}"",{(walker.pilot.Equals("NONE") ? "" : $@"
            riderName = ""{walker.pilot}"",")}
            colorType = {walker.paint},
            primaryWeapon = {walker.weapon},
            position = {{pos = {{{walker.position.coords.xCoord},{walker.position.coords.yCoord},{walker.position.coords.zCoord}}}, rotY = {walker.position.rotation.GetDegreeRotY()},}},
        }}");
            }
            return walkerList;
        }
    }
}
