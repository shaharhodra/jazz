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
	[SerializeField] private LayerMask aimLayer;
	[SerializeField] Transform debugTransform;
	[SerializeField] Transform pfBulletOrojectile;
	[SerializeField] Transform spawnBulletPosition;
	public Canvas shotshotCanvas;
	private Animator animator;



	private void Awake()
	{
		
	Input=Player.GetComponent<StarterAssets.StarterAssetsInputs>();
	Controller = Player.GetComponent<StarterAssets.ThirdPersonController>();
	shotshotCanvas.gameObject.SetActive(false);
   // animator.GetComponent<Animator>();

	}

	// Update is called once per frame
	void Update()
    {
		Vector3 mousWorldPosition = Vector3.zero;
		  
		Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
		Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
		if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f, aimLayer))
		{
			debugTransform.position = raycastHit.point;
			mousWorldPosition = raycastHit.point;
		}
		
		if (Input.aim)
		{
			//to activate target
			shotshotCanvas.gameObject.SetActive(true);
			// animetot weight
			//animator.SetLayerWeight(1, Mathf.Lerp(animator.GetLayerWeight(1), 1f, Time.deltaTime * 10f));
			
			aimVirtualcamera.gameObject.SetActive(true);
			Controller.setsensitivity(aimlSensitivity);
			Controller.SetRotationOnMove(false);
			
			Vector3 worldAimTarget = mousWorldPosition;
			worldAimTarget.y = transform.position.y;
			Vector3 aimDerection = (worldAimTarget - transform.position).normalized;
			
			transform.forward = Vector3.Lerp(transform.forward, aimDerection, Time.deltaTime * 20f);
			if (Input.shoot)
			{
				Vector3 aimDir = (mousWorldPosition - spawnBulletPosition.position).normalized;
				Instantiate(pfBulletOrojectile, spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up));

				Input.shoot = false;
			}
		}
		else
		{
			// set wieght animator layer to 0
			//animator.SetLayerWeight(1, Mathf.Lerp(animator.GetLayerWeight(1), 0f, Time.deltaTime * 10f));
			aimVirtualcamera.gameObject.SetActive(false);
			Controller.setsensitivity(normalSensitivity);
			Controller.SetRotationOnMove(true);
			//to disactivate target
			shotshotCanvas.gameObject.SetActive(false);
			// to use the shoting on normal mode

			Vector3 worldAimTarget = mousWorldPosition;
			worldAimTarget.y = transform.position.y;
			Vector3 aimDerection = (worldAimTarget - transform.position).normalized;

			transform.forward = Vector3.Lerp(transform.forward, aimDerection, Time.deltaTime * 20f);
			if (Input.shoot)
			{
				Vector3 aimDir = (mousWorldPosition - spawnBulletPosition.position).normalized;
				Instantiate(pfBulletOrojectile, spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up));

				Input.shoot = false;
			}
		}
	
		
	}
}
