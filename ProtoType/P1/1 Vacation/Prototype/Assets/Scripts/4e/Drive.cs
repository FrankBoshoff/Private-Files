using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour {

    public GameObject car;
    public GameObject wheels;
    public Rigidbody rBody;
    public Vector3 move;
    public float drive;
    public float steer;
	
	void Start ()
    {
        drive = Input.GetAxis("Vertical");
        steer = Input.GetAxis("Horizontal");

        //rBody. = drive;

	}

    void Update ()
    { /*
        if (Input.GetButtonDown("w") && Input.GetButtonDown("s"))
        {
            drive = transform.Translate(0,0,drive);
            transform.rotation = ;
        }
        */
        

	}
}
