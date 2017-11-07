using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPad : MonoBehaviour {

    public int code;
    float disableTimer = 0;

    private void Update()
    {
        if (disableTimer > 0)
            disableTimer -= Time.deltaTime;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && disableTimer <= 0)
        {
            foreach (TeleportPad tp in FindObjectsOfType<TeleportPad>())
            {
                if (tp.code == code && tp != this)
                {
                    tp.disableTimer = 2;
                    Vector3 Position = tp.gameObject.transform.position;
                    other.gameObject.transform.position = Position;
                }
            }
        }
    }
}
