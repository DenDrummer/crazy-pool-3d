# Level Design Guidelines
This file contains the guidelines in what to aim for in a level.

## Files
Besides the usual scene file in the "Scenes/Levels/", we're also going to need a corresponding resource file in "Resources/Levels" using the "Code/Main Game/Resources/Gamescene.cs".
Add the PackedScene to this resource file, give it a unique name.
You can optionally give it some tags to later search levels by tags, once that feature gets implemented.

These resource files are what will be used to load the actual levels.

## The scene
The main goal should always be making a fun level/hole.
A typical level should have a par ranging from 2 to 5, but for larger maps a larger par is acceptable as long as it's within a realistic range.  
The **absolute** maximum for a par is 255, since we're using a C# byte to store it.  
Larger maps should be the exception however, not the rule, so we ask to not go beyond par 10.

The level should also have proper out of bounds set up.

Finally, keep in mind that not everyone has an equally powerful machine.  
Because of this we ask that you keep things simple.  
That includes visuals, moving objects, size and complexity of the map, etc.

### Requirements
Some things are absolutely required for the level to work.  
Below you can find a short summary:
- 1 and only 1 ball spawner
- 1 and only 1 functioning hole
- par of 255 or less

### Recommendations
The requirements alone do not make a fun level.
Here's our recommendations for a fun level.
- par of 2 to 5, or up to 10 at most
- proper Out Of Bounds (OOB) areas:
	- just like real mini golf, hitting the ball OOB should be ok as long as it lands back inside the bounds of the track, so place OOB areas accordingly.
	- Currently only hard OOB areas are in the works, meaning the ball will immediately be eliminated upon entry.
- not too difficult
- consistent theming/decoration through your level
- make it visually clear what is part of the track and what is not
- don't overuse alternative routes
- get some inspiration from real life mini golf/crazy golf, real life crazy pool, and other mini golf games (might not want to blindly copy tracks however)

There's also some recommendations that depend on certain features being implemented:
- only minor use of track effects (track effects not implemented)
- make any track effects make sense at a glance, don't hide them (track effects not implemented)
- When the ball can travel through an OOB area for any valid reason, use a soft OOB area, which will only eliminate if it comes to a standstill inside it. (soft OOB areas not implemented)

### Theming
Any theme/setting is allowed, especially for User Generated Content\*, but it's highly recommended to tag levels accordingly.  
This will make it possible to make themed lobbies once tag filtering is enabled.  
*\*: UGC is currently not implemented, but there are plans to make this possible at some point.*

Themes with triggering elements will however not be allowed to be part of the official game, but we have no plans to control what happens with UGC **as long as it's properly tagged**.

Triggering elements include but are not limited to:
- Horror
- Flickering lights
- Sexual Themes
- ...

### Track Effects & Powerups
This still needs to be thought through properly, but as long as it adds to the fun without adding excessive overhead, it would probably be greenlit.

Whether a specific effect gets implemented or not depends partially on demand of said feature and the difficulty of implementing it.

#### Track Effects
These effect areas and effect surfaces are 
Some example effects could be:
- boosters that boost the ball in a direction while in contact (could also be used for conveyor belts?)
- "fans" that push the balls in a direction while in its area of effect (could be chained to make pipes)
- low friction surfaces (soap, ice, etc.)
- high friction surfaces
- altered gravity areas (including gravity direction?)
- fluids (e.g. water)
- death zones (e.g. lava, pit traps, etc.)
- "cannons" (similar to boosters and fans, but instead of applying a force, they set the speed and direction regardless of incoming direction and speed)
- ...

#### Powerups / Ball Effects
This should definitely be an option players can toggle on or off before starting a game, but as this is a more advanced feature, this won't be implemented for a while, if at all.  
If it is implemented partially depends on whether the players would want this, but likely the answer will be yes.

This is not set in stone, but the current idea is to use a system where you have a limited amount of powerup inventory slots (1 to 3? perhaps configurable?) and decide before hitting the ball to activate a powerup for 1 turn.

Some example ball effects could be:
- heavy
- light
- bouncy
- unbouncy
- low friction
- high friction
- ...
