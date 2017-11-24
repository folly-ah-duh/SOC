-- Afghanistan_CP_Reference.lua
-- lists the soldiers and routes for each Afghanistan CP

quest_cp = { -- sideop exclusive soldiers
  soldier_names = {
    "sol_quest_0000",
    "sol_quest_0001",
    "sol_quest_0002",
    "sol_quest_0003",
    "sol_quest_0004",
    "sol_quest_0005",
    "sol_quest_0006",
    "sol_quest_0007",
  },
}

afgh_field_cp = { -- da shago kallai
  soldier_names = {
    "sol_field_0000",
    "sol_field_0001",
    "sol_field_0002",
    "sol_field_0003",
    "sol_field_0004",
    "sol_field_0005",
    "sol_field_0006",
    "sol_field_0007",
    "sol_field_0008",
    "sol_field_0009",
    "sol_field_0010",
    "sol_field_0011",
  },
  sneakRoutes = {
    "rt_field_d_0000",
    "rt_field_d_0001",
    "rt_field_d_0002",
    "rt_field_d_0003",
    "rt_field_d_0004",
    "rt_field_d_0005",
    "rt_field_d_0006",
    "rt_field_d_0007",
    "rt_field_d_0008",
    "rt_field_d_0009",
    "rt_field_d_0010_sub",
    "rt_field_d_0012",
    "rt_field_d_0013",
    "rt_field_d_0011",
    "rt_field_d_0014",
    "rt_field_d_0015",
    "rt_field_n_0000",
    "rt_field_n_0001_sub",
    "rt_field_n_0002",
    "rt_field_n_0003",
    "rt_field_n_0004",
    "rt_field_n_0005",
    "rt_field_n_0006",
    "rt_field_n_0007_sub",
    "rt_field_n_0008",
    "rt_field_n_0009_sub",
    "rt_field_n_0010_sub",
    "rt_field_n_0011",
    "rt_field_n_0012",
  },
  cautionRoutes = {
    "rt_field_c_0000",
    "rt_field_c_0001",
    "rt_field_c_0002",
    "rt_field_c_0003",
    "rt_field_c_0004",
    "rt_field_c_0005",
    "rt_field_c_0006",
    "rt_field_c_0007",
    "rt_field_c_0008",
    "rt_field_c_0009",
    "rt_field_c_0010",
    "rt_field_c_0011",
  },
  hold = {
    "rt_field_h_0000",
    "rt_field_h_0001",
    "rt_field_h_0002",
    "rt_field_h_0003",
  },
  sleep = {
    "rt_field_s_0000",
    "rt_field_s_0001",
    "rt_field_s_0002",
    "rt_field_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_field_l_0000",
      "rt_field_l_0001",
    },
    in_lrrpHold_E = {
      "rt_field_lin_E",
      "rt_field_lin_E",
    },
    out_lrrpHold_E = {
      "rt_field_lout_E",
      "rt_field_lout_E",
    },
    in_lrrpHold_W = {
      "rt_field_lin_W",
      "rt_field_lin_W",
    },
    out_lrrpHold_W = {
      "rt_field_lout_W",
      "rt_field_lout_W",
    },
  },
  outofrain = {
    "rt_field_r_0000",
    "rt_field_r_0001",
    "rt_field_r_0002",
    "rt_field_r_0003",
    "rt_field_r_0004",
    "rt_field_r_0005",
    "rt_field_r_0006",
    "rt_field_r_0007",
    "rt_field_r_0008",
    "rt_field_r_0009",
    "rt_field_r_0010",
    "rt_field_r_0011",
    "rt_field_r_0012",
    "rt_field_r_0013",
    "rt_field_r_0014",
    "rt_field_r_0015",
    "rt_field_r_0016",
  },
  
  --[[
	rt_field_d_0011 northeast farmhouse
	rt_field_d_0012 patrol road
	rt_field_d_0013 north farmhouse
	rt_field_d_0005 patrolling north farm
	rt_field_d_0003 idle by central hub northeast entrance
	rt_field_d_0004 patrol by central hub northeast entrance
	rt_field_d_0002 idle front of central hub, beside tables under a little tarp
	rt_field_d_0007 idle beside d_0002
	rt_field_d_0006 patrol around and through central hub
	rt_field_d_0010 watchtower front
	rt_field_d_0001 patrol from front of central hub to south farmhouse, idle by central if more than 1 soldier?
	rt_field_d_0008 south farmhouse
	rt_field_d_0009 second floor idle under tarp
	rt_field_d_0000 central hub in watchtower 
	rt_field_d_0015 far west tarp entrance
	rt_field_d_0014 far west tarp entrance
	rt_field_n_0012 far west entrance tarp
	rt_field_n_0011 idle far west tarp? 
	rt_field_n_0005 patrol around farmhouses
	rt_field_c_0011 patrol around and through central hub
	rt_field_n_0004 full patrol around central hub
	rt_field_c_0009 patrol far north farms
	
	sideop routes from the prisoner rescue sideop -- quest_q20025.frt
	 
	rt_quest_d_0000 patrol on top of watchtower in central hub
	rt_quest_d_0002 idle beside north wall entrance to central hub
	rt_quest_d_0001 second floor outside door
	
	]]
  
  
}

