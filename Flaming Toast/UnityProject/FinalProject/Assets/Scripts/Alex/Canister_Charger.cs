using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/


public class Canister_Charger : MonoBehaviour
{
    public GameObject chargingParticle;

    [Tooltip("Charging amount per second")]
    [Range(0,10)]
    public int chargingAmount;

    [Tooltip("Charging with what type of flux")]
    public FluxType chargingType;

    //Charging Timer - every 1 second it will charge the canister by a certian amount.
    private float timer;

    //System RayCast 
    private System_RayCast system_Ray;


    //System Access point
    public Canister CurrentCanister
    { get { return system_Ray.CurrentCanister; } }

    //Instance ID's of all the cansiters used.
    //Allows it not to be charged again when put back onto the charger
    //Move to a single location Canister Charger Manager 
    //public List<int> usedCanisterID = new List<int>();
    //private Canister_Charger_Manager CCM;

    //Default value, if it has not found a valid canister
    private bool isValidCanister = false;


    //Pre-Initialisation
    private void Awake()
    {
        ////Raycast Line Check - Rework to a sphere cast.?
        //rayCast = new Ray(transform.position, Vector3.up);

        //CCM = GameObject.FindGameObjectWithTag("CCM").GetComponent<Canister_Charger_Manager>();

        //Current systems ray casting object, first child of this
        system_Ray = this.transform.GetChild(0).GetComponent<System_RayCast>();
       
        //So that it has something to check against
        //CCM.usedCanisterID.Add(0);

    }

    //Main-Initialisation
    private void Start()
    {          
        //Starting point for the timer, planned every 1 second it charge the currentCanister
        timer = 0.0f;

        //Charge Amount is set in the inspector
        //chargeAmount = 0;

        //Charging type set in the inspector
        //chargeType = FluxType.NONE;
    }

    //Physics
    private void FixedUpdate()
    {

    }

    //User Input || !Physics
    private void Update()
    {
        //Have a canister connected
        if (system_Ray.CheckForCanister() /*&& !holdingCanister*/)
        {
            //holdingCanister = true;

            //If the Flux type of the canister is NONE change it
            if (system_Ray.CurrentCanister.Type == FluxType.NONE)
            {
                //Set the currentCanister Type to match the charging type of this charger
                system_Ray.CurrentCanister.Type = chargingType;
                system_Ray.CurrentCanister.Charge = 1;
            }
 
            //Safe Gaurd AND validation
            if (system_Ray.CurrentCanister != null && system_Ray.CurrentCanister.Type == chargingType)
            {
                //Only charge the canister when it is a valid canister (not on the list)
                //if (ValidateCanister()/* && holdingCanister*/)
                //{
                    ChargeCanister();
                //}
                //else
                //{
                //    Debug.Log("No canister or not a valid canister");
                //}
                chargingParticle.SetActive(true);
            }

        
        }
        else
        {
            //When a canister leaves or there is none connected to this set it to false
            isValidCanister = false;

            if (system_Ray.CurrentCanister != null)
            {
                Debug.Log("Charge in canister: " + system_Ray.CurrentCanister.Charge);
            }

            system_Ray.CurrentCanister = null;

            chargingParticle.SetActive(false);

            //
            //holdingCanister = false;
        }
        

    }

    //Animations || !Important
    private void LateUpdate()
    {
           
    }


    //public bool ValidateCanister()
    //{
    //    //A valid canister has not been found
    //    if (!isValidCanister)
    //    {
    //        //Check for canisterID match
    //        for (int canisterID_index = 0; canisterID_index < CCM.usedCanisterID.Count; canisterID_index++)
    //        {
    //            //Canister ID does not match the currentCanister ID
    //            if (CCM.usedCanisterID[canisterID_index] != system_Ray.CurrentCanister.GetInstanceID())
    //            {
    //                //Doesn't match
    //                isValidCanister = true;
    //            }
    //            else
    //            {
    //                //Matches an element in the list
    //                isValidCanister = false;
    //            }
 

    //        }

    //        //isValidCanister and Zero charge
    //        if (isValidCanister && system_Ray.CurrentCanister.Charge == 0)
    //        {
    //            //Add it to the list of canister ID's so that it can not be used again.
    //            CCM.usedCanisterID.Add(system_Ray.CurrentCanister.GetInstanceID());
    //        }
    //    }

    //    //Return the current state after going through the loop
    //    //Debug.Log("Is a valid canister: " + isValidCanister);
    //    return isValidCanister;
    //}

    public void ChargeCanister()
    {
        //Found a valid canister and now charging it.
        //if (isValidCanister)
        //{
            //Depletion timer
            timer += Time.deltaTime;

            //Approx 1 second and while it is below max charge (100%)
            if (timer >= 1.0f && system_Ray.CurrentCanister.Charge < 100)
            {
                Debug.Log("<color=white>Charging the canister</color>");
                //Charge the connected canister by the chargeAmount
                system_Ray.CurrentCanister.Charge += chargingAmount;


                //Canister is charged
                if (system_Ray.CurrentCanister.Charge >= 100)
                {
                    //Clean up - Nothing above 100%
                    system_Ray.CurrentCanister.Charge = 100;
                    //Particle cue
                    //Here
                    Debug.Log("<color=yellow>Charge complete.</color>");
                    //Reset to false as it is done with the currentCanister
                    isValidCanister = false;
                }

                //Timer reset
                timer = 0.0f;

            }

        //}
    }


             

 
}
