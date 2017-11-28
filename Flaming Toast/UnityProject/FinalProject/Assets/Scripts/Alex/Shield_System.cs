using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class Shield_System : MonoBehaviour
{

    //Ship Core
    //Power_Core shipCore;

    //Base System
    private Base_System system;
    //[Header("Base System")]
    //[Tooltip("Value Overriden by the Base System")]
    //public float depletionRate;
    //[Header("Current System")]
    public Current_System currentSystem;

    //Current Systems canister slot
    private Canister_Slot canisterSlot;

    //When the shield is active and something hits that shield on the direction that it came from.
    //Take this value and minus it away from the canisters current charge
    [Header("*Usage amount per hit to the connected canister")]
    [Tooltip("Value Overriden by the Base System")]
    [Range(1, 100)]
    public int usageAmount;

    [Header("*Damage reduction amount when the shield are on.")]
    //[Tooltip("")]
    [Range(1, 100)]
    public int reductionAmount;

    private float timer;

    private GameObject currentColGroup;
    private Material currentShieldMaterial;

    //Sound System ADRIAN
    private bool TurnOnSounds = false;
    private bool TurnOffSounds = false;

    //Lerping adrian
    [Range(0.0f, 10.0f)]
    public float speedMultiplyer;

    private float lerping;


    //Pre-Initialisation
    private void Awake()
    {
        //Reference to the ship core.
        //shipCore = GameObject.FindGameObjectWithTag("Power_Core").GetComponent<Power_Core>();
        //Get the system manager
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();
        //Canister slot
        canisterSlot = currentSystem.SystemCanisterSlot.GetComponent<Canister_Slot>();
        //Grab the base usage amount
        usageAmount = system.Shield_UsageAmount;

        reductionAmount = system.Shield_ReductionAmount;
    }
       
    
    //Main-Initialisation
    private void Start()
    {
        //Set the current system type
        currentSystem.Type = SystemType.SHIELD;
        //systemDirection = Direction.TOP; - use the inspector.

        //Flux type requirement
        currentSystem.FluxType = FluxType.BLUE;

        //If it it active
        currentSystem.IsActive = system.IsActive;

        currentShieldMaterial = system.shipShield.GetComponent<Renderer>().material;
                
        switch (currentSystem.Direction)
        {
            case Current_System.SystemDirection.LEFT:
                currentColGroup = system.shieldCol_LEFT;
                break;

            case Current_System.SystemDirection.RIGHT:
                currentColGroup = system.shieldCol_RIGHT;
                break;
                
            case Current_System.SystemDirection.TOP:
                currentColGroup = system.shieldCol_TOP;
                break;

            case Current_System.SystemDirection.BOTTOM:
                currentColGroup = system.shieldCol_BOTTOM;
                break;
                
            case Current_System.SystemDirection.NONE:
                break;
            default:
                break;
        }
                

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
                        //Sound system check by adrian
                        /////////////////////////////////////////////
                        if (!TurnOnSounds)
                        {
                            PlayerAudio.instance.PlaySound(system.SheildSoundOn);
                            TurnOnSounds = true;
                        }
                            TurnOffSounds = true;
                        /////////////////////////////////////////////
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
                    //Sound system check by adrian
                    /////////////////////////////////////////////
                    TurnOnSounds = false;
                    if (TurnOffSounds)
                    {
                        PlayerAudio.instance.PlaySound(system.SheildSoundOff);
                        TurnOffSounds = false;
                    }
                    /////////////////////////////////////////////
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

                // Sound system check by adrian
                    /////////////////////////////////////////////
                TurnOnSounds = false;
                if (TurnOffSounds)
                {
                    PlayerAudio.instance.PlaySound(system.SheildSoundOff);
                    TurnOffSounds = false;
                }
                /////////////////////////////////////////////
            }
        }


        system.ShipHealth = system.ShipHealth;
        //The asteriod that collides with the shield parses it self as a game object to the shield system and from there
        //The shield system will grab the value from the game object and use that for the damage calculations
        //Asteriod Damage Random (1||2) - Shield Reduction value [reductionAmount](1,10) if Shields are up

        if (currentSystem.IsActive)
        {
            //Drains connected canister - can only happen if the system is active, when it has a cansiter
            canisterSlot.CanDrainCanister = true;
            
            //Lerp
            lerping += Time.deltaTime * speedMultiplyer;
            if (lerping >= 1)
            {
                lerping = 1;
            }

            //get the direction and affect the direction on the shield shader visibility
            switch (currentSystem.Direction)
            {
                case Current_System.SystemDirection.LEFT:
                    currentShieldMaterial.SetFloat("_Shield_Left", lerping);
                    break;
                case Current_System.SystemDirection.RIGHT:
                    currentShieldMaterial.SetFloat("_Shield_Right", lerping);
                    break;
                case Current_System.SystemDirection.TOP:
                    currentShieldMaterial.SetFloat("_Shield_Top", lerping);
                    break;
                case Current_System.SystemDirection.BOTTOM:
                    currentShieldMaterial.SetFloat("_Shield_Bottom", lerping);
                    break;
                case Current_System.SystemDirection.NONE:
                    break;
                default:
                    break;
            }

            currentColGroup.SetActive(true);

            timer += Time.deltaTime;

            if (timer >= 1.0f)
            {
                //Debug.Log("<color=cyan>Shield " + currentSystem.Direction + " are online</color>");

                //timer reset
                timer = 0.0f;
            }
            

        }
        else
        {
            lerping -= Time.deltaTime * speedMultiplyer;
            if (lerping <= 0)
            {
                lerping = 0;
            }
            switch (currentSystem.Direction)
            {
                case Current_System.SystemDirection.LEFT:
                    currentShieldMaterial.SetFloat("_Shield_Left", lerping);
                    break;
                case Current_System.SystemDirection.RIGHT:
                    currentShieldMaterial.SetFloat("_Shield_Right", lerping);
                    break;
                case Current_System.SystemDirection.TOP:
                    currentShieldMaterial.SetFloat("_Shield_Top", lerping);
                    break;
                case Current_System.SystemDirection.BOTTOM:
                    currentShieldMaterial.SetFloat("_Shield_Bottom", lerping);
                    break;
                case Current_System.SystemDirection.NONE:
                    break;
                default:
                    break;
            }

            currentColGroup.SetActive(false);
            //Debug.Log("Shields are DOWN!");
        }

 


    }




    /// <summary>
    /// Not sure if needed, testing requried, if it doesnt break the game remove this section of code. 
    /// </summary>
    //Current state being the core power bool being passed around
    private void Toggle(bool currentState)
    {
        currentSystem.CorePower = currentState;
    }

    //private void Top(bool currentEventHit)
    //{
    //    TakeDamage(currentEventHit);
    //}

    //private void Left(bool currentEventHit)
    //{
    //    TakeDamage(currentEventHit);
    //}
    //private void Right(bool currentEventHit)
    //{
    //    TakeDamage(currentEventHit);
    //}
    //private void Bottom(bool currentEventHit)
    //{
    //    TakeDamage(currentEventHit);
    //}

    //private void TakeDamage(bool currentEventHit)
    //{
    //    if (currentEventHit)
    //    {
    //        system.ShipHealth -= usageAmount - reductionAmount;//need to fix using the event system damage
    //        //Usage amount is meant for the canister charge if the shield was up or not take a set amount of charge or not.
    //    }
    //}
}
