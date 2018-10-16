using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouManager : MonoBehaviour {

    public GameObject spawner, text, color;
    public int rouNumber, nrColor;
    public bool ball, ballInGame;

	// Use this for initialization
	void Start () {
		
	}
	
	
	void Update () {
        if(ball == true)
        {
            spawner.GetComponent<RouSpawner>().ballInGame = true;
            Debug.Log("Het nummer is" + rouNumber);
            ball = false;
            text.GetComponent<Text>().text = rouNumber.ToString();
            //color.GetComponent<Image>().color = "#730000";
        }
	}
}
