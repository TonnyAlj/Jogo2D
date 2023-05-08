using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{     
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.gameObject.SetActive(false);
            Invoke("LoadGameOver", 0.5f);
            
        }
    }
    void LoadGameOver()
    {
        GameController.instace.ShowGameOver();      
    }
}
