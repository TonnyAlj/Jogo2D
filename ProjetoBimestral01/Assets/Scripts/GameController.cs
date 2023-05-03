using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int totalScore;
    public Text scoreText;

    public static GameController instace;

    void Start()
    {
        instace = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString("D4");
    }

    
}