using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCamera : MonoBehaviour {

    public Transform car;
    public Vector3 offset = new Vector3(0, 3, -10);


    // Update is called once per frame
    void Update () {
        transform.position = car.position + offset;
	}
}
