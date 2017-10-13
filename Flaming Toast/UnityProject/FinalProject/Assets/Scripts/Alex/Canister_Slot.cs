using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/
 
public class Canister_Slot : MonoBehaviour
{
    //Base System
    private Base_System system;

    //Depletion Timer - every 1 second it will go down by the depletionRate
    private float timer;

    //System RayCast 
    private System_RayCast system_Ray;

    //Current Canister Connected
    //private Canister currentCanister;

    //System Access point
    public Canister CurrentCanister
    { get { return system_Ray.CurrentCanister; } }



    //Is the canister slot allowed to drain the canister that is connected
    //Only when the system that this is attached to has a canister connected and power from the core.
    private bool canDrainCanister;
    //System Access point
    public bool CanDrainCanister
    {
        get { return canDrainCanister; }
        set { canDrainCanister = value; }
    }

    //Pre-Initialisation
    private void Awake()
    {
        //Get the system manager
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();

        ////Raycast Line Check - Rework to a sphere cast.?
        //rayCast = new Ray(transform.position, Vector3.up);

        //Current systems ray casting object, first child of this
        system_Ray = this.transform.GetChild(0).GetComponent<System_RayCast>();

        //Default value for the currentCanister
        //currentCanister = null;
    }

    //Main-Initialisation
    private void Start()
    {
        //Starting point for the timer, planned every 1 second it deplete the currentCanister
        timer = 0.0f;
    }

    private void Update()
    {
        if (canDrainCanister)
        {
            DrainCanister();
        }
    }

    private void DrainCanister()
    {
        //Canister is in the canister slot for the system
        //And it is allowed to drain the canister - Given the all clear from the current system
        if (system_Ray.CurrentCanister != null)
        {
            //update the status of the canister
            system.IsCanisterConnected = true;

            //Has charge in the cansiter
            if (system_Ray.CurrentCanister.Charge > 0)
            {
                //Depletion timer
                timer += Time.deltaTime;
                //Approx 1 second and while it is above Zero
                if (timer >= 1.0f)
                {
                    //Drain the connected canister by the base system depletion rate
                    system_Ray.CurrentCanister.Charge -= system.DepletionRate;

                    //if negative number
                    if (system_Ray.CurrentCanister.Charge < 0)
                    {
                        //Clean up - No negative numbers
                        system_Ray.CurrentCanister.Charge = 0;
                    }

                    //Timer reset
                    timer = 0.0f;

                    //Cue for the canister to explode!
                    if (system_Ray.CurrentCanister.Charge == 0)
                    {
                        //Particle cue
                        //Here
                        //Destroy the current canister
                        system_Ray.CurrentCanister.Destroy();
                        //Destroy(currentCanister.gameObject);
                        //Double check, set it to null. 
                        system_Ray.CurrentCanister = null;
                    }
                }

            }
        }
        else
        {
            //Reset the canister status
            system.IsCanisterConnected = false;
        }

    }

    /// <summary>
    /// Bounce to the system_Ray's Check for canister. The Ship system does not 
    /// need direct access to the system_Ray object as it is a child of the canister slot.
    /// </summary>
    /// <returns> The Connected Canister TRUE || FALSE </returns>
    public bool CheckForCanister()
    {
        
        if (system_Ray.CheckForCanister())
        {
            //Found a canister
            system_Ray.CurrentCanister = system_Ray.CurrentCanister;
            //system.IsCanisterConnected = true;
            return true;
        }
        else
        {
            //system.IsCanisterConnected = false;
            system_Ray.CurrentCanister = null;
            return false;
        }

     
    }



}
