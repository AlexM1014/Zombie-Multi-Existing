using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barricade : MonoBehaviour
{
    public Text costText;

    public GameObject barricade;

    public int cost;

    private void Start()
    {
        costText.enabled = false;
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            costText.text = "Press E to remove barrier - Cost: " + cost;
            costText.enabled = true;
            if(Input.GetKeyDown(KeyCode.E) && Game.game.playerScore >= cost)
            {
                barricade.SetActive(false);
                Game.game.playerScore -= cost;
            }
            if(tag == "Barricade1")
            {
                Game.game.barricade1Bought = true;
            }
            if (tag == "Barricade2")
            {
                Game.game.barricade2Bought = true;
            }
            if (tag == "Barricade3")
            {
                Game.game.barricade3Bought = true;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        costText.enabled = false;
    }
}
