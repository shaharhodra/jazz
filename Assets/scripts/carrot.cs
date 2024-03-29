using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrot : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		PlayerInvetort playerInvetort = other.GetComponent<PlayerInvetort>();
		if (playerInvetort!= null)
		{
			playerInvetort.CarrotCollected();
			gameObject.SetActive(false);
		}
	}
}
