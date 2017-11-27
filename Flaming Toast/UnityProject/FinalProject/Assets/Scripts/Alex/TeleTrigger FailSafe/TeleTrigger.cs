using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleTrigger : MonoBehaviour 
{
	private bool canSetTrue;

	private GameObject currentPlayerTrail;

 
	private void Update ()
	{
	  
	}
	

	private void ReEnableTrail()
	{
		if (canSetTrue)
		{
			currentPlayerTrail.SetActive(true);
			canSetTrue = false;
		}

		
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
		{

            Debug.Log(other.transform.name);

			currentPlayerTrail = other.gameObject.GetComponentInChildren<ParticleSystem>().gameObject;

			currentPlayerTrail.SetActive(false);

			other.transform.position = new Vector3(transform.position.x, other.transform.position.y, transform.position.z);

			canSetTrue = true;

			Invoke("ReEnableTrail", 0.25f);
		}
	}

}
