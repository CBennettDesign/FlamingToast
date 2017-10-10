using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*- Alex Scicluna -*/
//[ExecuteInEditMode] - The name of the element in the list equals the name of the name element
public class Event_System_Manager : MonoBehaviour
{
    [Header("Relative to the direction of the event.")]
    public GameObject[] spawnLocation; 


    public List<Event_> events = new List<Event_>();

    private float timer;
    private int countOfUsed;
    private bool runEventTimer;

    //Pre-Initialisation
    private void Awake()
    {
        //Timer for all events
        timer = 0.0f;

        countOfUsed = 0;
        runEventTimer = true;
    }


    //Main-Initialisation
    private void Start()
    {
        //Bubble sort
        for (int outerIndex = 0; outerIndex < events.Count; outerIndex++)
        {
            for (int innerIndex = 0; innerIndex < events.Count - 1; innerIndex++)
            {
                if (events[innerIndex].timeStamp > events[innerIndex + 1].timeStamp)
                {

                    Event_ tempHolder = null;

                    tempHolder = events[innerIndex];

                    events[innerIndex] = events[innerIndex + 1];

                    events[innerIndex + 1] = tempHolder;

                }
            }
        }
    }


    //Physics
    private void FixedUpdate()
    {

    }

    //User Input || !Physics
    private void Update()
    {
        if (runEventTimer)
        {

            timer += Time.deltaTime;

            foreach (var ev in events)
            {

                if (timer >= ev.timeStamp && !ev.BeenUsed)
                {
                    //Debug.Log("Incoming: " + ev.name + " : " + ev.type + " from: " + ev.direction + " : " + ev.timeStamp);
                    ev.BeenUsed = true;
                }
                else if(ev.BeenUsed)
                {
                    countOfUsed++;
                }

                //Stop the timer when all events have been used
                if (countOfUsed >= events.Count)
                {
                    runEventTimer = false;
                    Debug.Log("Stopped the event timer.");
                }
            }

            //Reset count after each pass
            countOfUsed = 0;
        }
                 
                


    }

    //Animations || !Important
    private void LateUpdate()
    {

    }

}//End of ESM Script

[System.Serializable] //- DO NOT REMOVE THIS LINE
public class Event_
{
    //Name of the event
    public string name;

    public enum EventType
    {
        NONE,
        ENEMY_SHIP,
        ASTEROID
    }
    public EventType type;


    public enum EventDirection
    {
        NONE,
        TOP,
        BOTTOM,
        LEFT,
        RIGHT,
       // TOP_RIGHT,
       // TOP_LEFT,
       // BOTTOM_RIGHT,
       // BOTTOM_LEFT
    }
    public EventDirection direction;

    [Header("Time in seconds when the event will happen. [0 to 300]")]
    [Range(0,300)]
    public int timeStamp;

    //When the event has been used - Or just remove it from the list**
    private bool hasBeenUsed;
    public bool BeenUsed
    {
        get { return hasBeenUsed; }
        set { hasBeenUsed = value; }
    }

}

