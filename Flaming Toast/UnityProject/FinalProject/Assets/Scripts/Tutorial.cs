using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {


   // public bool Canistercheck;
    public GameObject powercore;
    // Use this for initialization

    void Start ()
    {
        
    }
	
	// Update is called once per frame

	void Update ()
    {
          
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Canister")
        {
            powercore.transform.GetComponent<PowercoreIllumination>().enabled = true;
        }
        else
        {
            return;
        }
        Debug.Log(other);
    }
}
