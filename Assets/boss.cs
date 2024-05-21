using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    public int bosslife;
    public int hit;
    int numberOfhit;
    public GameObject[] timelines;
    GameObject bullet;
    
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        hit = 0;
        numberOfhit = 2;
        bosslife = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (hit==numberOfhit)
		{
            bosslife--;
            hit = 0;
		}
		if (bosslife==75)
		{
            timelines[0].gameObject.SetActive(false);
            timelines[1].gameObject.SetActive(true);
            Debug.Log("start next face");
            //start next face
		}
		if (bosslife==50)
		{
            timelines[1].gameObject.SetActive(false);
            timelines[2].gameObject.SetActive(true);
        }
        slider.value = bosslife;

    }
    private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("jazzbulet") || other.CompareTag("spazzbulet"))
		{
            hit++;
          
		}
	}
   public void hitcount()
	{
        hit++;
        if (hit == 30)
        {
            bosslife--;
            hit = 0;
        }
    }
    
   
}
