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


    private void Start()
    {
        game = this;
    }

    private void Update()
    {
        zombies = FindObjectsOfType<Zombie>().ToList();
    }
}
