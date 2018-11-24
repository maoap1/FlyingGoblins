using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject player;

    public float waterIncrease = 0.0f;
    public float foodIncrease = 0.0f;
    public float wealthIncrease = 0.0f;
    public float moraleIncrease = 0.0f;
    public float warmthIncrease = 0.0f;
    public float socializationIncrease = 0.0f;
    public float hygieneIncrease = 0.0f;
    public float staminaIncrease = 0.0f;

    void OnMouseDown()
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
