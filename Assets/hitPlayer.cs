using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitPlayer : MonoBehaviour
{
	PlayerInvetort playerInvetort;
	GameObject red;
	
	private void Start()
	{
		
		playerInvetort = red.GetComponent<PlayerInvetort>();
	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log("hit");
			
		playerInvetort.playerhit();
		
				
			
		}
	}
}
