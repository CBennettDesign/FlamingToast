﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
 

/*- Alex Scicluna -*/

public class UI_Menu_Manager : MonoBehaviour
{
 
    //Current State that the menu is on.
    [HideInInspector]
    public CurrentMenuPanel currentPanel;

    public GameObject startButton;
    public GameObject backButton;
    public GameObject resumeButton;
    [HideInInspector]
    public GameObject EventSystemRef;

    public GameObject mainMenu_Panel;
    public GameObject optionsMenu_Panel;
    public GameObject pauseMenu_Panel;
    public GameObject endGame_LOSS_Panel;
    public GameObject endGame_WIN_Panel;

    public GameObject Highlighter;

    //Allows to update the validation checks to have different amounts of buttons, 
    //only changed when the menu panel's change
    private int currentButtonCount_MIN;
    private int currentButtonCount_MAX;



 
    //Turn off all menu panels
    public void ClearPanels()
    {
        mainMenu_Panel.SetActive(false);
        optionsMenu_Panel.SetActive(false);
        pauseMenu_Panel.SetActive(false);
        endGame_LOSS_Panel.SetActive(false);
        endGame_WIN_Panel.SetActive(false);
        Highlighter.SetActive(false);
    }
        
    public void ShowMainMenuPanel()
    {
        currentPanel = CurrentMenuPanel.MAIN_MENU;
        //EventSystemRef.GetComponent<EventSystem>().SetSelectedGameObject(startButton);
        UpdateButtonCount(currentPanel);
        Debug.Log(transform.GetChild(0).name);
        transform.GetChild(0).gameObject.SetActive(true);
        Highlighter.SetActive(true);
    }


    public void ShowOptionsPanel()
    {
        currentPanel = CurrentMenuPanel.OPTIONS_MENU;
        //EventSystemRef.GetComponent<EventSystem>().SetSelectedGameObject(backButton);
        UpdateButtonCount(currentPanel);
        //Debug.Log(transform.GetChild(0).name);
        transform.GetChild(0).gameObject.SetActive(true);
        Highlighter.SetActive(true);
    }
        


    public void ShowPausePanel()
    {
        currentPanel = CurrentMenuPanel.PAUSE_MENU;
        //EventSystemRef.GetComponent<EventSystem>().SetSelectedGameObject(resumeButton);
        UpdateButtonCount(currentPanel);
        //Debug.Log(transform.GetChild(0).name);
        transform.GetChild(0).gameObject.SetActive(true);
        Highlighter.SetActive(true);
    }

    public void ShowEndGame_LOSS_Panel()
    {
        currentPanel = CurrentMenuPanel.END_GAME_LOSS;
        //EventSystemRef.GetComponent<EventSystem>().SetSelectedGameObject(resumeButton);
        UpdateButtonCount(currentPanel);
        //Debug.Log(transform.GetChild(0).name);
        transform.GetChild(0).gameObject.SetActive(true);
        Highlighter.SetActive(true);
    }


    public void ShowEndGame_WIN_Panel()
    {
        currentPanel = CurrentMenuPanel.END_GAME_WIN;
        //EventSystemRef.GetComponent<EventSystem>().SetSelectedGameObject(resumeButton);
        UpdateButtonCount(currentPanel);
        //Debug.Log(transform.GetChild(0).name);
        transform.GetChild(0).gameObject.SetActive(true);
        Highlighter.SetActive(true);
    }


    public void ShowCreditsScene()
    {
        SceneManager.LoadScene(2);
    }



    public void Quit()
    {
            //If we are running in a standalone build of the game
        #if UNITY_STANDALONE
            //Quit the application
            Application.Quit();
        #endif

            //If we are running in the editor
        #if UNITY_EDITOR
            //Stop playing the scene
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    /// <summary>
    /// Clears all panels and resets the count of buttons
    /// </summary>
    /// <param name="a_currentPanel"></param>
    private void UpdateButtonCount(CurrentMenuPanel a_currentPanel)
    {
        ClearPanels();

        Button[] buttonCountInChildren = GetComponentsInChildren<Button>();

        switch (currentPanel)
        {
            case CurrentMenuPanel.NONE:
                {
                    //Reset them to zero
                    currentButtonCount_MIN = 0;
                    currentButtonCount_MAX = 0;
                    break;
                }
            case CurrentMenuPanel.MAIN_MENU:
                {
                    mainMenu_Panel.SetActive(true);

                    //Update the current range for the main menu button count
                    currentButtonCount_MIN = 0;
                    currentButtonCount_MAX = buttonCountInChildren.Length;
 

                    break;
                }
            case CurrentMenuPanel.OPTIONS_MENU:
                {
                    optionsMenu_Panel.SetActive(true);

                    //Update the current range for the options menu button count
                    currentButtonCount_MIN = 0;
                    currentButtonCount_MAX = buttonCountInChildren.Length;
 

                    break;
                }
            case CurrentMenuPanel.PAUSE_MENU:
                {

                    pauseMenu_Panel.SetActive(true);

                    //Update the current range for the pause menu button count
                    currentButtonCount_MIN = 0;
                    currentButtonCount_MAX = buttonCountInChildren.Length;

 
                    break;
                }
            case CurrentMenuPanel.END_GAME_LOSS:
                {
                    endGame_LOSS_Panel.SetActive(true);
                    //Update the current range for the pause menu button count
                    currentButtonCount_MIN = 0;
                    currentButtonCount_MAX = buttonCountInChildren.Length;
                    
                    break;
                }
            case CurrentMenuPanel.END_GAME_WIN:
                {
                    endGame_WIN_Panel.SetActive(true);
                    //Update the current range for the pause menu button count
                    currentButtonCount_MIN = 0;
                    currentButtonCount_MAX = buttonCountInChildren.Length;

                    break;
                }
            default:
                {
                    //??NANI!!!
                    break;
                }
        }
    }



    public enum CurrentMenuPanel
    {
        NONE,
        MAIN_MENU,
        OPTIONS_MENU,
        PAUSE_MENU,
        END_GAME_LOSS,
        END_GAME_WIN
    }

}
