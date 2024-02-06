using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2 : MonoBehaviour

    
{

    public float time;
    public GameObject door2;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            door2.GetComponent<BoxCollider2D>().enabled = false;
            

        }
        if (col.CompareTag("Door 2"))
        {
            
            Destroy(gameObject, time);

        }

    }   
}
