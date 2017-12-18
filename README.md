# SOC - SideOp Companion

SideOp Companion is a UI-driven program, designed to help automate the process of creating custom sideops for Metal Gear Solid V: The Phantom Pain with the goal of improving their accessibility. 

## Overview - Custom Sideops For Metal Gear Solid V: The Phantom Pain

Custom Sideops are playable, user-created side-missions which can be added to the game through TinManTex's Infinite Heaven mod. Creating custom sideops manually can be difficult, even for experienced MGSV modders. Without an acute understanding of the game's files, formats and limitations, the user can often find themselves lost and confused.

SOC, or SideOp Companion, is my attempt to automate the process of creating custom sideops. The program alleviates a great deal of the difficult, tedious work involved in creating a custom sideop. Even with minimal understanding of modding, users can create and test their own custom sideops with relative ease. SOC can even create sideops with greater detail than those found in the base game, without even touching the game files. It is perhaps possible that this will make Custom Sideops the simplest and most accessible form of MGSV modding.

## Setup Page - Understanding The SOC Setup Page

Upon opening SOC.exe, the user is met with the Setup Page. This page prompts the user to fill in a number of forms which are required for a custom sideop.

* .FPK Filename: This is what the sideop will be named in the gamefiles. The user should think of a name which will be unique to the sideop.
  * Examples: MorbidQuest00, MorbidQuest01, ih_sheep_quest, ih_pilot_quest, Example_QuestName

* Quest Number: This quest number is how Infinite Heaven adds new sideops to the game. The user should use a unique number between 30103 and 39009.

* Quest Map: The Area of Operations for the sideop. The user can choose to create a sideop for Afghanistan, Central Africa or even Mother Base (with limitations).

* Quest Area: Quest Areas are fractions of the map where a single sideop is available. The user should choose the appropriate area that the sideop will be located within. 
  * Read 'SOC QuickMenu Guide' for information about *how* to get the correct area name.

* Quest CP: This is the name of the enemy Command Post for the sideop. Each enemy encampment in MGSV has a CP which determines the alert status of the encampment's soldiers. SOC will draw enemy-related information from the selected CP, such as route names and pre-existing soldiers in the encampment.
  * Some CP names are rather self-explanitory (ex: afgh_powerPlant_cp refers to the Serak Powerplant in Afghanistan). Other CP names are more confusing (ex: mafr_pfCamp_cp refers to Nova Braga Airport in Central Africa).
  * Read 'SOC QuickMenu Guide' for how to find an encampment's CP name.

* Map Coordinates: X Y Z: These are the ingame coordinates for the center of the side-mission circle that appears on the iDroid. The circle is aesthetic, and does not affect the actual gameplay aside from the pop-up UI which notifies the player upon entering the circle.
  * Read 'SOC QuickMenu Guide' for how to get in-game coordinates.

* Radius: This determines the size of the side-mission circle that appears on the iDroid. The radius of a sideop is likewise aesthetic.

* Quest Category: Categories are only used for selecting which sideops will appear in an Area of Operations. The user can choose whichever category that they feel will fit the sideop best.
  * The sideop does not need to match the category perfectly (ex: using ELIMINATE_HEAVY_INFANTRY for a sideop that involves assassinating a VIP, or using ELIMINATE_PUPPETS for a sideop that involves rescuing zombies).
  
* Quest Rank: this is essentially the GMP reward for completing the mission. The user can choose any rank between 300,000 GMP (S rank) and 30,000 GMP (I rank), as they please.

* Objective Type: This determines whether the sideop targets need to be rescued (RECOVERED) or eliminated (ELIMINATE) by the player in order to complete the sideop.
  * Sideops can technically be given fairly complex and unique win-states, but requires the user to manually edit the sideop's LUA script file.
  
* Quest Title: This is the sideop's name that shows up on the iDroid in-game.
  * The title itself is aesthetic. The flavor text has no affect on the gameplay.
  
* Quest Description: Like with the Quest Title, the Quest Description will appear on the iDroid menu in-game, when you select the sideop on the side-missions list.
  * The description is likewise flavor text, with no bearing on the gameplay.
  
* Progress Notification: This determines the notification text which pops up when the player completes a task for the sideop (ex: Prisoner Extracted \[1/3]).
  * Users can create Custom Notifications by clicking on the 'Custom...' button. For information on creating a Custom Notification, read 'Custom Notifications Guide'.
  

* Locational Data textboxes: These textboxes will read sets of coordinates (x, y, z and y-axis rotation) and create a 'box' on the Details Page for the specified coordinate.
  * Read 'SOC QuickMenu Guide' for how to get in-game coordinates.
  * The user does not need to fill out every Locational Data textbox, only the textboxes for the objects they wish to use in the sideop.
  * There is no enforced limit on how many coordinate sets can be used in a sideop, although the user should still consider the game limitations when setting coordinates (ex: only 3 heavy vehicles can be reliably spawned into a quest).
  * While the textboxes prompt the user to input {pos={X, Y, Z},rotY=Y-Axis Rotation,}, SOC will accept any 4 numbers as a coordinate set (ex: {pos={1, 2, 3},rotY=4,} and 1 2 3 4 are both valid inputs). If there are less than 4 numbers in a set, the coordinate is auto-filled with 0.00 as the remaining numbers.

Once the user has filled out the required Setup information, and input their desired Locational Data, they can click the Next>> button in the bottom-right corner to build the Details Page. The user can return to the Setup Page at any time, without losing any changes.

## Details Page - Creating Details For The Sideop
TBC
## Building A Sideop - Adding the Sideop To The Game
TBC
## Loading And Saving Sideops With SOC
TBC
## SOC QuickMenu Guide
TBC
## Custom Notifications Guide
TBC
