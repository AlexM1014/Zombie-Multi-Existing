using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject player;

    public static Game game;

    public int playerScore = 0;

    public List<Zombie> zombies;

    public GameObject barricades1;
    public GameObject barricades2;
    public GameObject barricades3;

    public GameObject barricade1Trigger;
    public GameObject barricade2Trigger;
    public GameObject barricade3Trigger;

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
