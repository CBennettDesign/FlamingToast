using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class Movement : MonoBehaviour {


    private Animator playerAnimator;
 


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

    private void Awake()
	{
        playerAnimator = GetComponent<Animator>();

 


        //Get a copy of the movement speed value
        defaultSpeed = movementSpeed;

        //No capsule collider
        if (this.gameObject.GetComponent<CapsuleCollider>() == null)
        {
            this.gameObject.AddComponent<CapsuleCollider>();
        }

        //Get the rigidBody Component
        rigidBody = GetComponent<Rigidbody>();
        //Set the constaints - anyways
        rigidBody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
    }

    private void FixedUpdate ()
	{
        //Left Stick input
		inputDirection = new Vector3(XCI.GetAxisRaw(XboxAxis.LeftStickX, controller), 0, XCI.GetAxisRaw(XboxAxis.LeftStickY, controller));

        

        if (inputDirection != Vector3.zero)
        {
            //Vector between the end from the start. targetDestination from the current position
            vecBetween = inputDirection;
            //Get the rotation from the vecBetween the above two points
            targetRotation = Quaternion.LookRotation(vecBetween);
            //Lerp the rotation from its current rotation to its new rotation
            rigidBody.rotation = Quaternion.Slerp(rigidBody.rotation, targetRotation,  movementSpeed * Time.fixedDeltaTime);
        }

        //Velocity of the player.
        Vector3 velocity = inputDirection * movementSpeed * Time.fixedDeltaTime;
        //playerAnimator.speed = velocity.magnitude * 8.0f;



        //
        playerAnimator.SetFloat("Speed", velocity.magnitude);
        //if (velocity.magnitude > 0.08f)
        //{
        //    playerAnimator.speed = velocity.magnitude * 8.0f;
        //}
        //else if (velocity.magnitude < 0.08f && velocity.magnitude > 0.01f)
        //{
        //    playerAnimator.speed = velocity.magnitude * 17.0f;
        //}
        //else if (velocity.magnitude <= 0.01f)
        //{
        //    playerAnimator.speed = 0.0f;
        //}


        //Moves the player towards the inputDirection, multiplied by the speed and smoothed with Time.fixedDeltaTime.
        rigidBody.MovePosition(rigidBody.position + velocity);

        //Debug.Log("Velocity: " + velocity * 1.0f);

        //While the debug sphere is attached to the player.
        if (inputDebugSphere != null)
        {
            //Displays the current input from the contoller
            inputDebugSphere.transform.position = rigidBody.position + inputDirection * 1.5f;	
        }

        //Remove velocity and angularVelocity
        rigidBody.velocity = Vector3.zero;
        rigidBody.angularVelocity = Vector3.zero;
    }

 
}

        

 