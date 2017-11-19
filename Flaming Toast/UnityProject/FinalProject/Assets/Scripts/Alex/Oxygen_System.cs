using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*- Alex Scicluna -*/

public class Oxygen_System : MonoBehaviour
{
    //public Text oxygenText;

    //Base System
    private Base_System system;
    //[Header("Base System")]
    //[Tooltip("Value Overriden by the Base System")]
    //public float depletionRate;
    //[Header("Current System")]
    public Current_System currentSystem;

    //Current Systems canister slot
    private Canister_Slot canisterSlot;

    private Event_System_Manager evm;
    
    //Depletion Timer - every 1 second it will go down by the depletionRate
    private float timer = 0.0f;
 
    //Pre-Initialisation
    private void Awake()
    {
       //Grab the base system 
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();

        //Canister slot
        canisterSlot = currentSystem.SystemCanisterSlot.GetComponent<Canister_Slot>();

        evm = GameObject.FindGameObjectWithTag("Event_System_Manager").GetComponent<Event_System_Manager>();

        //oxygenText.text = "Oxygen Systems: Offline";
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
        //system.OxygenLevel = 100;
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
            //oxygenText.text = "Oxygen Systems: Online";
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


                    if (currentSystem.SystemLight != null)
                    {
                        currentSystem.SystemLight.SetActive(true);
                    }

                }
            }
            else
            {
                //Reset
                canisterSlot.lowChargeWarning.SetActive(false);
                currentSystem.CanisterConnected = false;
                currentSystem.IsActive = false;

                if (currentSystem.SystemLight != null)
                {
                    currentSystem.SystemLight.SetActive(false);
                }

                canisterSlot.CanDrainCanister = false;
                //oxygenText.text = "Oxygen Systems: Offline";
            }
        }
        else
        {
            //oxygenText.text = "Oxygen Systems: Offline";
            canisterSlot.lowChargeWarning.SetActive(false);
            canisterSlot.CanDrainCanister = false;
            currentSystem.IsActive = false;
            if (currentSystem.SystemLight != null)
            {
                currentSystem.SystemLight.SetActive(false);
            }
        }



        if (evm.RunEvents)
        {
            // timer
            timer += Time.deltaTime;

        }

        //Once per second, check if the current system is active
        if (timer >= 1.0f)
        {
            //Is Active - Running - Charging the oxygen back up - else decrease oxygen levels
            if (currentSystem.IsActive)
            {
                //Drains connected canister - can only happen if the system is active, when it has a cansiter
                canisterSlot.CanDrainCanister = true; 

                //Increase the oxygen levels
                system.OxygenLevel += system.DepletionRate;

                //Clean up. nothing above 100
                if (system.OxygenLevel > 100)
                {
                    system.OxygenLevel = 100;
                }

            }
            else
            {
                //Decrease the oxygen level - Balance the numbers later
                system.OxygenLevel -= system.DepletionRate / 2.0f;
               // Debug.Log("Oxygen Level in OxygenSystem: " + system.OxygenLevel, system);
                //if negative number
                if (system.OxygenLevel < 0)
                {
                    //Clean up - No negative numbers
                    system.OxygenLevel = 0;

                    system.OxygenDepleted = true;
                }
            }

            //Debug.Log("<color=cyan>Oxygen System Online</color>");

            //timer reset - regarless of what code block executed.
            timer = 0.0f;
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
