-- CentralAfrica_CP_Reference.lua
-- lists the soldiers and routes for each Central African CP (big outpost)

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

mafr_outland_cp = { -- bwala ya masa
  soldier_names = {
    "sol_outland_0000",
    "sol_outland_0001",
    "sol_outland_0002",
    "sol_outland_0003",
    "sol_outland_0004",
    "sol_outland_0005",
    "sol_outland_0006",
    "sol_outland_0007",
    "sol_outland_0008",
    "sol_outland_0009",
    "sol_outland_0010",
    "sol_outland_0011",
  },
  sneakRoutes = {
    "rt_outland_d_0000_no_tower_sub",
    "rt_outland_d_0001_no_tower_sub",
    "rt_outland_d_0002",
    "rt_outland_d_0003",
    "rt_outland_d_0004",
    "rt_outland_d_0005",
    "rt_outland_d_0006",
    "rt_outland_d_0007",
    "rt_outland_d_0008",
    "rt_outland_d_0009",
    "rt_outland_d_0010",
    "rt_outland_d_0011",
    "rt_outland_n_0000_no_search_light_sub",
    "rt_outland_n_0001_no_search_light_sub",
    "rt_outland_n_0002",
    "rt_outland_n_0003",
    "rt_outland_n_0004",
    "rt_outland_n_0005",
    "rt_outland_n_0006",
    "rt_outland_n_0007",
    "rt_outland_n_0008",
    "rt_outland_n_0009",
    "rt_outland_n_0010",
    "rt_outland_n_0011",
  },
  cautionRoutes = {
    "rt_outland_c_0000",
    "rt_outland_c_0000",
    "rt_outland_c_0001",
    "rt_outland_c_0001",
    "rt_outland_c_0002",
    "rt_outland_c_0002",
    "rt_outland_c_0003",
    "rt_outland_c_0003",
    "rt_outland_c_0004",
    "rt_outland_c_0004",
    "rt_outland_c_0005",
    "rt_outland_c_0005",
    "rt_outland_c_0006",
    "rt_outland_c_0006",
  },
  hold = {
    "rt_outland_h_0000",
    "rt_outland_h_0001",
    "rt_outland_h_0002",
    "rt_outland_h_0003",
  },
  sleep = {
    "rt_outland_s_0000",
    "rt_outland_s_0001",
    "rt_outland_s_0002",
    "rt_outland_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_outland_l_0000",
      "rt_outland_l_0001",
    },
    in_lrrpHold_S = {
      "rt_outland_lin_S",
      "rt_outland_lin_S",
    },
    out_lrrpHold_S = {
      "rt_outland_lout_S",
      "rt_outland_lout_S",
    },
    in_lrrpHold_N = {
      "rt_outland_lin_N",
      "rt_outland_lin_N",
    },
    out_lrrpHold_N = {
      "rt_outland_lout_N",
      "rt_outland_lout_N",
    },
  },
  outofrain = {
    "rt_outland_r_0000",
    "rt_outland_r_0001",
    "rt_outland_r_0002",
    "rt_outland_r_0003",
    "rt_outland_r_0004",
    "rt_outland_r_0005",
    "rt_outland_r_0006",
    "rt_outland_r_0007",
    "rt_outland_r_0008",
    "rt_outland_r_0009",
    "rt_outland_r_0010",
    "rt_outland_r_0011",
    "rt_outland_r_0012",
    "rt_outland_r_0013",
    "rt_outland_r_0014",
    "rt_outland_r_0015",
    "rt_outland_r_0016",
    "rt_outland_r_0017",
    "rt_outland_r_0018",
    "rt_outland_r_0019",
  },

  --[[

rt_outland_d_0008 roadside
rt_outland_d_0004 south housing
rt_outland_d_0005 south housing
rt_outland_d_0009 centraal canoopy
rt_outland_d_0010 north buildiinngs lower to mid level
rt_outland_d_0006
rt_outland_n_0005 tiny patrol offside road
rt_outland_n_0010 by white mamba's prisoner building, not patrolling
rt_outland_d_0011 north buildings mid level
rt_outland_n_0011
rt_outland_c_0000 thorough patrols through east side of the camp, crosses road to scout edge of north buildings
rt_outland_c_0001 patrols basin, up to north buildings mid-level, through the buildings and back down to basin
rt_outland_c_0002 cuts through bog, stops where children were practicing, and back to west building by water
rt_outland_c_0003 circles around boat
rt_outland_c_0004 patrols up the hill towards the south jungle and back down 
rt_outland_c_0005 thorough patrol around perimeter of south buildings
rt_outland_c_0006 ventures far beyond the northmost building into the nearby woods and circles around
rt_outland_r_0019 boat, far side
rt_outland_r_0011 boat, under canopy in front of hole
rt_outland_r_0002 boat, behind rts_s10120_n_0002
rt_outland_r_0005 southern perimeter looking toward boat, anti-cheap
rt_outland_r_0010 central canopy looking towards r0005
rt_outland_r_0009 central canopy, between 10 and 7 middle looking towards outside
rt_outland_r_0007 central canopy looking outside
rt_outland_r_0013 north buildings mid level, in the corner. anti-cheap
rt_outland_r_0014 north buildings mid level, by white mamba prs building
rt_outland_r_0017 northmost buildings
rt_outland_r_0016 
rt_outland_r_0012 north lower buildings overlooking bog


story routes from the White Mamba mission -- s10120_area.frt

rts_s10120_d_0010 north buildings, lower level
rts_s10120_d_0003 noorth buildings mid level
rts_s10120_d_0008
rts_s10120_d_0005
rts_s10120_d_0004
rts_s10120_d_0002 boat patrol
rts_s10120_n_0005 north buildings basin to lower level
rts_s10120_n_0007 north buildings lower level
rts_s10120_n_0006
rts_s10120_d_0000 west building by the water
rts_s10120_n_0000 
rts_s10120_d_0001 boat ramp overlooking bog
rts_s10120_n_0002 above 0001
rts_s10120_c_0005 similar to rts 0006
rts_s10120_c_0002 patrols through south buildings
rts_s10120_c_0001 patrols along the roadside from southmost entrance to mid-east side
rts_s10120_s_0002 sleeps in west building by the water
rts_s10120_h_0001 holds outside of bog, near the middle of the area
rts_s10120_h_0002 holds by firepit on east side of the camp
rts_s10120_s_0003 northmost buildings sleepin
rts_s10120_h_0003 watches north entrance to camp
rts_s10120_c_0006 thorough patrol through north buildings, all levels
rts_s10120_c_0005 similar to rts 0006
rts_s10120_c_0003 circles and cuts through boat
rts_s10120_c_0002 patrols through south buildings
rts_s10120_c_0001 patrols along the roadside from southmost entrance to mid-east side
rts_s10120_c_0000 similar to rt 0000 but doesn't cross over to north buildings
]]
  
}

