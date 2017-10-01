using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class Canister : MonoBehaviour
{

    private Canister_Depot cDepotRef;

    [SerializeField]
    private FluxType canisterType;

    [SerializeField]
    [Range(0,100)]
    private int charge;

    public FluxType Type
    {
        get { return canisterType; }
        set { canisterType = value; }
    }


    public int Charge
    {
        get { return charge; }
        set { charge = value; }
    }
        
    //Pre-Initialisation
    private void Awake()
    {
        cDepotRef = GameObject.FindGameObjectWithTag("Canister_Depot").GetComponent<Canister_Depot>();
        //None by default as it will be changed later
        canisterType = FluxType.NONE;

        //Every canister starts with the charge of Zero
        Charge = 0;
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
 
    }

    //Animations || !Important
    private void LateUpdate()
    {

    }

    public void Destroy()
    {
        //When deleting canister remove from depot canister count
        cDepotRef.CanisterCount -= 1;

        Destroy(this.gameObject);
    }

}