using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private float dirX, dirY, movespeed;
    public Animator anim;

    private Vector2 moveDirection;

    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
    }

    void Update()
    {
        if (tag == "PlayerOne" && Input.anyKey)
        {

            if (Input.GetKey(KeyCode.W))
            {
                dirY = movespeed;
            }

            if (Input.GetKey(KeyCode.S))
            {
                dirY = -movespeed;
            }

            if (Input.GetKey(KeyCode.D))
            {
                dirX = movespeed;
            }

            if (Input.GetKey(KeyCode.A))
            {
                dirX = -movespeed;
            
            }
            else if (tag == "PlayerOne" && !Input.anyKey)
            {
                dirX = 0f;
                dirY = 0f;
            }

        }

        if (tag == "PlayerTwo" && Input.anyKey)
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                dirY = movespeed;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                dirY = -movespeed;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                dirX = movespeed;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                dirX = -movespeed;
            }
        }
        else if (tag == "PlayerTwo" && !Input.anyKey)
        {
            dirX = 0f;
            dirY = 0f;
        }
        ProcessInputs();
        Animate();
    }
   
    void FixedUpdate()
    {
        Move();
    }
    
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    void Animate()
    {
        anim.SetFloat("AnimMoveX", moveDirection.x);
        anim.SetFloat("AnimMoveY", moveDirection.y);
    }
}
