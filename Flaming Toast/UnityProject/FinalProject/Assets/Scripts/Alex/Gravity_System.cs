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

    [Header("*Current Gravity Status: ON || OFF")]
    public bool gravityStatus;

    //Depletion Timer - every 1 second it will go down by the depletionRate
    private float timer = 0.0f;

    //Pre-Initialisation
    private void Awake()
    {
        //Get a reference to the base system
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();

        //Canister slot
        canisterSlot = currentSystem.CanisterSlot.GetComponent<Canister_Slot>();


        //currentSystem.WireSet.GetComponent<WireStatus>().status;

        //Material mat = currentSystem.WireSet.transform.GetChild(0).GetComponent<Renderer>().material;
        //mat.EnableKeyword("_EMISSION");
        //Debug.Log("Wire Set " + currentSystem.WireSet.transform.GetChild(0).name + " : " + mat.GetFloat("_EmissionColor"));
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

        //Off by default
        gravityStatus = false;
    }

    //Physics
    private void FixedUpdate()
    {


    }

    //User Input || !Physics
    private void Update()
    {

 
        //While the oxygen is not depleted 
        //  And the current system is active (Canister connected and Core Power)
        if (!system.OxygenDepleted)
        {
            
            //General timer
            timer += Time.deltaTime;

            //If gravity is on. Full Player speed every 1 second
            if (currentSystem.IsActive && timer >= 1.0f)
            {
                //For every player in the players array
                foreach (GameObject p in system.player)
                {
                    //safe gaurd - double check for null values
                    if (p != null)
                    {
                        //Players speed is equal to what the starting speed was when the game starts
                        p.GetComponent<Movement>().movementSpeed = p.GetComponent<Movement>().DefaultSpeed;
                        Debug.Log("Gravity ON : Put at default speed: " + p.name);
                    }
                }
                    
                //Timer reset
                timer = 0.0f;
            }
            
            //if Gravity is off
            if (!currentSystem.IsActive && timer >= 1.0f)
            {
                //For every player in the players array
                foreach (GameObject p in system.player)
                {
                    //safe gaurd - double check for null values
                    if (p != null)
                    {
                        //Players speed is slowed
                        p.GetComponent<Movement>().movementSpeed = (p.GetComponent<Movement>().DefaultSpeed / 2.0f);
                        Debug.Log("Gravity OFF : Slowed: " + p.name);
                    }
                }

                //Timer reset
                timer = 0.0f;
            }

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
            gravityStatus = true;
            //Allows the canister slot to drain the connected canister
            canisterSlot.CanDrainCanister = true;
        }
        //Either one is false
        else if (!currentSystem.CanisterConnected || !currentSystem.CorePower)
        {
            //Set the current system IN ACTIVE;
            currentSystem.IsActive = false;
            gravityStatus = false;
            //Denies the canister slot from draining the connected canister
            canisterSlot.CanDrainCanister = false;
        }

        //Debuging the canister slot state.
        //string canisterStatus = (canisterSlot.CheckForCanister()) ? "Connected" : "Not Connected";
        //Debug.Log(transform.parent.name + "|| Canister Slot: Canister[" + canisterStatus + "]", this);
    }

}
