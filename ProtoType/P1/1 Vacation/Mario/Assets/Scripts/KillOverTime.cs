using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOverTime : MonoBehaviour {
    public float time;
    public bool kill;
	
	void Update () {
        if(kill == true)
        {
        Destroy(gameObject, time);

        }
	}
}
