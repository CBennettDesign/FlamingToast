using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event_Mover : MonoBehaviour
{


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

        //FIND OBJECTS BY TAGS?
        shield_System = GetComponent<Shield_System>();
        event_Spawner = GetComponent<Event_Spawner>();

    }


    //Physics
    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(1.5f,1.0f, 15.0f), 4.0f * Time.fixedDeltaTime);
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
        //Debug.Log(colObj.gameObject.name);

        //shield_System.SendMessage(colObj.gameObject.name, true, SendMessageOptions.DontRequireReceiver);


        //TakeDamage();

        Destroy(this.gameObject);
    }

    private void TakeDamage()
    {
 
        //powerCore.HealthSlider.value -= 5;

        
        if (shield_System.currentSystem.Direction == Current_System.SystemDirection.TOP && event_Spawner.currentEventDirection == Event_.EventDirection.TOP)
        {
            powerCore.ShipHealth -= (shield_System.usageAmount - shield_System.reductionAmount);
        }
        else
        {
            powerCore.ShipHealth -= shield_System.usageAmount;
        }

        if (shield_System.currentSystem.Direction == Current_System.SystemDirection.LEFT && event_Spawner.currentEventDirection == Event_.EventDirection.LEFT)
        {
            powerCore.ShipHealth -= (shield_System.usageAmount - shield_System.reductionAmount);
        }
        else
        {
            powerCore.ShipHealth -= shield_System.usageAmount;
        }

        if (shield_System.currentSystem.Direction == Current_System.SystemDirection.RIGHT && event_Spawner.currentEventDirection == Event_.EventDirection.RIGHT)
        {
            powerCore.ShipHealth -= (shield_System.usageAmount - shield_System.reductionAmount);
        }
        else
        {
            powerCore.ShipHealth -= shield_System.usageAmount;
        }

        if (shield_System.currentSystem.Direction == Current_System.SystemDirection.BOTTOM && event_Spawner.currentEventDirection == Event_.EventDirection.BOTTOM)
        {
            powerCore.ShipHealth -= (shield_System.usageAmount - shield_System.reductionAmount);
        }
        else
        {
            powerCore.ShipHealth -= shield_System.usageAmount;
        }



    }


}

