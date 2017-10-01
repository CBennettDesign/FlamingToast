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

    //Current Canister Connected
    private Canister currentCanister;

    //System RayCast 
    private System_RayCast system_Ray;
    //System Access point
    public Canister CurrentCanister
    { get { return currentCanister; } }


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
        currentCanister = null;
    }

    //Main-Initialisation
    private void Start()
    {
        //Starting point for the timer, planned every 1 second it deplete the currentCanister
        timer = 0.0f;
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
         
    }

    public void DrainCanister()
    {
        //Canister is in the canister slot for the system
        if (currentCanister != null)
        {
            //Has charge in the cansiter
            if (currentCanister.Charge > 0)
            {
                //Depletion timer
                timer += Time.deltaTime;
                //Approx 1 second and while it is above Zero
                if (timer >= 1.0f && currentCanister.Charge > 0)
                {
                    //Drain the connected canister by the base system depletion rate
                    currentCanister.Charge -= system.DepletionRate;

                    //if negative number
                    if (currentCanister.Charge < 0)
                    {
                        //Clean up - No negative numbers
                        currentCanister.Charge = 0;
                    }

                    //Timer reset
                    timer = 0.0f;

                    //Cue for the canister to explode!
                    if (currentCanister.Charge == 0)
                    {
                        //Particle cue
                        //Here
                        //Destroy the current canister
                        currentCanister.Destroy();
                        //Destroy(currentCanister.gameObject);
                        //Double check, set it to null. 
                        currentCanister = null;
                    }
                }

            }
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
            currentCanister = system_Ray.CurrentCanister;
            return true;
        }
        else
        {
            currentCanister = null;
            return false;
        }

     
    }



}
