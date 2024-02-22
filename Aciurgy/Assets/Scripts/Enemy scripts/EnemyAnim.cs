using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyAnim : MonoBehaviour
{
    public Animator anim;
    public Waypoints Wpoints;

    void Update()
    {
     
        Animate();
    }

    
    
    

    void Animate()
    {
        
        anim.SetFloat("GuardMoveX", Wpoints.moveDirection.x);
        anim.SetFloat("GuardMoveY", Wpoints.moveDirection.y);
    }
}
