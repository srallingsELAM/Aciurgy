using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2 : MonoBehaviour
{
    public GameObject portal;
    private GameObject player;
    void Start()
    {
        player = GameObject.FindWithTag("PlayerTwo");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerTwo")
        {
            player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);  
        }
    }
}
