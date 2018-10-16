using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDetection : MonoBehaviour {

    public GameObject manager;
    public int number, nrColor;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            manager.GetComponent<RouManager>().rouNumber = number;
            manager.GetComponent<RouManager>().nrColor = nrColor;
            manager.GetComponent<RouManager>().ball = true;
        }

    }

}