mafr_flowStation_cp = { -- mfinda oilfield
  soldier_names = {
    "sol_flowStation_0000",
    "sol_flowStation_0001",
    "sol_flowStation_0002",
    "sol_flowStation_0003",
    "sol_flowStation_0004",
    "sol_flowStation_0005",
    "sol_flowStation_0006",
    "sol_flowStation_0007",
    "sol_flowStation_0008",
    "sol_flowStation_0009",
    "sol_flowStation_0010",
    "sol_flowStation_0011",

  },
  sniperRoutes = {
    "rt_flowStation_snp_0000",
    "rt_flowStation_snp_0001",
  },
  sneakRoutes = {

    "rt_flowStation_d_0000",
    "rt_flowStation_d_0001",
    "rt_flowStation_d_0002",
    "rt_flowStation_d_0003",
    "rt_flowStation_d_0004",
    "rt_flowStation_d_0005",
    "rt_flowStation_d_0006",
    "rt_flowStation_d_0007",
    "rt_flowStation_d_0008",
    "rt_flowStation_d_0009",
    "rt_flowStation_d_0010",
    "rt_flowStation_d_0011",
    "rt_flowStation_n_0000",
    "rt_flowStation_n_0001",
    "rt_flowStation_n_0002",
    "rt_flowStation_n_0003",
    "rt_flowStation_n_0004",
    "rt_flowStation_n_0005",
    "rt_flowStation_n_0006",
    "rt_flowStation_n_0007",
    "rt_flowStation_n_0008",
    "rt_flowStation_n_0009",
    "rt_flowStation_n_0010",
    "rt_flowStation_n_0011",
  },
  cautionRoutes = {
    "rt_flowStation_c_0000",
    "rt_flowStation_c_0001",
    "rt_flowStation_c_0002",
    "rt_flowStation_c_0003",
    "rt_flowStation_c_0004",
    "rt_flowStation_c_0005",
    "rt_flowStation_c_0006",
    "rt_flowStation_c_0007",
    "rt_flowStation_c_0008",
    "rt_flowStation_c_0009",
    "rt_flowStation_c_0010",
    "rt_flowStation_c_0011",
    "rt_flowStation_c_0012",
    "rt_flowStation_c_0013",
  },
  hold = {
    "rt_flowStation_h_0000",
    "rt_flowStation_h_0001",
    "rt_flowStation_h_0002",
    "rt_flowStation_h_0003",
  },
  sleep = {
    "rt_flowStation_s_0000",
    "rt_flowStation_s_0001",
    "rt_flowStation_s_0002",
    "rt_flowStation_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_flowStation_l_0000",
      "rt_flowStation_l_0001",
    },
    in_lrrpHold_W = {
      "rt_flowStation_lin_W",
      "rt_flowStation_lin_W",
    },
    out_lrrpHold_B01 = {
      "rt_flowStation_lout_B01",
      "rt_flowStation_lout_B01",
    },
    out_lrrpHold_B02 = {
      "rt_flowStation_lout_B02",
      "rt_flowStation_lout_B02",
    },
  },
  --[[
	
	rt_flowStation_d_0000 overwatches tank area from above the ramp, goes up stairs to patrol and overwatch the central square
	rt_flowStation_d_0001 patrols around central square and stops inside Quiet Life room
	rt_flowStation_d_0002 patrols central building guardrails, then walks down and walks around behind the central building to overwatch the tank area from the guardrail
	rt_flowStation_d_0003 patrols central building upper guardrails
	rt_flowStation_d_0004 patrols on walkway below central building guardrails and overwatches above pipe route. also stops at sandbags near bwala entrance
	rt_flowStation_d_0005 on watchtower by AA gun
	rt_flowStation_d_0006 patrols through center of central square, over guardrails
	rt_flowStation_d_0007 watches kiziba entrance by sandbags, patrols back towards nearby containers within the facility
	rt_flowStation_d_0008 patrols bwala entrance, moves from sandbags to sandbags
	rt_flowStation_d_0009 overwatches tank area and then front area before separator area, then patrols area before separator area
	rt_flowStation_d_0010 hangs in bwala entrance building, then patrols around perimeter of separator tank area.
	rt_flowStation_d_0011 patrols between lower tank area across the lower bridge and up the stairs
	rt_flowStation_n_0000 closely patrols perimeter of central building.
	rt_flowStation_n_0001 patrols central building upper walkways
	rt_flowStation_n_0002 patrols central building upper walkways, closer to button room window
	rt_flowStation_n_0003 counterclockwise around the central square
	rt_flowStation_n_0004 holds by entrance to bwala entrance building, outside door
	rt_flowStation_n_0005 holds by AA gun during the day, using the searchlight at night.
	rt_flowStation_n_0006 stands watch outside entrance toward kiziba
	rt_flowStation_n_0007 hangs out in bwala entrance building, patrols through tank area similar to 0010, but patrols toward the tanks and loops back
	rt_flowStation_c_0013 patrols perimeter of tank area, similar to c0010 but doesn't stop to overlook much.
	rt_flowStation_c_0012 central square patrol, checks by car/toilet area
	rt_flowStation_c_0011 checks pipe drop-down entrance, overwatches above pipe exit
	rt_flowStation_c_0010 patrols perimeter of tank area, overwatches area before tank area
	rt_flowStation_c_0009 searches under central square railing, searches room I didn't know existed
	rt_flowStation_c_0008 sandbags watching kiziba entrance, crosses between the two
	rt_flowStation_c_0007 watches bwala entrance by AA gun, moves to overwatch bwala road from below watchtower
	rt_flowStation_c_0006 patrols area before tank area, goes down under the railing by bwala pipe entrance
	rt_flowStation_c_0005 watches bwala entrance, searches near entrance container/power area, searches bwala entrance building
	rt_flowStation_c_0004 patrols around central building, overwatches towards tank area twicewa
	rt_flowStation_c_0003 patrols upper rails of center building, walks down stairs and holds to watch center square, then back up.
	rt_flowStation_c_0002 patrols rails of central building, goes downstairs and back up. checks in on button room.
	rt_flowStation_c_0001 central square patrols center railings, goes down to check below railings, checks in on Quiet Life room
	rt_flowStation_c_0000 overwatches tank area from central building corner, goes up stairs and patrols central building railings
	rt_flowStation_n_0011 holds by bwala entrance, watching entrance
	rt_flowStation_n_0010 simple patrol around area before tank area, particularly around the entrance
	rt_flowStation_n_0009 patrols front central building, down the stairs to the connecting bridge to tank area, below tank area, and through tank area
	rt_flowStation_n_0008 holds in front of sleeping room
	]]
	
	--[[ story routes from the Pitch Dark mission -- s10080_area.frt
	
	rts_flowStation_d_0000 holds before entrance to oil separator tank
	rts_flowStation_n_0000 stopped in front of oil tanks, beside n0002
	rts_flowStation_d_0001 patrols underneath separator tank
	rts_flowStation_n_0001 circles below oil separator tanks
	rts_flowStation_d_0002 circles the area before the separator tanks, stops in front.
	rts_flowStation_n_0002 stopped in front of oil separator tank
	rts_flowStation_d_0003 stopped in front of containers by the exit to kiziba
	rts_flowStation_n_0003 same as d_0003, but looking towards central building
	rts_flowStation_d_0004 patrols walkway to the control room
	rts_flowStation_n_0004 stopped outside building with the "Quiet Life" tape playing
	
	
	rts_flowStation_c_0004 ?
	rts_flowStation_c_0003 patrol under tanks
	rts_flowStation_c_0002 ?
	rts_flowStation_c_0001 ?
	rts_flowStation_c_0000 ?
	
	]]
  

}

