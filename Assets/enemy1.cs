using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy1 : MonoBehaviour
{
    public Transform player;
	[SerializeField] NavMeshAgent agent;
    [SerializeField] private float timer = 5;
    float buletTime;
    public GameObject enemyBulet;
   // public NavMeshAgent enemy;
   // public Transform Player;
    public Transform spownPoint;
    public float enemyBuletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        agent.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        agent.destination = player.position;
        ShoteAtPlayer();

    }
    void ShoteAtPlayer()
    {
        buletTime -= Time.deltaTime;
        if (buletTime > 0) return;
        {
            buletTime = timer;
        }
        GameObject bulletobj = Instantiate(enemyBulet, spownPoint.transform.position, spownPoint.transform.rotation) as GameObject;
        Rigidbody buletrig = bulletobj.GetComponent<Rigidbody>();
        buletrig.AddForce(buletrig.transform.forward * enemyBuletSpeed);
        Destroy(bulletobj, 1f);

    }
}
