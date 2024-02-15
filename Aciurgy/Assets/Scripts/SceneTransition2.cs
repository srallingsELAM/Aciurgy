using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition2 : MonoBehaviour
{
    public string sceneToLoad;
    public Vector2 playerPosition;
    public VectorValue playerStorage;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerTwo") && !other.isTrigger)
        {
            playerStorage.initialvalue = playerPosition;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}      