mafr_pfCamp_cp = { -- nova braga airport
  soldier_names = {
    "sol_pfCamp_0000",
    "sol_pfCamp_0001",
    "sol_pfCamp_0002",
    "sol_pfCamp_0003",
    "sol_pfCamp_0004",
    "sol_pfCamp_0005",
    "sol_pfCamp_0006",
    "sol_pfCamp_0007",
    "sol_pfCamp_0008",
    "sol_pfCamp_0009",
    "sol_pfCamp_0010",
    "sol_pfCamp_0011",

  },
  sniperRoutes  = {
    "rt_pfCamp_snp_0000",
    "rt_pfCamp_snp_0001",
    "rt_pfCamp_snp_0002",
    "rt_pfCamp_snp_0003",
  },
  sneakRoutes = {
    "rt_pfCamp_d_0000",
    "rt_pfCamp_d_0001",
    "rt_pfCamp_d_0002",
    "rt_pfCamp_d_0003",
    "rt_pfCamp_d_0004",
    "rt_pfCamp_d_0005",
    "rt_pfCamp_d_0006",
    "rt_pfCamp_d_0007",
    "rt_pfCamp_d_0008",
    "rt_pfCamp_d_0009",
    "rt_pfCamp_d_0010",
    "rt_pfCamp_d_0011",
    "rt_pfCamp_n_0000_sub",
    "rt_pfCamp_n_0001_sub",
    "rt_pfCamp_n_0002",
    "rt_pfCamp_n_0003",
    "rt_pfCamp_n_0004",
    "rt_pfCamp_n_0005",
    "rt_pfCamp_n_0006",
    "rt_pfCamp_n_0007",
    "rt_pfCamp_n_0008",
    "rt_pfCamp_n_0009",
    "rt_pfCamp_n_0010",
    "rt_pfCamp_n_0011",
  },
  cautionRoutes = {
    "rt_pfCamp_c_0002",
    "rt_pfCamp_c_0002",
    "rt_pfCamp_c_0003",
    "rt_pfCamp_c_0004",
    "rt_pfCamp_c_0005",
    "rt_pfCamp_c_0006",
    "rt_pfCamp_c_0007",
    "rt_pfCamp_c_0008",
    "rt_pfCamp_c_0008",
    "rt_pfCamp_c_0009",
    "rt_pfCamp_c_0010",
    "rt_pfCamp_c_0011",
    "rt_pfCamp_c_0000",
    "rt_pfCamp_c_0001",
  },

  hold = {
    "rt_pfCamp_h_0000",
    "rt_pfCamp_h_0001",
  },
  sleep = {
    "rt_pfCamp_s_0000",
    "rt_pfCamp_s_0001",
  },
  travel = {
    lrrpHold = {
      "rt_pfCamp_l_0000",
      "rt_pfCamp_l_0001",
    },
    in_lrrpHold_S = {
      "rt_pfCamp_lin_S",
      "rt_pfCamp_lin_S",
    },
    out_lrrpHold_S = {
      "rt_pfCamp_lout_S",
      "rt_pfCamp_lout_S",
    },
  },
  outofrain = {
    "rt_pfCamp_r_0000",
    "rt_pfCamp_r_0001",
    "rt_pfCamp_r_0002",
    "rt_pfCamp_r_0003",
    "rt_pfCamp_r_0004",
    "rt_pfCamp_r_0005",
    "rt_pfCamp_r_0006",
    "rt_pfCamp_r_0007",
    "rt_pfCamp_r_0008",
    "rt_pfCamp_r_0009",
    "rt_pfCamp_r_0010",
    "rt_pfCamp_r_0011",
    "rt_pfCamp_r_0012",
    "rt_pfCamp_r_0013",
    "rt_pfCamp_r_0014",
    "rt_pfCamp_r_0015",
    "rt_pfCamp_r_0016",
    "rt_pfCamp_r_0017",
    "rt_pfCamp_r_0018",
    "rt_pfCamp_r_0019",
  },

    --[[
  
  rt_pfCamp_n_0000 south spotlight
  rt_pfCamp_n_0001 east spotlight, hits activearea wall
  rt_pfCamp_n_0005 rooftop patrol 
  rt_pfCamp_n_0010 patrol half-loop through central building and down north stairs
  rt_pfCamp_n_0004 patrols near n0010, goes in central building but not up the stairs
  rt_pfCamp_n_0009 patrols perimeter of west sector, enters 2 buildings
  rt_pfCamp_n_0008 patrols inner perimeter of west sector, enters other 2 buildings and central building
  rt_pfCamp_n_0002 inside central building second floor, walks around near comms equipment
  rt_pfCamp_n_0011 patrols inside in waiting room of second floor, walks outside to nearby building
  rt_pfCamp_n_0003 idle by LRRP parking
  rt_pfCamp_n_0007 east side patrol
  rt_pfCamp_n_0006 east side patrol
  
  rt_pfCamp_d_0000 idle inside south watchtower
  rt_pfCamp_d_0001 idle inside east watchtower, activearea despawn
  rt_pfCamp_d_0003 patrols west sector, 1 building and inside the garage
  rt_pfCamp_d_0004 patrols through west sector, central building, front of central building, north of central building and second floor of central building
  rt_pfCamp_d_0005 idles by LRRP parking
  rt_pfCamp_d_0008 walks back and forth in front of main building
  rt_pfCamp_d_0007 patrols north hangar and nearby
  rt_pfCamp_d_0002 rooftop patrol, same routhe as n0005
  rt_pfCamp_d_0006 patrols inside waiting room of second floor walks outside to nearby building. goes up main staircase and watches waiting room's other window that rt_pfCamp_n_0011 doesn't
  rt_pfCamp_d_0009 exact replica of n0002. lazy.
  rt_pfCamp_d_0011 east side patrol
  rt_pfCamp_d_0010 east side patrol
  
  rt_pfCamp_c_0001 south spotlight
  rt_pfCamp_c_0003 patrol west sector, buildings beside beside garage
  rt_pfCamp_c_0011 patrol west sector, strictly the perimeter and inside garage
  rt_pfCamp_c_0006 idle by LRRP parking
  rt_pfCamp_c_0009 patrols second floor of main building and rooftop
  rt_pfCamp_c_0004 idle in front of main building
  rt_pfCamp_c_0005 patrols first floor of main building and north hangar
  rt_pfCamp_c_0010 patrols north hangar
  rt_pfCamp_c_0008 patrols south hangar
  rt_pfCamp_c_0007 patrols both rooms of building in front of central building, goes to second floor of central building and through waiting room
  rt_pfCamp_c_0002 east side patrol
  rt_pfCamp_c_0000 east spotlight
  
  rt_quest_d_0004 patrol front of central building
  rt_quest_d_0003 patrol front of central building
  
  ]]
}


