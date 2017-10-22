using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event_Mover : MonoBehaviour
{
    public GameObject targetLocationToHit;

    private Base_System powerCore;

    private float eventMoveSpeed;

    Rigidbody rigidBody;

    private Shield_System shield_System;

    private Event_Spawner event_Spawner;

    //Pre-Initialisation
    private void Awake()
    {
        eventMoveSpeed = 4.0f;

        this.gameObject.AddComponent<Rigidbody>();
    }

    //Main-Initialisation
    private void Start()
    {

        //Get the rigidBody Component
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;

        powerCore = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();

        targetLocationToHit = GameObject.FindGameObjectWithTag("ShipHitLocation");

        //FIND OBJECTS BY TAGS?
        event_Spawner = this.transform.parent.GetComponent<Event_Spawner>();

        switch (event_Spawner.currentEventDirection)
        {
            case Event_.EventDirection.TOP:
                shield_System = GameObject.Find("Shield - Top").transform.GetChild(0).GetComponent<Shield_System>();
                //Debug.Log("Found the top Shield component");
                break;
            case Event_.EventDirection.LEFT:
                shield_System = GameObject.Find("Shield - Left").transform.GetChild(0).GetComponent<Shield_System>();
                //Debug.Log("Found the left Shield component");
                break;
            case Event_.EventDirection.RIGHT:
                shield_System = GameObject.Find("Shield - Right").transform.GetChild(0).GetComponent<Shield_System>();
                //Debug.Log("Found the right Shield component");
                break;
            case Event_.EventDirection.BOTTOM:
                shield_System = GameObject.Find("Shield - Bottom").transform.GetChild(0).GetComponent<Shield_System>();
                //Debug.Log("Found the bottom Shield component");
                break;
            default:
                break;
        }
        

    }


    //Physics
    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetLocationToHit.transform.position, eventMoveSpeed * Time.fixedDeltaTime);
        //rigidBody.MovePosition(rigidBody.position + (powerCore.transform.position - transform.position) * Time.fixedDeltaTime);
    }

    //User Input || !Physics
    private void Update()
    {

    }

    //Animations || !Important
    private void LateUpdate()
    {

    }

    private void OnCollisionEnter(Collision colObj)
    {
        DealDamageToShip();

        Destroy(this.gameObject);
    }

    private void DealDamageToShip()
    { 
               
        //Current Shield system that it is connected to is NOT active
        if (!shield_System.currentSystem.IsActive)
        {
            //Full Damage
            Debug.Log("<color=orange>Full Damage</color>");
            powerCore.ShipHealth -= shield_System.usageAmount;
            Debug.Log("Details: " + event_Spawner.currentEventDirection + " : " + shield_System.currentSystem.Direction);


        }
        else
        {
            //Partial Damage
            Debug.Log("<color=yellow>Partial Damage</color>");
            powerCore.ShipHealth -= Mathf.Abs(shield_System.usageAmount - shield_System.reductionAmount);
        }
        
         
    }


}

