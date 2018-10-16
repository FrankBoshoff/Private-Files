using System.Collections;
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

    private void Update()
    {
        if(restart == true)
        {
            print("destroyed");
            Destroy(gameObject, 3);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.transform.name);
    }

}
