using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class litelboos : MonoBehaviour
{
	[SerializeField] GameObject boss;
	[SerializeField]int hit;
	
	
	
		
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("jazzbulet") || other.CompareTag("spazzbulet"))
		{
				boss.GetComponent<boss>().hitcount();
			}
		}

	}

