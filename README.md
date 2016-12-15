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

Unity comes with some built-in 3D shapes. We can use these to set up a basic game. These objects start off as plain white: we will learn how to put colors and textures on them in a future lesson.

Once you have the editor open on a new project, create two GameObjects in the scene:

- A quad, scaled to 32x32
- A sphere, left at the default scale

You can add GameObjects through the GameObject menu in the Unity editor. Select "3D Object" from the menu and choose these object types from the list.

We will also need to add a component to our sphere. Components are reusable parts that do one job. We will be adding a component called a Rigidbody to our sphere. With your sphere selected, click the Add Component button in the inspector and type "rigidbody", then select the one that says only "Rigidbody". This is a component that we'll learn more about later, but it is what allows us to move and control an object that will have physics applied to it.

##Your first script

If you are coming from weakly-typed languages like Python or JavaScript, or if this is your first time programming, some things about C# will seem new to you. Your first script will keep these new features to a minimum.

An example starter script is provided in this repository. It is thoroughly commented.

All Unity scripts are descended from a base class called "MonoBehaviour". (Notice it is spelled the British way! Your script won't behave properly if you forget the U.) For now, all you need to know about this is that it means each Unity script has some built-in function names that it knows to run at specific times. When you create a new Script through the Unity Editor, it should give you two empty methods to start with: Awake() and Update().

Awake() tells Unity what to do with this object when it first becomes active in the scene. Very large levels might cause some offscreen objects to automatically be put to sleep to save memory, and Awake() will run every time the object becomes active again. This way, you know whatever is set in Awake() will be true as long as the object is active. Awake() is a good place to initialize your variables. Your script will need to be told about any Components attached to your object, like the Rigidbody we attached to our sphere. We tell scripts about components using a method called `GetComponent<Type>()`, where `Type` is the component we want. Use a GetComponent call in your Awake method to tell our script about our Rigidbody.

Update() is what Unity will run once every frame while the game is active. Generally, games run at 60 frames per second, so this gets called about sixty times per second. You should keep Update() as light and small as possible, because it adds up quickly. With Update(), there is a chance it will run more or fewer times than 60 per second, but it is slightly faster. Use Update() for things that don't rely on the physics engine, like a score display.

FixedUpdate() is similar to Update(), but it is guaranteed to run at 60 FPS at the cost of being a little slower and more intensive on the processor. The consistency of FixedUpdate() is what the physics engine in Unity relies on to do accurate calculations. For any object with a Rigidbody or any sort of movement physics to it, it's best to use FixedUpdate(). So, this is the method we will use to control our sphere.

Unity has a built-in module for Input which allows it to handle the same behaviors across multiple input types. The Input module ensures that, whether you prefer to move with the arrow keys, with WASD, or with a gamepad, these inputs are read by your script the same way.

Your job is to write some method in your FixedUpdate() that will read the horizontal and vertical movement data from the player's input, and use those values to move the Rigidbody attached to your sphere. Make sure it moves at a speed that is not too fast to be controlled.

Once your script is attached to your sphere, click the Play button in your editor to bring up the Editor Player. You should now be able to move your sphere around the board.

If you see any error messages: make sure there is a Rigidbody attached to your sphere, and add one using the Add Component button if there is none.

###Next steps

If you finish early, try adding some walls or obstacles to your scene.
