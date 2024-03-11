using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BulletProjectile : MonoBehaviour
{
	private Rigidbody bulletRB;
	public float speed = 10;
	
	
	private void Awake()
	{
		bulletRB = GetComponent<Rigidbody>();
	}
	private void Start()
	{
		
		bulletRB.velocity = transform.forward * speed ;

	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<target>()!=null)
		{
			Debug.Log("hit");
		}
		else
		{
			Debug.Log("miss");
		}
		Destroy(gameObject);
	}
}
