using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public Rigidbody rb;
    public Vector3 v;
    public float fForce = 20f;
    public float sForce = 7f;
    public float drive;
    public float steer;

    /*	void Start ()
        {
            //        rb.useGravity = false;
    //        rb.AddForce(0, 200, 500);
        }*/

    private void Start()
    {
        /*
        drive = Input.GetAxis("Vertical");
        steer = Input.GetAxis("Horizontal");
        rb = GetComponent<Rigidbody>();
        */
    }

    void FixedUpdate ()
    {
        Movement(v, fForce);


    //    rb.AddForce(0, 0, fForce * Time.deltaTime);
    /*
        if (Input.GetAxis("Vertical") != 0)
        {
            //rb.AddForce(fForce * drive * Time.deltaTime, 0, 0);
            print("Drive");
            v.z = transform.forward * drive * fForce;
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            //rb.AddForce(sForce* steer * Time.deltaTime, 0,0) ;
            print("steer");
            Quaternion target = Quaternion.Euler(0, steer, 0);
        }*/
    }

    private void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag == "Obstacle")
        {
            fForce = 0f;
            sForce = 0f;
        }
    }

    public void Movement(Vector3 mover, float speed)
    {
        mover.x = Input.GetAxis("Horizontal");
        mover.y = -Input.GetAxis("Vertical");
        transform.Translate(mover * speed * Time.deltaTime);

    }

}
