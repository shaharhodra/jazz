using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitPlayer : MonoBehaviour
{
	public GameObject red;
	
	
	private void Start()
	{

		red = GameObject.Find("PlayerArmature");
	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log("hit");

			red.GetComponent<PlayerInvetort>().playerhit();



		}
	}
}
