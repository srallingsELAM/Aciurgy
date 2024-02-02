using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour

    
{

    public float time;
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            door.GetComponent<BoxCollider2D>().enabled = false;
            

        }
        if (col.CompareTag("Door"))
        {
            
            Destroy(gameObject, time);

        }

    }   
}
