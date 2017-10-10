using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerPickup : MonoBehaviour {

    // Distance of pickup
    public float pickUpDistance;
    //In hands variable
    private GameObject inHands = null;
    public XboxController Controlers;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // XBOX control
		if (XCI.GetButtonDown(XboxButton.A, Controlers))
        {
            if (inHands == null)
            {
                //Local Raycast variable
                RaycastHit info;
                //Layermask set to Cap
                int layermask = 1 << LayerMask.NameToLayer("Cap");

                
                if (Physics.Raycast(transform.position + Vector3.up * 0.5f, transform.forward, out info, pickUpDistance, layermask))
                {
                    // Capsule ingame
                    GameObject obj = info.collider.gameObject;

                    // Set capsule infront of player
                    obj.transform.parent = transform.transform;
                    obj.transform.localPosition = new Vector3(0, 50, 80.0f);
                    obj.transform.localRotation = Quaternion.Euler(0, 90.0f, 0f);
                    //Gets the rigidbody of capsule and sets Kenetic on and velocity off
                    Rigidbody cap = obj.GetComponent<Rigidbody>();
                    Destroy(cap);

                    
                    //obj.transform.localRotation = Quaternion.identity;
                    inHands = obj;
                    return;
                }

                layermask = 1 << LayerMask.NameToLayer("Junction");
                if (Physics.Raycast(transform.position + Vector3.up * 0.25f, transform.forward, out info, pickUpDistance, layermask))
                {
                    GameObject obj = info.collider.gameObject;
                    Junctions CurrentJunction = obj.GetComponent<Junctions>();
                    CurrentJunction.ToggleJunction();
                }
            }
            else
            {
                

                RaycastHit info;
                int layermask = 1 << LayerMask.NameToLayer("Holder");
                if (Physics.Raycast(transform.position + Vector3.up * 0.25f, transform.forward, out info, pickUpDistance, layermask))
                {
                    GameObject holder = info.collider.gameObject;
                    inHands.transform.parent = null;
                    holder.BroadcastMessage("giveCanister", inHands, SendMessageOptions.DontRequireReceiver);
                    inHands = null;
                }
                else
                {

                    inHands.transform.parent = null;
                    inHands.AddComponent<Rigidbody>();
                    inHands = null;
                }
            }
        }
	}

}
