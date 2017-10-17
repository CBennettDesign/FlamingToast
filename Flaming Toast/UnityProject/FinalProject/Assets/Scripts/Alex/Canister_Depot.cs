using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*- Alex Scicluna -*/
public class Canister_Depot : MonoBehaviour
{

    //Inpector access - manual overrides
    [SerializeField]
    private bool canSpawnCansiter;
    public bool CanSpawnCansiter
    {
        get { return canSpawnCansiter; }
        set { canSpawnCansiter = value; }
    }
    [SerializeField]
    [Tooltip("How long it will take to spawn a canister")]
    [Range(0, 5)]
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
        canSpawnCansiter = false;


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

    //User Input || !Physics
    private void Update()
    {

        if (canisterSpawnLocation != null)
        {
            //Inspector checkbox - User Input / Interaction
            if (canSpawnCansiter)
            {
                //increase timer
                timer += Time.deltaTime;

                //At 1 second AND less or equal to the max count of canisters
                if (timer >= spawnInterval && system.CurrentCanisterCount < system.MaxCanisterCount)
                {
                    SpawnCanister();
                }
                else if (system.CurrentCanisterCount >= system.MaxCanisterCount)
                {
                    Debug.Log("<color=yellow>Max Canisters on scene</color>");
                }
            }
        
        }
        else
        {
            Debug.Log("<color=red>Critical Error: No canister spawn location.</color>");
        }


    }
     
    private void SpawnCanister()
    {
        //There is a prefab gameobject to use.
        if (canisterPreFab != null)
        {

            //Create a canister at a location Rotated by 90 on the Z axis
            Instantiate(canisterPreFab, canisterSpawnLocation.transform.position, Quaternion.identity/* Quaternion.Euler(new Vector3(0,0,90))*/);

            //Increase the count.
            system.CurrentCanisterCount++;

            //Update the local canister count
            canisterCountOnScene = system.CurrentCanisterCount;
        }
        else
        {
            Debug.Log("<color=red>Critical Error: Canister Prefab not found!</color>");
            //Debug Cube
            GameObject debugCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            debugCube.name = "Debug Cube!";
            debugCube.AddComponent<Rigidbody>();
            Instantiate(debugCube, canisterSpawnLocation.transform.position, Quaternion.identity);
        }

        //Reset Timer
        timer = 0.0f;

        //Reset the spawn canister check box.
        canSpawnCansiter = false;
    }


    private void CanSpawnCanister(bool status)
    {
        //When the player is looking at the depot
        canSpawnCansiter = status;
    }
}
