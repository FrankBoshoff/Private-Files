using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDetection : MonoBehaviour {

    public GameObject manager;
    public int number;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter (Collider collision)
    {
    }
    private void OnTriggerStay(Collider other)
    {
        print(other.transform.name);
        if(other.gameObject.tag == "Ball")
        {
            manager.GetComponent<RouManager>().ball = true;
            manager.GetComponent<RouManager>().rouNumber = number;

        }
        
    }

}
