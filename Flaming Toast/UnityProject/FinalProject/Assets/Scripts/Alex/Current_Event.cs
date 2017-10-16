using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class Current_Event : MonoBehaviour
{
    private Event_System_Manager eventSystem;

    private float timer;

    private bool currentState;

    //Pre-Initialisation
    private void Awake()
    {
        eventSystem = GameObject.FindGameObjectWithTag("Event_System_Manager").GetComponent<Event_System_Manager>();
    }

    //Main-Initialisation
    private void Start()
    {

    }

    //User Input || !Physics
    private void Update()
    {
        if (currentState)
        {
            timer += Time.deltaTime;

            if (timer >= eventSystem.eventDisplayTime)
            {
                gameObject.SetActive(false);

                timer = 0.0f;
            }
        }
    }

    private void RunEvent(bool state)
    {
        currentState = state;
    }



}
