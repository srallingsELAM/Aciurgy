using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyAnim : MonoBehaviour
{
    public Animator anim;
    private Vector2 moveDirection;

    void Update()
    {
        ProcessInputs();
        Animate();
    }

    
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    

    void Animate()
    {
        anim.SetFloat("GuardMoveX", moveDirection.x);
        anim.SetFloat("GuardMoveY", moveDirection.y);
    }
}
