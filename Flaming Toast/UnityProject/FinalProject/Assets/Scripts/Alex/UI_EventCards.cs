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
    [HideInInspector]
    public float hitOffset;

    //Transform positions for the cards to be in.
    //public GameObject[] cardPosition;

    private CardSwitcher cardSwitcher;

    //New Cards
    public UI_Card[] card;



    private Event_System_Manager evm;
    private bool activatedCards;


 
    private void Awake()
    {
        cardSwitcher = GetComponent<CardSwitcher>();

        //Iterate over all cards and populate the information.
        for (int cardIndex = 0; cardIndex < card.Length - 1; cardIndex++)
        {

            //Incoming Card - First Card
            card[cardIndex].Card_UI = transform.GetChild(cardIndex).transform.gameObject;
            //Incoming Card - First Card -> Ship
            card[cardIndex].EventIcon = transform.GetChild(cardIndex).transform.GetChild(0).gameObject;
            //Incoming Card - First Card -> Direction - TOP(1), LEFT(2), RIGHT(3), BOTTOM(4)
            card[cardIndex].Direction = new GameObject[4];
            card[cardIndex].Direction[0] = transform.GetChild(cardIndex).transform.GetChild(1).gameObject;
            card[cardIndex].Direction[1] = transform.GetChild(cardIndex).transform.GetChild(2).gameObject;
            card[cardIndex].Direction[2] = transform.GetChild(cardIndex).transform.GetChild(3).gameObject;
            card[cardIndex].Direction[3] = transform.GetChild(cardIndex).transform.GetChild(4).gameObject;
            //Incoming Card - First Card -> Shield Icon
            card[cardIndex].ShieldIcon = transform.GetChild(cardIndex).transform.GetChild(5).gameObject;
            //Incoming Card - First Card -> Weapon Icon
            card[cardIndex].WeaponIcon = transform.GetChild(cardIndex).transform.GetChild(6).gameObject;
            //Incoming Card - First Card -> Countdown Time
            card[cardIndex].TimeToHit = transform.GetChild(cardIndex).transform.GetChild(7).gameObject.GetComponent<Text>();
            
        }
        
    }

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

       

    }

    private void NewCardSetup()
    {

        //* Load data into the new card.  
            //Incoming Card - cardPrefab Card
            card[3].Card_UI = cardSwitcher.tempCard.transform.gameObject; //needs to be set to the new card's gameobjct.
            //Incoming Card - cardPrefab Card -> Ship
            card[3].EventIcon = cardSwitcher.tempCard.transform.GetChild(0).gameObject;
            //Incoming Card - cardPrefab Card -> Direction - TOP(1), LEFT(2), RIGHT(3), BOTTOM(4)
            card[3].Direction = new GameObject[4];
            card[3].Direction[0] = cardSwitcher.tempCard.transform.GetChild(1).gameObject;
            card[3].Direction[1] = cardSwitcher.tempCard.transform.GetChild(2).gameObject;
            card[3].Direction[2] = cardSwitcher.tempCard.transform.GetChild(3).gameObject;
            card[3].Direction[3] = cardSwitcher.tempCard.transform.GetChild(4).gameObject;
            //Incoming Card - cardPrefab Card -> Shield Icon
            card[3].ShieldIcon = cardSwitcher.tempCard.transform.GetChild(5).gameObject;
            //Incoming Card - cardPrefab Card -> Weapon Icon
            card[3].WeaponIcon = cardSwitcher.tempCard.transform.GetChild(6).gameObject;
            //Incoming Card - cardPrefab Card -> Countdown Time
            card[3].TimeToHit = cardSwitcher.tempCard.transform.GetChild(7).gameObject.GetComponent<Text>();


        cardSwitcher.canMove = true;

        //Ian's reccomendations
        // split CardSwitcher code into a separate component on Incoming Events - UI Cards object - Card Positions list / []
        // create CardUIMover on each of the Incoming Card objects to handle the movement from position to position. Move Towards
        // CardSwitcher will hold (or can access) a list of the CardUIMover scripts and will tell each one where move. 

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
                //Make a new card
                cardSwitcher.NewCard();
                //Load in the gameObjects for the new card - icons etc
                NewCardSetup();

                events.RemoveAt(0);
            }
 
 
            //FIRST CARD
            if (events.Count >= 1)
            {
                FirstCard();
                //CurrentCardInfomation(0);
            }
            else
            {
                card[0].Card_UI.SetActive(false);
            }


            //SECOND CARD
            if (events.Count >= 2)
            {
                SecondCard();
                //CurrentCardInfomation(1);
            }
            else
            {
                card[1].Card_UI.SetActive(false);
            }

                
            //THIRD CARD
            if (events.Count >= 3)
            {
                ThirdCard();
                //CurrentCardInfomation(2);
            }
            else
            {
                card[2].Card_UI.SetActive(false);
            }

        }
        else
        {
            //Events not running
            GameObject tempObject = null;
            for (int index = 0; index < transform.childCount; index++)
            {
                tempObject = transform.GetChild(index).gameObject;
                tempObject.SetActive(false);
            }
        }



        //if we have no events, just return
        if (events.Count == 0)
        {
            gameObject.SetActive(false);
            return;
        }

    }


    public void DeleteCard()
    {
        for (int index = 0; index < card.Length - 1; index++)
        {
            card[index] = card[index + 1];
        }
        card[card.Length - 1] = new UI_Card();
    }


    //Re-Work for a better solution, less repeating code
    private void FirstCard()
    {
        //Event Type
        //Enable current event type
        card[0].EventIcon.SetActive(true);

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

        //Time to hit 
        card[0].TimeToHit.text = (events[currentEventIndex].timeStamp + hitOffset - currentTimer).ToString("0.00");
    }

    private void SecondCard()
    {
        //Event Type 
        //Enable current event type
        card[1].EventIcon.SetActive(true);

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

        //Time to hit 
        card[1].TimeToHit.text = (events[currentEventIndex + 1].timeStamp + hitOffset - currentTimer).ToString("0.00");
    }

    private void ThirdCard()
    {
        //Event Type
        //Enable current event type
        card[2].EventIcon.SetActive(true);

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

        //Time to hit 
        card[2].TimeToHit.text = (events[currentEventIndex + 2].timeStamp + hitOffset - currentTimer).ToString("0.00");
    }


    private void CurrentCardInfomation(int currentCardIndex)
    {
        //Event Type
        //Enable current event type
        card[currentCardIndex].EventIcon.SetActive(true);

        //Direction
        switch (events[currentEventIndex].direction)
        {
            case Event_.EventDirection.NONE:
                break;
            case Event_.EventDirection.TOP:
                {
                    //Disable
                    card[currentCardIndex].Direction[1].SetActive(false);
                    card[currentCardIndex].Direction[2].SetActive(false);
                    card[currentCardIndex].Direction[3].SetActive(false);
                    //Enable
                    card[currentCardIndex].Direction[0].SetActive(true);

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
                    card[currentCardIndex].Direction[0].SetActive(false);
                    card[currentCardIndex].Direction[2].SetActive(false);
                    card[currentCardIndex].Direction[3].SetActive(false);
                    //Enable
                    card[currentCardIndex].Direction[1].SetActive(true);

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
                    card[currentCardIndex].Direction[0].SetActive(false);
                    card[currentCardIndex].Direction[1].SetActive(false);
                    card[currentCardIndex].Direction[3].SetActive(false);
                    //Enable
                    card[currentCardIndex].Direction[2].SetActive(true);

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
                    card[currentCardIndex].Direction[0].SetActive(false);
                    card[currentCardIndex].Direction[1].SetActive(false);
                    card[currentCardIndex].Direction[2].SetActive(false);
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
            card[currentCardIndex].ShieldIcon.SetActive(true);
        }
        else
        {
            card[currentCardIndex].ShieldIcon.SetActive(false);
        }


        //Weapon Icon
        if (events[currentEventIndex].type == Event_.EventType.ENEMY_SHIP)
        {
            card[currentCardIndex].WeaponIcon.SetActive(true);
        }
        else if (events[currentEventIndex].type == Event_.EventType.ASTEROID)
        {
            card[currentCardIndex].WeaponIcon.SetActive(false);
        }

        //Time to hit 
        card[currentCardIndex].TimeToHit.text = (events[currentEventIndex].timeStamp + hitOffset - currentTimer).ToString("0.00");
    }

}

[System.Serializable]
public class UI_Card
{
    public string nameOfCard;
    public GameObject Card_UI;
    [Header("Event Positions : 0 - Enemy Ship, 1 - Asteroid")]
    public GameObject EventIcon;
    [Header("Direction Positions : 0 - TOP, 1 - LEFT, 2 - RIGHT, 3 - BOTTOM")]
    public GameObject[] Direction;
    public GameObject ShieldIcon;
    public GameObject WeaponIcon;
    public Text TimeToHit;
}