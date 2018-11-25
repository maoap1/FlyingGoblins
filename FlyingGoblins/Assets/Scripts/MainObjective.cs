using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text;
using UnityEngine.UI;

public class MainObjective : MonoBehaviour
{
    public List<Objective> availableObjectives = new List<Objective>();

    public Objective currentObjective = null;
    public GameObject house = null;
    public bool objectiveIsDone = false;
    public GameObject newDayCanvas;
    public GameObject activeObject;
    public TextMeshProUGUI objectiveText;
    public GameObject canvas;
    public GameObject doneCanvas;
    public TextMeshProUGUI doText;
    public Image objectiveImage;
    public GameObject fakeLocations;


    void Start()
    {
        CreateNewObjective();
        ObjectiveSetActive();
        activeObject.SetActive(false);
        newDayCanvas.SetActive(true);
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
            objectiveIsDone = true;
            objectiveImage.color = Color.green;
        }
        StartCoroutine(Enumerator(location));

        
        if (location.ToString() == house.ToString())
        {

            if (objectiveIsDone)
            {
                CreateNewObjective();
                objectiveIsDone = false;
                objectiveImage.color = Color.red;
            }

            if(objectiveIsDone == false)
            {
                PlayerStats ps = GetComponentInParent<PlayerStats>();
                ps.wealth += -0.3f;
                ps.morale += -0.3f;
                ps.stamina += -0.1f;
            }

            ObjectiveSetActive();
            activeObject.SetActive(false);
            fakeLocations.SetActive(true);
            newDayCanvas.SetActive(true);
            canvas.SetActive(false);
            doneCanvas.SetActive(false);

        }
    }

    IEnumerator Enumerator(GameObject location)
    { 
        doneCanvas.SetActive(true);
        string temp = location.ToString();
        if (temp.Split(' ')[0] == "WoodCutting")
        {
            doText.SetText("Wood");
        }
        if (temp.Split(' ')[0] == "Stables")
        {
            doText.SetText("Wood");
        }
        //doText.SetText("You did: " + temp.Split(' ')[0]);
        yield return new WaitForSeconds(1);
        doneCanvas.SetActive(false);
    }

    void ObjectiveSetActive()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Objective :");
        sb.AppendLine(currentObjective.description);
        objectiveText.SetText(sb);
    }
}