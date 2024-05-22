using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class log : MonoBehaviour
{
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("spazzbulet")||other.CompareTag("jazzbulet"))
		{
            anim.gameObject.SetActive(true);
		}
	}
}
