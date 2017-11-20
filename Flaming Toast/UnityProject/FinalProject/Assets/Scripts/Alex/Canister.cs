using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*- Alex Scicluna -*/

public class Canister : MonoBehaviour
{

    //When the player is holding the canister.
    private bool isBeingHeld;
    public bool IsBeingHeld
    {
        get { return isBeingHeld; }
        set { isBeingHeld = value; }
    }




    public Slider chargeSlider;
    public Image sliderFill;//------------------------------------------


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

    private bool onlyCheckOnce;

    //Pre-Initialisation
    private void Awake()
    {
        //Double check that the tag Canister exists and then apply it to this object
        this.gameObject.tag = "Canister";

        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();

        //None by default as it will be changed later
        canisterType = FluxType.NONE;

        //Every canister starts with the charge of Zero || 1
        charge = 0;

        //Start Colour
        sliderFill.color = Color.white;
        //
        onlyCheckOnce = false;
    }


    private void Update()
    {
        chargeSlider.value = charge;

        if (charge > 0 && !onlyCheckOnce)
        {
            //chargeSlider.fillRect.GetChild(0).GetComponent<Renderer>().material.color = Color.red;
            if (canisterType == FluxType.RED)
            {
                sliderFill.color = Color.red;
            }
            else if (canisterType == FluxType.BLUE)
            {
                sliderFill.color = Color.cyan;
            }
            else if (canisterType == FluxType.GREEN)
            {
                sliderFill.color = Color.green;
            }
            else
            {
                sliderFill.color = Color.magenta;
            }

        }
        if (transform.position.y < 0.0f)
        {
            Destroy();
        }
    }

    public void Destroy()
    {
        //When deleting canister remove from depot canister count
        system.CurrentCanisterCount--;

        Destroy(this.gameObject);
    }

    public void Drop()
    {
      GetComponent<Collider>().isTrigger = false;
      transform.parent = null;
      gameObject.AddComponent<Rigidbody>();
     
    }
}