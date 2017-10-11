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
        system.ShipHealth = system.ShipHealth;
        //The asteriod that collides with the shield parses it self as a game object to the shield system and from there
        //The shield system will grab the value from the game object and use that for the damage calculations
        //Asteriod Damage Random (1||2) - Shield Reduction value [reductionAmount](1,10) if Shields are up

        if (currentSystem.IsActive)
        {
            Debug.Log("Shields are UP!");
            //get the direction and affect the direction on the shield shader visibility
        }
        else
        {
            //Debug.Log("Shields are DOWN!");
        }



    }

    //Animations || !Important
    private void LateUpdate()
    {
        //Does the canisterSlot have a canister?
        if (canisterSlot.CheckForCanister())
        {
            //Update the current systems canister status
            currentSystem.CanisterConnected = true;

            //Only Drain when the canister matches the Flux Type of this system AND the system is running
            if (canisterSlot.CurrentCanister.Type == currentSystem.FluxType && currentSystem.IsActive)
            {
                canisterSlot.DrainCanister();
            }

        }
        else
        {
            //Reset the canister status
            currentSystem.CanisterConnected = false;
        }

        //If Both the canister is there (with charge) AND it has power from the core then the current system is active.
        if (currentSystem.CanisterConnected && currentSystem.CorePower)
        {
            //Set the current system to be active;
            currentSystem.IsActive = true;
            //Allows the canister slot to drain the connected canister
            //canisterSlot.CanDrainCanister = true;
        }
        //Either one is false then the system wont be active / running
        else if (!currentSystem.CanisterConnected || !currentSystem.CorePower)
        {
            //Set the current system IN ACTIVE;
            currentSystem.IsActive = false;
            //Denies the canister slot from draining the connected canister
            //canisterSlot.CanDrainCanister = false;
        }

        ////Debuging the canister slot state.
        //string canisterStatus = (canisterSlot.CheckForCanister()) ? "Connected" : "Not Connected";
        //Debug.Log(transform.parent.name + "|| Canister Slot: Canister[" + canisterStatus + "]", this);
    }



    //Current state being the core power bool being passed around
    private void Toggle(bool currentState)
    {
        currentSystem.CorePower = currentState;
    }

}
