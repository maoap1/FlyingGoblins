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

    public void DetermineDeath()
    {
        if (water <= 0.0f)
        {
            Die();
        }
        if (food <= 0.0f)
        {
            Die();
        }
        if (wealth <= 0.0f)
        {
            Die();
        }
        if (morale <= 0.0f)
        {
            Die();
        }
        if (warmth <= 0.0f)
        {
            Die();
        }
        if (socialization <= 0.0f)
        {
            Die();
        }
        if (hygiene <= 0.0f)
        {
            Die();
        }
        if (stamina <= 0.0f)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(0);
        //TODO - Death scene
    }
}
