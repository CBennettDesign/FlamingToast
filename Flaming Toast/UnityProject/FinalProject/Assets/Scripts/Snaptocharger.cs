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
    GameObject canister = null;
    public float Radius = 2;
    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, transform.position + Vector3.forward * Radius);

        if (!canister)
        {
            int layermask = 1 << LayerMask.NameToLayer("Cap");
            Collider[] colliderList = Physics.OverlapSphere(transform.position, Radius, layermask);
            if (colliderList.Length > 0)
            {
                GameObject obj = colliderList[0].gameObject;
                obj.transform.parent = transform.transform;
                obj.transform.localPosition = new Vector3(-xPosition, yPosition, -zPosition);
                Rigidbody cap = obj.GetComponent<Rigidbody>();
                cap.isKinematic = true;
                cap.velocity = Vector3.zero;
                cap.angularVelocity = Vector3.zero;
                cap.transform.Rotate(90.0f, 0f, 100f);
                canister = obj;
            }
        }
        else
        {
            lerptime += speed * Time.deltaTime;
            canister.GetComponent<Renderer>().material.color = Color.Lerp(Startcolor, Endcolor, lerptime);
        }
    }
}
