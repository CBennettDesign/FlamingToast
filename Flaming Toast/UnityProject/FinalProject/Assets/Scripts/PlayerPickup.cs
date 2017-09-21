using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerPickup : MonoBehaviour {

    public float pickUpDistance;
    private GameObject inHands = null;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (XCI.GetButtonDown(XboxButton.B))
        {
            if (inHands == null)
            {
                RaycastHit info;
                int layermask = 1 << LayerMask.NameToLayer("Cap");

                if (Physics.SphereCast(transform.position, 0.5f, transform.forward, out info, pickUpDistance, layermask))
                {
                    GameObject obj = info.collider.gameObject;
                    obj.transform.parent = transform.transform;
                    obj.transform.localPosition = new Vector3(0, 0, 1.0f);
                    Rigidbody cap = obj.GetComponent<Rigidbody>();
                    cap.isKinematic = true;
                    cap.velocity = Vector3.zero;
                    cap.angularVelocity = Vector3.zero;
                    obj.transform.localRotation = Quaternion.identity;
                    inHands = obj;
                }
            }
            else
            {
                inHands.transform.parent = null;
                Rigidbody cap = inHands.GetComponent<Rigidbody>();
                cap.isKinematic = false;
                inHands = null;
                //Drops Capsule on an angle so riged body will take effect
                var rotationVector = cap.transform.rotation.eulerAngles;
                rotationVector.z = 10.0f;
                cap.transform.rotation = Quaternion.Euler(rotationVector);
            }
        }
	}
}
