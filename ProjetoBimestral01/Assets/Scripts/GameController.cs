using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject plataformPrefab;
    public GameObject gameOver;
    public GameObject nextLevel;

    public int totalScore;
    public Text scoreText;

    public static GameController instace;

    void Start()
    {
        instace = this;
        
        StartCoroutine(SpawnPlataform());
    }

    private IEnumerator SpawnPlataform()
    {
        Instantiate(plataformPrefab, new Vector3(20.6f, -7.6f, -3.0f), Quaternion.identity);

        yield return new WaitForSeconds(3f);
        yield return SpawnPlataform();
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString("D4");
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void ShowNextLvl()
    {
        nextLevel.SetActive(true);
    }
}
