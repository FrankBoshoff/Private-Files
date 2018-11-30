using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Vector3 posistion;
    public float speed = 10f;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Move();
	}

    void Move()
    {
        posistion.x = Input.GetAxis("Horizontal");
        posistion.z = Input.GetAxis("Vertical");
        transform.Translate(speed * posistion * Time.deltaTime);
    }
}
