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
            doText.SetText("You chopped wood. Tiresome and dirty but hopefully it will make the house warmer.");
        }
        if (temp.Split(' ')[0] == "Stables")
        {
            doText.SetText("It stank and everything was dirty. At least you could talk to the old horse. Your only friend.");
        }
        if (temp.Split(' ')[0] == "Beehive")
        {
            doText.SetText("You are scared of those little things.  But honey is tasty and valuable thing.");
        }
        if (temp.Split(' ')[0] == "Swing")
        {
            doText.SetText("You spend there few hours. It's calm but so lonely.");
        }
        if (temp.Split(' ')[0] == "Field")
        {
            doText.SetText("You feel really tired and mucky. Are those frozen crops worth it?");
        }
        if (temp.Split(' ')[0] == "Well")
        {
            doText.SetText("You exchanged fresh water for stare into dark abyss.");
        }
        if (temp.Split(' ')[0] == "House")
        {
            doText.SetText("You've done well, but father was morose anyway. Let's sleep.");
        }
        if (temp.Split(' ')[0] == "Grave")
        {
            doText.SetText("Your mother was so glad to see you again. Why is she buried so far away?");
        }
        if (temp.Split(' ')[0] == "Vendor")
        {
            doText.SetText("Again, he took more money than he should. At least there is something to eat.");
        }
        if (temp.Split(' ')[0] == "Pond")
        {
            doText.SetText("These cold baths are killing you and all of the bacteria. You filled the flask for the way back.");
        }
        //doText.SetText("You did: " + temp.Split(' ')[0]);
        yield return new WaitForSeconds(3);
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