using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerPickup : MonoBehaviour {

    // Distance of pickup
    public float pickUpDistance;
    //In hands variable
    private GameObject inHands = null;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // XBOX control
		if (XCI.GetButtonDown(XboxButton.B))
        {
            if (inHands == null)
            {
                //Local Raycast variable
                RaycastHit info;
                //Layermask set to Cap
                int layermask = 1 << LayerMask.NameToLayer("Cap");

                if (Physics.SphereCast(transform.position, 0.4f, transform.forward, out info, pickUpDistance, layermask))
                {
                    // Capsule ingame
                    GameObject obj = info.collider.gameObject;

                    // Set capsule infront of player
                    obj.transform.parent = transform.transform;
                    obj.transform.localPosition = new Vector3(0, 50, 80.0f);

                    //Gets the rigidbody of capsule and sets Kenetic on and velocity off
                    Rigidbody cap = obj.GetComponent<Rigidbody>();
                    cap.isKinematic = true;
                    cap.velocity = Vector3.zero;

                    //Turns angular velocity off
                    cap.angularVelocity = Vector3.zero;
                    obj.transform.localRotation = Quaternion.identity;
                    inHands = obj;
                }
            }
            else
            {
                inHands.transform.parent = null;
                // Capsule ingame
                Rigidbody cap = inHands.GetComponent<Rigidbody>();
                
                //Sets kenetic off and sets inHands to null
                cap.isKinematic = false;
                inHands = null;

                //SAVE FOR LATER USE

                ////Drops Capsule on an angle so riged body will take effect
                //var rotationVector = cap.transform.rotation.eulerAngles;
                //rotationVector.z = 10.0f;
                //cap.transform.rotation = Quaternion.Euler(rotationVector);
            }
        }
	}
}
