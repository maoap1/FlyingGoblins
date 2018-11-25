using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioScript : MonoBehaviour
{
    
	void Awake()
    {
        AudioSource ambientSound = null;
        AudioSource menuSound = null;

        foreach (Transform child in Singleton.Instance.gameObject.transform)
         {
            if (child.tag == "ambientSound")
            {
                ambientSound = child.gameObject.GetComponent<AudioSource>();
            }
            if (child.tag == "menuSound")
            {
                menuSound = child.gameObject.GetComponent<AudioSource>();
            }
         }


        ambientSound.mute = true;
        menuSound.mute = true;
        string activeScene = SceneManager.GetActiveScene().name;
        if ((activeScene == "MainMenu")||(activeScene == "Story"))
        {
            menuSound.enabled = true;
            menuSound.mute = false;
            ambientSound.enabled = false;
        }
        else
        {
            menuSound.enabled = false;
            ambientSound.enabled = true;
            ambientSound.mute = false;
        }
    }
}
