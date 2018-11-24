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
                    deathText.SetText("You are hungry. Very hungry. Your body is only bones and skin. You have less meat then ten years old squirrel (how recognise wolf, which has found your dead body).");
                    break;
                case 3:
                    deathText.SetText("You ran out of money. You need some gold, so you try to steal it. It was good idea, but they caught and poleaxed you.");
                    break;
                case 4:
                    deathText.SetText("No morale, no delight, no plan to future. You got very good idea. You commited a suicide. (Yeah, maybe it isn´t good idea, but who cares.)");
                    break;
                case 5:
                    deathText.SetText("Last fire went out. The world was changed into cold, dark cave. The day after, young boy find ice in human large, where you sat before.");
                    break;
                case 6:
                    deathText.SetText("You have no friends. People hate you and you hate people. You sit on a chair and wait, until someone came. Twenty yaers ago, someone find your bones on the chair.");
                    break;
                case 7:
                    deathText.SetText("You live in dirt and pollution. (Pig!) You got a lot of illnesses (Smelly pig!) and died alone. (Wretched smelly pig!)");
                    break;
                case 8:
                    deathText.SetText("You fell down and have no strenght to stand up. Maybe someone help you. No, sorry, but you can be happy, because your hogs have a lot to eat.");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
