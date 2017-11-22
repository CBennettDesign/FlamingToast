using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

/*- Alex Scicluna -*/


public class B_Back : MonoBehaviour {

    public GameObject uiMenu;
    UI_Menu_Manager UImm;


    XboxController allContollers;
    	
	void Start ()
    {
        UImm = uiMenu.GetComponent<UI_Menu_Manager>();
        allContollers = XboxController.All;
	}
	
	
	void Update ()
    {
        if (XCI.GetButtonDown(XboxButton.B, allContollers))
        {
            UImm.ClearPanels();
            UImm.ShowMainMenuPanel();
        }
	}
}
