using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanisterSlot : MonoBehaviour
{

    RaycastHit hitInfo;
    Ray rayCast;

    //Pre-Initialisation
    private void Awake()
    {
        rayCast = new Ray(transform.position, Vector3.up);
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

    }

    //Animations || !Important
    private void LateUpdate()
    {
        Debug.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z), Color.red);
    }

    public bool CheckForCanister()
    {

        /*Logic for checking if the canister is connected.*/
        if (Physics.Raycast(rayCast, out hitInfo, 1.5f))
        {
            if (hitInfo.collider.tag == "Canister")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }

    }
}
