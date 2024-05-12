using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaiks : MonoBehaviour
{
    public bool isTrigger;
    PlayerInvetort playerInvetort;
   [SerializeField] float timePassed = 0f;
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
      
        playerInvetort = GameObject.FindGameObjectWithTag("invetory").GetComponent<PlayerInvetort>();
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        if (isTrigger)
		{

            timePassed += Time.deltaTime;
            if (timePassed > .5f) // Execute every 5 seconds
            {
                playerInvetort.playerhit();
                

                timePassed = 0f; // Reset the timer
            }
         

        }
		if (playerInvetort.lastchecpointpos==Player.transform.position)
		{
            isTrigger = false;
		}

    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			isTrigger = true;
		}
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			isTrigger = false;
		}
	}


}
