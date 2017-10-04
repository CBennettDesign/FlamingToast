using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class SnaptoHolder : MonoBehaviour
{
    //Distance to pickup    
    public float pickUpDistance;
    
    //Snapping positions x, y, z
    public float xPosition;
    public float yPosition;
    public float zPosition;

    //Inhands object
    private GameObject inHands = null;

    // Lerp Speed
    public float speed = 0.2f;

    //Lerp Time
    float lerptime;
    
    //Start and end colors to lerp between
    public Color Startcolor;
    public Color Endcolor;

    //Canister game object
    GameObject canister = null;

    //Radius of sphere cast
    public float Radius = 2;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Debug to show cast line
        Debug.DrawLine(transform.position, transform.position + Vector3.forward * Radius);

        if (!canister)
        {
            //Layer mask Cap
            int layermask = 1 << LayerMask.NameToLayer("Cap");

            //Starts Sphere cast
            Collider[] colliderList = Physics.OverlapSphere(transform.position, Radius, layermask);

            if (colliderList.Length > 0)
            {
                //List of current canisters
                GameObject obj = colliderList[0].gameObject;
                
                //sets position to parents position
                obj.transform.parent = transform.transform;

                //Sets to public local positions
                obj.transform.localPosition = new Vector3(-xPosition, yPosition, -zPosition);

                //creates rigidbody component
                Rigidbody cap = obj.GetComponent<Rigidbody>();

                //Sets kinematic to true and sets velocity to 0
                cap.isKinematic = true;
                cap.velocity = Vector3.zero;
                cap.angularVelocity = Vector3.zero;

                //Rotation of object when snaped
                cap.transform.Rotate(90.0f, 0f, 0f);
                canister = obj;
            }
        }
        else
        {
            //Lerping colors when snaped
            lerptime += speed * Time.deltaTime;
            canister.GetComponent<Renderer>().material.color = Color.Lerp(Startcolor, Endcolor, lerptime);
        }
    }
}
