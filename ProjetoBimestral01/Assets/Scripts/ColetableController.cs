using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetableController : MonoBehaviour
{
    private SpriteRenderer fruitRender;
    private CircleCollider2D fruitCircle;

    public GameObject collected;
    public int Score = 5;

    void Start()
    {
        fruitRender = GetComponent<SpriteRenderer>();
        fruitCircle = GetComponent<CircleCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            fruitCircle.enabled = false;
            fruitRender.enabled = false;
            collected.SetActive(true);

            GameController.instace.totalScore += Score;
            GameController.instace.UpdateScoreText();

            Destroy(gameObject, 0.25f);
        }
    }
}
