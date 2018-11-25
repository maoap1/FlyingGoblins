using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSingleton : MonoBehaviour
{
    private static MenuSingleton instance = null;
    public static MenuSingleton Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }
}