mafr_savannah_cp = { -- ditadi abandoned village
  soldier_names = {
    "sol_savannah_0000",
    "sol_savannah_0001",
    "sol_savannah_0002",
    "sol_savannah_0003",
    "sol_savannah_0004",
    "sol_savannah_0005",
    "sol_savannah_0006",
    "sol_savannah_0007",
    "sol_savannah_0008",
    "sol_savannah_0009",
    "sol_savannah_0010",
    "sol_savannah_0011",

  },
  sneakRoutes = {
    "rt_savannah_d_0000",
    "rt_savannah_d_0007",
    "rt_savannah_d_0002",
    "rt_savannah_d_0003",
    "rt_savannah_d_0012",
    "rt_savannah_d_0005",
    "rt_savannah_d_0006",
    "rt_savannah_d_0001",
    "rt_savannah_d_0004",
    "rt_savannah_d_0013",
    "rt_savannah_d_0009",
    "rt_savannah_d_0010",
    "rt_savannah_d_0011",
    "rt_savannah_d_0008",
    "rt_savannah_n_0000_sub",
    "rt_savannah_n_0003",
    "rt_savannah_n_0002",
    "rt_savannah_n_0001",
    "rt_savannah_n_0012",
    "rt_savannah_n_0004",
    "rt_savannah_n_0005",
    "rt_savannah_n_0006_sub",
    "rt_savannah_n_0009",
    "rt_savannah_n_0011_sub",
    "rt_savannah_n_0007_sub",
    "rt_savannah_n_0010",
    "rt_savannah_n_0013",
    "rt_savannah_n_0008",
  },
  cautionRoutes = {
    "rt_savannah_c_0000",
    "rt_savannah_c_0001",
    "rt_savannah_c_0002",
    "rt_savannah_c_0003",
    "rt_savannah_c_0004",
    "rt_savannah_c_0005",
    "rt_savannah_c_0006",
    "rt_savannah_c_0007",
    "rt_savannah_c_0008",
    "rt_savannah_c_0009",
    "rt_savannah_c_0010",
    "rt_savannah_c_0011",
    "rt_savannah_c_0012",
    "rt_savannah_c_0013",
  },
  hold = {
    "rt_savannah_h_0000",
    "rt_savannah_h_0001",
    "rt_savannah_h_0002",
    "rt_savannah_h_0003",
  },
  sleep = {
    "rt_savannah_s_0000",
    "rt_savannah_s_0001",
    "rt_savannah_s_0002",
    "rt_savannah_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_savannah_l_0000",
      "rt_savannah_l_0001",
    },
    in_lrrpHold_E = {
      "rt_savannah_lin_E",
      "rt_savannah_lin_E",
    },
    out_lrrpHold_E = {
      "rt_savannah_lout_E",
      "rt_savannah_lout_E",
    },
    in_lrrpHold_W = {
      "rt_savannah_lin_W",
      "rt_savannah_lin_W",
    },
    out_lrrpHold_W = {
      "rt_savannah_lout_W",
      "rt_savannah_lout_W",
    },
  },
  outofrain = {
    "rt_savannah_r_0000",
    "rt_savannah_r_0001",
    "rt_savannah_r_0002",
    "rt_savannah_r_0003",
    "rt_savannah_r_0004",
    "rt_savannah_r_0005",
    "rt_savannah_r_0006",
    "rt_savannah_r_0007",
    "rt_savannah_r_0008",
    "rt_savannah_r_0009",
    "rt_savannah_r_0010",
    "rt_savannah_r_0011",
  },

}


