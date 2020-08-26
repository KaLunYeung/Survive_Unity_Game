using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicDontDestory : MonoBehaviour
{

    static BackgroundMusicDontDestory instance = null;

    
    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    
}
