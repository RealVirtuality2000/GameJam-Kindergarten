using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossAttack : MonoBehaviour
{
    private NavMeshAgent Agent;
    private Transform Player;
    public LayerMask ThePlayer;
    private HealthbarSkript healthPlayer;

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
        Agent = GetComponent<NavMeshAgent>();
    }
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        healthPlayer = GameObject.Find("HealthbarPlayer").GetComponent<HealthbarSkript>();
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

            PlayerStats.lifepoints -= (Damage - PlayerStats.resistance);

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