afgh_remnants_cp = { -- lamar khaate palace
  soldier_names = {
    "sol_remnants_0000",
    "sol_remnants_0001",
    "sol_remnants_0002",
    "sol_remnants_0003",
    "sol_remnants_0004",
    "sol_remnants_0005",
    "sol_remnants_0006",
    "sol_remnants_0007",
    "sol_remnants_0008",
    "sol_remnants_0009",
  },
  SniperRoutes = {
    "rt_remnants_snp_0000",
    "rt_remnants_snp_0001",
  },
  sneakRoutes = {
    "rt_remnants_d_0000",
    "rt_remnants_d_0001",
    "rt_remnants_d_0002",
    "rt_remnants_d_0003",
    "rt_remnants_d_0004",
    "rt_remnants_d_0005",
    "rt_remnants_d_0006",
    "rt_remnants_d_0007",
    "rt_remnants_d_0008",
    "rt_remnants_d_0009",
    "rt_remnants_d_0010",
    "rt_remnants_d_0011",
    "rt_remnants_n_0000_sub",
    "rt_remnants_n_0001_sub",
    "rt_remnants_n_0002_sub",
    "rt_remnants_n_0003",
    "rt_remnants_n_0004",
    "rt_remnants_n_0005",
    "rt_remnants_n_0006_sub",
    "rt_remnants_n_0007",
    "rt_remnants_n_0008",
    "rt_remnants_n_0009",
    "rt_remnants_n_0010",
    "rt_remnants_n_0011",
  },
  cautionRoutes = {
    "rt_remnants_c_0000",
    "rt_remnants_c_0001",
    "rt_remnants_c_0002",
    "rt_remnants_c_0003",
    "rt_remnants_c_0004",
    "rt_remnants_c_0005",
    "rt_remnants_c_0006",
    "rt_remnants_c_0007",
    "rt_remnants_c_0008",
    "rt_remnants_c_0009",
    "rt_remnants_c_0010",
    "rt_remnants_c_0011",
    "rt_remnants_c_0012",
    "rt_remnants_c_0013",
    "rt_remnants_c_0014",
    "rt_remnants_c_0015",
  },
  hold = {
    "rt_remnants_h_0000",
    "rt_remnants_h_0001",
    "rt_remnants_h_0002",
    "rt_remnants_h_0003",
  },
  sleep = {
    "rt_remnants_s_0000",
    "rt_remnants_s_0001",
    "rt_remnants_s_0002",
    "rt_remnants_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_remnants_l_0000",
      "rt_remnants_l_0001",
    },
    in_lrrpHold_N = {
      "rt_remnants_lin_N",
      "rt_remnants_lin_N",
    },
    out_lrrpHold_B01 = {
      "rt_remnants_lout_B01",
      "rt_remnants_lout_B01",
    },
    out_lrrpHold_B02 = {
      "rt_remnants_lout_B02",
      "rt_remnants_lout_B02",
    },
    out_lrrpHold_B03 = {
      "rt_remnants_lout_B03",
      "rt_remnants_lout_B03",
    },
  },
  outofrain = {
    "rt_remnants_r_0000",
    "rt_remnants_r_0001",
    "rt_remnants_r_0002",
    "rt_remnants_r_0003",
    "rt_remnants_r_0004",
    "rt_remnants_r_0005",
    "rt_remnants_r_0006",
    "rt_remnants_r_0007",
    "rt_remnants_r_0008",
    "rt_remnants_r_0009",
    "rt_remnants_r_0010",
    "rt_remnants_r_0011",
    "rt_remnants_r_0012",
    "rt_remnants_r_0013",
    "rt_remnants_r_0014",
    "rt_remnants_r_0015",
    "rt_remnants_r_0016",
    "rt_remnants_r_0017",
    "rt_remnants_r_0018",
    "rt_remnants_r_0019",
  },
}

afgh_tent_cp = { -- yakho oboo supply outpost
  soldier_names = {
    "sol_tent_0000",
    "sol_tent_0001",
    "sol_tent_0002",
    "sol_tent_0003",
    "sol_tent_0004",
    "sol_tent_0005",
    "sol_tent_0006",
    "sol_tent_0007",
    "sol_tent_0008",
    "sol_tent_0009",
    "sol_tent_0010",
    "sol_tent_0011",
  },
  SniperRoutes = {
    "rt_tent_snp_0000",
    "rt_tent_snp_0001",
  },
  sneakRoutes = {
    "rt_tent_d_0000",
    "rt_tent_d_0001",
    "rt_tent_d_0002",
    "rt_tent_d_0003",
    "rt_tent_d_0004",
    "rt_tent_d_0005",
    "rt_tent_d_0006",
    "rt_tent_d_0007",
    "rt_tent_d_0008_sub",
    "rt_tent_d_0009",
    "rt_tent_d_0010",
    "rt_tent_d_0011",
    "rt_tent_d_0012",
    "rt_tent_d_0013",
    "rt_tent_d_0014",
    "rt_tent_d_0015",
    "rt_tent_d_0016",
    "rt_tent_d_0017",
    "rt_tent_d_0018",
    "rt_tent_d_0019",
    "rt_tent_n_0000",
    "rt_tent_n_0001",
    "rt_tent_n_0002",
    "rt_tent_n_0003",
    "rt_tent_n_0004_sub",
    "rt_tent_n_0005_sub",
    "rt_tent_n_0006",
    "rt_tent_n_0007",
    "rt_tent_n_0008_sub",
    "rt_tent_n_0009",
    "rt_tent_n_0010",
    "rt_tent_n_0011",
    "rt_tent_n_0012",
    "rt_tent_n_0013",
    "rt_tent_n_0014",
    "rt_tent_n_0015",
    "rt_tent_n_0016",
    "rt_tent_n_0017",
    "rt_tent_n_0018",
    "rt_tent_n_0019",
  },
  cautionRoutes = {
    "rt_tent_c_0000",
    "rt_tent_c_0001",
    "rt_tent_c_0002",
    "rt_tent_c_0003",
    "rt_tent_c_0004",
    "rt_tent_c_0005",
    "rt_tent_c_0006",
    "rt_tent_c_0007",
    "rt_tent_c_0008",
    "rt_tent_c_0009",
    "rt_tent_c_0010",
    "rt_tent_c_0011",
    "rt_tent_c_0012",
    "rt_tent_c_0013",
    "rt_tent_c_0014",
    "rt_tent_c_0015",
    "rt_tent_c_0016",
    "rt_tent_c_0017",
    "rt_tent_c_0018",
    "rt_tent_c_0019",
  },
  hold = {
    "rt_tent_h_0000",
    "rt_tent_h_0001",
    "rt_tent_h_0002",
    "rt_tent_h_0003",
  },
  sleep = {
    "rt_tent_s_0000",
    "rt_tent_s_0001",
    "rt_tent_s_0002",
    "rt_tent_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_tent_l_0000",
      "rt_tent_l_0001",
    },
    in_lrrpHold_S = {
      "rt_tent_lin_S",
      "rt_tent_lin_S",
    },
    out_lrrpHold_N = {
      "rt_tent_lout_N",
      "rt_tent_lout_N",
    },
  },
  outofrain = {
    "rt_tent_r_0000",
    "rt_tent_r_0001",
    "rt_tent_r_0002",
    "rt_tent_r_0003",
    "rt_tent_r_0004",
    "rt_tent_r_0005",
    "rt_tent_r_0006",
    "rt_tent_r_0007",
    "rt_tent_r_0008",
    "rt_tent_r_0009",
    "rt_tent_r_0010",
    "rt_tent_r_0011",
    "rt_tent_r_0012",
    "rt_tent_r_0013",
    "rt_tent_r_0014",
    "rt_tent_r_0015",
    "rt_tent_r_0016",
    "rt_tent_r_0017",
    "rt_tent_r_0018",
    "rt_tent_r_0019",
  },
  
  --[[
rt_tent_d_0004 rampart patrol
rt_tent_d_0005 rampart patrol
rt_tent_d_0017 central patrol
rt_tent_d_0013 interior patrol
rt_tent_d_0012 interior patrol
rt_tent_d_0002 perimeter patrol
rt_tent_d_0003 perimeter patrol
rt_tent_d_0009 lawn patrol
rt_tent_d_0007 lawn watch
rt_tent_c_0007 vigorous lawn watch
rt_tent_c_0009 west watchtower below
rt_tent_c_0004 searchlight
rt_tent_c_0005 searchlight
rt_tent_c_0008 watchtower searchlight
rt_tent_c_0011 south entrance watch
rt_tent_c_0010 soutch entrance watch
rt_tent_c_0006 back entrance
rt_tent_c_0015 north overwatch above camp.
rt_tent_c_0016 front tower
rt_tent_c_0017 back watchtower


	 sideop routes from the volgin corpse retrieval sideop -- tent_q99040.frt
	 
rt_quest_d_0001 small stroll in central
rt_quest_d_0000 small stroll in central
rt_quest_d_0002 central patrol
rt_quest_d_0003 central patrol
]]
  
}

