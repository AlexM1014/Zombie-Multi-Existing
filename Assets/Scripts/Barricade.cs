using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barricade : MonoBehaviour
{
    public int pointCost;

    public Text costText;

    public void Start()
    {
        costText.enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        costText.enabled = true;
        if(Input.GetKeyDown(KeyCode.E) && Game.game.playerScore >= pointCost)
        {
            Destroy(this);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        costText.enabled = false;
    }
}
