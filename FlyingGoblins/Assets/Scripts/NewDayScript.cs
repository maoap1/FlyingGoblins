using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewDayScript : MonoBehaviour {

    public TextMeshProUGUI dayCount;
    public int dayNumber;
    Singleton singleton;

    // Use this for initialization
    void Start ()
    {

        singleton = Singleton.Instance;
    }
	
	// Update is called once per frame
	void Update () {

      
    }

    void OnEnable()
    {
        dayNumber ++;
        dayCount.SetText("Day " + dayNumber.ToString());
        singleton.days = dayNumber;
    }
}
