using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    public PlayerStats playerStats;
    public float lack = 0.3f;

	// Use this for initialization
	void Start () {
        text.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Beware!";
        text.enabled = false;
        if(playerStats.water < lack)
        {
            text.text += "\n You are thirsty!";
            text.enabled = true;
        }
        if (playerStats.food < lack)
        {
            text.text += "\n You are hungry!";
            text.enabled = true;
        }
        if (playerStats.wealth < lack)
        {
            text.text += "\n Your funds are low!";
            text.enabled = true;
        }
        if (playerStats.morale < lack)
        {
            text.text += "\n Your morale is low!";
            text.enabled = true;
        }
        if (playerStats.warmth < lack)
        {
            text.text += "\n You are freezing!";
            text.enabled = true;
        }
        if (playerStats.socialization < lack)
        {
            text.text += "\n No human contact!";
            text.enabled = true;
        }
        if (playerStats.hygiene < lack)
        {
            text.text += "\n You are sick!";
            text.enabled = true;
        }
        if (playerStats.stamina < lack)
        {
            text.text += "\n You are enfeebled!";
            text.enabled = true;
        }
    }
}