mafr_swamp_cp = { -- kiziba camp
  soldier_names = {
    "sol_swamp_0000",
    "sol_swamp_0001",
    "sol_swamp_0002",
    "sol_swamp_0003",
    "sol_swamp_0004",
    "sol_swamp_0005",
    "sol_swamp_0006",
    "sol_swamp_0007",
    "sol_swamp_0008",
    "sol_swamp_0009",
    "sol_swamp_0010",
    "sol_swamp_0011",

  },
  sniperRoutes = {
    "rt_swamp_snp_0000",
    "rt_swamp_snp_0001",
  },
  sneakRoutes = {
    "rt_swamp_d_0000",
    "rt_SwampNear_d_0000",
    "rt_swamp_d_0007",
    "rt_swamp_d_0011",
    "rt_swamp_d_0001",
    "rt_SwampNear_d_0001",
    "rt_swamp_d_0008",
    "rt_swamp_d_0012",
    "rt_swamp_d_0002",
    "rt_SwampNear_d_0002_no_watchtower_sub",
    "rt_swamp_d_0009",
    "rt_SwampNear_d_0004",
    "rt_swamp_d_0003",
    "rt_swamp_d_0005",
    "rt_swamp_d_0010",
    "rt_swamp_d_0013",
    "rt_swamp_d_0004",
    "rt_swamp_d_0006",
    "rt_SwampNear_d_0003",
    "rt_swamp_d_0014",
    "rt_swamp_n_0000",
    "rt_SwampNear_n_0000_no_searchlight_sub",
    "rt_swamp_n_0007",
    "rt_swamp_n_0011",
    "rt_swamp_n_0001_no_searchlight_sub",
    "rt_SwampNear_n_0001_no_searchlight_sub",
    "rt_swamp_n_0008_no_searchlight_sub",
    "rt_swamp_n_0012",
    "rt_swamp_n_0002",
    "rt_SwampNear_n_0002",
    "rt_swamp_n_0009_no_searchlight_sub",
    "rt_SwampNear_n_0004",
    "rt_swamp_n_0003_no_searchlight_sub",
    "rt_swamp_n_0005_no_searchlight_sub",
    "rt_swamp_n_0010",
    "rt_swamp_n_0013",
    "rt_swamp_n_0004",
    "rt_swamp_n_0006",
    "rt_SwampNear_n_0003",
    "rt_swamp_n_0014",
  },
  cautionRoutes = {
    "rt_swamp_c_0000",
    "rt_swamp_c_0001",
    "rt_swamp_c_0002",
    "rt_swamp_c_0003",
    "rt_swamp_c_0004_searchlight",
    "rt_SwampNear_c_0000",
    "rt_SwampNear_c_0001_searchlight",
    "rt_SwampNear_c_0002",
    "rt_swamp_c_0005",
    "rt_swamp_c_0006",
    "rt_swamp_c_0007",
    "rt_swamp_c_0008",
    "rt_swamp_c_0009",
    "rt_swamp_c_0010",
    "rt_SwampNear_c_0003",
    "rt_SwampNear_c_0004",
    "rt_swamp_c_0000",
    "rt_swamp_c_0011",
    "rt_swamp_c_0012",
    "rt_swamp_c_0013",
    "rt_swamp_c_0014",
    "rt_swamp_c_0015",
  },
  hold = {
    "rt_swamp_h_0000",
    "rt_swamp_h_0001",
    "rt_swampNear_h_0000",
    "rt_swamp_h_0002",
    "rt_swampNear_h_0001",
  },
  sleep = {
    "rt_swamp_s_0000",
    "rt_swamp_s_0001",
    "rt_swampNear_s_0000",
    "rt_swamp_s_0002",
    "rt_swampNear_s_0001",
  },
  travel = {
    lrrpHold = {
      "rt_swamp_l_0000",
      "rt_swamp_l_0001",
    },
    lrrpHold_01 = {
      "rt_swamp_l_0002",
      "rt_swamp_l_0003",
    },
    in_lrrpHold_N = {
      "rt_swamp_lin_N",
      "rt_swamp_lin_N",
    },
    in_lrrpHold_E = {
      "rt_swamp_lin_E",
      "rt_swamp_lin_E",
    },
    out_lrrpHold_B01 = {
      "rt_swamp_lout_B01",
      "rt_swamp_lout_B01",
    },
    out_lrrpHold_B02 = {
      "rt_swamp_lout_B02",
      "rt_swamp_lout_B02",
    },
    out_lrrpHold_B03 = {
      "rt_swamp_lout_B03",
      "rt_swamp_lout_B03",
    },
    out_lrrpHold_B04 = {
      "rt_swamp_lout_B04",
      "rt_swamp_lout_B04",
    },
  },
  outofrain = {
    "rt_swamp_r_0000",
    "rt_swamp_r_0001",
    "rt_swamp_r_0002",
    "rt_swamp_r_0003",
    "rt_swamp_r_0004",
    "rt_swamp_r_0005",
    "rt_swamp_r_0006",
    "rt_swamp_r_0007",
    "rt_swamp_r_0008",
    "rt_swamp_r_0009",
    "rt_swamp_r_0010",
    "rt_swamp_r_0011",
  },

}


