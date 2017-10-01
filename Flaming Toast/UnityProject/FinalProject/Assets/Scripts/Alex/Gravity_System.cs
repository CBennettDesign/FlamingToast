using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class Gravity_System : MonoBehaviour
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

    [Header("*Current Gravity level: Default starting amount 100%")]
    [Range(0, 100)]
    public float gravityLevel;

    //Depletion Timer - every 1 second it will go down by the depletionRate
    private float timer = 0.0f;

    //Pre-Initialisation
    private void Awake()
    {
        //Get a reference to the base system
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();

        //Canister slot
        canisterSlot = currentSystem.CanisterSlot.GetComponent<Canister_Slot>();
    }




    //Main-Initialisation
    private void Start()
    {
        //Current System Type
        currentSystem.Type = SystemType.GRAVITY;

        //Is the system active
        currentSystem.IsActive = system.IsActive;

        //Flux type requirement
        currentSystem.FluxType = FluxType.RED;

        //Start with 100%
        gravityLevel = 100;
    }

    //Physics
    private void FixedUpdate()
    {


    }

    //User Input || !Physics
    private void Update()
    {
        //While the gravity hasn't been depleted.
        if (gravityLevel > 0)//!system.GravityDepleted
        {
            //Depletion timer
            timer += Time.deltaTime;

            //Approx 1 second and while it is above Zero
            if (timer >= 1.0f && gravityLevel > 0)
            {
                //Decrease the gravity level
                gravityLevel -= system.DepletionRate;

                //if negative number
                if (gravityLevel < 0)
                {
                    //Clean up - No negative numbers
                    gravityLevel = 0;
                }

                //Timer reset
                timer = 0.0f;

            }
            

            if (gravityLevel == 0)
            {
                //Exit point
                system.GravityDepleted = true;
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