afgh_village_cp = { -- da wialo kallai
  soldier_names = {
    "sol_village_0000",
    "sol_village_0001",
    "sol_village_0002",
    "sol_village_0003",
    "sol_village_0004",
    "sol_village_0005",
    "sol_village_0006",
    "sol_village_0007",
    "sol_village_0008",
    "sol_village_0009",
  },
  sneakRoutes = {
    "rt_village_d_0000",
    "rt_village_d_0001",
    "rt_village_d_0002",
    "rt_village_d_0003",
    "rt_village_d_0004",
    "rt_village_d_0005",
    "rt_village_d_0006",
    "rt_village_d_0007",
    "rt_village_d_0008",
    "rt_village_d_0009",
    "rt_village_d_0010",
    "rt_village_n_0000",
    "rt_village_n_0001",
    "rt_village_n_0002",
    "rt_village_n_0003",
    "rt_village_n_0004",
    "rt_village_n_0005",
    "rt_village_n_0006",
    "rt_village_n_0007",
    "rt_village_n_0008",
    "rt_village_n_0009",
    "rt_village_n_0010",
  },
  cautionRoutes = {
    "rt_village_c_0000",
    "rt_village_c_0001",
    "rt_village_c_0002",
    "rt_village_c_0003",
    "rt_village_c_0004",
    "rt_village_c_0005",
    "rt_village_c_0006",
    "rt_village_c_0007",
    "rt_village_c_0008",
    "rt_village_c_0009",
  },
  hold = {
    "rt_village_h_0000",
    "rt_village_h_0001",
    "rt_village_h_0002",
    "rt_village_h_0003",
  },
  sleep = {
    "rt_village_s_0000",
    "rt_village_s_0001",
    "rt_village_s_0002",
    "rt_village_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_village_l_0000",
      "rt_village_l_0001",
    },
    in_lrrpHold_E = {
      "rt_village_lin_E",
      "rt_village_lin_E",
    },
    out_lrrpHold_E = {
      "rt_village_lout_E",
      "rt_village_lout_E",
    },
    in_lrrpHold_W = {
      "rt_village_lin_W",
      "rt_village_lin_W",
    },
    out_lrrpHold_W = {
      "rt_village_lout_W",
      "rt_village_lout_W",
    },
  },
  outofrain = {
    "rt_village_r_0000",
    "rt_village_r_0001",
    "rt_village_r_0002",
    "rt_village_r_0003",
    "rt_village_r_0004",
    "rt_village_r_0005",
    "rt_village_r_0006",
  },
}

afgh_slopedTown_cp = { -- da ghwandai kar
  soldier_names = {
    "sol_slopedTown_0000",
    "sol_slopedTown_0001",
    "sol_slopedTown_0002",
    "sol_slopedTown_0003",
    "sol_slopedTown_0004",
    "sol_slopedTown_0005",
    "sol_slopedTown_0006",
    "sol_slopedTown_0007",
    "sol_slopedTown_0008",
    "sol_slopedTown_0009",
    "sol_slopedTown_0010",
  },
  sneakRoutes = {
    "rt_slopedTown_d_0000",
    "rt_slopedTown_d_0001",
    "rt_slopedTown_d_0002",
    "rt_slopedTown_d_0003",
    "rt_slopedTown_d_0004",
    "rt_slopedTown_d_0005",
    "rt_slopedTown_d_0006",

    "rt_slopedTown_d_0008",
    "rt_slopedTown_d_0009",
    "rt_slopedTown_d_0010",
    "rt_slopedTown_d_0011",
    "rt_slopedTown_n_0000",
    "rt_slopedTown_n_0001",
    "rt_slopedTown_n_0002",
    "rt_slopedTown_n_0003",
    "rt_slopedTown_n_0004",

    "rt_slopedTown_n_0006",
    "rt_slopedTown_n_0007",
    "rt_slopedTown_n_0008",
    "rt_slopedTown_n_0009",
    "rt_slopedTown_n_0010",
  },
  cautionRoutes = {
    "rt_slopedTown_c_0000",
    "rt_slopedTown_c_0001",
    "rt_slopedTown_c_0002",
    "rt_slopedTown_c_0003",
    "rt_slopedTown_c_0004",
    "rt_slopedTown_c_0005",
    "rt_slopedTown_c_0006",
    "rt_slopedTown_c_0007",
    "rt_slopedTown_c_0008",
    "rt_slopedTown_c_0009",
  },
  hold = {
    "rt_slopedTown_h_0000",
    "rt_slopedTown_h_0001",
    "rt_slopedTown_h_0002",
    "rt_slopedTown_h_0003",
  },
  sleep = {
    "rt_slopedTown_s_0000",
    "rt_slopedTown_s_0001",
    "rt_slopedTown_s_0002",
    "rt_slopedTown_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_slopedTown_l_0000",
      "rt_slopedTown_l_0001",
    },
    in_lrrpHold_W = {
      "rt_slopedTown_lin_W",
      "rt_slopedTown_lin_W",
    },
    out_lrrpHold_W = {
      "rt_slopedTown_lout_W",
      "rt_slopedTown_lout_W",
    },
    out_lrrpHold_B01 = {
      "rt_slopedTown_lout_B01",
      "rt_slopedTown_lout_B01",
    },
  },
}

afgh_commFacility_cp = { -- eastern communications post
  soldier_names = {
    "sol_commFacility_0000",
    "sol_commFacility_0001",
    "sol_commFacility_0002",
    "sol_commFacility_0003",
    "sol_commFacility_0004",
    "sol_commFacility_0005",
    "sol_commFacility_0006",
    "sol_commFacility_0007",
    "sol_commFacility_0008",
  },
  sneakRoutes = {
    "rt_commFacility_d_0000",
    "rt_commFacility_d_0001",
    "rt_commFacility_d_0002",
    "rt_commFacility_d_0003",
    "rt_commFacility_d_0004",
    "rt_commFacility_d_0005",
    "rt_commFacility_d_0006",
    "rt_commFacility_d_0007",
    "rt_commFacility_n_0000",
    "rt_commFacility_n_0001",
    "rt_commFacility_n_0002",
    "rt_commFacility_n_0003",
    "rt_commFacility_n_0004",
    "rt_commFacility_n_0005",
    "rt_commFacility_n_0006",
    "rt_commFacility_n_0007",
    "rt_commFacility_n_0008",
  },
  cautionRoutes = {
    "rt_commFacility_c_0000",
    "rt_commFacility_c_0001",
    "rt_commFacility_c_0002",
    "rt_commFacility_c_0003",
    "rt_commFacility_c_0005",
    "rt_commFacility_c_0004",
    "rt_commFacility_c_0006",
  },
  hold = {
    "rt_commFacility_h_0000",
    "rt_commFacility_h_0001",
    "rt_commFacility_h_0002",
    "rt_commFacility_h_0003",
  },
  sleep = {
    "rt_commFacility_s_0000",
    "rt_commFacility_s_0001",
  },
  travel = {
    lrrpHold = {
      "rt_commFacility_l_0000",
      "rt_commFacility_l_0001",
    },
    in_lrrpHold_E = {
      "rt_commFacility_lin_E",
      "rt_commFacility_lin_E",
    },
    out_lrrpHold_E = {
      "rt_commFacility_lout_E",
      "rt_commFacility_lout_E",
    },
    in_lrrpHold_W = {
      "rt_commFacility_lin_W",
      "rt_commFacility_lin_W",
    },
    out_lrrpHold_W = {
      "rt_commFacility_lout_W",
      "rt_commFacility_lout_W",
    },
  },
  outofrain = {
    "rt_commFacility_r_0000",
    "rt_commFacility_r_0001",
    "rt_commFacility_r_0002",
    "rt_commFacility_r_0003",
    "rt_commFacility_r_0004",
    "rt_commFacility_r_0005",
    "rt_commFacility_r_0006",
    "rt_commFacility_r_0007",
    "rt_commFacility_r_0008",
    "rt_commFacility_r_0009",
    "rt_commFacility_r_0010",
  },
}

