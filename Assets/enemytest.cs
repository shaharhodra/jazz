using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemytest : MonoBehaviour
{
    public Transform Player;
    private NavMeshAgent agent;
    public GameObject player;
    public GameObject bulet
;    // Start is called before the first frame update
    void Start()
    {
       
        agent=GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = Player.position;
        Instantiate(bulet);
    }
	
}
