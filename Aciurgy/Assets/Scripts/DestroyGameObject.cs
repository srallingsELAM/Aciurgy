using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{

 
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (gameObject.tag == "Key")
        {
            Destroy(gameObject);
        }
    }

}
