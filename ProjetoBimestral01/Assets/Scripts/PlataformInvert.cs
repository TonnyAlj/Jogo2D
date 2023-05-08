using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformInvert : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool plataform;

    public bool moveUp = true;

    void Update()
    {
        if(plataform)
        {
            if(transform.position.y > 11)
            {
                moveUp = false;
                Destroy(gameObject);
            }
            else if(transform.position.y < -8.1f)
            {
                moveUp = true;
            }

            if(moveUp)
            {
                transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
            }
            else 
            {
                transform.Translate(Vector2.up * -moveSpeed * Time.deltaTime);
            }
        }
    }
}
