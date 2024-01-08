using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisionsX : MonoBehaviour
{

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (gameObject.CompareTag("Ball"))
        {
            gameManager.CatchBall();
        }

        Destroy(gameObject);
    }
}
