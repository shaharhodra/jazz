using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitPlayer : MonoBehaviour
{
	
	
	
	private void Start()
	{

		
	}


	private void OnTriggerEnter(Collider other)
	{
		
		
		if (other.CompareTag("Player"))
		{

			GameObject.FindGameObjectWithTag("invetory").GetComponent<PlayerInvetort>().playerhit();



		}
	}
}
