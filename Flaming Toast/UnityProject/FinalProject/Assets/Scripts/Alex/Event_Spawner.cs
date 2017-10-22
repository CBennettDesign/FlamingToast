using System.Collections;
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
    public Event_.EventDirection currentEventDirection;


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
                            Instantiate(enemyShip, transform.position + new Vector3(0, 2, 0), Quaternion.identity, transform);
                        }
                        break;
                    case Event_.EventType.ASTEROID:
                        {
                            Instantiate(asteroid, transform.position + new Vector3(0, 2, 0), Quaternion.identity, transform);
                        }
                        break;
                    default:
                        break;
                }

                currentState = false;
            }
        }

       
                    
    }

 
    public void SpawnEvent(bool state, Event_.EventType eventType, Event_.EventDirection eventDirection)
    {
        currentState = state;
        currentEventType = eventType;
        currentEventDirection = eventDirection;
    }
}

