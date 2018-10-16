using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoRotator : MonoBehaviour {

    public float rotSpeed = 25f;
    //private float startPos;

	// Use this for initialization
	/*void Start () {
        startPos = Random.Range(0f, 360f);
        transform.Rotate(0,0,startPos);
	}
	*/
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0,-rotSpeed * Time.deltaTime);
	}
}
