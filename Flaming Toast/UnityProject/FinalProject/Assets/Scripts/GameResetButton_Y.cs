using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using UnityEngine.SceneManagement;
public class GameResetButton_Y : MonoBehaviour {

    public XboxController controller;

    void Update ()
    {
        if (XCI.GetButtonDown(XboxButton.Y, controller)) 
        {
            SceneManager.LoadScene(0);
        }	
	}
}
