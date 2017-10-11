using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class CanisterSnapping : MonoBehaviour
{
    //Distance to pickup    
    public float pickUpDistance = 0.5f;
    
    //Snapping positions x, y, z
    public float xPosition;
    public float yPosition = 0.28f;
    public float zPosition;

    //Canister game object
    //GameObject canister = null;

    //Radius of sphere cast
    public float RadiusOfRayCast = 2;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void giveCanister(GameObject GiveCanister)
    {
        //sets position to parents position
        GiveCanister.transform.parent = transform.transform;

       //GiveCanister.BroadcastMessage("CanisterIsSnapped", true, SendMessageOptions.DontRequireReceiver);

        //Sets to public local positions
        GiveCanister.transform.localPosition = new Vector3(-xPosition, yPosition, -zPosition);
        GiveCanister.transform.localRotation = Quaternion.identity;

        //creates rigidbody component
        Rigidbody cap = GiveCanister.GetComponent<Rigidbody>();
        Destroy(cap);

        //canister = GiveCanister;
    }
}
