using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment2D : MonoBehaviour
{

    private float move;
    [SerializeField] private float moveSpeed = 3;

    [SerializeField] private bool jumping;
    [SerializeField] private float jumpSpeed = 12;

    [SerializeField]private bool isGrounded;
    public Transform feetPosition;
    public float sizeRadius;
    public LayerMask whatIsGround;


    private Rigidbody2D rb;
    SpriteRenderer sprite;
    private Animator animationPlayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite =  GetComponent<SpriteRenderer>();
        animationPlayer = GetComponent<Animator>();
    }

    void Update()
    {
        //Reconhece o chão
        isGrounded = Physics2D.OverlapCircle(feetPosition.position, sizeRadius, whatIsGround);
        //Input de movimentação do personagem
        move = Input.GetAxis("Horizontal");

        //Input de pulo para o personagem
        if(Input.GetButtonDown("Jump") && isGrounded){
            jumping = true;
        }

        //Inverte a posição do personagem
        if(move < 0){
            sprite.flipX = true;
        }
        else if(move > 0){
            sprite.flipX = false;
        }

        //Animação do personagem
        if(isGrounded){
            animationPlayer.SetBool("Jumping", false);
            animationPlayer.SetBool("Falling", false);

            if(rb.velocity.x != 0 && move != 0){
                animationPlayer.SetBool("Walking", true);
            }
            else{
                animationPlayer.SetBool("Walking", false);
            }
        }
        else{
            if(rb.velocity.x == 0){
                animationPlayer.SetBool("Walking", false);

                if(rb.velocity.y > 0){
                    animationPlayer.SetBool("Jumping", true);
                    animationPlayer.SetBool("Falling", false);
                }
                if(rb.velocity.y < 0){
                    animationPlayer.SetBool("Jumping", false);
                    animationPlayer.SetBool("Falling", true);
                }
            }
            else{
                if(rb.velocity.y > 0){
                    animationPlayer.SetBool("Jumping", true);
                    animationPlayer.SetBool("Falling", false);
                }
                if(rb.velocity.y < 0){
                    animationPlayer.SetBool("Jumping", false);
                    animationPlayer.SetBool("Falling", true);
                }
            }
        }
    }

    void FixedUpdate()
    {
        //Movimentação do personagem
        rb.velocity =  new Vector2(move * moveSpeed, rb.velocity.y);

        //Pulo do personagem
        if(jumping){
            //rb.AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
            rb.velocity = Vector2.up * jumpSpeed;

            //Desativar o pulo
            jumping = false;
        }
    }
}
