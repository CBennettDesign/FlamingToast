using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class Movement : MonoBehaviour {

    //For testing only
    public GameObject inputDebugSphere;
 
    //Player input controller number.
	public XboxController controller;
 
	[Range(0,20)]
	public float movementSpeed;

    //Copy of the movement speed 
    private float defaultSpeed;
    public float DefaultSpeed
    { get { return defaultSpeed; } }

    //Player Physics
	private Rigidbody rigidBody;
    //Contoller input direction
    private Vector3 inputDirection;

    //2 points between the current position and the target position
    private Vector3 vecBetween;
    //Rotation between its current forward to towards its target.
    private Quaternion targetRotation;


    ////Gravity System 
    //private bool gravityDepleted;
    //
    //public bool GravityDepleted
    //{
    //    get { return gravityDepleted; }
    //    set { gravityDepleted = value; }
    //}
    ////Gravity Trigger
    //private bool gravUsed = false;


    private void Awake()
	{
        //Get a copy of the movement speed value
        defaultSpeed = movementSpeed;

        //No capsule collider
        if (this.gameObject.GetComponent<CapsuleCollider>() == null)
        {
            this.gameObject.AddComponent<CapsuleCollider>();
        }

        //If the player object does not have a rigid body component add one
        if (this.gameObject.GetComponent<Rigidbody>() == null)
        {
            //Add the rigid body
            rigidBody = this.gameObject.AddComponent<Rigidbody>();
            //Set the constaints
            rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
        }
        else
        {
            //Get the rigidBody Component
	    	rigidBody = GetComponent<Rigidbody>();
            //Set the constaints - anyways
            rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
        }
	}

	private void FixedUpdate ()
	{
        //Left Stick input
		inputDirection = new Vector3(XCI.GetAxisRaw(XboxAxis.LeftStickX, controller), 0, XCI.GetAxisRaw(XboxAxis.LeftStickY, controller));

        if (inputDirection != Vector3.zero)
        {
            //Vector between the end from the start. targetDestination from the current position
            vecBetween = (rigidBody.position + inputDirection) - rigidBody.position;
            //Get the rotation from the vecBetween the above two points
            targetRotation = Quaternion.LookRotation(vecBetween);
            //Lerp the rotation from its current rotation to its new rotation
            rigidBody.rotation = Quaternion.Slerp(rigidBody.rotation, targetRotation,  movementSpeed * Time.fixedDeltaTime);
        }
        
        //Moves the player towards the inputDirection, multiplied by the speed and smoothed with Time.fixedDeltaTime.
        rigidBody.MovePosition(rigidBody.position + inputDirection * movementSpeed * Time.fixedDeltaTime);


        //While the debug sphere is attached to the player.
        if (inputDebugSphere != null)
        {
            //Displays the current input from the contoller
            inputDebugSphere.transform.position  = rigidBody.position + inputDirection * 1.5f;	
        }

        ////If the gravity has been depleted and the gravUsed has not been used yet. 
        ////This will only run once and then only check the first if statement, instead of
        ////going into the foreach loop and double checking for the null value.
        //if (gravityDepleted && !gravUsed)
        //{
        //    //For every player in the players array
        //    foreach (GameObject p in player)
        //    {
        //        //safe gaurd - double check for null values
        //        if (p != null)
        //        {
        //            //Slow the players by half of their current speed
        //            p.GetComponent<Movement>().movementSpeed -= (p.GetComponent<Movement>().movementSpeed / 2.0f);
        //            Debug.Log("Slowed: " + p.name);
        //        }
        //    }
        //
        //    gravUsed = true;
        //    Debug.Log("Gravity Depleted!!");
        //}

    }
}