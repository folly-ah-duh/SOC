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
                "AFGH_HOSTAGE",
                "TppDefine.QUEST_BODY_ID_LIST.AFGH_HOSTAGE_MALE",
                "/Assets/tpp/parts/chara/prs/prs2_main0_def_v00_ih_hos.parts",
                "/Assets/tpp/pack/mission2/ih/prs2_main0_mdl.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "AFGH_HOSTAGE_FEMALE",
                "TppDefine.QUEST_BODY_ID_LIST.AFGH_HOSTAGE_FEMALE",
                "/Assets/tpp/parts/chara/prs/prs3_main0_def_v00_ih_hos.parts",
                "/Assets/tpp/pack/mission2/ih/prs3_main0_mdl.fpk",
                true,
                false
                ),
            new BodyInfoEntry(
                "MAFR_HOSTAGE",
                "TppDefine.QUEST_BODY_ID_LIST.MAFR_HOSTAGE_MALE",
                "/Assets/tpp/parts/chara/prs/prs5_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/ih/prs5_main0_mdl.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "MAFR_HOSTAGE_FEMALE",
                "TppDefine.QUEST_BODY_ID_LIST.MAFR_HOSTAGE_FEMALE",
                "/Assets/tpp/parts/chara/prs/prs6_main0_def_v00_ih_hos.parts",
                "/Assets/tpp/pack/mission2/ih/prs6_main0_mdl.fpk",
                true,
                false
                ),
            new BodyInfoEntry(
                "DDS_RESEARCHER",
                "TppDefine.QUEST_BODY_ID_LIST.AFGH_HOSTAGE_MALE",
                "/Assets/tpp/parts/chara/dds/ddr0_main0_def_v00_ih_hos.parts",
                "/Assets/tpp/pack/mission2/ih/ddr0_main0_mdl.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "DDS_RESEARCHER_FEMALE",
                "TppDefine.QUEST_BODY_ID_LIST.AFGH_HOSTAGE_FEMALE",
                "/Assets/tpp/parts/chara/dds/ddr1_main0_def_v00_ih_hos.parts",
                "/Assets/tpp/pack/mission2/ih/ddr1_main0_mdl.fpk",
                true,
                false
                ),
            new BodyInfoEntry(
                "DRAB", 
                "TppEnemyBodyId.dds3_main0_v00", 
                "/Assets/tpp/parts/chara/dds/dds3_main0_def_v00.parts", 
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_wait.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "DRAB_FEMALE",
                "TppEnemyBodyId.dds8_main0_v00",
                "/Assets/tpp/parts/chara/dds/dds8_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_wait.fpk",
                true,
                false
                ),
            new BodyInfoEntry(
                "TIGER",
                "TppEnemyBodyId.dds5_main0_v00",
                "/Assets/tpp/parts/chara/dds/dds5_enem0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_attack.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "TIGER_FEMALE",
                "TppEnemyBodyId.dds6_main0_v00",
                "/Assets/tpp/parts/chara/dds/dds6_enef0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_attack.fpk",
                true,
                false
                ),
            new BodyInfoEntry(
                "SNEAKING_SUIT",
                "TppEnemyBodyId.dds4_enem0_def",
                "/Assets/tpp/parts/chara/sna/sna4_enem0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_sneak.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "SNEAKING_SUIT_FEMALE",
                "TppEnemyBodyId.dds4_enef0_def",
                "/Assets/tpp/parts/chara/sna/sna4_enef0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_sneak.fpk",
                true,
                false
                ),
            new BodyInfoEntry(
                "BATTLE_DRESS",
                "TppEnemyBodyId.dds5_enem0_def",
                "/Assets/tpp/parts/chara/sna/sna5_enem0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_btdrs.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "BATTLE_DRESS_FEMALE",
                "TppEnemyBodyId.dds5_enem0_def",
                "/Assets/tpp/parts/chara/sna/sna5_enef0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_btdrs.fpk",
                true,
                false
                ),
            new BodyInfoEntry(
                "XOF_GASMASK",
                "TppEnemyBodyId.wss0_main0_v00",
                "/Assets/tpp/parts/chara/wss/wss0_main0_def_v00_ih_sol.parts",
                "/Assets/tpp/pack/mission2/ih/wss0_main0_mdl.fpk",
                false,
                true
                ),
            new BodyInfoEntry(
                "XOF",
                "TppEnemyBodyId.wss4_main0_v00",
                "/Assets/tpp/parts/chara/wss/wss4_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_xof_soldier.fpk",
                false,
                true
                ),
            new BodyInfoEntry(
                "MSF_TPP",
                "TppEnemyBodyId.dds0_main1_v00",
                "/Assets/tpp/parts/chara/dds/dds0_main1_def_v00_ih_hos.parts",
                "/Assets/tpp/pack/mission2/ih/dds0_main1_mdl.fpk",
                false,
                true
                ),
            new BodyInfoEntry(
                "DDS_PILOT2",
                "TppEnemyBodyId.dds5_enem0_def",
                "/Assets/tpp/parts/chara/dds/dds9_main0_def_v00_ih_hos.parts",
                "/Assets/tpp/pack/mission2/ih/dds9_main0_mdl.fpk",
                false,
                true
                ),
            new BodyInfoEntry(
                "WANDERING_MSF",
                "TppEnemyBodyId.pfs0_dds0_v00",
                "/Assets/tpp/parts/chara/svs/svs0_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_afgh.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "SOVIET_BERET",
                "TppEnemyBodyId.svs0_unq_v010",
                "/Assets/tpp/parts/chara/svs/svs0_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_afgh.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "SOVIET_HOODIE",
                "TppEnemyBodyId.svs0_unq_v060",
                "/Assets/tpp/parts/chara/svs/svs0_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_afgh.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "SOVIET_SOLDIER",
                "TppEnemyBodyId.svs0_snp_v00_b",
                "/Assets/tpp/parts/chara/svs/svs0_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_afgh.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "PF_C_BERET",
                "TppEnemyBodyId.pfs0_unq_v450",
                "/Assets/tpp/parts/chara/pfs/pfs0_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_mafr.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "PF_SOLDIER",
                "TppEnemyBodyId.pfs0_snp_v00_a",
                "/Assets/tpp/parts/chara/pfs/pfs0_main0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_mafr.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "SWIMWEAR_GW",
                "TppEnemyBodyId.dlf_enem0_def",
                "/Assets/tpp/parts/chara/dlf/dlf1_enem0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_swim_suit.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "SWIMWEAR_GW_FEMALE",
                "TppEnemyBodyId.dlf_enef0_def",
                "/Assets/tpp/parts/chara/dlf/dlf0_enem0_def_f_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_swim_suit.fpk",
                true,
                false
                ),
            new BodyInfoEntry(
                "SWIMWEAR_GOB",
                "TppEnemyBodyId.dlg_enem0_def",
                "/Assets/tpp/parts/chara/dlg/dlg1_enem0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_swim_suit2.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "SWIMWEAR_GOB_FEMALE",
                "TppEnemyBodyId.dlg_enef0_def",
                "/Assets/tpp/parts/chara/dlg/dlg0_enem0_def_f_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_swim_suit2.fpk",
                true,
                false
                ),
            new BodyInfoEntry(
                "SWIMWEAR_MEG",
                "TppEnemyBodyId.dlh_enem0_def",
                "/Assets/tpp/parts/chara/dlh/dlh1_enem0_def_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_swim_suit3.fpk",
                false,
                false
                ),
            new BodyInfoEntry(
                "SWIMWEAR_MEG_FEMALE",
                "TppEnemyBodyId.dlh_enef0_def",
                "/Assets/tpp/parts/chara/dlh/dlh0_enem0_def_f_v00.parts",
                "/Assets/tpp/pack/mission2/common/mis_com_dd_soldier_swim_suit3.fpk",
                true,
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

        public bool hasface { get; set; }

        public BodyInfoEntry(string name, string id, string parts, string pack, bool female, bool face)
        {
            bodyName = name;
            bodyId = id;
            partsPath = parts;
            missionPackPath = pack;
            isFemale = female;
            hasface = face;

        }
    }
}
