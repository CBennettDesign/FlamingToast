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



                GameObject closeHolder = null;
                float maxHolderDistance = 99999f;
                int holderLayerMask = 1 << LayerMask.NameToLayer("Holder");
                Collider[] nearbyHolders = Physics.OverlapSphere(transform.position, pickUpDistance, holderLayerMask);
                for (int i = 0; i < nearbyHolders.Length; i++)
                {
                    Vector3 vecBetween = transform.position - nearbyHolders[i].transform.position;

                    float holderDistance = vecBetween.magnitude;

                    //float holderDistance = Vector3.Distance(transform.position, nearbyHolders[i].transform.position);
                    if (holderDistance < maxHolderDistance)
                    {
                        closeHolder = nearbyHolders[i].gameObject;
                        maxHolderDistance = holderDistance;
                    }
                
                }
                if (closeHolder != null)
                {
                    Debug.Log(closeHolder);
                    if (closeHolder.GetComponentInChildren<CanisterSnapping>() != null)
                    {
                        closeHolder.GetComponentInChildren<CanisterSnapping>().SetCanisterEmpty();
                    }
                }


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

                    closeCannister.GetComponent<Collider>().isTrigger = true;//Alex Edit


                    return;
                }

                // USE JUNCTION
                layermask = 1 << LayerMask.NameToLayer("Junction");

                //Testing for all nearby Junctions within the sphere around the player
                Collider[] nearbyJuction = Physics.OverlapSphere(transform.position, pickUpDistance, layermask);
                GameObject closeJunction = null;
                float closeDistanceJunction = 999999.0f;

                for (int i = 0; i < nearbyJuction.Length; i++)
                {
                    //Raycasting to check there is no walls in the way
                    Vector3 Dir = nearbyJuction[i].transform.position - (transform.position + Vector3.up * 0.5f);
                    Dir.Normalize();

                    if (Physics.Raycast(transform.position + Vector3.up * 0.5f, Dir, out info, pickUpDistance, layermask))
                    {
                        //If the object that is hit is the correct Junction
                        if (nearbyJuction[i].gameObject == info.collider.gameObject)
                        {
                            //todo: check if can be picked up

                            //Checking if it is the closest Junction
                            float distance = Vector3.Distance(transform.position, nearbyJuction[i].transform.position);
                            if (distance < closeDistanceJunction)
                            {
                                closeJunction = nearbyJuction[i].gameObject;
                                closeDistanceJunction = distance;
                            }
                        }
                    }
                }
                //Action to be used when interacting with Junctions
                if (closeJunction)
                {
                    Junctions CurrentJunction = closeJunction.GetComponent<Junctions>();
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
                    if (holder.GetComponentInChildren<FirstSnap>() != null)
                    {
                        holder.GetComponentInChildren<FirstSnap>().giveCanister(inHands);
                    } else if (holder.GetComponentInChildren<CanisterSnapping>() != null)
                    {
                        holder.GetComponentInChildren<CanisterSnapping>().giveCanister(inHands);
                    }
                    //holder.BroadcastMessage("giveCanister", inHands, SendMessageOptions.DontRequireReceiver);
                    inHands = null;
                }
                else //drop
                {
                    inHands.GetComponent<Collider>().isTrigger = false;//Alex Edit
                    inHands.transform.parent = null;
                    inHands.AddComponent<Rigidbody>();
                    inHands = null;
                }

            }
        }
	}
}
