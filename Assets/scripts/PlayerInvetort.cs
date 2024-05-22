using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInvetort : MonoBehaviour
{
	
	public Image[] carot;
	public Image[] hart;
	public TMP_Text textcoin;
	public TMP_Text textemmo;
	public int carrotcount;
	public int hitCount;
	public int coinscount;
	public int emmo;
	public int maxhart =3;
	[SerializeField]GameObject player;
	public Vector3 lastchecpointpos;
	public int numberOfHarts;
	private CharacterController characterController;
	private void Awake()
	{

		
		emmo = 100;
		carrotcount = 4 ;
		coinscount = 0;
	  numberOfHarts =4;
		hitCount = 0;

	}
	private void Start()
	{
	   
	
		for (int i = 0; i < hart.Length; i++)
		{
			hart[i].gameObject.SetActive(false);

		}
		for (int i = 0; i < carot.Length; i++)
		{
			carot[i].gameObject.SetActive(false);
		}
	}
	private void Update()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		characterController = player.GetComponent<CharacterController>();
		// restart from check point for debuging

		if (Input.GetKeyDown(KeyCode.R))
		{

			characterController.enabled = false;
			player.transform.position = lastchecpointpos;
			characterController.enabled = true;
		}

		textcoin.text = coinscount.ToString();
		textemmo.text = emmo.ToString();

		if (numberOfHarts == 2)
		{
			for (int i = 0; i < hart.Length; i++)
			{
				hart[0].gameObject.SetActive(true);
				hart[1].gameObject.SetActive(false);
				hart[2].gameObject.SetActive(false);

			}



		}
		if (numberOfHarts == 3)
		{
			for (int i = 0; i < hart.Length; i++)
			{
				hart[0].gameObject.SetActive(true);
				hart[1].gameObject.SetActive(true);
				hart[2].gameObject.SetActive(false);
			}

		}
		if (numberOfHarts == 4)
		{
			
			for (int i = 0; i < hart.Length; i++)
			{
				hart[0].gameObject.SetActive(true);
				hart[1].gameObject.SetActive(true);
				hart[2].gameObject.SetActive(true);
			}
			for (int i = 0; i < carot.Length; i++)
			{
				carot[i].gameObject.SetActive(false);
			}
			carrotcount = 0;

		}
		
		if (carrotcount == 1)
		{
			for (int i = 0; i < carot.Length; i++)
			{
				carot[0].gameObject.SetActive(true);
				carot[1].gameObject.SetActive(false);
				carot[2].gameObject.SetActive(false);
				carot[3].gameObject.SetActive(false);
				//carot[4].gameObject.SetActive(false);

			}

		}
		if (carrotcount == 2)
		{
			for (int i = 0; i < carot.Length; i++)
			{
				carot[0].gameObject.SetActive(true);
                carot[1].gameObject.SetActive(true);
				carot[2].gameObject.SetActive(false);
				carot[3].gameObject.SetActive(false);
				//carot[4].gameObject.SetActive(false);

			}
		}
		if (carrotcount == 3)
		{
			for (int i = 0; i < carot.Length; i++)
			{
				carot[0].gameObject.SetActive(true);
				carot[1].gameObject.SetActive(true);
				carot[2].gameObject.SetActive(true);
				carot[3].gameObject.SetActive(false);
				//carot[4].gameObject.SetActive(false);

				
			}
		}
		if (carrotcount == 4)
		{
			for (int i = 0; i < carot.Length; i++)
			{
				carot[0].gameObject.SetActive(true);
				carot[1].gameObject.SetActive(true);
				carot[2].gameObject.SetActive(true);
				carot[3].gameObject.SetActive(true);
				//carot[4].gameObject.SetActive(false);


			}
		}
		if (carrotcount == 5)
			
		{


			numberOfHarts++;

			for (int i = 0; i < carot.Length; i++)
			{
				carot[i].gameObject.SetActive(false);
			}
			carrotcount = 0;
			
		}


	}
	public void CarrotCollected()
	{
		
		if (numberOfHarts<4)
		{
			carrotcount++;
		}
		
		




	}
	public void hartCollected()
	{
		if (numberOfHarts<=maxhart)
		{
			
			numberOfHarts++;

		}


	}
	public void playerhit()
	{

		hitCount++;
		if (hitCount>=3&&carrotcount>0)
		{
		

			carrotcount--;
		
			hitCount = 0;
		}
		if (carrotcount == 0)
		{

			characterController.enabled = false;
			player.transform.position = lastchecpointpos;
			characterController.enabled = true;
		    numberOfHarts--;
	        carrotcount = 4;
		}
		
		if (numberOfHarts==1)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			

		}


	}
	public void coinColected()
	{
		coinscount++;
	}
	
}
