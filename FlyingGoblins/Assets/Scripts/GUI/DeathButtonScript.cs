using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BackToMenuButtonDown()
    {
        SceneManager.LoadScene(0);
    }

    public void RestratGameButtonDown()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitButtonDown()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
