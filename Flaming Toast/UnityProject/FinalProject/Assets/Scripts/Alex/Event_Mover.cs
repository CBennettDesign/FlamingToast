using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_Mover : MonoBehaviour
{

    public GameObject powerCore;


    private float eventMoveSpeed;

    Rigidbody rigidBody;



    //Pre-Initialisation
    private void Awake()
    {
        eventMoveSpeed = 4.0f;

        this.gameObject.AddComponent<Rigidbody>();
    }

    //Main-Initialisation
    private void Start()
    {

        //Get the rigidBody Component
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
        powerCore = GameObject.FindGameObjectWithTag("Power_Core");
    }


    //Physics
    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + (powerCore.transform.position - transform.position) * Time.fixedDeltaTime);
    }

    //User Input || !Physics
    private void Update()
    {

    }

    //Animations || !Important
    private void LateUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }

}

