using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSnap : MonoBehaviour {


    //Door set 1
    public GameObject doorSet1;


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

    public void giveCanister(GameObject GiveCanister)
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

        //creates rigidbody component
        Rigidbody cap = GiveCanister.GetComponent<Rigidbody>();
        Destroy(cap);
    }
}
