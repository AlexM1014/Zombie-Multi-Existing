using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barricade : MonoBehaviour
{
    public Text costText;

    public int cost;

    private void Start()
    {
        costText.enabled = false;
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            costText.enabled = true;
            if(Input.GetKeyDown(KeyCode.E) && Game.game.playerScore >= cost)
            {
                this.enabled = false;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        costText.enabled = false;
    }
}
