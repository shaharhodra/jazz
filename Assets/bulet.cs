using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulet : MonoBehaviour
{
   
   
    // Start is called before the first frame update
    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
     
        Invoke("destroy", 1f);
    }
	void destroy()
	{
        Destroy(this.gameObject);
	}
	
}
