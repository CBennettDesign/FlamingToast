using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class Shield_System : MonoBehaviour
{
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

    //Pre-Initialisation
    private void Awake()
    {
        //Get the system manager
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();
        //Grab the base usage amount
        usageAmount = system.Shield_UsageAmount;

        //Canister slot
        canisterSlot = currentSystem.CanisterSlot.GetComponent<Canister_Slot>();

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

    }

    //Animations || !Important
    private void LateUpdate()
    {
 
        //Does the canisterSlot have a canister?
        if (canisterSlot.CheckForCanister())
        {
            //Only Drain when the canister matches the Flux Type of this system
            if (canisterSlot.CurrentCanister.Type == currentSystem.FluxType)
            {
                canisterSlot.DrainCanister();
            }
 
        }
        
        ////Debuging the canister slot state.
        //string canisterStatus = (canisterSlot.CheckForCanister()) ? "Connected" : "Not Connected";
        //Debug.Log(transform.parent.name + "|| Canister Slot: Canister[" + canisterStatus + "]", this);
    }


}
