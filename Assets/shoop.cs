using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;

public class shoop : MonoBehaviour
{
    [SerializeField]TMP_Text text;
    public CinemachineVirtualCamera cam;
    bool onof;
    bool inside;
    Canvas shoopcanvas;
    PlayerInvetort invetory;
    public int hartoTOCoins;
    public int carrotToCoins;
    public int EmmoToCoins;
    public int coinsToHart;
    public int coinsToEmmo;
    public int coinsToCarrot;
    StarterAssets.ThirdPersonController thirdPersonController;
    shoting Shoting;
    private static shoop instanc;
	// Start is called before the first frame update
	private void Awake()
	{
        inside = false;
       
        shoopcanvas = GameObject.FindGameObjectWithTag("canvas").GetComponent<Canvas>();
    }
    void Start()

    {
      
        invetory = GameObject.FindGameObjectWithTag("invetory").GetComponent<PlayerInvetort>();
       
        shoopcanvas.gameObject.SetActive(false);
        text.enabled = false;
       // inside = false;
        text.text = "press E to Enter shoop";

    }

    // Update is called once per frame
    void Update()
    {
        Shoting = GameObject.FindGameObjectWithTag("shot").GetComponent<shoting>();

        thirdPersonController = GameObject.FindGameObjectWithTag("Player").GetComponent<StarterAssets.ThirdPersonController>();
        Debug.Log(inside);
        if (Input.GetKeyDown(KeyCode.E)&& inside)
        {
            onof = !onof;
            Debug.Log("e");
        }
		if (Input.GetKeyDown(KeyCode.Z)&&inside && invetory.coinscount!=0 &&invetory.numberOfHarts!=4 &&invetory.carrotcount!=0)
		{
            
            invetory.coinscount= invetory.coinscount-coinsToCarrot;
            invetory.carrotcount=invetory.carrotcount+carrotToCoins;
			if (invetory.carrotcount==4)
			{
                invetory.carot[0].gameObject.SetActive(false);
                invetory.carot[1].gameObject.SetActive(false);
                invetory.carot[2].gameObject.SetActive(false);
                invetory.carot[3].gameObject.SetActive(false);
                invetory.carot[4].gameObject.SetActive(false);

            }
            Debug.Log("-2 coins +1 carrot");

		}
		if (Input.GetKeyDown(KeyCode.X) && inside && invetory.coinscount != 0 && invetory.numberOfHarts!=4)
		{
            invetory.numberOfHarts=invetory.numberOfHarts+hartoTOCoins;
            invetory.coinscount = invetory.coinscount - coinsToHart;
			if (invetory.numberOfHarts==4)
			{
                invetory.carot[0].gameObject.SetActive(false);
                invetory.carot[1].gameObject.SetActive(false);
                invetory.carot[2].gameObject.SetActive(false);
                invetory.carot[3].gameObject.SetActive(false);
                invetory.carot[4].gameObject.SetActive(false);


            }
            Debug.Log("-3 coins +1 hart");
        }
        if (Input.GetKeyDown(KeyCode.C) && inside && invetory.coinscount != 0)
        {
            invetory.coinscount = invetory.coinscount - coinsToEmmo;
            invetory.emmo = invetory.emmo + EmmoToCoins;
            Debug.Log("-1 coins +1 emmo");
        }
		
    }
	private void OnTriggerEnter(Collider other)
	{
        text.enabled = true;
        inside = true;
    }
    private void OnTriggerStay(Collider other)
	{

       inside = true;
		if (onof)
		{
           Shoting.shootabol = false;
            thirdPersonController.moveing = false;
           text.enabled = false;
            cam.Priority = 10;
            shoopcanvas.gameObject.SetActive(true);
			
        }
		if (!onof)
		{
            thirdPersonController.moveing = true;
          Shoting.shootabol = true;
            text.enabled = true;
            cam.Priority = 1;
            shoopcanvas.gameObject.SetActive(false);

        }
    }
	private void OnTriggerExit(Collider other)
	{
        text.enabled = false;
        inside = false;
    }


}
