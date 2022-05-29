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
- **Reload Config**: You can use this option if you make direct changes to the Config.ini file.

**Double-click ControllerEmu in the task tray to open the Config window.**

# Config
There are a number of buttons you can bind to your keys in this window, it works similar to many MMO's: Click a box which either shows 'None' or the current key bound to it, then press the key you wish to bind to that input. By default, the WASD keys are already bound, but you must also bind a Toggle key for ControllerEmu to work.
- **Toggle A**: Set the primary key that will be used to toggle emulation of controller input.
- **Toggle B** (optional): Set the secondary key that will be used to toggle emulation of controller input.
- **Passthrough**: Determines whether the key bound to each Toggle will pass input through to the process.
- **Audio**: Determines whether audio notification will be played when emulation is enabled/disabled for each Toggle key pressed.
- - The volume of the enabled/disabled audio can be adjusted using the sliders.
- - You can replace the 'toggleon.mp3' and 'toggleoff.mp3' files if you have other sounds you want to use for notification.
- **Process Title** (default: LOST ARK): This determines which process ControllerEmu will check for inputs in, it's a partial match of the window title.

# Notes/Issues

- I'd recommend setting 'Toggle A' to something like 'F1' with 'Passthrough' disabled, and 'Toggle B' set to 'Enter' with 'Passthrough' enabled. This will allow you to enable emulation with 'F1', and then toggle emulation whenever you use the in-game chat.
- The 'Use Gamepad' option in Lost Ark settings must be enabled for ControllerEmu to work.
- - This results in input prompts displaying as controller buttons instead of keyboard keys, you can fix this by unassigning all of the bindings in Gamepad -> Control. You can unassign them by setting them to the same button as another binding.
- - - Assigning button bindings requires a controller, but you can instead temporarily assign a key to a button in ControllerEmu (Like assign 'A' to 'F2') and then use this key to assign the button bindings.
- Only Toggle & WASD keys need to be assigned in ControllerEmu, the rest of the button bindings are provided just in case you find some other use for them.

# todo
I'll get around to adding the below if anyone posts feature request for it.
- Implement capability of casting skills in direction of mouse cursor.
