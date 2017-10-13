using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*- Alex Scicluna -*/

public class Event_System_Manager : MonoBehaviour
{
    [Header("Relative to the direction of the event.")]
    public Image[] warningImageLocation;
    [Header("Warning Image Location child")]
    public Sprite[] eventimage;
    public GameObject[] spawnLocation;

    private Event_.EventType currentEventType;
    private Event_.EventDirection currentEventDirection;

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
        

        //Hide all warning images
        foreach (var warningImage in warningImageLocation)
        {
            warningImage.gameObject.SetActive(false);
        }

        //test block
        //foreach (var warningImage in warningImageLocation)
        //{
        //    warningImage.transform.GetChild(0).GetComponent<Image>().sprite = eventimage[0];
        //    warningImageLocation[0].transform.GetChild(0).GetComponent<Image>().sprite = eventimage[1];
        //}
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

            foreach (var activeEvent in events)
            {

                if (timer >= activeEvent.timeStamp && !activeEvent.BeenUsed)
                {
                    //Debug.Log("Incoming: " + ev.name + " : " + ev.type + " from: " + ev.direction + " : " + ev.timeStamp);

                    //Run the event launcher

                    //turn of every warning image before displaying the next
                    foreach (var imageLocation in warningImageLocation)
                    {
                        imageLocation.gameObject.SetActive(false);
                    }
                    

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
                                        warningImageLocation[0].transform.GetChild(0).GetComponent<Image>().sprite = eventimage[0];
                                        break;
                                    }
                                case Event_.EventDirection.BOTTOM:
                                    {
                                        warningImageLocation[1].gameObject.SetActive(true);
                                        warningImageLocation[1].transform.GetChild(0).GetComponent<Image>().sprite = eventimage[0];
                                        break;
                                    }
                                case Event_.EventDirection.LEFT:
                                    {
                                        warningImageLocation[2].gameObject.SetActive(true);
                                        warningImageLocation[2].transform.GetChild(0).GetComponent<Image>().sprite = eventimage[0];
                                        break;
                                    }
                                case Event_.EventDirection.RIGHT:
                                    {
                                        warningImageLocation[3].gameObject.SetActive(true);
                                        warningImageLocation[3].transform.GetChild(0).GetComponent<Image>().sprite = eventimage[0];
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
                                    Debug.Log("<color=red>Critical Error: Event Name: " + activeEvent.name + " did not have a valid event direction.</color>");
                                    break;
                                case Event_.EventDirection.TOP:
                                    {
                                        warningImageLocation[0].gameObject.SetActive(true);
                                        warningImageLocation[0].transform.GetChild(0).GetComponent<Image>().sprite = eventimage[1];
                                        break;
                                    }
                                case Event_.EventDirection.BOTTOM:
                                    {
                                        warningImageLocation[1].gameObject.SetActive(true);
                                        warningImageLocation[1].transform.GetChild(0).GetComponent<Image>().sprite = eventimage[1];
                                        break;
                                    }
                                case Event_.EventDirection.LEFT:
                                    {
                                        warningImageLocation[2].gameObject.SetActive(true);
                                        warningImageLocation[2].transform.GetChild(0).GetComponent<Image>().sprite = eventimage[1];
                                        break;
                                    }
                                case Event_.EventDirection.RIGHT:
                                    {
                                        warningImageLocation[3].gameObject.SetActive(true);
                                        warningImageLocation[3].transform.GetChild(0).GetComponent<Image>().sprite = eventimage[1];
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;

                        default:
                            break;

                    }


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
                    Debug.Log("<color=white>Stopped the event timer.</color>");
                }
            }


            //Reset count after each pass
            countOfUsed = 0;
        }

        //warningImage[0].transform.position;






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

