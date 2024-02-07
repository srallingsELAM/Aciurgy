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

    private void Start()
    {
        movespeed = 5f;
    }

    private void Update()
    {
        if (name == "PlayerOne")
        {
            dirX = Input.GetAxisRaw("Horizontal") * movespeed;
            dirY = Input.GetAxisRaw("Vertical") * movespeed;
        }

        if (name == "PlayerTwo" && Input.anyKey)
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
            dirX = 0f;
            dirY = 0f;
        }
        ProcessInputs();
        Animate();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
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
}
