using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    private int baseDepletionRate;

    [SerializeField]
    [Tooltip("Shield System usage amount per hit - amount taken away from connected canisters")]
    [Range(1, 100)]
    private int shield_UsageAmount;



    [SerializeField]
    [Tooltip("Canister Depot System")]
    [Range(1, 10)]
    private int maxCanisterCount;
    public int MaxCanisterCount
    { get { return maxCanisterCount; } }

    private int currentCanisterCount;
    public int CurrentCanisterCount
    {
        get { return currentCanisterCount; }
        set { currentCanisterCount = value; }
    }


    [SerializeField]
    [Range(0, 100)]
    private float oxygenLevel;

    public float OxygenLevel
    {
        get { return oxygenLevel; }
        set { oxygenLevel = value; }
    }


    //Ships health
    //Also use the property for taking damage
    [SerializeField]
    [Range(0, 100)]
    private float shipHealth;
    
    public float ShipHealth
    {
        get { return shipHealth; }
        set { shipHealth = value; }
    }

    //UI Slider
    public Slider HealthSlider;
    public Slider OxygenSlider;


    public GameObject shipShield;
    public GameObject shieldCol_TOP;
    public GameObject shieldCol_LEFT;
    public GameObject shieldCol_RIGHT;
    public GameObject shieldCol_BOTTOM;

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



    //Oxygen System 
    private bool oxygenDepleted;

    public bool OxygenDepleted
    {
        get { return oxygenDepleted; }
        set { oxygenDepleted = value; }
    }
    //Oxygen Trigger
    private bool oxyUsed = false;


    private void Awake()
    {
        //Makes Sure that this tag exists and then applies it to this object
        this.gameObject.tag = "Base_System";

        Material mat  = shipShield.GetComponent<Renderer>().material;

        mat.SetFloat("_Shield_Top", 0.0f);
        mat.SetFloat("_Shield_Left", 0.0f);
        mat.SetFloat("_Shield_Right", 0.0f);
        mat.SetFloat("_Shield_Bottom", 0.0f);
 
        

        //shipHealth = 100;
        //oxygenLevel = 100;
    }


    //Main loop for base system
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

                    //game over screen
                }
            }

            oxyUsed = true;
            Debug.Log("Oxygen Depleted!!");
        }

        // Debug.Log("OxygenLevel in Base_System before slider: " + oxygenLevel);

        HealthSlider.value = shipHealth;
        OxygenSlider.value = oxygenLevel;
       // Debug.Log("OxygenLevel in Base_System: " + oxygenLevel);
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

public enum FluxType
{
    NONE,
    RED,
    BLUE
}

[System.Serializable]
public class Current_System
{
    [Tooltip("Core_Power AND Canister is connected")]
    [SerializeField]
    private bool isActive;

    public bool IsActive
    {
        get { return isActive; }
        set { isActive = value; }
    }

    [Tooltip("System Type")]
    [SerializeField]
    private SystemType type;

    public SystemType Type
    {
        get { return type; }
        set { type = value; }
    }

    [Tooltip("What the flux type it requires")]
    [SerializeField]
    private FluxType fluxType;

    public FluxType FluxType
    {
        get { return fluxType; }
        set { fluxType = value; }
    }

    [Tooltip("System Direction")]
    [SerializeField]
    private SystemDirection direction;

    public SystemDirection Direction
    {
        get { return direction; }
        set { direction = value; }
    }

    [Tooltip("Core_Power ON || OFF")]
    [SerializeField]
    private bool corePower;

    public bool CorePower
    {
        get { return corePower; }
        set { corePower = value; }
    }

    [Tooltip("Connected wire set to the current system.")]
    [SerializeField]
    private GameObject wireSet;

    public GameObject WireSet
    {
        get { return wireSet; }
        set { wireSet = value; }
    }

    [Tooltip("Canister of the current system.")]
    [SerializeField]
    private GameObject systemCanisterSlot;

    public GameObject SystemCanisterSlot
    {
        get { return systemCanisterSlot; }
        set { systemCanisterSlot = value; }
    }

    [Tooltip("Canister connected TRUE || FALSE")]
    [SerializeField]
    private bool canisterConnected;

    public bool CanisterConnected
    {
        get { return canisterConnected; }
        set { canisterConnected = value; }
    }

    public enum SystemDirection
    {
        LEFT,
        RIGHT,
        TOP,
        BOTTOM,
        NONE
    }


}



