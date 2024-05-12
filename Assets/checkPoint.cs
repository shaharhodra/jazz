using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
	PlayerInvetort playerInvetort;
	private spaiks Spaiks;
	private void Start()
	{
		playerInvetort = GameObject.FindGameObjectWithTag("invetory").GetComponent<PlayerInvetort>();
	}
	private void Update()
	{
		
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{

			
			playerInvetort.lastchecpointpos = transform.position;
		}
	}
}
