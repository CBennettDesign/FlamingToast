using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

/*- Alex Scicluna -*/

public class Base_System : MonoBehaviour
{
    public GameObject[] player;

    public GameObject winState;
    public GameObject lossState;

    private bool isPowered = false;
    public bool IsPowered
    {
        get { return isPowered; }
        set { isPowered = value; }
    }
    public AudioClip destroyCanisterSound;
    public AudioClip SheildSoundOn;
    public AudioClip SheildSoundOff;
    public AudioClip WeaponSoundOn;
    public AudioClip WeaponSoundOff;
    public AudioClip SpawnCanisterSound;
    public AudioClip MaxCanisterSound;
    public AudioClip ShieldHit;
    public AudioClip ShipHit;


    private bool isCanisterConnected = false;
    public bool IsCanisterConnected
    {
        get { return isCanisterConnected; }
        set { isCanisterConnected = value; }
    }


    private bool isActive = false;
    public bool IsActive
    {
        get { return isActive; }
        set { isActive = value; }
    }


    [SerializeField]
    [Range(0, 5)]
    //[Tooltip("")]
    private int baseDepletionRate;

    public int DepletionRate
    {
        get { return baseDepletionRate; }
        set { baseDepletionRate = value; }
    }

    //[SerializeField]
    [Tooltip("Shield System usage amount per hit - amount taken away from connected canisters")]
    [Range(1, 50)]
    private int shield_UsageAmount;

    public int Shield_UsageAmount
    {
        get { return shield_UsageAmount; }
        set { shield_UsageAmount = value; }
    }

    //[SerializeField]
    [Tooltip("Shield System reduction amount per hit - (shield usasge amount - this value")]
    [Range(1, 50)]
    private int shield_ReductionAmount;
    public int Shield_ReductionAmount
    {
        get { return shield_ReductionAmount; }
        set { shield_ReductionAmount = value; }
    }


    [SerializeField]
    [Tooltip("Canister Depot System")]
    [Range(1, 10)]
    private int maxCanisterCount;
    public int MaxCanisterCount
    { get { return maxCanisterCount; } }

    private int currentCanisterCount;
    public int CurrentCanisterCount
    {
        get { return currentCanisterCount; }
        set { currentCanisterCount = value; }
    }


    [SerializeField]
    [Range(0, 100)]
    private float oxygenLevel;

    public float OxygenLevel
    {
        get { return oxygenLevel; }
        set { oxygenLevel = value; }
    }


    //Ships health
    //Also use the property for taking damage
    [SerializeField]
    [Range(0, 100)]
    private float shipHealth;
    
    public float ShipHealth
    {
        get { return shipHealth; }
        set { shipHealth = value; }
    }

    //UI Slider
    public Slider HealthSlider;
    public Slider OxygenSlider;
    public Text ProgressValue;

    public GameObject shipShield;
    public GameObject shieldCol_TOP;
    public GameObject shieldCol_LEFT;
    public GameObject shieldCol_RIGHT;
    public GameObject shieldCol_BOTTOM;



    public UI_Menu_Manager ui_menu;


    //Oxygen System 
    private bool oxygenDepleted;

    public bool OxygenDepleted
    {
        get { return oxygenDepleted; }
        set { oxygenDepleted = value; }
    }
    //Oxygen Trigger
    private bool oxyUsed = false;

    private bool shipHealthDepleted = false;

    private void Awake()
    {
        //Makes Sure that this tag exists and then applies it to this object
        this.gameObject.tag = "Base_System";

        Material mat = shipShield.GetComponent<Renderer>().material;

        mat.SetFloat("_Shield_Top", 0.0f);
        mat.SetFloat("_Shield_Left", 0.0f);
        mat.SetFloat("_Shield_Right", 0.0f);
        mat.SetFloat("_Shield_Bottom", 0.0f);

      

        //shipHealth = 100;
        //oxygenLevel = 100;
    }


