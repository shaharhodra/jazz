using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class ChangingCharacters : MonoBehaviour
{
	public ParticleSystem redsmoke;
	public ParticleSystem bluesmoke;
    public GameObject red;
    public GameObject blue;
	public GameObject redPos;
	public GameObject bluepos;
	private bool keyPressed = false;
	bool OnOff;
	public Vector3 playerNewPos;
	public Quaternion playerNewRotation;
	PlayerInvetort playerInvetort;
	private void Start()
	{
	}
	// Update is called once per frame
	void Update()
    {

		if (Input.GetKeyDown(KeyCode.RightControl))

		{
			OnOff = !OnOff;

		}



		if (OnOff)
		{
			Invoke("jazz",0.5f );
			keyPressed = true;
			//coroutine 0.5 to chanch carector
			StartCoroutine(jazzz());
			//add partical here


		}

		if (!OnOff)
		{

			Invoke("spazz", 0.5f);
			keyPressed = true;
			//coroutine 0.5 to chanch carector
			StartCoroutine(Spazzz());
			//add partical here
		}
		

	}
	void jazz()
	{
		//stop moving
		red.GetComponentInChildren<StarterAssetsInputs>().move = Vector2.zero;
		// stop jumping
		red.GetComponentInChildren<ThirdPersonController>().jumpCount = 4;
		// stop trampolin from jump
		red.GetComponentInChildren<ThirdPersonController>().stopTrampolin();
		red.SetActive(false);

		blue.SetActive(true);
		//on active fix rotation and position
		redPos.transform.position = playerNewPos;
		playerNewPos = bluepos.transform.position;
		redPos.transform.rotation = playerNewRotation;
		playerNewRotation = bluepos.transform.rotation;

	}
    void spazz()
	{

		//stop moving
		blue.GetComponentInChildren<StarterAssetsInputs>().move = Vector2.zero;
		//stop jumping
		blue.GetComponentInChildren<ThirdPersonController>().jumpCount = 2;
		// stop trampolin from jump
		blue.GetComponentInChildren<ThirdPersonController>().stopTrampolin();
		//on active fix rotation and position
		blue.SetActive(false);
		red.SetActive(true);
		bluepos.transform.position = playerNewPos;
		playerNewPos = redPos.transform.position;
		bluepos.transform.rotation = playerNewRotation;
		playerNewRotation = redPos.transform.rotation;
	}
	IEnumerator jazzz()
	{
		red.GetComponentInChildren<StarterAssetsInputs>().move = Vector2.zero;
		yield return new WaitForSeconds(0.5f);
		keyPressed = false;
	}
	IEnumerator Spazzz()
	{
		blue.GetComponentInChildren<StarterAssetsInputs>().move = Vector2.zero;
		yield return new WaitForSeconds(0.5f);
		keyPressed = false;
	}
}
