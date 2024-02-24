using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using StarterAssets;

public class ThirdPersonShooterControler : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera aimVirtualcamera;
    private StarterAssetsInputs starterAssetsInputs;

	private void Awake()
	{
		starterAssetsInputs = GetComponent<StarterAssetsInputs>();
	}
	// Update is called once per frame
	void Update()
    {
		if (starterAssetsInputs.aim)
		{
			Debug.Log("cameraCheck");
			//aimVirtualcamera.gameObject.SetActive(true);
		}
		else
		{
			//aimVirtualcamera.gameObject.SetActive(false);
		}
	}
}
