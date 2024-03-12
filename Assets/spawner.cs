using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spawner : MonoBehaviour

{
    [SerializeField] private float timer = 5;
    float spowntime;
    public Transform spownPoint;
    public NavMeshAgent enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        spowntime -= Time.deltaTime;
        if (spowntime > 0) return;
        {
            spowntime = timer;
        }
        enemy = Instantiate(enemy, spownPoint.transform.position, spownPoint.transform.rotation);
    }
}
