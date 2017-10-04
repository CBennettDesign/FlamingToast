using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class Junctions : MonoBehaviour {
    public GameObject[] Wires;
    public GameObject[] Systems;
    public int startsIlluminated;
    private int selectedIndex = 0;

	// Use this for initialization
	void Start ()
    {
        if (startsIlluminated >= 0)
        {
            setIlluminated(startsIlluminated, true);
            selectedIndex = startsIlluminated;
        }
       
	}
	
	// Update is called once per frame
	void Update ()
    {
	  
	}

    public void ToggleJunction()
    {
        setIlluminated(selectedIndex, false);

        selectedIndex++;
        if (selectedIndex >= Wires.Length)
            selectedIndex = 0;

        setIlluminated(selectedIndex, true);
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
            //
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
