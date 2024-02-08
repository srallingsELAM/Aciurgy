using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveWASD : MonoBehaviour
{
    public float Speed;
    public float moveSpeed;
    public Rigidbody2D rb;

    float MovementX;
    float MovementY;


    public Animator anim;
    private Vector2 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MovementX = 0;
        MovementY = 0;
    }

  
    void Update()
    {

        
        Animate();
        ProcessInputs();

        rb.velocity = new Vector2(MovementX * Speed * Time.deltaTime, MovementY * Speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W))
        {
            MovementY = 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            MovementY = -1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            MovementX = -1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            MovementX = 1;
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            MovementY = 0;
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            MovementX = 0;
        }

    }
    void Animate()
    {
        anim.SetFloat("AnimMoveX", moveDirection.x);
        anim.SetFloat("AnimMoveY", moveDirection.y);
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    void FixedUpdate()
    {
        Move();
    }
}

