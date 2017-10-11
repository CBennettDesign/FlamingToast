using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class AlterChargeAtRun : MonoBehaviour
{
    
    private Canister cansiter;

    //Pre-Initialisation
    private void Start()
    {
        cansiter = this.transform.GetComponent<Canister>();
        cansiter.Charge = 100;
        Debug.Log("Set the green cansiter to 100 charge.");
    }

 

}

