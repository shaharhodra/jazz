using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harts : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		PlayerInvetort playerInvetort = other.GetComponent<PlayerInvetort>();
		if (playerInvetort != null)
		{
			playerInvetort.hartCollected();
			gameObject.SetActive(false);
		}
	}
}
