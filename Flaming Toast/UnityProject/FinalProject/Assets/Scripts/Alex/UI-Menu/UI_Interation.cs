using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;

/*- Alex Scicluna -*/

public class UI_Interation : MonoBehaviour
{
    private XboxController contoller;

    private UI_Menu_Manager displayPanel;                 
    private bool isPaused;                         
    private StartOptions startScript;              
                                                   
    //Awake is called before Start()
    void Awake()
    {
        //Get a component reference to ShowPanels attached to this object, store in showPanels variable
        displayPanel = GetComponent<UI_Menu_Manager>();
 
    }


    private void Start()
    {
        contoller = XboxController.All;
    }

    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        //Debug.Log(currentScene.buildIndex);

        //Is in main game
        if (currentScene.buildIndex != 0)
        {
            //Start button OR Escape AND IS PAUSED and it's not in the main menu
            if (XCI.GetButtonDown(XboxButton.Start, contoller)  && isPaused)
            {
                //UnPause the game
                UnPauseGame();
            }

            //Start button OR Escape AND not paused and it's not in the main menu
            else if (XCI.GetButtonDown(XboxButton.Start, contoller)  && !isPaused)
            {
                    
                //displayPanel.EventSystemRef.GetComponent<EventSystem>().SetSelectedGameObject(GameObject.Find("Resume"));
               
                //pause the game
                PauseGame();
            }
        }
    }

                                                   
  

    public void PauseGame()
    {
        //Set isPaused to true
        isPaused = true;

        //Set time.timescale to 0
        Time.timeScale = 0;
 
        displayPanel.ShowPausePanel();
    }


    public void UnPauseGame()
    {
        //Set isPaused to false
        isPaused = false;

        //Set time.timescale to 1
        Time.timeScale = 1;

        displayPanel.ClearPanels();
    }



}


