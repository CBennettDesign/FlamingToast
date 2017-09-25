using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class Movement : MonoBehaviour {

	public XboxController controller;

	[Range(2,10)]
	public float movementSpeed;



	private void Start ()
	{
		
	}
	

	private void FixedUpdate ()
	{
		transform.Translate(new Vector3(XCI.GetAxisRaw(XboxAxis.LeftStickX, controller), 0, XCI.GetAxisRaw(XboxAxis.LeftStickY, controller)) * movementSpeed * Time.deltaTime) ;
	}
		
}
