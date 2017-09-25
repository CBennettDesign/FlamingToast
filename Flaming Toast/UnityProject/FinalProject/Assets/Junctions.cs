using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Junctions : MonoBehaviour {
    public GameObject[] Wires;
    private int selectedIndex = 0;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach(Transform child in Wires[selectedIndex].transform)
            {
                child.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
                child.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);

                selectedIndex++;
                if (selectedIndex >= Wires.Length)
                    selectedIndex = 0;

                child.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.green);
                child.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            }
           
        }	
	}
}
