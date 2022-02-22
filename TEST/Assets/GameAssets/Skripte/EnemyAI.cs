using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;


public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent Agent;

    private Transform Player;

    public LayerMask Ground, ThePlayer;


    //Patrolling

    private Vector3 walkPoint;
    private bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAttacks;
    private bool alreadyAttacked;
    private bool AttackDestinationSet;

    //States
    public float sightRange, attackRange;
    private bool playerInSightRange, playerInAttackRange;

    //Soap Bubble
    public GameObject bubble;
    public GameObject firePoint;
    private GameObject Geschoss;
    

    private void Awake()
    {
        Player = GameObject.Find("Player").transform;
        Agent = GetComponent<NavMeshAgent>();

        GameStateManager.Instance.OnGameStateChanged += OnGameStateChanged;
    }

    private void OnDestroy()
    {
        GameStateManager.Instance.OnGameStateChanged -= OnGameStateChanged;
    }

    private void Update()
    {
        //Check for sight and attack Range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, ThePlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, ThePlayer);

        if (!playerInAttackRange && !playerInSightRange) { Patroling(); Debug.Log("Patrolling"); }
        if (!playerInAttackRange && playerInSightRange) { ChasePlayer(); Debug.Log("I see the Player!"); }
        if (playerInAttackRange && playerInSightRange) { AttackPlayer(); Debug.Log("Attack"); }
    }

    private void OnGameStateChanged(GameState newGameState)
    {
        enabled = newGameState == GameState.Gameplay;
    }
    private void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint();
        if (walkPointSet) Agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f) walkPointSet = false;
    }

    private void SearchWalkPoint()
    {
        //Calculate Random point in Range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);
        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        Debug.Log(walkPoint);
        if (Physics.Raycast(walkPoint, -transform.up, 2f, Ground))
        {
            walkPointSet = true;
        }
    }

    private void ChasePlayer()
    {
        Agent.SetDestination(Player.position);
        AttackDestinationSet = false;
    }

    private void AttackPlayer()
    {
        //Make sure Enemy doesn't move
        if (!AttackDestinationSet)
        {
            Agent.SetDestination(transform.position);
            
            AttackDestinationSet = true;
        }
        
        Vector3 targetposition = new Vector3(Player.position.x, this.transform.position.y, Player.position.z);

        transform.LookAt(targetposition);

        if (!alreadyAttacked)
        {
           //Insert Attackcode here

            //Attackcode Bubble
            Geschoss = Instantiate(bubble, firePoint.transform.position, gameObject.transform.rotation);
            
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }

    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

}