afgh_enemyBase_cp = { -- wakh sind barracks
  soldier_names = {
    "sol_enemyBase_0000",
    "sol_enemyBase_0001",
    "sol_enemyBase_0002",
    "sol_enemyBase_0003",
    "sol_enemyBase_0004",
    "sol_enemyBase_0005",
    "sol_enemyBase_0006",
    "sol_enemyBase_0007",
    "sol_enemyBase_0008",
    "sol_enemyBase_0009",
    "sol_enemyBase_0010",
    "sol_enemyBase_0011",
    "sol_enemyBase_0012",
    "sol_enemyBase_0013",
  },
  sneakRoutes = {
    "rt_enemyBase_d_0000",
    "rt_enemyBase_d_0005",
    "rt_enemyBase_d_0008",
    "rt_enemyBase_d_0013",
    "rt_enemyBase_d_0001",
    "rt_enemyBase_d_0006",
    "rt_enemyBase_d_0009",
    "rt_enemyBase_d_0014",
    "rt_enemyBase_d_0002_sub",
    "rt_enemyBase_d_0006",
    "rt_enemyBase_d_0010",
    "rt_enemyBase_d_0015",
    "rt_enemyBase_d_0003",
    "rt_enemyBase_d_0007",
    "rt_enemyBase_d_0011",
    "rt_enemyBase_d_0016",
    "rt_enemyBase_d_0004",
    "rt_enemyBase_d_0007",
    "rt_enemyBase_d_0012",
    "rt_enemyBase_d_0017",
    "rt_enemyBase_n_0000",
    "rt_enemyBase_n_0005_sub",
    "rt_enemyBase_n_0010",
    "rt_enemyBase_n_0015",
    "rt_enemyBase_n_0001",
    "rt_enemyBase_n_0006",
    "rt_enemyBase_n_0011",
    "rt_enemyBase_n_0016",
    "rt_enemyBase_n_0002",
    "rt_enemyBase_n_0007",
    "rt_enemyBase_n_0012_sub",
    "rt_enemyBase_n_0017",
    "rt_enemyBase_n_0003",
    "rt_enemyBase_n_0008",
    "rt_enemyBase_n_0013",
    "rt_enemyBase_n_0018",
    "rt_enemyBase_n_0004",
    "rt_enemyBase_n_0009_sub",
    "rt_enemyBase_n_0014",
    "rt_enemyBase_n_0019",
  },
  cautionRoutes = {
    "rt_enemyBase_c_0000",
    "rt_enemyBase_c_0000",
    "rt_enemyBase_c_0001",
    "rt_enemyBase_c_0002",
    "rt_enemyBase_c_0002",
    "rt_enemyBase_c_0003",
    "rt_enemyBase_c_0004",
    "rt_enemyBase_c_0005",
    "rt_enemyBase_c_0006",
    "rt_enemyBase_c_0006",
    "rt_enemyBase_c_0007",
    "rt_enemyBase_c_0008",
    "rt_enemyBase_c_0009",
    "rt_enemyBase_c_0010",
    "rt_enemyBase_c_0011",
    "rt_enemyBase_c_0012",
    "rt_enemyBase_c_0013",
    "rt_enemyBase_c_0014",
    "rt_enemyBase_c_0015",
    "rt_enemyBase_c_0016",
    "rt_enemyBase_c_0017",
    "rt_enemyBase_c_0017",
  },
  hold = {
    "rt_enemyBase_h_0000",
    "rt_enemyBase_h_0001",
    "rt_enemyBase_h_0002",
    "rt_enemyBase_h_0003",
  },
  sleep = {
    "rt_enemyBase_s_0000",
    "rt_enemyBase_s_0001",
    "rt_enemyBase_s_0002",
    "rt_enemyBase_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_enemyBase_l_0000",
      "rt_enemyBase_l_0001",
    },

    in_lrrpHold_S = {
      "rt_enemyBase_lin_S",
      "rt_enemyBase_lin_S",
    },
    in_lrrpHold_N = {
      "rt_enemyBase_lin_N",
      "rt_enemyBase_lin_N",
    },

    out_lrrpHold_S = {
      "rt_enemyBase_lout_S",
      "rt_enemyBase_lout_S",
    },
    out_lrrpHold_N = {
      "rt_enemyBase_lout_N",
      "rt_enemyBase_lout_N",
    },
  },
  outofrain = {
    "rt_enemyBase_r_0000",
    "rt_enemyBase_r_0001",
    "rt_enemyBase_r_0002",
    "rt_enemyBase_r_0003",
    "rt_enemyBase_r_0004",
    "rt_enemyBase_r_0005",
    "rt_enemyBase_r_0006",
    "rt_enemyBase_r_0007",
    "rt_enemyBase_r_0008",
    "rt_enemyBase_r_0009",
    "rt_enemyBase_r_0010",
    "rt_enemyBase_r_0011",
    "rt_enemyBase_r_0012",
    "rt_enemyBase_r_0013",
    "rt_enemyBase_r_0014",
    "rt_enemyBase_r_0015",
    "rt_enemyBase_r_0016",
    "rt_enemyBase_r_0017",
    "rt_enemyBase_r_0018",
    "rt_enemyBase_r_0019",
  },
}

