﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class Base_System : MonoBehaviour
{
    public GameObject[] player;

    private bool isPowered = false;
    private bool isCanisterConnected = false;
    private bool isActive = false;

    [SerializeField]
    [Range(0, 5)]
    //[Tooltip("")]
    private float baseDepletionRate;

    [SerializeField]
    [Tooltip("Shield System")]
    [Range(1, 100)]
    private int shield_UsageAmount;


    public bool IsPowered
    {
        get { return isPowered; }
        set { isPowered = value; }
    }

    public bool IsActive
    {
        get { return isActive; }
        set { isActive = value; }
    }

    public bool IsCanisterConnected
    {
        get { return isCanisterConnected; }
        set { isCanisterConnected = value; }
    }

    public float DepletionRate
    {
        get { return baseDepletionRate; }
        set { baseDepletionRate = value; }
    }

    public int Shield_UsageAmount
    {
        get { return shield_UsageAmount; }
        set { shield_UsageAmount = value; }
    }



    //Oxygen System 
    private bool oxygenDepleted;

    public bool OxygenDepleted
    {
        get { return oxygenDepleted; }
        set { oxygenDepleted = value; }
    }
    //Oxygen Trigger
    private bool oxyUsed = false;

    //Gravity System 
    private bool gravityDepleted;

    public bool GravityDepleted
    {
        get { return gravityDepleted; }
        set { gravityDepleted = value; }
    }
    //Gravity Trigger
    private bool gravUsed = false;


    private void Update()
    {
        //If the oxygen has been depleted and the oxyUsed has not been used yet. 
        //This will only run once and then only check the first if statement, instead of
        //going into the foreach loop and double checking for the null value.
        if (oxygenDepleted && !oxyUsed)
        {
            //For every player in the players array
            foreach (GameObject p in player)
            {
                //safe gaurd - double check for null values
                if (p != null)
                {
                    //Set the players movement speed to 0.0f
                    p.GetComponent<Movement>().movementSpeed = 0.0f;
                    Debug.Log("Stopped: " + p.name);
                }
            }

            oxyUsed = true;
            Debug.Log("Oxygen Depleted!!");
        }

        //If the gravity has been depleted and the gravUsed has not been used yet. 
        //This will only run once and then only check the first if statement, instead of
        //going into the foreach loop and double checking for the null value.
        if (gravityDepleted && !gravUsed)
        {
            //For every player in the players array
            foreach (GameObject p in player)
            {
                //safe gaurd - double check for null values
                if (p != null)
                {
                    //Slow the players by half of their current speed
                    p.GetComponent<Movement>().movementSpeed -= (p.GetComponent<Movement>().movementSpeed / 2.0f);
                    Debug.Log("Slowed: " + p.name);
                }
            }

            gravUsed = true;
            Debug.Log("Gravity Depleted!!");



        }


    }


}//End of Base_System

public enum SystemType
{
    SHIELD,
    OXYGEN,
    GRAVITY,
    WEAPON,
    NONE
}



/// <summary>
/// Everything to do with a ship system.
/// 
/// </summary>
[System.Serializable]
public class Current_System
{
    [Tooltip("Core_Power AND Canister is connected")]
    public bool isActive;

    [Tooltip("System Type")]
    public SystemType type;

    [Tooltip("System Direction")]
    public Direction direction;

    [Tooltip("Core_Power ON || OFF")]
    public bool corePower;

    [Tooltip("Junction Box connected to the current system.")]
    public GameObject junctionBox;

    [Tooltip("Canister of the current system.")]
    public GameObject canisterSlot;

    [Tooltip("Canister connected TRUE || FALSE")]
    public bool canisterConnected;

    public enum Direction
    {
        LEFT,
        RIGHT,
        TOP,
        BOTTOM,
        NONE
    }

}






