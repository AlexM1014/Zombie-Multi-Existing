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