afgh_bridge_cp = { -- mountain relay base
  soldier_names = {
    "sol_bridge_0000",
    "sol_bridge_0001",
    "sol_bridge_0002",
    "sol_bridge_0003",
    "sol_bridge_0004",
    "sol_bridge_0005",
    "sol_bridge_0006",
    "sol_bridge_0007",
    "sol_bridge_0008",
    "sol_bridge_0009",
  },
  sneakRoutes= {
    "rt_bridge_d_0003",
    "rt_bridge_d_0004",
    "rt_bridge_d_0002",
    "rt_bridge_d_0006",
    "rt_bridge_d_0000_sub",
    "rt_bridge_d_0001",
    "rt_bridge_d_0005",
    "rt_bridge_d_0009",
    "rt_bridge_d_0007",
    "rt_bridge_d_0008",
    "rt_bridge_n_0000",
    "rt_bridge_n_0001",
    "rt_bridge_n_0006_sub",
    "rt_bridge_n_0007",
    "rt_bridge_n_0002",
    "rt_bridge_n_0003_sub",
    "rt_bridge_n_0008",
    "rt_bridge_n_0004",
    "rt_bridge_n_0005",
    "rt_bridge_n_0009",
  },
  cautionRoutes = {
    "rt_bridge_c_0005",
    "rt_bridge_c_0006",
    "rt_bridge_c_0004",
    "rt_bridge_c_0004",
    "rt_bridge_c_0002",
    "rt_bridge_c_0003",
    "rt_bridge_c_0007",
    "rt_bridge_c_0000",
    "rt_bridge_c_0001",
    "rt_bridge_c_0008",
    "rt_bridge_c_0009",
    "rt_bridge_c_0010",
  },
  hold = {
    "rt_bridge_h_0000",
    "rt_bridge_h_0001",
    "rt_bridge_h_0002",
    "rt_bridge_h_0003",
  },
  sleep = {
    "rt_bridge_s_0000",
    "rt_bridge_s_0001",
    "rt_bridge_s_0002",
    "rt_bridge_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_bridge_l_0000",
      "rt_bridge_l_0001",
    },
    in_lrrpHold_N = {
      "rt_bridge_lin_N",
      "rt_bridge_lin_N",
    },
    out_lrrpHold_S = {
      "rt_bridge_lout_S",
      "rt_bridge_lout_S",
    },
  },
  outofrain = {
    "rt_bridge_r_0000",
    "rt_bridge_r_0001",
    "rt_bridge_r_0002",
    "rt_bridge_r_0003",
    "rt_bridge_r_0004",
    "rt_bridge_r_0005",
    "rt_bridge_r_0006",
    "rt_bridge_r_0007",
    "rt_bridge_r_0008",
    "rt_bridge_r_0009",
    "rt_bridge_r_0010",
    "rt_bridge_r_0011",
    "rt_bridge_r_0012",
  },
}

afgh_fort_cp = { -- da smasei laman
  soldier_names = {
    "sol_fort_0000",
    "sol_fort_0001",
    "sol_fort_0002",
    "sol_fort_0003",
    "sol_fort_0004",
    "sol_fort_0005",
    "sol_fort_0006",
    "sol_fort_0007",
    "sol_fort_0008",
    "sol_fort_0009",
  },
  SniperRoutes = {
    "rt_cliffTown_snp_0000",
    "rt_cliffTown_snp_0001",
  },
  sneakRoutes = {
    "rt_cliffTown_d_0010",
    "rt_cliffTown_d_0009",
    "rt_cliffTown_d_0002",
    "rt_cliffTown_d_0002",
    "rt_cliffTown_d_0006",
    "rt_cliffTown_d_0008",
    "rt_cliffTown_d_0003",
    "rt_cliffTown_d_0012",
    "rt_cliffTown_d_0007",
    "rt_cliffTown_d_0005",
    "rt_cliffTown_d_0004",
    "rt_cliffTown_d_0013",
    "rt_cliffTown_d_0001_no_tower_sub",
    "rt_cliffTown_d_0011",
    "rt_cliffTown_d_0000",
    "rt_cliffTown_d_0014",
    "rt_cliffTown_n_0001_no_search_light_sub",
    "rt_cliffTown_n_0012",
    "rt_cliffTown_n_0011",
    "rt_cliffTown_n_0010",
    "rt_cliffTown_n_0000_no_search_light_sub",
    "rt_cliffTown_n_0009",
    "rt_cliffTown_n_0003",
    "rt_cliffTown_n_0013",
    "rt_cliffTown_n_0008",
    "rt_cliffTown_n_0006",
    "rt_cliffTown_n_0002",
    "rt_cliffTown_n_0014",
    "rt_cliffTown_n_0005_no_search_light_sub",
    "rt_cliffTown_n_0007",
    "rt_cliffTown_n_0004_no_search_light_sub",
    "rt_cliffTown_n_0015",
  },
  cautionRoutes = {
    "rt_cliffTown_c_0000",
    "rt_cliffTown_c_0000",
    "rt_cliffTown_c_0001",
    "rt_cliffTown_c_0001",
    "rt_cliffTown_c_0002",
    "rt_cliffTown_c_0002",
    "rt_cliffTown_c_0003",
    "rt_cliffTown_c_0003",
    "rt_cliffTown_c_0004",
    "rt_cliffTown_c_0004",
    "rt_cliffTown_c_0005",
    "rt_cliffTown_c_0005",
    "rt_cliffTown_c_0006",
    "rt_cliffTown_c_0006",
    "rt_cliffTown_c_0001",
    "rt_cliffTown_c_0004",
  },
  hold = {
    "rt_cliffTown_h_0000",
    "rt_cliffTown_h_0001",
    "rt_cliffTown_h_0002",
    "rt_cliffTown_h_0003",
  },
  sleep = {
    "rt_cliffTown_s_0000",
    "rt_cliffTown_s_0001",
    "rt_cliffTown_s_0002",
    "rt_cliffTown_s_0003",
  },
  travel = {
    lrrp_cliffTown = {
      "rt_cliffTown_l_0000",
      "rt_cliffTown_l_0001",
    },
    lrrpHold = {
      "rt_cliffTown_l_0000",
      "rt_cliffTown_l_0001",
    },
    lrrpHold_01 = {
      "rt_cliffTown_l_0002",
      "rt_cliffTown_l_0003",
    },
    in_lrrpHold_W = {
      "rt_cliffTown_lin_W",
      "rt_cliffTown_lin_W",
    },
    out_lrrpHold_N = {
      "rt_cliffTown_lout_N",
      "rt_cliffTown_lout_N",
    },
  },
  outofrain = {
    "rt_cliffTown_r_0000",
    "rt_cliffTown_r_0001",
    "rt_cliffTown_r_0002",
    "rt_cliffTown_r_0003",
    "rt_cliffTown_r_0004",
    "rt_cliffTown_r_0005",
    "rt_cliffTown_r_0006",
    "rt_cliffTown_r_0007",
    "rt_cliffTown_r_0008",
    "rt_cliffTown_r_0009",
    "rt_cliffTown_r_0010",
    "rt_cliffTown_r_0011",
    "rt_cliffTown_r_0012",
    "rt_cliffTown_r_0013",
  },
}

