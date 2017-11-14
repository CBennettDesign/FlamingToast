using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*- Alex Scicluna -*/

public class UI_EventCards : MonoBehaviour
{

    private float currentTimer;

    [Header("Direction Positions : 0 - TOP, 1 - LEFT, 2 - RIGHT, 3 - BOTTOM")]
    public GameObject[] incomingEvent;

    //Events
    [Header("Grabs the events from the event manager.")]
    public List<Event_> events = new List<Event_>();
    private int currentEventIndex;

    //[HideInInspector]
    [Header("Time offset until the actual time it hits")]
    [Range(0, 10)]
    public float hitOffset;

    //New Cards
    public UI_Card[] card;

    [HideInInspector]
    public Slider[] cardSlider;

    //UI Elements
    //public GameObject[] eventCards;
    //public GameObject[] eventCard_TYPE;
    //public GameObject[] eventCard_DIRECTION;
    //public Slider[] eventCard_TIME;

    private Event_System_Manager evm;
    private bool activatedCards;

    private	void Start ()
    {
        //Reference NOT COPY
        //events = GameObject.FindGameObjectWithTag("Event_System_Manager").GetComponent<Event_System_Manager>().events;

        evm = GameObject.FindGameObjectWithTag("Event_System_Manager").GetComponent<Event_System_Manager>();
        //Store a temp reference to the list
        List<Event_> tempEventCollection = evm.events;

        //for every event in that temp reference add it to the local list of events
        foreach (var ev in tempEventCollection)
        {
            events.Add(ev);
        }

        //Card Slider ref
        cardSlider[0] = card[0].TimeToHitSlider.GetComponent<Slider>();
        cardSlider[1] = card[1].TimeToHitSlider.GetComponent<Slider>();
        cardSlider[2] = card[2].TimeToHitSlider.GetComponent<Slider>();
        
 

    }
    
    
    private	void Update ()
    {
        if (evm.RunEvents)
        {
            
            if (!activatedCards)
            {
                GameObject tempObject = null;
                for (int index = 0; index < transform.childCount; index++)
                {
                    tempObject = transform.GetChild(index).gameObject;
                    if (!tempObject.activeSelf)
                    {
                        tempObject.SetActive(true);
                    }

                }

                activatedCards = true;
            }

            currentTimer += Time.deltaTime;

            //reached the soonest event
            if (currentTimer >= events[currentEventIndex].timeStamp + hitOffset)
            {
                //TempSwitchCard();
                //currentEventIndex++;
                events.RemoveAt(0);
            }

            //FIRST CARD
            if (events.Count >= 1)
            {
                 

                //Event Type
                if (events[currentEventIndex].type == Event_.EventType.ENEMY_SHIP)
                {
                    //Disable previous event type
                    card[0].EventIcon[1].SetActive(false);
                    //Enable current event type
                    card[0].EventIcon[0].SetActive(true);
                }
                else if (events[currentEventIndex].type == Event_.EventType.ASTEROID)
                {
                    //Disable previous event type
                    card[0].EventIcon[0].SetActive(false);
                    //Enable current event type
                    card[0].EventIcon[1].SetActive(true);
                }

                //Direction
                switch (events[currentEventIndex].direction)
                {
                    case Event_.EventDirection.NONE:
                        break;
                    case Event_.EventDirection.TOP:
                        {
                            //Disable
                            card[0].Direction[1].SetActive(false);
                            card[0].Direction[2].SetActive(false);
                            card[0].Direction[3].SetActive(false);
                            //Enable
                            card[0].Direction[0].SetActive(true);

                            //Disable
                            incomingEvent[1].SetActive(false);
                            incomingEvent[2].SetActive(false);
                            incomingEvent[3].SetActive(false);
                            //Enable
                            incomingEvent[0].SetActive(true);
                            break;
                        }
                    case Event_.EventDirection.LEFT:
                        {
                            //Disable
                            card[0].Direction[0].SetActive(false);
                            card[0].Direction[2].SetActive(false);
                            card[0].Direction[3].SetActive(false);
                            //Enable
                            card[0].Direction[1].SetActive(true);

                            //Disable
                            incomingEvent[0].SetActive(false);
                            incomingEvent[2].SetActive(false);
                            incomingEvent[3].SetActive(false);
                            //Enable
                            incomingEvent[1].SetActive(true);
                            break;
                        }
                    case Event_.EventDirection.RIGHT:
                        {
                            //Disable
                            card[0].Direction[0].SetActive(false);
                            card[0].Direction[1].SetActive(false);
                            card[0].Direction[3].SetActive(false);
                            //Enable
                            card[0].Direction[2].SetActive(true);

                            //Disable
                            incomingEvent[0].SetActive(false);
                            incomingEvent[1].SetActive(false);
                            incomingEvent[3].SetActive(false);
                            //Enable
                            incomingEvent[2].SetActive(true);
                            break;
                        }
                    case Event_.EventDirection.BOTTOM:
                        {
                            //Disable
                            card[0].Direction[0].SetActive(false);
                            card[0].Direction[1].SetActive(false);
                            card[0].Direction[2].SetActive(false);
                            //Enable
                            card[0].Direction[3].SetActive(true);

                            //Disable
                            incomingEvent[0].SetActive(false);
                            incomingEvent[1].SetActive(false);
                            incomingEvent[2].SetActive(false);
                            //Enable
                            incomingEvent[3].SetActive(true);
                            break;
                        }
                    default:
                        break;
                }

                //Shield Icon
                if (events[currentEventIndex].type == Event_.EventType.ENEMY_SHIP || events[currentEventIndex].type == Event_.EventType.ASTEROID)
                {
                    card[0].ShieldIcon.SetActive(true);
                }
                else
                {
                    card[0].ShieldIcon.SetActive(false);
                }


                //Weapon Icon
                if (events[currentEventIndex].type == Event_.EventType.ENEMY_SHIP)
                {
                    card[0].WeaponIcon.SetActive(true);
                }
                else if (events[currentEventIndex].type == Event_.EventType.ASTEROID)
                {
                    card[0].WeaponIcon.SetActive(false);
                }

                //Time to hit slider
                cardSlider[0].value = events[currentEventIndex].timeStamp + hitOffset - currentTimer;
            }
            else
            {
                card[0].Card_UI.SetActive(false);
            }


            //SECOND CARD
            if (events.Count >= 2)
            {


                //Event Type
                if (events[currentEventIndex + 1].type == Event_.EventType.ENEMY_SHIP)
                {
                    //Disable previous event type
                    card[1].EventIcon[1].SetActive(false);
                    //Enable current event type
                    card[1].EventIcon[0].SetActive(true);
                }
                else if (events[currentEventIndex + 1].type == Event_.EventType.ASTEROID)
                {
                    //Disable previous event type
                    card[1].EventIcon[0].SetActive(false);
                    //Enable current event type
                    card[1].EventIcon[1].SetActive(true);
                }

                //Direction
                switch (events[currentEventIndex + 1].direction)
                {
                    case Event_.EventDirection.NONE:
                        break;
                    case Event_.EventDirection.TOP:
                        {
                            //Disable
                            card[1].Direction[1].SetActive(false);
                            card[1].Direction[2].SetActive(false);
                            card[1].Direction[3].SetActive(false);
                            //Enable
                            card[1].Direction[0].SetActive(true);
                            break;
                        }
                    case Event_.EventDirection.LEFT:
                        {
                            //Disable
                            card[1].Direction[0].SetActive(false);
                            card[1].Direction[2].SetActive(false);
                            card[1].Direction[3].SetActive(false);
                            //Enable
                            card[1].Direction[1].SetActive(true);
                            break;
                        }
                    case Event_.EventDirection.RIGHT:
                        {
                            //Disable
                            card[1].Direction[0].SetActive(false);
                            card[1].Direction[1].SetActive(false);
                            card[1].Direction[3].SetActive(false);
                            //Enable
                            card[1].Direction[2].SetActive(true);
                            break;
                        }
                    case Event_.EventDirection.BOTTOM:
                        {
                            //Disable
                            card[1].Direction[0].SetActive(false);
                            card[1].Direction[1].SetActive(false);
                            card[1].Direction[2].SetActive(false);
                            //Enable
                            card[1].Direction[3].SetActive(true);
                            break;
                        }
                    default:
                        break;
                }

                //Shield Icon
                if (events[currentEventIndex + 1].type == Event_.EventType.ENEMY_SHIP || events[currentEventIndex + 1].type == Event_.EventType.ASTEROID)
                {
                    card[1].ShieldIcon.SetActive(true);
                }
                else
                {
                    card[1].ShieldIcon.SetActive(false);
                }


                //Weapon Icon
                if (events[currentEventIndex + 1].type == Event_.EventType.ENEMY_SHIP)
                {
                    card[1].WeaponIcon.SetActive(true);
                }
                else if (events[currentEventIndex + 1].type == Event_.EventType.ASTEROID)
                {
                    card[1].WeaponIcon.SetActive(false);
                }

                //Time to hit slider
                cardSlider[1].value = events[currentEventIndex + 1].timeStamp + hitOffset - currentTimer;
            }
            else
            {
                card[1].Card_UI.SetActive(false);
            }

                
            //THIRD CARD
            if (events.Count >= 3)
            {
                //Event Type
                if (events[currentEventIndex + 2].type == Event_.EventType.ENEMY_SHIP)
                {
                    //Disable previous event type
                    card[2].EventIcon[1].SetActive(false);
                    //Enable current event type
                    card[2].EventIcon[0].SetActive(true);
                }
                else if (events[currentEventIndex + 2].type == Event_.EventType.ASTEROID)
                {
                    //Disable previous event type
                    card[2].EventIcon[0].SetActive(false);
                    //Enable current event type
                    card[2].EventIcon[1].SetActive(true);
                }

                //Direction
                switch (events[currentEventIndex + 2].direction)
                {
                    case Event_.EventDirection.NONE:
                        break;
                    case Event_.EventDirection.TOP:
                        {
                            //Disable
                            card[2].Direction[1].SetActive(false);
                            card[2].Direction[2].SetActive(false);
                            card[2].Direction[3].SetActive(false);
                            //Enable
                            card[2].Direction[0].SetActive(true);
                            break;
                        }
                    case Event_.EventDirection.LEFT:
                        {
                            //Disable
                            card[2].Direction[0].SetActive(false);
                            card[2].Direction[2].SetActive(false);
                            card[2].Direction[3].SetActive(false);
                            //Enable
                            card[2].Direction[1].SetActive(true);
                            break;
                        }
                    case Event_.EventDirection.RIGHT:
                        {
                            //Disable
                            card[2].Direction[0].SetActive(false);
                            card[2].Direction[1].SetActive(false);
                            card[2].Direction[3].SetActive(false);
                            //Enable
                            card[2].Direction[2].SetActive(true);
                            break;
                        }
                    case Event_.EventDirection.BOTTOM:
                        {
                            //Disable
                            card[2].Direction[0].SetActive(false);
                            card[2].Direction[1].SetActive(false);
                            card[2].Direction[2].SetActive(false);
                            //Enable
                            card[2].Direction[3].SetActive(true);
                            break;
                        }
                    default:
                        break;
                }

                //Shield Icon
                if (events[currentEventIndex + 2].type == Event_.EventType.ENEMY_SHIP || events[currentEventIndex + 2].type == Event_.EventType.ASTEROID)
                {
                    card[2].ShieldIcon.SetActive(true);
                }
                else
                {
                    card[2].ShieldIcon.SetActive(false);
                }


                //Weapon Icon
                if (events[currentEventIndex + 2].type == Event_.EventType.ENEMY_SHIP)
                {
                    card[2].WeaponIcon.SetActive(true);
                }
                else if (events[currentEventIndex + 2].type == Event_.EventType.ASTEROID)
                {
                    card[2].WeaponIcon.SetActive(false);
                }

                //Time to hit slider
                cardSlider[2].value = events[currentEventIndex + 2].timeStamp + hitOffset - currentTimer;
            }
            else
            {
                card[2].Card_UI.SetActive(false);
            }

        }
        else
        {
            GameObject tempObject = null;
            for (int index = 0; index < transform.childCount; index++)
            {
                tempObject = transform.GetChild(index).gameObject;
                tempObject.SetActive(false);
            }
            //return;
        }



        //if we have no events, just return
        if (events.Count == 0)
        {
            gameObject.SetActive(false);
            return;
        }

    }


    private void TempSwitchCard()
    {
        currentEventIndex++;
    }
}

[System.Serializable]
public class UI_Card
{
    public string nameOfCard;
    public GameObject Card_UI;
    [Header("Event Positions : 0 - Enemy Ship, 1 - Asteroid")]
    public GameObject[] EventIcon;
    [Header("Direction Positions : 0 - TOP, 1 - LEFT, 2 - RIGHT, 3 - BOTTOM")]
    public GameObject[] Direction;
    public GameObject ShieldIcon;
    public GameObject WeaponIcon;
    public GameObject TimeToHitSlider;
}