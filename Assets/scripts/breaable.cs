using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breaable : MonoBehaviour
{
    [SerializeField] private GameObject _replacement;
    [SerializeField] private float _breakForce = 2;
    [SerializeField] private float _collisionMultiplier = 100;
    [SerializeField] private bool _broken;
	[SerializeField]bool hit;
	private void Awake()
	{
		hit = false;
	}
	void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.CompareTag("spazzbulet"))
        {
            Debug.Log("spazz");
            hit = true;
        }
        if (_broken) return;
		 
		if (collision.relativeVelocity.magnitude >= _breakForce && hit)
		{

			_broken = true;
			var replacement = Instantiate(_replacement, transform.position, transform.rotation);

			var rbs = replacement.GetComponentsInChildren<Rigidbody>();
			foreach (var rb in rbs)
			{
				rb.AddExplosionForce(collision.relativeVelocity.magnitude * _collisionMultiplier, collision.contacts[0].point, 2);
			}
			hit = false;
			Destroy(gameObject);
		}
		
	}
	private void OnTriggerEnter(Collider other)
	{
	
	}
}
