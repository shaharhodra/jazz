using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
	public GameObject invetory;
	private void OnTriggerEnter(Collider other)
	{
		PlayerInvetort playerInvetort = invetory.GetComponent<PlayerInvetort>();
		if (other.CompareTag("Player"))
		{
			playerInvetort.coinColected();
			gameObject.SetActive(false);
		}

	}
}