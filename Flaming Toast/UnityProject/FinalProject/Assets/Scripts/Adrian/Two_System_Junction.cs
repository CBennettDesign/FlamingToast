using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_System_Junction : MonoBehaviour {

    //Systems that are being switched
    public GameObject[] Systems;

    //Bool is currently powered
    //private bool powered;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Toggle(bool currentState)
    {
        //powered = currentState;
        for (int i = 0; i < Systems.Length; i++)
        {
            Systems[i].SendMessage("Toggle", currentState, SendMessageOptions.DontRequireReceiver);
        }
    }
}
