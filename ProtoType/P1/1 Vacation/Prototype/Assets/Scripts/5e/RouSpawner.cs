using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouSpawner : MonoBehaviour {

    public GameObject ball, manager;
    public bool ballInGame;

    private void Start()
    {
        
    }


    public void BallSpawn()
    {
        if(ballInGame == true)
        {
            Destroy(GameObject.FindGameObjectWithTag("Ball"));
            manager.GetComponent<RouManager>().ballInGame = true;
            ballInGame = false;
            Instantiate(ball);

        }
    }

}
