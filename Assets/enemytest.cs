using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemytest : MonoBehaviour
{
    public Transform Player;
    private NavMeshAgent agent;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
       
        agent=GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = Player.position;
    }
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
            Destroy(player);
		}
	}
}
