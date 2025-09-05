# Goals
The overall goal is to make a fun multiplayer minigolf game, but instead of using golf clubs, you'd be using the a pool cue.  
This also means that the controls would be more akin to those of pool or billiards video games.

## Main Milestones
TLDR the goals we want to reach for specific points in development.  
A roadmap if you will.

### Minimum Viable Product
For the MVP, the goal is to have a main menu and at least 1 level.  
The main menu should have a "random"\* level mode and a quit button.  
Only singleplayer mode is required for this milestone.  
The level just needs to be functional.  
Control wise, only aiming the camera and hitting the ball at a preset strength in the middle will do.  
Concerning the visuals... programmer art will do for now.

*\* since there will probably only be 1 level, can you really call it random?*

### V1
A small number of simple levels/holes, probably 9 since that's half a standard minigolf course.  
Controlling strength of hitting the ball should be implemented at this point.
Visuals should have had a slight upgrade to be more than just the default settings and programmer art.
The MVP level(s) will probably have to be redone from scratch using better assets.
make the random level button actually random.

## Special Milestones
These milestones are separate from the main milestones.  
They will almost certainly be released together with main milestones, but haven't been pinned on when they'll be released yet.  
The main reason is that we don't know enough yet to say how easy or difficult this'll be for us, and thus have no clue how long it'll take us.  
We are aware that these kind of things will likely also get more complex the longer we wait with implementing them.

### Multiplayer
Things to consider will be how we'll handle multiplayer.  
A likely solution is that we'll be using the default Godot multiplayer functionality.  
If that doesn't satisfy our needs however, an alternative solution will have to be found.

Things we'll definitely need is a username system, even if it's a system where you pick your username each time you connect to a game.  
Later we can look into using accounts

### Accounts
For now, we don't need accounts, but if we want leaderboards, rating systems, etc. this becomes a requirement.  
This also means there will need to be an official server.

### User Generated Content
For the longevity of the game, this is certainly something we're aiming for.  
However, this won't be for the near future, as UGC without a working game is kind of pointless.

If an official place for sharing this content is made, a reporting feature for UGC will probably be required.  
Such an official hub would likely also require the use of an account system.

### Rating system
If possible, we'd also want to provide a rating system where people can rate levels and campaigns on various aspects.  
This is mostly aimed at UGC, but it's not impossible that UGC may make it into the official game, so the official maps will also benefit from this.  
This feature will however depend on some kind of user system to prevent abuse of the system as much as possible.  

The current idea is that you'd only be able to give a rating after completing a track.  
This can also double as a warning for difficult tracks

Aspects we think could use a rating system are:
- fun
- difficulty
- visuals
- ...

## Levels / Holes
Goals for levels are being outlined in the "Level Design Guidelines.md" file.  
I short, they should prioritize fun.

If certain effects are used, they should be mentioned in the tags, so they can later be filtered out for players that don't like that feature.

### Level Editor
There are no plans in the near future for this, but it's definitely on the table to add at some point if possible.  
Might want to also have some kind of level browser, even if it's a simplified equivalent of what Zeepkist has.

## Campaigns
These are intended to be an ordered list of levels following a theme and gradually getting more difficult.

### Campaign editor
Just like the Level Editor, there are currently no plans to implement this, but it's on the table as an idea for a later version.  
A prerequisite for this will be a working level browser and/or level search engine.

## Monetization
Building the game from the source code will always be free, but should act as a demo version.

Access to the official levels and campaigns will likely be behind a "pay once have access forever" paywall.  
The price for this may go up over time as more levels and campaigns get added.

If official servers get made, using these will probably be put behind a small subscription to account for costs of maintaining said server.  
Preferably we'll also provide peer-to-peer and/or dedicated server options, which will be free to use as they provide no cost to us.  
It is true that it'd lessen the revenue, but it also lessens the requirements for our own server, and thus its costs.

Preferably no microtransactions, but if there are, then they'll be related to cosmetics.  
There should never be microtransactions that give you a gameplay advantage over "F2P" players.

Multiplayer access will likely also not be available in the demo version.
