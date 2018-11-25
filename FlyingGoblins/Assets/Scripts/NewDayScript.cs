using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewDayScript : MonoBehaviour {

    public TextMeshProUGUI dayCount;
    public TextMeshProUGUI newObjectives;
    public TextMeshProUGUI infoObjectives;
    public int dayNumber;

    void OnEnable()
    {
        dayNumber ++;
        dayCount.SetText("Day " + dayNumber.ToString());
        Singleton.Instance.days = dayNumber;
        infoObjectives.SetText(newObjectives.text);
    }
}
