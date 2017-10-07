using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*- Alex Scicluna -*/
public class Power_Core : MonoBehaviour
{
    //Ships health
    //Also use the property for taking damage
    [SerializeField]
    [Range(0,10)]
    private float shipHealth;
    public float ShipHealth
    {
        get { return shipHealth; }
        set { shipHealth = value; }
    }

    //UI Slider
    public Slider slider;
    float sValue;

    //Pre-Initialisation
    private void Awake()
    {
        //Double check that the tag Power_Core exists and then apply it to this object
        this.gameObject.tag = "Power_Core";


        //Ship Health at default 100%
        shipHealth = 10;
        
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
        slider.value = shipHealth;       
    }

    //Animations || !Important
    private void LateUpdate()
    {

    }
    
}
