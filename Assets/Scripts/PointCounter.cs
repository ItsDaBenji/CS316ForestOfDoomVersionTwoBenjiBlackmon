using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text pointScoreCounter;

    public Text livesCounter;

    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("MrManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        pointScoreCounter.text = "Score: " + gameManager.highScore;
        livesCounter.text = "Lives: " + gameManager.numLivesLeft;
    }
}