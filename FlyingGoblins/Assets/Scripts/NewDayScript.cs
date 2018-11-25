using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text;

public class NewDayScript : MonoBehaviour {

    public TextMeshProUGUI dayCount;
    public TextMeshProUGUI infoObjectives;
    public int dayNumber;
    public MainObjective mainObjective;

    void OnEnable()
    {
        dayNumber ++;
        dayCount.SetText("Day " + dayNumber.ToString());
        Singleton.Instance.days = dayNumber;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Objective :");
            sb.AppendLine(mainObjective.currentObjective.description);
            infoObjectives.SetText(sb);
        
    }
}
