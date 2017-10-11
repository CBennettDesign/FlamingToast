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

                //PICKUP OBJECT 

                //Testing for all nearby canisters within the sphere around the player
                Collider[] nearbyCanisters = Physics.OverlapSphere(transform.position, pickUpDistance, layermask);
                GameObject closeCannister = null;
                float closeDistance = 999999.0f;

                for (int i = 0; i < nearbyCanisters.Length; i++)
                {
                    //Raycasting to check there is no walls in the way
                    Vector3 Dir = nearbyCanisters[i].transform.position - (transform.position + Vector3.up * 0.5f);
                    Dir.Normalize();

                    layermask = 1 << LayerMask.NameToLayer("Holder");
                    layermask = ~layermask;

                    if (Physics.Raycast(transform.position + Vector3.up * 0.5f, Dir, out info, pickUpDistance, layermask))
                    {
                        //If the object that is hit is the correct canister
                        if(nearbyCanisters[i].gameObject == info.collider.gameObject)
                        {
                            //todo: check if can be picked up

                            //Checking if it is the closest canister
                            float distance = Vector3.Distance(transform.position, nearbyCanisters[i].transform.position);
                            if (distance < closeDistance)
                            {
                                closeCannister = nearbyCanisters[i].gameObject;
                                closeDistance = distance;
                            }
                        }
                    }
                }

                //Pick up closest canister
                if (closeCannister)
                {
                    // Set capsule infront of player
                    closeCannister.transform.parent = transform.transform;
                    closeCannister.transform.localPosition = new Vector3(0, .50f, .30f);
                    closeCannister.transform.localRotation = Quaternion.Euler(0, 90.0f, 0f);
                    //Gets the rigidbody of capsule and sets Kenetic on and velocity off
                    Rigidbody cap = closeCannister.GetComponent<Rigidbody>();
                    Destroy(cap);
                    inHands = closeCannister;
                    return;
                }

                // USE JUNCTION
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
                //USE OBJECT ON HOLDER
                RaycastHit info;
                int layermask = 1 << LayerMask.NameToLayer("Holder");
                if (Physics.Raycast(transform.position + Vector3.up * 0.25f, transform.forward, out info, pickUpDistance, layermask))
                {
                    GameObject holder = info.collider.gameObject;
                    inHands.transform.parent = null;
                    holder.BroadcastMessage("giveCanister", inHands, SendMessageOptions.DontRequireReceiver);
                    inHands = null;
                }
                else //drop
                {
                    inHands.transform.parent = null;
                    inHands.AddComponent<Rigidbody>();
                    inHands = null;
                }
            }
        }
	}
}
