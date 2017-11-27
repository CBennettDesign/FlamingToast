using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowIndicatorLooping : MonoBehaviour {

    public Image[] arrowObjects;
    public bool canDraw = true;

    [HideInInspector]
    public int turnOn = 0;
    [HideInInspector]
    public int turnOff = 5;

    private float timeBetweenSwitch = 0.2f;
    private float timer;

	// Use this for initialization
	void Start () {
        arrowObjects = GetComponentsInChildren<Image>();
        timer = Time.time;

        for (int j = 0; j < arrowObjects.Length; j++)
        {
            arrowObjects[j].gameObject.SetActive(false);
        }

        turnOff = arrowObjects.Length - 1;
    }
	
	// Update is called once per frame
	void Update () {

        if (Time.time - timer > timeBetweenSwitch) {
            timer = Time.time;
            arrowObjects[turnOn].gameObject.SetActive(true);
            if (arrowObjects[turnOff].gameObject != null)
            {
                arrowObjects[turnOff].gameObject.SetActive(false);
            }

            if (turnOn != arrowObjects.Length - 1)
            {
                turnOn += 1;
            } else if (turnOn == arrowObjects.Length - 1)
            {
                turnOn = 0;
            }

            if (turnOff != arrowObjects.Length - 1)
            {
                turnOff += 1;
            }
            else if (turnOff == arrowObjects.Length - 1)
            {
                turnOff = 0;
            }
        }
    }
}
