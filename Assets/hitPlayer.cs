using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitPlayer : MonoBehaviour
{
    [SerializeField]public static float score;
   
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
            score++;
           
		}
	}
}
