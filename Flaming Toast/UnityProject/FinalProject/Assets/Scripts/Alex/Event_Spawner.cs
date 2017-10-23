using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class Event_Spawner : MonoBehaviour
{


    private float timer;
    private float spawnDelayTimer;

    public GameObject asteroid;
    public GameObject enemyShip;
    
    private bool currentState;

    private Event_.EventType currentEventType;
    public Event_.EventDirection currentEventDirection;

    private void Awake()
    {
        //When zero, set to something large so when an event happens this value is changed.
        //If no events spawn, its because this value was not changed.
        if (spawnDelayTimer == 0.0f)
        {
            spawnDelayTimer = 1000.0f;
        }
    }

    //User Input || !Physics
    private void Update()
    {
        if (currentState)
        {
            timer += Time.deltaTime;
            if (timer >= spawnDelayTimer)
            {
                //What event to spawn from the spawn location (here)
                switch (currentEventType)
                {
                    case Event_.EventType.NONE:
                        {
                            Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube), transform.position + new Vector3(0, 2, 0), Quaternion.identity);
                            break;
                        }
                    case Event_.EventType.ENEMY_SHIP:
                        {
                            Instantiate(enemyShip, transform.position + new Vector3(0, 2, 0), Quaternion.identity, transform);
                            break;
                        }
                    case Event_.EventType.ASTEROID:
                        {
                            Instantiate(asteroid, transform.position + new Vector3(0, 2, 0), Quaternion.identity, transform);
                            break;
                        }
                    default:
                        break;
                }

                timer = 0.0f;
                currentState = false;
            }
        }

       
                    
    }

 
    public void SpawnEvent(bool state, Event_.EventType eventType, Event_.EventDirection eventDirection, float delayTimer)
    {
        currentState = state;
        currentEventType = eventType;
        currentEventDirection = eventDirection;
        spawnDelayTimer = delayTimer;
    }
}

