using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

[ExecuteInEditMode]
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


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z));
    }


}
