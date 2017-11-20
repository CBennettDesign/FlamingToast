using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

/*- Alex Scicluna -*/


public class HighlightMove : MonoBehaviour {

    
    public GameObject[] buttonPositions;

    XboxController allContollers;
    
    int currentIndex;

    Vector3 inputDirection;
		

    void Start ()
	{
        allContollers = XboxController.All;

        currentIndex = 0;
    }
	
	
	void Update ()
    {
        transform.position = Vector3.MoveTowards(transform.position, buttonPositions[currentIndex].transform.position, 5);

        //Left Stick input
        inputDirection = new Vector3(0, XCI.GetAxisRaw(XboxAxis.LeftStickY, allContollers), 0);

        Debug.Log(currentIndex);
        Debug.Log(inputDirection.y);

        if (inputDirection.y >= 0.5f )
        {
            //shift down
            if (currentIndex > 0)
            {
                currentIndex--;
            }
        }

        if (inputDirection.y <= -0.5f )
        {
            //shift up
            if (currentIndex < buttonPositions.Length - 1)
            {
                currentIndex++;
            }
        }



        //keyBoard Code
        if (Input.GetKeyDown(KeyCode.W))
        {
            //shift down
            if (currentIndex > 0)
            {
                currentIndex--;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //shift up
            if (currentIndex < buttonPositions.Length - 1)
            {
                currentIndex++;
            }
        }
    }
}
