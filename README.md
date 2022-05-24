# ControllerEmu
Emulate controller input of left analog stick using WASD keys on a keyboard.

This application is for use in Lost Ark which does not provide a native method of moving your character with WASD keys, it's possible to also use this application for games with similar limitations.

WASD key movement is achieved by emulating controller input of the analog stick, as Lost Ark does support controller input.

Feel free to support me with a donation [here](https://streamlabs.com/primpri) if this app was of use to you.

# Getting Started
- First download & install [VigEm Bus Driver](https://github.com/ViGEm/ViGEmBus/releases/tag/setup-v1.17.333), you may need to reboot after.
- Start ControllerEmu.exe
- - ControllerEmu will display as an icon in your task tray.
- Right-click ControllerEmu in the task tray to bring up a context menu.
- - The **Connect Controller**/**Disconnect Controller** option will toggle the state of the controller, similar to if you were to physically connect/disconnect a controller to your PC.
- The toggle key must first be set before ControllerEmu can do anything, this is explained below in the Config
- After setting the toggle key, you can then press it while the game is active to toggle emulation.

# Config
The **Config** submenu has a few options to configure:
- **Set Toggle Key**: When clicking this, the next key you press will be the key used for toggling controller emulation.
- - You will need to toggle emulation whenever you want to switch between using WASD for movement or things like chat.
- - Note: Emulation is only active while the game is the active window, so you don't have to worry about needing to disable emulation manually when you alt-tab to a different window.
- **Connect on Start**: Toggles whether the emulated controller will be automatically connected when ControllerEmu is started.
- **Play Enabled/Disabled Audio**: Toggles whether an audio notification will play whenever emulation is enabled/disabled as a result of the toggle key being pressed.

There are a few other config options you can configure directly from the Config.ini file, you will need to press the 'Reload Config' menu option when making changes to them:
- **ClientTitle**: This is a partial match of the window title for the process that emulation will be active in, this option is made available in case you want to try using this app for other games.
- **Enabled/DisabledAudioFile**: The file name of the audio file to play when emulation is enabled/disabled, these should be in the same directory as ControllerEmu.exe
- **Enabled/DisabledAudioVolume**: Adjust the audio volume, must be a value from 0 to 1.

# todo
I'll get around to adding the below if anyone posts feature request for it.
- Implement config for setting movement keys instead of hard-coding WASD, for people who may want to use arrow keys or such to move instead.
