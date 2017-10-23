using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class Junctions : MonoBehaviour {
    public GameObject[] Wires;
    public GameObject[] NextJunction;
    public int startsIlluminated = -1;
    private int selectedIndex = -1;
    private bool isPowered = false;

    private void Awake()
    {
        selectedIndex = startsIlluminated;
    }

    // Use this for initialization
    void Start ()
    {
        if (startsIlluminated >= 0)
        {
            setIlluminated(startsIlluminated, true);
            isPowered = true;
        }
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