afgh_cliffTown_cp = { -- Qarya Sakhra Ee
  soldier_names = {
    "sol_cliffTown_0000",
    "sol_cliffTown_0001",
    "sol_cliffTown_0002",
    "sol_cliffTown_0003",
    "sol_cliffTown_0004",
    "sol_cliffTown_0005",
    "sol_cliffTown_0006",
    "sol_cliffTown_0007",
    "sol_cliffTown_0008",
    "sol_cliffTown_0009",
    "sol_cliffTown_0010",
    "sol_cliffTown_0011",
    "sol_cliffTown_0012",
  },
  sneakRoutes = {
    "rt_fort_d_0001",
    "rt_fort_d_0002",
    "rt_fort_d_0004_sub",
    "rt_fort_d_0005",
    "rt_fort_d_0000",
    "rt_fort_d_0006",
    "rt_fort_d_0007",
    "rt_fort_d_0010",
    "rt_fort_d_0003_sub",
    "rt_fort_d_0008",
    "rt_fort_d_0009",
    "rt_fort_d_0011",
    "rt_fort_n_0000",
    "rt_fort_n_0001",
    "rt_fort_n_0002",
    "rt_fort_n_0005",
    "rt_fort_n_0003_sub",
    "rt_fort_n_0006",
    "rt_fort_n_0004",
    "rt_fort_n_0010",
    "rt_fort_n_0007",
    "rt_fort_n_0009",
    "rt_fort_n_0008_sub",
    "rt_fort_n_0011",
  },
  cautionRoutes = {
    "rt_fort_c_0001",
    "rt_fort_c_0008",
    "rt_fort_c_0002",
    "rt_fort_c_0002",
    "rt_fort_c_0003",
    "rt_fort_c_0004",
    "rt_fort_c_0005",
    "rt_fort_c_0000",
    "rt_fort_c_0006",
    "rt_fort_c_0007",
    "rt_fort_c_0010",
    "rt_fort_c_0010",
  },
  hold = {
    "rt_fort_h_0000",
    "rt_fort_h_0001",
    "rt_fort_h_0002",
    "rt_fort_h_0003",
    "rt_fort_h_0004",
    "rt_fort_h_0005",
  },
  sleep = {
    "rt_fort_s_0000",
    "rt_fort_s_0001",
    "rt_fort_s_0002",
    "rt_fort_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_fort_l_0000",
      "rt_fort_l_0001",
    },
    in_lrrpHold_W = {
      "rt_fort_lin_W",
      "rt_fort_lin_W",
    },
    out_lrrpHold_S = {
      "rt_fort_lout_S",
      "rt_fort_lout_S",
    },
  },
  outofrain = {
    "rt_fort_r_0000",
    "rt_fort_r_0001",
    "rt_fort_r_0002",
    "rt_fort_r_0003",
    "rt_fort_r_0004",
    "rt_fort_r_0005",
  },
}

afgh_powerPlant_cp = { -- serak power plant
  soldier_names = {
    "sol_powerPlant_0000",
    "sol_powerPlant_0001",
    "sol_powerPlant_0002",
    "sol_powerPlant_0003",
    "sol_powerPlant_0004",
    "sol_powerPlant_0005",
    "sol_powerPlant_0006",
    "sol_powerPlant_0007",
    "sol_powerPlant_0008",
    "sol_powerPlant_0009",
  },
  SniperRoutes = {
    "rt_powerPlant_snp_0000",
    "rt_powerPlant_snp_0001",
  },
  sneakRoutes = {
    "rt_powerPlant_d_0000",
    "rt_powerPlant_d_0005",
    "rt_powerPlant_d_0001",
    "rt_powerPlant_d_0006",
    "rt_powerPlant_d_0002",
    "rt_powerPlant_d_0007",
    "rt_powerPlant_d_0003",
    "rt_powerPlant_d_0008",
    "rt_powerPlant_d_0004",
    "rt_powerPlant_d_0009",
    "rt_powerPlant_n_0000",
    "rt_powerPlant_n_0005",
    "rt_powerPlant_n_0001_sub",
    "rt_powerPlant_n_0006",
    "rt_powerPlant_n_0002",
    "rt_powerPlant_n_0007",
    "rt_powerPlant_n_0003",
    "rt_powerPlant_n_0008",
    "rt_powerPlant_n_0004",
    "rt_powerPlant_n_0009",
  },
  CautionSniperRoutes = {
    "rt_powerPlant_snp_0000c",
    "rt_powerPlant_snp_0001c",
  },
  cautionRoutes = {
    "rt_powerPlant_c_0004",
    "rt_powerPlant_c_0005",
    "rt_powerPlant_c_0000",
    "rt_powerPlant_c_0001",
    "rt_powerPlant_c_0002",
    "rt_powerPlant_c_0003",
    "rt_powerPlant_c_0006",
    "rt_powerPlant_c_0007",
    "rt_powerPlant_c_0008_sub",
    "rt_powerPlant_c_0009",
    "rt_powerPlant_c_0000",
    "rt_powerPlant_c_0001",
    "rt_powerPlant_c_0002",
    "rt_powerPlant_c_0003",
    "rt_powerPlant_c_0009",
  },
  hold = {
    "rt_powerPlant_h_0000",
    "rt_powerPlant_h_0001",
    "rt_powerPlant_h_0002",
    "rt_powerPlant_h_0003",
  },
  sleep = {
    "rt_powerPlant_s_0000",
    "rt_powerPlant_s_0001",
    "rt_powerPlant_s_0002",
    "rt_powerPlant_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_powerPlant_l_0000",
      "rt_powerPlant_l_0001",
    },
    in_lrrpHold_S = {
      "rt_powerPlant_lin_S",
      "rt_powerPlant_lin_S",
    },
    out_lrrpHold_B01 = {
      "rt_powerPlant_lout_B01",
      "rt_powerPlant_lout_B01",
    },
    out_lrrpHold_B02 = {
      "rt_powerPlant_lout_B02",
      "rt_powerPlant_lout_B02",
    },
    out_lrrpHold_B03 = {
      "rt_powerPlant_lout_B03",
      "rt_powerPlant_lout_B03",
    },
  },
  outofrain = {
    "rt_powerPlant_r_0000",
    "rt_powerPlant_r_0001",
    "rt_powerPlant_r_0002",
    "rt_powerPlant_r_0003",
    "rt_powerPlant_r_0004",
    "rt_powerPlant_r_0005",
    "rt_powerPlant_r_0006",
    "rt_powerPlant_r_0007",
    "rt_powerPlant_r_0008",
    "rt_powerPlant_r_0009",
    "rt_powerPlant_r_0010",
    "rt_powerPlant_r_0011",
    "rt_powerPlant_r_0012",
    "rt_powerPlant_r_0013",
    "rt_powerPlant_r_0014",
    "rt_powerPlant_r_0015",
  },
}

