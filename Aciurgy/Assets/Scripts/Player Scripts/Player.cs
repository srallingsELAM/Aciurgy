using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private float dirX, dirY, movespeed;
    public Rigidbody2D rb2;

    public Animator anim;
    private Vector2 moveDirection;
    public float moveSpeed;

    private void Start()
    {
        movespeed = 5f;
    }

    void Update()
    {
        if (tag == "PlayerOne")
        {
            dirX = Input.GetAxisRaw("Horizontal") * movespeed;
            dirY = Input.GetAxisRaw("Vertical") * movespeed;
            moveDirection = new Vector2(dirX, dirY).normalized;
        }

        if (tag == "PlayerTwo" && Input.anyKey)
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
        }
        else if (name == "PlayerTwo" && !Input.anyKey)
        {
            dirX = 5f;
            dirY = 5f;
        }
        ProcessInputs();
        Animate();
    }

    
    void Animate()
    {
        anim.SetFloat("AnimMoveX", moveDirection.x);
        anim.SetFloat("AnimMoveY", moveDirection.y);
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
}
