using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2 : MonoBehaviour
{
    public GameObject portal2;
    private GameObject player2;
    void Start()
    {
        player2 = GameObject.FindWithTag("PlayerTwo");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerTwo")
        {
            player2.transform.position = new Vector2(portal2.transform.position.x, portal2.transform.position.y);  
        }
    }
}
