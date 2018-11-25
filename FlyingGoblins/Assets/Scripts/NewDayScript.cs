using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewDayScript : MonoBehaviour {

    public TextMeshProUGUI dayCount;
    public int dayNumber;

    void OnEnable()
    {
        dayNumber ++;
        dayCount.SetText("Day " + dayNumber.ToString());
        Singleton.Instance.days = dayNumber;
    }
}
