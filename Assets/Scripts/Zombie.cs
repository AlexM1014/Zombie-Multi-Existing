using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    Animator animator;
    Rigidbody rb;
    float distance;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        distance = Vector3.Distance(transform.position, Game.game.player.transform.position);
        Debug.Log(distance);
        animator.SetFloat("Distance", distance);
        navMeshAgent.SetDestination(Game.game.player.transform.position);
        animator.SetFloat("Speed", rb.velocity.magnitude);
    }
}
