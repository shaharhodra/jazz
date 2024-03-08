using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform Player;
    public LayerMask whatIsgrunded, whatIsPlayer;
    //patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;
    //attacking
    public float timeBetweenATTACKS;
   public bool alreadyAtacked;
    //states
    public float sightRange, attackRange;
    public bool playerInSightRange , playerInAttackrange;

	private void Awake()
	{
        Player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
	}
	private void Update()
	{
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackrange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
        if (!playerInSightRange && !playerInAttackrange) Patroling();
        if (playerInSightRange && !playerInAttackrange) ChasePlayer();
        if (playerInAttackrange && playerInSightRange) AttackPlayer();
		
    }
    void Patroling()
	{
        if (!walkPointSet) SerchWalkPoint();
		if (walkPointSet)
		{
            agent.SetDestination(walkPoint);
		}
        Vector3 distanceToWalkPoint = transform.position - walkPoint;
		if (distanceToWalkPoint.magnitude<1f)
		{
            walkPointSet = false;
		}
	}
    void SerchWalkPoint()
	{
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.x + randomZ);
        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsgrunded));
		{
            walkPointSet = true;
		}
    }
    void ChasePlayer()
	{
        agent.SetDestination(Player.position);
	}
    void AttackPlayer()
	{
        agent.SetDestination(transform.position);
        transform.LookAt(Player);
		if (!alreadyAtacked)
		{
            //add the attack code here
           
            alreadyAtacked = true;
            Invoke(nameof(ResetAttack), timeBetweenATTACKS);
		}
	}
    void ResetAttack()
	{
        alreadyAtacked = false;
	}
   
}
