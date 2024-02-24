using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangingCharacters : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
	public bool Red;
	public bool Blue;
    bool OnOff;
	
	// Start is called before the first frame update
	void Start()
	{

		
	    Red=red.GetComponentInChildren<StarterAssets.ThirdPersonController>().red=true;
		Blue=blue.GetComponentInChildren<StarterAssets.ThirdPersonController>().blue=true;
		
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.E))

		{
			OnOff = !OnOff;

		}

		
		
		if (OnOff)
        {
			
			red.SetActive(false);
			blue.SetActive(true);
			Blue = true;
			Red = false;
		}
       else if (!OnOff)
        {
			
			blue.SetActive(false);
			red.SetActive(true);
			Red = true;
			Blue = false;



		}
		
		
    }
}
