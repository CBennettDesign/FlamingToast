using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using XboxCtrlrInput;

public class Request_Canister : MonoBehaviour
{
    
    //Ray Casting - Change to sphere cast, maybe?
    private RaycastHit hitInfo;
    private Ray rayCast;
    public XboxController Controlers;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update ()
    {
        rayCast = new Ray(transform.position + Vector3.up * 1.0f, transform.forward);


            
        if (XCI.GetButtonDown(XboxButton.A, Controlers))
        {
            if (Physics.Raycast(rayCast, out hitInfo, 0.5f))
            {
                if (hitInfo.collider.tag == "Canister_Depot") // - Rework for layer masking as this inner if statement would just result in true ?
                {
                    Debug.Log("Canister Depot found! " + hitInfo.collider.gameObject.name);
                    hitInfo.collider.gameObject.GetComponent<Canister_Depot>().CanSpawnCansiter = true;
                }
 
            }
        }
    }

    //Debug Visuals
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position + Vector3.up * 1.0f, transform.position + Vector3.up * 1.0f + transform.forward * 0.5f);
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(transform.position + Vector3.up * 1.0f, 0.2f);
    }
}
