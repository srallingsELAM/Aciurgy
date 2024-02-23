using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtoInteract : MonoBehaviour
{
    public GameObject canvasTrigger;

   
   

    private void OnTriggerEnter2D(Collider2D other)
    { 
      if (other.CompareTag("Player"))
        {
            canvasTrigger.SetActive(true);
        }


        if (other.CompareTag("PlayerTwo"))
        {
            canvasTrigger.SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canvasTrigger.SetActive(false);
            
        }


        if (other.CompareTag("PlayerTwo"))
        {
            canvasTrigger.SetActive(false);

        }

    }
}