mafr_banana_cp = { -- bampeve plantation
  soldier_names = {

    "sol_banana_0000",
    "sol_banana_0001",
    "sol_banana_0002",
    "sol_banana_0003",
    "sol_banana_0004",
    "sol_banana_0005",
    "sol_banana_0006",
    "sol_banana_0007",
    "sol_banana_0008",
    "sol_banana_0009",
    "sol_banana_0010",
    "sol_banana_0011",

  },
  sneakRoutes = {
    "rt_banana_d_0000",
    "rt_banana_d_0003",
    "rt_banana_d_0005",
    "rt_banana_d_0008",
    "rt_banana_d_0001",
    "rt_banana_d_0004_sub",
    "rt_banana_d_0006",
    "rt_banana_d_0009",
    "rt_banana_d_0002",
    "rt_banana_d_0005",
    "rt_banana_d_0007",
    "rt_banana_d_0010",
    "rt_banana_n_0000_sub",
    "rt_banana_n_0003",
    "rt_banana_n_0006",
    "rt_banana_n_0009",
    "rt_banana_n_0001",
    "rt_banana_n_0004_sub",
    "rt_banana_n_0007_sub",
    "rt_banana_n_0010",
    "rt_banana_n_0002",
    "rt_banana_n_0005_sub",
    "rt_banana_n_0008",
    "rt_banana_n_0011",
  },
  cautionRoutes = {
    "rt_banana_c_0000",
    "rt_banana_c_0001",
    "rt_banana_c_0001",
    "rt_banana_c_0002",
    "rt_banana_c_0003",
    "rt_banana_c_0004",
    "rt_banana_c_0005",
    "rt_banana_c_0006",
    "rt_banana_c_0007",
    "rt_banana_c_0008",
    "rt_banana_c_0009",
    "rt_banana_c_0010",
    "rt_banana_c_0011",
    "rt_banana_c_0012",
    "rt_banana_c_0012",
  },
  hold = {
    "rt_banana_h_0000",
    "rt_banana_h_0001",
    "rt_banana_h_0002",
    "rt_banana_h_0003",
  },
  sleep = {
    "rt_banana_s_0000",
    "rt_banana_s_0001",
    "rt_banana_s_0002",
    "rt_banana_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_banana_l_0000",
      "rt_banana_l_0001",
    },
    in_lrrpHold_N = {
      "rt_banana_lin_N",
      "rt_banana_lin_N",
    },
    out_lrrpHold_B01 = {
      "rt_banana_lout_B01",
      "rt_banana_lout_B01",
    },
    out_lrrpHold_B02 = {
      "rt_banana_lout_B02",
      "rt_banana_lout_B02",
    },
  },
  outofrain = {
    "rt_banana_r_0000",
    "rt_banana_r_0001",
    "rt_banana_r_0002",
    "rt_banana_r_0003",
    "rt_banana_r_0004",
    "rt_banana_r_0005",
    "rt_banana_r_0006",
    "rt_banana_r_0007",
    "rt_banana_r_0008",
    "rt_banana_r_0009",
    "rt_banana_r_0010",
    "rt_banana_r_0011",
    "rt_banana_r_0012",
    "rt_banana_r_0013",
    "rt_banana_r_0014",
    "rt_banana_r_0015",
    "rt_banana_r_0016",
    "rt_banana_r_0017",
    "rt_banana_r_0018",
    "rt_banana_r_0019",
  },

}


mafr_diamond_cp = { -- kungenga mine
  soldier_names = {
    "sol_diamond_0000",
    "sol_diamond_0001",
    "sol_diamond_0002",
    "sol_diamond_0003",
    "sol_diamond_0004",
    "sol_diamond_0005",
    "sol_diamond_0006",
    "sol_diamond_0007",
    "sol_diamond_0008",
    "sol_diamond_0009",
    "sol_diamond_0010",
    "sol_diamond_0011",

  },
  sneakRoutes = {
    "rt_diamond_d_0000",
    "rt_diamond_d_0003",
    "rt_diamond_d_0005",
    "rt_diamond_d_0008",
    "rt_diamond_d_0001",
    "rt_diamond_d_0004",
    "rt_diamond_d_0006",
    "rt_diamond_d_0009",
    "rt_diamond_d_0002",
    "rt_diamond_d_0004",
    "rt_diamond_d_0007",
    "rt_diamond_d_0010",
    "rt_diamond_n_0000_sub",
    "rt_diamond_n_0003",
    "rt_diamond_n_0006",
    "rt_diamond_n_0009",
    "rt_diamond_n_0001_sub",
    "rt_diamond_n_0004",
    "rt_diamond_n_0007",
    "rt_diamond_n_0010",
    "rt_diamond_n_0002_sub",
    "rt_diamond_n_0005",
    "rt_diamond_n_0008_sub",
    "rt_diamond_n_0011",
  },
  cautionRoutes = {
    "rt_diamond_c_0000",
    "rt_diamond_c_0001",
    "rt_diamond_c_0002",
    "rt_diamond_c_0003",
    "rt_diamond_c_0004",
    "rt_diamond_c_0005",
    "rt_diamond_c_0006",
    "rt_diamond_c_0007",
    "rt_diamond_c_0008",
    "rt_diamond_c_0009",
    "rt_diamond_c_0010",
    "rt_diamond_c_0011",
    "rt_diamond_c_0012",
    "rt_diamond_c_0012",
  },
  hold = {
    "rt_diamond_h_0000",
    "rt_diamond_h_0001",
    "rt_diamond_h_0002",
    "rt_diamond_h_0003",
  },
  sleep = {
    "rt_diamond_s_0000",
    "rt_diamond_s_0001",
    "rt_diamond_s_0002",
    "rt_diamond_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_diamond_l_0000",
      "rt_diamond_l_0001",
    },
    in_lrrpHold_S = {
      "rt_diamond_lin_S",
      "rt_diamond_lin_S",
    },
    out_lrrpHold_B01 = {
      "rt_diamond_lout_B01",
      "rt_diamond_lout_B01",
    },
    out_lrrpHold_B02 = {
      "rt_diamond_lout_B02",
      "rt_diamond_lout_B02",
    },
    out_lrrpHold_B03 = {
      "rt_diamond_lout_B03",
      "rt_diamond_lout_B03",
    },
  },
  outofrain = {
    "rt_diamond_r_0000",
    "rt_diamond_r_0001",
    "rt_diamond_r_0002",
    "rt_diamond_r_0003",
    "rt_diamond_r_0004",
    "rt_diamond_r_0005",
    "rt_diamond_r_0006",
    "rt_diamond_r_0007",
    "rt_diamond_r_0008",
    "rt_diamond_r_0009",
    "rt_diamond_r_0010",
    "rt_diamond_r_0011",
    "rt_diamond_r_0012",
    "rt_diamond_r_0013",
    "rt_diamond_r_0014",
    "rt_diamond_r_0015",
    "rt_diamond_r_0016",
    "rt_diamond_r_0017",
    "rt_diamondSwamp_r_0000",
    "rt_diamondSwamp_r_0001",
  },

}


