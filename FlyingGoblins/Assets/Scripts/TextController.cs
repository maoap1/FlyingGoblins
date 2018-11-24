using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public PlayerStats playerStats;
    Text text;
    public float lack = 0.3f;

	// Use this for initialization
	void Start () {
        text = this.GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Warning!";
        text.enabled = false;
        if(playerStats.water < lack)
        {
            text.text += "\n You are thirsty!";
            text.enabled = true;
        }
	}
}
