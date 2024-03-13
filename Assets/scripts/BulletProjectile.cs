using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BulletProjectile : MonoBehaviour
{
	private Rigidbody bulletRB;
	public float speed = 10;
	public  Transform vfxPos;
	
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
			// vfx efect
			Instantiate(vfxPos, transform.position, Quaternion.identity);
			//code for hit ...ivent triger
		}
		else
		{
			// if dont hit code
		}
		Destroy(gameObject);
	}
}
