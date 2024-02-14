using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangingCharacters : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
	bool jump;
	// Start is called before the first frame update
	void Start()
	{
		red.GetComponentInChildren<StarterAssets.ThirdPersonController>();
		blue.GetComponent<StarterAssets.ThirdPersonController>();
	    jump = GetComponent<StarterAssets.StarterAssetsInputs>().jump;
		

	}

    // Update is called once per frame
    void Update()
    {
		jump = true;
		if (Input.GetKeyDown(KeyCode.E))
        {
			
			red.SetActive(false);
			blue.SetActive(true);
        }
       else if (Input.GetKeyDown(KeyCode.Q))
        {
			blue.SetActive(false);
			red.SetActive(true);

            
			
		}
    }
}
