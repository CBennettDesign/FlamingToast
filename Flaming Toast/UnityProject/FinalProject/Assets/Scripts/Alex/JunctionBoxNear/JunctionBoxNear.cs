using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*- Alex Scicluna -*/

public class JunctionBoxNear : MonoBehaviour {

	[Range(0,5)]
	public float toolTipDistance;

    public List<GameObject> junctionBoxes;

    public GameObject aButtonToolTip;

    private Event_System_Manager evm;

	void Start ()
	{
        GameObject[] tempJbox = GameObject.FindGameObjectsWithTag("jBox");

        evm = GameObject.FindGameObjectWithTag("Event_System_Manager").GetComponent<Event_System_Manager>();

        foreach (GameObject jBox in tempJbox)
        {
            junctionBoxes.Add(jBox);
        }

        aButtonToolTip.GetComponent<Image>().enabled = false;

    }
	
 
	void Update ()
	{

        if (!evm.RunEvents)
        {
            return;
        }

        aButtonToolTip.transform.rotation = Quaternion.Euler(new Vector3(90, 90, 90));

        GameObject closestGO = null;
        float closestDist = float.MaxValue;


        foreach (var jBoxLoc in junctionBoxes)
        {
            Vector3 vecBetween = (jBoxLoc.transform.position - this.transform.position);

            float distance = vecBetween.magnitude;

            if(distance < closestDist)
            {
                closestDist = distance;
                closestGO = jBoxLoc;
            }

        }

        if (closestDist < toolTipDistance)
        {
            aButtonToolTip.GetComponent<Image>().enabled = true;
        }
        else
        {
            aButtonToolTip.GetComponent<Image>().enabled = false;
        }
        
	}
}
