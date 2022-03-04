using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    Animator animator;
    Rigidbody rb;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        navMeshAgent.SetDestination(Game.game.player.transform.position);
        animator.SetFloat("Speed", rb.velocity.magnitude);
    }
}
