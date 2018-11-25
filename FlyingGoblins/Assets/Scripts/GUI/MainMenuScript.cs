using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {
    
    public void PlayButtonDown()
    {
        SceneManager.LoadScene(1);
    }

    public void TutorialButtonDown()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitButtonDown()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
