# SOC - SideOp Companion

SideOp Companion is a UI-driven program, designed to help automate the process of creating custom sideops for Metal Gear Solid V: The Phantom Pain with the goal of improving their accessibility. 

## Overview - Custom Sideops For Metal Gear Solid V: The Phantom Pain

Custom Sideops are playable, user-created side-missions which can be added to the game through [TinManTex's Infinite Heaven mod](https://www.nexusmods.com/metalgearsolidvtpp/mods/45/?). Creating custom sideops manually can be difficult, even for experienced MGSV modders. Without an acute understanding of the game's files, formats and limitations, the user can often find themselves lost and confused.

SOC, or SideOp Companion, is my attempt to automate the process of creating custom sideops. The program alleviates a great deal of the difficult, tedious work involved in creating a custom sideop. Even with minimal understanding of modding, users can create and test their own custom sideops with relative ease. SOC can even create sideops with greater detail than those found in the base game, without even touching the game files. It is perhaps possible that SOC will make Custom Sideops the simplest and most accessible form of MGSV modding.

## Setup Page - Understanding The SOC Setup Page

Upon opening SOC.exe, the user is met with the Setup Page. This page prompts the user to fill in a number of forms which are required for a custom sideop.

* **.FPK Filename**: This is what the sideop will be named in the gamefiles. The user should think of a name which will be unique to the sideop.
  * Examples: MorbidQuest00, MorbidQuest01, ih_sheep_quest, ih_pilot_quest, Example_QuestName
* **Quest Number**: This quest number is how Infinite Heaven adds new sideops to the game. The quest number can range between 30103 and 39009. **Users should check which quest numbers have already been taken by other mod authors by opening the MGS_TPP directory with Infinite Heaven installed, then navigating to \mod\modules\InfQuest.lua. The user can pick any quest number they wish for testing purposes, but prior to publishing custom sideops to nexusmods, users should contact [Tinmantex](https://www.nexusmods.com/metalgearsolidvtpp/users/26892144) to reserve their quest numbers, which will then be recorded in InfQuest.lua.**
  * If the user is unsure of what to write to Tinmantex, simply tell him: "I am making a custom sideop(s), and I wish to reserve \<X Amount Of> Quest Numbers." He can tell you which numbers to use. 
* **Quest Map**: The Area of Operations for the sideop. The user can choose to create a sideop for Afghanistan, Central Africa or even Mother Base (with limitations).
* **Quest Area**: Quest Areas are fractions of the map where a single sideop is available. The user should choose the appropriate area that the sideop will be located within. 
  * Read '[SOC QuickMenu Guide](https://github.com/Morbidslinky/SOC#soc-quickmenu-guide)' for information about *how* to get the correct area name.
* **Quest CP**: This is the name of the enemy Command Post for the sideop. Each enemy encampment in MGSV has a CP which determines the alert status of the encampment's soldiers. SOC will draw enemy-related information from the selected CP, such as route names and pre-existing soldiers in the encampment.
  * Some CP names are rather self-explanitory (ex: afgh_powerPlant_cp refers to the Serak Powerplant in Afghanistan). Other CP names are more confusing (ex: mafr_pfCamp_cp refers to Nova Braga Airport in Central Africa).
  * Read '[SOC QuickMenu Guide](https://github.com/Morbidslinky/SOC#soc-quickmenu-guide)' for how to find an encampment's CP name.
* **Map Coordinates: X Y Z**: These are the ingame coordinates for the center of the side-mission circle that appears on the iDroid. The circle is aesthetic, and does not affect the actual gameplay aside from the pop-up UI which notifies the player upon entering the circle.
  * Read '[SOC QuickMenu Guide](https://github.com/Morbidslinky/SOC#soc-quickmenu-guide)' for how to get in-game coordinates.
* **Radius**: This determines the size of the side-mission circle that appears on the iDroid. The radius of a sideop is likewise aesthetic.
* **Quest Category**: Categories are only used for selecting which sideops will appear in an Area of Operations. The user can choose whichever category that they feel will fit the sideop best.
  * The sideop does not need to match the category perfectly (ex: using ELIMINATE_HEAVY_INFANTRY for a sideop that involves assassinating a VIP, or using ELIMINATE_PUPPETS for a sideop that involves rescuing zombies).
* **Quest Rank**: this is essentially the GMP reward for completing the mission. The user can choose any rank between 300,000 GMP (S rank) and 30,000 GMP (I rank), as they please.
* **Objective Type**: This determines whether the sideop targets need to be rescued (RECOVERED) or eliminated (ELIMINATE) by the player in order to complete the sideop.
  * Sideops can technically be given fairly complex and unique win-states, but requires the user to manually edit the sideop's LUA script file.
* **Quest Title**: This is the sideop's name that shows up on the iDroid in-game.
  * The title itself is aesthetic. The flavor text has no affect on the gameplay.
* **Quest Description**: Like with the Quest Title, the Quest Description will appear on the iDroid menu in-game, when you select the sideop on the side-missions list.
  * The description is likewise flavor text, with no bearing on the gameplay.
* **Progress Notification**: This determines the notification text which pops up when the player completes a task for the sideop (ex: Prisoner Extracted \[1/3]).
    * Users can create Custom Notifications by clicking on the 'Custom...' button. For information on creating a Custom Notification, read '[Custom Notifications Guide](https://github.com/Morbidslinky/SOC#custom-notifications-guide)'.

* **Locational Data textboxes**: These textboxes will read sets of coordinates (x, y, z and y-axis rotation) and create a 'box' on the Details Page for the specified coordinate.
  * Read '[SOC QuickMenu Guide](https://github.com/Morbidslinky/SOC#soc-quickmenu-guide)' for how to get in-game coordinates.
  * The user does not need to fill out every Locational Data textbox, only the textboxes for the objects they wish to use in the sideop.
  * **There is no enforced limit on how many coordinate sets can be used in a sideop, although the user should still consider the game limitations when setting coordinates (ex: only 3 heavy vehicles can be reliably spawned into a quest). Additionally, the extra resources used in sideops can strain the game's allocation and cause crashes (ex: spawning 40 prisoners in a sideop). Certain Infinite Heaven features, such as helicopters and walker gears in free roam, may already be using additional resources. As such, a player may encounter game crashes if they have such features enabled when they enter a quest area. The user should be considerate of these limitations when creating their custom sideops.**
  * While the textboxes prompt the user to input {pos={X, Y, Z},rotY=Y-Axis Rotation,}, SOC will accept any 4 numbers as a coordinate set (ex: {pos={1, 2, 3},rotY=4,} and 1 2 3 4 are both valid inputs). If there are less than 4 numbers in a set, the coordinate is auto-filled with 0.00 as the remaining numbers.

Once the user has filled out the required Setup information, and input their desired Locational Data, they can click the "Next >>" button in the bottom-right corner to build the Details Page. The user can return to the Setup Page at any time, without losing any changes.

## Details Page - Creating Details For The Sideop
After clicking "Next >>" button on the Setup Page, SOC will display the Details Page. The Details Page reads the CP Name and Locational Data textboxes from the Setup Page and lists it as editable boxes. Boxes can be added and removed by returning to the Setup Page and editing the setup information.

There are several different types of detail boxes:

* **New Enemies**: These boxes list new enemies (8 total) which can be spawned into the encampment for a Sideop. These boxes will only appear on the Details Page if you have selected a CP Name on the Setup Page.
  * Soldier SubType: Determines the appearance of the sideop's enemies. 
    * In Afghanistan, the user can choose between SOVIET_A and SOVIET_B. SOVIET_A are Soviet soldiers who wear mostly green and tan uniforms, whereas SOVIET_B wears black and blue uniforms. 
    * In Africa, the user can choose between the different Private Forces soldiers, PF_A, PF_B and PF_C. PF_A are CFA Soldiers, PF_B are ZRS Soldiers and PF_C are Rogue Coyote soldiers.
  * Spawn: Determines whether the new soldier will be added to the sideop.
  * Is Target: Determines whether the soldier will be a target objective for the sideop.
  * Balaclava: Determines whether the soldier will wear a balaclava (limit 8 per sideop).
  * Is Zombie: Determines whether the soldier is a parasite-zombie.
  * Sneak Route: Determines the route of the soldier when the CP is not aware of the player's presence.
  * Caution Route: Determines the route of the soldier when the encampment is on alert.
    * *note* The listed routes have undescriptive names (ex: rt_powerPlant_d_0000). Unfortunately, the user cannot yet preview the routes without checking them in-game. For more information on routes, read '[Enemy Routes Guide](https://github.com/Morbidslinky/SOC#enemy-routes-guide)'.
    * Multiple soldiers can share the same route. They will patrol together during the sideop.
  * Gear | Tactics: Determines what equipment the soldier will wear, as well as their combat preparedness (ex: enemies with MG will have machine guns equiped, and enemies with FULTON_SPECIAL will shoot at fulton balloons). 
  * Heavy Armor: Determines whether the soldier is wearing riot gear (limit 8 per sideop).
    * Riot Gear soldiers cannot also wear balaclavas or different Body appearances.
  * Body: Determines the appearance of the soldier.
    * Body names marked with 'unq' are unique outfits, such as the soldiers with berets or special uniforms. Check out Infinite Heaven's appearance notes on the body names by opening the MGS_TPP directory with Infinite Heaven installed, then navigating to \mod\modules\InfBodyInfo.lua.
  * Staff Type: Determines the Mother Base team that the soldier will be best suited for.
  * Skill: Determines the soldier's unique skill.

* **Existing Enemies**: Enemies that are already patrolling the encampments can be retooled for sideops, in the same ways that New Enemies can be spawned.
  * Customize: Customizing an existing soldier will allow the user to retool the selected soldier for the sideop. The soldier will otherwise follow their normal routes with their default attributes.

* **Prisoners**: Prisoner boxes are added by inputting coordinate sets into the Prisoner Locations textbox on the Setup Page. A hostage will be placed at every coordinate set in the textbox.
  * Body: Determines the body type and gender for all prisoners.
  * Interrogate For Whereabouts: Determines whether the player can interrogate an enemy soldier for the whereabouts of the prisoner(s).
  * Coordinates: Determines the X, Y, Z coordinates of the prisoner.
  * Rotation: Determines the direction that the prisoner will be facing. The rotation is in degrees.
  * Is Target: Determines whether the prisoner is a target objective.
  * Untied: Determines whether the prisoner is untied and sitting upright.
  * Injured: Restricts the player from fultoning the prisoner.
  * Scared: Determines how the prisoner will act. ALWAYS scared prisoners will always be shaking and snivelling after being untied, whereas NEVER scared prisoners will remain sitting upright even during gunfights.
  * Language: Determines the language that the hostage will speak.
    * Female prisoners can only speak english, however Male prisoners can speak english, russian, pashto, kikongo and afrikaans.
  * Staff Type: Determines the Mother Base team that the prisoner will be best suited for.
  * Skill: Determines the prisoner's unique skill.

* **Heavy Vehicles**: The user can spawn heavy vehicles by inputting coordinate sets into the Vehicle Locations textbox on the Setup Page. Unfortunately, spawned vehicles cannot be entered by the player or enemy soldiers. Note: 
  * Coordinates: Determines the X, Y, Z coordinates of the vehicle.
  * Rotation: Determines the direction that the vehicle will be facing. The rotation is in degrees.
  * Is Target: Determines whether the vehicle is a target objective.
  * Vehicle: Determines what type of vehicle will spawn.
  * Class: Determines the color and health of the spawned vehicle.

* **Animals**: Animal boxes are added by inputting coordinate sets into the Animal Cluster Locations textbox on the Setup Page. A cluster of animals will be placed at every coordinate set in the textbox.
  * Coordinates: Determines the X, Y, Z coordinates of the animal cluster.
  * Rotation: Determines the direction that the animal cluster will be facing. The rotation is in degrees.
  * Animal: Determines the type of animal cluster that will spawn at the coordinates.
  * Count: Determines the number of animals which will spawn at the coordinates.
  * Is Target: Determines whether one of the animals in the cluster is a target objective.
  * Type ID: Gives the animal cluster a specified type ID, to avoid conflicting with existing animals near the sideop.
    * Generally, the user should use TppNubian/TppJackal type IDs in Afghanistan, and TppGoat/TppWolf IDs in Africa to avoid conflicting with the preexisting animals and their animal IDs. **A conflict will result in missing animals and game crashes, so it is very important to assign the proper animal ID. The user should be certain of any animals that spawn within the quest area and spawn animals accordingly.**

* **Dormant Items**: Dormant Items are items like guns, ammunition and innactive support weapons which the player can pick up and use during gameplay. The user can spawn dormant items by inputting coordinate sets into the Item Locations textbox on the Setup Page.
  * Coordinates: Determines the X, Y, Z coordinates of the item.
  * Rotation: Determines 3D space rotation of the item. The rotation is in [Quaternion format](http://www.opengl-tutorial.org/intermediate-tutorials/tutorial-17-quaternions/).
  * Item: Determines what item will spawn at the coordinates.
    * Items with \_WP_ in their name are guns, \_SWP_ are support weapons, \_IT_ are items, \_AB_ are ammo boxes.
    * While most of the items on the list should work properly, some items may be bugged due to game limitations.
    * The items have undescriptive names. The user can check Tex's notes on the item names by opening the MGS_TPP directory with Infinite Heaven installed, then navigating to \mod\modules\InfEquip.lua.
  * Count: Determines the number of uses for items/support weapons. Guns are unaffected by the Count.
  * Boxed: Determines whether the item is contained in a weapon crate, similar to the Honey Bee mission.

* **Active Items**: Active Items, unlike dormant items, are already placed and armed prior to the player picking them up. Traps such as Directional Mines, Shock Decoys and Sleep Mines are Active Items. The player will earn heroism for disarming an Active Item. The user can spawn active items by inputting coordinate sets into the Active Item Locations textbox on the Setup Page. (Note: Active Items cannot be placed in a sideop if dormant items exist, and vice versa.)
  * Coordinates: Determines the X, Y, Z coordinates of the active item.
  * Rotation: Determines 3D space rotation of the item. The rotation is in [Quaternion format](http://www.opengl-tutorial.org/intermediate-tutorials/tutorial-17-quaternions/).
  * Active Item: Determines what active item will spawn at the coordinates.

* **Static Models**: Static models can be placed and used for both aesthetic and gameplay purposes, such as a wrecked helicopter or a barbed fence. The user can spawn models by inputting coordinate sets into the Static Model Locations textbox on the Setup Page.
  * Coordinates: Determines the X, Y, Z coordinates of the model.
  * Rotation: Determines 3D space rotation of the model. The rotation is in [Quaternion format](http://www.opengl-tutorial.org/intermediate-tutorials/tutorial-17-quaternions/).
  * Model: Determines what model will spawn at the coordinates.
    * a number of preset models are included with SOC by default. The user can add new models to the Model list by going to the SOC directory and navigating to assets\ModelAssets\, where they can add .fmdl and .geom files from the game. The .geom file is not required, but recommended.
    * a number of models will spawn above or below the origin of their coordinate. The user will need to compensate by manually adjusting the Y coordinate.
    
When the user has input all of their desired changes to the Details Page, they can click the "Build" button in the bottom right to build the sideop, or "<< Back" to review the Setup Page before continuing.

## Building A Sideop - Adding the Sideop To The Game
Once the Setup and Details Pages are completed and the user is ready to test the sideop in-game. It is recommended that the user save the sideop to an Xml file prior to closing SOC.

1. Click the "Build" button on the Details Page to create a "Sideop_Build" folder which contains the mod files, ready to be packed for Makebite.
2. Open Makebite, and click the ellipses button in the top-right corner.
3. Navigate to the Sideop_Build folder and select it, then Click "Select Folder".
  * If the folder was selected properly, a number of filepaths should appear in the Makebite Mod Files. The filepaths should begin with /Assets/ (except one, which begins with /GameDir/).
4. Fill out the Makebite Mod Information.
5. Click the "Do it (build archive)" button in the bottom-right corner and name the file.
  * This will build the .MGSV file, which can be installed via SnakeBite.
6. Install the sideop .mgsv file, as well as Infinite Heaven if it isn't already installed.
7. Start the game and open the Infinite Heaven ACC Main menu.
8. In the ACC menu, open "10:Side ops menu" and in that menu, find "2:Open Specific Sideop".
  * By default, the number begins with 0. The user can loop to the last Sideop on the list by dropping below 0.
9. Select the new sideop. 
  * Without any other sideops installed, the new sideop should be #162 or #161.
  
The user can now test the sideop and make adjustments as necessary by loading the sideop's xml file back into SOC.
## Saving And Loading Sideops With SOC
SOC can save sideops to an xml file, and also load the sideop xml file at any point during the sideop's creation process.

* To save a sideop, click the "Save To Xml..." button at the bottom-left corner of the application. Name the Xml and click Save.
* To load a sideop, click the "Load From Xml.." button at the Bottom-left corner. Select the Xml and click Open.
  * Six example sideops are included by defaul with SOC. The user can load these examples from the Example Sideops folder, inside Helpful User Resources. Each example can be built and tested ingame, to help the user better understand SOC and it's capabilities.
## SOC QuickMenu Guide
In the SOC directory, a folder named "Helpful User Resources" contains a .mgsv file named "_SOC QuickMenu For Infinite Heaven.mgsv_". This QuickMenu preset is immensely useful for gathering in-game information for custom sideops. The user must have Infinite Heaven r223+ installed in order to utilize the QuickMenu.

SOC QuickMenu maps a number of useful hotkey functions to the keyboard/gamepad, so the user does not need to navigate the Infinite Heaven menu to get sideop information.

The hotkeys are mapped as followed:

* While holding down the **[Call]** button:
  * Press the **[Action]** Button to **toggle Free Cam**.
    * Free Cam can be nice for getting into tight or precise places where the player normally could not. The Free Cam speed can be controlled by holding down the [Action] button and moving forward/backward. The camera can be moved up and down with the [Camera Zoom] and [Sprint] buttons, respectively.
  * Press the **[Crouch]** Button to **write the player's position to ih_log.txt**. If Free Cam is active, the Free Cam position will be written to ih_log.txt instead.
    * This will write the player's current coordinate set to Infinite Heaven's ih_log, located in \MGS_TPP\mod\ih_log.txt. These coordinates are the key to placing prisoners, items, static models and other side op objects. Once written to ih_log, these coordinates can be easily copy/pasted into SOC's Locational Data textboxes.
    * Additionally, the **Quest Area** of the player's position will be written to ih_log.txt. 
    * Certain areas of the map are not covered by the Quest Areas. In that event, this hotkey will notify the user if the coordinates are not suitable for a sideop. (Free Cam cannot notify the user of sideop suitability.)
    * When gathering coordinate sets with the Free Cam, note that the camera must be as close as possible to the surface of the ground/object. Otherwise, the sideop object may noticably float above the surface in-game.
  * Press the **[Reload]** or **[Dive]** Buttons to **warp the player to the most-recent iDroid marker**. If Free Cam is active, the player will **warp to the Free Cam position**.
    * Useful for jumping between locations in the encampment. Warping can also teleport the player to distant encampments (occasionally results in falling through the map, but mostly reliable).
  * Press the **[Up]** Button to **mark all soldiers AND set all soldiers to Friendly**.
    * Particularly useful for observing soldier routes and gathering locational information in an outpost.
  * If a marker is placed on an enemy, press **[Down]** to **show the enemy name and the closest CP name**.
    * This hotkey is useful for finding the correct CP Name for the Setup Page, as well as recording the soldier routes.
  * Press the **[Left]** Button to **toggle the enemy phase between Sneak and Caution**.
    * This will help the user observe and test the \_d_ and \_c_ routes of the outpost's soldiers.
  * Press the **[Right]** Button to **speed up the world timescale for a moment**. During this time, soldiers will move very quickly along their routes.
    * When determining which routes to use, watching how and where the soldier patrols move is vital. Speeding up the world timescale will allow the user to learn about patrols much faster than watching in real-time.

## Custom Notifications Guide
When choosing a sideop's progress notification, the user can choose from 9 default notifications. Additionally, the user can create new notifications by clicking the "Custom..." button beside the Progress Notification form. Custom notifications are saved to UpdateNotifsList.txt within SOC's assets folder.

* Upon clicking "Custom...", the user is prompted to input a Unique LangId and an In-game Notification.
  * The Unique LangId is a unique Id referenced by the game files, so the user should choose an appropriate name (ex: example_notif, quest_extract_vip, assassinate_notification)
  * The In-game Notification is the text that the player see in-game, upon completing a sideop task. The user can write any notification that will fit their sideop the best (ex: Example Sideop Notification, VIP Extracted, Commander Eliminated)
  
## Enemy Routes Guide
Currently, route information is still being researched by [Sai/youarebritish](https://github.com/youarebritish), so (for now) new routes cannot be created and old routes can only be previewed in-game.
For a given route name (ex: rt_powerPlant_d_0000):
 * Routes with \_d_ in their names are the encampment's **daytime routes**. These routes are typically more patrol-oriented, so the user is more likely to find patrol routes by assigning soldiers to \_d_ routes.
 * Routes with \_n_ in their names are the encampment's **nighttime routes**. Nighttime routes tend to be more stationary than their daytime counterparts, with occasional patrol routes.
 * Routes with \_snp_ in their names are **sniper routes**. Soldiers assigned to sniper routes will stand in place as they sweep the landscape with their gun at the ready. Assigning soldiers with the 'SNIPER' gear is recommended for these routes, but not required.
 * Routes with \_c_ in their name are the encampment's **caution routes**. Soldiers with these routes will walk cautiously with their guns at the ready.
   * \_c_ routes can be used as a soldier's Sneak Route, although the soldier will still patrol as if they are on alert. \_d_ and \_n_ routes can be used as a soldier's Caution Route, but the soldier will still act alert as they patrol.
 * Routes with \_h_ in their name are **hold routes**. Soldiers with hold routes will stand in place, alert as they wait for the player.
 * Routes with \_s_ in their name are **sleep routes**. Soldiers assigned to a sleep route as their Sneak Route will lay in bed sleeping until disturbed by the player. 
   * If the soldier has a sleep route assigned as their Caution Route, they will stand over their bed and hold their gun at the ready (similar to \_h_ routes).
 
A few outpost routes have been roughly documented in Afghanistan_CP_Reference.lua and CentralAfrica_CP_Reference.lua in the Helpful User Resources folder, but the user will need to learn the routes in-game if they wish to have precise patrols for their sideops (although sideops with randomly assigned routes work well enough). These are some tips for gathering route information:
* Build a sideop with each soldier assigned to a unique route, the QuickMenu [Down] hotkey will notify the user of the soldier's name. The user can then match the route by the name of the soldier, and take note of how they patrol.
* Use the QuickMenu [Up] hotkey to mark all enemies and set them to Friendly. The user will be able to survey routes easier without interference or having to hunt down every soldier.
* Using the QuickMenu [Right] hotkey will speed up the world timescale, causing soldiers to move along their routes at high speeds. This hotkey will allow the user to quickly learn about where the soldier routes travel.
* Using the QuickMenu [Left] hotkey will toggle the soldiers between their \_d_ routes and their \_c_ routes. This will allow users to document the soldier's \_c_ routes more easily.
