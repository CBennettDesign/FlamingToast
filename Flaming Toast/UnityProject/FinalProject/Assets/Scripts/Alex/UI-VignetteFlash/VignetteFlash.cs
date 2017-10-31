using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class VignetteFlash : MonoBehaviour
{
	public GameObject shieldVignette;
	public GameObject damageVignette;
 
    private bool onHit;
	private bool isShieldUp;

	private float timer;

	[Range(0.1f, 1.0f)]
	public float onDisplayTime;


	private	void Start ()
	{
		 

		if (shieldVignette == null || damageVignette == null)
		{
			Debug.Log("No image attached for the vignette flash");
		}

        shieldVignette.SetActive(false);
        damageVignette.SetActive(false);

    }
	
	
	private void Update ()
	{
		if (onHit)
		{
			timer += Time.deltaTime;

			if (isShieldUp)
			{
				shieldVignette.SetActive(true);
			}
			else
			{
				damageVignette.SetActive(true);
			}

			if (timer >= onDisplayTime)
			{
				timer = 0.0f;
				onHit = false;
				shieldVignette.SetActive(false);
				damageVignette.SetActive(false);
			}
		}
	}

	public void ShipHit(bool newStatus, bool wasShieldUp)
	{
		onHit = newStatus;
		isShieldUp = wasShieldUp;
	}
}