mafr_hill_cp = { -- munoko ya nioka station
  soldier_names = {
    "sol_hill_0000",
    "sol_hill_0001",
    "sol_hill_0002",
    "sol_hill_0003",
    "sol_hill_0004",
    "sol_hill_0005",
    "sol_hill_0006",
    "sol_hill_0007",
    "sol_hill_0008",
    "sol_hill_0009",
    "sol_hill_0010",
    "sol_hill_0011",

  },
  sneakRoutes = {
    "rt_hill_d_0002",
    "rt_hill_d_0010",
    "rt_hill_d_0000",
    "rt_hill_d_0009",
    "rt_hill_d_0003",
    "rt_hill_d_0008",
    "rt_hill_d_0006",
    "rt_hill_d_0007",
    "rt_hill_d_0011",
    "rt_hill_d_0004",
    "rt_hill_d_0001",
    "rt_hill_d_0005",
    "rt_hill_n_0002",
    "rt_hill_n_0011",
    "rt_hill_n_0000_sub",
    "rt_hill_n_0009",
    "rt_hill_n_0004",
    "rt_hill_n_0006",
    "rt_hill_n_0008",
    "rt_hill_n_0007",
    "rt_hill_n_0010",
    "rt_hill_n_0003",
    "rt_hill_n_0001_sub",
    "rt_hill_n_0005",
  },
  cautionRoutes = {
    "rt_hill_c_0000",
    "rt_hill_c_0001",
    "rt_hill_c_0002",
    "rt_hill_c_0003",
    "rt_hill_c_0004",
    "rt_hill_c_0005",
    "rt_hill_c_0006",
    "rt_hill_c_0007",
    "rt_hill_c_0008",
    "rt_hill_c_0009",
    "rt_hill_c_0010",
    "rt_hill_c_0011",
    "rt_hill_c_0004",
    "rt_hill_c_0011",
  },
  hold = {
    "rt_hill_h_0000",
    "rt_hill_h_0001",
    "rt_hill_h_0002",
  },
  sleep = {
    "rt_hill_s_0000",
    "rt_hill_s_0001",
    "rt_hill_s_0002",
  },
  travel = {
    lrrpHold = {
      "rt_hill_l_0000",
      "rt_hill_l_0001",
    },
    in_lrrpHold_S = {
      "rt_hill_lin_S",
      "rt_hill_lin_S",
    },
    out_lrrpHold_B01 = {
      "rt_hill_lout_B01",
      "rt_hill_lout_B01",
    },
    out_lrrpHold_B02 = {
      "rt_hill_lout_B02",
      "rt_hill_lout_B02",
    },
  },
  outofrain = {
    "rt_hill_r_0000",
    "rt_hill_r_0001",
    "rt_hill_r_0002",
    "rt_hill_r_0003",
    "rt_hill_r_0004",
    "rt_hill_r_0005",
    "rt_hill_r_0006",
    "rt_hill_r_0007",
    "rt_hill_r_0008",
    "rt_hill_r_0009",
    "rt_hill_r_0010",
    "rt_hill_r_0011",
  },

}


