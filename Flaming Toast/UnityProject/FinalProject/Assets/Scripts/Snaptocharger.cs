using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class Snaptocharger : MonoBehaviour
{

    public float pickUpDistance;
    public float xPosition;
    public float yPosition;
    public float zPosition;
    private GameObject inHands = null;
    float startTime;
    public float speed = 0.5f;
    float lerptime;
    public Color Startcolor;
    public Color Endcolor;
    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit info;
        int layermask = 1 << LayerMask.NameToLayer("Cap");
        if (XCI.GetButtonDown(XboxButton.B))
        {
            if (Physics.SphereCast(transform.position, 0.5f, transform.forward, out info, pickUpDistance, layermask))
            {
                GameObject obj = info.collider.gameObject;
                obj.transform.parent = transform.transform;
                obj.transform.localPosition = new Vector3(-xPosition, yPosition, -zPosition);
                Rigidbody cap = obj.GetComponent<Rigidbody>();
                cap.isKinematic = true;
                cap.velocity = Vector3.zero;
                cap.angularVelocity = Vector3.zero;
                cap.transform.Rotate(90.0f, 0f, 0f);
                lerptime += speed * Time.deltaTime;

                cap.GetComponent<Renderer>().material.color = Color.Lerp(Startcolor, Endcolor, lerptime);
                
            }
        }
    }
}
