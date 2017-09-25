using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveSpeed = 15f;

        Vector3 input = new Vector3(XCI.GetAxisRaw(XboxAxis.LeftStickX), 0 ,XCI.GetAxisRaw(XboxAxis.LeftStickY));
        //float targetVelocityX = input.x * moveSpeed;
        transform.position += input * moveSpeed * Time.deltaTime;
    }
}
