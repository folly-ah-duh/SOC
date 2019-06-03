using SOC.Classes.Common;
using System;
using System.Collections.Generic;
using System.Text;
using static SOC.Classes.Common.Tools;

namespace SOC.QuestObjects.Hostage
{
    static class HostageLua
    {
        public static string GetPackList(HostageDetail hostageDetail)
        {
            int hostageCount = hostageDetail.hostages.Count;
            StringBuilder hostagePackList = new StringBuilder("");

            BodyInfoEntry hostageBody = NPCBodyInfo.GetBodyInfo(hostageDetail.hostageMetadata.hostageBodyName);

            if (hostageCount > 0)
            {
                hostagePackList.Append(@"
        ""/Assets/tpp/pack/mission2/ih/ih_hostage_base.fpk"",");
                hostagePackList.Append($@"
        ""{hostageBody.missionPackPath}"", ");
                hostagePackList.Append($@"
        randomFaceListIH = {{ gender = ""{(hostageBody.isFemale ? "FEMALE" : "MALE")}"", count = {hostageCount}}}, ");
            }

            return hostagePackList.ToString();
        }

        public static void GetMain(HostageDetail hostageDetail, List<string> luaList)
        {
            List<Hostage> hostages = hostageDetail.hostages;
            HostageMetadata meta = hostageDetail.hostageMetadata;
            luaList[GetLineContaining("local hostageCount =", luaList)] = string.Format("local hostageCount = {0}", hostageDetail.hostages.Count);
            luaList[GetLineContaining("local useInter =", luaList)] = string.Format("local useInter = {0}", meta.canInterrogate.ToString().ToLower());
            luaList[GetLineContaining("local hostageQuestType =", luaList)] = string.Format("local hostageQuestType = {0}", meta.hostageObjectiveType);

            luaList[GetLineContaining("hostageList = {", luaList)] = BuildHostageList(hostageDetail);

            foreach (Hostage hostage in hostageDetail.hostages)
            {
                if (hostage.isTarget)
                    luaList.Insert(GetLineContaining("targetList = {", luaList) + 1, $@"    ""{hostage.GetObjectName()}"", ");
            }
        }

        private static string BuildHostageList(HostageDetail hostageDetail)
        {
            StringBuilder hostageListBuilder = new StringBuilder(@"    hostageList = {");
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
    },");
            return hostageListBuilder.ToString();
        }
    }
}
