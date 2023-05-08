using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("LoadNextLevel", 0.3f);
        }
    }

    void LoadNextLevel(){
        GameController.instace.ShowNextLvl();
    }
}
