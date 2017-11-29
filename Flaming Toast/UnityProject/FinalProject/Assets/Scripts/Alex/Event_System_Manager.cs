using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

/*- Alex Scicluna -*/

public class Event_System_Manager : MonoBehaviour
{
    //Enemy Particle
    public GameObject enemyParticle;

    //Asterid particle
    public GameObject asteriodParticle;

    //Progress slider
    [SerializeField]
    private Text progressText;

    [Range(0, 10)]
    public float eventDisplayTime;

    [Range(0, 15)]
    public float spawnDelayTimer;

    [Range(0, 20)]
    public int fullDamageValue;

    [Range(0, 20)]
    public int halfDamageValue;

    [Range(0, 20)]
    public int minimumDamageValue;



    [Header("Relative to the direction of the event.")]
    public Image[] warningImageLocation;
    [Header("Warning Image Location child")]
    public Sprite[] eventImage;
    public GameObject[] spawnLocation;

    private Event_.EventType currentEventType;
    private Event_.EventDirection currentEventDirection;

    public List<Event_> events = new List<Event_>();

    private float timer;
    private int countOfUsed;
    private bool runEventTimer;
    private bool endOfEvent;

    private Base_System baseSystem;

    //When true the events runs
    public bool RunEvents
    {
        get { return runEventTimer; }
        set { runEventTimer = value; }
    }

