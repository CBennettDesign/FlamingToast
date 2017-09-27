using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*- Alex Scicluna -*/


public class Shield_System : MonoBehaviour
{
    //Base System
    private Base_System system;
    [Header("Base System")]
    [Tooltip("Value Overriden by the Base System")]
    public int depletionRate;
    //[Header("Current System")]
    public Current_System currentSystem;

    //Current Systems canister slot
    private CanisterSlot canisterSlot;

    //When the shield is active and something hits that shield on the direction that it came from.
    //Take this value and minus it away from the canisters current charge
    [Header("*Usage amount per hit to the connected canister")]
    [Tooltip("Value Overriden by the Base System")]
    [Range(1, 100)]
    public int usageAmount;

    //Pre-Initialisation
    private void Awake()
    {
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();
        usageAmount = system.Shield_UsageAmount;

        //Canister slot
        canisterSlot = currentSystem.canisterSlot.transform.GetChild(0).GetComponent<CanisterSlot>();

    }


    //Main-Initialisation
    private void Start()
    {
        currentSystem.type = SystemType.SHIELD;
        //systemDirection = Direction.TOP; - use the inspector.
        depletionRate = system.DepletionRate;
        currentSystem.isActive = system.IsActive;

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
        //Returns true or false
        //canisterSlot.CheckForCanister();

        //Debuging the canister slot state.
        string canisterStatus = (canisterSlot.CheckForCanister()) ? "Connected" : "Not Connected";
        Debug.Log(transform.parent.name + "|| Canister Slot: Canister[" + canisterStatus + "]", this);
    }


}
