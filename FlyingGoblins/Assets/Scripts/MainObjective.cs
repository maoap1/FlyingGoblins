using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainObjective : MonoBehaviour
{
    public List<Objective> availableObjectives = new List<Objective>();
    
    public Objective GetObjective()
    {
        int rnd = Random.Range(0, availableObjectives.Count);
        return availableObjectives[rnd];
    }
}