using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
      if(col.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (col.CompareTag("PlayerTwo"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}