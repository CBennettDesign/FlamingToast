using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*- Alex Scicluna -*/

public class Canister_Depot : MonoBehaviour
{
    public Light depotLight;
    public Text depotCanisterCountText;

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

    private Event_System_Manager evm;

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
    //[SerializeField]
    [Tooltip("Current cansiters in the scene - Stored in the system manager")]
    public int canisterCountOnScene;

    //Has given warning to console
    private bool warningGiven;
    
    //Spawn Timer
    private float timer;

    //canister spawned
    private bool canisterSpawning;

    //Pre-Initialisation
    private void Awake()
    {
        //Get a reference to the base system
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();
        
        //Default check
        canSpawnCansiter = false;

        evm = GameObject.FindGameObjectWithTag("Event_System_Manager").GetComponent<Event_System_Manager>();

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
        depotCanisterCountText.text = (canisterCountMax - canisterCountOnScene).ToString();
        //Debug.Log((canisterCountMax - canisterCountOnScene).ToString());
        if (canisterSpawnLocation != null)
        {


            if (system.CurrentCanisterCount < system.MaxCanisterCount/* && !canisterSpawning*/)
            {
                depotLight.color = Color.green;
            }
            if (!evm.RunEvents)
            {
                depotLight.color = Color.red;
            }
      
            //Inspector checkbox - User Input / Interaction
            if (canSpawnCansiter && evm.RunEvents)
            {

                canisterSpawning = true;
                depotLight.color = Color.red;
                
                //increase timer
                timer += Time.deltaTime;


                //At 1 second AND less or equal to the max count of canisters
                if (timer >= spawnInterval && system.CurrentCanisterCount < system.MaxCanisterCount)
                {
                    SpawnCanister();
                    warningGiven = false;

                    //Reset the spawn canister check box. - Regardless if the canister coount reached the maximum or not
                    canSpawnCansiter = false;
                }
                else if (system.CurrentCanisterCount >= system.MaxCanisterCount && !warningGiven)
                {
                    Debug.Log("<color=yellow>Max Canisters on scene</color>");
                    warningGiven = true;

                    depotLight.color = Color.red;

                    //Reset the spawn canister check box. - Regardless if the canister coount reached the maximum or not
                    canSpawnCansiter = false;
                }

            }
            else
            {
                warningGiven = false;
            }


            //Update the local canister count
            canisterCountOnScene = system.CurrentCanisterCount;
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
            Instantiate(canisterPreFab, canisterSpawnLocation.transform.position,/* Quaternion.identity*/ Quaternion.Euler(new Vector3(0, 90, 0)));

            //Increase the count.
            system.CurrentCanisterCount++;


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

        canisterSpawning = false;
    }


    private void CanSpawnCanister(bool status)
    {
        //When the player is looking at the depot
        canSpawnCansiter = status;
    }
}
