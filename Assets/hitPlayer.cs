using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitPlayer : MonoBehaviour
{
    [SerializeField]public static float score;
	public static float dameg=10;
   
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
            score = score-dameg;
           
		}
	}
}
