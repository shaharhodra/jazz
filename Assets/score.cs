using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public float enemyScore;
   
    public GameObject plater;
    // Start is called before the first frame update
    void Start()
    {
        plater = GameObject.Find("PlayerArmature");
       
    }

    // Update is called once per frame
    void Update()
    {
		enemyScore = plater.GetComponent<PlayerInvetort>().numberOfHarts;


		if (enemyScore == 0)
		{
			//code of restart
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
   
}
