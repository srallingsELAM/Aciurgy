using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveItem : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
