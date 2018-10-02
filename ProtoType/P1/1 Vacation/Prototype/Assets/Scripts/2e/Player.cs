using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Vector3 movePos;
    public float walkSpeed;
    private float movPlyrX;
    private float movPlyrY;

    private CharacterController controller;

    private float verticalVelocity;
    private float gravity = 14.0f;
    private float jumpForce = 10.0f;



    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

	void FixedUpdate ()
    {
        Movement(movePos, walkSpeed);
//        Jump();
	}

    public void Movement(Vector3 mover, float speed)
    {
        mover.x = Input.GetAxis("Horizontal");
        mover.z = Input.GetAxis("Vertical");
        transform.Translate(mover * speed * Time.deltaTime);

    }



//    private void Jump()
//    {
//        if (controller.isGrounded)
//        {
//            verticalVelocity = -gravity * Time.deltaTime;
//            if (Input.GetKeyDown(KeyCode.Space))
//            {
//                verticalVelocity = jumpForce;
//            }
//        }
//        else
//        {
//            verticalVelocity -= gravity * Time.deltaTime;
//        }
//        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
//        controller.move(moveVector * Time.deltaTime);
//    }

}
