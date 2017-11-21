using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/*- Alex Scicluna -*/


public class HighlightMove : MonoBehaviour {


    public GameObject[] menuButtonCollection;
    
    public List<GameObject> buttonPositions;

    private XboxController allContollers;
    private int currentIndex;

    private float verticalInput;

    private bool userInputed;

    [HideInInspector]
    public UI_Menu_Manager menuSystem;

    Scene currentScene;
 

    void Awake ()
    {
        allContollers = XboxController.All;

        currentIndex = 0;

        buttonPositions = new List<GameObject>();

        currentScene = SceneManager.GetActiveScene();

        if (currentScene.buildIndex == 0)
        {

            for (int outerIndex = 0; outerIndex < menuButtonCollection.Length; outerIndex++)
            {
                if (menuButtonCollection[outerIndex].activeInHierarchy)
                {
                    for (int innerIndex = 0; innerIndex < menuButtonCollection[outerIndex].transform.GetChild(1).childCount; innerIndex++)
                    {
                        buttonPositions.Add(menuButtonCollection[outerIndex].transform.GetChild(1).GetChild(innerIndex).gameObject);
                    }
                }
            }

        }
        else if (currentScene.buildIndex == 1)
        {
            for (int innerIndex = 0; innerIndex < menuButtonCollection[2].transform.GetChild(1).childCount; innerIndex++)
            {
                buttonPositions.Add(menuButtonCollection[2].transform.GetChild(1).GetChild(innerIndex).gameObject);
            }
        }

            

    }
    
    void Start()
    {
        buttonPositions[2].SetActive(false);
        //gameObject.SetActive(false);
    }
    
    void Update ()
    {

        transform.position = Vector3.MoveTowards(transform.position, buttonPositions[currentIndex].transform.position, 15); 
       

        if (XCI.GetDPadDown(XboxDPad.Up, allContollers))
        {
           
            //shift down
            if (currentIndex > 0)
            {
                currentIndex--;
            }
          
        }

        
        if (XCI.GetDPadDown(XboxDPad.Down, allContollers))
        {
            
            //shift up
            if (currentIndex < buttonPositions.Count - 1)
            {
                currentIndex++;
            }
            
        }

        if (XCI.GetButtonDown(XboxButton.A, allContollers))
        {
            buttonPositions[currentIndex].GetComponent<Button>().onClick.Invoke();

            //reset all button Positons
            
            buttonPositions.Clear();

            /*
             * for every menu panel
             * if the menu panel is active in scene
             * for every child of that menu panel that has children
             * add all children to the buttonPositions list 
             * 
             */

            for (int outerIndex = 0; outerIndex < menuButtonCollection.Length; outerIndex++)
            {
                if (menuButtonCollection[outerIndex].activeInHierarchy)
                {
                    for (int innerIndex = 0; innerIndex < menuButtonCollection[outerIndex].transform.GetChild(1).childCount; innerIndex++)
                    {
                        buttonPositions.Add(menuButtonCollection[outerIndex].transform.GetChild(1).GetChild(innerIndex).gameObject);
                    }
                }
            }



            currentIndex = 0;   


 


               

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
            if (currentIndex < buttonPositions.Count - 1)
            {
                currentIndex++;
            }
        }
    }

 
}
