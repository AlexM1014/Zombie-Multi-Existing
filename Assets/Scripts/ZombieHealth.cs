using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    private int maxHealth = 10;
    private int currentHealth;
    private bool isDead = false;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            Destroy(gameObject);
        }

    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;
        if(currentHealth <= 0)
        {
            Game.game.playerScore += 25;
            Debug.Log(Game.game.playerScore);
            isDead = true;
            return;
        }
        else
        {
            currentHealth -= damage;
        }
    }
}
