using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    
   
    public void CharacterPicker()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Cutscene2()
    {
        SceneManager.LoadSceneAsync(8);
    }



}

