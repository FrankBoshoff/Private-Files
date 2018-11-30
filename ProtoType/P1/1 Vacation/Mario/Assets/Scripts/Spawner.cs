using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    GameObject item;
    public bool spawner;
    Vector3 pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
    {
        if (spawner == true)
        {
            Instantiate(item, pos, Quaternion.identity);
            spawner = false;
        }   
	}
}