    //Main loop for base system
    private void Update()
    {
        //If the oxygen has been depleted and the oxyUsed has not been used yet. 
        //This will only run once and then only check the first if statement, instead of
        //going into the foreach loop and double checking for the null value.
        if (oxygenDepleted && !oxyUsed)
        {
            //For every player in the players array
            foreach (GameObject p in player)
            {
                //safe gaurd - double check for null values
                if (p != null)
                {
                    //Set the players movement speed to 0.0f
                    p.GetComponent<Movement>().movementSpeed = 0.0f;
                   // Debug.Log("Killed: " + p.name);

                    //game over screen
                    lossState.GetComponent<Image>().enabled = true;
                    EndGameRestart_LOSS();
                    //Time.timeScale = 0.2f;
                }
            }

            oxyUsed = true;
            //Debug.Log("<color=red>Oxygen Depleted!!</color>");
        }

        if (shipHealth <= 0 && !shipHealthDepleted)
        {
            //Debug.Log("<color=red>Ship health is 0, game over!</color>");
            //For every player in the players array
            foreach (GameObject p in player)
            {
                //safe gaurd - double check for null values
                if (p != null)
                {
                    //Set the players movement speed to 0.0f
                    p.GetComponent<Movement>().movementSpeed = 0.0f;
                    //Debug.Log("Killed: " + p.name);

                    //game over screen
                    lossState.GetComponent<Image>().enabled = true;
                    EndGameRestart_LOSS();
                    //Invoke("EndGameRestart_LOSS", 2.0f);
                    //Time.timeScale = 0.2f;

                }
            }
            shipHealthDepleted = true;
        }

        HealthSlider.value = shipHealth;
        OxygenSlider.value = oxygenLevel;

        //This should be the actual fix
        if (ProgressValue.text.CompareTo("97%") == 0)
        {
            ProgressValue.text = "100%";
            winState.GetComponent<Image>().enabled = true;
            EndGameRestart_WIN();
            Debug.Log(ProgressValue.text);
        }

        //int maxValue;
        //maxValue = 3;//Convert.ToInt32("5");
        //int currentValue;
        //String textProg = ProgressValue.text.ToString();
        //String splitBy = "%";
        //int.TryParse(ProgressValue.text, out currentValue);
        //Debug.Log(ProgressValue.text + " : " + currentValue);

        //if (currentValue >= maxValue)
        //{
        //    ProgressValue.text = "100%";
        //    winState.GetComponent<Image>().enabled = true;
        //    EndGameRestart_WIN();
        //    //Invoke("EndGameRestart_WIN", 2.0f);
        //}
       

    }

    private void EndGameRestart_LOSS()
    {
         ui_menu.ShowEndGame_LOSS_Panel();
    }
        

    private void EndGameRestart_WIN()
    {
        ui_menu.ShowEndGame_WIN_Panel();
    }
        

}//End of Base_System

public enum SystemType
{
    SHIELD,
    OXYGEN,
    GRAVITY,
    WEAPON,
    NONE
}

public enum FluxType
{
    NONE,
    RED,
    BLUE,
    GREEN
}

[System.Serializable]
public class Current_System
{
    [Header("Core_Power AND Canister is connected")]
    [SerializeField]
    private GameObject systemLight;
    public GameObject SystemLight
    {
        get { return systemLight; }
        set { systemLight = value; }
    }

    [Header("Core_Power AND Canister is connected")]
    [SerializeField]
    private bool isActive;

    public bool IsActive
    {
        get { return isActive; }
        set { isActive = value; }
    }

    [Header("System Type")]
    [SerializeField]
    private SystemType type;

    public SystemType Type
    {
        get { return type; }
        set { type = value; }
    }

    [Header("What the flux type it requires")]
    [SerializeField]
    private FluxType fluxType;

    public FluxType FluxType
    {
        get { return fluxType; }
        set { fluxType = value; }
    }

    [Header("System Direction")]
    [SerializeField]
    private SystemDirection direction;

    public SystemDirection Direction
    {
        get { return direction; }
        set { direction = value; }
    }

    [Header("Core_Power ON || OFF")]
    [SerializeField]
    private bool corePower;

    public bool CorePower
    {
        get { return corePower; }
        set { corePower = value; }
    }

    [Header("Connected wire set to the current system.")]
    [SerializeField]
    private GameObject wireSet;

    public GameObject WireSet
    {
        get { return wireSet; }
        set { wireSet = value; }
    }

    [Header("Canister of the current system.")]
    [SerializeField]
    private GameObject systemCanisterSlot;

    public GameObject SystemCanisterSlot
    {
        get { return systemCanisterSlot; }
        set { systemCanisterSlot = value; }
    }

    [Header("Canister connected TRUE || FALSE")]
    [SerializeField]
    private bool canisterConnected;

    public bool CanisterConnected
    {
        get { return canisterConnected; }
        set { canisterConnected = value; }
    }

    public enum SystemDirection
    {
        LEFT,
        RIGHT,
        TOP,
        BOTTOM,
        NONE
    }


}



