using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineController : MonoBehaviour
{
    private Animator animTrampoline;
    public float jumpForce;

    void Start()
    {
        animTrampoline = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            animTrampoline.SetTrigger("Jumpping");
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}
