using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

public class VignetteFlash : MonoBehaviour
{
	public GameObject shieldVignette;
	public GameObject damageVignette;
    private Base_System system;

    private bool onHit;
	private bool isShieldUp;

	private float timer;

	[Range(0.1f, 1.0f)]
	public float onDisplayTime;


	private	void Start ()
	{
        system = GameObject.FindGameObjectWithTag("Base_System").GetComponent<Base_System>();

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

	public void ShipHit(bool newStatus, bool wasShieldUp, bool isEnemy)
	{
		onHit = newStatus;
		isShieldUp = wasShieldUp;

        //On Ship hit sound

        if (isEnemy)
        {
            //Enemy Sound
            if (isShieldUp)
            {
                PlayerAudio.instance.PlaySound(system.ShieldHit);
            }
            else
            {
                PlayerAudio.instance.PlaySound(system.ShipHit);
            }

        }
        else
        {
            //Asteroid Sound
            if (isShieldUp)
            {
                PlayerAudio.instance.PlaySound(system.ShieldHit);
            }
            else
            {
                PlayerAudio.instance.PlaySound(system.ShipHit);
            }
        }
	}
}
