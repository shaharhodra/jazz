using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrot : MonoBehaviour
{
	int carrotCaunt;
	public GameObject invetory;
	private void OnTriggerEnter(Collider other)
	{
		
		PlayerInvetort playerInvetort = invetory.GetComponent<PlayerInvetort>();
		if (other.CompareTag("Player"))

		{
			Debug.Log("carrot");
			playerInvetort.CarrotCollected();
			gameObject.SetActive(false);
		}
	}
}
