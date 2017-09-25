using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 /*- Alex Scicluna -*/

public class Base_System : MonoBehaviour
{
 

    private bool isPowered = false;
    private bool isCanisterConnected = false;
    private bool isActive = false;

    [SerializeField]
    [Range(0,5)]
    //[Tooltip("")]
    private int baseDepletionRate;

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

    public int DepletionRate
    {
        get { return baseDepletionRate; }
        set { baseDepletionRate = value; }
    }

    public int Shield_UsageAmount
    {
        get { return shield_UsageAmount; }
        set { shield_UsageAmount = value; }
    }


    public bool CheckForCanister()
    {
        //if a canister is in the slot return true
        //else false
        return false;
    }

}

public enum SystemType
{
    SHIELD,
    OXYGEN,
    GRAVITY,
    WEAPON,
    NONE
}

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
    public bool isPowered;
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






