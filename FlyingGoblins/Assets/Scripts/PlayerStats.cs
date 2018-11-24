using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerStats : MonoBehaviour {


    public float water = 1.0f;
    public float food = 1.0f;
    public float wealth = 1.0f;
    public float morale = 1.0f;
    public float warmth = 1.0f;
    public float socialization = 1.0f;
    public float hygiene = 1.0f;
    public float stamina = 1.0f;

    private void ProcessChanges(ref float number)
    {
        if (number <= 0.0f)
        {
            Die();
        }
        if (number > 1.0f)
        {
            number = 1.0f;
        }
    }

    public void DetermineDeath()
    {
        ProcessChanges(ref water);
        ProcessChanges(ref food);
        ProcessChanges(ref wealth);
        ProcessChanges(ref morale);
        ProcessChanges(ref warmth);
        ProcessChanges(ref socialization);
        ProcessChanges(ref hygiene);
        ProcessChanges(ref stamina);
    }

    private void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(0);
        //TODO - Death scene
    }
}
