using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSnap : BaseCanisterSnapper {


    //Door set 1
    public GameObject doorSet1;

    [HideInInspector]
    public Event_System_Manager evm;

    //Distance to pickup    
    public float pickUpDistance = 0.5f;

    //Snapping positions x, y, z
    public float xPosition;
    public float yPosition = 0.28f;
    public float zPosition;

    //Radius of sphere cast
    public float RadiusOfRayCast = 2;


    // Use this for initialization
    void Start()
    {
        evm = GameObject.FindGameObjectWithTag("Event_System_Manager").GetComponent<Event_System_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug to show cast line
        Debug.DrawLine(transform.position, transform.position + Vector3.forward * RadiusOfRayCast);
        Debug.DrawLine(transform.position, transform.position + Vector3.back * RadiusOfRayCast);
        Debug.DrawLine(transform.position, transform.position + Vector3.left * RadiusOfRayCast);
        Debug.DrawLine(transform.position, transform.position + Vector3.right * RadiusOfRayCast);
        Debug.DrawLine(transform.position, transform.position + Vector3.forward * RadiusOfRayCast);
    }

    public override bool giveCanister(GameObject GiveCanister)
    {

        //sets position to parents position
        GiveCanister.transform.parent = transform.transform;

        //Opens all doors at on enter of the frist green canister.
        doorSet1.SetActive(false);

        //Turns on PowerIllumination script when green canister is inserted.
        this.transform.GetComponent<PowercoreIllumination>().enabled = true;

        //Sets to public local positions
        GiveCanister.transform.localPosition = new Vector3(-xPosition, yPosition, -zPosition);
        GiveCanister.transform.localRotation = Quaternion.identity;// transform.parent.rotation;

        //Prevent core canister from being pick up after entry
        Rigidbody cap = GiveCanister.GetComponent<Rigidbody>();
        Destroy(cap);
        GiveCanister.layer = 0;

        evm.RunEvents = true;

        
        //this.gameObject is RayCast_Canister
        transform.parent.gameObject.GetComponent<Renderer>().material.SetFloat("_FlashSwitch", 0.0f);
        transform.GetChild(0).gameObject.GetComponent<Renderer>().material.SetFloat("_FlashSwitch", 0.0f);

        return true;
    }
}
