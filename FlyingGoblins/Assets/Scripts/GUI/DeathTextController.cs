using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathTextController : MonoBehaviour {

    public TextMeshProUGUI deathText;
    public TextMeshProUGUI days;

    // Use this for initialization
    void Start()
    {
        Singleton singleton = Singleton.Instance;
        int dayCount = singleton.days;
        if (dayCount == 1)
        {
            days.SetText("You survived 1 Day.");
        }
        else
        {
            days.SetText("You survived " + dayCount.ToString() + " Day.");
        }
        
        if (deathText)
        {
            switch (singleton.typeOfDeath)
            {
                case 1:
                    deathText.SetText("They say humans can survive five days without water. But you're just a boy and in these parts death comes in matter of hours.");
                    break;
                case 2:
                    deathText.SetText("Just bones and skin. Less meat than a squirrel but wolves don't mind.");
                    break;
                case 3:
                    deathText.SetText("You ruined this family. Father rather sold you to foreign slavers. You died after first shift in sulfur mines.");
                    break;
                case 4:
                    deathText.SetText("So many voices. Talking to you. All the time. You bashed them out of your head. For good.");
                    break;
                case 5:
                    deathText.SetText("In these parts snow never melts away. And so they will never find your frozen corpse.");
                    break;
                case 6:
                    deathText.SetText("You came to hate your kin and befriended wolves. You've been killed during the initiation into the pack.");
                    break;
                case 7:
                    deathText.SetText("You will never know what disease killed you. You wouldn't be able to pronounce its name anyways.");
                    break;
                case 8:
                    deathText.SetText("You fell down exhausted and never got on your feet again. Wilderness devoured you with time.");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
