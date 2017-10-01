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

    //Canister PreFab
    public GameObject canisterPreFab;
    
    //base System
    private Base_System system;

    //Current Canister Count
    [SerializeField]
    private int canisterCount;

    
    public int CanisterCount
    {
        get { return canisterCount; }
        set
        {
            //Range check validation
            if (canisterCount >= 0 && canisterCount < system.MaxCanisterCount)
            {
                canisterCount = value;
            }
        }

    }

    //Spawn Timer
    private float timer;

    //Pre-Initialisation
    private void Awake()
    {
        //Get a reference to the base system
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();
        
        //Default check
        spawnCanister = false;

        //Start at Zero
        canisterCount = 0;

    }

    //Main-Initialisation
    private void Start()
    {

    }


    //Physics
    private void FixedUpdate()
    {

    }

    //User Input || !Physics
    private void Update()
    {
        //Inspector checkbox
        if (spawnCanister)
        {
            //increase timer
            timer += Time.deltaTime;

            //At 1 second AND less or equal to the max count of canisters
            if (timer >= spawnInterval && canisterCount < system.MaxCanisterCount)
            {
                //There is a prefab gameobject to use.
                if (canisterPreFab != null)
                {
 

                    //Create a canister at a location - Re - work to a better solution for the position
                    Instantiate(canisterPreFab, new Vector3(transform.position.x - 2.0f, transform.position.y + 3.0f, transform.position.z - 1.0f), Quaternion.identity);

                    //Increase the count.
                    canisterCount++;

                    //Reset Timer
                    timer = 0.0f;

                    //Reset the spawn canister check box.
                    spawnCanister = false;
                }
            }
            else if (canisterCount >= system.MaxCanisterCount)
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
