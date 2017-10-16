﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class Event_Spawner : MonoBehaviour
{
    [Range(0,15)]
    public float delayTimer;

    private float timer;

    public GameObject asteroid;
    public GameObject enemyShip;
    
    private bool currentState;

    private Event_.EventType currentEventType;


    //Pre-Initialisation
    private void Awake()
    {
         
    }

    //Main-Initialisation
    private void Start()
    {

    }


    //Physics
    private void FixedUpdate()
    {

    }



    //User Input || !Physics
    private void Update()
    {
        if (currentState)
        {
            timer += Time.deltaTime;
            if (timer >= delayTimer)
            {
                //What event to spawn from the spawn location (here)
                switch (currentEventType)
                {
                    case Event_.EventType.NONE:
                        {
                            Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube), transform.position + new Vector3(0, 2, 0), Quaternion.identity);
                        }
                        break;
                    case Event_.EventType.ENEMY_SHIP:
                        {
                            Instantiate(enemyShip, transform.position + new Vector3(0, 2, 0), Quaternion.identity);
                        }
                        break;
                    case Event_.EventType.ASTEROID:
                        {
                            Instantiate(asteroid, transform.position + new Vector3(0, 2, 0), Quaternion.identity);
                        }
                        break;
                    default:
                        break;
                }

                currentState = false;
            }
        }

       
                    
    }

 
    public void SpawnEvent(bool state, Event_.EventType eventType)
    {
        currentState = state;
        currentEventType = eventType;
    }
}
