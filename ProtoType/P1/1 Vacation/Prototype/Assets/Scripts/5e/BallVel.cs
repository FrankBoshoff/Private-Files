﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVel : MonoBehaviour {

    public float speed;
    Rigidbody rb;
    public bool restart;

	void Start ()
    {
        speed = Random.Range(5f, 14f);
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, speed);
    }

}
