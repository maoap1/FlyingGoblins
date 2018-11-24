using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsController : MonoBehaviour {

    public PlayerStats playerStats;
    public Slider waterslider;
    public Slider foodslider;
    public Slider wealthslider;
    public Slider moraleslider;
    public Slider warmthslider;
    public Slider socializitionslider;
    public Slider hygieneslider;
    public Slider staminaslider;
    
	// Update is called once per frame
	void Update ()
    {
        waterslider.value = playerStats.water;
        foodslider.value = playerStats.food;
        wealthslider.value = playerStats.wealth;
        moraleslider.value = playerStats.morale;
        warmthslider.value = playerStats.warmth;
        socializitionslider.value = playerStats.socialization;
        hygieneslider.value = playerStats.hygiene;
        staminaslider.value = playerStats.stamina;

    }
}
