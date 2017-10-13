using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class Shield_System : MonoBehaviour
{

    //Ship Core
    //Power_Core shipCore;

    //Base System
    private Base_System system;
    //[Header("Base System")]
    //[Tooltip("Value Overriden by the Base System")]
    //public float depletionRate;
    //[Header("Current System")]
    public Current_System currentSystem;

    //Current Systems canister slot
    private Canister_Slot canisterSlot;

    //When the shield is active and something hits that shield on the direction that it came from.
    //Take this value and minus it away from the canisters current charge
    [Header("*Usage amount per hit to the connected canister")]
    [Tooltip("Value Overriden by the Base System")]
    [Range(1, 100)]
    public int usageAmount;

    [Header("*Damage reduction amount when the shield are on.")]
    //[Tooltip("")]
    [Range(1, 10)]
    public int reductionAmount;


    private float timer;

    //Pre-Initialisation
    private void Awake()
    {
        //Reference to the ship core.
        //shipCore = GameObject.FindGameObjectWithTag("Power_Core").GetComponent<Power_Core>();
        //Get the system manager
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();
        //Grab the base usage amount
        usageAmount = system.Shield_UsageAmount;
        //Canister slot
        canisterSlot = currentSystem.SystemCanisterSlot.GetComponent<Canister_Slot>();
    }
       
    
    //Main-Initialisation
    private void Start()
    {
        //Set the current system type
        currentSystem.Type = SystemType.SHIELD;
        //systemDirection = Direction.TOP; - use the inspector.

        //Flux type requirement
        currentSystem.FluxType = FluxType.BLUE;

        //If it it active
        currentSystem.IsActive = system.IsActive;

    }
 

    //Physics
    private void FixedUpdate()
    {

    }

    //User Input || !Physics
    private void Update()
    {



        //If there is power from the core going into the current system
        if (currentSystem.CorePower)
        {
            //only check if a canister is there when the system has power.
            //When it has a canister and core power
            if (canisterSlot.CheckForCanister())
            {
                //Update value
                currentSystem.CanisterConnected = true;
                //validate the canister that it has found.
                if (canisterSlot.CurrentCanister.Type == currentSystem.FluxType)
                {
                    //only when the previous 3 checks are true.
                    currentSystem.IsActive = true;
                }
            }
            else
            {
                //Reset
                currentSystem.CanisterConnected = false;
                currentSystem.IsActive = false;
                canisterSlot.CanDrainCanister = false;
            }
        }
        else
        {
            currentSystem.IsActive = false;
        }


        system.ShipHealth = system.ShipHealth;
        //The asteriod that collides with the shield parses it self as a game object to the shield system and from there
        //The shield system will grab the value from the game object and use that for the damage calculations
        //Asteriod Damage Random (1||2) - Shield Reduction value [reductionAmount](1,10) if Shields are up

        if (currentSystem.IsActive)
        {
            timer += Time.deltaTime;
            if (timer >= 1.0f)
            {
                Debug.Log("<color=cyan>Shield " + currentSystem.Direction + " are online</color>");
                //get the direction and affect the direction on the shield shader visibility

                //Drains connected canister - can only happen if the system is active, when it has a cansiter
                canisterSlot.CanDrainCanister = true;


                //timer reset
                timer = 0.0f;
            }
            

        }
        else
        {
            //Debug.Log("Shields are DOWN!");
        }

 


    }

    //Animations || !Important
    private void LateUpdate()
    {

        
    }



    //Current state being the core power bool being passed around
    private void Toggle(bool currentState)
    {
        currentSystem.CorePower = currentState;
    }

}