    //Pre-Initialisation
    private void Awake()
    {

        //Timer for all events
        timer = 0.0f;

        countOfUsed = 0;
        runEventTimer = false;
        

        //Hide all warning images
        foreach (var warningImage in warningImageLocation)
        {
            warningImage.gameObject.SetActive(false);
        }

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


    //Main-Initialisation
    private void Start()
    {
        baseSystem = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();
    }

    //User Input || !Physics
    private void Update()
    {
        //If true then run the events
        if (runEventTimer)
        {

       
            if (timer >= 60.0f)
            {
                baseSystem.DepletionRate = 2;
            }

            if (timer >= 180.0f)
            {
                baseSystem.DepletionRate = 3;
            }


            timer += Time.deltaTime;
            float timMin = (timer / 300) * 100;

            //progress slider value is equal to the timer value
            // timer / minutes in an hour / seconds in a minute * 5 minutes
            progressText.text = (timMin.ToString("f0") + "%");
            //Debug.Log((timer));
            foreach (var activeEvent in events)
            {

                if (timer >= activeEvent.timeStamp && !activeEvent.BeenUsed)
                {

                    //Grab the type, store it
                    if (activeEvent.type != Event_.EventType.NONE)
                    {
                        currentEventType = activeEvent.type;
                    }
                    else
                    {
                        currentEventType = Event_.EventType.NONE;
                    }

                    //Grab the direction, store it
                    if (activeEvent.direction != Event_.EventDirection.NONE)
                    {
                        currentEventDirection = activeEvent.direction;
                    }
                    else
                    {
                        currentEventDirection = Event_.EventDirection.NONE;
                    }
                       
                    switch (currentEventType)
                    {
                        case Event_.EventType.NONE:
                            //do nothing - Debug message
                            Debug.Log("<color=red>Critical Error:</color> Event Name: " + activeEvent.name + " did not have a valid event type.");
                            break;
                        case Event_.EventType.ENEMY_SHIP:
                            //Where on screen to place the warning image
                            switch (currentEventDirection)
                            {
                                case Event_.EventDirection.NONE:
                                    //do nothing - Debug message
                                    Debug.Log("<color=red>Critical Error:</color> Event Name: " + activeEvent.name + " did not have a valid event direction.");
                                    break;
                                      
                                case Event_.EventDirection.TOP:
                                    {
                                        warningImageLocation[0].gameObject.SetActive(true);
                                        warningImageLocation[0].transform.GetChild(0).GetComponent<Image>().sprite = eventImage[0];
                                        //Run the event launcher
                                        warningImageLocation[0].BroadcastMessage("RunEvent", true, SendMessageOptions.DontRequireReceiver);
                                        spawnLocation[0].GetComponent<Event_Spawner>().SpawnEvent(true, currentEventType, currentEventDirection, spawnDelayTimer);
                                        break;
                                    }
                                case Event_.EventDirection.LEFT:
                                    {
                                        warningImageLocation[1].gameObject.SetActive(true);
                                        warningImageLocation[1].transform.GetChild(0).GetComponent<Image>().sprite = eventImage[0];
                                        //Run the event launcher
                                        warningImageLocation[1].BroadcastMessage("RunEvent", true, SendMessageOptions.DontRequireReceiver);
                                        spawnLocation[1].GetComponent<Event_Spawner>().SpawnEvent(true, currentEventType, currentEventDirection, spawnDelayTimer);
                                        break;
                                    }
                                case Event_.EventDirection.RIGHT:
                                    {
                                        warningImageLocation[2].gameObject.SetActive(true);
                                        warningImageLocation[2].transform.GetChild(0).GetComponent<Image>().sprite = eventImage[0];
                                        //Run the event launcher
                                        warningImageLocation[2].BroadcastMessage("RunEvent", true, SendMessageOptions.DontRequireReceiver);
                                        spawnLocation[2].GetComponent<Event_Spawner>().SpawnEvent(true, currentEventType, currentEventDirection, spawnDelayTimer);
                                        break;
                                    }
                                case Event_.EventDirection.BOTTOM:
                                    {
                                        warningImageLocation[3].gameObject.SetActive(true);
                                        warningImageLocation[3].transform.GetChild(0).GetComponent<Image>().sprite = eventImage[0];
                                        //Run the event launcher
                                        warningImageLocation[3].BroadcastMessage("RunEvent", true, SendMessageOptions.DontRequireReceiver);
                                        spawnLocation[3].GetComponent<Event_Spawner>().SpawnEvent(true, currentEventType, currentEventDirection, spawnDelayTimer);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;

                        case Event_.EventType.ASTEROID:
                            //Where on screen to place the warning image
                            switch (currentEventDirection)
                            {
                                case Event_.EventDirection.NONE:
                                    //do nothing - Debug message

                                    //Debug.Log("<color=red>Critical Error: Event Name: " + activeEvent.name + " did not have a valid event direction.</color>");
                                    break;
                                case Event_.EventDirection.TOP:
                                    {
                                        warningImageLocation[0].gameObject.SetActive(true);
                                        warningImageLocation[0].transform.GetChild(0).GetComponent<Image>().sprite = eventImage[1];
                                        //Run the event launcher
                                        warningImageLocation[0].BroadcastMessage("RunEvent", true, SendMessageOptions.DontRequireReceiver);
                                        spawnLocation[0].GetComponent<Event_Spawner>().SpawnEvent(true, currentEventType, currentEventDirection, spawnDelayTimer);
                                        break;
                                    }
                                case Event_.EventDirection.LEFT:
                                    {
                                        warningImageLocation[1].gameObject.SetActive(true);
                                        warningImageLocation[1].transform.GetChild(0).GetComponent<Image>().sprite = eventImage[1];
                                        //Run the event launcher
                                        warningImageLocation[1].BroadcastMessage("RunEvent", true, SendMessageOptions.DontRequireReceiver);
                                        spawnLocation[1].GetComponent<Event_Spawner>().SpawnEvent(true, currentEventType, currentEventDirection, spawnDelayTimer);
                                        break;
                                    }
                                case Event_.EventDirection.RIGHT:
                                    {
                                        warningImageLocation[2].gameObject.SetActive(true);
                                        warningImageLocation[2].transform.GetChild(0).GetComponent<Image>().sprite = eventImage[1];
                                        //Run the event launcher
                                        warningImageLocation[2].BroadcastMessage("RunEvent", true, SendMessageOptions.DontRequireReceiver);
                                        spawnLocation[2].GetComponent<Event_Spawner>().SpawnEvent(true, currentEventType, currentEventDirection, spawnDelayTimer);
                                        break;
                                    }
                                case Event_.EventDirection.BOTTOM:
                                    {
                                        warningImageLocation[3].gameObject.SetActive(true);
                                        warningImageLocation[3].transform.GetChild(0).GetComponent<Image>().sprite = eventImage[1];
                                        //Run the event launcher
                                        warningImageLocation[3].BroadcastMessage("RunEvent", true, SendMessageOptions.DontRequireReceiver);
                                        spawnLocation[3].GetComponent<Event_Spawner>().SpawnEvent(true, currentEventType, currentEventDirection, spawnDelayTimer);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;

                        default:
                            break;

                    }

                    //Debug.Log("<color=white> "+ "Current Event: "+ activeEvent.type + " : " + activeEvent.direction + " </color>");

                    activeEvent.BeenUsed = true;
                }
                else if(activeEvent.BeenUsed)
                {
                    countOfUsed++;
                }

       

                //Stop the timer when all events have been used
                if (countOfUsed >= events.Count)
                {
                    runEventTimer = false;
                    //Debug.Log("<color=white>Stopped the event timer.</color>");
                }
            }
 

            //Reset count after each pass
            countOfUsed = 0;
        }
        else
        {
            
        }

        if (!endOfEvent)
        {
            int maxValue;
            maxValue = Convert.ToInt32("100");
            int currentValue;
            //currentValue = Convert.ToInt32(progressText.text);
            int.TryParse(progressText.text, out currentValue);
            if (currentValue >= maxValue)
            {
                endOfEvent = true;
            }
        }

        //warningImage[0].transform.position;






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

