using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class CanisterSnapping : BaseCanisterSnapper
{
    //Distance to pickup    
    public float pickUpDistance = 0.5f;
    
    //Snapping positions x, y, z
    public float xPosition;
    public float yPosition = 0.28f;
    public float zPosition;

    //Canister game object
    public GameObject canister = null;

    //Radius of sphere cast
    public float RadiusOfRayCast = 2;

    //Bool to keep snapped
    public bool keepSnapped;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
                
    }

    public override bool giveCanister(GameObject GiveCanister)
    {
        if (canister == null)
        {
            //sets position to parents position
            GiveCanister.transform.parent = transform.transform;

            //Sets to public local positions
            GiveCanister.transform.localPosition = new Vector3(-xPosition, yPosition, -zPosition);
            GiveCanister.transform.localRotation = Quaternion.identity;

            //creates rigidbody component
            Rigidbody cap = GiveCanister.GetComponent<Rigidbody>();

            //Destroy(cap);
            canister = GiveCanister;
            //Debug.Log("RETURNED TRUE DID BAD STUFF");
            return true;
        }
        else
        {
            GiveCanister.AddComponent<Rigidbody>();
            GiveCanister.GetComponent<Collider>().isTrigger = false;//Alex Edit
            GiveCanister.transform.parent = null;
            return false;
        }
    }
    //Called in PlayerPickup to run Change
    public void SetCanisterEmpty()
    {
        //Invoke("Change", 0.5f);
        canister = null;
        //Debug.Log("ITS A EMPTY");
    }

    //Delayed function to avoid overwritting null value
    public void Change()
    {
        canister = null;
    }

}
