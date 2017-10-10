using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDeleteLater : MonoBehaviour {

    public GameObject doorTest;

    public Current_System currentSystem;

    private Canister_Slot canisterSlot;

    // Use this for initialization
    void Start ()
    {
        //Canister slot
        canisterSlot = currentSystem.SystemCanisterSlot.GetComponent<Canister_Slot>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (canisterSlot.CheckForCanister())
        {
            currentSystem.CanisterConnected = true;
        }
        else
        {
            currentSystem.CanisterConnected = false;
        }

        if (currentSystem.CanisterConnected)
        {
            doorTest.SetActive(false);
        }
        else
        {
            doorTest.SetActive(true);
        }

             
        
    }
}
