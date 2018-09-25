using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public GameObject manager;
    public GameObject other;

	void OnTriggerEnter (Collider ok)
    {
        print("OK");
        if (ok.gameObject.tag == "Player")
        {
            print("hii");
            Destroy(other);
            Destroy(gameObject);
        }
	}
	
}
