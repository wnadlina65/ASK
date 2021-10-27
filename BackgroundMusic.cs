using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic bgm;

    private void Awake()
    {
        if(bgm == null)
        {
            bgm = this;
            DontDestroyOnLoad(bgm);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
