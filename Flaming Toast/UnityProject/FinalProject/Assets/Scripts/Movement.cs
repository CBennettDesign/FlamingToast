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
        //Get the rigidBody Component
		rigidBody = GetComponent<Rigidbody>();
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

	}
}