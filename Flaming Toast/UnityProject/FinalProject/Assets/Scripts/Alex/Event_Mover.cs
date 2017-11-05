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

    private Weapon_System weapon_System;

    private Event_Spawner event_Spawner;

    private VignetteFlash vignetteFlash;


    private bool isEnemy;

    //Pre-Initialisation
    private void Awake()
    {
        eventMoveSpeed = 4.0f;

        this.gameObject.AddComponent<Rigidbody>();
    }

    //Main-Initialisation
    private void Start()
    {
        vignetteFlash = GameObject.FindGameObjectWithTag("vFlash").GetComponent<VignetteFlash>();
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

                weapon_System = GameObject.FindGameObjectWithTag("wTOP").GetComponent<Weapon_System>();
                //weapon_System = GameObject.Find("Weapon - Top").transform.GetChild(0).GetComponent<Weapon_System>();
                //Debug.Log("Found the top Shield component");
                break;
            case Event_.EventDirection.LEFT:
                shield_System = GameObject.Find("Shield - Left").transform.GetChild(0).GetComponent<Shield_System>();

                weapon_System = GameObject.FindGameObjectWithTag("wLEFT").GetComponent<Weapon_System>();
                //weapon_System = GameObject.Find("Weapon - Left").transform.GetChild(0).GetComponent<Weapon_System>();
                //Debug.Log("Found the left Shield component");
                break;
            case Event_.EventDirection.RIGHT:
                shield_System = GameObject.Find("Shield - Right").transform.GetChild(0).GetComponent<Shield_System>();

                weapon_System = GameObject.FindGameObjectWithTag("wRIGHT").GetComponent<Weapon_System>();
                //weapon_System = GameObject.Find("Weapon - Right").transform.GetChild(0).GetComponent<Weapon_System>();
                //Debug.Log("Found the right Shield component");
                break;
            case Event_.EventDirection.BOTTOM:
                shield_System = GameObject.Find("Shield - Bottom").transform.GetChild(0).GetComponent<Shield_System>();

                weapon_System = GameObject.FindGameObjectWithTag("wBOTTOM").GetComponent<Weapon_System>();
                //weapon_System = GameObject.Find("Weapon - Bottom").transform.GetChild(0).GetComponent<Weapon_System>();
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

  
    private void OnCollisionEnter(Collision colObj)
    {
        DealDamageToShip();

        Destroy(this.gameObject);
    }

    private void DealDamageToShip()
    {
        if (isEnemy)
        {
            /* 3 cases of damage
             * 
             * 1. Full damage - NO shield or weapon ON
             * 2. Half damage - 1 not both of shield or weapon ON
             * 3. Partial / Minimal damage - both shield and weapon ON
             * 
             */

            //Full damage - no system is active
            if (!weapon_System.currentSystem.IsActive && !shield_System.currentSystem.IsActive)
            {
                Debug.Log("<color=orange>Full Damage</color>");
                powerCore.ShipHealth -= transform.parent.parent.GetComponent<Event_System_Manager>().fullDamageValue;

               
                vignetteFlash.ShipHit(true, false);
            }
            //Half damage - one of the systems is active
            else if (weapon_System.currentSystem.IsActive || shield_System.currentSystem.IsActive)
            {
                //Half Damage
                Debug.Log("<color=yellow>Half Damage</color>");
                powerCore.ShipHealth -= transform.parent.parent.GetComponent<Event_System_Manager>().halfDamageValue;

                vignetteFlash.ShipHit(true, true);
            }
            //Minimal damage - Both systems on
            else if (weapon_System.currentSystem.IsActive && shield_System.currentSystem.IsActive)
            {
                //Partial Damage
                Debug.Log("<color=yellow>Minimum Damage</color>");
                powerCore.ShipHealth -= transform.parent.parent.GetComponent<Event_System_Manager>().minimumDamageValue;

                vignetteFlash.ShipHit(true, true);
            }

        }
        else // Asteroid
        {
            //Current Shield system that it is connected to is NOT active
            if (!shield_System.currentSystem.IsActive)
            {
                //Full Damage
                Debug.Log("<color=orange>Full Damage</color>");
                powerCore.ShipHealth -= transform.parent.parent.GetComponent<Event_System_Manager>().fullDamageValue;//shield_System.usageAmount;

                //Debug.Log("Details: " + event_Spawner.currentEventDirection + " : " + shield_System.currentSystem.Direction);

                vignetteFlash.ShipHit(true, false);

            }
            else
            {
                //Partial Damage
                Debug.Log("<color=yellow>Minimum Damage</color>");
                powerCore.ShipHealth -= transform.parent.parent.GetComponent<Event_System_Manager>().minimumDamageValue;//Mathf.Abs(shield_System.usageAmount - shield_System.reductionAmount);

                vignetteFlash.ShipHit(true, true);

            }

        }


    }


    /// <summary>
    /// If returns true then it is an enemy
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    private void IsEnemy(bool type)
    {
        isEnemy = type;     
    }

    
}

