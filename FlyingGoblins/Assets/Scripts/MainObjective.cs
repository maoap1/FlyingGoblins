using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text;

public class MainObjective : MonoBehaviour
{
    public List<Objective> availableObjectives = new List<Objective>();

    public Objective currentObjective = null;
    public GameObject house = null;
    public bool objectiveIsDone = false;
    public GameObject newDayCanvas;
    public GameObject activeObject;
    public TextMeshProUGUI objectiveText;

    void Start()
    {
        CreateNewObjective();
        ObjectiveSetActive();
        activeObject.SetActive(false);
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
                PlayerStats ps = GetComponentInParent<PlayerStats>();
                ps.water += -0.2f;
            }

            ObjectiveSetActive();
            activeObject.SetActive(false);
            newDayCanvas.SetActive(true);
            
        }
    }

    void ObjectiveSetActive()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Objective :");
        sb.AppendLine("        " + currentObjective.description);
        objectiveText.SetText(sb);
    }
}