afgh_sovietBase_cp = { -- afghanistan central base camp
  soldier_names = {
    "sol_sovietBase_0000",
    "sol_sovietBase_0001",
    "sol_sovietBase_0002",
    "sol_sovietBase_0003",
    "sol_sovietBase_0004",
    "sol_sovietBase_0005",
    "sol_sovietBase_0006",
    "sol_sovietBase_0007",
    "sol_sovietBase_0008",
    "sol_sovietBase_0009",
    "sol_sovietBase_0010",
    "sol_sovietBase_0011",
    "sol_sovietBase_0012",
    "sol_sovietBase_0013",
    "sol_sovietBase_0014",
  },
  sniperRoutes = {
    "rt_sovietBase_snp_0000",
    "rt_sovietBase_snp_0001",
    "rt_sovietBase_snp_0002",
  },
  sneakRoutes = {
    "rt_sovietBase_d_0000",
    "rt_sovietBase_d_0001",
    "rt_sovietBase_d_0002",
    "rt_sovietBase_d_0003",
    "rt_sovietBase_d_0004",
    "rt_sovietBase_d_0005_sub",
    "rt_sovietBase_d_0006",
    "rt_sovietBase_d_0007",
    "rt_sovietBase_d_0008",
    "rt_sovietBase_d_0009",
    "rt_sovietBase_d_0010",
    "rt_sovietBase_d_0011",
    "rt_sovietBase_d_0012",
    "rt_sovietBase_d_0013",
    "rt_sovietBase_d_0014",
    "rt_sovietBase_d_0015",
    "rt_sovietBase_n_0000",
    "rt_sovietBase_n_0001",
    "rt_sovietBase_n_0002",
    "rt_sovietBase_n_0003",
    "rt_sovietBase_n_0004",
    "rt_sovietBase_n_0005_sub",
    "rt_sovietBase_n_0006",
    "rt_sovietBase_n_0007",
    "rt_sovietBase_n_0008",
    "rt_sovietBase_n_0009",
    "rt_sovietBase_n_0010",
    "rt_sovietBase_n_0011",
    "rt_sovietBase_n_0012",
    "rt_sovietBase_n_0013",
    "rt_sovietBase_n_0014",
    "rt_sovietBase_n_0015",
  },
  cautionSniperRoutes {
    "rt_sovietBase_snp_0000c",
    "rt_sovietBase_snp_0001c",
    "rt_sovietBase_snp_0002c",
  },
  cautionRoutes = {
    "rt_sovietBase_c_0002",
    "rt_sovietBase_c_0017",
    "rt_sovietBase_c_0018",
    "rt_sovietBase_c_0003",
    "rt_sovietBase_c_0004",
    "rt_sovietBase_c_0000",
    "rt_sovietBase_c_0006",
    "rt_sovietBase_c_0007",
    "rt_sovietBase_c_0001",
    "rt_sovietBase_c_0013",
    "rt_sovietBase_c_0012",
    "rt_sovietBase_c_0009",
    "rt_sovietBase_c_0011",
    "rt_sovietBase_c_0014",
    "rt_sovietBase_c_0015",
    "rt_sovietBase_c_0008",
    "rt_sovietBase_c_0005",
    "rt_sovietBase_c_0010",
    "rt_sovietBase_c_0019",
    "rt_sovietBase_c_0016",
    "rt_sovietBase_c_0013",
    "rt_sovietBase_c_0012",
    "rt_sovietBase_c_0011",
  },
  hold = {
    "rt_sovietBase_h_0000",
    "rt_sovietBase_h_0001",
    "rt_sovietBase_h_0002",
    "rt_sovietBase_h_0003",
    "rt_sovietBase_h_0004",
  },
  sleep = {
    "rt_sovietBase_s_0000",
    "rt_sovietBase_s_0001",
    "rt_sovietBase_s_0002",
    "rt_sovietBase_s_0003",
    "rt_sovietBase_s_0004",
  },
  travel = {
    lrrpHold = {
      "rt_sovietBase_l_0000",
      "rt_sovietBase_l_0001",
    },
    in_lrrpHold_S = {
      "rt_sovietBase_lin_S",
      "rt_sovietBase_lin_S",
    },
    out_lrrpHold_S = {
      "rt_sovietBase_lout_S",
      "rt_sovietBase_lout_S",
    },
  },
  outofrain = {
    "rt_sovietBase_r_0000",
    "rt_sovietBase_r_0001",
    "rt_sovietBase_r_0002",
    "rt_sovietBase_r_0003",
    "rt_sovietBase_r_0004",
    "rt_sovietBase_r_0005",
    "rt_sovietBase_r_0006",
    "rt_sovietBase_r_0007",
    "rt_sovietBase_r_0008",
    "rt_sovietBase_r_0009",
    "rt_sovietBase_r_0010",
    "rt_sovietBase_r_0011",
    "rt_sovietBase_r_0012",
    "rt_sovietBase_r_0013",
    "rt_sovietBase_r_0014",
    "rt_sovietBase_r_0015",
    "rt_sovietBase_r_0016",
    "rt_sovietBase_r_0017",
    "rt_sovietBase_r_0018",
    "rt_sovietBase_r_0019",
  },
  
  --[[
	rt_sovietBase_c_0000 long patrol entrance
	rt_sovietBase_c_0001 patrol frontmid road overwatch south underpass
	rt_sovietBase_c_0002 patrol in front of north barracks and by garage	

	rt_sovietBase_c_0004 patrol front road overwatch south underpass
	rt_sovietBase_c_0005 patrol along west side around sniper building north barracks	
	rt_sovietBase_c_0006 patrols north west side of center barracks
	rt_sovietBase_c_0007 patrols through garage
	rt_sovietBase_c_0008 long patrol through base
	rt_sovietBase_c_0009 underpass patrol
	rt_sovietBase_c_0010 patrol around gunrange 
	rt_sovietBase_c_0011 patrols near gunrange and center barracks
	rt_sovietBase_c_0012 long patrol entrance
	rt_sovietBase_c_0013 patrol grand loop around base
	rt_sovietBase_c_0014 patrols frontmid around fork
	rt_sovietBase_c_0015 patrol beside west building	
	
	rt_sovietBase_c_0017 patrols inside ruined barracks
	rt_sovietBase_c_0018 walks beside LRRP resting tent 
	rt_sovietBase_c_0019 before entrance to base
	
	rt_sovietBase_c_0018 patrols around front of ruined barracks and up the road between the ruined barracks and garage
	
	
	patrols front of ruined barracks
	
	rt_sovietBase_d_0001 idle in box overwatching underpass/frontmid area
	rt_sovietBase_d_0002 on building over looking exit area. typical sniper roof
	rt_sovietBase_d_0003 idle in box at front entrance
	rt_sovietBase_d_0003 might also be soldier idle on west side of overpass in front of maintenance platform
	
	rt_sovietBase_d_0005 exit watchtower
	
	rt_sovietBase_d_0007 idle beside garage watching toward LRRP resting tentw
	rt_sovietBase_d_0008 at desolate tent across from underpass
	rt_sovietBase_d_0009 patrols frontmid LZ area
	rt_sovietBase_d_0010 patrols gunrange road and gunrange tents
	rt_sovietBase_d_0011 patrol around central road loop
	rt_sovietBase_d_0012 loops around front entrance. trail to desolate tent and under overpass
	rt_sovietBase_d_0013 long loop around ruined barracks following the main roads
	rt_sovietBase_d_0014 	idle at fork			
	rt_sovietBase_d_0015  loosely patrol beside west building
	rt_sovietBase_d_0016 patrol exit road loop
	rt_sovietBase_d_0017 enters front of ruined barracks and idles 
	
	 
	 rt_sovietBase_n_0000 idle entrance box watching entrance
	 rt_sovietBase_n_0001 idle in frontmid box overlooking overpass and desolate tent
	 rt_sovietBase_n_0002 halfloop around exit roads, cuts through typical sniper building overlooking exit area
	 rt_sovietBase_n_0003 walks back and forth by mainenance platform west of overpass
	 rt_sovietBase_n_0004 patrol down front road, idle at fork
	 rt_sovietBase_n_0005 exit watchtower
	 rt_sovietBase_n_0006 idle by LRRP resting tent
	 rt_sovietBase_n_0007 idle across from garage overlooking north barracks
	 rt_sovietBase_n_0008 idle at desolate tent across from underpass
	 rt_sovietBase_n_0009 idle under ruined for doorway overwatching overpass/maintanence area
	 rt_sovietBase_n_0010 (?)idle frontmid at fork
	 rt_sovietBase_n_0011 (?) frontmid road holding at fork
	 rt_sovietBase_n_0012 (?) walks around tent on north side of central barracks	
	 rt_sovietBase_n_0013 patrol through mid LZ area
	 rt_sovietBase_n_0014 idle at fork
	 rt_sovietBase_n_0015 patrol beside west building
	 rt_sovietBase_n_0016 patrols exit road by armory
	 rt_sovietBase_n_0017 idles in doorway of ruined barracks overwatching garage
	 rt_sovietBase_n_0018 patrol outside front of garage
	 rt_sovietBase_n_0019 outside front entance
	 
	 rt_sovietBase_snp_0002c watchtower before entrance
	 rt_sovietBase_snp_0001c no idea, can't find him
	 rt_sovietBase_snp_0000c on ruined building?
	 
	 rt_quest_d_0000
	 rt_quest_c_0000 patrol
	 rt_quest_d_0001
	 rt_quest_c_0001
	 rt_quest_c_0005 patrol
	 rt_quest_c_0006
	 
	]]
  
  
}

