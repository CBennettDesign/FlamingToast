using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygen_System : MonoBehaviour
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

    [Header("*Current Oxygen level: Default starting amount 100%")]
    [Range(1, 100)]
    public int oxygenLevel = 100;

    private float timer = 0.0f;

    //Pre-Initialisation
    private void Awake()
    {
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();

       
        //Canister slot
        canisterSlot = currentSystem.canisterSlot.transform.GetChild(0).GetComponent<CanisterSlot>();


    }


    //Main-Initialisation
    private void Start()
    {
        currentSystem.type = SystemType.OXYGEN;
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



        //Depletion timer
        timer += Time.deltaTime;
        if (timer >= 1.0f && oxygenLevel > 0)
        {
            oxygenLevel -= depletionRate;
            if (oxygenLevel < 0)
            {
                oxygenLevel = 0;
            }    
            timer = 0.0f;
        }
    }

    //Animations || !Important
    private void LateUpdate()
    {
        //Debuging the canister slot state.
        string canisterStatus = (canisterSlot.CheckForCanister()) ? "Connected" : "Not Connected";
        Debug.Log(transform.parent.name + "|| Canister Slot: Canister[" + canisterStatus + "]", this);
    }

}
