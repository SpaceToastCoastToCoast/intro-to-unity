# intro-to-unity
A basic introduction to the Unity game engine.

##Essentials
Unity is a free game engine designed to be accessible to all age and skill groups. The free Unity Editor works on Windows, Mac and Linux, and comes out of the box with the ability to create games for web (using the Unity Web Player) and for Windows/Mac/Linux. With additional software, it can create games for Android and iOS, and even for smart TVs and commercial game consoles. This course will focus on desktop games.

####Skills
By learning simple game creation in Unity, students will expand their abilities in:

- Spatial knowledge, creating objects in 3D space
- Component-based programming: Each game object has multiple modular components--components which do one job and can be reused on other objects.
- Object-oriented programming: All components in Unity are child classes of a single base Unity component script.
- C# programming: Unity allows user-created scripts in C# and in UnityScript. C# is an object-oriented programming language developed by Microsoft which is used in many of their products for business. Unity provides a means to learn C# in an engaging and entertaining way.

##Getting started

Go to [the Unity downloads page](https://store.unity.com/download?ref=personal) and download the Unity Personal editor which matches your computer's OS.

Create a new project. You don't need to import anything--we will make a project from scratch.

Unity comes with some built-in 3D shapes. We can use these to set up a basic game. These objects start off as plain white: we will learn how to put colors and textures on them in the next lesson.

Once you have the editor open on a new project, create two GameObjects in the scene:

- A quad, scaled to 20x20
- A sphere, left at the default scale

##Your first script

If you are coming from weakly-typed languages like Python or JavaScript, or if this is your first time programming, some things about C# will seem new to you. Your first script will keep these new features to a minimum.

An example starter script is provided in this repository. It is thoroughly commented.

Attach this script to your sphere: this will be your player character for now. The script we create will allow you to control this sphere with your keyboard.

Unity has a built-in module for Input which allows it to handle the same behaviors across multiple input types. The Input module ensures that, whether you prefer to move with the arrow keys, with WASD, or with a gamepad, these inputs are read by your script the same way.

Once your script is attached to your sphere, click the Play button in your editor to bring up the Editor Player. You should now be able to move your sphere around the board.

If you see any error messages: make sure there is a Rigidbody attached to your sphere, and add one using the Add Component button.

###Next steps

If you finish early, try adding some walls or obstacles to your scene.