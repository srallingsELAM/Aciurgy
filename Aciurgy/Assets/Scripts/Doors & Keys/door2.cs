using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2 : MonoBehaviour
{
    public bool locked;

    private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        locked = true;
    }


    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Key 2"))
        {
            anim.SetTrigger("Open");
            locked = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key 2"))
        {
            locked = true;
        }
    }

}
