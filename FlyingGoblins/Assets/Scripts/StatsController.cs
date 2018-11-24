using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsController : MonoBehaviour {

    public PlayerStats playerStats;
    public Slider waterslider;
    public Slider foodslider;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        waterslider.value = playerStats.water;
        foodslider.value = playerStats.food;
	}
}
