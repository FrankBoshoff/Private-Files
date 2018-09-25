using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Vector3 moveV;
    public int speed;
    public int kill;
    public int mana;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
        Shoot();
	}

    void Move()
    {
        moveV.x = Input.GetAxis("Horizontal");
        moveV.y = Input.GetAxis("Vertical");
        transform.Translate(moveV * speed * Time.deltaTime);
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            print("Smash");
        }
        else
        {
            print("Not Enough mana");
        }
    }
}
