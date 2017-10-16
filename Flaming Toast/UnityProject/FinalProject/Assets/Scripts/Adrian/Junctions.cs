﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class Junctions : MonoBehaviour {
    public GameObject[] Wires;
    public GameObject[] NextJunction;
    //public GameObject[] Systems;
    public int startsIlluminated = -1;
    private int selectedIndex = 0;
    //public bool SystemSide_A;
    //public bool SystemSide_B;
    //public bool ConnectedJunction;
    //private Material mat;

   

    private bool isPowered = false;
 

    // Use this for initialization
    void Start ()
    {
        //grabs the original material of the object that it starts with.
        //mat = Wires[0].transform.GetChild(0).GetComponent<Renderer>().material;
        
        if (startsIlluminated >= 0)
        {
            setIlluminated(startsIlluminated, true);
            selectedIndex = startsIlluminated;
            isPowered = true;
        }
        selectedIndex = startsIlluminated;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(selectedIndex < 0)
        {
            return;
        }
	    if(isPowered)
        {

            setIlluminated(selectedIndex, true);
        }
        else
        {
            setIlluminated(selectedIndex, false);
        }
	}

    public void ToggleJunction()
    {
        if (!isPowered)
        {
            return;
        }

        if (selectedIndex >= 0)
        {
            setIlluminated(selectedIndex, false);
        }
      
        selectedIndex++;
        if (selectedIndex >= Wires.Length)
            selectedIndex = 0;

        setIlluminated(selectedIndex, true);
    }

    public void setIlluminated(int Wire, bool state)
    {
        //creates new color
        Color myColor = new Color();
        ColorUtility.TryParseHtmlString("#042F04FF", out myColor);

        if (state)
        {
            foreach (Transform child in Wires[Wire].transform)
            {
                //Turns on emissions and Changes colors
                child.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                child.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.green);
                child.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            }
        }
        else
        {
            foreach (Transform child in Wires[Wire].transform)
            {
                //Turns off emissions and resets colors
                child.GetComponent<Renderer>().material.SetColor("_Color", myColor);
                child.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
                child.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);
            }
        }
        if(Wire < NextJunction.Length)
            NextJunction[Wire].SendMessage("Toggle", state, SendMessageOptions.DontRequireReceiver);
    }

    void Toggle(bool state)
    {
        isPowered = state;

        if (selectedIndex < NextJunction.Length && selectedIndex >= 0)
        {
            NextJunction[selectedIndex].SendMessage("Toggle", state, SendMessageOptions.DontRequireReceiver);
        }
    }

}