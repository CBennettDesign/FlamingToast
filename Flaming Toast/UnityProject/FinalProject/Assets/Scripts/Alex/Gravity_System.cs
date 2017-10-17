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
        canisterSlot = currentSystem.SystemCanisterSlot.GetComponent<Canister_Slot>();


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
        /* 
         * Order
         * Core Power check
         *      Is a canister there
         *          Is it the right type - matches the current system
         *              currentSystem.IsActive = true;
         * else not core power
         *      currentSystem.IsActive = false;
         *      
         *      
         */

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

        //The status of the gravity, is on or off depending on the above code
        gravityStatus = currentSystem.IsActive;


        //While the oxygen is not depleted  - other wise the player movement speed would be reset back to half speed.
        //  And the current system is active (Canister connected and Core Power)
        if (!system.OxygenDepleted)
        {

            //General timer
            timer += Time.deltaTime;

            //If gravity is on. Full Player speed every 1 second
            if (timer >= 1.0f && currentSystem.IsActive)
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

                //Drains connected canister - can only happen if the system is active, when it has a cansiter
                canisterSlot.CanDrainCanister = true;

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
                        Debug.Log("<color=orange>Gravity OFF : Slowed: " + p.name + "</color>");
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



       
    }


    //Current state being the core power bool being passed around from the junction boxes
    private void Toggle(bool currentState)
    {
        currentSystem.CorePower = currentState;
    }

}