mafr_lab_cp = { -- lufwa valley
  soldier_names = {
    "sol_lab_0000",
    "sol_lab_0001",
    "sol_lab_0002",
    "sol_lab_0003",
    "sol_lab_0004",
    "sol_lab_0005",
    "sol_lab_0006",
    "sol_lab_0007",
    "sol_lab_0008",
    "sol_lab_0009",
    "sol_lab_0010",
    "sol_lab_0011",
  },
  sneakRoutes = {
    "rt_lab_d_0000",
    "rt_lab_d_0005",
    "rt_lab_d_0002",
    "rt_lab_d_0012",
    "rt_lab_d_0001",
    "rt_lab_d_0007",
    "rt_lab_d_0008",
    "rt_lab_d_0006",
    "rt_lab_d_0002",
    "rt_lab_d_0006",
    "rt_lab_d_0007",
    "rt_lab_d_0004",
    "rt_lab_d_0003",
    "rt_lab_d_0009",
    "rt_lab_d_0006",
    "rt_lab_d_0007",
    "rt_lab_d_0004",
    "rt_lab_d_0008",
    "rt_lab_d_0002",
    "rt_lab_d_0008",
    "rt_lab_n_0000",
    "rt_lab_n_0007",
    "rt_lab_n_0002",
    "rt_lab_n_0012",
    "rt_lab_n_0001",
    "rt_lab_n_0009",
    "rt_lab_n_0006",
    "rt_lab_n_0013",
    "rt_lab_n_0002",
    "rt_lab_n_0008",
    "rt_lab_n_0007",
    "rt_lab_n_0002",
    "rt_lab_n_0004",
    "rt_lab_n_0003",
    "rt_lab_n_0010",
    "rt_lab_n_0006",
    "rt_lab_n_0006",
    "rt_lab_n_0005",
    "rt_lab_n_0011",
    "rt_lab_n_0007",
  },
  cautionRoutes = {
    "rt_lab_c_0000",
    "rt_lab_c_0001",
    "rt_lab_c_0002",
    "rt_lab_c_0004",
    "rt_lab_c_0005",
    "rt_lab_c_0008",
    "rt_lab_c_0009",
    "rt_lab_c_0000",
    "rt_lab_c_0001",
    "rt_lab_c_0003",
    "rt_lab_c_0004",
    "rt_lab_c_0005",
    "rt_lab_c_0008",
    "rt_lab_c_0007",
    "rt_lab_c_0000",
    "rt_lab_c_0001",
    "rt_lab_c_0004",
    "rt_lab_c_0005",
    "rt_lab_c_0008",
    "rt_lab_c_0006",
    "rt_lab_c_0001",
    "rt_lab_c_0008",
  },
  hold = {
    "rt_lab_h_0000",
    "rt_lab_h_0001",
    "rt_lab_h_0002",
    "rt_lab_h_0003",
  },
  sleep = {
    "rt_lab_s_0000",
    "rt_lab_s_0001",
    "rt_lab_s_0002",
    "rt_lab_s_0003",
  },
  travel = {
    lrrpHold = {
      "rt_lab_l_0000",
      "rt_lab_l_0001",
    },

    in_lrrpHold_W = {
      "rt_lab_lin_W",
      "rt_lab_lin_W",
    },

    out_lrrpHold_W = {
      "rt_lab_lout_W",
      "rt_lab_lout_W",
    },
  },
  outofrain = {
    "rt_lab_r_0000",
    "rt_lab_r_0001",
    "rt_lab_r_0002",
    "rt_lab_r_0003",
    "rt_lab_r_0004",
    "rt_lab_r_0005",
    "rt_lab_r_0006",
    "rt_lab_r_0007",
    "rt_lab_r_0008",
    "rt_lab_r_0009",
    "rt_lab_r_0010",
    "rt_lab_r_0011",
    "rt_lab_r_0012",
    "rt_lab_r_0013",
    "rt_lab_r_0014",
    "rt_lab_r_0015",
    "rt_lab_r_0016",
    "rt_lab_r_0017",
    "rt_lab_r_0018",
  },
 --[[ 
 
 
 
 
 story routes from the Cursed Legacy mission -- lab_q10700.frt
 
 		routes that walk around:
				
			rts_lab_a_035_0022 -- entrance to mid-jungle, on upper crust
			rts_lab_a_025_0021 -- entrance to mid-jungle, patrolling the backwater
			rts_lab_a_015_0018 -- entrance to mid-jungle, peeks through entrance briefly
			rts_lab_a_030_0020 -- late-jungle to jungle exit, walks through a small canyon on his way to the "TGS demo" tent and turns around.
			rts_lab_a_010_0015 -- by TGS Demo tent, walks between 0021 and the bridge toward lab, but stops short of actually walking over the bridge.
			rts_lab_a_020_0019 -- below demo tent, walks between 0020's exit and the bridge that 0008 watches over from the other side. doesn't use bridge.
			rts_lab_a_04x_0001 -- very long route. walks the canyon similar to 0020, but then walks across bridge to boring area and comes back.
			
			rts_lab_c_050_0014 -- moves between rts_lab_a_040_0008 and central-boring area
			rts_lab_c_080_0000 -- moves between middle bridge and central boring area. like rts_lab_c_050_0014
			rts_lab_c_090_0000 -- short patrol in late-jungle area
			rts_lab_a_090_0009 -- short patrol in mid to late jungle area. seems familiar.
			rts_lab_a_110_0014 -- short patrol in late-jungle area, can be seen below TGS tent
			
		
		stationary routes: 
			
			rts_lab_a_015_0009 center of jungle, smokes all the time and only moves an inch.
			rts_lab_a_065_0020 stands beside 0009
			rts_lab_a_025_0010 stands across from 0009, watches toward lab
			rts_lab_a_075_0007 stands nearby 0009, but displaced a little farther than the others. watching towards waterfalls.
			rts_lab_a_045_0018 stands a short distance from the 0009 gang, like 0007. however, he's closer to the lab. watching toward lab.
			rts_lab_a_055_0019 stands with the 0009 gang, watching toward lab-waterfall
			rts_lab_a_035_0021 stands under TGS demo tent. same place where the guards were holding Tan.
			rts_lab_a_030_0014 stands close to 0021, watching toward lab and occasionally moving an inch. 
			rts_lab_a_040_0008 watches over the middle bridge connecting the jungle to the boring area.
			rts_lab_a_060_0015 stands in boring area, watching toward jungle. COULD BE rts_lab_a_050_0016
			rts_lab_a_050_0016 guards the south-most bridge on the jungle-side, watches toward jungle. COULD BE rts_lab_a_060_0015
			rts_lab_a_070_0007 same as 0015, slightly closer to south-most bridge.
			rts_lab_a_010_0007 stands in boring area, further back from rts_lab_a_070_0007. smokes all day
			rts_lab_a_020_0017 same as rts_lab_a_010_0007, stands slightly to the left of him.
			
			rts_lab_c_030_0012 TGS tent
			rts_lab_c_035_0017 TGS tent
			rts_lab_c_010_0008 back of boring area
			rts_lab_c_040_0000 central boring area
			rts_lab_c_020_0015 back of boring area
			rts_lab_c_070_0008 barely moves. he's between rts_lab_c_050_0014 and rts_lab_c_080_0000.
			rts_lab_c_060_0013 basically rts_lab_a_050_0016, moves a little 
			rts_lab_c_100_0008 -- very short walk route, located just after rts_lab_c_090_0000
			rts_lab_c_075_0008 -- very short walk in central forest
			rts_lab_c_085_0000 -- very short walk, just below rts_lab_c_075_0008
			rts_lab_c_095_0000 -- very short walk, located  before rts_lab_c_085_0000 closer to the jungle entrance
			rts_lab_c_110_0011 -- very short walk late in the jungle
			rts_lab_c_055_0001 -- central jungle gang, barely walks
			The others are in the central jungle gang.
			rts_lab_c_105_0008 -- paces near jungle entrance, quickly back and forth
			rts_lab_a_105_0010 -- same as 0008, stops for longer
			rts_lab_a_095_0009 smoking, almost completely stopped, a little further behind 0008 and 0010 -- I think I like it
			rts_lab_a_085_0008 stopped, further behind 0009. little unnecessary
			rts_lab_a_115_0014 slightly past the central gang. Watching towards lab. moves ever so slightly
			rts_lab_c_115_0012 same as 0014, but gun at the ready. does not move.
			rts_labJungle_In_0000 - 0003 all stopped beside tent. kinda pointless in this case
			rts_lab_a_080_0008 stopped in boring area, watching towards southern bridge
			rts_lab_a_100_0010 -- very short path, at jungle exits, watching into the jungle.
 ]]
 
 ]]
}
