using UnityEngine;
using System.Collections;

//'using' is Unity's version of 'import' or 'require'.

[RequireComponent (typeof (Rigidbody))]

//RequireComponent forces the object this is attached to to include this component.
//A Rigidbody is the way that Unity integrates game objects with its physics engine.

public class RollingMovement : MonoBehavior {
  //Declare your variables here.

  //Public variables are accessible from the editor.
  //You can assign a default to public variables to use in case the field is left blank.
  public float speed = 4f;
  //The speed represents how many units per second we want our object to move. In Unity, the default unit is meters.

  //Variables not marked as public are hidden from the editor.
  Vector3 movement;
  Rigidbody playerRigidbody;
  float h, v;

  void Awake() {
    //Initialize your variables here.
    playerRigidbody = GetComponent<Rigidbody>();
  }

  void FixedUpdate() {
    //FixedUpdate runs once every frame, and games run at 60 frames per second(fps).
    //Every second, this function is called 60 times. Keep it as short as possible!

    //Get user input here.
    h = Input.GetAxis("Horizontal");
    v = Input.GetAxis("Vertical")
    //Call your movement function here.
    Move(h, v);
  }

  void Move(float h, float v) {
    //Define your logic for moving your character here.
    movement.Set(h, 0f, v);
    //The movement variable describes the change in position this object will undergo.

    movement = movement.normalized;
    //Without normalization, you would move faster diagonally than you would move at right angles. Normalizing makes sure your movement is the same strength in any direction.

    movement = movement * speed;
    //We multiply in our speed variable to determine how fast we want this character to move. Our default will move it 4 units per second.

    movement = movement * Time.deltaTime;
    //Time.deltaTime keeps track of how long it's been between this frame and the last.
    //Since Move is being called from FixedUpdate 60 times every second, we want to multiply it by Time.deltaTime, which should be 1/60th of a second.
    //If we forgot this step, our object would move too fast for us to see or control!

    playerRigidbody.MovePosition(transform.position + movement);
    //Every object has a "transform", which represents its position, rotation and scale in the world.
    //We move the rigidbody to its current position plus the change in position.
    //Moving the rigidbody rather than the object's transform position lets us use other physics forces like gravity on the object later.
  }
}