using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunctionBoxNear : MonoBehaviour {

	[Range(1,10)]
	public int distanceAwayFromJunctionBox;

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
        aButtonToolTip.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        foreach (var jBoxLoc in junctionBoxes)
        {
            Vector3 vecBetween = (jBoxLoc.transform.position - this.transform.position).normalized;

            if (vecBetween.magnitude < distanceAwayFromJunctionBox)
            {
                aButtonToolTip.SetActive(true);
            }
            else
            {
                aButtonToolTip.SetActive(false);
            }
        }
	}
}
