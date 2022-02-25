using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossAttack : MonoBehaviour
{
    private NavMeshAgent Agent;
    private Transform Player;
    public LayerMask ThePlayer;
    public HealthbarSkript healthPlayer;

    private int Damage = 20;

    //States
    private float AttackRange = 7;
    public bool playerInAttackRange;

    //Attacking
    public float timeBetweenAttacks;
    private bool alreadyAttacked;
    private bool AttackDestinationSet;

    private void Awake()
    {
        Player = GameObject.Find("Player").transform;
        Agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        playerInAttackRange = Physics.CheckSphere(transform.position, AttackRange, ThePlayer);

        if (!playerInAttackRange) { WalkToPlayer(); }
        if (playerInAttackRange) { AttackPlayer(); }

    }

    private void WalkToPlayer()
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

            PlayerStats.lifepoints -= Damage;

            Debug.Log(PlayerStats.lifepoints);
            healthPlayer.SetHealth(PlayerStats.lifepoints);

            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

}
