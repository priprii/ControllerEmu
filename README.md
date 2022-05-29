# ControllerEmu
Emulate controller input using keyboard keys.

This application is intended for use in Lost Ark which does not officially support a method of moving your character with WASD keys, but it should work for games that have similar limitations that support controller input.

Lost Ark supports the use of a controller whereby the character can be moved with the left analog stick. So taking advantage of this, ControllerEmu can be used to bind the WASD keys to emulate the left analog stick on a controller, other button bindings are also made available if needed.

Feel free to support me with a donation [here](https://streamlabs.com/primpri) if this app was of use to you.

# Getting Started
- First download & install [VigEm Bus Driver](https://github.com/ViGEm/ViGEmBus/releases/tag/setup-v1.17.333)
- - This is a driver which enables creation of a virtual controller and emulating input.
- Download ControllerEmu.zip from the releases page [here](https://github.com/priprii/ControllerEmu/releases), extract it after download.
- Start ControllerEmu.exe
- - ControllerEmu will display as an icon in your task tray.

**Right-clicking ControllerEmu in the task tray will bring up a context menu with the following options:**
- **Connect/Disconnect Controller**: Toggle the state of the controller, similar to if you were to physically connect/disconnect a controller to your PC. By default, the virtual controller is connected so you don't need to touch this.
- **Reload Config**: You can use this option if you make direct changes to the Config.ini file, but you probably shouldn't need to.

**Double-click ControllerEmu in the task tray to open the Config window.**

# Config
There are a number of buttons you can bind to your keys in this window, it works similar to many MMO's: Click a box which either shows 'None' or the current key bound to it, then press the key you wish to bind to that input. By default, the WASD keys are already bound, but you must also bind a Toggle key for ControllerEmu to work.
- **Toggle A**: Set the primary key that will be used to toggle emulation of controller input.
- **Toggle B** (optional): Set the secondary key that will be used to toggle emulation of controller input.
- **Passthrough**: Determines whether the key bound to each Toggle will pass input through to any process or if the input should be discarded.
- **Binding Passthrough**: Additional passthrough option at the bottom of the config with similar behaviour to toggle passthrough, but for controller binded keys. This should be enabled if you're using other applications that listen to these key presses (like an input overlay), it may need to be disabled if the game forces the use of the bound keys for other functions.
- **Audio**: Determines whether audio notification will be played when emulation is enabled/disabled for each Toggle key pressed.
- - The volume of the enabled/disabled audio can be adjusted using the sliders.
- - You can replace the 'toggleon.mp3' and 'toggleoff.mp3' files if you have other sounds you want to use for notification.
- **Process Title** (default: LOST ARK): This determines which process ControllerEmu will check for inputs in, it's a partial match of the window title.

# Mouse Direction Skill Bindings
This provides capability of using a skill in the direction of the mouse cursor (relative to character position) rather than using it in the direction that the character is moving/facing.
- Press the 'Update' button and then press the key assigned to a skill in-game that you wish to have used in the direction of the mouse cursor.
- - The pressed key will be added to the list, repeat the process for additional keys.
- - You can remove a key from the list by attempting to assign it a second time.

# Notes

- I'd recommend setting 'Toggle A' to something like 'F1' with 'Passthrough' disabled, and 'Toggle B' set to 'Enter' with 'Passthrough' enabled. This will allow you to enable emulation with 'F1', and then toggle emulation whenever you use the in-game chat.
- You can unbind a key in ControllerEmu by clicking the box for it then pressing the 'Escape' key.
- The 'Use Gamepad' option in Lost Ark settings must be enabled for ControllerEmu to work.
- - This results in input prompts displaying as controller buttons instead of keyboard keys, you can fix this by unassigning all of the bindings in Gamepad -> Control. You can unassign them by setting them to the same button as another binding.
- - - Assigning button bindings requires a controller, but you can instead temporarily assign a key to a button in ControllerEmu (Like assign 'A' to 'F2') and then use this key to assign the button bindings.
- Only Toggle & WASD keys need to be assigned in ControllerEmu, the rest of the button bindings are provided just in case you find some use for them.
