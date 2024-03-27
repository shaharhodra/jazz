using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class ChangingCharacters : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
	public GameObject redPos;
	public GameObject bluepos;
	
    bool OnOff;
	public Vector3 playerNewPos;

	private void Start()
	{
	
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

			redPos.transform.position = playerNewPos;
			playerNewPos = bluepos.transform.position;
			
		
			
		}

		 if (!OnOff)
		{
			
			blue.SetActive(false);
			red.SetActive(true);
			bluepos.transform.position = playerNewPos;
			playerNewPos = redPos.transform.position;



		}


	}
}
