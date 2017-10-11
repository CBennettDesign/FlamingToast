using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class Junctions : MonoBehaviour {
    public GameObject[] Wires;
    public GameObject[] NextJunction;
    public GameObject[] Systems;
    public int startsIlluminated;
    private int selectedIndex = 0;
    //public bool SystemSide_A;
    //public bool SystemSide_B;
    //public bool ConnectedJunction;
    private Material mat;

   

    private bool isPowered = true;
 

    // Use this for initialization
    void Start ()
    {
        //grabs the original material of the object that it starts with.
        mat = Wires[0].transform.GetChild(0).GetComponent<Renderer>().material;
        
        if (startsIlluminated >= 0)
        {
            setIlluminated(startsIlluminated, true);
            selectedIndex = startsIlluminated;
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

    void setIlluminated(int Wire, bool state)
    {
        //creates new color
        Color myColor = new Color();
        ColorUtility.TryParseHtmlString("#042F04FF", out myColor);

        if (state)
        {
            foreach (Transform child in Wires[Wire].transform)

            {
                child.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                child.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.green);
                child.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            }

        }
        else
        {
            foreach (Transform child in Wires[Wire].transform)
            {
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

        if (selectedIndex < NextJunction.Length)
        {
            NextJunction[selectedIndex].SendMessage("Toggle", state, SendMessageOptions.DontRequireReceiver);
        }
    }

}
