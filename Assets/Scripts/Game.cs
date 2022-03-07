using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject player;

    public static Game game;

    public int playerScore = 0;

    public List<Zombie> zombies;

    public bool barricade1Bought = false;
    public bool barricade2Bought = false;
    public bool barricade3Bought = false;


    bool isInBarricadeTrigger = false;

    private void Start()
    {
        game = this;
    }

    private void Update()
    {
        zombies = FindObjectsOfType<Zombie>().ToList();
    }

}
