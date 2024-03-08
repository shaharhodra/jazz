using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
			Debug.Log("hitTurget");
		}
		else
		{
			Debug.Log("miss");
		}
		Destroy(gameObject);
	}
}
