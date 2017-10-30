using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using UnityEngine.UI;

/*- Alex Scicluna -*/

public class Menu_Selection_Manager : MonoBehaviour
{

    //Controller listener
    private XboxController controller;

    //Array of menu buttons?
    public List<GameObject> menuButtons;

    //int current index of the array of buttons
    private int currentMenuIndex;

    //active colour tint
    Color buttonActiveTint;
    //non active colour tint
    Color buttonInactiveTint;
    
    //Setup
    private void Start ()
    {
        //Listen to all controllers
        controller = XboxController.All;

        //Fill in the menuButtons Array
        //PopulateMenuButtons();
        
        //Fill in the menuButtons Array
        Button[] tempButtonChildren = GetComponentsInChildren<Button>();

        //menuButtons = new List<GameObject>[tempButtonChildren.Length];

        int countOfChildren = 0;

        //Add each active button to the list
        foreach (Button childButton in tempButtonChildren)
        {
            menuButtons.Add(childButton.gameObject);
            countOfChildren++;
        }

        //Store the colours
        buttonActiveTint = menuButtons[0].GetComponent<Button>().colors.highlightedColor;
        buttonInactiveTint = menuButtons[0].GetComponent<Button>().colors.normalColor;

        //activate first menu item
        menuButtons[0].GetComponent<Image>().color = buttonActiveTint;

 

    }
    
    

    //User input via the controller D-Pad Button && A.Button for selection B.Button to go to the previous menu
    private void Update ()
    {



        if (XCI.GetButtonDown(XboxButton.A, controller))
        {
            //Call all functions on the button that is currently selected
            menuButtons[currentMenuIndex].GetComponent<Button>().onClick.Invoke();

            //re populate the array of buttons with the new set of active objects
            PopulateMenuButtons();

        }



        if (XCI.GetButtonDown(XboxButton.DPadDown, controller))
        {

            //set the current active to false 
            menuButtons[currentMenuIndex].GetComponent<Image>().color = buttonInactiveTint;

            //increase current menu index
            currentMenuIndex++;

            //validate - wrap
            if(currentMenuIndex == menuButtons.Count)
            {
                currentMenuIndex = 0;
            }
            
            //set the new button active to true 
            menuButtons[currentMenuIndex].GetComponent<Image>().color = buttonActiveTint;
        }



        if (XCI.GetButtonDown(XboxButton.DPadUp, controller))
        {
            //set the current active to false 
            //menuButtons[currentMenuIndex].SetActive(false);
            menuButtons[currentMenuIndex].GetComponent<Image>().color = buttonInactiveTint;

            //decrement menu index
            currentMenuIndex--;

            //validate - wrap
            if (currentMenuIndex < 0)
            {
                currentMenuIndex = menuButtons.Count - 1;
            }

            //set the new button active to true 
            //menuButtons[currentMenuIndex].SetActive(true);
            menuButtons[currentMenuIndex].GetComponent<Image>().color = buttonActiveTint;
        }

    }
 

    //Display current active menu button
    private void PopulateMenuButtons()
    {

        //foreach (var button  in menuButtons)
        //{
        //    button.SetActive(false);
        //}
        menuButtons[0].transform.parent.transform.parent.gameObject.SetActive(false);

        //empty the list of active buttons
        menuButtons.Clear();

        //Fill in the menuButtons Array
        Button[] tempButtonChildren = GetComponentsInChildren<Button>();

        //menuButtons = new List<GameObject>[tempButtonChildren.Length];

        int countOfChildren = 0;

        //Add each active button to the list
        foreach (Button childButton in tempButtonChildren)
        {
            menuButtons.Add(childButton.gameObject);
            countOfChildren++;
        }

        //activate first menu item
        menuButtons[0].GetComponent<Image>().color = buttonActiveTint;

        //reset menuIndex
        currentMenuIndex = 0;
    }


}
