using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class Oxygen_System : MonoBehaviour
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

    [Header("*Current Oxygen level: Default starting amount 100%")]
    [Range(0, 100)]
    public float oxygenLevel;
    
    //Depletion Timer - every 1 second it will go down by the depletionRate
    private float timer = 0.0f;
 
    //Pre-Initialisation
    private void Awake()
    {
       //Grab the base system 
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();

        //Canister slot
        canisterSlot = currentSystem.CanisterSlot.GetComponent<Canister_Slot>();
    }
         


    //Main-Initialisation
    private void Start()
    {
        //Current System Type
        currentSystem.Type = SystemType.OXYGEN;

        //Flux type requirement
        currentSystem.FluxType = FluxType.BLUE;

        //Is the system active
        currentSystem.IsActive = system.IsActive;

        //Start with 100%
        oxygenLevel = 100;
    }

    //Physics
    private void FixedUpdate()
    {


    }

    //User Input || !Physics
    private void Update()
    {


        //While the oxygen hasn't been depleted.
        //When exactly 0 it won't step into it - Good
        if (oxygenLevel > 0)//!system.OxygenDepleted
        {
            //Depletion timer
            timer += Time.deltaTime;

            //Approx 1 second and while it is above Zero
            if (timer >= 1.0f && oxygenLevel > 0) 
            {
                //Decrease the oxygen level - Balance the numbers later
                oxygenLevel -= system.DepletionRate / 2.0f;

                //if negative number
                if (oxygenLevel < 0)
                {
                    //Clean up - No negative numbers
                    oxygenLevel = 0;
                }
   
                //Timer reset
                timer = 0.0f;

            }
            
            if (oxygenLevel == 0)
            {
                //Exit point
                system.OxygenDepleted = true;
            }
        }
   
 


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

        //Debuging the canister slot state.
        //string canisterStatus = (canisterSlot.CheckForCanister()) ? "Connected" : "Not Connected";
        //Debug.Log(transform.parent.name + "|| Canister Slot: Canister[" + canisterStatus + "]", this);
    }

}
