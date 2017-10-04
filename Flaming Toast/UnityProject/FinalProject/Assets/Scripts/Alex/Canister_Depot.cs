using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canister_Depot : MonoBehaviour
{
    //Debug
    public bool spawnCanister;

    [SerializeField]
    [Tooltip("How long it will take to spawn a canister")]
    [Range(0, 10)]
    public float spawnInterval;


    //Canister Spawn location
    [Tooltip("Spawn Point of the canister")]
    private GameObject canisterSpawnLocation;

    //Canister PreFab
    [Tooltip("PreFab Object")]
    public GameObject canisterPreFab;
    
    //Base System
    private Base_System system;

    //Overriden in the awake
    [Tooltip("This value will be overriden by the base system canister count")]
    public int canisterCountMax;
    //Current Canister Count
    [SerializeField]
    [Tooltip("Current cansiters in the scene - Stored in the system manager")]
    private int canisterCountOnScene;
 
    
    
    //Spawn Timer
    private float timer;

    //Pre-Initialisation
    private void Awake()
    {
        //Get a reference to the base system
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();
        
        //Default check
        spawnCanister = false;


        //get the max canister count
        if (system != null)
        {
            //Starting values
            canisterCountMax = system.MaxCanisterCount;
            canisterCountOnScene = system.CurrentCanisterCount;
        }

    }


    //Main-Initialisation
    private void Start()
    {
        //Canister Depot's first child - "Canister Spawn Location"
        canisterSpawnLocation = transform.GetChild(0).gameObject;
    }


    //Physics
    private void FixedUpdate()
    {

    }

    //User Input || !Physics
    private void Update()
    {
        //Inspector checkbox - User Input / Interaction
        if (spawnCanister)
        {
            //increase timer
            timer += Time.deltaTime;

            //At 1 second AND less or equal to the max count of canisters
            if (timer >= spawnInterval && system.CurrentCanisterCount < system.MaxCanisterCount)
            {
                //There is a prefab gameobject to use.
                if (canisterPreFab != null)
                {
 
                    //Create a canister at a location Rotated by 90 on the Z axis
                    Instantiate(canisterPreFab, canisterSpawnLocation.transform.position, Quaternion.Euler(new Vector3(0,0,90)));

                    //Increase the count.
                    system.CurrentCanisterCount++;

                    //Update the local canister count
                    canisterCountOnScene = system.CurrentCanisterCount;

                    //Reset Timer
                    timer = 0.0f;

                    //Reset the spawn canister check box.
                    spawnCanister = false;
                }
                else
                {
                    Debug.Log("Canister not found!");
                    //Debug Cube
                    Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube), canisterSpawnLocation.transform.position, Quaternion.Euler(new Vector3(0,0,90)));
                }
            }
            else if (system.CurrentCanisterCount >= system.MaxCanisterCount)
            {
                Debug.Log("Max Canisters on scene");
            }


        }
    }

    //Animations || !Important
    private void LateUpdate()
    {

    }
}
