using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlataform : MonoBehaviour
{

    public float fallingTime;
    private TargetJoint2D target;
    private BoxCollider2D boxCollider;

    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("Falling", fallingTime);
    }

    void Falling()
    {
        target.enabled = false;
        boxCollider.isTrigger = true;
    }
}
