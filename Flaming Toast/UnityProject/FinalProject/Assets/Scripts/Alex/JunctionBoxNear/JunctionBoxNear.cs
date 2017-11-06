using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JunctionBoxNear : MonoBehaviour {

	[Range(0,5)]
	public float toolTipDistance;

    public List<GameObject> junctionBoxes;

    public GameObject aButtonToolTip;


	void Start ()
	{
        GameObject[] tempJbox = GameObject.FindGameObjectsWithTag("jBox");


        foreach (GameObject jBox in tempJbox)
        {
            junctionBoxes.Add(jBox);
        }

    }
	
 
	void Update ()
	{
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
