using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public float enemyScore;
    public TMP_Text _Text;
    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        _Text.text = enemyScore.ToString();
      
		if (enemyScore==0)
		{
            //code of restart
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
   
}
