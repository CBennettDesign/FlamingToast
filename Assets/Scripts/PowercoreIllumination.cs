using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowercoreIllumination : MonoBehaviour {
    public GameObject[] Wires;

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i  < Wires.Length; i ++)
        {
            setIlluminated(i, true);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	    //if (Input.GetKeyDown(KeyCode.Space))
     //   {
     //       setIlluminated(selectedIndex, false);

     //       selectedIndex++;
     //       if (selectedIndex >= Wires.Length)
     //           selectedIndex = 0;

     //       setIlluminated(selectedIndex, true);
     //   }	
	}

    void setIlluminated(int Wire, bool state)
    {
        if (state)
        {
            foreach (Transform child in Wires[Wire].transform)
            {
                child.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.green);
                child.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            }
        }
        else
        {
            foreach (Transform child in Wires[Wire].transform)
            {
                child.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
                child.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);
            }
        }
    }
}
