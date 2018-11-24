using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    
    public GameObject player;
    public float distance;
    public float maxdistance = 5f;
    public Text text;

    public float waterIncrease = 0.0f;
    public float foodIncrease = 0.0f;
    public float wealthIncrease = 0.0f;
    public float moraleIncrease = 0.0f;
    public float warmthIncrease = 0.0f;
    public float socializationIncrease = 0.0f;
    public float hygieneIncrease = 0.0f;
    public float staminaIncrease = 0.0f;
    
    void Start()
    {
       
    }

    void Update()
    {
       
    }

    void OnMouseEnter()
    {
        distance = (this.transform.position - player.transform.position).magnitude;
        if (distance < maxdistance)
        {
            if(waterIncrease != 0)
            {
                text.text += "water +" + Mathf.Sign(waterIncrease) + "/n"; 
            }
        }
    }

    void OnMouseDown()
    {
        distance = (this.transform.position - player.transform.position).magnitude;
        if (distance < maxdistance)
        {
            PlayerStats stats = player.GetComponent<PlayerStats>();
            stats.water += waterIncrease;
            stats.food += foodIncrease;
            stats.wealth += wealthIncrease;
            stats.morale += moraleIncrease;
            stats.warmth += warmthIncrease;
            stats.socialization += socializationIncrease;
            stats.hygiene += hygieneIncrease;
            stats.stamina += staminaIncrease;
            stats.DetermineDeath();
        }
    }
}
