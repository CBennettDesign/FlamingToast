using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*- Alex Scicluna -*/


public class Shield_System : MonoBehaviour
{
    //Base System
    private Base_System system;
    [Header("Base System")]
    [Tooltip("Value Overriden by the Base System")]
    public int depletionRate;
    //[Header("Current System")]
    public Current_System currentSystem;


    //When the shield is active and something hits that shield on the direction that it came from.
    //Take this value and minus it away from the canisters current charge
    [Header("*Usage amount per hit to the connected canister")]
    [Tooltip("Value Overriden by the Base System")]
    [Range(1,100)]
    public int usageAmount;
    
    //Pre-Initialisation
    private void Awake()
    {
        //Grabs the parent of the system and gets the base_system
        system = transform.parent.gameObject.GetComponent<Base_System>();
        usageAmount = system.Shield_UsageAmount;
    }


    //Main-Initialisation
    private void Start()
    {
        currentSystem.type = SystemType.SHIELD;
        //systemDirection = Direction.TOP; - use the inspector.
        depletionRate = system.DepletionRate;
        currentSystem.isActive = system.IsActive;
        
    }

    //Physics
    private void FixedUpdate()
    {

    }

    //User Input
    private void Update()
    {

    }

    //Animations
    private void LateUpdate()
    {

    }

}
