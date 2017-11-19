using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_System : MonoBehaviour
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

    private float timer;

    //Pre-Initialisation
    private void Awake()
    {
        //Get the system manager
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();
        //Canister slot
        canisterSlot = currentSystem.SystemCanisterSlot.GetComponent<Canister_Slot>();
    }

    //Main-Initialisation
    private void Start()
    {
        //Set the current system type
        currentSystem.Type = SystemType.WEAPON;
        //systemDirection = Direction.TOP; - use the inspector.

        //Flux type requirement
        currentSystem.FluxType = FluxType.RED;

        //If it it active
        currentSystem.IsActive = system.IsActive;
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
            }
        }
        else
        {
            canisterSlot.lowChargeWarning.SetActive(false);
            canisterSlot.CanDrainCanister = false;
            currentSystem.IsActive = false;
            if (currentSystem.SystemLight != null)
            {
                currentSystem.SystemLight.SetActive(false);
            }
        }


        if (currentSystem.IsActive)
        {

            //Drains connected canister - can only happen if the system is active, when it has a cansiter
            canisterSlot.CanDrainCanister = true;


            timer += Time.deltaTime;

            if (timer >= 1.0f)
            {
                Debug.Log("<color=cyan>Weapons " + currentSystem.Direction + " are online</color>");

                //timer reset
                timer = 0.0f;
            }
        }



    }



    //Current state being the core power bool being passed around
    private void Toggle(bool currentState)
    {
        currentSystem.CorePower = currentState;
    }




}
