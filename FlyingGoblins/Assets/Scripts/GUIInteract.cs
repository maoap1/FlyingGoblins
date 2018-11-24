using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;

public class GUIInteract : MonoBehaviour
{

    public TextMeshProUGUI statsDisplayer;
    public Image backgroundPanel;
    public GameObject player;

    string[] str = new string[8];
    float[] statsIncrease = new float[8];
    Interact interact;


    // Use this for initialization
    void Start()
    {
        interact = this.GetComponent<Interact>();
        statsIncrease[0] = interact.waterIncrease;
        statsIncrease[1] = interact.foodIncrease;
        statsIncrease[2] = interact.wealthIncrease;
        statsIncrease[3] = interact.moraleIncrease;
        statsIncrease[4] = interact.warmthIncrease;
        statsIncrease[5] = interact.socializationIncrease;
        statsIncrease[6] = interact.hygieneIncrease;
        statsIncrease[7] = interact.staminaIncrease;
    }

    void OnMouseEnter()
    {
        interact.distance = (this.transform.position - player.transform.position).magnitude;
        if (interact.distance < interact.maxdistance)
        {
            for (int i = 0; i < 8; i++)
            {
                if (statsIncrease[i] > 0f)
                {
                    str[i] = "+";
                }
                else if (statsIncrease[i] < 0f)
                {
                    str[i] = "-";
                }
                else str[i] = "0";
            }


            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Possible efect:");
            sb.AppendLine("water " + str[0] + "               food " + str[1] + "               wealth " + str[2] + "           morale " + str[3]);
            sb.AppendLine("warmth " + str[4] + "       socialization " + str[5] + "       hygiene " + str[6] + "        stamina " + str[7]);

            statsDisplayer.SetText(sb.ToString());
            backgroundPanel.enabled = true;
        }
    }

    void OnMouseExit()
    {
        statsDisplayer.SetText("");
        backgroundPanel.enabled = false;
    }
}
