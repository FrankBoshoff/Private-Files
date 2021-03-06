﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float inputDelay = 0.1f;
    public float forwardVel = 12;
    public float rotateVel = 100;
    public Vector3 velocity = Vector3.zero;

    Quaternion targetRotation;
    Rigidbody rBody;
    float forwardInput, turnInput;

    public Quaternion TargetRotation
    {
        get { return targetRotation; }
    }

    void Start()
    {
        targetRotation = transform.rotation;
        if (GetComponent<Rigidbody>())
        {
            rBody = GetComponent<Rigidbody>();
        }
        else
        {
            Debug.LogError("Character heeft geen rigibudy");
        }

        forwardInput = turnInput = 0f;
    }

    void GetInput()
    {
        forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }

    void Update()
    {
        GetInput();
        Turn();
    }

    void FixedUpdate()
    {
        Run();
        Jump();
    }

    void Run()
    {
        if(Mathf.Abs(forwardInput) > inputDelay)
        {
            rBody.velocity = transform.forward * forwardInput * forwardVel;
        }
        else
        {
            rBody.velocity = Vector3.zero;
        }
    }

    void Turn()
    {
    //    if (Mathf.Abs(turnInput) > inputDelay)
   //     {
            targetRotation *= Quaternion.AngleAxis(rotateVel * turnInput * Time.deltaTime, Vector3.up);
 //       }
            transform.rotation = targetRotation;
    }

    void Jump()
    {

    }
}
