using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouManager : MonoBehaviour {

    public int rouNumber;
    public bool ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(ball == true)
        {
            Debug.Log("Het nummer is" + rouNumber);
        }
	}
}
