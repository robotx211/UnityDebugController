A little plugin I wrote to control whether debug features (eg. menus, log messages etc. ) are shown in a unity project.

To use, you need to apply the Debug_Controller script to a single game object in your scene. This script allows you to toggle debug mode on and off, at the click of a button. You can tell if you are in debug mode by the helpful little “Debug Mode” label I the top left of the game view. Debug Mode is automatically set to off when you launch an app.

For any debug menus, add the Debug_Object script to the object/object container. Then the object/objects in the container will only be visible when debug mode is active

For any log messages (eg. Using Debug.Log() or print() ), you can use Debug_Console.Log() to output messages to the console. It works the same as Debug.Log, so you can pass a context object as a parameter too. Console logs called using Debug_Console.Log() will only be output when Debug Mode is enabled.

If you want to, you could set a button in game to toggle debug mode, simply by referencing the Debug_Controller.instance, and calling the setting the IsInDebugMode to true of false. All the debug mode features will be set to on/off automatically, when you set the debug mode using the getter/setter IsInDebugMode.
