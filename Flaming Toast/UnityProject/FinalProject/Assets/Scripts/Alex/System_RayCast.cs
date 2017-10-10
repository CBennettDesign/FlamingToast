using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/

[ExecuteInEditMode]
public class System_RayCast : MonoBehaviour
{
    //Ray Casting - Change to sphere cast, maybe?
    private RaycastHit hitInfo;
    private Ray rayCast;

    //Current Canister Connected
    private Canister currentCanister;
    //System Access point
    public Canister CurrentCanister
    {
        get { return currentCanister; }
        set { currentCanister = value; }
    }

    //Pre-Initialisation
    private void Awake()
    {
        //Raycast Line Check - Rework to a sphere cast.?
        rayCast = new Ray(transform.position, Vector3.up);

        //Default starting value
        currentCanister = null;
    }

    private void Update()
    {

    }


    public bool CheckForCanister()
    {
        ///*Logic for checking if the canister is connected. - Add later for the layer masking*/
        if (Physics.Raycast(rayCast, out hitInfo, 1.5f))
        {
            if (hitInfo.collider.tag == "Canister") // - Rework for layer masking as this inner if statement would just result in true ?
            {
                //Assign the hitInfo obj to the internal currentCanister and drain the charge from that when connected.
                //In drain the current canister only when the cannister is connected
                currentCanister = hitInfo.collider.gameObject.GetComponent<Canister>();

                Debug.Log("Canister found! " + hitInfo.collider.gameObject.name);

                //Found a canister
                return true;
            }
            else
            {
                //Reset current Canister to null - safe gaurd
                currentCanister = null;
            
                //Something other than a canister
                return false;
            }
        }
        else
        {
            if (this.transform.childCount > 0 && this.transform.GetChild(0).GetComponent<Canister>() != null)
            {
                //As the canister is snapped to the position it becomes a child of this game object.
                currentCanister = this.transform.GetChild(0).GetComponent<Canister>();
                //Found a canister
                return true;
            }
            else
            {
                //Reset current Canister to null - safe gaurd
                currentCanister = null;
                //No canister
                return false;
            }


        }
 



    }

    //Debug Visuals
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z));
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(transform.position, 0.2f);
    }

}