afgh_citadel_cp = { -- okb0
  soldier_names = {
    "sol_citadel_0000",
    "sol_citadel_0001",
    "sol_citadel_0002",
    "sol_citadel_0003",
    "sol_citadel_0004",
    "sol_citadel_0005",
    "sol_citadel_0006",
    "sol_citadel_0007",
    "sol_citadel_0008",
    "sol_citadel_0009",
    "sol_citadel_0010",
    "sol_citadel_0011",
    "sol_citadel_0012",
    "sol_citadel_0013",
    "sol_citadel_0014",
    "sol_citadel_0015",
    "sol_citadel_0016",
    "sol_citadel_0017",
    "sol_citadel_0018",
    "sol_citadel_0019",
    "sol_citadel_0020",
  },
  sniperRoutes = {
    "rt_citadel_snp_0000",
    "rt_citadel_d_0020",
    "rt_citadel_d_0026",
    "rt_citadel_d_0031",
  },
  sneakRoutes = {

    stage1st = {
      "rt_citadel_d_0000",
      "rt_citadel_d_0002",
      "rt_citadel_d_0003",
      "rt_citadel_d_0032",
      "rt_citadel_n_0001_sub",
      "rt_citadel_n_0000",
      "rt_citadel_n_0002_sub",
      "rt_citadel_n_0005",
    },
    stage2nd = {
      "rt_citadel_d_0010",
      "rt_citadel_d_0013",
      "rt_citadel_d_0005",
      "rt_citadel_d_0007",
      "rt_citadel_d_0011",
      "rt_citadel_d_0008",
      "rt_citadel_d_0004",
      "rt_citadel_d_0012",
      "rt_citadel_d_0009",
      "rt_citadel_n_0006_sub",
      "rt_citadel_n_0007_sub",
      "rt_citadel_n_0008_sub",
      "rt_citadel_n_0009",
      "rt_citadel_n_0010",
    },
    stage3rd = {
      "rt_citadel_d_0019",
      "rt_citadel_d_0016",
      "rt_citadel_d_0018",
      "rt_citadel_d_0035",
      "rt_citadel_d_0015",
      "rt_citadel_d_0017",
      "rt_citadel_d_0022",
      "rt_citadel_d_0023",
      "rt_citadel_d_0033",
      "rt_citadel_d_0034",
      "rt_citadel_n_0012",
      "rt_citadel_n_0011_sub",
      "rt_citadel_n_0012",
      "rt_citadel_n_0016",
      "rt_citadel_n_0017",
      "rt_citadel_n_0016",
      "rt_citadel_n_0017",
      "rt_citadel_n_0013",
      "rt_citadel_n_0014",
      "rt_citadel_n_0022",
    },
    stage4th = {
      "rt_citadel_d_0027",
      "rt_citadel_d_0024",
      "rt_citadel_d_0028",
      "rt_citadel_d_0029",
      "rt_citadel_d_0030",
      "rt_citadel_n_0018_sub",
      "rt_citadel_n_0020",
      "rt_citadel_n_0021",
    },
    groupWalkerGear={
      "rt_citadel_d_0025",
      "rt_citadel_d_0021",
      "rt_citadel_d_0006",
      "rt_citadel_d_0014",
    },
  },
  cautionSniperRoutes = {
    "rt_citadel_snp_0000",
    "rt_citadel_c_0011",
    "rt_citadel_c_0023",
    "rt_citadel_c_0034",
  },
  cautionRoutes = {
    stage1st = {
      "rt_citadel_c_0000",
      "rt_citadel_c_0001",
      "rt_citadel_c_0003",
      "rt_citadel_c_0004",
    },
    stage2nd = {
      "rt_citadel_c_0007",
      "rt_citadel_c_0009",
      "rt_citadel_c_0005",
      "rt_citadel_c_0010",
      "rt_citadel_c_0012",
      "rt_citadel_c_0013",
      "rt_citadel_c_0014",
      "rt_citadel_c_0015",
      "rt_citadel_c_0016",
    },
    stage3rd = {

      "rt_citadel_c_0017",
      "rt_citadel_c_0018",
      "rt_citadel_c_0019",
      "rt_citadel_c_0021",
      "rt_citadel_c_0022",
      "rt_citadel_c_0024",
      "rt_citadel_c_0025",
      "rt_citadel_c_0026",
      "rt_citadel_c_0027",
      "rt_citadel_c_0028",
    },
    stage4th = {

      "rt_citadel_c_0029",
      "rt_citadel_c_0030",
      "rt_citadel_c_0031",
      "rt_citadel_c_0033",
      "rt_citadel_c_0035",
    },
    groupWalkerGear={
      "rt_citadel_c_0032",
      "rt_citadel_c_0020",
      "rt_citadel_c_0008",
      "rt_citadel_c_0002",
    },
  },
}
