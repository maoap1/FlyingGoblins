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

    private void ProcessChanges(ref float number, int type)
    {
        if (number <= 0.0f)
        {
            Die(type);
        }
        if (number > 1.0f)
        {
            number = 1.0f;
        }
    }

    public void DetermineDeath()
    {
        ProcessChanges(ref water, 1);
        ProcessChanges(ref food, 2);
        ProcessChanges(ref wealth, 3);
        ProcessChanges(ref morale, 4);
        ProcessChanges(ref warmth, 5);
        ProcessChanges(ref socialization, 6);
        ProcessChanges(ref hygiene, 7);
        ProcessChanges(ref stamina, 8);
    }

    private void Die(int deathnumber)
    {
        Destroy(gameObject);
        Singleton.Instance.typeOfDeath = deathnumber;
        SceneManager.LoadScene(2);
        //TODO - Death scene
    }
}
