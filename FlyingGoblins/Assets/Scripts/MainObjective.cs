﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainObjective : MonoBehaviour
{
    public List<Objective> availableObjectives = new List<Objective>();

    public Objective currentObjective = null;
    public GameObject house = null;
    public bool objectiveIsDone = false;

    void Start()
    {
        CreateNewObjective();
    }

    public void CreateNewObjective()
    {
        int rnd = Random.Range(0, availableObjectives.Count);
        currentObjective = availableObjectives[rnd];
    }

    public void RegisterLocation(GameObject location)
    {
        if (location.ToString() == currentObjective.location.ToString())
        {
            //CreateNewObjective();
            objectiveIsDone = true;
        }
        if (location.ToString() == house.ToString())
        {
            if (objectiveIsDone)
            {

            }
        }
    }
}