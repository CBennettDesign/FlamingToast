using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode] - The name of the element in the list equals the name of the name element
public class Event_System_Manager : MonoBehaviour
{
    public List<Event_> events = new List<Event_>();

    private float timer;

    //Pre-Initialisation
    private void Awake()
    {
        timer = 0.0f;
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
        timer += Time.deltaTime;

        foreach (var ev in events)
        {
            if (timer >= ev.timeStamp && !ev.BeenUsed)
            {
                Debug.Log("Incoming: " + ev.type + " from: " + ev.direction);
                ev.BeenUsed = true;
            }
        }
                


    }

    //Animations || !Important
    private void LateUpdate()
    {

    }

}//End of ESM Script

[System.Serializable]
public class Event_
{
    void Start()
    {
        Debug.Log("Start");
    }

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
        RIGHT,
        LEFT,
        TOP_RIGHT,
        TOP_LEFT,
        BOTTOM_RIGHT,
        BOTTOM_LEFT
    }
    public EventDirection direction;

    [Header("Time in seconds when the event will happen. [0 to 300]")]
    [Range(0,300)]
    public int timeStamp;

    //When the event has been used - Or just remove it from the list
    private bool hasBeenUsed;
    public bool BeenUsed
    {
        get { return hasBeenUsed; }
        set { hasBeenUsed = value; }
    }

}

