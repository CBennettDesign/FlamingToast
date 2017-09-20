using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class Movement : MonoBehaviour {

    public XboxController controls;
    public float moveSpeed = 15f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        Vector3 input = new Vector3(XCI.GetAxisRaw(XboxAxis.LeftStickX, controls), 0 ,XCI.GetAxisRaw(XboxAxis.LeftStickY, controls));
        transform.position += input * moveSpeed * Time.deltaTime;
    }
}
