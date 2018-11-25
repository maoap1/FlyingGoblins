using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathTextController : MonoBehaviour {

    public TextMeshProUGUI deathText;

    // Use this for initialization
    void Start()
    {
        Singleton singleton = Singleton.Instance;
        if (deathText)
        {
            switch (singleton.typeOfDeath)
            {
                case 1:
                    deathText.SetText("No water. Nothing to drink. It seems like your kidneys ran out of your body, because they hate you.");
                    break;
                case 2:
                    deathText.SetText("You are hungry. Very hungry. Your body is just bones and skin. You have less meat than a ten years old squirrel (how recognised the wolf, that has found your dead body).");
                    break;
                case 3:
                    deathText.SetText("You ran out of money. You needed some gold, so you tried to steal it. It was good idea, however, they caught you and you were executed.");
                    break;
                case 4:
                    deathText.SetText("No morale, no delight, no plans for the future. Suddenly, you got a good idea. You commited a suicide. (Yeah, maybe it wasn't a good idea, but who cares.)");
                    break;
                case 5:
                    deathText.SetText("The heat is gone. The world has changed into a cold, dark cave. One day after, young boy found a human-sized ice, where you were spotted for the last time.");
                    break;
                case 6:
                    deathText.SetText("You have no friends. People hate you and you hate people. You sit on a chair and wait, until someone comes. Twenty yaers later, someone finds only your bones sitting on the chair.");
                    break;
                case 7:
                    deathText.SetText("You live in dirt and pollution. (Pig!) You got a lot of illnesses (Smelly pig!) and died alone. (Wretched smelly pig!)");
                    break;
                case 8:
                    deathText.SetText("You fell down and have not enought strength to stand up. Maybe someone helps you. No, sorry, but you can be happy, because your hogs have at least something to eat.");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
