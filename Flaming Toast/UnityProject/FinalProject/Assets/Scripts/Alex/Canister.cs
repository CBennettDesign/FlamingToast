using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class Canister : MonoBehaviour
{

    private Base_System system;

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
        //Double check that the tag Canister exists and then apply it to this object
        this.gameObject.tag = "Canister";

        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();

        //None by default as it will be changed later
        canisterType = FluxType.NONE;

        //Every canister starts with the charge of Zero || 1
        Charge = 1;
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
        system.CurrentCanisterCount--;

        Destroy(this.gameObject);
    }

}