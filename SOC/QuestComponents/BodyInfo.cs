using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.QuestComponents
{
    public static class BodyInfo
    {
        public static BodyInfoEntry[] BodyInfoArray = {
            new BodyInfoEntry(
                "DRAB", 
                "TppEnemyBodyId.dds3_main0_v00", 
                "/Assets/tpp/parts/chara/dds/dds3_main0_def_v00.parts", 
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_wait.fpk",
                false
                ),
            new BodyInfoEntry(
                "DRAB_FEMALE",
                "TppEnemyBodyId.dds8_main0_v00",
                "/Assets/tpp/parts/chara/dds/dds8_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_wait.fpk",
                true
                ),
            new BodyInfoEntry(
                "TIGER",
                "TppEnemyBodyId.dds5_main0_v00",
                "/Assets/tpp/parts/chara/dds/dds5_enem0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_attack.fpk",
                false
                ),
            new BodyInfoEntry(
                "TIGER_FEMALE",
                "TppEnemyBodyId.dds6_main0_v00",
                "/Assets/tpp/parts/chara/dds/dds6_enef0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_attack.fpk",
                true
                ),
            new BodyInfoEntry(
                "SNEAKING_SUIT",
                "TppEnemyBodyId.dds3_main0_v00",
                "/Assets/tpp/parts/chara/dds/dds3_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_wait.fpk",
                false
                ),
            new BodyInfoEntry(
                "SNEAKING_SUIT_FEMALE",
                "TppEnemyBodyId.dds3_main0_v00",
                "/Assets/tpp/parts/chara/dds/dds3_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_wait.fpk",
                false
                ),
            new BodyInfoEntry(
                "BATTLE_DRESS",
                "TppEnemyBodyId.dds3_main0_v00",
                "/Assets/tpp/parts/chara/dds/dds3_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_wait.fpk",
                false
                ),
            new BodyInfoEntry(
                "BATTLE_DRESS_FEMALE",
                "TppEnemyBodyId.dds3_main0_v00",
                "/Assets/tpp/parts/chara/dds/dds3_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_wait.fpk",
                false
                ),
        };
        
         
    }

    public struct BodyInfoEntry
    {
        public string bodyName { get; set; }

        public string bodyId { get; set; }

        public string partsPath { get; set; }

        public string missionPackPath { get; set; }

        public bool isFemale { get; set; }

        public BodyInfoEntry(string name, string id, string parts, string pack, bool female)
        {
            bodyName = name;
            bodyId = id;
            partsPath = parts;
            missionPackPath = pack;
            isFemale = female;
        }
    }
}
