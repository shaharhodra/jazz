using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class enemyshote : MonoBehaviour
{
    [SerializeField] private float timer = 5;
    float buletTime;
    public GameObject enemyBulet;
    public NavMeshAgent enemy;
    public Transform player;
    public Transform spownPoint;
    public float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
        ShoteAtPlayer();
    }
    void ShoteAtPlayer()
	{
        buletTime -= Time.deltaTime;
        if (buletTime > 0) return;
		{
            buletTime = timer;
		}
        GameObject bulletobj = Instantiate(enemyBulet, spownPoint.transform.position,spownPoint.transform.rotation) as GameObject;
        Rigidbody buletrig = bulletobj.GetComponent<Rigidbody>();
        buletrig.AddForce(buletrig.transform.forward * enemySpeed);
        Destroy(bulletobj, 1f);

	}
}
