﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSnap : MonoBehaviour {



    public GameObject doorTest;


    //Distance to pickup    
    public float pickUpDistance = 0.5f;

    //Snapping positions x, y, z
    public float xPosition;
    public float yPosition;
    public float zPosition;

    //Inhands object
    private GameObject inHands = null;

    //objectlist to turn on
    public GameObject ParticlesToSwitch = null;

    // Lerp Speed
    public float speed = 0.2f;

    //Lerp Time
    float lerptime;

    //Start and end colors to lerp between
    public Color Startcolor;
    public Color Endcolor;

    //Canister game object
    GameObject canister = null;

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

        if (!canister)
        {

        }
        else
        {
            //Lerping colors when snaped
            lerptime += speed * Time.deltaTime;
            canister.GetComponent<Renderer>().materials[1].color = Color.Lerp(Startcolor, Endcolor, lerptime);
        }
    }

    public void giveCanister(GameObject GiveCanister)
    {

        //sets position to parents position
        GiveCanister.transform.parent = transform.transform;

        // ISSUE HEREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
        doorTest.SetActive(false);

        this.transform.GetComponent<PowercoreIllumination>().enabled = true;

        //Sets to public local positions
        GiveCanister.transform.localPosition = new Vector3(-xPosition, yPosition, -zPosition);
        GiveCanister.transform.localRotation = Quaternion.identity;// transform.parent.rotation;
        //transform.parent.rotation

        //creates rigidbody component
        Rigidbody cap = GiveCanister.GetComponent<Rigidbody>();
        Destroy(cap);

        canister = GiveCanister;
    }
}