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
    { get { return currentCanister; } }

    //Pre-Initialisation
    private void Awake()
    {
        //Raycast Line Check - Rework to a sphere cast.?
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
        /*Logic for checking if the canister is connected. - Add later for the layer masking*/
        if (Physics.Raycast(rayCast, out hitInfo, 0.5f))
        {
            if (hitInfo.collider.tag == "Canister") // - Rework for layer masking as this inner if statement would just result in true 
            {
                //Assign the hitInfo obj to the internal currentCanister and drain the charge from that when connected.
                //In drain the current canister only when the cannister is connected
                currentCanister = hitInfo.collider.gameObject.GetComponent<Canister>();

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
            //Reset current Canister to null - safe gaurd
            currentCanister = null;
            //No canister
            return false;
        }
    }

    //Debug Visuals
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z));
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(transform.position, 0.1f);
    }

}
