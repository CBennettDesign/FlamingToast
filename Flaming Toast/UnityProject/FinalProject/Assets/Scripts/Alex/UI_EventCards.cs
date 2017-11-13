using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*- Alex Scicluna -*/

public class UI_EventCards : MonoBehaviour
{

    private float currentTimer;

    //Events
    public List<Event_> events = new List<Event_>();
    private int currentEventIndex;

    [HideInInspector]
    [Range(0, 10)]
    public float hitOffset;

    //UI Elements
    public GameObject[] eventCards;
    public Text[] eventCard_TYPE;
    public Text[] eventCard_DIRECTION;
    public Text[] eventCard_TIME;

    private Event_System_Manager evm;

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


        if (eventCards == null)
        {
            Debug.Log("Array of cards was empty");
        }

        int localCount = 0;
        foreach (GameObject card in eventCards)
        {
            //eCard_TYPE[localCount].gameObject.AddComponent<Text>();
            eventCard_TYPE[localCount] = card.transform.GetChild(1).GetComponent<Text>();
            eventCard_DIRECTION[localCount] = card.transform.GetChild(2).GetComponent<Text>();
            eventCard_TIME[localCount] = card.transform.GetChild(3).GetComponent<Text>();
            localCount++;
        }

            
	}
	
	
    private	void Update ()
    {
        if (evm.RunEvents)
        {
            GameObject tempObject = null;
            for (int index = 0; index < transform.childCount; index++)
            {
                tempObject = transform.GetChild(index).gameObject;
                if (!tempObject.active)
                {
                    tempObject.SetActive(true);
                }

            }

            currentTimer += Time.deltaTime;

            //reached the soonest event
            if (currentTimer >= events[currentEventIndex].timeStamp + hitOffset)
            {
                //TempSwitchCard();
                //currentEventIndex++;
                events.RemoveAt(0);
            }

            //First card
            if (events.Count >= 1)
            {
                eventCard_TYPE[currentEventIndex].text = events[currentEventIndex].type.ToString();
                eventCard_DIRECTION[currentEventIndex].text = events[currentEventIndex].direction.ToString();
                eventCard_TIME[currentEventIndex].text = (events[currentEventIndex].timeStamp - currentTimer + hitOffset).ToString("0.00");
            }
            else
            {
                eventCards[0].SetActive(false);
            }


            if (events.Count >= 2)
            {

                //Second card
                eventCard_TYPE[1].text = events[currentEventIndex + 1].type.ToString();
                eventCard_DIRECTION[1].text = events[currentEventIndex + 1].direction.ToString();
                eventCard_TIME[1].text = (events[currentEventIndex + 1].timeStamp - currentTimer + hitOffset).ToString("0.00");
            }
            else
            {
                eventCards[1].SetActive(false);
            }


            if (events.Count >= 3)
            {
                //Third card
                eventCard_TYPE[2].text = events[currentEventIndex + 2].type.ToString();
                eventCard_DIRECTION[2].text = events[currentEventIndex + 2].direction.ToString();
                eventCard_TIME[2].text = (events[currentEventIndex + 2].timeStamp - currentTimer + hitOffset).ToString("0.00");

            }
            else
            {
                eventCards[2].SetActive(false);
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
