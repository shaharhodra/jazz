using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class PlayerInvetort : MonoBehaviour
{
	public TextMeshProUGUI carootText;
	public TextMeshProUGUI hartText;
	int carrotcount;
	int hartCount;
	int hitCount;
	public int NamberOfCarrot;
	public int numberOfHarts;

	private void Awake()
	{
		carrotcount = 0;
		NamberOfCarrot=0;
		numberOfHarts = 3;
		hitCount = 0;

	}
	private void Start()
	{
		
	}
	public void CarrotCollected()
	{
		carrotcount++;
		if (carrotcount==3)
		{
			numberOfHarts++;
			NamberOfCarrot++;
			carootText.text = NamberOfCarrot.ToString();
			hartText.text = numberOfHarts.ToString();
			carrotcount = 0;
		}
		 
		

		
	}
	public void hartCollected()
	{
		
		numberOfHarts++;
		hartText.text = numberOfHarts.ToString();
	}
	public void playerhit()
	{
		hitCount++;
		if (hitCount==3)
		{
			Debug.Log("hit");

			numberOfHarts--;
			hartText.text = numberOfHarts.ToString();
			hitCount = 0;
		}
		
		
	}
	
}
