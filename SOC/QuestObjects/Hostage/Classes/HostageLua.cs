using SOC.Classes.Common;
using SOC.Classes.Lua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOC.QuestObjects.Hostage
{
    static class HostageLua
    {
        static readonly LuaFunction WarpHostages = new LuaFunction("WarpHostages", @"
function this.WarpHostages()
  for i,hostageInfo in ipairs(this.QUEST_TABLE.hostageList)do
    local gameObjectId= GetGameObjectId(hostageInfo.hostageName)
    if gameObjectId~=GameObject.NULL_ID then
      local position=hostageInfo.position
      local command={id=""Warp"",degRotationY=position.rotY,position=Vector3(position.pos[1],position.pos[2],position.pos[3])}
      GameObject.SendCommand(gameObjectId,command)
    end
  end
end");

        static readonly LuaFunction SetHostageAttributes = new LuaFunction("SetHostageAttributes", @"
function this.SetHostageAttributes()
  for i,hostageInfo in ipairs(this.QUEST_TABLE.hostageList)do
    local gameObjectId= GetGameObjectId(hostageInfo.hostageName)
    if gameObjectId~=GameObject.NULL_ID then
	  if hostageInfo.commands then
        for j,hostageCommand in ipairs(hostageInfo.commands)do
	      GameObject.SendCommand(gameObjectId, hostageCommand)
	    end
	  end
    end
  end
end");

        static readonly LuaFunction CheckIsHostage = new LuaFunction("CheckIsHostage", @"
function this.CheckIsHostage(gameId)
  return Tpp.IsHostage(gameId) == true
end");

        public static void GetDefinition(HostageDetail hostageDetail, DefinitionLua definitionLua)
        {
            int hostageCount = hostageDetail.hostages.Count;
            BodyInfoEntry hostageBody = NPCBodyInfo.GetBodyInfo(hostageDetail.hostageMetadata.hostageBodyName);

            if (hostageCount > 0)
            {
                definitionLua.AddPackPath("/Assets/tpp/pack/mission2/ih/ih_hostage_base.fpk");
                definitionLua.AddPackPath(hostageBody.missionPackPath);

                definitionLua.AddPackInfo($@"randomFaceListIH = {{ gender = ""{(hostageBody.isFemale ? "FEMALE" : "MALE")}"", count = {hostageCount}}}");
            }
        }

        public static void GetMain(HostageDetail hostageDetail, MainLua mainLua)
        {
            List<Hostage> hostages = hostageDetail.hostages;
            HostageMetadata meta = hostageDetail.hostageMetadata;

            mainLua.AddToQuestTable(BuildHostageList(hostageDetail)); // leave outside if hostages.count > 0 for now, because the interrogation stuff isn't dynamically inserted into the lua yet
            mainLua.AddToLocalVariables("local hostageCount =", "local hostageCount = " + hostages.Count);
            mainLua.AddToLocalVariables("local useInter =", "local useInter = " + meta.canInterrogate.ToString().ToLower());

            if (hostages.Count > 0)
            {
                mainLua.AddToQStep_Start_OnEnter(WarpHostages);
                mainLua.AddToAuxiliary(WarpHostages);

                mainLua.AddToQStep_Start_OnEnter(SetHostageAttributes);
                mainLua.AddToAuxiliary(SetHostageAttributes);

                if (hostages.Any(hostage => hostage.isTarget))
                {
                    CheckQuestGenericEnemy hostageCheck = new CheckQuestGenericEnemy(mainLua, CheckIsHostage, meta.objectiveType);
                    foreach (Hostage hostage in hostages)
                    {
                        if (hostage.isTarget)
                            mainLua.AddToTargetList(hostage.GetObjectName());
                    }
                }
            }
        }

        private static Table BuildHostageList(HostageDetail hostageDetail)
        {
            Table hostageList = new Table("hostageList");
            List<Hostage> hostages = hostageDetail.hostages;
            HostageMetadata meta = hostageDetail.hostageMetadata;

            string scaredCommand = @"{id = ""SetForceScared"",   scared=true, ever=true }";
            string braveCommand = @"{id = ""SetHostage2Flag"",  flag=""disableScared"", on=true }";
            string injuredCommand = @"{id = ""SetHostage2Flag"",  flag=""disableFulton"",on=true }";
            string untiedCommand = @"{id = ""SetHostage2Flag"",  flag=""unlocked"",   on=true,}";

            if (hostages.Count == 0)
                hostageList.Add(@"
        nil ");
            else
                foreach (Hostage hostage in hostages)
                {
                    hostageList.Add($@"
        {{
            hostageName = ""{hostage.GetObjectName()}"",
            isFaceRandom = true,
            isTarget = {hostage.isTarget.ToString().ToLower()},
            voiceType = {{""hostage_a"", ""hostage_b"", {(hostage.language.Equals("english") ? @" ""hostage_c"", ""hostage_d""," : "")}}},
            langType = ""{hostage.language}"", {(hostage.staffType.Equals("NONE") ? "" : $@"
            staffTypeId = TppDefine.STAFF_TYPE_ID.{hostage.staffType},")} {(hostage.skill.Equals("NONE") ? "" : $@"
            skill = ""{hostage.skill}"", ")}
            bodyId = {NPCBodyInfo.GetBodyInfo(meta.hostageBodyName).gameId},
            position = {{pos = {{{hostage.position.coords.xCoord},{hostage.position.coords.yCoord},{hostage.position.coords.zCoord}}}, rotY = {hostage.position.rotation.GetDegreeRotY()},}},
            commands = {{{(hostage.scared.Equals("ALWAYS") ? scaredCommand + "," : (hostage.scared.Equals("NEVER") ? braveCommand + "," : ""))}{(hostage.isInjured ? injuredCommand + "," : "")}{(hostage.isUntied ? untiedCommand + "," : "")}}},
        }}");
                }
            return hostageList;
        }
    }
}
