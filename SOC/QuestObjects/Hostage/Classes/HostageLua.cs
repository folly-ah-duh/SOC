using SOC.Classes.Common;
using SOC.Classes.Lua;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOC.QuestObjects.Hostage
{
    static class HostageLua
    {
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

            mainLua.AddToLocalVariables("local hostageCount =", "local hostageCount = " + hostages.Count);
            mainLua.AddToLocalVariables("local useInter =", "local useInter = " + meta.canInterrogate.ToString().ToLower());
            mainLua.AddToLocalVariables("local hostageQuestType =", "local hostageQuestType = " + meta.objectiveType);

            mainLua.AddToQuestTable(BuildHostageList(hostageDetail));

            foreach (Hostage hostage in hostages)
            {
                if (hostage.isTarget)
                    mainLua.AddToTargetList(hostage.GetObjectName());
            }
        }

        private static string BuildHostageList(HostageDetail hostageDetail)
        {
            StringBuilder hostageListBuilder = new StringBuilder("hostageList = {");
            List<Hostage> hostages = hostageDetail.hostages;
            HostageMetadata meta = hostageDetail.hostageMetadata;

            string scaredCommand = @"{id = ""SetForceScared"",   scared=true, ever=true },";
            string braveCommand = @"{id = ""SetHostage2Flag"",  flag=""disableScared"", on=true },";
            string injuredCommand = @"{id = ""SetHostage2Flag"",  flag=""disableFulton"",on=true },";
            string untiedCommand = @"{id = ""SetHostage2Flag"",  flag=""unlocked"",   on=true,},";

            if (hostages.Count == 0)
                hostageListBuilder.Append(" nil ");
            else
                foreach (Hostage hostage in hostages)
                {
                    hostageListBuilder.Append($@"
        {{
            hostageName = ""{hostage.GetObjectName()}"",
            isFaceRandom = true,
            isTarget = {hostage.isTarget.ToString().ToLower()},
            voiceType = {{""hostage_a"", ""hostage_b"", {(hostage.language.Equals("english") ? @" ""hostage_c"", ""hostage_d""," : "")}}},
            langType = ""{hostage.language}"",
            {(hostage.staffType.Equals("NONE") ? "" : $"staffTypeId = TppDefine.STAFF_TYPE_ID.{hostage.staffType},")}
            {(hostage.skill.Equals("NONE") ? "" : $@"skill = ""{hostage.skill}"", ")}
            bodyId = {NPCBodyInfo.GetBodyInfo(meta.hostageBodyName).gameId},
            position = {{pos = {{{hostage.position.coords.xCoord},{hostage.position.coords.yCoord},{hostage.position.coords.zCoord}}}, rotY = {hostage.position.rotation.GetDegreeRotY()},}},
            commands = {{{(hostage.scared.Equals("ALWAYS") ? scaredCommand : (hostage.scared.Equals("NEVER") ? braveCommand : ""))}{(hostage.isInjured ? injuredCommand : "")}{(hostage.isUntied ? untiedCommand : "")}}},");
                    hostageListBuilder.Append(@"
        },");
                }
            hostageListBuilder.Append(@"
    }");
            return hostageListBuilder.ToString();
        }
    }
}
