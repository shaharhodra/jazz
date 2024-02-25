using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using StarterAssets;

public class ThirdPersonShooterControler : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera aimVirtualcamera;
	[SerializeField] private float normalSensitivity;
	[SerializeField] private float aimlSensitivity;
	public GameObject Player;
	StarterAssetsInputs Input;
	ThirdPersonController Controller;
	
	private void Awake()
	{
	Input=Player.GetComponent<StarterAssets.StarterAssetsInputs>();
	Controller = Player.GetComponent<StarterAssets.ThirdPersonController>();
	}
	// Update is called once per frame
	void Update()
    {

		if (Input.aim)
		{
		
			aimVirtualcamera.gameObject.SetActive(true);
			Controller.setsensitivity(aimlSensitivity);
		}
		else
		{
			aimVirtualcamera.gameObject.SetActive(false);
			Controller.setsensitivity(normalSensitivity);
		}
	}
}
